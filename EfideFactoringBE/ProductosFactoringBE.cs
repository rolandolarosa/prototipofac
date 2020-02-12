
namespace EfideFactoringBE
{
   public class ProductosFactoringBE : GeneralBE
   {
       private string _prodCreditoID = string.Empty;
       
       public string prodCreditoID
       {
           get { return _prodCreditoID; }
           set { _prodCreditoID = value; }
       }

       private string _lineaCreditoID = string.Empty;
       
       public string lineaCreditoID
       {
           get { return _lineaCreditoID; }
           set { _lineaCreditoID = value; }
       }

       private string _condicionID = string.Empty;
       
       public string condicionID
       {
           get { return _condicionID; }
           set { _condicionID = value; }
       }

       private int _monedaID = 0;
       
       public int monedaID
       {
           get { return _monedaID; }
           set { _monedaID = value; }
       }

   }
}
