using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Efide.Tesoreria.BusinessEntity.adeudo;

namespace Efide.Tesoreria.IntercafeData.adeudo
{
    public interface IRenovacionD
    {
        string insertRenovacion(RenovacionBE pRenovacionBE);
        void updateRenovacion(RenovacionBE pRenovacionBE);
        List<RenovacionBE> listRenovacion(RenovacionBE pRenovacionBE);
        RenovacionBE getRenovacion(string idRenovacion);
    }
}
