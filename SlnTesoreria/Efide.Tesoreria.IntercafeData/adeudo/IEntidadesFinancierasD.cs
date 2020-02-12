using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Efide.Tesoreria.BusinessEntity.adeudo;

namespace Efide.Tesoreria.IntercafeData.adeudo
{
    public interface IEntidadesFinancierasD
    {
        List<EntidadesFinancierasBE> obtenerEntidadesFinancieras(EntidadesFinancierasBE pEntidadesFinancierasBE);
    }
}
