using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace EfideFactoringBE
{
    public class CargoBE
    {
        private string _carcod;
        private bool? _bPersonal;
        private string _carnom;
        private string _usuario;
        private string _cAreCod;
        private string _cCodigo;
        private string _cPuestoDesc;
        private string _cTituloPdf;
        private Int16 _version;
        private DataTable _Detalle = new DataTable();
        private byte? _iCanReq;
        private byte? _iCanAsi;
        private byte[] _imFuncion;
        private byte[] _imProcedimiento;

        public string cCarCod {
	        get { return _carcod; }
	        set { _carcod = value; }
        }

        public bool? bPersonal {
	        get { return _bPersonal; }
	        set { _bPersonal = value; }
        }

        public byte? iCanReq {
	        get { return _iCanReq; }
	        set { _iCanReq = value; }
        }

        public byte? iCanAsi {
	        get { return _iCanAsi; }
	        set { _iCanAsi = value; }
        }

        public Int16 version {
	        get { return _version; }
	        set { _version = value; }
        }

        public string cCarNom {
	        get { return _carnom; }
	        set { _carnom = value; }
        }

        public string Usuario {
	        get { return _usuario; }
	        set { _usuario = value; }
        }

        public string cAreCod {
	        get { return _cAreCod; }
	        set { _cAreCod = value; }
        }

        public string cCodigo {
	        get { return _cCodigo; }
	        set { _cCodigo = value; }
        }

        public string cPuestoDesc {
	        get { return _cPuestoDesc; }
	        set { _cPuestoDesc = value; }
        }

        public string cTituloPdf {
	        get { return _cTituloPdf; }
	        set { _cTituloPdf = value; }
        }

        public DataTable Detalle {
	        get { return _Detalle; }
	        set { _Detalle = value; }
        }

        public byte[] imFuncion {
	        get { return _imFuncion; }
	        set { _imFuncion = value; }
        }

        public byte[] imProcedimiento {
	        get { return _imProcedimiento; }
	        set { _imProcedimiento = value; }
        }

        //public New(string _carcod, string _carnom)
        //{
        //    this._carcod = _carcod;
        //    this._carnom = _carnom;
        //}

        //public New()
        //{
        //}

    }
}
