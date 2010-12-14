﻿using System;
using System.Windows;
using System.Windows.Shapes;

namespace LogicCircuit {
	partial class Editor {
		private class WirePledge : Marker {
			public Line MarkerLine { get; private set; }
			public GridPoint Point1 { get { return Symbol.GridPoint(new Point(this.MarkerLine.X1, this.MarkerLine.Y1)); } }
			public GridPoint Point2 { get { return Symbol.GridPoint(new Point(this.MarkerLine.X2, this.MarkerLine.Y2)); } }

			public WirePledge(Point point) {
				Point start = Symbol.ScreenPoint(Symbol.GridPoint(point));
				this.MarkerLine = new Line() {
					X1 = start.X,
					Y1 = start.Y,
					X2 = point.X,
					Y2 = point.Y,
					DataContext = this,
					Stroke = Symbol.WireStroke,
					StrokeThickness = 1,
				};
			}
			
			public override Symbol Symbol { get { throw new InvalidOperationException(); } }

			public override FrameworkElement Glyph { get { return this.MarkerLine; } }

			public override void Move(Editor editor, Point point) {
				this.MarkerLine.X2 = point.X;
				this.MarkerLine.Y2 = point.Y;
			}

			public override void Commit(Editor editor, Point point) {
			}
		}
	}
}
