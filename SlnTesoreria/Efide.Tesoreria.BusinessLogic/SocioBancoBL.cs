using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Efide.Tesoreria.DataAccess;
using Efide.Tesoreria.IntercafeData;

namespace Efide.Tesoreria.BusinessLogic
{
    public class SocioBancoBL : ISocioBancoD
    {
        private SocioBancoDA _SocioBancoDA;
        private SocioBancoDA oSocioBancoDA
        {
            get { return (_SocioBancoDA == null ? _SocioBancoDA = new SocioBancoDA() : _SocioBancoDA); }
        }

        public List<BusinessEntity.SocioBancoBE> listSocioBanco(BusinessEntity.SocioBancoBE pSocioBancoBE)
        {
            return oSocioBancoDA.listSocioBanco(pSocioBancoBE);
        }

        public void insertMovimintoSocio(BusinessEntity.RescisionBE pRescisionBE)
        {
            oSocioBancoDA.insertMovimintoSocio(pRescisionBE);
        }
    }
}
