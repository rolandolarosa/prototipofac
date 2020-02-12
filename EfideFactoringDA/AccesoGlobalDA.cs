using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EfideFactoringBE;
using Microsoft.Practices.EnterpriseLibrary.Data;

namespace EfideFactoringDA
{
    public class AccesoGlobalDA
    {
        Database db = DatabaseFactory.CreateDatabase("ConexionStrDBFENIXSEG");
        DbCommand cmd = null;

        public List<AccesoGlobalBE> ListaAccesos(string rolID, string usuarioID, string plataformaID, string moduloID)
        {
            List<AccesoGlobalBE> lstAccesoGlobalBE = new List<AccesoGlobalBE>();
            AccesoGlobalBE oAccesoGlobalBE;
            IDataReader dr = null;
            try
            {
                using (DbCommand cmd = db.GetStoredProcCommand("dbo.spSelectViewPermisosTM"))
                {
                    cmd.CommandTimeout = 0;
                    db.AddInParameter(cmd, "@rolID", System.Data.DbType.String, rolID);
                    db.AddInParameter(cmd, "@usuarioID", System.Data.DbType.String, usuarioID);
                    db.AddInParameter(cmd, "@plataformaID", System.Data.DbType.String, plataformaID);
                    db.AddInParameter(cmd, "@moduloID", System.Data.DbType.String, moduloID);
                    dr = db.ExecuteReader(cmd);

                    while (dr.Read())
                    {
                        oAccesoGlobalBE = new AccesoGlobalBE() {
                            menNomPublico = dr.GetString(dr.GetOrdinal("menNomPublico")),
                            menNomInterno = dr.GetString(dr.GetOrdinal("menNomInterno")),
                            menPadre = dr.GetInt32(dr.GetOrdinal("menPadre")),
                            menPosicion = dr.GetInt32(dr.GetOrdinal("menPosicion")),
                            menHijo = dr.GetInt32(dr.GetOrdinal("menHijo")),
                            perEstado = dr.GetBoolean(dr.GetOrdinal("perEstado"))
                        };
                        lstAccesoGlobalBE.Add(oAccesoGlobalBE);
                    }
                }
            }
            catch (Exception)
            {
                if (dr != null && !dr.IsClosed)
                    dr.Close();
                throw;
            }

            return lstAccesoGlobalBE;
        }
    }
}
