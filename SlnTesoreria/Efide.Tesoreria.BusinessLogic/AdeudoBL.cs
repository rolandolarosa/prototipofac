using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Efide.Tesoreria.DataAccess;
using Efide.Tesoreria.IntercafeData;

namespace Efide.Tesoreria.BusinessLogic
{
    public class AdeudoBL : IAdeudoD
    {
        private AdeudoDA _AdeudoDA;
        private AdeudoDA oAdeudoDA
        {
            get { return (_AdeudoDA == null ? _AdeudoDA = new AdeudoDA() : _AdeudoDA); }
        }

        public string insertAdeudo(BusinessEntity.AdeudoBE pAdeudoBE)
        {
            return oAdeudoDA.insertAdeudo(pAdeudoBE);
        }

        public void updateAdeudo(BusinessEntity.AdeudoBE pAdeudoBE)
        {
            oAdeudoDA.updateAdeudo(pAdeudoBE);
        }

        public void generarCartera(int pAnio, int pMes, string userName)
        {
            oAdeudoDA.generarCartera(pAnio, pMes, userName);
        }

        public List<BusinessEntity.AdeudoBE> listAdeudo(BusinessEntity.AdeudoBE pAdeudoBE)
        {
            return oAdeudoDA.listAdeudo(pAdeudoBE);
        }

        public BusinessEntity.AdeudoBE getAdeudo(string idAdeudo, DateTime fechaGlobal)
        {
            return oAdeudoDA.getAdeudo(idAdeudo, fechaGlobal);
        }

        public List<BusinessEntity.AdeudoBE> listCartera(int pAnio, int pMes)
        {
            return oAdeudoDA.listCartera(pAnio, pMes);
        }

        public List<BusinessEntity.CarteraExportBE> exportCartera(int pAnio, int pMes)
        {
            return oAdeudoDA.exportCartera(pAnio, pMes);
        }
    }
}
