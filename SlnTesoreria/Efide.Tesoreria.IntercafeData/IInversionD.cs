using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Efide.Tesoreria.BusinessEntity;

namespace Efide.Tesoreria.IntercafeData
{
    public interface IInversionD
    {
        string insertInversion(BusinessEntity.InversionBE pInversionBE);
        void updateInversion(BusinessEntity.InversionBE pInversionBE);
        void generarCartera(int pAnio, int pMes, string userName);
        List<BusinessEntity.InversionBE> listInversion(BusinessEntity.InversionBE pInversionBE);
        BusinessEntity.InversionBE getInversion(string idInversion, DateTime fechaGlobal);
        List<BusinessEntity.InversionBE> listCartera(int pAnio, int pMes);
        List<BusinessEntity.CarteraExportBE> exportCartera(int pAnio, int pMes);
    }
}
