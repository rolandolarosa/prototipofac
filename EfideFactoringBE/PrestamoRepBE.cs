using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfideFactoringBE
{
    public class PrestamoRepBE : GeneralBE
    {
  
        private System.DateTime _dtFecRegIni;
        public System.DateTime dtFecRegIni
        {
            get { return _dtFecRegIni; }
            set { _dtFecRegIni = value; }
        }

        private System.DateTime _dtFecRegFin;
        public System.DateTime dtFecRegFin
        {
            get { return _dtFecRegFin; }
            set { _dtFecRegFin = value; }
        }

        private int _MonedaID = 0;
        public int MonedaID
        {
            get { return _MonedaID; }
            set { _MonedaID = value; }
        }

        private string _TipPerID = string.Empty;
        public string TipPerID
        {
            get { return _TipPerID; }
            set { _TipPerID = value; }
        }

        private string _ClienteID = string.Empty;
        public string ClienteID
        {
            get { return _ClienteID; }
            set { _ClienteID = value; }
        }

        private string _IdPagadora = string.Empty;
        public string IdPagadora
        {
            get { return _IdPagadora; }
            set { _IdPagadora = value; }
        }

        private int _EstatusID = 0;
        public int EstatusID
        {
            get { return _EstatusID; }
            set { _EstatusID = value; }
        }

        private int _bTasa = 0;
        public int bTasa
        {
            get { return _bTasa; }
            set { _bTasa = value; }
        }
    }
}
