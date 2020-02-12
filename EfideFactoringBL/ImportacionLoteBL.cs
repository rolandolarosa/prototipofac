using System.Data;
using EfideFactoringBE;
using EfideFactoringDA;

namespace EfideFactoringBL
{
   public class ImportacionLoteBL
   {
       ImportacionLoteDAL ImportacionLoteDA = new ImportacionLoteDAL();

       public DataSet ProcesarImportacionLote(ImportacionLoteBE BE)
       {
           return ImportacionLoteDA.ProcesarImportacionLote(BE);
       }
   }
}

