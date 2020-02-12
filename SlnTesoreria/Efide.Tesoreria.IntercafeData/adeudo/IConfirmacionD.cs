using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Efide.Tesoreria.BusinessEntity.adeudo;

namespace Efide.Tesoreria.IntercafeData.adeudo
{
    public interface IConfirmacionD
    {
        string insertConfirmacion(ConfirmacionBE pConfirmacionBE);
    }
}
