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
