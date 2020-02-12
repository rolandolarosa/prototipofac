
namespace EfideFactoringBE
{
    public class FEXMLBE
    {
        private string _IdPagadora = string.Empty;
        public string IdPagadora
        {
            get { return _IdPagadora; }
            set { _IdPagadora = value; }
        }

        private string _IdPagadora_Dsc = string.Empty;
        public string IdPagadora_Dsc
        {
            get { return _IdPagadora_Dsc; }
            set { _IdPagadora_Dsc = value; }
        }

        private string _RUC = string.Empty;
        public string RUC
        {
            get { return _RUC; }
            set { _RUC = value; }
        }

        private string _IdDocumento = string.Empty;
        public string IdDocumento
        {
            get { return _IdDocumento; }
            set { _IdDocumento = value; }
        }

        private string _IdDocumento_Dsc = string.Empty;
        public string IdDocumento_Dsc
        {
            get { return _IdDocumento_Dsc; }
            set { _IdDocumento_Dsc = value; }
        }

        private string _cNumDoc = string.Empty;
        public string cNumDoc
        {
            get { return _cNumDoc; }
            set { _cNumDoc = value; }
        }

        private System.DateTime _sdVencimiento;
        public System.DateTime sdVencimiento
        {
            get { return _sdVencimiento; }
            set { _sdVencimiento = value; }
        }

        private decimal _nvNominal = 0;
        public decimal nvNominal
        {
            get { return _nvNominal; }
            set { _nvNominal = value; }
        }

        private decimal _nvNegociable = 0;
        public decimal nvNegociable
        {
            get { return _nvNegociable; }
            set { _nvNegociable = value; }
        }

        private string _IdSocio_BeneficiarioRuc = string.Empty;
        public string IdSocio_BeneficiarioRuc
        {
            get { return _IdSocio_BeneficiarioRuc; }
            set { _IdSocio_BeneficiarioRuc = value; }
        }

        private string _Mensaje = string.Empty;
        public string Mensaje
        {
            get { return _Mensaje; }
            set { _Mensaje = value; }
        }

        private string _IdTipoConfirmacion_Dsc = string.Empty;
        public string IdTipoConfirmacion_Dsc
        {
            get { return _IdTipoConfirmacion_Dsc; }
            set { _IdTipoConfirmacion_Dsc = value; }
        }
    }
}
