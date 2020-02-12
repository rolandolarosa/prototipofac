using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Efide.Tesoreria.BusinessEntity.adeudo;
using Efide.Tesoreria.DataAccess;
using Efide.Tesoreria.DataAccess.adeudo;
using Efide.Tesoreria.IntercafeData;
using Efide.Tesoreria.IntercafeData.adeudo;

namespace Efide.Tesoreria.BusinessLogic.adeudo
{
    public class SocioBancoBL : ISocioBancoD
    {
        private SocioBancoDA _SocioBancoDA;
        private SocioBancoDA oSocioBancoDA
        {
            get { return (_SocioBancoDA == null ? _SocioBancoDA = new SocioBancoDA() : _SocioBancoDA); }
        }

        public List<SocioBancoBE> listSocioBanco(SocioBancoBE pSocioBancoBE)
        {
            return oSocioBancoDA.listSocioBanco(pSocioBancoBE);
        }

        public void insertMovimintoSocio(RescisionBE pRescisionBE)
        {
            oSocioBancoDA.insertMovimintoSocio(pRescisionBE);
        }
    }
}
