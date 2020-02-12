using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using EfideFactoringBE;
using Microsoft.Practices.EnterpriseLibrary.Data;

namespace EfideFactoringDA
{
    public class SocioDA
    {
        Database db = DatabaseFactory.CreateDatabase("ConexionStrDBEfideFactoring");
        DbCommand cmd = null;

        Database dbFENIXDB = DatabaseFactory.CreateDatabase("ConexionStrDBFENIXDB");

        public DataSet ProcesarSocio(SocioBE BE)
        {
            DataSet dsResult;
            try
            {
                cmd = db.GetStoredProcCommand("Socio_Mnt");
                db.AddInParameter(cmd, "OPCION", DbType.Int32, BE.OPCION);
                db.AddInParameter(cmd, "USUARIO", DbType.String, BE.USUARIO);
                db.AddInParameter(cmd, "CodSocio", DbType.String, BE.CodSocio);
                db.AddInParameter(cmd, "RazonSocial", DbType.String, BE.RazonSocial);
                dsResult = db.ExecuteDataSet(cmd);
            }
            catch (Exception ex)
            {   
                throw new Exception(ex.Message);
            }
            return dsResult;
        }

        public TercerCasoAuxBE obtenerTercerCaso(string codSocio, string NroCuenta)
        {
            IDataReader dr = null;
            try
            {
                TercerCasoAuxBE oTercerCasoAuxBE = null;
                using (DbCommand cmd = dbFENIXDB.GetStoredProcCommand("AdminBancos.usp_getTercerCaso"))
                {
                    cmd.CommandTimeout = 0;
                    dbFENIXDB.AddInParameter(cmd, "codSocio", DbType.String, codSocio);
                    dbFENIXDB.AddInParameter(cmd, "NroCuenta", DbType.String, NroCuenta);
                    dr = dbFENIXDB.ExecuteReader(cmd);

                    while (dr.Read())
                    {
                        oTercerCasoAuxBE = new TercerCasoAuxBE();

                        if (!dr.IsDBNull(dr.GetOrdinal("CodSocio")))
                            oTercerCasoAuxBE.CodSocio = dr.GetString(dr.GetOrdinal("CodSocio"));

                        if (!dr.IsDBNull(dr.GetOrdinal("TipoDoc")))
                            oTercerCasoAuxBE.TipoDoc = dr.GetString(dr.GetOrdinal("TipoDoc"));

                        if (!dr.IsDBNull(dr.GetOrdinal("NumDoc")))
                            oTercerCasoAuxBE.NumDoc = dr.GetString(dr.GetOrdinal("NumDoc"));

                        if (!dr.IsDBNull(dr.GetOrdinal("RUC")))
                            oTercerCasoAuxBE.RUC = dr.GetString(dr.GetOrdinal("RUC"));

                        if (!dr.IsDBNull(dr.GetOrdinal("Beneficiario")))
                            oTercerCasoAuxBE.Beneficiario = dr.GetString(dr.GetOrdinal("Beneficiario"));

                        if (!dr.IsDBNull(dr.GetOrdinal("NumCuentaLocal")))
                            oTercerCasoAuxBE.NumCuentaLocal = dr.GetString(dr.GetOrdinal("NumCuentaLocal"));

                        if (!dr.IsDBNull(dr.GetOrdinal("CodInterbancario")))
                            oTercerCasoAuxBE.CodInterbancario = dr.GetString(dr.GetOrdinal("CodInterbancario"));
                    }
                }

                return oTercerCasoAuxBE;
            }
            catch (Exception)
            {
                if (dr != null && !dr.IsClosed)
                    dr.Close();
                throw;
            }
        }

        public void actualizaTercerCaso(TercerCasoAuxBE pTercerCasoAuxBE)
        {
            try
            {
                cmd = dbFENIXDB.GetStoredProcCommand("AdminBancos.usp_updateTercerCaso");
                dbFENIXDB.AddInParameter(cmd, "CodSocio", DbType.String, pTercerCasoAuxBE.CodSocio);
                dbFENIXDB.AddInParameter(cmd, "TipoDoc", DbType.String, pTercerCasoAuxBE.TipoDoc);
                dbFENIXDB.AddInParameter(cmd, "NumDoc", DbType.String, pTercerCasoAuxBE.NumDoc);
                dbFENIXDB.AddInParameter(cmd, "RUC", DbType.String, pTercerCasoAuxBE.RUC);
                dbFENIXDB.AddInParameter(cmd, "Beneficiario", DbType.String, pTercerCasoAuxBE.Beneficiario);
                dbFENIXDB.AddInParameter(cmd, "NumCuentaLocal", DbType.String, pTercerCasoAuxBE.NumCuentaLocal);
                dbFENIXDB.AddInParameter(cmd, "CodInterbancario", DbType.String, pTercerCasoAuxBE.CodInterbancario);
                dbFENIXDB.ExecuteNonQuery(cmd);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public CuentaBancoBE obtenerDocumnetoSocio(string detOrdenID, string ordenBancoID)
        {
            IDataReader dr = null;
            try
            {
                CuentaBancoBE oCuentaBancoBE = null;
                using (DbCommand cmd = dbFENIXDB.GetStoredProcCommand("AdminBancos.uspGetOrdenBancoDetalle_Aux"))
                {
                    cmd.CommandTimeout = 0;
                    dbFENIXDB.AddInParameter(cmd, "detOrdenID", DbType.String, detOrdenID);
                    dbFENIXDB.AddInParameter(cmd, "ordenBancoID", DbType.String, ordenBancoID);
                    dr = dbFENIXDB.ExecuteReader(cmd);

                    while (dr.Read())
                    {
                        oCuentaBancoBE = new CuentaBancoBE();

                        if (!dr.IsDBNull(dr.GetOrdinal("CodPersonaSocio")))
                            oCuentaBancoBE.CodPersonaSocio = dr.GetString(dr.GetOrdinal("CodPersonaSocio"));

                        if (!dr.IsDBNull(dr.GetOrdinal("NroDocumentoSocio")))
                            oCuentaBancoBE.NroDocumentoSocio = dr.GetString(dr.GetOrdinal("NroDocumentoSocio"));

                        if (!dr.IsDBNull(dr.GetOrdinal("TipoDocumentoSocio")))
                            oCuentaBancoBE.TipoDocumentoSocio = dr.GetString(dr.GetOrdinal("TipoDocumentoSocio"));

                        if (!dr.IsDBNull(dr.GetOrdinal("NombreSocio")))
                            oCuentaBancoBE.NombreSocio = dr.GetString(dr.GetOrdinal("NombreSocio"));


                        if (!dr.IsDBNull(dr.GetOrdinal("CodPersonaRepresenta")))
                            oCuentaBancoBE.CodPersonaRepresenta = dr.GetString(dr.GetOrdinal("CodPersonaRepresenta"));

                        if (!dr.IsDBNull(dr.GetOrdinal("NroDocumentoRepresenta")))
                            oCuentaBancoBE.NroDocumentoRepresenta = dr.GetString(dr.GetOrdinal("NroDocumentoRepresenta"));

                        if (!dr.IsDBNull(dr.GetOrdinal("TipoDocumentoRepresenta")))
                            oCuentaBancoBE.TipoDocumentoRepresenta = dr.GetString(dr.GetOrdinal("TipoDocumentoRepresenta"));

                        if (!dr.IsDBNull(dr.GetOrdinal("NombreRepresenta")))
                            oCuentaBancoBE.NombreRepresenta = dr.GetString(dr.GetOrdinal("NombreRepresenta"));


                        if (!dr.IsDBNull(dr.GetOrdinal("CodPersonaAux")))
                            oCuentaBancoBE.CodPersonaAux = dr.GetString(dr.GetOrdinal("CodPersonaAux"));

                        if (!dr.IsDBNull(dr.GetOrdinal("NroDocumentoAux")))
                            oCuentaBancoBE.NroDocumentoAux = dr.GetString(dr.GetOrdinal("NroDocumentoAux"));

                        if (!dr.IsDBNull(dr.GetOrdinal("TipoDocumentoAux")))
                            oCuentaBancoBE.TipoDocumentoAux = dr.GetString(dr.GetOrdinal("TipoDocumentoAux"));

                        if (!dr.IsDBNull(dr.GetOrdinal("NombreAux")))
                            oCuentaBancoBE.NombreAux = dr.GetString(dr.GetOrdinal("NombreAux"));


                        if (!dr.IsDBNull(dr.GetOrdinal("CodPersonaExcel")))
                            oCuentaBancoBE.CodPersonaExcel = dr.GetString(dr.GetOrdinal("CodPersonaExcel"));

                        if (!dr.IsDBNull(dr.GetOrdinal("NroDocumentoExcel")))
                            oCuentaBancoBE.NroDocumentoExcel = dr.GetString(dr.GetOrdinal("NroDocumentoExcel"));

                        if (!dr.IsDBNull(dr.GetOrdinal("TipoDocumentoExcel")))
                            oCuentaBancoBE.TipoDocumentoExcel = dr.GetString(dr.GetOrdinal("TipoDocumentoExcel"));

                        if (!dr.IsDBNull(dr.GetOrdinal("NombreExcel")))
                            oCuentaBancoBE.NombreExcel = dr.GetString(dr.GetOrdinal("NombreExcel"));


                        if (!dr.IsDBNull(dr.GetOrdinal("NroDocumentoTerceraPersona")))
                            oCuentaBancoBE.NroDocumentoTerceraPersona = dr.GetString(dr.GetOrdinal("NroDocumentoTerceraPersona"));

                        if (!dr.IsDBNull(dr.GetOrdinal("TipoDocumentoTerceraPersona")))
                            oCuentaBancoBE.TipoDocumentoTerceraPersona = dr.GetString(dr.GetOrdinal("TipoDocumentoTerceraPersona"));


                        if (!dr.IsDBNull(dr.GetOrdinal("TipoOpeBanco")))
                            oCuentaBancoBE.TipoOpeBanco = dr.GetString(dr.GetOrdinal("TipoOpeBanco"));

                        if (!dr.IsDBNull(dr.GetOrdinal("comGlosa")))
                            oCuentaBancoBE.comGlosa = dr.GetString(dr.GetOrdinal("comGlosa"));

                        if (!dr.IsDBNull(dr.GetOrdinal("BancoDestino")))
                            oCuentaBancoBE.BancoDestino = dr.GetString(dr.GetOrdinal("BancoDestino"));

                        if (!dr.IsDBNull(dr.GetOrdinal("NroCuenta")))
                            oCuentaBancoBE.NroCuenta = dr.GetString(dr.GetOrdinal("NroCuenta"));

                        //if (!dr.IsDBNull(dr.GetOrdinal("Beneficiario")))
                        //    oCuentaBancoBE.Beneficiario = dr.GetString(dr.GetOrdinal("Beneficiario"));


                        if (!dr.IsDBNull(dr.GetOrdinal("valorOrigenID")))
                            oCuentaBancoBE.origen = Convert.ToInt32(dr.GetDecimal(dr.GetOrdinal("valorOrigenID")));

                        if (!dr.IsDBNull(dr.GetOrdinal("Tipo")))
                            oCuentaBancoBE.Tipo = dr.GetInt32(dr.GetOrdinal("Tipo"));
                    }
                }

                return oCuentaBancoBE;
            }
            catch (Exception)
            {
                if (dr != null && !dr.IsClosed)
                    dr.Close();
                throw;
            }
        }

        public void actualizaDocumnetoSocio(string detOrdenID, string ordenBancoID, int tipo, int origen, string @nroCuenta)
        {
            try
            {
                cmd = dbFENIXDB.GetStoredProcCommand("AdminBancos.uspInsertOrdenBancoDetalle_Aux");
                dbFENIXDB.AddInParameter(cmd, "detOrdenID", DbType.String, detOrdenID);
                dbFENIXDB.AddInParameter(cmd, "ordenBancoID", DbType.String, ordenBancoID);
                dbFENIXDB.AddInParameter(cmd, "nroCuenta", DbType.String, @nroCuenta);
                dbFENIXDB.AddInParameter(cmd, "tipo", DbType.Int32, tipo);
                dbFENIXDB.AddInParameter(cmd, "origen", DbType.Int32, origen);
                dbFENIXDB.ExecuteNonQuery(cmd);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
