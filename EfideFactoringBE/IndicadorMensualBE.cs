
namespace EfideFactoringBE
{
    public class IndicadorMensualBE : GeneralBE
    {
        private string _Periodo = string.Empty;

        public string Periodo 
        {
            get { return _Periodo; }
            set { _Periodo = value; }
        }

        private System.DateTime _dtActualizacion = System.DateTime.MinValue;
        public System.DateTime dtActualizacion
        {
            get { return _dtActualizacion; }
            set { _dtActualizacion = value; }
        }

        private string _vCodigoIndicador = string.Empty;

        public string vCodigoIndicador
        {
            get { return _vCodigoIndicador; }
            set { _vCodigoIndicador = value; }
        }

        private string _vDescripcionIndicador = string.Empty;
        public string vDescripcionIndicador
        {
            get { return _vDescripcionIndicador; }
            set { _vDescripcionIndicador = value; }
        }

        private decimal _nImporte = 0;
        public decimal nImporte
        {
            get { return _nImporte; }
            set { _nImporte = value; }
        }

        private decimal _nLimiteIndividual = 0;
        public decimal nLimiteIndividual
        {
            get { return _nLimiteIndividual; }
            set { _nLimiteIndividual = value; }
        }

        private decimal _nLimiteRiesgo = 0;
        public decimal nLimiteRiesgo
        {
            get { return _nLimiteRiesgo; }
            set { _nLimiteRiesgo = value; }
        }
    }
}
