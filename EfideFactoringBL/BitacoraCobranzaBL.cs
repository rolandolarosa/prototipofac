using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EfideFactoringDA;
using System.Data;
using EfideFactoringBE;

namespace EfideFactoringBL
{
    public class BitacoraCobranzaBL
    {
        public DataSet ProcesarBitacoraCobranza(BitacoraCobranzaInputBE IEntity)
        {
            DataSet dsResultEntity = new DataSet();
            try 
	        {
                BitacoraCobranzaDA DA = new BitacoraCobranzaDA();
                dsResultEntity = DA.ProcesarBitacoraCobranza(IEntity);
	        }
	        catch (Exception ex)
	        {
		        throw ex;
	        }
            return dsResultEntity;
        }
    }
}
