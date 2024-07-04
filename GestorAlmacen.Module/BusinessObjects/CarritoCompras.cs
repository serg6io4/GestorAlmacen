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
    public class CarritoCompras : BaseObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        // Use CodeRush to create XPO classes and properties with a few keystrokes.
        // https://docs.devexpress.com/CodeRushForRoslyn/118557
        public CarritoCompras(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
        }
        //Atributos CarritoCompras
        private int _cantidadProducto;
        private int _precioTotal;

        //Metodos CantidadProducto
        public int CantidadProducto { 
            get=>_cantidadProducto;
            set => SetPropertyValue(nameof(CantidadProducto), ref _cantidadProducto, value);
        }
        //Metodos PrecioTotal
        public int PrecioTotal
        {
            get => _precioTotal;
            set => SetPropertyValue(nameof(PrecioTotal), ref _precioTotal, value);
        }

        //Relacion OneToOne Cliente-CarritoCompras
        Cliente _cliente = null;
        public Cliente Cliente
        {
            get { return _cliente; }
            set
            {
                if (_cliente == value)
                    return;

                
                Cliente _prevCliente = _cliente;
                _cliente = value;

                if (IsLoading) return;

                
                if (_prevCliente != null && _prevCliente.Carrito == this)
                    _prevCliente.Carrito = null;

                
                if (_cliente != null)
                    _cliente.Carrito = this;
                OnChanged(nameof(Cliente));
            }
        }
    }
}