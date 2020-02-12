using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Efide.Tesoreria.DataAccess;
using Efide.Tesoreria.IntercafeData;

namespace Efide.Tesoreria.BusinessLogic
{
    public class InversionBL : IInversionD
    {
        private InversionDA _InversionDA;
        private InversionDA oInversionDA
        {
            get { return (_InversionDA == null ? _InversionDA = new InversionDA() : _InversionDA); }
        }

        public string insertInversion(BusinessEntity.InversionBE pInversionBE)
        {
            return oInversionDA.insertInversion(pInversionBE);
        }

        public void updateInversion(BusinessEntity.InversionBE pInversionBE)
        {
            oInversionDA.updateInversion(pInversionBE);
        }

        public void generarCartera(int pAnio, int pMes, string userName)
        {
            oInversionDA.generarCartera(pAnio, pMes, userName);
        }

        public List<BusinessEntity.InversionBE> listInversion(BusinessEntity.InversionBE pInversionBE)
        {
            return oInversionDA.listInversion(pInversionBE);
        }

        public BusinessEntity.InversionBE getInversion(string idInversion, DateTime fechaGlobal)
        {
            return oInversionDA.getInversion(idInversion, fechaGlobal);
        }

        public List<BusinessEntity.InversionBE> listCartera(int pAnio, int pMes)
        {
            return oInversionDA.listCartera(pAnio, pMes);
        }

        public List<BusinessEntity.CarteraExportBE> exportCartera(int pAnio, int pMes)
        {
            return oInversionDA.exportCartera(pAnio, pMes);
        }
    }
}
