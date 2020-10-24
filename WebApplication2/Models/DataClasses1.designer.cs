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

namespace WebApplication2.Models
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Database1")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertBooking(Booking instance);
    partial void UpdateBooking(Booking instance);
    partial void DeleteBooking(Booking instance);
    partial void InsertUser(User instance);
    partial void UpdateUser(User instance);
    partial void DeleteUser(User instance);
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["Database1ConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Booking> Bookings
		{
			get
			{
				return this.GetTable<Booking>();
			}
		}
		
		public System.Data.Linq.Table<User> Users
		{
			get
			{
				return this.GetTable<User>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Booking")]
	public partial class Booking : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _check_out;
		
		private System.Nullable<int> _no_children;
		
		private System.Nullable<int> _no_adult;
		
		private string _check_in;
		
		private string _room_type;
		
		private int _Customer_id;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Oncheck_outChanging(string value);
    partial void Oncheck_outChanged();
    partial void Onno_childrenChanging(System.Nullable<int> value);
    partial void Onno_childrenChanged();
    partial void Onno_adultChanging(System.Nullable<int> value);
    partial void Onno_adultChanged();
    partial void Oncheck_inChanging(string value);
    partial void Oncheck_inChanged();
    partial void Onroom_typeChanging(string value);
    partial void Onroom_typeChanged();
    partial void OnCustomer_idChanging(int value);
    partial void OnCustomer_idChanged();
    #endregion
		
		public Booking()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_check_out", DbType="NChar(10) NOT NULL", CanBeNull=false)]
		public string check_out
		{
			get
			{
				return this._check_out;
			}
			set
			{
				if ((this._check_out != value))
				{
					this.Oncheck_outChanging(value);
					this.SendPropertyChanging();
					this._check_out = value;
					this.SendPropertyChanged("check_out");
					this.Oncheck_outChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_no_children", DbType="Int")]
		public System.Nullable<int> no_children
		{
			get
			{
				return this._no_children;
			}
			set
			{
				if ((this._no_children != value))
				{
					this.Onno_childrenChanging(value);
					this.SendPropertyChanging();
					this._no_children = value;
					this.SendPropertyChanged("no_children");
					this.Onno_childrenChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_no_adult", DbType="Int")]
		public System.Nullable<int> no_adult
		{
			get
			{
				return this._no_adult;
			}
			set
			{
				if ((this._no_adult != value))
				{
					this.Onno_adultChanging(value);
					this.SendPropertyChanging();
					this._no_adult = value;
					this.SendPropertyChanged("no_adult");
					this.Onno_adultChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_check_in", DbType="NChar(10) NOT NULL", CanBeNull=false)]
		public string check_in
		{
			get
			{
				return this._check_in;
			}
			set
			{
				if ((this._check_in != value))
				{
					this.Oncheck_inChanging(value);
					this.SendPropertyChanging();
					this._check_in = value;
					this.SendPropertyChanged("check_in");
					this.Oncheck_inChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_room_type", DbType="NChar(10) NOT NULL", CanBeNull=false)]
		public string room_type
		{
			get
			{
				return this._room_type;
			}
			set
			{
				if ((this._room_type != value))
				{
					this.Onroom_typeChanging(value);
					this.SendPropertyChanging();
					this._room_type = value;
					this.SendPropertyChanged("room_type");
					this.Onroom_typeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Customer_id", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int Customer_id
		{
			get
			{
				return this._Customer_id;
			}
			set
			{
				if ((this._Customer_id != value))
				{
					this.OnCustomer_idChanging(value);
					this.SendPropertyChanging();
					this._Customer_id = value;
					this.SendPropertyChanged("Customer_id");
					this.OnCustomer_idChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Users")]
	public partial class User : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _USERNAME;
		
		private string _EMAIL;
		
		private string _PASSWORD;
		
		private string _GENDER;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnUSERNAMEChanging(string value);
    partial void OnUSERNAMEChanged();
    partial void OnEMAILChanging(string value);
    partial void OnEMAILChanged();
    partial void OnPASSWORDChanging(string value);
    partial void OnPASSWORDChanged();
    partial void OnGENDERChanging(string value);
    partial void OnGENDERChanged();
    #endregion
		
		public User()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", DbType="Int NOT NULL", IsPrimaryKey=true)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_USERNAME", DbType="VarChar(50)")]
		public string USERNAME
		{
			get
			{
				return this._USERNAME;
			}
			set
			{
				if ((this._USERNAME != value))
				{
					this.OnUSERNAMEChanging(value);
					this.SendPropertyChanging();
					this._USERNAME = value;
					this.SendPropertyChanged("USERNAME");
					this.OnUSERNAMEChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EMAIL", DbType="VarChar(50)")]
		public string EMAIL
		{
			get
			{
				return this._EMAIL;
			}
			set
			{
				if ((this._EMAIL != value))
				{
					this.OnEMAILChanging(value);
					this.SendPropertyChanging();
					this._EMAIL = value;
					this.SendPropertyChanged("EMAIL");
					this.OnEMAILChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PASSWORD", DbType="VarChar(50)")]
		public string PASSWORD
		{
			get
			{
				return this._PASSWORD;
			}
			set
			{
				if ((this._PASSWORD != value))
				{
					this.OnPASSWORDChanging(value);
					this.SendPropertyChanging();
					this._PASSWORD = value;
					this.SendPropertyChanged("PASSWORD");
					this.OnPASSWORDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GENDER", DbType="VarChar(50)")]
		public string GENDER
		{
			get
			{
				return this._GENDER;
			}
			set
			{
				if ((this._GENDER != value))
				{
					this.OnGENDERChanging(value);
					this.SendPropertyChanging();
					this._GENDER = value;
					this.SendPropertyChanged("GENDER");
					this.OnGENDERChanged();
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
