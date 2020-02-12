using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Efide.Tesoreria.BusinessEntity.inversion;
using Efide.Tesoreria.DataAccess;
using Efide.Tesoreria.DataAccess.inversion;
using Efide.Tesoreria.IntercafeData;
using Efide.Tesoreria.IntercafeData.inversion;

namespace Efide.Tesoreria.BusinessLogic.inversion
{
    public class RescisionBL : IRescisionD
    {
        private RescisionDA _RescisionDA;
        private RescisionDA oRescisionDA
        {
            get { return (_RescisionDA == null ? _RescisionDA = new RescisionDA() : _RescisionDA); }
        }

        public string insertRescision(RescisionBE pRescisionBE)
        {
            return oRescisionDA.insertRescision(pRescisionBE);
        }

        public void updateRescision(RescisionBE pRescisionBE)
        {
            oRescisionDA.updateRescision(pRescisionBE);
        }

        public List<RescisionBE> listRescision(RescisionBE pRescisionBE)
        {
            return oRescisionDA.listRescision(pRescisionBE);
        }

        public RescisionBE getRescision(string idRescision)
        {
            return oRescisionDA.getRescision(idRescision);
        }
    }
}
