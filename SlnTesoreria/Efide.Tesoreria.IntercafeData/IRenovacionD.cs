using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Efide.Tesoreria.BusinessEntity;

namespace Efide.Tesoreria.IntercafeData
{
    public interface IRenovacionD
    {
        string insertRenovacion(RenovacionBE pRenovacionBE);
        void updateRenovacion(RenovacionBE pRenovacionBE);
        List<RenovacionBE> listRenovacion(RenovacionBE pRenovacionBE);
        RenovacionBE getRenovacion(string idRenovacion);
    }
}
