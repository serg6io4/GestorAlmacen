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
    public class Almacen : BaseObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        // Use CodeRush to create XPO classes and properties with a few keystrokes.
        // https://docs.devexpress.com/CodeRushForRoslyn/118557
        public Almacen(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }

        //Atributos de Almacen
        private string _nombre;
        private string _empresa;
        private int _cantidadStock;
        private DateTime _fechaAct;

        //Relacion OneToOne Ubicacion
        public Ubicacion _ubicacion = null;

        //Metodos de Nombre
        public string Nombre {
            get => _nombre;
            set => SetPropertyValue(nameof(Nombre), ref _nombre, value);
        }
        //Metodos de Empresa
        public string Empresa
        {
            get => _empresa;
            set => SetPropertyValue(nameof(Empresa), ref _empresa, value);
        }
        //Metodos de CantidadStock
        public int CantidadStock
        {
            get => _cantidadStock;
            set => SetPropertyValue(nameof(CantidadStock), ref _cantidadStock, value);
        }
        //Metodos de FechaAct
        public DateTime FechaAct
        {
            get => _fechaAct;
            set => SetPropertyValue(nameof(FechaAct), ref _fechaAct, value);
        }

        //Relacion OneToOne Ubicacion-Almacen
        public Ubicacion Ubicacion {
            get { return _ubicacion;}
            set {
                if (_ubicacion == value) { return; }

                //Guardar la referencia de la ubicacion actual
                Ubicacion _prevUbicacion = _ubicacion;
                _ubicacion = value;

                if(IsLoading) return;

                //Eliminar la referencia de ubicacion de este almacen, si existe
                if (_prevUbicacion != null && _prevUbicacion.Almacen == this) { 
                    _prevUbicacion.Almacen = null;
                }
                //Y ahora procedo a cargar su nueva ubicacion
                if (_ubicacion != null) {
                    _ubicacion.Almacen = this;
                }
                OnChanged(nameof(Ubicacion));
            }

        }

    }
}