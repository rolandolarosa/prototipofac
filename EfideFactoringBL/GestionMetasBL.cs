using System.Data;
using EfideFactoringBE;
using EfideFactoringDA;

namespace EfideFactoringBL
{
   public class GestionMetasBL
   {
       GestionMetasDA GestionMetasDA = new GestionMetasDA();

       public DataSet ProcesarGestionMetas(GestionMetasBE BE)
       {
           return GestionMetasDA.ProcesarGestionMetas(BE);
       }
   }
}

