﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.4927
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BA.MultiMvc.Sample.Models.Infrastructure.Linq
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
	
	
	[System.Data.Linq.Mapping.DatabaseAttribute(Name="MultiMVCSampleDB")]
	public partial class DBDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertRessource(Ressource instance);
    partial void UpdateRessource(Ressource instance);
    partial void DeleteRessource(Ressource instance);
    partial void InsertUser(User instance);
    partial void UpdateUser(User instance);
    partial void DeleteUser(User instance);
    #endregion
		
		public DBDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["MultiMVCSampleDBConnectionString1"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DBDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DBDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DBDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DBDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Ressource> Ressources
		{
			get
			{
				return this.GetTable<Ressource>();
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
	
	[Table(Name="dbo.Ressources")]
	public partial class Ressource : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _RessourceID;
		
		private string _RessourceLanguage;
		
		private string _RessourceKey;
		
		private string _RessourceValue;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnRessourceIDChanging(int value);
    partial void OnRessourceIDChanged();
    partial void OnRessourceLanguageChanging(string value);
    partial void OnRessourceLanguageChanged();
    partial void OnRessourceKeyChanging(string value);
    partial void OnRessourceKeyChanged();
    partial void OnRessourceValueChanging(string value);
    partial void OnRessourceValueChanged();
    #endregion
		
		public Ressource()
		{
			OnCreated();
		}
		
		[Column(Storage="_RessourceID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int RessourceID
		{
			get
			{
				return this._RessourceID;
			}
			set
			{
				if ((this._RessourceID != value))
				{
					this.OnRessourceIDChanging(value);
					this.SendPropertyChanging();
					this._RessourceID = value;
					this.SendPropertyChanged("RessourceID");
					this.OnRessourceIDChanged();
				}
			}
		}
		
		[Column(Storage="_RessourceLanguage", DbType="NVarChar(2) NOT NULL", CanBeNull=false)]
		public string RessourceLanguage
		{
			get
			{
				return this._RessourceLanguage;
			}
			set
			{
				if ((this._RessourceLanguage != value))
				{
					this.OnRessourceLanguageChanging(value);
					this.SendPropertyChanging();
					this._RessourceLanguage = value;
					this.SendPropertyChanged("RessourceLanguage");
					this.OnRessourceLanguageChanged();
				}
			}
		}
		
		[Column(Storage="_RessourceKey", DbType="NVarChar(255) NOT NULL", CanBeNull=false)]
		public string RessourceKey
		{
			get
			{
				return this._RessourceKey;
			}
			set
			{
				if ((this._RessourceKey != value))
				{
					this.OnRessourceKeyChanging(value);
					this.SendPropertyChanging();
					this._RessourceKey = value;
					this.SendPropertyChanged("RessourceKey");
					this.OnRessourceKeyChanged();
				}
			}
		}
		
		[Column(Storage="_RessourceValue", DbType="Text NOT NULL", CanBeNull=false, UpdateCheck=UpdateCheck.Never)]
		public string RessourceValue
		{
			get
			{
				return this._RessourceValue;
			}
			set
			{
				if ((this._RessourceValue != value))
				{
					this.OnRessourceValueChanging(value);
					this.SendPropertyChanging();
					this._RessourceValue = value;
					this.SendPropertyChanged("RessourceValue");
					this.OnRessourceValueChanged();
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
	
	[Table(Name="dbo.Users")]
	public partial class User : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _UserID;
		
		private string _UserName;
		
		private string _PasswordHash;
		
		private System.DateTime _RegistrationDate;
		
		private string _PasswordSalt;
		
		private string _EmailAddress;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnUserIDChanging(int value);
    partial void OnUserIDChanged();
    partial void OnUserNameChanging(string value);
    partial void OnUserNameChanged();
    partial void OnPasswordHashChanging(string value);
    partial void OnPasswordHashChanged();
    partial void OnRegistrationDateChanging(System.DateTime value);
    partial void OnRegistrationDateChanged();
    partial void OnPasswordSaltChanging(string value);
    partial void OnPasswordSaltChanged();
    partial void OnEmailAddressChanging(string value);
    partial void OnEmailAddressChanged();
    #endregion
		
		public User()
		{
			OnCreated();
		}
		
		[Column(Storage="_UserID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int UserID
		{
			get
			{
				return this._UserID;
			}
			set
			{
				if ((this._UserID != value))
				{
					this.OnUserIDChanging(value);
					this.SendPropertyChanging();
					this._UserID = value;
					this.SendPropertyChanged("UserID");
					this.OnUserIDChanged();
				}
			}
		}
		
		[Column(Storage="_UserName", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string UserName
		{
			get
			{
				return this._UserName;
			}
			set
			{
				if ((this._UserName != value))
				{
					this.OnUserNameChanging(value);
					this.SendPropertyChanging();
					this._UserName = value;
					this.SendPropertyChanged("UserName");
					this.OnUserNameChanged();
				}
			}
		}
		
		[Column(Storage="_PasswordHash", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string PasswordHash
		{
			get
			{
				return this._PasswordHash;
			}
			set
			{
				if ((this._PasswordHash != value))
				{
					this.OnPasswordHashChanging(value);
					this.SendPropertyChanging();
					this._PasswordHash = value;
					this.SendPropertyChanged("PasswordHash");
					this.OnPasswordHashChanged();
				}
			}
		}
		
		[Column(Storage="_RegistrationDate", DbType="SmallDateTime NOT NULL")]
		public System.DateTime RegistrationDate
		{
			get
			{
				return this._RegistrationDate;
			}
			set
			{
				if ((this._RegistrationDate != value))
				{
					this.OnRegistrationDateChanging(value);
					this.SendPropertyChanging();
					this._RegistrationDate = value;
					this.SendPropertyChanged("RegistrationDate");
					this.OnRegistrationDateChanged();
				}
			}
		}
		
		[Column(Storage="_PasswordSalt", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string PasswordSalt
		{
			get
			{
				return this._PasswordSalt;
			}
			set
			{
				if ((this._PasswordSalt != value))
				{
					this.OnPasswordSaltChanging(value);
					this.SendPropertyChanging();
					this._PasswordSalt = value;
					this.SendPropertyChanged("PasswordSalt");
					this.OnPasswordSaltChanged();
				}
			}
		}
		
		[Column(Storage="_EmailAddress", DbType="NVarChar(255) NOT NULL", CanBeNull=false)]
		public string EmailAddress
		{
			get
			{
				return this._EmailAddress;
			}
			set
			{
				if ((this._EmailAddress != value))
				{
					this.OnEmailAddressChanging(value);
					this.SendPropertyChanging();
					this._EmailAddress = value;
					this.SendPropertyChanged("EmailAddress");
					this.OnEmailAddressChanged();
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
