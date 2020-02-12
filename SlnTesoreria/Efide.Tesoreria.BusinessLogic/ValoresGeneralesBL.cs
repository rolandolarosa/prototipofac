using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Efide.Tesoreria.BusinessEntity;
using Efide.Tesoreria.DataAccess;
using Efide.Tesoreria.IntercafeData;

namespace Efide.Tesoreria.BusinessLogic
{
    public class ValoresGeneralesBL : IValoresGeneralesD
    {
        private ValoresGeneralesDA _ValoresGeneralesDA;
        private ValoresGeneralesDA oValoresGeneralesDA
        {
            get { return (_ValoresGeneralesDA == null ? _ValoresGeneralesDA = new ValoresGeneralesDA() : _ValoresGeneralesDA); }
        }

        public List<ValoresGeneralesBE> listValoresGenerales(ValoresGeneralesBE pValoresGeneralesBE)
        {
            return oValoresGeneralesDA.listValoresGenerales(pValoresGeneralesBE).Where(x => x.varCodigo != 3).ToList();
        }

        public List<ValueListsBE> listCuentasBancarias()
        {
            return oValoresGeneralesDA.listCuentasBancarias();
        }
    }
}
