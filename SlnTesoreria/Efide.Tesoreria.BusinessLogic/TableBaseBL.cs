using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Efide.Tesoreria.BusinessEntity;
using Efide.Tesoreria.DataAccess;
using Efide.Tesoreria.IntercafeData;

namespace Efide.Tesoreria.BusinessLogic
{
    public class TableBaseBL : ITableBaseD
    {
        private TableBaseDA _TableBaseDA;
        private TableBaseDA oTableBaseDA
        {
            get { return (_TableBaseDA == null ? _TableBaseDA = new TableBaseDA() : _TableBaseDA); }
        }

        public List<TableBaseBE> ProcesarTableBase(TableBaseBE BE)
        {
            return oTableBaseDA.ProcesarTableBase(BE);
        }
    }
}
