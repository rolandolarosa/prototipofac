
namespace EfideFactoringBE
{
   public class GestionMetasBE : GeneralBE
   {
       private string _Annio = string.Empty;
       
       public string Annio
       {
           get { return _Annio; }
           set { _Annio = value; }
       }

       private string _Mes = string.Empty;
       
       public string Mes
       {
           get { return _Mes; }
           set { _Mes = value; }
       }

       private string _GestorId = string.Empty;
       
       public string GestorId
       {
           get { return _GestorId; }
           set { _GestorId = value; }
       }

       private decimal _Monto = 0;
       
       public decimal Monto
       {
           get { return _Monto; }
           set { _Monto = value; }
       }

   }
}
