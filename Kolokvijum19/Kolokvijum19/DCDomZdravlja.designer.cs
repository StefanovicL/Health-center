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

namespace Kolokvijum19
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="DomZdravlja")]
	public partial class DCDomZdravljaDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertFirma(Firma instance);
    partial void UpdateFirma(Firma instance);
    partial void DeleteFirma(Firma instance);
    partial void InsertPacijent(Pacijent instance);
    partial void UpdatePacijent(Pacijent instance);
    partial void DeletePacijent(Pacijent instance);
    partial void InsertPaket(Paket instance);
    partial void UpdatePaket(Paket instance);
    partial void DeletePaket(Paket instance);
    #endregion
		
		public DCDomZdravljaDataContext() : 
				base(global::Kolokvijum19.Properties.Settings.Default.DomZdravljaConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DCDomZdravljaDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DCDomZdravljaDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DCDomZdravljaDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DCDomZdravljaDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Firma> Firmas
		{
			get
			{
				return this.GetTable<Firma>();
			}
		}
		
		public System.Data.Linq.Table<Pacijent> Pacijents
		{
			get
			{
				return this.GetTable<Pacijent>();
			}
		}
		
		public System.Data.Linq.Table<Paket> Pakets
		{
			get
			{
				return this.GetTable<Paket>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Firma")]
	public partial class Firma : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _FirmaID;
		
		private string _Naziv;
		
		private string _Sediste;
		
		private EntitySet<Paket> _Pakets;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnFirmaIDChanging(int value);
    partial void OnFirmaIDChanged();
    partial void OnNazivChanging(string value);
    partial void OnNazivChanged();
    partial void OnSedisteChanging(string value);
    partial void OnSedisteChanged();
    #endregion
		
		public Firma()
		{
			this._Pakets = new EntitySet<Paket>(new Action<Paket>(this.attach_Pakets), new Action<Paket>(this.detach_Pakets));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FirmaID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int FirmaID
		{
			get
			{
				return this._FirmaID;
			}
			set
			{
				if ((this._FirmaID != value))
				{
					this.OnFirmaIDChanging(value);
					this.SendPropertyChanging();
					this._FirmaID = value;
					this.SendPropertyChanged("FirmaID");
					this.OnFirmaIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Naziv", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Naziv
		{
			get
			{
				return this._Naziv;
			}
			set
			{
				if ((this._Naziv != value))
				{
					this.OnNazivChanging(value);
					this.SendPropertyChanging();
					this._Naziv = value;
					this.SendPropertyChanged("Naziv");
					this.OnNazivChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Sediste", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Sediste
		{
			get
			{
				return this._Sediste;
			}
			set
			{
				if ((this._Sediste != value))
				{
					this.OnSedisteChanging(value);
					this.SendPropertyChanging();
					this._Sediste = value;
					this.SendPropertyChanged("Sediste");
					this.OnSedisteChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Firma_Paket", Storage="_Pakets", ThisKey="FirmaID", OtherKey="FirmaID")]
		public EntitySet<Paket> Pakets
		{
			get
			{
				return this._Pakets;
			}
			set
			{
				this._Pakets.Assign(value);
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
		
		private void attach_Pakets(Paket entity)
		{
			this.SendPropertyChanging();
			entity.Firma = this;
		}
		
		private void detach_Pakets(Paket entity)
		{
			this.SendPropertyChanging();
			entity.Firma = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Pacijent")]
	public partial class Pacijent : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _PacijentID;
		
		private string _Ime;
		
		private string _Prezime;
		
		private System.DateTime _DatumIzmene;
		
		private System.Nullable<int> _Popust;
		
		private int _IDPaketa;
		
		private EntityRef<Paket> _Paket;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnPacijentIDChanging(int value);
    partial void OnPacijentIDChanged();
    partial void OnImeChanging(string value);
    partial void OnImeChanged();
    partial void OnPrezimeChanging(string value);
    partial void OnPrezimeChanged();
    partial void OnDatumIzmeneChanging(System.DateTime value);
    partial void OnDatumIzmeneChanged();
    partial void OnPopustChanging(System.Nullable<int> value);
    partial void OnPopustChanged();
    partial void OnIDPaketaChanging(int value);
    partial void OnIDPaketaChanged();
    #endregion
		
		public Pacijent()
		{
			this._Paket = default(EntityRef<Paket>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PacijentID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int PacijentID
		{
			get
			{
				return this._PacijentID;
			}
			set
			{
				if ((this._PacijentID != value))
				{
					this.OnPacijentIDChanging(value);
					this.SendPropertyChanging();
					this._PacijentID = value;
					this.SendPropertyChanged("PacijentID");
					this.OnPacijentIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Ime", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Ime
		{
			get
			{
				return this._Ime;
			}
			set
			{
				if ((this._Ime != value))
				{
					this.OnImeChanging(value);
					this.SendPropertyChanging();
					this._Ime = value;
					this.SendPropertyChanged("Ime");
					this.OnImeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Prezime", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Prezime
		{
			get
			{
				return this._Prezime;
			}
			set
			{
				if ((this._Prezime != value))
				{
					this.OnPrezimeChanging(value);
					this.SendPropertyChanging();
					this._Prezime = value;
					this.SendPropertyChanged("Prezime");
					this.OnPrezimeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DatumIzmene", DbType="DateTime NOT NULL")]
		public System.DateTime DatumIzmene
		{
			get
			{
				return this._DatumIzmene;
			}
			set
			{
				if ((this._DatumIzmene != value))
				{
					this.OnDatumIzmeneChanging(value);
					this.SendPropertyChanging();
					this._DatumIzmene = value;
					this.SendPropertyChanged("DatumIzmene");
					this.OnDatumIzmeneChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Popust", DbType="Int")]
		public System.Nullable<int> Popust
		{
			get
			{
				return this._Popust;
			}
			set
			{
				if ((this._Popust != value))
				{
					this.OnPopustChanging(value);
					this.SendPropertyChanging();
					this._Popust = value;
					this.SendPropertyChanged("Popust");
					this.OnPopustChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDPaketa", DbType="Int NOT NULL")]
		public int IDPaketa
		{
			get
			{
				return this._IDPaketa;
			}
			set
			{
				if ((this._IDPaketa != value))
				{
					if (this._Paket.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnIDPaketaChanging(value);
					this.SendPropertyChanging();
					this._IDPaketa = value;
					this.SendPropertyChanged("IDPaketa");
					this.OnIDPaketaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Paket_Pacijent", Storage="_Paket", ThisKey="IDPaketa", OtherKey="PaketID", IsForeignKey=true)]
		public Paket Paket
		{
			get
			{
				return this._Paket.Entity;
			}
			set
			{
				Paket previousValue = this._Paket.Entity;
				if (((previousValue != value) 
							|| (this._Paket.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Paket.Entity = null;
						previousValue.Pacijents.Remove(this);
					}
					this._Paket.Entity = value;
					if ((value != null))
					{
						value.Pacijents.Add(this);
						this._IDPaketa = value.PaketID;
					}
					else
					{
						this._IDPaketa = default(int);
					}
					this.SendPropertyChanged("Paket");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Paket")]
	public partial class Paket : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _PaketID;
		
		private string _Naziv;
		
		private int _Cena;
		
		private int _FirmaID;
		
		private EntitySet<Pacijent> _Pacijents;
		
		private EntityRef<Firma> _Firma;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnPaketIDChanging(int value);
    partial void OnPaketIDChanged();
    partial void OnNazivChanging(string value);
    partial void OnNazivChanged();
    partial void OnCenaChanging(int value);
    partial void OnCenaChanged();
    partial void OnFirmaIDChanging(int value);
    partial void OnFirmaIDChanged();
    #endregion
		
		public Paket()
		{
			this._Pacijents = new EntitySet<Pacijent>(new Action<Pacijent>(this.attach_Pacijents), new Action<Pacijent>(this.detach_Pacijents));
			this._Firma = default(EntityRef<Firma>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PaketID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int PaketID
		{
			get
			{
				return this._PaketID;
			}
			set
			{
				if ((this._PaketID != value))
				{
					this.OnPaketIDChanging(value);
					this.SendPropertyChanging();
					this._PaketID = value;
					this.SendPropertyChanged("PaketID");
					this.OnPaketIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Naziv", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Naziv
		{
			get
			{
				return this._Naziv;
			}
			set
			{
				if ((this._Naziv != value))
				{
					this.OnNazivChanging(value);
					this.SendPropertyChanging();
					this._Naziv = value;
					this.SendPropertyChanged("Naziv");
					this.OnNazivChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Cena", DbType="Int NOT NULL")]
		public int Cena
		{
			get
			{
				return this._Cena;
			}
			set
			{
				if ((this._Cena != value))
				{
					this.OnCenaChanging(value);
					this.SendPropertyChanging();
					this._Cena = value;
					this.SendPropertyChanged("Cena");
					this.OnCenaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FirmaID", DbType="Int NOT NULL")]
		public int FirmaID
		{
			get
			{
				return this._FirmaID;
			}
			set
			{
				if ((this._FirmaID != value))
				{
					if (this._Firma.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnFirmaIDChanging(value);
					this.SendPropertyChanging();
					this._FirmaID = value;
					this.SendPropertyChanged("FirmaID");
					this.OnFirmaIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Paket_Pacijent", Storage="_Pacijents", ThisKey="PaketID", OtherKey="IDPaketa")]
		public EntitySet<Pacijent> Pacijents
		{
			get
			{
				return this._Pacijents;
			}
			set
			{
				this._Pacijents.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Firma_Paket", Storage="_Firma", ThisKey="FirmaID", OtherKey="FirmaID", IsForeignKey=true)]
		public Firma Firma
		{
			get
			{
				return this._Firma.Entity;
			}
			set
			{
				Firma previousValue = this._Firma.Entity;
				if (((previousValue != value) 
							|| (this._Firma.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Firma.Entity = null;
						previousValue.Pakets.Remove(this);
					}
					this._Firma.Entity = value;
					if ((value != null))
					{
						value.Pakets.Add(this);
						this._FirmaID = value.FirmaID;
					}
					else
					{
						this._FirmaID = default(int);
					}
					this.SendPropertyChanged("Firma");
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
		
		private void attach_Pacijents(Pacijent entity)
		{
			this.SendPropertyChanging();
			entity.Paket = this;
		}
		
		private void detach_Pacijents(Pacijent entity)
		{
			this.SendPropertyChanging();
			entity.Paket = null;
		}
	}
}
#pragma warning restore 1591
