using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;

namespace LogicCircuit {
	internal class WireValidator {
		private static Thread? thread;
		private static AutoResetEvent? updateRequest;
		private static WireValidator? wireValidator;

		private bool running;
		private bool stopPending;

		private readonly HashSet<Wire> badWires = new HashSet<Wire>();
		private readonly EditorDiagram diagram;
		private LogicalCircuit? logicalCircuit;
		private int version;

		public WireValidator(EditorDiagram diagram) {
			this.diagram = diagram;
			if(WireValidator.thread == null) {
				Thread attempt = new Thread(new ThreadStart(WireValidator.Run)) {
					Name = nameof(WireValidator),
					IsBackground = true,
					Priority = ThreadPriority.BelowNormal
				};
				if(null == Interlocked.CompareExchange(ref WireValidator.thread, attempt, null)) {
					WireValidator.updateRequest = new AutoResetEvent(false);
					WireValidator.thread.Start();
				}
			}
			WireValidator.wireValidator = this;
		}

		private HashSet<Wire>? Bad(LogicalCircuit current) {
			Dictionary<GridPoint, List<Jam>> jams = new Dictionary<GridPoint, List<Jam>>();

			IEnumerable<Jam> connected(Conductor conductor) {
				IEnumerable<Jam> at(GridPoint point) {
					List<Jam>? list;
					if(jams.TryGetValue(point, out list)) {
						return list;
					}
					return Enumerable.Empty<Jam>();
				}

				return conductor.Points.SelectMany(point => at(point));
			}

			foreach(CircuitSymbol symbol in current.CircuitSymbols()) {
                if (!(symbol.Circuit is CircuitProbe)) {
					foreach(Jam jam in symbol.Jams()) {
						if(this.stopPending) return null;
						GridPoint point = jam.AbsolutePoint;
						List<Jam>? list;
						if(!jams.TryGetValue(point, out list)) {
							list = new List<Jam>(1);
							jams.Add(point, list);
						}
						list.Add(jam);
					}
				}
			}

			HashSet<Wire> bad = new HashSet<Wire>();
			foreach(Conductor conductor in current.ConductorMap().Conductors) {
                int first = 0;
				int count = 0;

                foreach (Jam jam in connected(conductor)) {
					count++;

					if (this.stopPending) return null;
					if (first == 0) {
						first = jam.Pin.BitWidth;
					}
					else {
						if (first != jam.Pin.BitWidth) {
							bad.UnionWith(conductor.Wires);
							break;
						}
					}
				}

				// Check if wire is connected only to one thing (not connecting two or more things together)
                if (count <= 1) {
                    bad.UnionWith(conductor.Wires);
                }

				// Check if wire is dangling
				List<GridPoint> allPoints = conductor.Wires.SelectMany(c => new[] {c.Point1, c.Point2}).ToList();
				foreach (Wire wire in conductor.Wires) {
					foreach (GridPoint point in new[] {wire.Point1, wire.Point2}) {
						// wire is hanging when one end is not connected to any jam or other wires
                        if (allPoints.Count(x => x == point) == 1 && jams.TryGetValue(point, out _) == false) {
                            bad.Add(wire);
                            break;
                        }
                    }
				}

                if (this.stopPending) return null;
			}

			return bad;
		}

		private void UpdateCurrent() {
			//Debug.Print("<<< starting UpdateCurrent");
			try {
				this.running = true;
				LogicalCircuit current = this.diagram.CircuitProject.ProjectSet.Project.LogicalCircuit;
				int currentVersion = this.diagram.CircuitProject.Version;

				HashSet<Wire>? bad = this.Bad(current);
				void redraw() {
					List<Wire> list = current.Wires().Except(bad).ToList();
					//List<Wire> list = this.badWires.Except(bad).ToList();
					foreach(Wire wire in list.Where(w => !w.IsDeleted())) {
						if(this.stopPending) return;
						wire.WireGlyph.Stroke = Symbol.WireStroke;
                        wire.WireGlyph.StrokeThickness = 1;
                    }
					this.badWires.ExceptWith(list);
					foreach(Wire wire in bad.Where(w => !this.badWires.Contains(w))) {
						if(this.stopPending) return;
						this.badWires.Add(wire);
						wire.WireGlyph.Stroke = Symbol.BadWireStroke;
						wire.WireGlyph.StrokeThickness = 2;

                    }
				}
				if(this.logicalCircuit != current) {
					this.badWires.Clear();
				}
				if(!this.stopPending && bad != null) {
					App.Dispatch(redraw);
					this.logicalCircuit = current;
				}
				if(!this.stopPending) {
					this.version = currentVersion;
				}
			} catch(Exception exception) {
				App.Mainframe.ReportException(exception);
			} finally {
				this.running = false;
				//Debug.Print(">>> ending UpdateCurrent");
			}
		}

		private static void Run() {
			Debug.Assert(WireValidator.updateRequest != null && WireValidator.wireValidator != null);
			try {
				for(;;) {
					WireValidator.updateRequest.WaitOne();
					WireValidator.wireValidator.UpdateCurrent();
				}
			} catch(Exception exception) {
				App.Mainframe.ReportException(exception);
			}
		}

		public void Update() {
			if(this.diagram.InEditMode && this.version != this.diagram.CircuitProject.Version) {
				Debug.Assert(WireValidator.updateRequest != null);
				if(this.running) {
					this.stopPending = true;
				}
				while(this.running) {
					Thread.Sleep(0);
				}
				this.stopPending = false;
				WireValidator.updateRequest.Set();
			}
		}

		public void Reset() {
			this.stopPending = true;
			this.version = 0;
			this.badWires.Clear();
		}
	}
}
