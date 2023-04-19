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

	// Defines the shape of the table Constant
	internal partial struct ConstantData {
		public Guid ConstantId;
		private int fieldBitWidth;
		public int BitWidth {
			get { return this.fieldBitWidth; }
			set { this.fieldBitWidth = BasePin.CheckBitWidth(value); }
		}
		public int Value;
		public PinSide PinSide;
		public string Note;
		internal Constant? Constant;
		// Field accessors
		// Accessor of the ConstantId field
		public sealed class ConstantIdField : IField<ConstantData, Guid>, IFieldSerializer<ConstantData> {
			public static readonly ConstantIdField Field = new ConstantIdField();
			private ConstantIdField() {}
			public string Name { get { return "ConstantId"; } }
			public int Order { get; set; }
			public Guid DefaultValue { get { return default; } }
			public Guid GetValue(ref ConstantData record) {
				return record.ConstantId;
			}
			public void SetValue(ref ConstantData record, Guid value) {
				record.ConstantId = value;
			}
			public int Compare(ref ConstantData l, ref ConstantData r) {
				return l.ConstantId.CompareTo(r.ConstantId);
			}
			public int Compare(Guid l, Guid r) {
				return l.CompareTo(r);
			}

			// Implementation of interface IFieldSerializer<ConstantData>
			bool IFieldSerializer<ConstantData>.NeedToSave(ref ConstantData data) {
				return this.Compare(data.ConstantId, this.DefaultValue) != 0;
			}
			string IFieldSerializer<ConstantData>.GetTextValue(ref ConstantData data) {
				return string.Format(CultureInfo.InvariantCulture, "{0}", data.ConstantId);
			}
			void IFieldSerializer<ConstantData>.SetDefault(ref ConstantData data) {
				data.ConstantId = this.DefaultValue;
			}
			void IFieldSerializer<ConstantData>.SetTextValue(ref ConstantData data, string text) {
				data.ConstantId = new Guid(text);
			}
		}

		// Accessor of the BitWidth field
		public sealed class BitWidthField : IField<ConstantData, int>, IFieldSerializer<ConstantData> {
			public static readonly BitWidthField Field = new BitWidthField();
			private BitWidthField() {}
			public string Name { get { return "BitWidth"; } }
			public int Order { get; set; }
			public int DefaultValue { get { return 1; } }
			public int GetValue(ref ConstantData record) {
				return record.BitWidth;
			}
			public void SetValue(ref ConstantData record, int value) {
				record.BitWidth = value;
			}
			public int Compare(ref ConstantData l, ref ConstantData r) {
				return Math.Sign((long)l.BitWidth - (long)r.BitWidth);
			}
			public int Compare(int l, int r) {
				return Math.Sign((long)l - (long)r);
			}

			// Implementation of interface IFieldSerializer<ConstantData>
			bool IFieldSerializer<ConstantData>.NeedToSave(ref ConstantData data) {
				return this.Compare(data.BitWidth, this.DefaultValue) != 0;
			}
			string IFieldSerializer<ConstantData>.GetTextValue(ref ConstantData data) {
				return string.Format(CultureInfo.InvariantCulture, "{0}", data.BitWidth);
			}
			void IFieldSerializer<ConstantData>.SetDefault(ref ConstantData data) {
				data.BitWidth = this.DefaultValue;
			}
			void IFieldSerializer<ConstantData>.SetTextValue(ref ConstantData data, string text) {
				data.BitWidth = int.Parse(text, CultureInfo.InvariantCulture);
			}
		}

		// Accessor of the Value field
		public sealed class ValueField : IField<ConstantData, int>, IFieldSerializer<ConstantData> {
			public static readonly ValueField Field = new ValueField();
			private ValueField() {}
			public string Name { get { return "Value"; } }
			public int Order { get; set; }
			public int DefaultValue { get { return 0; } }
			public int GetValue(ref ConstantData record) {
				return record.Value;
			}
			public void SetValue(ref ConstantData record, int value) {
				record.Value = value;
			}
			public int Compare(ref ConstantData l, ref ConstantData r) {
				return Math.Sign((long)l.Value - (long)r.Value);
			}
			public int Compare(int l, int r) {
				return Math.Sign((long)l - (long)r);
			}

			// Implementation of interface IFieldSerializer<ConstantData>
			bool IFieldSerializer<ConstantData>.NeedToSave(ref ConstantData data) {
				return this.Compare(data.Value, this.DefaultValue) != 0;
			}
			string IFieldSerializer<ConstantData>.GetTextValue(ref ConstantData data) {
				return string.Format(CultureInfo.InvariantCulture, "{0}", data.Value);
			}
			void IFieldSerializer<ConstantData>.SetDefault(ref ConstantData data) {
				data.Value = this.DefaultValue;
			}
			void IFieldSerializer<ConstantData>.SetTextValue(ref ConstantData data, string text) {
				data.Value = int.Parse(text, CultureInfo.InvariantCulture);
			}
		}

		// Accessor of the PinSide field
		public sealed class PinSideField : IField<ConstantData, PinSide>, IFieldSerializer<ConstantData> {
			public static readonly PinSideField Field = new PinSideField();
			private PinSideField() {}
			public string Name { get { return "PinSide"; } }
			public int Order { get; set; }
			public PinSide DefaultValue { get { return PinSide.Right; } }
			public PinSide GetValue(ref ConstantData record) {
				return record.PinSide;
			}
			public void SetValue(ref ConstantData record, PinSide value) {
				record.PinSide = value;
			}
			public int Compare(ref ConstantData l, ref ConstantData r) {
				return l.PinSide.CompareTo(r.PinSide);
			}
			public int Compare(PinSide l, PinSide r) {
				return l.CompareTo(r);
			}

			// Implementation of interface IFieldSerializer<ConstantData>
			bool IFieldSerializer<ConstantData>.NeedToSave(ref ConstantData data) {
				return this.Compare(data.PinSide, this.DefaultValue) != 0;
			}
			string IFieldSerializer<ConstantData>.GetTextValue(ref ConstantData data) {
				return string.Format(CultureInfo.InvariantCulture, "{0}", data.PinSide);
			}
			void IFieldSerializer<ConstantData>.SetDefault(ref ConstantData data) {
				data.PinSide = this.DefaultValue;
			}
			void IFieldSerializer<ConstantData>.SetTextValue(ref ConstantData data, string text) {
				data.PinSide = EnumHelper.Parse<PinSide>(text, this.DefaultValue);
			}
		}

		// Accessor of the Note field
		public sealed class NoteField : IField<ConstantData, string>, IFieldSerializer<ConstantData> {
			public static readonly NoteField Field = new NoteField();
			private NoteField() {}
			public string Name { get { return "Note"; } }
			public int Order { get; set; }
			public string DefaultValue { get { return ""; } }
			public string GetValue(ref ConstantData record) {
				return record.Note;
			}
			public void SetValue(ref ConstantData record, string value) {
				record.Note = value;
			}
			public int Compare(ref ConstantData l, ref ConstantData r) {
				return StringComparer.Ordinal.Compare(l.Note, r.Note);
			}
			public int Compare(string? l, string? r) {
				return StringComparer.Ordinal.Compare(l, r);
			}

			// Implementation of interface IFieldSerializer<ConstantData>
			bool IFieldSerializer<ConstantData>.NeedToSave(ref ConstantData data) {
				return this.Compare(data.Note, this.DefaultValue) != 0;
			}
			string IFieldSerializer<ConstantData>.GetTextValue(ref ConstantData data) {
				return string.Format(CultureInfo.InvariantCulture, "{0}", data.Note);
			}
			void IFieldSerializer<ConstantData>.SetDefault(ref ConstantData data) {
				data.Note = this.DefaultValue;
			}
			void IFieldSerializer<ConstantData>.SetTextValue(ref ConstantData data, string text) {
				data.Note = text;
			}
		}

		// Special field used to access items wrapper of this record from record.
		// This is used when no other universes is used
		internal sealed class ConstantField : IField<ConstantData, Constant> {
			public static readonly ConstantField Field = new ConstantField();
			private ConstantField() {}
			public string Name { get { return "ConstantWrapper"; } }
			public int Order { get; set; }
			public Constant DefaultValue { get { return null!; } }
			public Constant GetValue(ref ConstantData record) {
				return record.Constant!;
			}
			public void SetValue(ref ConstantData record, Constant value) {
				record.Constant = value;
			}
			public int Compare(ref ConstantData l, ref ConstantData r) {
				return this.Compare(l.Constant, r.Constant);
			}
			public int Compare(Constant? l, Constant? r) {
				if(object.ReferenceEquals(l, r)) return 0;
				if(l == null) return -1;
				if(r == null) return 1;
				return l.ConstantRowId.CompareTo(r.ConstantRowId);
			}
		}

		private static readonly IField<ConstantData>[] fields = {
			ConstantIdField.Field,
			BitWidthField.Field,
			ValueField.Field,
			PinSideField.Field,
			NoteField.Field,
			ConstantField.Field
		};

		// Creates table.
		public static TableSnapshot<ConstantData> CreateTable(StoreSnapshot store) {
			TableSnapshot<ConstantData> table = new TableSnapshot<ConstantData>(store, "Constant", ConstantData.fields);
			// Create all but foreign keys of the table
			table.MakeUnique("PK_Constant", ConstantData.ConstantIdField.Field , true);
			// Return created table
			return table;
		}

		// Creates all foreign keys of the table
		public static void CreateForeignKeys(StoreSnapshot store) {
			TableSnapshot<ConstantData>? table = (TableSnapshot<ConstantData>?)store.Table("Constant");
			Debug.Assert(table != null);
			table.CreateForeignKey("PK_Constant", store.Table("Circuit"), ConstantData.ConstantIdField.Field, ForeignKeyAction.Cascade, false);
		}
	}

	// Class wrapper for a record.
	partial class Constant : Circuit {

		// RowId of the wrapped record
		internal RowId ConstantRowId { get; private set; }

		// Constructor
		#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
		public Constant(CircuitProject store, RowId rowIdConstant, RowId rowIdCircuit) : base(store, rowIdCircuit) {
			Debug.Assert(!rowIdConstant.IsEmpty);
			this.ConstantRowId = rowIdConstant;
			// Link back to record. Assuming that a transaction is started
			this.Table.SetField(this.ConstantRowId, ConstantData.ConstantField.Field, this);
			this.InitializeConstant();
		}
		#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

		partial void InitializeConstant();

		// Gets table storing this item.
		private TableSnapshot<ConstantData> Table { get { return this.CircuitProject.ConstantSet.Table; } }


		//Properties of Constant

		// Gets value of the ConstantId field.
		public Guid ConstantId {
			get { return this.Table.GetField(this.ConstantRowId, ConstantData.ConstantIdField.Field); }
		}

		// Gets or sets value of the BitWidth field.
		public int BitWidth {
			get { return this.Table.GetField(this.ConstantRowId, ConstantData.BitWidthField.Field); }
			set { this.Table.SetField(this.ConstantRowId, ConstantData.BitWidthField.Field, value); }
		}

		// Gets or sets value of the Value field.
		private int Value {
			get { return this.Table.GetField(this.ConstantRowId, ConstantData.ValueField.Field); }
			set { this.Table.SetField(this.ConstantRowId, ConstantData.ValueField.Field, value); }
		}

		// Gets or sets value of the PinSide field.
		public PinSide PinSide {
			get { return this.Table.GetField(this.ConstantRowId, ConstantData.PinSideField.Field); }
			set { this.Table.SetField(this.ConstantRowId, ConstantData.PinSideField.Field, value); }
		}

		// Gets or sets value of the Note field.
		public override string Note {
			get { return this.Table.GetField(this.ConstantRowId, ConstantData.NoteField.Field); }
			set { this.Table.SetField(this.ConstantRowId, ConstantData.NoteField.Field, value); }
		}


		internal void NotifyChanged(TableChange<ConstantData> change) {
			if(this.HasListener) {
				ConstantData oldData, newData;
				change.GetOldData(out oldData);
				change.GetNewData(out newData);
				if(ConstantData.ConstantIdField.Field.Compare(ref oldData, ref newData) != 0) {
					this.NotifyPropertyChanged("ConstantId");
				}
				if(ConstantData.BitWidthField.Field.Compare(ref oldData, ref newData) != 0) {
					this.NotifyPropertyChanged("BitWidth");
				}
				if(ConstantData.ValueField.Field.Compare(ref oldData, ref newData) != 0) {
					this.NotifyPropertyChanged("Value");
				}
				if(ConstantData.PinSideField.Field.Compare(ref oldData, ref newData) != 0) {
					this.NotifyPropertyChanged("PinSide");
				}
				if(ConstantData.NoteField.Field.Compare(ref oldData, ref newData) != 0) {
					this.NotifyPropertyChanged("Note");
				}
			}
			this.OnConstantChanged();
		}

		partial void OnConstantChanged();
	}


	// Wrapper for table Constant.
	partial class ConstantSet : INotifyCollectionChanged, IEnumerable<Constant> {

		public event NotifyCollectionChangedEventHandler? CollectionChanged;

		internal TableSnapshot<ConstantData> Table { get; private set; }

		// Gets StoreSnapshot this set belongs to.
		public CircuitProject CircuitProject { get { return (CircuitProject)this.Table.StoreSnapshot; } }

		// Constructor
		#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
		public ConstantSet(CircuitProject store) {
			ITableSnapshot? table = store.Table("Constant");
			if(table != null) {
				Debug.Assert(store.IsFrozen, "The store should be frozen");
				this.Table = (TableSnapshot<ConstantData>)table;
			} else {
				Debug.Assert(!store.IsFrozen, "In order to create table, the store should not be frozen");
				this.Table = ConstantData.CreateTable(store);
			}
			this.InitializeConstantSet();
		}
		#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

		partial void InitializeConstantSet();

		//internal void Register() {
		//	foreach(RowId rowId in this.Table.Rows) {
		//		this.FindOrCreate(rowId);
		//	}
		//}


		// gets items wrapper by RowId
		public Constant? Find(RowId rowId) {
			if(!rowId.IsEmpty) {
				return this.Table.GetField(rowId, ConstantData.ConstantField.Field);
			}
			return null;
		}


		// gets items wrapper by RowId
		private IEnumerable<Constant> Select(IEnumerable<RowId> rows) {
			foreach(RowId rowId in rows) {
				Constant? item = this.Find(rowId);
				Debug.Assert(item != null, "What is the reason for the item not to be found?");
				yield return item;
			}
		}

		// Create wrapper for the row and register it in the dictionary
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Performance", "CA1822:Mark members as static")]
		private Constant Create(RowId rowId, RowId CircuitRowId) {
			Constant item = new Constant(this.CircuitProject, rowId, CircuitRowId);
			return item;
		}

		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1506:AvoidExcessiveClassCoupling")]
		internal Constant FindOrCreate(RowId rowId) {
			Debug.Assert(!rowId.IsEmpty && !this.Table.IsDeleted(rowId), "Bad RowId");
			Constant? item;
			if((item = this.Find(rowId)) != null) {
				Debug.Assert(!item.IsDeleted(), "Deleted item should not be present in the dictionary");
				return item;
			}
			Guid primaryKeyValue = this.Table.GetField(rowId, ConstantData.ConstantIdField.Field);


			TableSnapshot<CircuitData>? tableCircuit = (TableSnapshot<CircuitData>?)this.CircuitProject.Table("Circuit");
			Debug.Assert(tableCircuit != null);
			return this.Create(rowId, tableCircuit.Find(CircuitData.CircuitIdField.Field, primaryKeyValue));
		}

		// Creates Constant wrapper
		private Constant CreateItem(
			// Fields of Constant table
			Guid ConstantId,
			int BitWidth,
			int Value,
			PinSide PinSide,
			string Note
			// Fields of Circuit table

		) {
			TableSnapshot<CircuitData>? tableCircuit = (TableSnapshot<CircuitData>?)this.CircuitProject.Table("Circuit");
			Debug.Assert(tableCircuit != null);
			CircuitData dataCircuit = new CircuitData() {
				CircuitId = ConstantId
			};
			RowId rowIdCircuit = tableCircuit.Insert(ref dataCircuit);

			ConstantData dataConstant = new ConstantData() {
				ConstantId = ConstantId,
				BitWidth = BitWidth,
				Value = Value,
				PinSide = PinSide,
				Note = Note,
			};
			return this.Create(this.Table.Insert(ref dataConstant), rowIdCircuit);
		}

		// Search helpers

		// Finds Constant by ConstantId
		public Constant? FindByConstantId(Guid constantId) {
			return this.Find(this.Table.Find(ConstantData.ConstantIdField.Field, constantId));
		}

		public IEnumerator<Constant> GetEnumerator() {
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

		internal List<Constant>? UpdateSet(int oldVersion, int newVersion) {
			IEnumerator<TableChange<ConstantData>>? change = this.Table.GetVersionChangeChanges(oldVersion, newVersion);
			if(change != null) {
				bool handlerAttached = (this.CollectionChanged != null);
				List<Constant>? del = (handlerAttached) ? new List<Constant>() : null;
				while(change.MoveNext()) {
					switch(change.Current.Action) {
					case SnapTableAction.Insert:
						this.FindOrCreate(change.Current.RowId);
						Debug.Assert(this.Find(change.Current.RowId) != null, "Why the item was not created?");
						break;
					case SnapTableAction.Delete:
						if(handlerAttached) {
							Constant item = change.Current.GetOldField(ConstantData.ConstantField.Field);
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

		internal void NotifyVersionChanged(int oldVersion, int newVersion, List<Constant>? deleted) {
			IEnumerator<TableChange<ConstantData>>? change = this.Table.GetVersionChangeChanges(oldVersion, newVersion);
			if(change != null) {
				bool handlerAttached = (this.CollectionChanged != null);
				List<Constant>? add = (handlerAttached) ? new List<Constant>() : null;
				this.StartNotifyConstantSetChanged(oldVersion, newVersion);
				while(change.MoveNext()) {
					this.NotifyConstantSetChanged(change.Current);
					switch(change.Current.Action) {
					case SnapTableAction.Insert:
						Debug.Assert(this.Find(change.Current.RowId) != null, "Why the item was not created?");
						if(handlerAttached) {
							add!.Add(this.Find(change.Current.RowId)!);
						}
						break;
					case SnapTableAction.Delete:
						Debug.Assert(change.Current.GetOldField(ConstantData.ConstantField.Field).IsDeleted(), "Why the item still exists?");
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
				this.EndNotifyConstantSetChanged();
			}
		}

		partial void StartNotifyConstantSetChanged(int oldVersion, int newVersion);
		partial void EndNotifyConstantSetChanged();
		partial void NotifyConstantSetChanged(TableChange<ConstantData> change);

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
