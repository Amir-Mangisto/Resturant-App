#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ResturantUsingMvcEtLts.Models
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="ResturantDB")]
	public partial class OrdersDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertOrder(Order instance);
    partial void UpdateOrder(Order instance);
    partial void DeleteOrder(Order instance);
    #endregion
		
		public OrdersDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["ResturantDBConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public OrdersDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public OrdersDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public OrdersDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public OrdersDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Order> Orders
		{
			get
			{
				return this.GetTable<Order>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Orders")]
	public partial class Order : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private System.Nullable<int> _ClientId;
		
		private System.Nullable<int> _EmployeeNumber;
		
		private string _OrderDate;
		
		private System.Nullable<int> _Paid;
		
		private System.Nullable<int> _GeneralPrice;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnClientIdChanging(System.Nullable<int> value);
    partial void OnClientIdChanged();
    partial void OnEmployeeNumberChanging(System.Nullable<int> value);
    partial void OnEmployeeNumberChanged();
    partial void OnOrderDateChanging(string value);
    partial void OnOrderDateChanged();
    partial void OnPaidChanging(System.Nullable<int> value);
    partial void OnPaidChanged();
    partial void OnGeneralPriceChanging(System.Nullable<int> value);
    partial void OnGeneralPriceChanged();
    #endregion
		
		public Order()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ClientId", DbType="Int")]
		public System.Nullable<int> ClientId
		{
			get
			{
				return this._ClientId;
			}
			set
			{
				if ((this._ClientId != value))
				{
					this.OnClientIdChanging(value);
					this.SendPropertyChanging();
					this._ClientId = value;
					this.SendPropertyChanged("ClientId");
					this.OnClientIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EmployeeNumber", DbType="Int")]
		public System.Nullable<int> EmployeeNumber
		{
			get
			{
				return this._EmployeeNumber;
			}
			set
			{
				if ((this._EmployeeNumber != value))
				{
					this.OnEmployeeNumberChanging(value);
					this.SendPropertyChanging();
					this._EmployeeNumber = value;
					this.SendPropertyChanged("EmployeeNumber");
					this.OnEmployeeNumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OrderDate", DbType="VarChar(50)")]
		public string OrderDate
		{
			get
			{
				return this._OrderDate;
			}
			set
			{
				if ((this._OrderDate != value))
				{
					this.OnOrderDateChanging(value);
					this.SendPropertyChanging();
					this._OrderDate = value;
					this.SendPropertyChanged("OrderDate");
					this.OnOrderDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Paid", DbType="Int")]
		public System.Nullable<int> Paid
		{
			get
			{
				return this._Paid;
			}
			set
			{
				if ((this._Paid != value))
				{
					this.OnPaidChanging(value);
					this.SendPropertyChanging();
					this._Paid = value;
					this.SendPropertyChanged("Paid");
					this.OnPaidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GeneralPrice", DbType="Int")]
		public System.Nullable<int> GeneralPrice
		{
			get
			{
				return this._GeneralPrice;
			}
			set
			{
				if ((this._GeneralPrice != value))
				{
					this.OnGeneralPriceChanging(value);
					this.SendPropertyChanging();
					this._GeneralPrice = value;
					this.SendPropertyChanged("GeneralPrice");
					this.OnGeneralPriceChanged();
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
}
#pragma warning restore 1591
