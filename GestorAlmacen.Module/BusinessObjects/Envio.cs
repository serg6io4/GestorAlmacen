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
    public class Envio : BaseObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        // Use CodeRush to create XPO classes and properties with a few keystrokes.
        // https://docs.devexpress.com/CodeRushForRoslyn/118557
        public Envio(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
        }
        //Atributos Envio
        private string _direccion;
        private DateTime _fechEnvio;
        private DateTime _fechEstimada;
        private string _empresaEnv;
        private string _estado;

        //Metodos Direccion
        public string Direccion {
            get => _direccion;
            set => SetPropertyValue(nameof(Direccion), ref _direccion, value);
        }
        //Metodos FechEnvio
        public DateTime FechEnvio
        {
            get => _fechEnvio;
            set => SetPropertyValue(nameof(FechEnvio), ref _fechEnvio, value);
        }
        //Metodos FechEstimada
        public DateTime FechEstimada
        {
            get => _fechEstimada;
            set => SetPropertyValue(nameof(FechEstimada), ref _fechEstimada, value);
        }
        //Metodos EmpresaEnv
        public string EmpresaEnv
        {
            get => _empresaEnv;
            set => SetPropertyValue(nameof(EmpresaEnv), ref _empresaEnv, value);
        }
        //Metodos Estado
        public string Estado
        {
            get => _estado;
            set => SetPropertyValue(nameof(Estado), ref _estado, value);
        }

    }
}