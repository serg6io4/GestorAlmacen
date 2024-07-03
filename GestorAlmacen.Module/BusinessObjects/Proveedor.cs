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
    public class Proveedor : BaseObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        // Use CodeRush to create XPO classes and properties with a few keystrokes.
        // https://docs.devexpress.com/CodeRushForRoslyn/118557
        public Proveedor(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
        }
        //Atributos Proveedor
        private string _nombre;
        private string _apellidos;
        private string _direccion;
        private string _telefono;
        private string _correoElec;

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
    }
}