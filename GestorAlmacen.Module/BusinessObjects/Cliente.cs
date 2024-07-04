using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.DC;
using DevExpress.ExpressApp.Model;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace GestorAlmacen.Module.BusinessObjects
{
    [DefaultClassOptions]
    //[ImageName("BO_Contact")]
    //[DefaultProperty("DisplayMemberNameForLookupEditorsOfThisType")]
    //[DefaultListViewOptions(MasterDetailMode.ListViewOnly, false, NewItemRowPosition.None)]
    //[Persistent("DatabaseTableName")]
    // Specify more UI options using a declarative approach (https://documentation.devexpress.com/#eXpressAppFramework/CustomDocument112701).
    public class Cliente : BaseObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        // Use CodeRush to create XPO classes and properties with a few keystrokes.
        // https://docs.devexpress.com/CodeRushForRoslyn/118557
        public Cliente(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
        }

        //Atributos Cliente
        private string _nombre;
        private string _apellidos;
        private string _direccion;
        private string _telefono;
        private string _correoElec;
        private DateTime _fechRegistro;

        //Metodos Nombre
        public string Nombre {
            get => _nombre;
            set => SetPropertyValue(nameof(Nombre), ref _nombre, value);
        }
        //Metodos Apellidos
        public string Apellidos
        {
            get => _apellidos;
            set => SetPropertyValue(nameof(Apellidos), ref _apellidos, value);
        }
        //Metodos Direccion
        public string Direccion
        {
            get => _direccion;
            set => SetPropertyValue(nameof(Direccion), ref _direccion, value);
        }
        //Metodos Telefono
        public string Telefono
        {
            get => _telefono;
            set => SetPropertyValue(nameof(Telefono), ref _telefono, value);
        }
        //Metodos CorreoElec
        public string CorreoElec
        {
            get => _correoElec;
            set => SetPropertyValue(nameof(CorreoElec), ref _correoElec, value);
        }
        //Metodos FechRegistro
        public DateTime FechRegistro
        {
            get => _fechRegistro;
            set => SetPropertyValue(nameof(FechRegistro), ref _fechRegistro, value);
        }

        //Relacion OneToOne Cliente-CarritoCompras
        CarritoCompras _carrito = null;
        public CarritoCompras Carrito
        {
            get { return _carrito; }
            set
            {
                if (_carrito == value)
                    return;

                // Store a reference to the former owner.
                CarritoCompras _prevCarrito = _carrito;
                _carrito = value;

                if (IsLoading) return;

                // Remove an owner's reference to this building, if exists.
                if (_prevCarrito != null && _prevCarrito.Cliente == this)
                    _prevCarrito.Cliente = null;

                // Specify that the building is a new owner's house.
                if (_carrito != null)
                    _carrito.Cliente = this;
                OnChanged(nameof(Carrito));
            }
        }
    }
}