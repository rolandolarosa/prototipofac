using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Efide.Tesoreria.DataAccess;
using Efide.Tesoreria.IntercafeData;

namespace Efide.Tesoreria.BusinessLogic
{
    public class RescisionBL : IRescisionD
    {
        private RescisionDA _RescisionDA;
        private RescisionDA oRescisionDA
        {
            get { return (_RescisionDA == null ? _RescisionDA = new RescisionDA() : _RescisionDA); }
        }

        public string insertRescision(BusinessEntity.RescisionBE pRescisionBE)
        {
            return oRescisionDA.insertRescision(pRescisionBE);
        }

        public void updateRescision(BusinessEntity.RescisionBE pRescisionBE)
        {
            oRescisionDA.updateRescision(pRescisionBE);
        }

        public List<BusinessEntity.RescisionBE> listRescision(BusinessEntity.RescisionBE pRescisionBE)
        {
            return oRescisionDA.listRescision(pRescisionBE);
        }

        public BusinessEntity.RescisionBE getRescision(string idRescision)
        {
            return oRescisionDA.getRescision(idRescision);
        }
    }
}
