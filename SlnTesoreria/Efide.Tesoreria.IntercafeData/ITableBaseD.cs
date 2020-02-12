using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Efide.Tesoreria.BusinessEntity;

namespace Efide.Tesoreria.IntercafeData
{
    public interface ITableBaseD
    {
        List<TableBaseBE> ProcesarTableBase(TableBaseBE BE);
    }
}
