using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Efide.Tesoreria.BusinessEntity;
using Efide.Tesoreria.DataAccess;
using Efide.Tesoreria.IntercafeData;

namespace Efide.Tesoreria.BusinessLogic
{
    public class EntidadesFinancierasBL: IEntidadesFinancierasD
    {
        private EntidadesFinancierasDA _EntidadesFinancierasDA;
        private EntidadesFinancierasDA oEntidadesFinancierasDA
        {
            get { return (_EntidadesFinancierasDA == null ? _EntidadesFinancierasDA = new EntidadesFinancierasDA() : _EntidadesFinancierasDA); }
        }

        public List<EntidadesFinancierasBE> obtenerEntidadesFinancieras(EntidadesFinancierasBE pEntidadesFinancierasBE)
        {
            return oEntidadesFinancierasDA.obtenerEntidadesFinancieras(pEntidadesFinancierasBE);
        }
    }
}
