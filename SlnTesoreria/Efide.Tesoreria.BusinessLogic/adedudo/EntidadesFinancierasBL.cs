using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Efide.Tesoreria.BusinessEntity;
using Efide.Tesoreria.BusinessEntity.adeudo;
using Efide.Tesoreria.DataAccess;
using Efide.Tesoreria.DataAccess.adeudo;
using Efide.Tesoreria.IntercafeData;
using Efide.Tesoreria.IntercafeData.adeudo;

namespace Efide.Tesoreria.BusinessLogic.adeudo
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
