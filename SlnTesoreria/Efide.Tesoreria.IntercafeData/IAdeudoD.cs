using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Efide.Tesoreria.IntercafeData
{
    public interface IAdeudoD
    {
        string insertAdeudo(BusinessEntity.AdeudoBE pAdedudoBE);
        void updateAdeudo(BusinessEntity.AdeudoBE pAdedudoBE);
        void generarCartera(int pAnio, int pMes, string userName);
        List<BusinessEntity.AdeudoBE> listAdeudo(BusinessEntity.AdeudoBE pAdedudoBE);
        BusinessEntity.AdeudoBE getAdeudo(string idAdedudo, DateTime fechaGlobal);
        List<BusinessEntity.AdeudoBE> listCartera(int pAnio, int pMes);
        List<BusinessEntity.CarteraExportBE> exportCartera(int pAnio, int pMes);
    }
}
