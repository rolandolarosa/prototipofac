using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Efide.Tesoreria.BusinessEntity;

namespace Efide.Tesoreria.Populate
{
    public class TableBaseP
    {
        public static TableBaseBE ObtenerTableBase(IDataReader dr)
        {
            TableBaseBE oTableBaseBE = new TableBaseBE();

            if (!dr.IsDBNull(dr.GetOrdinal("Table_Id")))
                oTableBaseBE.Table_Id = dr.GetString(dr.GetOrdinal("Table_Id"));

            if (!dr.IsDBNull(dr.GetOrdinal("Table_Parent_Id")))
                oTableBaseBE.Table_Parent_Id = dr.GetString(dr.GetOrdinal("Table_Parent_Id"));

            if (!dr.IsDBNull(dr.GetOrdinal("Table_Name")))
                oTableBaseBE.Table_Name = dr.GetString(dr.GetOrdinal("Table_Name"));

            if (!dr.IsDBNull(dr.GetOrdinal("Table_Order")))
                oTableBaseBE.Table_Order = dr.GetString(dr.GetOrdinal("Table_Order"));

            if (!dr.IsDBNull(dr.GetOrdinal("Table_Value")))
                oTableBaseBE.Table_Value = dr.GetString(dr.GetOrdinal("Table_Value"));

            return oTableBaseBE;
        }
    }
}
