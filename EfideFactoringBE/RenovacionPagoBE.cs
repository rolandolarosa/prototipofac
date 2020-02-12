
namespace EfideFactoringBE
{
    public class RenovacionPagoBE : GeneralBE
    {
        private string _IdRenovacion = string.Empty;

        public string IdRenovacion
        {
            get { return _IdRenovacion; }
            set { _IdRenovacion = value; }
        }

        private string _socioBancoID = string.Empty;

        public string socioBancoID
        {
            get { return _socioBancoID; }
            set { _socioBancoID = value; }
        }

        private string _ctasBancariaID = string.Empty;

        public string ctasBancariaID
        {
            get { return _ctasBancariaID; }
            set { _ctasBancariaID = value; }
        }

        private string _ctasBanNumCta = string.Empty;

        public string ctasBanNumCta
        {
            get { return _ctasBanNumCta; }
            set { _ctasBanNumCta = value; }
        }

        private decimal _nTotal = 0;
        public decimal nTotal
        {
            get { return _nTotal; }
            set { _nTotal = value; }
        }

        private string _IdOperacion_tt = string.Empty;

        public string IdOperacion_tt
        {
            get { return _IdOperacion_tt; }
            set { _IdOperacion_tt = value; }
        }

        private string _IdOperacion_tt_Dsc = string.Empty;

        public string IdOperacion_tt_Dsc
        {
            get { return _IdOperacion_tt_Dsc; }
            set { _IdOperacion_tt_Dsc = value; }
        }

        private string _IdTipoAbono_tt = string.Empty;

        public string IdTipoAbono_tt
        {
            get { return _IdTipoAbono_tt; }
            set { _IdTipoAbono_tt = value; }
        }

        private string _IdTipoAbono_tt_Dsc = string.Empty;

        public string IdTipoAbono_tt_Dsc
        {
            get { return _IdTipoAbono_tt_Dsc; }
            set { _IdTipoAbono_tt_Dsc = value; }
        }

        private decimal _jImporte = 0;
        public decimal jImporte
        {
            get { return _jImporte; }
            set { _jImporte = value; }
        }

        private decimal _jSaldo = 0;
        public decimal jSaldo
        {
            get { return _jSaldo; }
            set { _jSaldo = value; }
        }
    }
}
