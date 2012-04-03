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

	// Defines the shape of the table Memory
	internal partial struct MemoryData {
		public Guid MemoryId;
		public bool Writable;
		public bool WriteOn1;
		private int fieldAddressBitWidth;
		public int AddressBitWidth {
			get { return this.fieldAddressBitWidth; }
			set { this.fieldAddressBitWidth = Memory.CheckAddressBitWidth(value); }
		}
		private int fieldDataBitWidth;
		public int DataBitWidth {
			get { return this.fieldDataBitWidth; }
			set { this.fieldDataBitWidth = BasePin.CheckBitWidth(value); }
		}
		public string Data;
		public string Note;
		internal Memory Memory;
		// Field accessors
		// Accessor of the MemoryId field
		public sealed class MemoryIdField : IField<MemoryData, Guid>, IFieldSerializer<MemoryData> {
			public static readonly MemoryIdField Field = new MemoryIdField();
			private MemoryIdField() {}
			public string Name { get { return "MemoryId"; } }
			public int Order { get; set; }
			public Guid DefaultValue { get { return default(Guid); } }
			public Guid GetValue(ref MemoryData record) {
				return record.MemoryId;
			}
			public void SetValue(ref MemoryData record, Guid value) {
				record.MemoryId = value;
			}
			public int Compare(ref MemoryData l, ref MemoryData r) {
				return l.MemoryId.CompareTo(r.MemoryId);
			}
			public int Compare(Guid l, Guid r) {
				return l.CompareTo(r);
			}

			// Implementation of interface IFieldSerializer<MemoryData>
			bool IFieldSerializer<MemoryData>.NeedToSave(ref MemoryData data) {
				return this.Compare(data.MemoryId, this.DefaultValue) != 0;
			}
			string IFieldSerializer<MemoryData>.GetTextValue(ref MemoryData data) {
				return string.Format(CultureInfo.InvariantCulture, "{0}", data.MemoryId);
			}
			void IFieldSerializer<MemoryData>.SetDefault(ref MemoryData data) {
				data.MemoryId = this.DefaultValue;
			}
			void IFieldSerializer<MemoryData>.SetTextValue(ref MemoryData data, string text) {
				data.MemoryId = new Guid(text);
			}
		}

		// Accessor of the Writable field
		public sealed class WritableField : IField<MemoryData, bool>, IFieldSerializer<MemoryData> {
			public static readonly WritableField Field = new WritableField();
			private WritableField() {}
			public string Name { get { return "Writable"; } }
			public int Order { get; set; }
			public bool DefaultValue { get { return default(bool); } }
			public bool GetValue(ref MemoryData record) {
				return record.Writable;
			}
			public void SetValue(ref MemoryData record, bool value) {
				record.Writable = value;
			}
			public int Compare(ref MemoryData l, ref MemoryData r) {
				return l.Writable.CompareTo(r.Writable);
			}
			public int Compare(bool l, bool r) {
				return l.CompareTo(r);
			}

			// Implementation of interface IFieldSerializer<MemoryData>
			bool IFieldSerializer<MemoryData>.NeedToSave(ref MemoryData data) {
				return this.Compare(data.Writable, this.DefaultValue) != 0;
			}
			string IFieldSerializer<MemoryData>.GetTextValue(ref MemoryData data) {
				return string.Format(CultureInfo.InvariantCulture, "{0}", data.Writable);
			}
			void IFieldSerializer<MemoryData>.SetDefault(ref MemoryData data) {
				data.Writable = this.DefaultValue;
			}
			void IFieldSerializer<MemoryData>.SetTextValue(ref MemoryData data, string text) {
				data.Writable = bool.Parse(text);
			}
		}

		// Accessor of the WriteOn1 field
		public sealed class WriteOn1Field : IField<MemoryData, bool>, IFieldSerializer<MemoryData> {
			public static readonly WriteOn1Field Field = new WriteOn1Field();
			private WriteOn1Field() {}
			public string Name { get { return "WriteOn1"; } }
			public int Order { get; set; }
			public bool DefaultValue { get { return false; } }
			public bool GetValue(ref MemoryData record) {
				return record.WriteOn1;
			}
			public void SetValue(ref MemoryData record, bool value) {
				record.WriteOn1 = value;
			}
			public int Compare(ref MemoryData l, ref MemoryData r) {
				return l.WriteOn1.CompareTo(r.WriteOn1);
			}
			public int Compare(bool l, bool r) {
				return l.CompareTo(r);
			}

			// Implementation of interface IFieldSerializer<MemoryData>
			bool IFieldSerializer<MemoryData>.NeedToSave(ref MemoryData data) {
				return this.Compare(data.WriteOn1, this.DefaultValue) != 0;
			}
			string IFieldSerializer<MemoryData>.GetTextValue(ref MemoryData data) {
				return string.Format(CultureInfo.InvariantCulture, "{0}", data.WriteOn1);
			}
			void IFieldSerializer<MemoryData>.SetDefault(ref MemoryData data) {
				data.WriteOn1 = this.DefaultValue;
			}
			void IFieldSerializer<MemoryData>.SetTextValue(ref MemoryData data, string text) {
				data.WriteOn1 = bool.Parse(text);
			}
		}

		// Accessor of the AddressBitWidth field
		public sealed class AddressBitWidthField : IField<MemoryData, int>, IFieldSerializer<MemoryData> {
			public static readonly AddressBitWidthField Field = new AddressBitWidthField();
			private AddressBitWidthField() {}
			public string Name { get { return "AddressBitWidth"; } }
			public int Order { get; set; }
			public int DefaultValue { get { return default(int); } }
			public int GetValue(ref MemoryData record) {
				return record.AddressBitWidth;
			}
			public void SetValue(ref MemoryData record, int value) {
				record.AddressBitWidth = value;
			}
			public int Compare(ref MemoryData l, ref MemoryData r) {
				return Math.Sign((long)l.AddressBitWidth - (long)r.AddressBitWidth);
			}
			public int Compare(int l, int r) {
				return Math.Sign((long)l - (long)r);
			}

			// Implementation of interface IFieldSerializer<MemoryData>
			bool IFieldSerializer<MemoryData>.NeedToSave(ref MemoryData data) {
				return this.Compare(data.AddressBitWidth, this.DefaultValue) != 0;
			}
			string IFieldSerializer<MemoryData>.GetTextValue(ref MemoryData data) {
				return string.Format(CultureInfo.InvariantCulture, "{0}", data.AddressBitWidth);
			}
			void IFieldSerializer<MemoryData>.SetDefault(ref MemoryData data) {
				data.AddressBitWidth = this.DefaultValue;
			}
			void IFieldSerializer<MemoryData>.SetTextValue(ref MemoryData data, string text) {
				data.AddressBitWidth = int.Parse(text, CultureInfo.InvariantCulture);
			}
		}

		// Accessor of the DataBitWidth field
		public sealed class DataBitWidthField : IField<MemoryData, int>, IFieldSerializer<MemoryData> {
			public static readonly DataBitWidthField Field = new DataBitWidthField();
			private DataBitWidthField() {}
			public string Name { get { return "DataBitWidth"; } }
			public int Order { get; set; }
			public int DefaultValue { get { return default(int); } }
			public int GetValue(ref MemoryData record) {
				return record.DataBitWidth;
			}
			public void SetValue(ref MemoryData record, int value) {
				record.DataBitWidth = value;
			}
			public int Compare(ref MemoryData l, ref MemoryData r) {
				return Math.Sign((long)l.DataBitWidth - (long)r.DataBitWidth);
			}
			public int Compare(int l, int r) {
				return Math.Sign((long)l - (long)r);
			}

			// Implementation of interface IFieldSerializer<MemoryData>
			bool IFieldSerializer<MemoryData>.NeedToSave(ref MemoryData data) {
				return this.Compare(data.DataBitWidth, this.DefaultValue) != 0;
			}
			string IFieldSerializer<MemoryData>.GetTextValue(ref MemoryData data) {
				return string.Format(CultureInfo.InvariantCulture, "{0}", data.DataBitWidth);
			}
			void IFieldSerializer<MemoryData>.SetDefault(ref MemoryData data) {
				data.DataBitWidth = this.DefaultValue;
			}
			void IFieldSerializer<MemoryData>.SetTextValue(ref MemoryData data, string text) {
				data.DataBitWidth = int.Parse(text, CultureInfo.InvariantCulture);
			}
		}

		// Accessor of the Data field
		public sealed class DataField : IField<MemoryData, string>, IFieldSerializer<MemoryData> {
			public static readonly DataField Field = new DataField();
			private DataField() {}
			public string Name { get { return "Data"; } }
			public int Order { get; set; }
			public string DefaultValue { get { return ""; } }
			public string GetValue(ref MemoryData record) {
				return record.Data;
			}
			public void SetValue(ref MemoryData record, string value) {
				record.Data = value;
			}
			public int Compare(ref MemoryData l, ref MemoryData r) {
				return StringComparer.Ordinal.Compare(l.Data, r.Data);
			}
			public int Compare(string l, string r) {
				return StringComparer.Ordinal.Compare(l, r);
			}

			// Implementation of interface IFieldSerializer<MemoryData>
			bool IFieldSerializer<MemoryData>.NeedToSave(ref MemoryData data) {
				return this.Compare(data.Data, this.DefaultValue) != 0;
			}
			string IFieldSerializer<MemoryData>.GetTextValue(ref MemoryData data) {
				return string.Format(CultureInfo.InvariantCulture, "{0}", data.Data);
			}
			void IFieldSerializer<MemoryData>.SetDefault(ref MemoryData data) {
				data.Data = this.DefaultValue;
			}
			void IFieldSerializer<MemoryData>.SetTextValue(ref MemoryData data, string text) {
				data.Data = text;
			}
		}

		// Accessor of the Note field
		public sealed class NoteField : IField<MemoryData, string>, IFieldSerializer<MemoryData> {
			public static readonly NoteField Field = new NoteField();
			private NoteField() {}
			public string Name { get { return "Note"; } }
			public int Order { get; set; }
			public string DefaultValue { get { return ""; } }
			public string GetValue(ref MemoryData record) {
				return record.Note;
			}
			public void SetValue(ref MemoryData record, string value) {
				record.Note = value;
			}
			public int Compare(ref MemoryData l, ref MemoryData r) {
				return StringComparer.Ordinal.Compare(l.Note, r.Note);
			}
			public int Compare(string l, string r) {
				return StringComparer.Ordinal.Compare(l, r);
			}

			// Implementation of interface IFieldSerializer<MemoryData>
			bool IFieldSerializer<MemoryData>.NeedToSave(ref MemoryData data) {
				return this.Compare(data.Note, this.DefaultValue) != 0;
			}
			string IFieldSerializer<MemoryData>.GetTextValue(ref MemoryData data) {
				return string.Format(CultureInfo.InvariantCulture, "{0}", data.Note);
			}
			void IFieldSerializer<MemoryData>.SetDefault(ref MemoryData data) {
				data.Note = this.DefaultValue;
			}
			void IFieldSerializer<MemoryData>.SetTextValue(ref MemoryData data, string text) {
				data.Note = text;
			}
		}

		// Special field used to access items wrapper of this record from record.
		// This is used when no other universes is used
		internal sealed class MemoryField : IField<MemoryData, Memory> {
			public static readonly MemoryField Field = new MemoryField();
			private MemoryField() {}
			public string Name { get { return "MemoryWrapper"; } }
			public int Order { get; set; }
			public Memory DefaultValue { get { return null; } }
			public Memory GetValue(ref MemoryData record) {
				return record.Memory;
			}
			public void SetValue(ref MemoryData record, Memory value) {
				record.Memory = value;
			}
			public int Compare(ref MemoryData l, ref MemoryData r) {
				return this.Compare(l.Memory, r.Memory);
			}
			public int Compare(Memory l, Memory r) {
				if(object.ReferenceEquals(l, r)) return 0;
				if(l == null) return -1;
				if(r == null) return 1;
				return l.MemoryRowId.CompareTo(r.MemoryRowId);
			}
		}

		private static IField<MemoryData>[] fields = {
			MemoryIdField.Field,
			WritableField.Field,
			WriteOn1Field.Field,
			AddressBitWidthField.Field,
			DataBitWidthField.Field,
			DataField.Field,
			NoteField.Field,
			MemoryField.Field
		};

		// Creates table.
		public static TableSnapshot<MemoryData> CreateTable(StoreSnapshot store) {
			TableSnapshot<MemoryData> table = new TableSnapshot<MemoryData>(store, "Memory", MemoryData.fields);
			// Create all but foreign keys of the table
			table.MakeUnique("PK_Memory", MemoryData.MemoryIdField.Field , true);
			// Return created table
			return table;
		}

		// Creates all foreign keys of the table
		public static void CreateForeignKeys(StoreSnapshot store) {
			TableSnapshot<MemoryData> table = (TableSnapshot<MemoryData>)store.Table("Memory");
			table.CreateForeignKey("PK_Memory", store.Table("Circuit"), MemoryData.MemoryIdField.Field, ForeignKeyAction.Cascade, false);
		}
	}

	// Class wrapper for a record.
	partial class Memory : Circuit {

		// RowId of the wrapped record
		internal RowId MemoryRowId { get; private set; }

		// Constructor
		public Memory(CircuitProject store, RowId rowIdMemory, RowId rowIdCircuit) : base(store, rowIdCircuit) {
			Debug.Assert(!rowIdMemory.IsEmpty);
			this.MemoryRowId = rowIdMemory;
			// Link back to record. Assuming that a transaction is started
			this.Table.SetField(this.MemoryRowId, MemoryData.MemoryField.Field, this);
			this.InitializeMemory();
		}

		partial void InitializeMemory();

		// Gets table storing this item.
		private TableSnapshot<MemoryData> Table { get { return this.CircuitProject.MemorySet.Table; } }


		//Properties of Memory

		// Gets value of the MemoryId field.
		public Guid MemoryId {
			get { return this.Table.GetField(this.MemoryRowId, MemoryData.MemoryIdField.Field); }
		}

		// Gets or sets value of the Writable field.
		public bool Writable {
			get { return this.Table.GetField(this.MemoryRowId, MemoryData.WritableField.Field); }
			set { this.Table.SetField(this.MemoryRowId, MemoryData.WritableField.Field, value); }
		}

		// Gets or sets value of the WriteOn1 field.
		public bool WriteOn1 {
			get { return this.Table.GetField(this.MemoryRowId, MemoryData.WriteOn1Field.Field); }
			set { this.Table.SetField(this.MemoryRowId, MemoryData.WriteOn1Field.Field, value); }
		}

		// Gets or sets value of the AddressBitWidth field.
		public int AddressBitWidth {
			get { return this.Table.GetField(this.MemoryRowId, MemoryData.AddressBitWidthField.Field); }
			set { this.Table.SetField(this.MemoryRowId, MemoryData.AddressBitWidthField.Field, value); }
		}

		// Gets or sets value of the DataBitWidth field.
		public int DataBitWidth {
			get { return this.Table.GetField(this.MemoryRowId, MemoryData.DataBitWidthField.Field); }
			set { this.Table.SetField(this.MemoryRowId, MemoryData.DataBitWidthField.Field, value); }
		}

		// Gets or sets value of the Data field.
		private string Data {
			get { return this.Table.GetField(this.MemoryRowId, MemoryData.DataField.Field); }
			set { this.Table.SetField(this.MemoryRowId, MemoryData.DataField.Field, value); }
		}

		// Gets or sets value of the Note field.
		public string Note {
			get { return this.Table.GetField(this.MemoryRowId, MemoryData.NoteField.Field); }
			set { this.Table.SetField(this.MemoryRowId, MemoryData.NoteField.Field, value); }
		}


		internal void NotifyChanged(TableChange<MemoryData> change) {
			if(this.HasListener) {
				MemoryData oldData, newData;
				change.GetOldData(out oldData);
				change.GetNewData(out newData);
				if(MemoryData.MemoryIdField.Field.Compare(ref oldData, ref newData) != 0) {
					this.NotifyPropertyChanged("MemoryId");
				}
				if(MemoryData.WritableField.Field.Compare(ref oldData, ref newData) != 0) {
					this.NotifyPropertyChanged("Writable");
				}
				if(MemoryData.WriteOn1Field.Field.Compare(ref oldData, ref newData) != 0) {
					this.NotifyPropertyChanged("WriteOn1");
				}
				if(MemoryData.AddressBitWidthField.Field.Compare(ref oldData, ref newData) != 0) {
					this.NotifyPropertyChanged("AddressBitWidth");
				}
				if(MemoryData.DataBitWidthField.Field.Compare(ref oldData, ref newData) != 0) {
					this.NotifyPropertyChanged("DataBitWidth");
				}
				if(MemoryData.DataField.Field.Compare(ref oldData, ref newData) != 0) {
					this.NotifyPropertyChanged("Data");
				}
				if(MemoryData.NoteField.Field.Compare(ref oldData, ref newData) != 0) {
					this.NotifyPropertyChanged("Note");
				}
			}
			this.OnMemoryChanged();
		}

		partial void OnMemoryChanged();
	}


	// Wrapper for table Memory.
	partial class MemorySet : INotifyCollectionChanged, IEnumerable<Memory> {

		public event NotifyCollectionChangedEventHandler CollectionChanged;

		internal TableSnapshot<MemoryData> Table { get; private set; }

		// Gets StoreSnapshot this set belongs to.
		public CircuitProject CircuitProject { get { return (CircuitProject)this.Table.StoreSnapshot; } }

		// Constructor
		public MemorySet(CircuitProject store) {
			ITableSnapshot table = store.Table("Memory");
			if(table != null) {
				Debug.Assert(store.IsFrozen, "The store should be frozen");
				this.Table = (TableSnapshot<MemoryData>)table;
			} else {
				Debug.Assert(!store.IsFrozen, "In order to create table, the store should not be frozen");
				this.Table = MemoryData.CreateTable(store);
			}
			this.InitializeMemorySet();
		}

		partial void InitializeMemorySet();

		//internal void Register() {
		//	foreach(RowId rowId in this.Table.Rows) {
		//		this.FindOrCreate(rowId);
		//	}
		//}


		// gets items wrapper by RowId
		public Memory Find(RowId rowId) {
			if(!rowId.IsEmpty) {
				return this.Table.GetField(rowId, MemoryData.MemoryField.Field);
			}
			return null;
		}

		private void Delete(RowId rowId) {
		}

		// gets items wrapper by RowId
		private IEnumerable<Memory> Select(IEnumerable<RowId> rows) {
			foreach(RowId rowId in rows) {
				Memory item = this.Find(rowId);
				Debug.Assert(item != null, "What is the reason for the item not to be found?");
				yield return item;
			}
		}

		// Create wrapper for the row and register it in the dictionary
		private Memory Create(RowId rowId, RowId CircuitRowId) {
			Memory item = new Memory(this.CircuitProject, rowId, CircuitRowId);
			return item;
		}

		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1506:AvoidExcessiveClassCoupling")]
		internal Memory FindOrCreate(RowId rowId) {
			Debug.Assert(!rowId.IsEmpty && !this.Table.IsDeleted(rowId), "Bad RowId");
			Memory item;
			if((item = this.Find(rowId)) != null) {
				Debug.Assert(!item.IsDeleted(), "Deleted item should not be present in the dictionary");
				return item;
			}
			Guid primaryKeyValue = this.Table.GetField(rowId, MemoryData.MemoryIdField.Field);


			TableSnapshot<CircuitData> tableCircuit = (TableSnapshot<CircuitData>)this.CircuitProject.Table("Circuit");
			return this.Create(rowId, tableCircuit.Find(CircuitData.CircuitIdField.Field, primaryKeyValue));
		}

		// Creates Memory wrapper
		private Memory CreateItem(
			// Fields of Memory table
			Guid MemoryId,
			bool Writable,
			bool WriteOn1,
			int AddressBitWidth,
			int DataBitWidth,
			string Data,
			string Note
			// Fields of Circuit table

		) {
			TableSnapshot<CircuitData> tableCircuit = (TableSnapshot<CircuitData>)this.CircuitProject.Table("Circuit");
			CircuitData dataCircuit = new CircuitData() {
				CircuitId = MemoryId
			};
			RowId rowIdCircuit = tableCircuit.Insert(ref dataCircuit);

			MemoryData dataMemory = new MemoryData() {
				MemoryId = MemoryId,
				Writable = Writable,
				WriteOn1 = WriteOn1,
				AddressBitWidth = AddressBitWidth,
				DataBitWidth = DataBitWidth,
				Data = Data,
				Note = Note,
			};
			return this.Create(this.Table.Insert(ref dataMemory), rowIdCircuit);
		}

		// Search helpers

		// Finds Memory by MemoryId
		public Memory FindByMemoryId(Guid memoryId) {
			return this.Find(this.Table.Find(MemoryData.MemoryIdField.Field, memoryId));
		}

		public IEnumerator<Memory> GetEnumerator() {
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

		internal List<Memory> UpdateSet(int oldVersion, int newVersion) {
			IEnumerator<TableChange<MemoryData>> change = this.Table.GetVersionChangeChanges(oldVersion, newVersion);
			if(change != null) {
				bool handlerAttached = (this.CollectionChanged != null);
				List<Memory> del = (handlerAttached) ? new List<Memory>() : null;
				while(change.MoveNext()) {
					switch(change.Current.Action) {
					case SnapTableAction.Insert:
						this.FindOrCreate(change.Current.RowId);
						Debug.Assert(this.Find(change.Current.RowId) != null, "Why the item was not created?");
						break;
					case SnapTableAction.Delete:
						if(handlerAttached) {
							Memory item = change.Current.GetOldField(MemoryData.MemoryField.Field);
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

		internal void NotifyVersionChanged(int oldVersion, int newVersion, List<Memory> deleted) {
			IEnumerator<TableChange<MemoryData>> change = this.Table.GetVersionChangeChanges(oldVersion, newVersion);
			if(change != null) {
				bool handlerAttached = (this.CollectionChanged != null);
				List<Memory> add = (handlerAttached) ? new List<Memory>() : null;
				this.StartNotifyMemorySetChanged(oldVersion, newVersion);
				while(change.MoveNext()) {
					this.NotifyMemorySetChanged(change.Current);
					switch(change.Current.Action) {
					case SnapTableAction.Insert:
						Debug.Assert(this.Find(change.Current.RowId) != null, "Why the item was not created?");
						if(handlerAttached) {
							add.Add(this.Find(change.Current.RowId));
						}
						break;
					case SnapTableAction.Delete:
						Debug.Assert(change.Current.GetOldField(MemoryData.MemoryField.Field).IsDeleted(), "Why the item still exists?");
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
				this.EndNotifyMemorySetChanged();
			}
		}

		partial void StartNotifyMemorySetChanged(int oldVersion, int newVersion);
		partial void EndNotifyMemorySetChanged();
		partial void NotifyMemorySetChanged(TableChange<MemoryData> change);

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
