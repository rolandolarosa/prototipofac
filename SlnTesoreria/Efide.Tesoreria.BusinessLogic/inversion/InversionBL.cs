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
    public class InversionBL : IInversionD
    {
        private InversionDA _InversionDA;
        private InversionDA oInversionDA
        {
            get { return (_InversionDA == null ? _InversionDA = new InversionDA() : _InversionDA); }
        }

        public string insertInversion(InversionBE pInversionBE)
        {
            return oInversionDA.insertInversion(pInversionBE);
        }

        public void updateInversion(InversionBE pInversionBE)
        {
            oInversionDA.updateInversion(pInversionBE);
        }

        public void generarCartera(int pAnio, int pMes, string userName)
        {
            oInversionDA.generarCartera(pAnio, pMes, userName);
        }

        public List<InversionBE> listInversion(InversionBE pInversionBE)
        {
            return oInversionDA.listInversion(pInversionBE);
        }

        public InversionBE getInversion(string idInversion, DateTime fechaGlobal)
        {
            return oInversionDA.getInversion(idInversion, fechaGlobal);
        }

        public List<InversionBE> listCartera(int pAnio, int pMes)
        {
            return oInversionDA.listCartera(pAnio, pMes);
        }

        public List<CarteraExportBE> exportCartera(int pAnio, int pMes)
        {
            return oInversionDA.exportCartera(pAnio, pMes);
        }
    }
}
