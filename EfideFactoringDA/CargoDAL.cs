using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.Data;
using System.Data.Common;
using EfideFactoringBE;

namespace EfideFactoringDA
{
    public class CargoDAL
    {
        Database db = DatabaseFactory.CreateDatabase("dbcashpoint");
        DbCommand cmd;
        DbDataReader midtr;
        public bool Insertar(CargoBE BE)
        {
            cmd = db.GetStoredProcCommand("Cargo_Mnt");
            db.AddInParameter(cmd, "@cCarNom",   DbType.String, BE.cCarNom);
            db.AddInParameter(cmd, "@Usuario", DbType.String, BE.Usuario);
            db.AddInParameter(cmd, "@Tipo", DbType.String, "02");
            try
            {
                db.ExecuteNonQuery(cmd);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool Actualizar(CargoBE BE)
        {
            cmd = db.GetStoredProcCommand("Cargo_Mnt");
            db.AddInParameter(cmd, "@cCarCod", DbType.String, BE.cCarCod);
            db.AddInParameter(cmd, "@cCarNom", DbType.String, BE.cCarNom);
            db.AddInParameter(cmd, "@Usuario", DbType.String, BE.Usuario);
            db.AddInParameter(cmd, "@Tipo", DbType.String, "02");
            try
            {
                db.ExecuteNonQuery(cmd);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool Eliminar(string xCarCod, string xUsuCod)
        {
            cmd = db.GetStoredProcCommand("Cargo_Mnt");
            db.AddInParameter(cmd, "@cCarCod", DbType.String, xCarCod);
            db.AddInParameter(cmd, "@Usuario", DbType.String, xUsuCod);
            db.AddInParameter(cmd, "@Tipo", DbType.String, "03");
            try
            {
                db.ExecuteNonQuery(cmd);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public CargoBE Buscar(string cCarCod)
        {
            CargoBE oCargoBE = new CargoBE();
            cmd = db.GetStoredProcCommand("Cargo_Mnt");
            db.AddInParameter(cmd, "@cCarCod", DbType.String, cCarCod);
            db.AddInParameter(cmd, "@Tipo", DbType.String, "01");
            try
            {
                midtr = db.ExecuteReader(cmd);
                if (midtr.HasRows)
                {
                    //Se lee los datos
                    midtr.Read();
                    var _with1 = oCargoBE;
                    _with1.ccarcod = (Information.IsDBNull(midtr("ccarcod")) ? "" : midtr("ccarcod"));
                    _with1.ccarnom = (Information.IsDBNull(midtr("ccarnom")) ? "" : midtr("ccarnom"));
                    _with1.Usuario = (Information.IsDBNull(midtr("cUsuCod_Mod")) ? "" : midtr("cUsuCod_Mod"));
                }
                midtr.Close();
            }
            catch (Exception ex)
            {
                throw;
            }
            return oCargoBE;
        }

        public DataTable ListarFiltro(string _cCarNom)
        {
            cmd = db.GetStoredProcCommand("Cargo_Mnt");
            db.AddInParameter(cmd, "@cCarNom", DbType.String, _cCarNom);
            db.AddInParameter(cmd, "@Tipo", DbType.String, "04");
            try
            {
                return db.ExecuteDataSet(cmd).Tables[0];
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


    }
}
