
namespace EfideFactoringBE
{
   public class TarifarioBE : GeneralBE
   {
       private string _IdTarifario = string.Empty;
       
       public string IdTarifario
       {
           get { return _IdTarifario; }
           set { _IdTarifario = value; }
       }

       private string _tipCxcID = string.Empty;
       
       public string tipCxcID
       {
           get { return _tipCxcID; }
           set { _tipCxcID = value; }
       }

       private string _IdTipoCalculo_tt = string.Empty;

       public string IdTipoCalculo_tt
       {
           get { return _IdTipoCalculo_tt; }
           set { _IdTipoCalculo_tt = value; }
       }

       private string _IdCalculo_tt = string.Empty;

       public string IdCalculo_tt
       {
           get { return _IdCalculo_tt; }
           set { _IdCalculo_tt = value; }
       }

       private decimal _PorMonto = 0;
       
       public decimal PorMonto
       {
           get { return _PorMonto; }
           set { _PorMonto = value; }
       }

       private string _PorConcepto_tt = string.Empty;
       
       public string PorConcepto_tt
       {
           get { return _PorConcepto_tt; }
           set { _PorConcepto_tt = value; }
       }

       private decimal _Monto = 0;
       
       public decimal Monto
       {
           get { return _Monto; }
           set { _Monto = value; }
       }

       private string _IdFrecuencia_tt = string.Empty;
       
       public string IdFrecuencia_tt
       {
           get { return _IdFrecuencia_tt; }
           set { _IdFrecuencia_tt = value; }
       }

       private bool _bTransferencia;
       
       public bool bTransferencia
       {
           get { return _bTransferencia; }
           set { _bTransferencia = value; }
       }

       private string _tipCxcNombre = string.Empty;
       public string tipCxcNombre
       {
           get { return _tipCxcNombre; }
           set { _tipCxcNombre = value; }
       }

       private string _IdSocio = string.Empty;
       public string IdSocio
       {
           get { return _IdSocio; }
           set { _IdSocio = value; }
       }

       private string _IdPagadora = string.Empty;
       public string IdPagadora
       {
           get { return _IdPagadora; }
           set { _IdPagadora = value; }
       }

       private string _IdReferencia = string.Empty;
       public string IdReferencia
       {
           get { return _IdReferencia; }
           set { _IdReferencia = value; }
       }
   }
}
