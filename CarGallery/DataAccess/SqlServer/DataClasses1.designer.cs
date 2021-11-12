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

namespace CarGallery.DataAccess.SqlServer
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="CarGalleryDb")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertPetrolType(PetrolType instance);
    partial void UpdatePetrolType(PetrolType instance);
    partial void DeletePetrolType(PetrolType instance);
    partial void InsertBanType(BanType instance);
    partial void UpdateBanType(BanType instance);
    partial void DeleteBanType(BanType instance);
    partial void InsertBrand(Brand instance);
    partial void UpdateBrand(Brand instance);
    partial void DeleteBrand(Brand instance);
    partial void InsertCarColor(CarColor instance);
    partial void UpdateCarColor(CarColor instance);
    partial void DeleteCarColor(CarColor instance);
    partial void InsertCar(Car instance);
    partial void UpdateCar(Car instance);
    partial void DeleteCar(Car instance);
    partial void InsertImagePath(ImagePath instance);
    partial void UpdateImagePath(ImagePath instance);
    partial void DeleteImagePath(ImagePath instance);
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::CarGallery.Properties.Settings.Default.CarGalleryDbConnectionString2, mappingSource)
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
		
		public System.Data.Linq.Table<PetrolType> PetrolTypes
		{
			get
			{
				return this.GetTable<PetrolType>();
			}
		}
		
		public System.Data.Linq.Table<BanType> BanTypes
		{
			get
			{
				return this.GetTable<BanType>();
			}
		}
		
		public System.Data.Linq.Table<Brand> Brands
		{
			get
			{
				return this.GetTable<Brand>();
			}
		}
		
		public System.Data.Linq.Table<CarColor> CarColors
		{
			get
			{
				return this.GetTable<CarColor>();
			}
		}
		
		public System.Data.Linq.Table<Car> Cars
		{
			get
			{
				return this.GetTable<Car>();
			}
		}
		
		public System.Data.Linq.Table<ImagePath> ImagePaths
		{
			get
			{
				return this.GetTable<ImagePath>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.PetrolTypes")]
	public partial class PetrolType : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Name;
		
		private EntitySet<Car> _Cars;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    #endregion
		
		public PetrolType()
		{
			this._Cars = new EntitySet<Car>(new Action<Car>(this.attach_Cars), new Action<Car>(this.detach_Cars));
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(200) NOT NULL", CanBeNull=false)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PetrolType_Car", Storage="_Cars", ThisKey="Id", OtherKey="PetrolTypes_Id")]
		public EntitySet<Car> Cars
		{
			get
			{
				return this._Cars;
			}
			set
			{
				this._Cars.Assign(value);
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
		
		private void attach_Cars(Car entity)
		{
			this.SendPropertyChanging();
			entity.PetrolType = this;
		}
		
		private void detach_Cars(Car entity)
		{
			this.SendPropertyChanging();
			entity.PetrolType = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.BanTypes")]
	public partial class BanType : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Name;
		
		private EntitySet<Car> _Cars;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    #endregion
		
		public BanType()
		{
			this._Cars = new EntitySet<Car>(new Action<Car>(this.attach_Cars), new Action<Car>(this.detach_Cars));
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(200) NOT NULL", CanBeNull=false)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="BanType_Car", Storage="_Cars", ThisKey="Id", OtherKey="BanType_Id")]
		public EntitySet<Car> Cars
		{
			get
			{
				return this._Cars;
			}
			set
			{
				this._Cars.Assign(value);
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
		
		private void attach_Cars(Car entity)
		{
			this.SendPropertyChanging();
			entity.BanType = this;
		}
		
		private void detach_Cars(Car entity)
		{
			this.SendPropertyChanging();
			entity.BanType = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Brands")]
	public partial class Brand : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Name;
		
		private EntitySet<Car> _Cars;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    #endregion
		
		public Brand()
		{
			this._Cars = new EntitySet<Car>(new Action<Car>(this.attach_Cars), new Action<Car>(this.detach_Cars));
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(200) NOT NULL", CanBeNull=false)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Brand_Car", Storage="_Cars", ThisKey="Id", OtherKey="Brand_Id")]
		public EntitySet<Car> Cars
		{
			get
			{
				return this._Cars;
			}
			set
			{
				this._Cars.Assign(value);
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
		
		private void attach_Cars(Car entity)
		{
			this.SendPropertyChanging();
			entity.Brand = this;
		}
		
		private void detach_Cars(Car entity)
		{
			this.SendPropertyChanging();
			entity.Brand = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.CarColors")]
	public partial class CarColor : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Name;
		
		private EntitySet<Car> _Cars;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    #endregion
		
		public CarColor()
		{
			this._Cars = new EntitySet<Car>(new Action<Car>(this.attach_Cars), new Action<Car>(this.detach_Cars));
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(200) NOT NULL", CanBeNull=false)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="CarColor_Car", Storage="_Cars", ThisKey="Id", OtherKey="CarColors_Id")]
		public EntitySet<Car> Cars
		{
			get
			{
				return this._Cars;
			}
			set
			{
				this._Cars.Assign(value);
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
		
		private void attach_Cars(Car entity)
		{
			this.SendPropertyChanging();
			entity.CarColor = this;
		}
		
		private void detach_Cars(Car entity)
		{
			this.SendPropertyChanging();
			entity.CarColor = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Cars")]
	public partial class Car : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private System.Nullable<int> _Brand_Id;
		
		private System.Nullable<int> _BanType_Id;
		
		private System.Nullable<int> _CarColors_Id;
		
		private System.Nullable<int> _PetrolTypes_Id;
		
		private System.Nullable<bool> _IsNew;
		
		private System.Nullable<int> _Milage;
		
		private int _Release_Date;
		
		private System.Nullable<decimal> _Price;
		
		private System.Nullable<int> _ImagePath_Id;
		
		private EntityRef<BanType> _BanType;
		
		private EntityRef<Brand> _Brand;
		
		private EntityRef<CarColor> _CarColor;
		
		private EntityRef<PetrolType> _PetrolType;
		
		private EntityRef<ImagePath> _ImagePath;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnBrand_IdChanging(System.Nullable<int> value);
    partial void OnBrand_IdChanged();
    partial void OnBanType_IdChanging(System.Nullable<int> value);
    partial void OnBanType_IdChanged();
    partial void OnCarColors_IdChanging(System.Nullable<int> value);
    partial void OnCarColors_IdChanged();
    partial void OnPetrolTypes_IdChanging(System.Nullable<int> value);
    partial void OnPetrolTypes_IdChanged();
    partial void OnIsNewChanging(System.Nullable<bool> value);
    partial void OnIsNewChanged();
    partial void OnMilageChanging(System.Nullable<int> value);
    partial void OnMilageChanged();
    partial void OnRelease_DateChanging(int value);
    partial void OnRelease_DateChanged();
    partial void OnPriceChanging(System.Nullable<decimal> value);
    partial void OnPriceChanged();
    partial void OnImagePath_IdChanging(System.Nullable<int> value);
    partial void OnImagePath_IdChanged();
    #endregion
		
		public Car()
		{
			this._BanType = default(EntityRef<BanType>);
			this._Brand = default(EntityRef<Brand>);
			this._CarColor = default(EntityRef<CarColor>);
			this._PetrolType = default(EntityRef<PetrolType>);
			this._ImagePath = default(EntityRef<ImagePath>);
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Brand_Id", DbType="Int")]
		public System.Nullable<int> Brand_Id
		{
			get
			{
				return this._Brand_Id;
			}
			set
			{
				if ((this._Brand_Id != value))
				{
					if (this._Brand.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnBrand_IdChanging(value);
					this.SendPropertyChanging();
					this._Brand_Id = value;
					this.SendPropertyChanged("Brand_Id");
					this.OnBrand_IdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BanType_Id", DbType="Int")]
		public System.Nullable<int> BanType_Id
		{
			get
			{
				return this._BanType_Id;
			}
			set
			{
				if ((this._BanType_Id != value))
				{
					if (this._BanType.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnBanType_IdChanging(value);
					this.SendPropertyChanging();
					this._BanType_Id = value;
					this.SendPropertyChanged("BanType_Id");
					this.OnBanType_IdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CarColors_Id", DbType="Int")]
		public System.Nullable<int> CarColors_Id
		{
			get
			{
				return this._CarColors_Id;
			}
			set
			{
				if ((this._CarColors_Id != value))
				{
					if (this._CarColor.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnCarColors_IdChanging(value);
					this.SendPropertyChanging();
					this._CarColors_Id = value;
					this.SendPropertyChanged("CarColors_Id");
					this.OnCarColors_IdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PetrolTypes_Id", DbType="Int")]
		public System.Nullable<int> PetrolTypes_Id
		{
			get
			{
				return this._PetrolTypes_Id;
			}
			set
			{
				if ((this._PetrolTypes_Id != value))
				{
					if (this._PetrolType.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnPetrolTypes_IdChanging(value);
					this.SendPropertyChanging();
					this._PetrolTypes_Id = value;
					this.SendPropertyChanged("PetrolTypes_Id");
					this.OnPetrolTypes_IdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IsNew", DbType="Bit")]
		public System.Nullable<bool> IsNew
		{
			get
			{
				return this._IsNew;
			}
			set
			{
				if ((this._IsNew != value))
				{
					this.OnIsNewChanging(value);
					this.SendPropertyChanging();
					this._IsNew = value;
					this.SendPropertyChanged("IsNew");
					this.OnIsNewChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Milage", DbType="Int")]
		public System.Nullable<int> Milage
		{
			get
			{
				return this._Milage;
			}
			set
			{
				if ((this._Milage != value))
				{
					this.OnMilageChanging(value);
					this.SendPropertyChanging();
					this._Milage = value;
					this.SendPropertyChanged("Milage");
					this.OnMilageChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Release_Date", DbType="Int NOT NULL")]
		public int Release_Date
		{
			get
			{
				return this._Release_Date;
			}
			set
			{
				if ((this._Release_Date != value))
				{
					this.OnRelease_DateChanging(value);
					this.SendPropertyChanging();
					this._Release_Date = value;
					this.SendPropertyChanged("Release_Date");
					this.OnRelease_DateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Price", DbType="Money")]
		public System.Nullable<decimal> Price
		{
			get
			{
				return this._Price;
			}
			set
			{
				if ((this._Price != value))
				{
					this.OnPriceChanging(value);
					this.SendPropertyChanging();
					this._Price = value;
					this.SendPropertyChanged("Price");
					this.OnPriceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ImagePath_Id", DbType="Int")]
		public System.Nullable<int> ImagePath_Id
		{
			get
			{
				return this._ImagePath_Id;
			}
			set
			{
				if ((this._ImagePath_Id != value))
				{
					if (this._ImagePath.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnImagePath_IdChanging(value);
					this.SendPropertyChanging();
					this._ImagePath_Id = value;
					this.SendPropertyChanged("ImagePath_Id");
					this.OnImagePath_IdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="BanType_Car", Storage="_BanType", ThisKey="BanType_Id", OtherKey="Id", IsForeignKey=true)]
		public BanType BanType
		{
			get
			{
				return this._BanType.Entity;
			}
			set
			{
				BanType previousValue = this._BanType.Entity;
				if (((previousValue != value) 
							|| (this._BanType.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._BanType.Entity = null;
						previousValue.Cars.Remove(this);
					}
					this._BanType.Entity = value;
					if ((value != null))
					{
						value.Cars.Add(this);
						this._BanType_Id = value.Id;
					}
					else
					{
						this._BanType_Id = default(Nullable<int>);
					}
					this.SendPropertyChanged("BanType");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Brand_Car", Storage="_Brand", ThisKey="Brand_Id", OtherKey="Id", IsForeignKey=true)]
		public Brand Brand
		{
			get
			{
				return this._Brand.Entity;
			}
			set
			{
				Brand previousValue = this._Brand.Entity;
				if (((previousValue != value) 
							|| (this._Brand.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Brand.Entity = null;
						previousValue.Cars.Remove(this);
					}
					this._Brand.Entity = value;
					if ((value != null))
					{
						value.Cars.Add(this);
						this._Brand_Id = value.Id;
					}
					else
					{
						this._Brand_Id = default(Nullable<int>);
					}
					this.SendPropertyChanged("Brand");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="CarColor_Car", Storage="_CarColor", ThisKey="CarColors_Id", OtherKey="Id", IsForeignKey=true)]
		public CarColor CarColor
		{
			get
			{
				return this._CarColor.Entity;
			}
			set
			{
				CarColor previousValue = this._CarColor.Entity;
				if (((previousValue != value) 
							|| (this._CarColor.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._CarColor.Entity = null;
						previousValue.Cars.Remove(this);
					}
					this._CarColor.Entity = value;
					if ((value != null))
					{
						value.Cars.Add(this);
						this._CarColors_Id = value.Id;
					}
					else
					{
						this._CarColors_Id = default(Nullable<int>);
					}
					this.SendPropertyChanged("CarColor");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PetrolType_Car", Storage="_PetrolType", ThisKey="PetrolTypes_Id", OtherKey="Id", IsForeignKey=true)]
		public PetrolType PetrolType
		{
			get
			{
				return this._PetrolType.Entity;
			}
			set
			{
				PetrolType previousValue = this._PetrolType.Entity;
				if (((previousValue != value) 
							|| (this._PetrolType.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._PetrolType.Entity = null;
						previousValue.Cars.Remove(this);
					}
					this._PetrolType.Entity = value;
					if ((value != null))
					{
						value.Cars.Add(this);
						this._PetrolTypes_Id = value.Id;
					}
					else
					{
						this._PetrolTypes_Id = default(Nullable<int>);
					}
					this.SendPropertyChanged("PetrolType");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="ImagePath_Car", Storage="_ImagePath", ThisKey="ImagePath_Id", OtherKey="Id", IsForeignKey=true)]
		public ImagePath ImagePath
		{
			get
			{
				return this._ImagePath.Entity;
			}
			set
			{
				ImagePath previousValue = this._ImagePath.Entity;
				if (((previousValue != value) 
							|| (this._ImagePath.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._ImagePath.Entity = null;
						previousValue.Cars.Remove(this);
					}
					this._ImagePath.Entity = value;
					if ((value != null))
					{
						value.Cars.Add(this);
						this._ImagePath_Id = value.Id;
					}
					else
					{
						this._ImagePath_Id = default(Nullable<int>);
					}
					this.SendPropertyChanged("ImagePath");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.ImagePath")]
	public partial class ImagePath : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Path;
		
		private EntitySet<Car> _Cars;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnPathChanging(string value);
    partial void OnPathChanged();
    #endregion
		
		public ImagePath()
		{
			this._Cars = new EntitySet<Car>(new Action<Car>(this.attach_Cars), new Action<Car>(this.detach_Cars));
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Path", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string Path
		{
			get
			{
				return this._Path;
			}
			set
			{
				if ((this._Path != value))
				{
					this.OnPathChanging(value);
					this.SendPropertyChanging();
					this._Path = value;
					this.SendPropertyChanged("Path");
					this.OnPathChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="ImagePath_Car", Storage="_Cars", ThisKey="Id", OtherKey="ImagePath_Id")]
		public EntitySet<Car> Cars
		{
			get
			{
				return this._Cars;
			}
			set
			{
				this._Cars.Assign(value);
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
		
		private void attach_Cars(Car entity)
		{
			this.SendPropertyChanging();
			entity.ImagePath = this;
		}
		
		private void detach_Cars(Car entity)
		{
			this.SendPropertyChanging();
			entity.ImagePath = null;
		}
	}
}
#pragma warning restore 1591
