﻿// This file is generated by ItemWrapper.Generator. Do not modify this file as it will be regenerated
namespace LogicCircuit {
	using System;
	using System.Collections.Generic;
	using System.Collections.Specialized;
	using System.ComponentModel;
	using System.Diagnostics;
	using System.Globalization;
	using System.Linq;
	using System.Text;
	using LogicCircuit.DataPersistent;

	// Defines the shape of the table Gate
	internal partial struct GateData {
		public Guid GateId;
		internal Gate? Gate;
		// Field accessors
		// Accessor of the GateId field
		public sealed class GateIdField : IField<GateData, Guid> {
			public static readonly GateIdField Field = new GateIdField();
			private GateIdField() {}
			public string Name { get { return "GateId"; } }
			public int Order { get; set; }
			public Guid DefaultValue { get { return default; } }
			public Guid GetValue(ref GateData record) {
				return record.GateId;
			}
			public void SetValue(ref GateData record, Guid value) {
				record.GateId = value;
			}
			public int Compare(ref GateData l, ref GateData r) {
				return l.GateId.CompareTo(r.GateId);
			}
			public int Compare(Guid l, Guid r) {
				return l.CompareTo(r);
			}
		}

		// Special field used to access items wrapper of this record from record.
		// This is used when no other universes is used
		internal sealed class GateField : IField<GateData, Gate> {
			public static readonly GateField Field = new GateField();
			private GateField() {}
			public string Name { get { return "GateWrapper"; } }
			public int Order { get; set; }
			public Gate DefaultValue { get { return null!; } }
			public Gate GetValue(ref GateData record) {
				return record.Gate!;
			}
			public void SetValue(ref GateData record, Gate value) {
				record.Gate = value;
			}
			public int Compare(ref GateData l, ref GateData r) {
				return this.Compare(l.Gate, r.Gate);
			}
			public int Compare(Gate? l, Gate? r) {
				if(object.ReferenceEquals(l, r)) return 0;
				if(l == null) return -1;
				if(r == null) return 1;
				return l.GateRowId.CompareTo(r.GateRowId);
			}
		}

		private static readonly IField<GateData>[] fields = {
			GateIdField.Field,
			GateField.Field
		};

		// Creates table.
		public static TableSnapshot<GateData> CreateTable(StoreSnapshot store) {
			TableSnapshot<GateData> table = new TableSnapshot<GateData>(store, "Gate", GateData.fields);
			// Create all but foreign keys of the table
			table.MakeUnique("PK_Gate", GateData.GateIdField.Field , true);
			// Return created table
			return table;
		}

		// Creates all foreign keys of the table
		public static void CreateForeignKeys(StoreSnapshot store) {
			TableSnapshot<GateData>? table = (TableSnapshot<GateData>?)store.Table("Gate");
			Debug.Assert(table != null);
			table.CreateForeignKey("PK_Gate", store.Table("Circuit"), GateData.GateIdField.Field, ForeignKeyAction.Cascade, false);
		}
	}

	// Class wrapper for a record.
	partial class Gate : Circuit {

		// RowId of the wrapped record
		internal RowId GateRowId { get; private set; }

		// Constructor
		#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
		public Gate(CircuitProject store, RowId rowIdGate, RowId rowIdCircuit) : base(store, rowIdCircuit) {
			Debug.Assert(!rowIdGate.IsEmpty);
			this.GateRowId = rowIdGate;
			// Link back to record. Assuming that a transaction is started
			this.Table.SetField(this.GateRowId, GateData.GateField.Field, this);
			this.InitializeGate();
		}
		#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

		partial void InitializeGate();

		// Gets table storing this item.
		private TableSnapshot<GateData> Table { get { return this.CircuitProject.GateSet.Table; } }


		//Properties of Gate

		// Gets value of the GateId field.
		public Guid GateId {
			get { return this.Table.GetField(this.GateRowId, GateData.GateIdField.Field); }
		}


		internal void NotifyChanged(TableChange<GateData> change) {
			if(this.HasListener) {
				GateData oldData, newData;
				change.GetOldData(out oldData);
				change.GetNewData(out newData);
				if(GateData.GateIdField.Field.Compare(ref oldData, ref newData) != 0) {
					this.NotifyPropertyChanged("GateId");
				}
			}
			this.OnGateChanged();
		}

		partial void OnGateChanged();
	}


	// Wrapper for table Gate.
	partial class GateSet : INotifyCollectionChanged, IEnumerable<Gate> {

		public event NotifyCollectionChangedEventHandler? CollectionChanged;

		internal TableSnapshot<GateData> Table { get; private set; }

		// Gets StoreSnapshot this set belongs to.
		public CircuitProject CircuitProject { get { return (CircuitProject)this.Table.StoreSnapshot; } }

		// Constructor
		#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
		public GateSet(CircuitProject store) {
			ITableSnapshot? table = store.Table("Gate");
			if(table != null) {
				Debug.Assert(store.IsFrozen, "The store should be frozen");
				this.Table = (TableSnapshot<GateData>)table;
			} else {
				Debug.Assert(!store.IsFrozen, "In order to create table, the store should not be frozen");
				this.Table = GateData.CreateTable(store);
			}
			this.InitializeGateSet();
		}
		#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

		partial void InitializeGateSet();

		//internal void Register() {
		//	foreach(RowId rowId in this.Table.Rows) {
		//		this.FindOrCreate(rowId);
		//	}
		//}


		// gets items wrapper by RowId
		public Gate? Find(RowId rowId) {
			if(!rowId.IsEmpty) {
				return this.Table.GetField(rowId, GateData.GateField.Field);
			}
			return null;
		}


		// gets items wrapper by RowId
		private IEnumerable<Gate> Select(IEnumerable<RowId> rows) {
			foreach(RowId rowId in rows) {
				Gate? item = this.Find(rowId);
				Debug.Assert(item != null, "What is the reason for the item not to be found?");
				yield return item;
			}
		}

		// Create wrapper for the row and register it in the dictionary
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Performance", "CA1822:Mark members as static")]
		private Gate Create(RowId rowId, RowId CircuitRowId) {
			Gate item = new Gate(this.CircuitProject, rowId, CircuitRowId);
			return item;
		}

		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1506:AvoidExcessiveClassCoupling")]
		internal Gate FindOrCreate(RowId rowId) {
			Debug.Assert(!rowId.IsEmpty && !this.Table.IsDeleted(rowId), "Bad RowId");
			Gate? item;
			if((item = this.Find(rowId)) != null) {
				Debug.Assert(!item.IsDeleted(), "Deleted item should not be present in the dictionary");
				return item;
			}
			Guid primaryKeyValue = this.Table.GetField(rowId, GateData.GateIdField.Field);


			TableSnapshot<CircuitData>? tableCircuit = (TableSnapshot<CircuitData>?)this.CircuitProject.Table("Circuit");
			Debug.Assert(tableCircuit != null);
			return this.Create(rowId, tableCircuit.Find(CircuitData.CircuitIdField.Field, primaryKeyValue));
		}

		// Creates Gate wrapper
		private Gate CreateItem(
			// Fields of Gate table
			Guid GateId
			// Fields of Circuit table

		) {
			TableSnapshot<CircuitData>? tableCircuit = (TableSnapshot<CircuitData>?)this.CircuitProject.Table("Circuit");
			Debug.Assert(tableCircuit != null);
			CircuitData dataCircuit = new CircuitData() {
				CircuitId = GateId
			};
			RowId rowIdCircuit = tableCircuit.Insert(ref dataCircuit);

			GateData dataGate = new GateData() {
				GateId = GateId,
			};
			return this.Create(this.Table.Insert(ref dataGate), rowIdCircuit);
		}

		// Search helpers

		// Finds Gate by GateId
		public Gate? FindByGateId(Guid gateId) {
			return this.Find(this.Table.Find(GateData.GateIdField.Field, gateId));
		}

		public IEnumerator<Gate> GetEnumerator() {
			return this.Select(this.Table.Rows).GetEnumerator();
		}

		System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() {
			return this.GetEnumerator();
		}

		private void NotifyCollectionChanged(NotifyCollectionChangedEventArgs arg) {
			NotifyCollectionChangedEventHandler? handler = this.CollectionChanged;
			if(handler != null) {
				handler(this, arg);
			}
		}

		internal List<Gate>? UpdateSet(int oldVersion, int newVersion) {
			IEnumerator<TableChange<GateData>>? change = this.Table.GetVersionChangeChanges(oldVersion, newVersion);
			if(change != null) {
				bool handlerAttached = (this.CollectionChanged != null);
				List<Gate>? del = (handlerAttached) ? new List<Gate>() : null;
				while(change.MoveNext()) {
					switch(change.Current.Action) {
					case SnapTableAction.Insert:
						this.FindOrCreate(change.Current.RowId);
						Debug.Assert(this.Find(change.Current.RowId) != null, "Why the item was not created?");
						break;
					case SnapTableAction.Delete:
						if(handlerAttached) {
							Gate item = change.Current.GetOldField(GateData.GateField.Field);
							Debug.Assert(item.IsDeleted());
							del!.Add(item);
						}
						break;
					default:
						Debug.Assert(change.Current.Action == SnapTableAction.Update, "Unknown action");
						Debug.Assert(this.Find(change.Current.RowId) != null, "Why the item does not exist during update?");
						break;
					}
				}
				change.Dispose();
				return del;
			}
			return null;
		}

		internal void NotifyVersionChanged(int oldVersion, int newVersion, List<Gate>? deleted) {
			IEnumerator<TableChange<GateData>>? change = this.Table.GetVersionChangeChanges(oldVersion, newVersion);
			if(change != null) {
				bool handlerAttached = (this.CollectionChanged != null);
				List<Gate>? add = (handlerAttached) ? new List<Gate>() : null;
				this.StartNotifyGateSetChanged(oldVersion, newVersion);
				while(change.MoveNext()) {
					this.NotifyGateSetChanged(change.Current);
					switch(change.Current.Action) {
					case SnapTableAction.Insert:
						Debug.Assert(this.Find(change.Current.RowId) != null, "Why the item was not created?");
						if(handlerAttached) {
							add!.Add(this.Find(change.Current.RowId)!);
						}
						break;
					case SnapTableAction.Delete:
						Debug.Assert(change.Current.GetOldField(GateData.GateField.Field).IsDeleted(), "Why the item still exists?");
						break;
					default:
						Debug.Assert(change.Current.Action == SnapTableAction.Update, "Unknown action");
						Debug.Assert(this.Find(change.Current.RowId) != null, "Why the item does not exist during update?");
						this.Find(change.Current.RowId)!.NotifyChanged(change.Current);
						break;
					}
				}
				change.Dispose();
				if(handlerAttached) {
					if(deleted != null && 0 < deleted.Count) {
						this.NotifyCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Remove, deleted));
					}
					if(0 < add!.Count) {
						this.NotifyCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Add, add));
					}
				}
				this.EndNotifyGateSetChanged();
			}
		}

		partial void StartNotifyGateSetChanged(int oldVersion, int newVersion);
		partial void EndNotifyGateSetChanged();
		partial void NotifyGateSetChanged(TableChange<GateData> change);

		internal void NotifyRolledBack(int version) {
			if(this.Table.WasAffected(version)) {
				IEnumerator<RowId> change = this.Table.GetRolledBackChanges(version);
				if(change != null) {
					while(change.MoveNext()) {
						RowId rowId = change.Current;
						if(this.Table.IsDeleted(rowId)) {
						} else {
							this.FindOrCreate(rowId);
						}
					}
					change.Dispose();
				}
			}
		}
	}

}
