
namespace EfideFactoringBE
{
   public class SocioLineaPagPlazoBE : GeneralBE
   {
       private string _IdLinea = string.Empty;
       
       public string IdLinea
       {
           get { return _IdLinea; }
           set { _IdLinea = value; }
       }

       private string _IdPagadora = string.Empty;
       
       public string IdPagadora
       {
           get { return _IdPagadora; }
           set { _IdPagadora = value; }
       }

       private string _IdDocumento = string.Empty;
       
       public string IdDocumento
       {
           get { return _IdDocumento; }
           set { _IdDocumento = value; }
       }

       private string _IdItem = string.Empty;
       
       public string IdItem
       {
           get { return _IdItem; }
           set { _IdItem = value; }
       }

       private decimal _nPlazo = 0;
       
       public decimal nPlazo
       {
           get { return _nPlazo; }
           set { _nPlazo = value; }
       }

       private decimal _nTasa = 0;
       
       public decimal nTasa
       {
           get { return _nTasa; }
           set { _nTasa = value; }
       }

       private decimal _nTasaSobregiro = 0;
       
       public decimal nTasaSobregiro
       {
           get { return _nTasaSobregiro; }
           set { _nTasaSobregiro = value; }
       }

   }
}
