using DevExpress.Data.Filtering;
using DevExpress.DirectX.Common.DirectWrite;
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
    public class Pedido : BaseObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        // Use CodeRush to create XPO classes and properties with a few keystrokes.
        // https://docs.devexpress.com/CodeRushForRoslyn/118557
        public Pedido(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
        }

        //Atributos Pedido
        private DateTime _fechPedido;
        private string _estadoPedido;
        private string _metodoPago;
        private string _direccionEnvio;
        private string _correoElec;
        private double _totalPedido;

        
        //Metodos FechPedido
        public DateTime FechPedido {
            get => _fechPedido;
            set => SetPropertyValue(nameof(FechPedido), ref _fechPedido, value);
        }
        //Metodos EstadoPedido
        public string EstadoPedido
        {
            get => _estadoPedido;
            set => SetPropertyValue(nameof(EstadoPedido), ref _estadoPedido, value);
        }
        //Metodos MetodoPago
        public string MetodoPago
        {
            get => _metodoPago;
            set => SetPropertyValue(nameof(MetodoPago), ref _metodoPago, value);
        }
        //Metodos DireccionEnvio
        public string DireccionEnvio
        {
            get => _direccionEnvio;
            set => SetPropertyValue(nameof(DireccionEnvio), ref _direccionEnvio, value);
        }
        //Metodos CorreoElec
        public string CorreoElec
        {
            get => _correoElec;
            set => SetPropertyValue(nameof(CorreoElec), ref _correoElec, value);
        }
        //Metodos TotalPedido
        public double TotalPedido
        {
            get => _totalPedido;
            set => SetPropertyValue(nameof(TotalPedido), ref _totalPedido, value);
        }

        //Relacion OneToOne Pedido-Factura
        Factura _factura = null;
        public Factura Factura {
            get { return _factura;}
            set {
                if (_factura == value) { return; }
                //Almacenar la referencia del actual factura
                Factura _prevFactura = _factura;
                _factura = value;

                if (IsLoading) { return; }

                // Remove an owner's reference to this building, if exists.
                if (_prevFactura != null && _prevFactura.Pedido == this)
                    _prevFactura.Pedido = null;

                // Specify that the building is a new owner's house.
                if (_factura != null)
                    _factura.Pedido = this;
                OnChanged(nameof(Factura));
            }
        }
    }
}