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
    public class Factura : BaseObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        // Use CodeRush to create XPO classes and properties with a few keystrokes.
        // https://docs.devexpress.com/CodeRushForRoslyn/118557
        public Factura(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
        }
        //Atributos Factura
        private DateTime _fechEmision;
        private double _importeTotal;
        private double _impuestosAplic;

        //Metodos FechEmision
        public DateTime FechEmision {
            get => _fechEmision;
            set => SetPropertyValue(nameof(FechEmision), ref _fechEmision, value);
        }
        //Metodos ImporteTotal
        public double ImporteTotal
        {
            get => _importeTotal;
            set => SetPropertyValue(nameof(ImporteTotal), ref _importeTotal, value);
        }
        //Metodos ImpuestosAplic
        public double ImpuestosAplic
        {
            get => _impuestosAplic;
            set => SetPropertyValue(nameof(ImpuestosAplic), ref _impuestosAplic, value);
        }
    }
}