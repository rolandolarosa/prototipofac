using System;
using System.Data;
using System.Data.Common;
using EfideFactoringBE;
using Microsoft.Practices.EnterpriseLibrary.Data;

namespace EfideFactoringDA
{
   public class BitacoraComercialDA
   {

       Database db = DatabaseFactory.CreateDatabase("ConexionStrDBEfideFactoring");
       DbCommand cmd = null;

       public DataSet ProcesarBitacoraComercial(BitacoraComercialBE BE)
       {
           DataSet dsResult;
           try
           {
               cmd = db.GetStoredProcCommand("BitacoraComercial_Mnt");
               db.AddInParameter(cmd, "OPCION", DbType.Int32, BE.OPCION);
               db.AddInParameter(cmd, "USUARIO", DbType.String, BE.USUARIO);
               db.AddInParameter(cmd, "IdBitacoraComercial", DbType.String, BE.IdBitacoraComercial);
               db.AddInParameter(cmd, "IdSocio", DbType.String, BE.IdSocio);
               db.AddInParameter(cmd, "IdTipoBitacora_tt", DbType.String, BE.IdTipoBitacora_tt);
               db.AddInParameter(cmd, "Descripcion", DbType.String, BE.Descripcion);
               if (BE.FechaAlerta != DateTime.MinValue){ db.AddInParameter(cmd, "FechaAlerta", DbType.DateTime, BE.FechaAlerta);}
               db.AddInParameter(cmd, "IdEstado_tt", DbType.String, BE.IdEstado_tt);
               if (BE.FechaAtendido != DateTime.MinValue){ db.AddInParameter(cmd, "FechaAtendido", DbType.DateTime, BE.FechaAtendido);}
               db.AddInParameter(cmd, "IdGestor", DbType.String, BE.IdGestor);
               db.AddInParameter(cmd, "IdBitacoraComercialGenerada", DbType.String, BE.IdBitacoraComercialGenerada);
               db.AddInParameter(cmd, "FlgOrigen", DbType.Int32, BE.FlgOrigen); 
               dsResult = db.ExecuteDataSet(cmd);
           }
           catch (Exception ex)
           {
               throw new Exception(ex.Message);
           }
           return dsResult;
       }
   }
}

