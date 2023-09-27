using System;
using System.Collections.Generic;

namespace LogicCircuit {
	public class FunctionLedMatrixIndividual : FunctionLedMatrix {
		private readonly int[] state;
		private LogicalCircuit? lastLogicalCircuit;

		public FunctionLedMatrixIndividual(CircuitState circuitState, IEnumerable<CircuitSymbol> symbols, int[] parameter) : base(circuitState, symbols, parameter) {
			LedMatrix matrix = this.Matrix;
			this.state = new int[matrix.Rows * matrix.Columns];
		}

		public override void Redraw() {
			LogicalCircuit current = this.CurrentLogicalCircuit;
			// making this unconditional fixes matrix not updating when switching to a different instance of the same circuit
			// it also makes matrices update every tick
			// this can be improved by making it check if current is the same instance of circuit instead
			// i don't care enough though
			if(true || current != this.lastLogicalCircuit) {
				this.lastLogicalCircuit = current;
				for(int i = 0; i < this.state.Length; i++) {
					this.state[i] = -1;
				}
			}
			for(int i = 0; i < this.state.Length; i++) {
				int value = 0;
				for(int j = 0; j < this.BitPerLed; j++) {
					if(this[i * this.BitPerLed + j] == State.On1) {
						value |= 1 << j;
					}
				}
				if(this.state[i] != value) {
					this.state[i] = value;
					this.Fill(i, value);
				}
			}
		}
	}
}
