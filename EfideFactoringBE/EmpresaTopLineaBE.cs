
namespace EfideFactoringBE
{
   public class EmpresaTopLineaBE : GeneralBE
   {
       private string _vRuc = string.Empty;
       public string vRuc
       {
           get { return _vRuc; }
           set { _vRuc = value; }
       }

       private string _vRazonSocial = string.Empty;
       public string vRazonSocial
       {
           get { return _vRazonSocial; }
           set { _vRazonSocial = value; }
       }

       private decimal _nLinea = 0;
       public decimal nLinea
       {
           get { return _nLinea; }
           set { _nLinea = value; }
       }

       private string _cEstado = string.Empty;
       public string cEstado
       {
           get { return _cEstado; }
           set { _cEstado = value; }
       }

       private string _vObservacion = string.Empty;
       public string vObservacion
       {
           get { return _vObservacion; }
           set { _vObservacion = value; }
       }
   }
}
