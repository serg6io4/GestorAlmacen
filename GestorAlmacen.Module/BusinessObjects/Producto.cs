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
using System.Drawing;
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
    public class Producto : BaseObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        // Use CodeRush to create XPO classes and properties with a few keystrokes.
        // https://docs.devexpress.com/CodeRushForRoslyn/118557
        public Producto(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
        }
        //Atributos Producto
        private string _nombre;
        private string _descripcion;
        private double _precio;
        private int _stock;
        private int _sku;

        private byte[] _imagen;
        [ImageEditor(ListViewImageEditorCustomHeight = 100, DetailViewImageEditorFixedWidth = 200)]
        
        private DateTime _fechAlta;

        //Metodos Nombre
        public string Nombre {
            get => _nombre;
            set => SetPropertyValue(nameof(Nombre), ref _nombre, value);
        }
        //Metodos Descripcion
        public string Descripcion
        {
            get => _descripcion;
            set => SetPropertyValue(nameof(Descripcion), ref _descripcion, value);
        }
        //Metodos Precio
        public double Precio
        {
            get => _precio;
            set => SetPropertyValue(nameof(Precio), ref _precio, value);
        }
        //Metodos Stock
        public int Stock
        {
            get => _stock;
            set => SetPropertyValue(nameof(Stock), ref _stock, value);
        }
        //Metodos SKU
        public int SKU
        {
            get => _sku;
            set => SetPropertyValue(nameof(SKU), ref _sku, value);
        }
        //Metodos Imagen
        public byte[] Imagen
        {
            get => _imagen;
            set => SetPropertyValue(nameof(Imagen), ref _imagen, value);
        }
        //Metodos FechAlta
        public DateTime FechAlta
        {
            get => _fechAlta;
            set => SetPropertyValue(nameof(FechAlta), ref _fechAlta, value);
        }
        //Relacion OneToOne Producto-Categoria
        Categoria _categoria = null;
        public Categoria Categoria
        {
            get { return _categoria; }
            set
            {
                if (_categoria == value)
                    return;

                
                Categoria _prevCategoria = _categoria;
                _categoria = value;

                if (IsLoading) return;

                
                if (_prevCategoria != null && _prevCategoria.Producto == this)
                    _prevCategoria.Producto = null;

                
                if (_categoria != null)
                    _categoria.Producto = this;
                OnChanged(nameof(Categoria));
            }
        }
    }
}