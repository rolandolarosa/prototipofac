using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Efide.Tesoreria.DataAccess;
using Efide.Tesoreria.IntercafeData;

namespace Efide.Tesoreria.BusinessLogic
{
    public class ConfirmacionDetalleBL : IConfirmacionDetalleD
    {
        private ConfirmacionDetalleDA _ConfirmacionDetalleDA;
        private ConfirmacionDetalleDA oConfirmacionDetalleDA
        {
            get { return (_ConfirmacionDetalleDA == null ? _ConfirmacionDetalleDA = new ConfirmacionDetalleDA() : _ConfirmacionDetalleDA); }
        }

        public string insertConfirmacionDetalle(BusinessEntity.ConfirmacionDetalleBE pConfirmacionDetalleBE)
        {
            return oConfirmacionDetalleDA.insertConfirmacionDetalle(pConfirmacionDetalleBE);
        }
    }
}
