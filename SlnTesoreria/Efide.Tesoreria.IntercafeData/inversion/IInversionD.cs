using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Efide.Tesoreria.BusinessEntity.inversion;

namespace Efide.Tesoreria.IntercafeData.inversion
{
    public interface IInversionD
    {
        string insertInversion(InversionBE pInversionBE);
        void updateInversion(InversionBE pInversionBE);
        void generarCartera(int pAnio, int pMes, string userName);
        List<InversionBE> listInversion(InversionBE pInversionBE);
        InversionBE getInversion(string idInversion, DateTime fechaGlobal);
        List<InversionBE> listCartera(int pAnio, int pMes);
        List<CarteraExportBE> exportCartera(int pAnio, int pMes);
    }
}
