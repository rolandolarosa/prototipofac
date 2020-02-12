using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Efide.Tesoreria.BusinessEntity;
using Efide.Tesoreria.BusinessEntity.adeudo;

namespace Efide.Tesoreria.IntercafeData.adeudo
{
    public interface ISocioBancoD
    {
        List<SocioBancoBE> listSocioBanco(SocioBancoBE pSocioBancoBE);
        void insertMovimintoSocio(RescisionBE pRescisionBE);
    }
}
