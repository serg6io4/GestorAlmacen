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
    public class Devolucion : BaseObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        // Use CodeRush to create XPO classes and properties with a few keystrokes.
        // https://docs.devexpress.com/CodeRushForRoslyn/118557
        public Devolucion(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
        }
        //Atributos Devolucion
        private DateTime _fechDevolucion;
        private string _motivo;
        private string _estado;
        private double _importeDev;

        //Metodos FechDevolucion
        public DateTime FechDevolucion { 
            get=> _fechDevolucion;
            set => SetPropertyValue(nameof(FechDevolucion), ref _fechDevolucion, value);
        }
        //Metodos Motivo
        public string Motivo
        {
            get => _motivo;
            set => SetPropertyValue(nameof(Motivo), ref _motivo, value);
        }
        //Metodos Estado
        public string Estado
        {
            get => _estado;
            set => SetPropertyValue(nameof(Estado), ref _estado, value);
        }
        //Metodos ImporteDev
        public double ImporteDev
        {
            get => _importeDev;
            set => SetPropertyValue(nameof(ImporteDev), ref _importeDev, value);
        }

    }
}