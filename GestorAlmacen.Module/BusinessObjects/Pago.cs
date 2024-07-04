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
    public class Pago : BaseObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        // Use CodeRush to create XPO classes and properties with a few keystrokes.
        // https://docs.devexpress.com/CodeRushForRoslyn/118557
        public Pago(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
        }
        //Atributos de Pago
        private DateTime _fechPago;
        private double _cantidad;
        private string _metodoPago;
        private string _estadoPago;   
        
        //Metodos FechPago
        public DateTime FechPago {
            get => _fechPago;
            set => SetPropertyValue(nameof(FechPago), ref _fechPago, value);
        }
        //Metodos Cantidad
        public double Cantidad { 
            get => _cantidad;
            set => SetPropertyValue(nameof(Cantidad), ref _cantidad, value); 
        }
        //Metodos de MetodoPago
        public string MetodoPago {
            get => _metodoPago;
            set => SetPropertyValue(nameof(MetodoPago), ref _metodoPago, value);
        }
        //Metodos de EstadoPago
        public string EstadoPago
        {
            get => _estadoPago;
            set => SetPropertyValue(nameof(EstadoPago), ref _estadoPago, value);
        }

        //Relacion OneToOne Pedido-Pago
        Pedido _pedido = null;
        public Pedido Pedido
        {
            get { return _pedido; }
            set
            {
                if (_pedido == value) { return; }
                
                Pedido _prevPedido = _pedido;
                _pedido = value;

                if (IsLoading) { return; }

                
                if (_prevPedido != null && _prevPedido.Pago == this)
                    _prevPedido.Pago = null;

                
                if (_pedido != null)
                    _pedido.Pago = this;
                OnChanged(nameof(Pedido));
            }
        }
    }
}