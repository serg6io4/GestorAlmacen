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
    public class DetallePedido : BaseObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        // Use CodeRush to create XPO classes and properties with a few keystrokes.
        // https://docs.devexpress.com/CodeRushForRoslyn/118557
        public DetallePedido(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
        }
        //Atributos DetallePedido
        private int _cantidad;
        private double _precioUnitario;
        private int _descuento;

        //Metodos Cantidad
        public int Cantidad {
            get => _cantidad;
            set => SetPropertyValue(nameof(Cantidad), ref _cantidad, value);
        }
        //Metodos PrecioUnitario
        public double PrecioUnitario
        {
            get => _precioUnitario;
            set => SetPropertyValue(nameof(PrecioUnitario), ref _precioUnitario, value);
        }
        //Metodos Descuento
        public int Descuento
        {
            get => _descuento;
            set => SetPropertyValue(nameof(Descuento), ref _descuento, value);
        }

        //Relacion ManyToMany Producto-Pedido
        private Pedido _pedido;
        [Association]
        public Pedido Pedido
        {
            get { return _pedido; }
            set { SetPropertyValue(nameof(Pedido), ref _pedido, value); }
        }

        private Producto _producto;
        [Association]
        public Producto Producto
        {
            get { return _producto; }
            set { SetPropertyValue(nameof(Producto), ref _producto, value); }
        }
    }
}