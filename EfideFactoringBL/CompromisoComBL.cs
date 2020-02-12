using System.Data;
using EfideFactoringBE;
using EfideFactoringDA;

namespace EfideFactoringBL
{
   public class CompromisoComBL
   {
       CompromisoComDA CompromisoComDA = new CompromisoComDA();

       public DataSet ProcesarCompromisoCom(CompromisoComBE BE)
       {
           return CompromisoComDA.ProcesarCompromisoCom(BE);
       }
   }
}

