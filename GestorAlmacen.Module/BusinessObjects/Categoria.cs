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
    public class Categoria : BaseObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        // Use CodeRush to create XPO classes and properties with a few keystrokes.
        // https://docs.devexpress.com/CodeRushForRoslyn/118557
        public Categoria(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
        }
        //Atributos Categoria

        private string _nombre;
        private string _descripcion;
        private string _categPadre;

        //Metodos Nombre
        public string Nombre { 
            get=> _nombre;
            set => SetPropertyValue(nameof(Nombre), ref _nombre, value);
        }
        //Metodos Descripcion
        public string Descripcion
        {
            get => _descripcion;
            set => SetPropertyValue(nameof(Descripcion), ref _descripcion, value);
        }
        //Metodos CategPadre
        public string CategPadre
        {
            get => _categPadre;
            set => SetPropertyValue(nameof(CategPadre), ref _categPadre, value);
        }

        //Relacion OneToOne Categoria-Producto
        Producto _producto = null;
        public Producto Producto {
            get { return _producto; }
            set
            {
                if (_producto == value)
                    return;

                
                Producto _prevProducto = _producto;
                _producto = value;

                if (IsLoading) return;

                
                if (_prevProducto != null && _prevProducto.Categoria == this)
                    _prevProducto.Categoria = null;

                
                if (_producto != null)
                    _producto.Categoria = this;
                OnChanged(nameof(Producto));
            }
    }
}