﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Hotel
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="HotelManaging")]
	public partial class HotelManagingDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertCUSTOMER(CUSTOMER instance);
    partial void UpdateCUSTOMER(CUSTOMER instance);
    partial void DeleteCUSTOMER(CUSTOMER instance);
    partial void InsertRELATION_CUSTOMER_BOOKING(RELATION_CUSTOMER_BOOKING instance);
    partial void UpdateRELATION_CUSTOMER_BOOKING(RELATION_CUSTOMER_BOOKING instance);
    partial void DeleteRELATION_CUSTOMER_BOOKING(RELATION_CUSTOMER_BOOKING instance);
    partial void InsertBOOKING_DETAIL(BOOKING_DETAIL instance);
    partial void UpdateBOOKING_DETAIL(BOOKING_DETAIL instance);
    partial void DeleteBOOKING_DETAIL(BOOKING_DETAIL instance);
    #endregion
		
		public HotelManagingDataContext() : 
				base(global::Hotel.Properties.Settings.Default.HotelManagingConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public HotelManagingDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public HotelManagingDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public HotelManagingDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public HotelManagingDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<CUSTOMER> CUSTOMERs
		{
			get
			{
				return this.GetTable<CUSTOMER>();
			}
		}
		
		public System.Data.Linq.Table<RELATION_CUSTOMER_BOOKING> RELATION_CUSTOMER_BOOKINGs
		{
			get
			{
				return this.GetTable<RELATION_CUSTOMER_BOOKING>();
			}
		}
		
		public System.Data.Linq.Table<BOOKING_DETAIL> BOOKING_DETAILs
		{
			get
			{
				return this.GetTable<BOOKING_DETAIL>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.CUSTOMER")]
	public partial class CUSTOMER : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _CUSTOMER_ID;
		
		private string _CUSTOMER_NAME;
		
		private string _CUSTOMER_ADDRESS;
		
		private int _CUSTOMER_PHONENO;
		
		private string _CUSTOMER_COUNTRY;
		
		private string _CUSTOMER_EMAIL_ADDRESS;
		
		private EntitySet<RELATION_CUSTOMER_BOOKING> _RELATION_CUSTOMER_BOOKINGs;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCUSTOMER_IDChanging(string value);
    partial void OnCUSTOMER_IDChanged();
    partial void OnCUSTOMER_NAMEChanging(string value);
    partial void OnCUSTOMER_NAMEChanged();
    partial void OnCUSTOMER_ADDRESSChanging(string value);
    partial void OnCUSTOMER_ADDRESSChanged();
    partial void OnCUSTOMER_PHONENOChanging(int value);
    partial void OnCUSTOMER_PHONENOChanged();
    partial void OnCUSTOMER_COUNTRYChanging(string value);
    partial void OnCUSTOMER_COUNTRYChanged();
    partial void OnCUSTOMER_EMAIL_ADDRESSChanging(string value);
    partial void OnCUSTOMER_EMAIL_ADDRESSChanged();
    #endregion
		
		public CUSTOMER()
		{
			this._RELATION_CUSTOMER_BOOKINGs = new EntitySet<RELATION_CUSTOMER_BOOKING>(new Action<RELATION_CUSTOMER_BOOKING>(this.attach_RELATION_CUSTOMER_BOOKINGs), new Action<RELATION_CUSTOMER_BOOKING>(this.detach_RELATION_CUSTOMER_BOOKINGs));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CUSTOMER_ID", DbType="Char(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string CUSTOMER_ID
		{
			get
			{
				return this._CUSTOMER_ID;
			}
			set
			{
				if ((this._CUSTOMER_ID != value))
				{
					this.OnCUSTOMER_IDChanging(value);
					this.SendPropertyChanging();
					this._CUSTOMER_ID = value;
					this.SendPropertyChanged("CUSTOMER_ID");
					this.OnCUSTOMER_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CUSTOMER_NAME", DbType="Char(20) NOT NULL", CanBeNull=false)]
		public string CUSTOMER_NAME
		{
			get
			{
				return this._CUSTOMER_NAME;
			}
			set
			{
				if ((this._CUSTOMER_NAME != value))
				{
					this.OnCUSTOMER_NAMEChanging(value);
					this.SendPropertyChanging();
					this._CUSTOMER_NAME = value;
					this.SendPropertyChanged("CUSTOMER_NAME");
					this.OnCUSTOMER_NAMEChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CUSTOMER_ADDRESS", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string CUSTOMER_ADDRESS
		{
			get
			{
				return this._CUSTOMER_ADDRESS;
			}
			set
			{
				if ((this._CUSTOMER_ADDRESS != value))
				{
					this.OnCUSTOMER_ADDRESSChanging(value);
					this.SendPropertyChanging();
					this._CUSTOMER_ADDRESS = value;
					this.SendPropertyChanged("CUSTOMER_ADDRESS");
					this.OnCUSTOMER_ADDRESSChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CUSTOMER_PHONENO", DbType="Int NOT NULL")]
		public int CUSTOMER_PHONENO
		{
			get
			{
				return this._CUSTOMER_PHONENO;
			}
			set
			{
				if ((this._CUSTOMER_PHONENO != value))
				{
					this.OnCUSTOMER_PHONENOChanging(value);
					this.SendPropertyChanging();
					this._CUSTOMER_PHONENO = value;
					this.SendPropertyChanged("CUSTOMER_PHONENO");
					this.OnCUSTOMER_PHONENOChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CUSTOMER_COUNTRY", DbType="Char(20) NOT NULL", CanBeNull=false)]
		public string CUSTOMER_COUNTRY
		{
			get
			{
				return this._CUSTOMER_COUNTRY;
			}
			set
			{
				if ((this._CUSTOMER_COUNTRY != value))
				{
					this.OnCUSTOMER_COUNTRYChanging(value);
					this.SendPropertyChanging();
					this._CUSTOMER_COUNTRY = value;
					this.SendPropertyChanged("CUSTOMER_COUNTRY");
					this.OnCUSTOMER_COUNTRYChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CUSTOMER_EMAIL_ADDRESS", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string CUSTOMER_EMAIL_ADDRESS
		{
			get
			{
				return this._CUSTOMER_EMAIL_ADDRESS;
			}
			set
			{
				if ((this._CUSTOMER_EMAIL_ADDRESS != value))
				{
					this.OnCUSTOMER_EMAIL_ADDRESSChanging(value);
					this.SendPropertyChanging();
					this._CUSTOMER_EMAIL_ADDRESS = value;
					this.SendPropertyChanged("CUSTOMER_EMAIL_ADDRESS");
					this.OnCUSTOMER_EMAIL_ADDRESSChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="CUSTOMER_RELATION_CUSTOMER_BOOKING", Storage="_RELATION_CUSTOMER_BOOKINGs", ThisKey="CUSTOMER_ID", OtherKey="CUSTOMER_ID2")]
		public EntitySet<RELATION_CUSTOMER_BOOKING> RELATION_CUSTOMER_BOOKINGs
		{
			get
			{
				return this._RELATION_CUSTOMER_BOOKINGs;
			}
			set
			{
				this._RELATION_CUSTOMER_BOOKINGs.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_RELATION_CUSTOMER_BOOKINGs(RELATION_CUSTOMER_BOOKING entity)
		{
			this.SendPropertyChanging();
			entity.CUSTOMER = this;
		}
		
		private void detach_RELATION_CUSTOMER_BOOKINGs(RELATION_CUSTOMER_BOOKING entity)
		{
			this.SendPropertyChanging();
			entity.CUSTOMER = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.RELATION_CUSTOMER_BOOKING")]
	public partial class RELATION_CUSTOMER_BOOKING : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _CUSTOMER_ID1;
		
		private string _BOOKING_DETAILS_ID1;
		
		private string _CUSTOMER_ID2;
		
		private EntityRef<CUSTOMER> _CUSTOMER;
		
		private EntityRef<BOOKING_DETAIL> _BOOKING_DETAIL;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCUSTOMER_ID1Changing(string value);
    partial void OnCUSTOMER_ID1Changed();
    partial void OnBOOKING_DETAILS_ID1Changing(string value);
    partial void OnBOOKING_DETAILS_ID1Changed();
    partial void OnCUSTOMER_ID2Changing(string value);
    partial void OnCUSTOMER_ID2Changed();
    #endregion
		
		public RELATION_CUSTOMER_BOOKING()
		{
			this._CUSTOMER = default(EntityRef<CUSTOMER>);
			this._BOOKING_DETAIL = default(EntityRef<BOOKING_DETAIL>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CUSTOMER_ID1", DbType="Char(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string CUSTOMER_ID1
		{
			get
			{
				return this._CUSTOMER_ID1;
			}
			set
			{
				if ((this._CUSTOMER_ID1 != value))
				{
					this.OnCUSTOMER_ID1Changing(value);
					this.SendPropertyChanging();
					this._CUSTOMER_ID1 = value;
					this.SendPropertyChanged("CUSTOMER_ID1");
					this.OnCUSTOMER_ID1Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BOOKING_DETAILS_ID1", DbType="Char(10) NOT NULL", CanBeNull=false)]
		public string BOOKING_DETAILS_ID1
		{
			get
			{
				return this._BOOKING_DETAILS_ID1;
			}
			set
			{
				if ((this._BOOKING_DETAILS_ID1 != value))
				{
					if (this._BOOKING_DETAIL.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnBOOKING_DETAILS_ID1Changing(value);
					this.SendPropertyChanging();
					this._BOOKING_DETAILS_ID1 = value;
					this.SendPropertyChanged("BOOKING_DETAILS_ID1");
					this.OnBOOKING_DETAILS_ID1Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CUSTOMER_ID2", DbType="Char(10)")]
		public string CUSTOMER_ID2
		{
			get
			{
				return this._CUSTOMER_ID2;
			}
			set
			{
				if ((this._CUSTOMER_ID2 != value))
				{
					if (this._CUSTOMER.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnCUSTOMER_ID2Changing(value);
					this.SendPropertyChanging();
					this._CUSTOMER_ID2 = value;
					this.SendPropertyChanged("CUSTOMER_ID2");
					this.OnCUSTOMER_ID2Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="CUSTOMER_RELATION_CUSTOMER_BOOKING", Storage="_CUSTOMER", ThisKey="CUSTOMER_ID2", OtherKey="CUSTOMER_ID", IsForeignKey=true)]
		public CUSTOMER CUSTOMER
		{
			get
			{
				return this._CUSTOMER.Entity;
			}
			set
			{
				CUSTOMER previousValue = this._CUSTOMER.Entity;
				if (((previousValue != value) 
							|| (this._CUSTOMER.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._CUSTOMER.Entity = null;
						previousValue.RELATION_CUSTOMER_BOOKINGs.Remove(this);
					}
					this._CUSTOMER.Entity = value;
					if ((value != null))
					{
						value.RELATION_CUSTOMER_BOOKINGs.Add(this);
						this._CUSTOMER_ID2 = value.CUSTOMER_ID;
					}
					else
					{
						this._CUSTOMER_ID2 = default(string);
					}
					this.SendPropertyChanged("CUSTOMER");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="BOOKING_DETAIL_RELATION_CUSTOMER_BOOKING", Storage="_BOOKING_DETAIL", ThisKey="BOOKING_DETAILS_ID1", OtherKey="BOOKING_DETAILS_ID", IsForeignKey=true)]
		public BOOKING_DETAIL BOOKING_DETAIL
		{
			get
			{
				return this._BOOKING_DETAIL.Entity;
			}
			set
			{
				BOOKING_DETAIL previousValue = this._BOOKING_DETAIL.Entity;
				if (((previousValue != value) 
							|| (this._BOOKING_DETAIL.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._BOOKING_DETAIL.Entity = null;
						previousValue.RELATION_CUSTOMER_BOOKINGs.Remove(this);
					}
					this._BOOKING_DETAIL.Entity = value;
					if ((value != null))
					{
						value.RELATION_CUSTOMER_BOOKINGs.Add(this);
						this._BOOKING_DETAILS_ID1 = value.BOOKING_DETAILS_ID;
					}
					else
					{
						this._BOOKING_DETAILS_ID1 = default(string);
					}
					this.SendPropertyChanged("BOOKING_DETAIL");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.BOOKING_DETAILS")]
	public partial class BOOKING_DETAIL : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _BOOKING_DETAILS_ID;
		
		private System.DateTime _BD_START_DATE;
		
		private System.DateTime _BD_END_DATE;
		
		private int _BD_QUANTITY;
		
		private decimal _BD_TOTAL_PRICE;
		
		private System.Nullable<int> _ADVERTISEMENT_ID2;
		
		private string _RESERVATION_ID;
		
		private EntitySet<RELATION_CUSTOMER_BOOKING> _RELATION_CUSTOMER_BOOKINGs;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnBOOKING_DETAILS_IDChanging(string value);
    partial void OnBOOKING_DETAILS_IDChanged();
    partial void OnBD_START_DATEChanging(System.DateTime value);
    partial void OnBD_START_DATEChanged();
    partial void OnBD_END_DATEChanging(System.DateTime value);
    partial void OnBD_END_DATEChanged();
    partial void OnBD_QUANTITYChanging(int value);
    partial void OnBD_QUANTITYChanged();
    partial void OnBD_TOTAL_PRICEChanging(decimal value);
    partial void OnBD_TOTAL_PRICEChanged();
    partial void OnADVERTISEMENT_ID2Changing(System.Nullable<int> value);
    partial void OnADVERTISEMENT_ID2Changed();
    partial void OnRESERVATION_IDChanging(string value);
    partial void OnRESERVATION_IDChanged();
    #endregion
		
		public BOOKING_DETAIL()
		{
			this._RELATION_CUSTOMER_BOOKINGs = new EntitySet<RELATION_CUSTOMER_BOOKING>(new Action<RELATION_CUSTOMER_BOOKING>(this.attach_RELATION_CUSTOMER_BOOKINGs), new Action<RELATION_CUSTOMER_BOOKING>(this.detach_RELATION_CUSTOMER_BOOKINGs));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BOOKING_DETAILS_ID", DbType="Char(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string BOOKING_DETAILS_ID
		{
			get
			{
				return this._BOOKING_DETAILS_ID;
			}
			set
			{
				if ((this._BOOKING_DETAILS_ID != value))
				{
					this.OnBOOKING_DETAILS_IDChanging(value);
					this.SendPropertyChanging();
					this._BOOKING_DETAILS_ID = value;
					this.SendPropertyChanged("BOOKING_DETAILS_ID");
					this.OnBOOKING_DETAILS_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BD_START_DATE", DbType="DateTime NOT NULL")]
		public System.DateTime BD_START_DATE
		{
			get
			{
				return this._BD_START_DATE;
			}
			set
			{
				if ((this._BD_START_DATE != value))
				{
					this.OnBD_START_DATEChanging(value);
					this.SendPropertyChanging();
					this._BD_START_DATE = value;
					this.SendPropertyChanged("BD_START_DATE");
					this.OnBD_START_DATEChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BD_END_DATE", DbType="DateTime NOT NULL")]
		public System.DateTime BD_END_DATE
		{
			get
			{
				return this._BD_END_DATE;
			}
			set
			{
				if ((this._BD_END_DATE != value))
				{
					this.OnBD_END_DATEChanging(value);
					this.SendPropertyChanging();
					this._BD_END_DATE = value;
					this.SendPropertyChanged("BD_END_DATE");
					this.OnBD_END_DATEChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BD_QUANTITY", DbType="Int NOT NULL")]
		public int BD_QUANTITY
		{
			get
			{
				return this._BD_QUANTITY;
			}
			set
			{
				if ((this._BD_QUANTITY != value))
				{
					this.OnBD_QUANTITYChanging(value);
					this.SendPropertyChanging();
					this._BD_QUANTITY = value;
					this.SendPropertyChanged("BD_QUANTITY");
					this.OnBD_QUANTITYChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BD_TOTAL_PRICE", DbType="Decimal(7,2) NOT NULL")]
		public decimal BD_TOTAL_PRICE
		{
			get
			{
				return this._BD_TOTAL_PRICE;
			}
			set
			{
				if ((this._BD_TOTAL_PRICE != value))
				{
					this.OnBD_TOTAL_PRICEChanging(value);
					this.SendPropertyChanging();
					this._BD_TOTAL_PRICE = value;
					this.SendPropertyChanged("BD_TOTAL_PRICE");
					this.OnBD_TOTAL_PRICEChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ADVERTISEMENT_ID2", DbType="Int")]
		public System.Nullable<int> ADVERTISEMENT_ID2
		{
			get
			{
				return this._ADVERTISEMENT_ID2;
			}
			set
			{
				if ((this._ADVERTISEMENT_ID2 != value))
				{
					this.OnADVERTISEMENT_ID2Changing(value);
					this.SendPropertyChanging();
					this._ADVERTISEMENT_ID2 = value;
					this.SendPropertyChanged("ADVERTISEMENT_ID2");
					this.OnADVERTISEMENT_ID2Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RESERVATION_ID", DbType="Char(10)")]
		public string RESERVATION_ID
		{
			get
			{
				return this._RESERVATION_ID;
			}
			set
			{
				if ((this._RESERVATION_ID != value))
				{
					this.OnRESERVATION_IDChanging(value);
					this.SendPropertyChanging();
					this._RESERVATION_ID = value;
					this.SendPropertyChanged("RESERVATION_ID");
					this.OnRESERVATION_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="BOOKING_DETAIL_RELATION_CUSTOMER_BOOKING", Storage="_RELATION_CUSTOMER_BOOKINGs", ThisKey="BOOKING_DETAILS_ID", OtherKey="BOOKING_DETAILS_ID1")]
		public EntitySet<RELATION_CUSTOMER_BOOKING> RELATION_CUSTOMER_BOOKINGs
		{
			get
			{
				return this._RELATION_CUSTOMER_BOOKINGs;
			}
			set
			{
				this._RELATION_CUSTOMER_BOOKINGs.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_RELATION_CUSTOMER_BOOKINGs(RELATION_CUSTOMER_BOOKING entity)
		{
			this.SendPropertyChanging();
			entity.BOOKING_DETAIL = this;
		}
		
		private void detach_RELATION_CUSTOMER_BOOKINGs(RELATION_CUSTOMER_BOOKING entity)
		{
			this.SendPropertyChanging();
			entity.BOOKING_DETAIL = null;
		}
	}
}
#pragma warning restore 1591