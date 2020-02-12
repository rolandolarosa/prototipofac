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
    public class ConfirmacionDetalleBL : IConfirmacionDetalleD
    {
        private ConfirmacionDetalleDA _ConfirmacionDetalleDA;
        private ConfirmacionDetalleDA oConfirmacionDetalleDA
        {
            get { return (_ConfirmacionDetalleDA == null ? _ConfirmacionDetalleDA = new ConfirmacionDetalleDA() : _ConfirmacionDetalleDA); }
        }

        public string insertConfirmacionDetalle(ConfirmacionDetalleBE pConfirmacionDetalleBE)
        {
            return oConfirmacionDetalleDA.insertConfirmacionDetalle(pConfirmacionDetalleBE);
        }
    }
}
