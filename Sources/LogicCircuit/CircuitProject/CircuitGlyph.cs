﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace LogicCircuit {
	public abstract class CircuitGlyph : Symbol {
		
		private List<Jam>[] jams;
		private bool isUpdated;

		public abstract Circuit Circuit { get; }
		public abstract GridPoint Point { get; set; }

		private FrameworkElement glyph = null;

		public override FrameworkElement Glyph {
			get { return this.glyph ?? (this.glyph = this.Circuit.CreateGlyph(this)); }
		}

		public void Reset() {
			this.glyph = null;
		}

		public void GuaranteeGlyph() {
			if(this.glyph == null) {
				this.glyph = this.Circuit.CreateGlyph(this);
			}
		}

		public abstract void Invalidate();

		public FrameworkElement ProbeView { get; set; }

		protected CircuitGlyph() : base() {
		}

		private IList<Jam> Left {
			get {
				this.Update();
				return this.jams[(int)PinSide.Left];
			}
		}
		private IList<Jam> Top {
			get {
				this.Update();
				return this.jams[(int)PinSide.Top];
			}
		}
		private IList<Jam> Right {
			get {
				this.Update();
				return this.jams[(int)PinSide.Right];
			}
		}
		private IList<Jam> Bottom {
			get {
				this.Update();
				return this.jams[(int)PinSide.Bottom];
			}
		}

		public IEnumerable<Jam> Jams() {
			return this.Left.Concat(this.Top).Concat(this.Right).Concat(this.Bottom);
		}

		public void ResetJams() {
			this.isUpdated = false;
			//this.NotifyPropertyChanged("Left");
			//this.NotifyPropertyChanged("Top");
			//this.NotifyPropertyChanged("Right");
			//this.NotifyPropertyChanged("Bottom");
			//this.NotifyPropertyChanged("Glyph");
			this.Invalidate();
		}

		private void Update() {
			if(!this.isUpdated) {
				if(this.jams == null) {
					this.jams = new List<Jam>[] { new List<Jam>(), new List<Jam>(), new List<Jam>(), new List<Jam>() };
				} else {
					foreach(List<Jam> j in this.jams) {
						j.Clear();
					}
				}
				IList<Jam> list = this.jams[(int)PinSide.Left];
				foreach(BasePin pin in this.Circuit.Left) {
					list.Add(new JamItem(pin, this));
				}
				list = this.jams[(int)PinSide.Top];
				foreach(BasePin pin in this.Circuit.Top) {
					list.Add(new JamItem(pin, this));
				}
				list = this.jams[(int)PinSide.Right];
				foreach(BasePin pin in this.Circuit.Right) {
					list.Add(new JamItem(pin, this));
				}
				list = this.jams[(int)PinSide.Bottom];
				foreach(BasePin pin in this.Circuit.Bottom) {
					list.Add(new JamItem(pin, this));
				}
				this.isUpdated = true;
			}
		}

		private static FrameworkElement Skin(Canvas canvas, string skinText) {
			FrameworkElement shape = Symbol.Skin(skinText);
			shape.Width = canvas.Width;
			shape.Height = canvas.Height;
			canvas.Children.Add(shape);
			Panel.SetZIndex(shape, 0);
			return shape;
		}

		private static bool AddJam(Canvas canvas, IEnumerable<Jam> list, Action<Jam, TextBlock> notationPosition) {
			bool hasNotation = false;
			foreach(Jam jam in list) {
				Ellipse ellipse = new Ellipse();
				ellipse.DataContext = jam;
				ellipse.Width = ellipse.Height = Symbol.PinRadius * 2;
				Canvas.SetLeft(ellipse, Symbol.ScreenPoint(jam.X) - Symbol.PinRadius);
				Canvas.SetTop(ellipse, Symbol.ScreenPoint(jam.Y) - Symbol.PinRadius);
				canvas.Children.Add(ellipse);
				if(jam.Pin.Inverted) {
					ellipse.Fill = Symbol.JamInvertedFill;
					ellipse.Stroke = Symbol.JamStroke;
					ellipse.StrokeThickness = 1;
					Panel.SetZIndex(ellipse, 1);
				} else {
					ellipse.Fill = Symbol.JamDirectFill;
					Panel.SetZIndex(ellipse, -1);
				}
				ellipse.ToolTip = jam.Pin.ToolTip;
				string jamNotation = jam.Pin.JamNotation;
				if(!string.IsNullOrEmpty(jamNotation)) {
					Tracer.Assert(notationPosition != null); // If pin has notation then it should belong to rectangualry rendering circuit.
					TextBlock text = new TextBlock();
					text.Foreground = Brushes.Black;
					int len = (jam.Pin.PinSide == PinSide.Top || jam.Pin.PinSide == PinSide.Bottom) ? 4 : 2;
					text.Text = jamNotation.Substring(0, Math.Min(len, jamNotation.Length));
					text.ToolTip = jam.Pin.ToolTip;
					text.FontSize = 8;
					Panel.SetZIndex(text, 1);
					notationPosition(jam, text);
					canvas.Children.Add(text);
					hasNotation = true;
				}
			}
			return hasNotation;
		}

		private Canvas CreateGlyphCanvas() {
			Canvas canvas = new Canvas();
			Panel.SetZIndex(canvas, 1);
			canvas.DataContext = this;
			canvas.Width = Symbol.ScreenPoint(this.Circuit.SymbolWidth);
			canvas.Height = Symbol.ScreenPoint(this.Circuit.SymbolHeight);
			canvas.ToolTip = this.Circuit.ToolTip;
			return canvas;
		}

		public FrameworkElement CreateButtonGlyph() {
			Tracer.Assert(this.Circuit is CircuitButton);
			Canvas canvas = this.CreateGlyphCanvas();
			CircuitGlyph.AddJam(canvas, this.Jams(), null);
			ButtonControl buttonControl = new ButtonControl();
			buttonControl.Content = this.Circuit.Notation;
			buttonControl.Width = canvas.Width;
			buttonControl.Height = canvas.Height;
			canvas.Children.Add(buttonControl);
			this.ProbeView = buttonControl;
			return canvas;
		}

		public FrameworkElement CreateSimpleGlyph(string skin) {
			Canvas canvas = this.CreateGlyphCanvas();
			CircuitGlyph.AddJam(canvas, this.Jams(), null);
			FrameworkElement shape = CircuitGlyph.Skin(canvas, skin);
			FrameworkElement probeView = shape.FindName("ProbeView") as FrameworkElement;
			if(probeView != null) {
				this.ProbeView = probeView;
				TextBlock textBlock = probeView as TextBlock;
				if(textBlock != null) {
					textBlock.Text = this.Circuit.Notation;
				}
			}
			return canvas;
		}

		public FrameworkElement CreateRectangularGlyph() {
			Canvas canvas = this.CreateGlyphCanvas();
			canvas.Background = Symbol.CircuitFill;
			bool ln = CircuitGlyph.AddJam(canvas, this.Left, (j, t) => { Canvas.SetLeft(t, Symbol.PinRadius); Canvas.SetTop(t, Symbol.ScreenPoint(j.Y) - 2 * Symbol.PinRadius); });
			bool tn = CircuitGlyph.AddJam(canvas, this.Top, (j, t) => { Canvas.SetLeft(t, Symbol.ScreenPoint(j.X) - Symbol.PinRadius); Canvas.SetTop(t, Symbol.PinRadius); });
			bool rn = CircuitGlyph.AddJam(canvas, this.Right, (j, t) => { Canvas.SetRight(t, Symbol.PinRadius); Canvas.SetTop(t, Symbol.ScreenPoint(j.Y) - 2 * Symbol.PinRadius); });
			bool bn = CircuitGlyph.AddJam(canvas, this.Bottom, (j, t) => { Canvas.SetLeft(t, Symbol.ScreenPoint(j.X) - Symbol.PinRadius); Canvas.SetBottom(t, Symbol.PinRadius); });
			FrameworkElement shape = CircuitGlyph.Skin(canvas, SymbolShape.Rectangular);
			TextBlock text = shape.FindName("Notation") as TextBlock;
			if(text != null) {
				text.Margin = new Thickness(ln ? 10 : 5, tn ? 10 : 5, rn ? 10 : 5, bn ? 10 : 5);
				text.Text = this.Circuit.Notation;
			}
			return canvas;
		}

		public FrameworkElement CreateShapedGlyph(string skin) {
			Gate gate = this.Circuit as Gate;
			Tracer.Assert(gate != null);
			Canvas canvas = this.CreateGlyphCanvas();
			CircuitGlyph.AddJam(canvas, this.Jams(), null);
			FrameworkElement shape = CircuitGlyph.Skin(canvas, skin);
			int top = Math.Max(0, gate.InputCount - 3) / 2;
			int bottom = Math.Max(0, gate.InputCount - 3 - top);
			Rectangle topLine = shape.FindName("topLine") as Rectangle;
			if(topLine != null) {
				topLine.Height = Symbol.ScreenPoint(top);
			}
			Rectangle bottomLine = shape.FindName("bottomLine") as Rectangle;
			if(bottomLine != null) {
				bottomLine.Height = Symbol.ScreenPoint(bottom);
			}
			return canvas;
		}

		private class JamItem : Jam {
			public JamItem(BasePin pin, CircuitGlyph symbol) {
				this.Pin = pin;
				this.CircuitSymbol = symbol;
			}
		}
	}
}
