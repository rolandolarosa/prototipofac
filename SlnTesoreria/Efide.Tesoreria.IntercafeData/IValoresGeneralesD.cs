using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Efide.Tesoreria.BusinessEntity;

namespace Efide.Tesoreria.IntercafeData
{
    public interface IValoresGeneralesD
    {
        List<ValoresGeneralesBE> listValoresGenerales(ValoresGeneralesBE pValoresGeneralesBE);
        List<ValueListsBE> listCuentasBancarias();
    }
}
