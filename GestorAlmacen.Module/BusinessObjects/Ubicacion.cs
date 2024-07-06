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
    public class Ubicacion : BaseObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        // Use CodeRush to create XPO classes and properties with a few keystrokes.
        // https://docs.devexpress.com/CodeRushForRoslyn/118557
        public Ubicacion(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction(); 
        }
        //Atributos de clase Ubicacion
        private int _longitud;
        private int _latitud;
        private string _direccion;
        private string _ciudad;
        private string _pais;
        private int _cp;


        //Metodos de Longitud
        public int Longitud {
            get => _longitud;
            set => SetPropertyValue(nameof(Longitud), ref _longitud, value);
        }

        //Metodos de Latitud
        public int Latitud { 
            get => _latitud;
            set => SetPropertyValue(nameof(Latitud), ref _latitud, value);
        }

        //Metodos de Direccion
        public string Direccion {
            get => _direccion;
            set => SetPropertyValue(nameof(Direccion), ref _direccion, value);
        }

        //Metodos de Ciudad
        public String Ciudad { 
            get=> _ciudad;
            set=> SetPropertyValue(nameof(Ciudad), ref _ciudad, value);
        }

        //Metodos de Pais
        public String Pais { 
            get => _pais;
            set => SetPropertyValue(nameof(Pais), ref _pais, value);
        }

        //Metodos de CP
        public int CP { 
            get => _cp;
            set => SetPropertyValue(nameof(CP), ref _cp, value);
        }

        //Relacion OneToOne Ubicacion-Almacen
        Almacen _almacen;
        public Almacen Almacen
        {
            get { return _almacen; }

            set
            {
                if (_almacen == value) { return; }

                //Almacenar la referencia del actual almacen
                Almacen _prevAlmacen = _almacen;
                _almacen = value;

                if (IsLoading) { return; }

                //Eliminar la referencia de almacen de esta ubicacion, si existe
                if (_prevAlmacen != null && _prevAlmacen.Ubicacion == this) { 
                    _prevAlmacen.Ubicacion = null;
                }
                //Especificar el nuevo almacen de esa ubicacion
                if (_almacen != null) { 
                    _almacen.Ubicacion = this;
                }
                OnChanged(nameof(Almacen));
            }
        }
    }
}