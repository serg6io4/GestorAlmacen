using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.DC;
using DevExpress.ExpressApp.Model;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;
using DevExpress.RichEdit.Export;
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
    public class Usuario : BaseObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        // Use CodeRush to create XPO classes and properties with a few keystrokes.
        // https://docs.devexpress.com/CodeRushForRoslyn/118557
        public Usuario(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
        }
        //Atributos Usuario
        private int _idUsuario;
        private string _nombre;
        private string _contrasenya;
        private string _rol;
        private string _correoElec;
        private DateTime _fechRegistro;

        //Metodos de IDUsuario
        public int IDUsuario
        {
            get => _idUsuario;
            set => SetPropertyValue(nameof(IDUsuario), ref _idUsuario, value);
        }
        //Metodos de nombre
        public string Nombre { 
            get=>_nombre; 
            set=>SetPropertyValue(nameof(Nombre), ref _nombre, value);
        }
        //Metodos de contrasenya
        public string Contrasenya{ 
            get=>_contrasenya;
            set => SetPropertyValue(nameof(Contrasenya), ref _contrasenya, value);
        }
        //Metodos de rol
        public string Rol { 
            get => _rol;
            set => SetPropertyValue(nameof(Rol), ref _rol, value);
        }
        //Metodos de CorreoElec
        public string CorreoElec{ 
            get => _correoElec;
            set => SetPropertyValue(nameof(CorreoElec), ref _correoElec, value);
        }
        //Metodos de FechRegistro
        public DateTime FechRegistro {
            get => _fechRegistro;
            set => SetPropertyValue(nameof(FechRegistro), ref _fechRegistro, value);
        }

    }
}