using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Efide.Tesoreria.BusinessEntity.inversion;

namespace Efide.Tesoreria.IntercafeData.inversion
{
    public interface IRescisionD
    {
        string insertRescision(RescisionBE pRescisionBE);
        void updateRescision(RescisionBE pRescisionBE);
        List<RescisionBE> listRescision(RescisionBE pRescisionBE);
        RescisionBE getRescision(string idRescision);
    }
}
