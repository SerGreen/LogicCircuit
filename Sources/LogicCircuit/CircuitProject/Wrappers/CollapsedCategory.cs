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

	// Defines the shape of the table CollapsedCategory
	internal partial struct CollapsedCategoryData {
		public string Name;
		internal CollapsedCategory? CollapsedCategory;
		// Field accessors
		// Accessor of the Name field
		public sealed class NameField : IField<CollapsedCategoryData, string>, IFieldSerializer<CollapsedCategoryData> {
			public static readonly NameField Field = new NameField();
			private NameField() {}
			public string Name { get { return "Name"; } }
			public int Order { get; set; }
			public string DefaultValue { get { return ""; } }
			public string GetValue(ref CollapsedCategoryData record) {
				return record.Name;
			}
			public void SetValue(ref CollapsedCategoryData record, string value) {
				record.Name = value;
			}
			public int Compare(ref CollapsedCategoryData l, ref CollapsedCategoryData r) {
				return StringComparer.Ordinal.Compare(l.Name, r.Name);
			}
			public int Compare(string? l, string? r) {
				return StringComparer.Ordinal.Compare(l, r);
			}

			// Implementation of interface IFieldSerializer<CollapsedCategoryData>
			bool IFieldSerializer<CollapsedCategoryData>.NeedToSave(ref CollapsedCategoryData data) {
				return this.Compare(data.Name, this.DefaultValue) != 0;
			}
			string IFieldSerializer<CollapsedCategoryData>.GetTextValue(ref CollapsedCategoryData data) {
				return string.Format(CultureInfo.InvariantCulture, "{0}", data.Name);
			}
			void IFieldSerializer<CollapsedCategoryData>.SetDefault(ref CollapsedCategoryData data) {
				data.Name = this.DefaultValue;
			}
			void IFieldSerializer<CollapsedCategoryData>.SetTextValue(ref CollapsedCategoryData data, string text) {
				data.Name = text;
			}
		}

		// Special field used to access items wrapper of this record from record.
		// This is used when no other universes is used
		internal sealed class CollapsedCategoryField : IField<CollapsedCategoryData, CollapsedCategory> {
			public static readonly CollapsedCategoryField Field = new CollapsedCategoryField();
			private CollapsedCategoryField() {}
			public string Name { get { return "CollapsedCategoryWrapper"; } }
			public int Order { get; set; }
			public CollapsedCategory DefaultValue { get { return null!; } }
			public CollapsedCategory GetValue(ref CollapsedCategoryData record) {
				return record.CollapsedCategory!;
			}
			public void SetValue(ref CollapsedCategoryData record, CollapsedCategory value) {
				record.CollapsedCategory = value;
			}
			public int Compare(ref CollapsedCategoryData l, ref CollapsedCategoryData r) {
				return this.Compare(l.CollapsedCategory, r.CollapsedCategory);
			}
			public int Compare(CollapsedCategory? l, CollapsedCategory? r) {
				if(object.ReferenceEquals(l, r)) return 0;
				if(l == null) return -1;
				if(r == null) return 1;
				return l.CollapsedCategoryRowId.CompareTo(r.CollapsedCategoryRowId);
			}
		}

		private static readonly IField<CollapsedCategoryData>[] fields = {
			NameField.Field,
			CollapsedCategoryField.Field
		};

		// Creates table.
		public static TableSnapshot<CollapsedCategoryData> CreateTable(StoreSnapshot store) {
			TableSnapshot<CollapsedCategoryData> table = new TableSnapshot<CollapsedCategoryData>(store, "CollapsedCategory", CollapsedCategoryData.fields);
			// Create all but foreign keys of the table
			table.MakeUnique("PK_CollapsedCategory", CollapsedCategoryData.NameField.Field , true);
			// Return created table
			return table;
		}

		// Creates all foreign keys of the table
		public static void CreateForeignKeys(StoreSnapshot store) {
		}
	}

	// Class wrapper for a record.
	partial class CollapsedCategory : INotifyPropertyChanged {

		// RowId of the wrapped record
		internal RowId CollapsedCategoryRowId { get; private set; }
		// Store this wrapper belongs to
		public CircuitProject CircuitProject { get; private set; }

		// Constructor
		#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
		public CollapsedCategory(CircuitProject store, RowId rowIdCollapsedCategory) {
			Debug.Assert(!rowIdCollapsedCategory.IsEmpty);
			this.CircuitProject = store;
			this.CollapsedCategoryRowId = rowIdCollapsedCategory;
			// Link back to record. Assuming that a transaction is started
			this.Table.SetField(this.CollapsedCategoryRowId, CollapsedCategoryData.CollapsedCategoryField.Field, this);
			this.InitializeCollapsedCategory();
		}
		#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

		partial void InitializeCollapsedCategory();

		// Gets table storing this item.
		private TableSnapshot<CollapsedCategoryData> Table { get { return this.CircuitProject.CollapsedCategorySet.Table; } }

		// Deletes object
		public virtual void Delete() {
			this.Table.Delete(this.CollapsedCategoryRowId);
		}

		// Checks if the item is deleted
		public bool IsDeleted() {
			return this.Table.IsDeleted(this.CollapsedCategoryRowId);
		}

		//Properties of CollapsedCategory

		// Gets or sets value of the Name field.
		public string Name {
			get { return this.Table.GetField(this.CollapsedCategoryRowId, CollapsedCategoryData.NameField.Field); }
			set { this.Table.SetField(this.CollapsedCategoryRowId, CollapsedCategoryData.NameField.Field, value); }
		}

		public event PropertyChangedEventHandler? PropertyChanged;

		protected void NotifyPropertyChanged(string name) {
			PropertyChangedEventHandler? handler = this.PropertyChanged;
			if(handler != null) {
				handler(this, new PropertyChangedEventArgs(name));
			}
		}

		protected bool HasListener { get { return this.PropertyChanged != null; } }

		internal void NotifyChanged(TableChange<CollapsedCategoryData> change) {
			if(this.HasListener) {
				CollapsedCategoryData oldData, newData;
				change.GetOldData(out oldData);
				change.GetNewData(out newData);
				if(CollapsedCategoryData.NameField.Field.Compare(ref oldData, ref newData) != 0) {
					this.NotifyPropertyChanged("Name");
				}
			}
			this.OnCollapsedCategoryChanged();
		}

		partial void OnCollapsedCategoryChanged();
	}


	// Wrapper for table CollapsedCategory.
	partial class CollapsedCategorySet : INotifyCollectionChanged, IEnumerable<CollapsedCategory> {

		public event NotifyCollectionChangedEventHandler? CollectionChanged;

		internal TableSnapshot<CollapsedCategoryData> Table { get; private set; }

		// Gets StoreSnapshot this set belongs to.
		public CircuitProject CircuitProject { get { return (CircuitProject)this.Table.StoreSnapshot; } }

		// Constructor
		#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
		public CollapsedCategorySet(CircuitProject store) {
			ITableSnapshot? table = store.Table("CollapsedCategory");
			if(table != null) {
				Debug.Assert(store.IsFrozen, "The store should be frozen");
				this.Table = (TableSnapshot<CollapsedCategoryData>)table;
			} else {
				Debug.Assert(!store.IsFrozen, "In order to create table, the store should not be frozen");
				this.Table = CollapsedCategoryData.CreateTable(store);
			}
			this.InitializeCollapsedCategorySet();
		}
		#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

		partial void InitializeCollapsedCategorySet();

		//internal void Register() {
		//	foreach(RowId rowId in this.Table.Rows) {
		//		this.FindOrCreate(rowId);
		//	}
		//}


		// gets items wrapper by RowId
		public CollapsedCategory? Find(RowId rowId) {
			if(!rowId.IsEmpty) {
				return this.Table.GetField(rowId, CollapsedCategoryData.CollapsedCategoryField.Field);
			}
			return null;
		}


		// gets items wrapper by RowId
		private IEnumerable<CollapsedCategory> Select(IEnumerable<RowId> rows) {
			foreach(RowId rowId in rows) {
				CollapsedCategory? item = this.Find(rowId);
				Debug.Assert(item != null, "What is the reason for the item not to be found?");
				yield return item;
			}
		}

		// Create wrapper for the row and register it in the dictionary
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Performance", "CA1822:Mark members as static")]
		private CollapsedCategory Create(RowId rowId) {
			CollapsedCategory item = new CollapsedCategory(this.CircuitProject, rowId);
			return item;
		}

		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1506:AvoidExcessiveClassCoupling")]
		internal CollapsedCategory FindOrCreate(RowId rowId) {
			Debug.Assert(!rowId.IsEmpty && !this.Table.IsDeleted(rowId), "Bad RowId");
			CollapsedCategory? item;
			if((item = this.Find(rowId)) != null) {
				Debug.Assert(!item.IsDeleted(), "Deleted item should not be present in the dictionary");
				return item;
			}

			return this.Create(rowId);
		}

		// Creates CollapsedCategory wrapper
		private CollapsedCategory CreateItem(
			// Fields of CollapsedCategory table
			string Name
		) {
			CollapsedCategoryData dataCollapsedCategory = new CollapsedCategoryData() {
				Name = Name,
			};
			return this.Create(this.Table.Insert(ref dataCollapsedCategory));
		}

		// Search helpers

		// Finds CollapsedCategory by Name
		public CollapsedCategory? Find(string name) {
			return this.Find(this.Table.Find(CollapsedCategoryData.NameField.Field, name));
		}

		public IEnumerator<CollapsedCategory> GetEnumerator() {
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

		internal List<CollapsedCategory>? UpdateSet(int oldVersion, int newVersion) {
			IEnumerator<TableChange<CollapsedCategoryData>>? change = this.Table.GetVersionChangeChanges(oldVersion, newVersion);
			if(change != null) {
				bool handlerAttached = (this.CollectionChanged != null);
				List<CollapsedCategory>? del = (handlerAttached) ? new List<CollapsedCategory>() : null;
				while(change.MoveNext()) {
					switch(change.Current.Action) {
					case SnapTableAction.Insert:
						this.FindOrCreate(change.Current.RowId);
						Debug.Assert(this.Find(change.Current.RowId) != null, "Why the item was not created?");
						break;
					case SnapTableAction.Delete:
						if(handlerAttached) {
							CollapsedCategory item = change.Current.GetOldField(CollapsedCategoryData.CollapsedCategoryField.Field);
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

		internal void NotifyVersionChanged(int oldVersion, int newVersion, List<CollapsedCategory>? deleted) {
			IEnumerator<TableChange<CollapsedCategoryData>>? change = this.Table.GetVersionChangeChanges(oldVersion, newVersion);
			if(change != null) {
				bool handlerAttached = (this.CollectionChanged != null);
				List<CollapsedCategory>? add = (handlerAttached) ? new List<CollapsedCategory>() : null;
				this.StartNotifyCollapsedCategorySetChanged(oldVersion, newVersion);
				while(change.MoveNext()) {
					this.NotifyCollapsedCategorySetChanged(change.Current);
					switch(change.Current.Action) {
					case SnapTableAction.Insert:
						Debug.Assert(this.Find(change.Current.RowId) != null, "Why the item was not created?");
						if(handlerAttached) {
							add!.Add(this.Find(change.Current.RowId)!);
						}
						break;
					case SnapTableAction.Delete:
						Debug.Assert(change.Current.GetOldField(CollapsedCategoryData.CollapsedCategoryField.Field).IsDeleted(), "Why the item still exists?");
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
				this.EndNotifyCollapsedCategorySetChanged();
			}
		}

		partial void StartNotifyCollapsedCategorySetChanged(int oldVersion, int newVersion);
		partial void EndNotifyCollapsedCategorySetChanged();
		partial void NotifyCollapsedCategorySetChanged(TableChange<CollapsedCategoryData> change);

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
