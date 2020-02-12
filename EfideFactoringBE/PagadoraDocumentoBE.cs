
namespace EfideFactoringBE
{
   public class PagadoraDocumentoBE : GeneralBE
   {
       private string _IdPagadora = string.Empty;
       
       public string IdPagadora
       {
           get { return _IdPagadora; }
           set { _IdPagadora = value; }
       }

       private string _IdItemDoc = string.Empty;
       
       public string IdItemDoc
       {
           get { return _IdItemDoc; }
           set { _IdItemDoc = value; }
       }

       private string _IdDocumento = string.Empty;
       
       public string IdDocumento
       {
           get { return _IdDocumento; }
           set { _IdDocumento = value; }
       }

       private string _IdTipoConfirmacion_tt = string.Empty;
       public string IdTipoConfirmacion_tt
       {
           get { return _IdTipoConfirmacion_tt; }
           set { _IdTipoConfirmacion_tt = value; }
       }

       private string _IdTipoTransferencia_tt = string.Empty;
       public string IdTipoTransferencia_tt
       {
           get { return _IdTipoTransferencia_tt; }
           set { _IdTipoTransferencia_tt = value; }
       }

       private string _IdTipoCartaP_tt = string.Empty;
       public string IdTipoCartaP_tt
       {
           get { return _IdTipoCartaP_tt; }
           set { _IdTipoCartaP_tt = value; }
       }

       private string _IdTipoCartaE_tt = string.Empty;
       public string IdTipoCartaE_tt
       {
           get { return _IdTipoCartaE_tt; }
           set { _IdTipoCartaE_tt = value; }
       }

       private string _vFrecuencia = string.Empty;
       public string vFrecuencia
       {
           get { return _vFrecuencia; }
           set { _vFrecuencia = value; }
       }

       private string _IdFrecuencia_tt = string.Empty;
       public string IdFrecuencia_tt
       {
           get { return _IdFrecuencia_tt; }
           set { _IdFrecuencia_tt = value; }
       }

       private string _IdDiasPagoFrecuencia_tt = string.Empty;
       public string IdDiasPagoFrecuencia_tt
       {
           get { return _IdDiasPagoFrecuencia_tt; }
           set { _IdDiasPagoFrecuencia_tt = value; }
       }

       private string _vDia = string.Empty;
       public string vDia
       {
           get { return _vDia; }
           set { _vDia = value; }
       }

       private int _iPlazo = 0;

       public int iPlazo
       {
           get { return _iPlazo; }
           set { _iPlazo = value; }
       }

       private int _iDiaPago = 0;

       public int iDiaPago
       {
           get { return _iDiaPago; }
           set { _iDiaPago = value; }
       }

       private string _IdFormaPago_tt = string.Empty;
       
       public string IdFormaPago_tt
       {
           get { return _IdFormaPago_tt; }
           set { _IdFormaPago_tt = value; }
       }

       private string _vcLugardePago = string.Empty;
       
       public string vcLugardePago
       {
           get { return _vcLugardePago; }
           set { _vcLugardePago = value; }
       }

   }
}
