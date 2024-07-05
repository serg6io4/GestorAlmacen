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
    public class Promocion : BaseObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        // Use CodeRush to create XPO classes and properties with a few keystrokes.
        // https://docs.devexpress.com/CodeRushForRoslyn/118557
        public Promocion(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
        }
        //Atributos Promocion
        private string _nombre;
        private string _descripcion;
        private int _descuento;
        private DateTime _fechInicio;
        private DateTime _fechFinal;

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
        //Metodos Descuento
        public int Descuento
        {
            get => _descuento;
            set => SetPropertyValue(nameof(Descuento), ref _descuento, value);
        }
        //Metodos FechInicio
        public DateTime FechInicio
        {
            get => _fechInicio;
            set => SetPropertyValue(nameof(FechInicio), ref _fechInicio, value);
        }
        //Metodos FechFinal
        public DateTime FechFinal
        {
            get => _fechFinal;
            set => SetPropertyValue(nameof(FechFinal), ref _fechFinal, value);
        }

        //Relacion OneToMany Promocion-Producto
        [Association]
        public XPCollection<Producto> Productos
        {
            get { return GetCollection<Producto>(nameof(Productos)); }
        }
    }
}