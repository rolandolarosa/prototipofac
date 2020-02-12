
namespace EfideFactoringBE
{
   public class EmpresaSentinelBE : GeneralBE
   {
       private string _Periodo = string.Empty;
       
       public string Periodo
       {
           get { return _Periodo; }
           set { _Periodo = value; }
       }

       private string _RUC = string.Empty;
       
       public string RUC
       {
           get { return _RUC; }
           set { _RUC = value; }
       }

       private string _CalificacionNormal = string.Empty;
       
       public string CalificacionNormal
       {
           get { return _CalificacionNormal; }
           set { _CalificacionNormal = value; }
       }

       private string _DeudaDirectoIndirecto = string.Empty;
       
       public string DeudaDirectoIndirecto
       {
           get { return _DeudaDirectoIndirecto; }
           set { _DeudaDirectoIndirecto = value; }
       }

       private decimal _RangoDeuda = 0;
       
       public decimal RangoDeuda
       {
           get { return _RangoDeuda; }
           set { _RangoDeuda = value; }
       }

       private string _Operador = string.Empty;
       
       public string Operador
       {
           get { return _Operador; }
           set { _Operador = value; }
       }

       private decimal _RangoDeudaB = 0;
       
       public decimal RangoDeudaB
       {
           get { return _RangoDeudaB; }
           set { _RangoDeudaB = value; }
       }

       private string _DeudaCoativa = string.Empty;
       
       public string DeudaCoativa
       {
           get { return _DeudaCoativa; }
           set { _DeudaCoativa = value; }
       }

       private string _ProtestoNoRegularisado = string.Empty;
       
       public string ProtestoNoRegularisado
       {
           get { return _ProtestoNoRegularisado; }
           set { _ProtestoNoRegularisado = value; }
       }

       private string _Creditos = string.Empty;
       
       public string Creditos
       {
           get { return _Creditos; }
           set { _Creditos = value; }
       }

       private string _Grupo = string.Empty;
       
       public string Grupo
       {
           get { return _Grupo; }
           set { _Grupo = value; }
       }

   }
}
