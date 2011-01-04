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
	using System.Xml;
	using LogicCircuit.DataPersistent;

	// Defines the shape of the table DevicePin
	internal partial struct DevicePinData {
		public Guid PinId;
		public Guid CircuitId;
		private int fieldBitWidth;
		public int BitWidth {
			get { return this.fieldBitWidth; }
			set { this.fieldBitWidth = BasePin.CheckBitWidth(value); }
		}
		public PinType PinType;
		public PinSide PinSide;
		public bool Inverted;
		public string Name;
		public string Note;
		public string JamNotation;
		internal DevicePin DevicePin;

		// Field accessors

		// Accessor of the PinId field
		public sealed class PinIdField : IField<DevicePinData, Guid> {
			public static readonly PinIdField Field = new PinIdField();
			private PinIdField() {}
			public string Name { get { return "PinId"; } }
			public int Order { get; set; }
			public Guid DefaultValue { get { return default(Guid); } }
			public Guid GetValue(ref DevicePinData record) {
				return record.PinId;
			}
			public void SetValue(ref DevicePinData record, Guid value) {
				record.PinId = value;
			}
			public int Compare(ref DevicePinData l, ref DevicePinData r) {
				return l.PinId.CompareTo(r.PinId);
			}
			public int Compare(Guid l, Guid r) {
				return l.CompareTo(r);
			}
		}

		// Accessor of the CircuitId field
		public sealed class CircuitIdField : IField<DevicePinData, Guid> {
			public static readonly CircuitIdField Field = new CircuitIdField();
			private CircuitIdField() {}
			public string Name { get { return "CircuitId"; } }
			public int Order { get; set; }
			public Guid DefaultValue { get { return default(Guid); } }
			public Guid GetValue(ref DevicePinData record) {
				return record.CircuitId;
			}
			public void SetValue(ref DevicePinData record, Guid value) {
				record.CircuitId = value;
			}
			public int Compare(ref DevicePinData l, ref DevicePinData r) {
				return l.CircuitId.CompareTo(r.CircuitId);
			}
			public int Compare(Guid l, Guid r) {
				return l.CompareTo(r);
			}
		}

		// Accessor of the BitWidth field
		public sealed class BitWidthField : IField<DevicePinData, int> {
			public static readonly BitWidthField Field = new BitWidthField();
			private BitWidthField() {}
			public string Name { get { return "BitWidth"; } }
			public int Order { get; set; }
			public int DefaultValue { get { return 1; } }
			public int GetValue(ref DevicePinData record) {
				return record.BitWidth;
			}
			public void SetValue(ref DevicePinData record, int value) {
				record.BitWidth = value;
			}
			public int Compare(ref DevicePinData l, ref DevicePinData r) {
				return Math.Sign((long)l.BitWidth - (long)r.BitWidth);
			}
			public int Compare(int l, int r) {
				return Math.Sign((long)l - (long)r);
			}
		}

		// Accessor of the PinType field
		public sealed class PinTypeField : IField<DevicePinData, PinType> {
			public static readonly PinTypeField Field = new PinTypeField();
			private PinTypeField() {}
			public string Name { get { return "PinType"; } }
			public int Order { get; set; }
			public PinType DefaultValue { get { return PinType.Input; } }
			public PinType GetValue(ref DevicePinData record) {
				return record.PinType;
			}
			public void SetValue(ref DevicePinData record, PinType value) {
				record.PinType = value;
			}
			public int Compare(ref DevicePinData l, ref DevicePinData r) {
				return l.PinType.CompareTo(r.PinType);
			}
			public int Compare(PinType l, PinType r) {
				return l.CompareTo(r);
			}
		}

		// Accessor of the PinSide field
		public sealed class PinSideField : IField<DevicePinData, PinSide> {
			public static readonly PinSideField Field = new PinSideField();
			private PinSideField() {}
			public string Name { get { return "PinSide"; } }
			public int Order { get; set; }
			public PinSide DefaultValue { get { return PinSide.Left; } }
			public PinSide GetValue(ref DevicePinData record) {
				return record.PinSide;
			}
			public void SetValue(ref DevicePinData record, PinSide value) {
				record.PinSide = value;
			}
			public int Compare(ref DevicePinData l, ref DevicePinData r) {
				return l.PinSide.CompareTo(r.PinSide);
			}
			public int Compare(PinSide l, PinSide r) {
				return l.CompareTo(r);
			}
		}

		// Accessor of the Inverted field
		public sealed class InvertedField : IField<DevicePinData, bool> {
			public static readonly InvertedField Field = new InvertedField();
			private InvertedField() {}
			public string Name { get { return "Inverted"; } }
			public int Order { get; set; }
			public bool DefaultValue { get { return false; } }
			public bool GetValue(ref DevicePinData record) {
				return record.Inverted;
			}
			public void SetValue(ref DevicePinData record, bool value) {
				record.Inverted = value;
			}
			public int Compare(ref DevicePinData l, ref DevicePinData r) {
				return l.Inverted.CompareTo(r.Inverted);
			}
			public int Compare(bool l, bool r) {
				return l.CompareTo(r);
			}
		}

		// Accessor of the Name field
		public sealed class NameField : IField<DevicePinData, string> {
			public static readonly NameField Field = new NameField();
			private NameField() {}
			public string Name { get { return "Name"; } }
			public int Order { get; set; }
			public string DefaultValue { get { return null; } }
			public string GetValue(ref DevicePinData record) {
				return record.Name;
			}
			public void SetValue(ref DevicePinData record, string value) {
				record.Name = value;
			}
			public int Compare(ref DevicePinData l, ref DevicePinData r) {
				return StringComparer.Ordinal.Compare(l.Name, r.Name);
			}
			public int Compare(string l, string r) {
				return StringComparer.Ordinal.Compare(l, r);
			}
		}

		// Accessor of the Note field
		public sealed class NoteField : IField<DevicePinData, string> {
			public static readonly NoteField Field = new NoteField();
			private NoteField() {}
			public string Name { get { return "Note"; } }
			public int Order { get; set; }
			public string DefaultValue { get { return ""; } }
			public string GetValue(ref DevicePinData record) {
				return record.Note;
			}
			public void SetValue(ref DevicePinData record, string value) {
				record.Note = value;
			}
			public int Compare(ref DevicePinData l, ref DevicePinData r) {
				return StringComparer.Ordinal.Compare(l.Note, r.Note);
			}
			public int Compare(string l, string r) {
				return StringComparer.Ordinal.Compare(l, r);
			}
		}

		// Accessor of the JamNotation field
		public sealed class JamNotationField : IField<DevicePinData, string> {
			public static readonly JamNotationField Field = new JamNotationField();
			private JamNotationField() {}
			public string Name { get { return "JamNotation"; } }
			public int Order { get; set; }
			public string DefaultValue { get { return ""; } }
			public string GetValue(ref DevicePinData record) {
				return record.JamNotation;
			}
			public void SetValue(ref DevicePinData record, string value) {
				record.JamNotation = value;
			}
			public int Compare(ref DevicePinData l, ref DevicePinData r) {
				return StringComparer.Ordinal.Compare(l.JamNotation, r.JamNotation);
			}
			public int Compare(string l, string r) {
				return StringComparer.Ordinal.Compare(l, r);
			}
		}

		// Special field used to access items wrapper of this record from record.
		// This is used when no other universes is used
		internal sealed class DevicePinField : IField<DevicePinData, DevicePin> {
			public static readonly DevicePinField Field = new DevicePinField();
			private DevicePinField() {}
			public string Name { get { return "DevicePinWrapper"; } }
			public int Order { get; set; }
			public DevicePin DefaultValue { get { return null; } }
			public DevicePin GetValue(ref DevicePinData record) {
				return record.DevicePin;
			}
			public void SetValue(ref DevicePinData record, DevicePin value) {
				record.DevicePin = value;
			}
			public int Compare(ref DevicePinData l, ref DevicePinData r) {
				return this.Compare(l.DevicePin, r.DevicePin);
			}
			public int Compare(DevicePin l, DevicePin r) {
				if(object.ReferenceEquals(l, r)) return 0;
				if(l == null) return -1;
				if(r == null) return 1;
				return l.DevicePinRowId.CompareTo(r.DevicePinRowId);
			}
		}

		// Creates table.
		public static TableSnapshot<DevicePinData> CreateTable(StoreSnapshot store) {
			TableSnapshot<DevicePinData> table = new TableSnapshot<DevicePinData>(store, "DevicePin"
				,PinIdField.Field
				,CircuitIdField.Field
				,BitWidthField.Field
				,PinTypeField.Field
				,PinSideField.Field
				,InvertedField.Field
				,NameField.Field
				,NoteField.Field
				,JamNotationField.Field
				,DevicePinField.Field
			);
			// Create all but foreign keys of the table
			table.MakeUnique("PK_DevicePin", DevicePinData.PinIdField.Field , true);
			table.MakeUnique("AK_DevicePinName", DevicePinData.CircuitIdField.Field, DevicePinData.NameField.Field);
			table.CreateIndex("IX_Circuit_DevicePin", DevicePinData.CircuitIdField.Field );
			// Return created table
			return table;
		}

		// Creates all foreign keys of the table
		public static void CreateForeignKeys(StoreSnapshot store) {
			TableSnapshot<DevicePinData> table = (TableSnapshot<DevicePinData>)store.Table("DevicePin");
			table.CreateForeignKey("PK_DevicePin", store.Table("Circuit"), DevicePinData.PinIdField.Field, ForeignKeyAction.Cascade, false);
			table.CreateForeignKey("FK_Circuit_DevicePin", store.Table("Circuit"), DevicePinData.CircuitIdField.Field, ForeignKeyAction.Restrict, false);
		}
	}


	// Class wrapper for a record.
	partial class DevicePin : BasePin {

		// RowId of the wrapped record
		internal RowId DevicePinRowId { get; private set; }

		// Constructor
		public DevicePin(CircuitProject store, RowId rowIdDevicePin, RowId rowIdCircuit) : base(store, rowIdCircuit) {
			Debug.Assert(!rowIdDevicePin.IsEmpty);
			this.DevicePinRowId = rowIdDevicePin;
			// Link back to record. Assuming that a transaction is started
			this.Table.SetField(this.DevicePinRowId, DevicePinData.DevicePinField.Field, this);
			this.InitializeDevicePin();
		}

		partial void InitializeDevicePin();

		// Gets table storing this item.
		private TableSnapshot<DevicePinData> Table { get { return this.CircuitProject.DevicePinSet.Table; } }


		//Properties of DevicePin

		// Gets value of the PinId field.
		public Guid PinId {
			get { return this.Table.GetField(this.DevicePinRowId, DevicePinData.PinIdField.Field); }
		}

		// Gets or sets the value reffered by the foreign key on field CircuitId
		public Circuit Circuit {
			get { return this.CircuitProject.CircuitSet.Find(this.Table.GetField(this.DevicePinRowId, DevicePinData.CircuitIdField.Field)); }
			set { this.Table.SetField(this.DevicePinRowId, DevicePinData.CircuitIdField.Field, value.CircuitId); }
		}

		// Gets or sets value of the BitWidth field.
		private int PinBitWidth {
			get { return this.Table.GetField(this.DevicePinRowId, DevicePinData.BitWidthField.Field); }
			set { this.Table.SetField(this.DevicePinRowId, DevicePinData.BitWidthField.Field, value); }
		}

		// Gets or sets value of the PinType field.
		public override PinType PinType {
			get { return this.Table.GetField(this.DevicePinRowId, DevicePinData.PinTypeField.Field); }
			set { this.Table.SetField(this.DevicePinRowId, DevicePinData.PinTypeField.Field, value); }
		}

		// Gets or sets value of the PinSide field.
		public override PinSide PinSide {
			get { return this.Table.GetField(this.DevicePinRowId, DevicePinData.PinSideField.Field); }
			set { this.Table.SetField(this.DevicePinRowId, DevicePinData.PinSideField.Field, value); }
		}

		// Gets or sets value of the Inverted field.
		public override bool Inverted {
			get { return this.Table.GetField(this.DevicePinRowId, DevicePinData.InvertedField.Field); }
			set { this.Table.SetField(this.DevicePinRowId, DevicePinData.InvertedField.Field, value); }
		}

		// Gets or sets value of the Name field.
		public override string Name {
			get { return this.Table.GetField(this.DevicePinRowId, DevicePinData.NameField.Field); }
			set { this.Table.SetField(this.DevicePinRowId, DevicePinData.NameField.Field, value); }
		}

		// Gets or sets value of the Note field.
		public override string Note {
			get { return this.Table.GetField(this.DevicePinRowId, DevicePinData.NoteField.Field); }
			set { this.Table.SetField(this.DevicePinRowId, DevicePinData.NoteField.Field, value); }
		}

		// Gets or sets value of the JamNotation field.
		public override string JamNotation {
			get { return this.Table.GetField(this.DevicePinRowId, DevicePinData.JamNotationField.Field); }
			set { this.Table.SetField(this.DevicePinRowId, DevicePinData.JamNotationField.Field, value); }
		}


		internal void NotifyChanged(TableChange<DevicePinData> change) {
			if(this.HasListener) {
				DevicePinData oldData, newData;
				change.GetOldData(out oldData);
				change.GetNewData(out newData);
				if(DevicePinData.PinIdField.Field.Compare(ref oldData, ref newData) != 0) {
					this.NotifyPropertyChanged("PinId");
				}
				if(DevicePinData.CircuitIdField.Field.Compare(ref oldData, ref newData) != 0) {
					this.NotifyPropertyChanged("Circuit");
				}
				if(DevicePinData.BitWidthField.Field.Compare(ref oldData, ref newData) != 0) {
					this.NotifyPropertyChanged("BitWidth");
				}
				if(DevicePinData.PinTypeField.Field.Compare(ref oldData, ref newData) != 0) {
					this.NotifyPropertyChanged("PinType");
				}
				if(DevicePinData.PinSideField.Field.Compare(ref oldData, ref newData) != 0) {
					this.NotifyPropertyChanged("PinSide");
				}
				if(DevicePinData.InvertedField.Field.Compare(ref oldData, ref newData) != 0) {
					this.NotifyPropertyChanged("Inverted");
				}
				if(DevicePinData.NameField.Field.Compare(ref oldData, ref newData) != 0) {
					this.NotifyPropertyChanged("Name");
				}
				if(DevicePinData.NoteField.Field.Compare(ref oldData, ref newData) != 0) {
					this.NotifyPropertyChanged("Note");
				}
				if(DevicePinData.JamNotationField.Field.Compare(ref oldData, ref newData) != 0) {
					this.NotifyPropertyChanged("JamNotation");
				}
			}
			this.OnDevicePinChanged();
		}

		partial void OnDevicePinChanged();
	}


	// Wrapper for table DevicePin.
	partial class DevicePinSet : INotifyCollectionChanged, IEnumerable<DevicePin> {

		public event NotifyCollectionChangedEventHandler CollectionChanged;

		internal TableSnapshot<DevicePinData> Table { get; private set; }

		// Gets StoreSnapshot this set belongs to.
		public CircuitProject CircuitProject { get { return (CircuitProject)this.Table.StoreSnapshot; } }

		// Constructor
		public DevicePinSet(CircuitProject store) {
			ITableSnapshot table = store.Table("DevicePin");
			if(table != null) {
				Debug.Assert(store.IsFrozen, "The store should be frozen");
				this.Table = (TableSnapshot<DevicePinData>)table;
			} else {
				Debug.Assert(!store.IsFrozen, "In order to create table, the store should not be frozen");
				this.Table = DevicePinData.CreateTable(store);
			}
			this.InitializeDevicePinSet();
		}

		partial void InitializeDevicePinSet();

		//internal void Register() {
		//	foreach(RowId rowId in this.Table.Rows) {
		//		this.FindOrCreate(rowId);
		//	}
		//}


		// gets items wrapper by RowId
		public DevicePin Find(RowId rowId) {
			if(!rowId.IsEmpty) {
				return this.Table.GetField(rowId, DevicePinData.DevicePinField.Field);
			}
			return null;
		}

		private void Delete(RowId rowId) {
		}

		// gets items wrapper by RowId
		private IEnumerable<DevicePin> Select(IEnumerable<RowId> rows) {
			foreach(RowId rowId in rows) {
				DevicePin item = this.Find(rowId);
				Debug.Assert(item != null, "What is the reason for the item not to be found?");
				yield return item;
			}
		}

		// Create wrapper for the row and register it in the dictionary
		private DevicePin Create(RowId rowId, RowId CircuitRowId) {
			DevicePin item = new DevicePin(this.CircuitProject, rowId, CircuitRowId);
			return item;
		}

		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1506:AvoidExcessiveClassCoupling")]
		internal DevicePin FindOrCreate(RowId rowId) {
			Debug.Assert(!rowId.IsEmpty && !this.Table.IsDeleted(rowId), "Bad RowId");
			DevicePin item;
			if((item = this.Find(rowId)) != null) {
				Debug.Assert(!item.IsDeleted(), "Deleted item should not be present in the dictionary");
				return item;
			}
			Guid primaryKeyValue = this.Table.GetField(rowId, DevicePinData.PinIdField.Field);


			TableSnapshot<CircuitData> tableCircuit = (TableSnapshot<CircuitData>)this.CircuitProject.Table("Circuit");
			return this.Create(rowId, tableCircuit.Find(CircuitData.CircuitIdField.Field, primaryKeyValue));
		}

		// Creates DevicePin wrapper
		private DevicePin CreateItem(
			// Fields of DevicePin table
			Guid PinId,
			Circuit Circuit,
			int BitWidth,
			PinType PinType,
			PinSide PinSide,
			bool Inverted,
			string Name,
			string Note,
			string JamNotation
			// Fields of Circuit table

		) {
			TableSnapshot<CircuitData> tableCircuit = (TableSnapshot<CircuitData>)this.CircuitProject.Table("Circuit");
			CircuitData dataCircuit = new CircuitData() {
				CircuitId = PinId
			};
			RowId rowIdCircuit = tableCircuit.Insert(ref dataCircuit);

			DevicePinData dataDevicePin = new DevicePinData() {
				PinId = PinId,
				CircuitId = (Circuit != null) ? Circuit.CircuitId : DevicePinData.CircuitIdField.Field.DefaultValue,
				BitWidth = BitWidth,
				PinType = PinType,
				PinSide = PinSide,
				Inverted = Inverted,
				Name = Name,
				Note = Note,
				JamNotation = JamNotation,
			};
			return this.Create(this.Table.Insert(ref dataDevicePin), rowIdCircuit);
		}

		// Search helpers

		// Finds DevicePin by PinId
		public DevicePin FindByPinId(Guid pinId) {
			return this.Find(this.Table.Find(DevicePinData.PinIdField.Field, pinId));
		}

		// Finds DevicePin by Circuit and Name
		public DevicePin FindByCircuitAndName(Circuit circuit, string name) {
			return this.Find(
				this.Table.Find(
					DevicePinData.CircuitIdField.Field, DevicePinData.NameField.Field,
					circuit.CircuitId, name
				)
			);
		}

		// Selects DevicePin by Circuit
		public IEnumerable<DevicePin> SelectByCircuit(Circuit circuit) {
			return this.Select(this.Table.Select(DevicePinData.CircuitIdField.Field, circuit.CircuitId));
		}

		public IEnumerator<DevicePin> GetEnumerator() {
			return this.Select(this.Table.Rows).GetEnumerator();
		}

		System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() {
			return this.GetEnumerator();
		}

		private void NotifyCollectionChanged(NotifyCollectionChangedEventArgs arg) {
			NotifyCollectionChangedEventHandler handler = this.CollectionChanged;
			if(handler != null) {
				handler(this, arg);
			}
		}

		internal List<DevicePin> UpdateSet(int oldVersion, int newVersion) {
			IEnumerator<TableChange<DevicePinData>> change = this.Table.GetVersionChangeChanges(oldVersion, newVersion);
			if(change != null) {
				bool handlerAttached = (this.CollectionChanged != null);
				List<DevicePin> del = (handlerAttached) ? new List<DevicePin>() : null;
				while(change.MoveNext()) {
					switch(change.Current.Action) {
					case SnapTableAction.Insert:
						this.FindOrCreate(change.Current.RowId);
						Debug.Assert(this.Find(change.Current.RowId) != null, "Why the item was not created?");
						break;
					case SnapTableAction.Delete:
						if(handlerAttached) {
							DevicePin item = change.Current.GetOldField(DevicePinData.DevicePinField.Field);
							Debug.Assert(item.IsDeleted());
							del.Add(item);
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

		internal void NotifyVersionChanged(int oldVersion, int newVersion, List<DevicePin> deleted) {
			IEnumerator<TableChange<DevicePinData>> change = this.Table.GetVersionChangeChanges(oldVersion, newVersion);
			if(change != null) {
				bool handlerAttached = (this.CollectionChanged != null);
				List<DevicePin> add = (handlerAttached) ? new List<DevicePin>() : null;
				this.StartNotifyDevicePinSetChanged(oldVersion, newVersion);
				while(change.MoveNext()) {
					this.NotifyDevicePinSetChanged(change.Current);
					switch(change.Current.Action) {
					case SnapTableAction.Insert:
						Debug.Assert(this.Find(change.Current.RowId) != null, "Why the item was not created?");
						if(handlerAttached) {
							add.Add(this.Find(change.Current.RowId));
						}
						break;
					case SnapTableAction.Delete:
						Debug.Assert(change.Current.GetOldField(DevicePinData.DevicePinField.Field).IsDeleted(), "Why the item still exists?");
						break;
					default:
						Debug.Assert(change.Current.Action == SnapTableAction.Update, "Unknown action");
						Debug.Assert(this.Find(change.Current.RowId) != null, "Why the item does not exist during update?");
						this.Find(change.Current.RowId).NotifyChanged(change.Current);
						break;
					}
				}
				change.Dispose();
				if(handlerAttached) {
					if(deleted != null && 0 < deleted.Count) {
						this.NotifyCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Remove, deleted));
					}
					if(0 < add.Count) {
						this.NotifyCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Add, add));
					}
				}
				this.EndNotifyDevicePinSetChanged();
			}
		}

		partial void StartNotifyDevicePinSetChanged(int oldVersion, int newVersion);
		partial void EndNotifyDevicePinSetChanged();
		partial void NotifyDevicePinSetChanged(TableChange<DevicePinData> change);

		internal void NotifyRolledBack(int version) {
			if(this.Table.WasAffected(version)) {
				IEnumerator<RowId> change = this.Table.GetRolledBackChanges(version);
				if(change != null) {
					while(change.MoveNext()) {
						RowId rowId = change.Current;
						if(this.Table.IsDeleted(rowId)) {
							this.Delete(rowId);
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
