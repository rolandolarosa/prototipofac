
namespace EfideFactoringBE
{
    public class MovimientoBE : GeneralBE
    {
        public string IdMovimiento = string.Empty;
        public string IdTipo_tt = string.Empty;
        public string IdReferencia = string.Empty;
        public string RazonSocial = string.Empty;
        public string TipoDocumento = string.Empty;
        public string NroDoc = string.Empty;
        public System.DateTime FechaMovimiento = System.DateTime.MinValue;
        public string IdMoneda_tt = string.Empty;
        public decimal Importe = 0;
        public string IdEstado_tt = string.Empty;
        public string Comentario = string.Empty;
    }
}
