using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary;
using EfideFactoringBE;
using System.Data.Common;
using System.Data;

namespace EfideFactoringDA
{
    public class OpcionDAL
    {
        Database db = DatabaseFactory.CreateDatabase("dbcashpoint");
        
        DbCommand cmd;
        DbDataReader midtr;

        public DataTable Listar()
        {
            cmd = db.GetStoredProcCommand("Opcion_Listar");
            try
            {
                return db.ExecuteDataSet(cmd).Tables[0]; 
            }
            catch (Exception EX)
            {
                throw new Exception(EX.Message);
            }
        }

        public DataTable ListarDetalle()
        {
            cmd = db.GetStoredProcCommand("Opcion_ListarDetalle");
            try
            {
                return db.ExecuteDataSet(cmd).Tables[0];
            }
            catch (Exception EX)
            {
                throw new Exception(EX.Message);
            }
        }

        public DataTable ListarSinAccion()
        {
            cmd = db.GetStoredProcCommand("Opcion_ListarSinAccion");
            try
            {
                return db.ExecuteDataSet(cmd).Tables[0];
            }
            catch (Exception EX)
            {
                throw new Exception(EX.Message);
            }
        }

        public int Opcion_Ins(OpcionBE objOpcionBE)
        {
            cmd = db.GetStoredProcCommand("Opcion_Ins");
            db.AddInParameter(cmd, "@IdPadre", DbType.Int32, objOpcionBE.IdPadre);
            db.AddInParameter(cmd, "@cOpcTipo", DbType.String, objOpcionBE.cOpcTipo);
            db.AddInParameter(cmd, "@cOpcDesc", DbType.String, objOpcionBE.cOpcDesc);
            db.AddInParameter(cmd, "@cOpcNom", DbType.String, objOpcionBE.cOpcNom);
            db.AddInParameter(cmd, "@cOpcNomMenu", DbType.String, objOpcionBE.cOpcNomMenu);
            db.AddInParameter(cmd, "@cOpcOrden", DbType.Int32, objOpcionBE.cOpcOrden);
            db.AddInParameter(cmd, "@cEstado", DbType.String, objOpcionBE.cEstado);
            db.AddInParameter(cmd, "@cUsuario", DbType.String, objOpcionBE.cUsuario);
            try
            {
                return Convert.ToInt32(db.ExecuteScalar(cmd));
            }
            catch (Exception EX)
            {
                throw new Exception(EX.Message);
            }
        }

        public bool Opcion_Del(int IdOpcion)
        {
            cmd = db.GetStoredProcCommand("Opcion_Del");
            db.AddInParameter(cmd, "@IdOpcion", DbType.Int32, IdOpcion);
            try
            {
                db.ExecuteScalar(cmd);
                return true;
            }
            catch (Exception EX)
            {
                throw new Exception(EX.Message);
            }
        }

        public DataSet Opcion_Sel(int IdOpcion)
        {
            cmd = db.GetStoredProcCommand("Opcion_Sel");
            db.AddInParameter(cmd, "@IdOpcion", DbType.Int32, IdOpcion);
            try
            {
                return db.ExecuteDataSet(cmd);
            }
            catch (Exception EX)
            {
                throw new Exception(EX.Message);
            }
        }

        public bool Opcion_Upd(int IdPadre, int IdOpcion)
        {
            cmd = db.GetStoredProcCommand("Opcion_Upd");
            db.AddInParameter(cmd, "@IdPadre", DbType.Int32, IdPadre);
            db.AddInParameter(cmd, "@IdOpcion", DbType.Int32, IdOpcion);
            try
            {
                db.ExecuteScalar(cmd);
                return true;
            }
            catch (Exception EX)
            {
                throw new Exception(EX.Message);
            }
        }

        public bool Opcion_Upd(OpcionBE OpcionBE)
        {
            cmd = db.GetStoredProcCommand("Opcion_UpdBE");
            db.AddInParameter(cmd, "@IdOpcion", DbType.Int32, OpcionBE.IdOpcion);
            db.AddInParameter(cmd, "@IdPadre", DbType.Int32, OpcionBE.IdPadre);
            db.AddInParameter(cmd, "@cOpcTipo", DbType.String, OpcionBE.cOpcTipo);
            db.AddInParameter(cmd, "@cOpcDesc", DbType.String, OpcionBE.cOpcDesc);
            db.AddInParameter(cmd, "@cOpcNom", DbType.String, OpcionBE.cOpcNom);
            db.AddInParameter(cmd, "@cOpcNomMenu", DbType.String, OpcionBE.cOpcNomMenu);
            db.AddInParameter(cmd, "@cOpcOrden", DbType.Int32, OpcionBE.cOpcOrden);
            db.AddInParameter(cmd, "@cEstado", DbType.String, OpcionBE.cEstado);
            db.AddInParameter(cmd, "@cUsuario", DbType.String, OpcionBE.cUsuario);
            try
            {
                db.ExecuteScalar(cmd);
                return true;
            }
            catch (Exception EX)
            {
                throw new Exception(EX.Message);
            }
        }

        public bool Opcion_UpdAccion(int IdOpcion, string Accion)
        {
            cmd = db.GetStoredProcCommand("Opcion_UpdAccion");
            db.AddInParameter(cmd, "@IdOpcion", DbType.Int32, IdOpcion);
            db.AddInParameter(cmd, "@Accion", DbType.String, Accion);
            try
            {
                db.ExecuteScalar(cmd);
                return true;
            }
            catch (Exception EX)
            {
                throw new Exception(EX.Message);
            }
        }

    }
}
