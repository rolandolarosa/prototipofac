using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Efide.Tesoreria.BusinessEntity.inversion;

namespace Efide.Tesoreria.IntercafeData.inversion
{
    public interface IRenovacionD
    {
        string insertRenovacion(RenovacionBE pRenovacionBE);
        void updateRenovacion(RenovacionBE pRenovacionBE);
        List<RenovacionBE> listRenovacion(RenovacionBE pRenovacionBE);
        RenovacionBE getRenovacion(string idRenovacion);
    }
}
