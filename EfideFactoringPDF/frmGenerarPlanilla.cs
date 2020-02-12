using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using EfideFactoringBE;
using EfideFactoringBL;
using System.Data.SqlClient;
using System.Configuration;
using CrystalDecisions.Shared;
using EfideFactoringBE;
using EfideFactoringBL;
using System.Threading.Tasks;

namespace EfideFactoringPDF
{
    public partial class frmGenerarPlanilla : DevComponents.DotNetBar.OfficeForm
    {
        int TotalCola = 30;
        public frmGenerarPlanilla()
        {
            InitializeComponent();
        }

        private void frmGenerarPlanilla_Load(object sender, EventArgs e)
        {
            try
            {
                GenerarPlanilla(-15, 1);
                Task.Delay(300000).Wait();
                GenerarPlanilla(-7, 1);
                Task.Delay(300000).Wait();
                GenerarPlanilla(0, 3);
                Task.Delay(300000).Wait();
                GenerarPlanillaSocio(0, 3);
                GenerarEventos(2);
                GenerarEventos(4);
                GenerarEventos(5);

                //GenerarCartasNotariales(7, 9);
                GenerarCartasNotariales(7, 20);
                GenerarCartasNotariales(7, 30);

                //MessageBox.Show("Se generaron los archivos correctamente en el servidor", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Close();
                Dispose();
            }
            catch (Exception ex)
            {
                Close();
                Dispose();
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GenerarPlanilla(int Dias, int Opcion)
        {
            try
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("IdPagadora");
                dt.Columns.Add("IdSocio");
                dt.Columns.Add("IdLote");
                dt.Columns.Add("cItem");
                dt.Columns.Add("Pagadora");
                dt.Columns.Add("Socio");

                RobotCobranzasBE oEntity = new EfideFactoringBE.RobotCobranzasBE();
                oEntity.OPCION = Opcion;
                oEntity.Dias = Dias;
                DataSet ds = new RobotCobranzasBL().ProcesarRobotCobranzas(oEntity);

                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    DataRow dr = dt.NewRow();
                    dr["IdPagadora"] = row["IdPagadora"].ToString();
                    dr["IdSocio"] = row["IdSocio"].ToString();
                    dr["IdLote"] = row["IdLote"].ToString();
                    dr["cItem"] = row["cItem"].ToString();
                    dr["Pagadora"] = row["IdPagadora_Dsc"].ToString();
                    dr["Socio"] = row["Socio"].ToString();
                    dt.Rows.Add(dr);
                }

                DataView View = new DataView(dt);
                System.Data.DataTable dtDistinctPagadoras = View.ToTable(true, "IdPagadora", "Pagadora");

                System.Data.DataTable dtDistinctSocio = View.ToTable(true, "IdSocio", "Socio");

                string StrDocumento = string.Empty;
                System.Data.DataTable dtDocumentos = new System.Data.DataTable();

                int Count = 0;
                foreach (DataRow dr in dtDistinctPagadoras.Rows)
                {
                    DataRow[] drDocumentos = dt.Select("IdPagadora = '" + dr["IdPagadora"].ToString() + "'");

                    foreach (DataRow item in drDocumentos)
                    {
                        StrDocumento = StrDocumento + item[2].ToString().Trim() + "_" + item[3].ToString().Trim() + "&";
                    }

                    DataSet dsDatos = new DataSet();
                    using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConexionStrDBEfideFactoring"].ConnectionString))
                    {
                        SqlCommand cmd1 = new SqlCommand("dbo.Rpt_AvisoVencTituloValor", con);
                        cmd1.CommandType = CommandType.StoredProcedure;
                        cmd1.Parameters.AddWithValue("@Opcion", 1);
                        cmd1.Parameters.AddWithValue("@IdPagadora", dr["IdPagadora"].ToString());
                        cmd1.Parameters.AddWithValue("@StrDocumento", StrDocumento);
                        SqlDataAdapter daCab = new SqlDataAdapter(cmd1);
                        daCab.Fill(dsDatos, "dtVencTituloValor");
                        con.Close();
                    }

                    EfideFactoring.Formula.Crystal.crRptVencTituloValor oRpt = new EfideFactoring.Formula.Crystal.crRptVencTituloValor();
                    oRpt.SetDataSource(dsDatos);
                    oRpt.SetParameterValue("Pagadora", dr["Pagadora"].ToString());

                    string NombreDocumento = dr["IdPagadora"].ToString().Trim() + DateTime.Now.ToString("yyyyMMddmmss");
                    oRpt.ExportToDisk(ExportFormatType.PortableDocFormat, ConfigurationManager.AppSettings["RutaAvisoVenc"].ToString() + NombreDocumento + ".pdf");
                    oRpt.Dispose();
                    StrDocumento = string.Empty;

                    /************************************
                     * Enviar correo y generar bitacora
                     ***********************************/
                    if (Dias == -15)
                    {
                        oEntity = new EfideFactoringBE.RobotCobranzasBE();
                        oEntity.OPCION = 1;
                        oEntity.IdPagadora = dr["IdPagadora"].ToString();
                        oEntity.NombreDocumento = NombreDocumento;
                        new RobotCobranzasBL().ProcesarRobotCobranzas_Correo(oEntity);
                    }
                    else if (Dias == -7)
                    {
                        oEntity = new EfideFactoringBE.RobotCobranzasBE();
                        oEntity.OPCION = 2;
                        oEntity.IdPagadora = dr["IdPagadora"].ToString();
                        oEntity.NombreDocumento = NombreDocumento;
                        new RobotCobranzasBL().ProcesarRobotCobranzas_Correo(oEntity);
                    }
                    else if (Dias == 0)
                    {
                        oEntity = new EfideFactoringBE.RobotCobranzasBE();
                        oEntity.OPCION = 3;
                        oEntity.IdPagadora = dr["IdPagadora"].ToString();
                        oEntity.NombreDocumento = NombreDocumento;
                        new RobotCobranzasBL().ProcesarRobotCobranzas_Correo(oEntity);
                    }

                    Count++;

                    if (Count == TotalCola)
                    {
                        Task.Delay(300000).Wait();
                        Count = 0;
                    }
                }


                /********************************
                 * Enviar correos por Socios  
                 ********************************/

                //if (Dias == 0)
                //{
                //    foreach (DataRow dr in dtDistinctSocio.Rows)
                //    {
                //        DataRow[] drDocumentos = dt.Select("IdSocio = '" + dr["IdSocio"].ToString() + "'");

                //        foreach (DataRow item in drDocumentos)
                //        {
                //            StrDocumento = StrDocumento + item[2].ToString().Trim() + "_" + item[3].ToString().Trim() + "&";
                //        }

                //        DataSet dsDatos = new DataSet();
                //        using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConexionStrDBEfideFactoring"].ConnectionString))
                //        {
                //            SqlCommand cmd1 = new SqlCommand("dbo.Rpt_AvisoVencTituloValor", con);
                //            cmd1.CommandType = CommandType.StoredProcedure;
                //            cmd1.Parameters.AddWithValue("@Opcion", 1);
                //            cmd1.Parameters.AddWithValue("@IdSocio", dr["IdSocio"].ToString());
                //            cmd1.Parameters.AddWithValue("@StrDocumento", StrDocumento);
                //            SqlDataAdapter daCab = new SqlDataAdapter(cmd1);
                //            daCab.Fill(dsDatos, "dtVencTituloValor");
                //            con.Close();
                //        }

                //        EfideFactoring.Formula.Crystal.crRptVencTituloValor oRpt = new EfideFactoring.Formula.Crystal.crRptVencTituloValor();
                //        oRpt.SetDataSource(dsDatos);
                //        oRpt.SetParameterValue("Pagadora", dr["Socio"].ToString());

                //        string NombreDocumento = dr["IdSocio"].ToString().Trim() + DateTime.Now.ToString("yyyMMddmmss");
                //        oRpt.ExportToDisk(ExportFormatType.PortableDocFormat, ConfigurationManager.AppSettings["RutaAvisoVenc"].ToString() + "\\tmp\\" + NombreDocumento + ".pdf");
                //        StrDocumento = string.Empty;

                //        /**********************************
                //          Generar bitacora y Enviar correo
                //        ***********************************/
                //        oEntity = new EfideFactoringBE.RobotCobranzasBE();
                //        oEntity.OPCION = 5;
                //        oEntity.Usuario = "RobotCobranza";  
                //        oEntity.IdSocio = dr["IdSocio"].ToString();
                //        oEntity.NombreDocumento = NombreDocumento;
                //        new RobotCobranzasBL().ProcesarRobotCobranzas_Correo(oEntity);
                //    }
                //}
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GenerarPlanillaSocio(int Dias, int Opcion)
        {
            try
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("IdPagadora");
                dt.Columns.Add("IdSocio");
                dt.Columns.Add("IdLote");
                dt.Columns.Add("cItem");
                dt.Columns.Add("Pagadora");
                dt.Columns.Add("Socio");

                RobotCobranzasBE oEntity = new EfideFactoringBE.RobotCobranzasBE();
                oEntity.OPCION = Opcion;
                oEntity.Dias = Dias;
                DataSet ds = new RobotCobranzasBL().ProcesarRobotCobranzas(oEntity);

                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    DataRow dr = dt.NewRow();
                    dr["IdPagadora"] = row["IdPagadora"].ToString();
                    dr["IdSocio"] = row["IdSocio"].ToString();
                    dr["IdLote"] = row["IdLote"].ToString();
                    dr["cItem"] = row["cItem"].ToString();
                    dr["Pagadora"] = row["IdPagadora_Dsc"].ToString();
                    dr["Socio"] = row["Socio"].ToString();
                    dt.Rows.Add(dr);
                }

                DataView View = new DataView(dt);
                System.Data.DataTable dtDistinctPagadoras = View.ToTable(true, "IdPagadora", "Pagadora");

                System.Data.DataTable dtDistinctSocio = View.ToTable(true, "IdSocio", "Socio");

                string StrDocumento = string.Empty;
                System.Data.DataTable dtDocumentos = new System.Data.DataTable();

                if (Dias == 0)
                {
                    int Count = 0;
                    foreach (DataRow dr in dtDistinctSocio.Rows)
                    {
                        DataRow[] drDocumentos = dt.Select("IdSocio = '" + dr["IdSocio"].ToString() + "'");

                        foreach (DataRow item in drDocumentos)
                        {
                            StrDocumento = StrDocumento + item[2].ToString().Trim() + "_" + item[3].ToString().Trim() + "&";
                        }

                        DataSet dsDatos = new DataSet();
                        using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConexionStrDBEfideFactoring"].ConnectionString))
                        {
                            SqlCommand cmd1 = new SqlCommand("dbo.Rpt_AvisoVencTituloValor", con);
                            cmd1.CommandType = CommandType.StoredProcedure;
                            cmd1.Parameters.AddWithValue("@Opcion", 1);
                            cmd1.Parameters.AddWithValue("@IdSocio", dr["IdSocio"].ToString());
                            cmd1.Parameters.AddWithValue("@StrDocumento", StrDocumento);
                            SqlDataAdapter daCab = new SqlDataAdapter(cmd1);
                            daCab.Fill(dsDatos, "dtVencTituloValor");
                            con.Close();
                        }

                        EfideFactoring.Formula.Crystal.crRptVencTituloValor oRpt = new EfideFactoring.Formula.Crystal.crRptVencTituloValor();
                        oRpt.SetDataSource(dsDatos);
                        oRpt.SetParameterValue("Pagadora", dr["Socio"].ToString());

                        string NombreDocumento = dr["IdSocio"].ToString().Trim() + DateTime.Now.ToString("yyyMMddmmss");
                        oRpt.ExportToDisk(ExportFormatType.PortableDocFormat, ConfigurationManager.AppSettings["RutaAvisoVenc"].ToString() + "\\tmp\\" + NombreDocumento + ".pdf");
                        oRpt.Dispose();
                        StrDocumento = string.Empty;

                        /**********************************
                          Generar bitacora y Enviar correo
                        ***********************************/
                        oEntity = new EfideFactoringBE.RobotCobranzasBE();
                        oEntity.OPCION = 5;
                        oEntity.Usuario = "RobotCobranza";
                        oEntity.IdSocio = dr["IdSocio"].ToString();
                        oEntity.NombreDocumento = NombreDocumento;
                        new RobotCobranzasBL().ProcesarRobotCobranzas_Correo(oEntity);

                        Count++;

                        if (Count == TotalCola)
                        {
                            Task.Delay(300000).Wait();
                            Count = 0;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GenerarEventos(int Opcion)
        {
            try
            {
                EfideFactoringBE.RobotCobranzasBE oEntity = new EfideFactoringBE.RobotCobranzasBE();
                oEntity.OPCION = Opcion;
                new RobotCobranzasBL().ProcesarRobotCobranzas(oEntity);
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GenerarCartasNotariales(int Opcion, int _Dias)
        {
            try
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("IdPagadora");
                dt.Columns.Add("IdSocio");
                dt.Columns.Add("IdLote");
                dt.Columns.Add("cItem");
                dt.Columns.Add("Pagadora");
                dt.Columns.Add("Socio");

                RobotCobranzasBE oEntity = new EfideFactoringBE.RobotCobranzasBE();
                oEntity.OPCION = Opcion;
                oEntity.Dias = _Dias;
                DataSet ds = new RobotCobranzasBL().ProcesarRobotCobranzas(oEntity);

                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    DataRow dr = dt.NewRow();
                    dr["IdPagadora"] = row["IdPagadora"].ToString();
                    dr["IdSocio"] = row["IdSocio"].ToString();
                    dr["IdLote"] = row["IdLote"].ToString();
                    dr["cItem"] = row["cItem"].ToString();
                    dr["Pagadora"] = row["IdPagadora_Dsc"].ToString();
                    dr["Socio"] = row["Socio"].ToString();
                    dt.Rows.Add(dr);
                }

                DataView View = new DataView(dt);
                System.Data.DataTable dtDistinctPagadoras = View.ToTable(true, "IdPagadora", "Pagadora");

                //System.Data.DataTable dtDistinctSocio = View.ToTable(true, "IdSocio", "Socio");

                /********************************
                * GENERAR CARTA NOTARIAL PAGADORA
                ********************************/
                foreach (DataRow dr in dtDistinctPagadoras.Rows)
                {
                    DataSet dsDatos = new DataSet();
                    using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConexionStrDBEfideFactoring"].ConnectionString))
                    {
                        SqlCommand cmd1 = new SqlCommand("dbo.Rpt_CartaNotarialCobranza_Qry", con);
                        cmd1.CommandType = CommandType.StoredProcedure;
                        cmd1.Parameters.AddWithValue("@Opcion", 2);
                        cmd1.Parameters.AddWithValue("@IdEntidad", dr["IdPagadora"].ToString());
                        SqlDataAdapter daCab = new SqlDataAdapter(cmd1);
                        daCab.Fill(dsDatos, "dtCabecera");
                        con.Close();

                        SqlCommand cmd2 = new SqlCommand("dbo.Rpt_CartaNotarialCobranza_Qry", con);
                        cmd2.CommandType = CommandType.StoredProcedure;
                        cmd2.Parameters.AddWithValue("@Opcion", 4);
                        cmd2.Parameters.AddWithValue("@IdEntidad", dr["IdPagadora"].ToString());
                        cmd2.Parameters.AddWithValue("@Dias", _Dias);
                        SqlDataAdapter daCab1 = new SqlDataAdapter(cmd2);
                        daCab1.Fill(dsDatos, "dtDetalle");
                        con.Close();
                    }

                    EfideFactoring.Formula.Crystal.crRpt_CartaNotarialPagadora oRpt = new EfideFactoring.Formula.Crystal.crRpt_CartaNotarialPagadora();
                    oRpt.SetDataSource(dsDatos);

                    string NombreDocumento = "Pagadoras_" + dr["IdPagadora"].ToString().Trim() + DateTime.Now.ToString("yyyyMMddmmss") + ".pdf";
                    oRpt.ExportToDisk(ExportFormatType.PortableDocFormat, ConfigurationManager.AppSettings["RutaCartaNotariales"].ToString() + NombreDocumento);

                    // Generar movimiento de gestion notarial
                    using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConexionStrDBEfideFactoring"].ConnectionString))
                    {
                        DataSet dsGN = new DataSet();
                        SqlCommand cmd1 = new SqlCommand("dbo.GestionCartaNotarial_Mnt", con);
                        cmd1.CommandType = CommandType.StoredProcedure;
                        cmd1.Parameters.AddWithValue("@Opcion", 2);
                        cmd1.Parameters.AddWithValue("@IdCartaNotarial", string.Empty);
                        cmd1.Parameters.AddWithValue("@IdEntidad", dr["IdPagadora"].ToString());
                        cmd1.Parameters.AddWithValue("@IdEntidad_Dsc", dr["Pagadora"].ToString());
                        cmd1.Parameters.AddWithValue("@vAdjunto", NombreDocumento);
                        cmd1.Parameters.AddWithValue("@Usuario", "RobotCobranzas");
                        SqlDataAdapter daCab = new SqlDataAdapter(cmd1);
                        daCab.Fill(dsGN, "dtGN");
                        con.Close();
                    }

                    /********************************
                    * GENERAR CARTA NOTARIAL SOCIO
                    ********************************/
                    DataView ViewSocio = new DataView(dt);
                    ViewSocio.RowFilter = "IdPagadora = '" + dr["IdPagadora"].ToString() + "'";
                    System.Data.DataTable dtDistinctSocio = ViewSocio.ToTable(true, "IdSocio", "Socio");

                    foreach (DataRow drSocios in dtDistinctSocio.Rows)
                    {
                        dsDatos = new DataSet();
                        using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConexionStrDBEfideFactoring"].ConnectionString))
                        {
                            SqlCommand cmd1 = new SqlCommand("dbo.Rpt_CartaNotarialCobranza_Qry", con);
                            cmd1.CommandType = CommandType.StoredProcedure;
                            cmd1.Parameters.AddWithValue("@Opcion", 1);
                            cmd1.Parameters.AddWithValue("@IdSocio", drSocios["IdSocio"].ToString());
                            SqlDataAdapter daCab = new SqlDataAdapter(cmd1);
                            daCab.Fill(dsDatos, "dtCabecera");
                            con.Close();

                            SqlCommand cmd2 = new SqlCommand("dbo.Rpt_CartaNotarialCobranza_Qry", con);
                            cmd2.CommandType = CommandType.StoredProcedure;
                            cmd2.Parameters.AddWithValue("@Opcion", 4);
                            cmd2.Parameters.AddWithValue("@IdEntidad", dr["IdPagadora"].ToString());
                            cmd2.Parameters.AddWithValue("@IdSocio", drSocios["IdSocio"].ToString());
                            cmd2.Parameters.AddWithValue("@Dias", _Dias);
                            SqlDataAdapter daCab1 = new SqlDataAdapter(cmd2);
                            daCab1.Fill(dsDatos, "dtDetalle");
                            con.Close();
                        }

                        EfideFactoring.Formula.Crystal.crRpt_CartaNotarialSocio oRptSocios = new EfideFactoring.Formula.Crystal.crRpt_CartaNotarialSocio();
                        oRptSocios.SetDataSource(dsDatos);

                        NombreDocumento = "Socio_" + drSocios["IdSocio"].ToString().Trim() + DateTime.Now.ToString("yyyMMddmmss") + ".pdf";
                        oRptSocios.ExportToDisk(ExportFormatType.PortableDocFormat, ConfigurationManager.AppSettings["RutaCartaNotariales"].ToString() + NombreDocumento);

                        // Generar movimiento de gestion notarial
                        using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConexionStrDBEfideFactoring"].ConnectionString))
                        {
                            DataSet dsGN = new DataSet();
                            SqlCommand cmd1 = new SqlCommand("dbo.GestionCartaNotarial_Mnt", con);
                            cmd1.CommandType = CommandType.StoredProcedure;
                            cmd1.Parameters.AddWithValue("@Opcion", 2);
                            cmd1.Parameters.AddWithValue("@IdCartaNotarial", string.Empty);
                            cmd1.Parameters.AddWithValue("@IdEntidad", drSocios["IdSocio"].ToString());
                            cmd1.Parameters.AddWithValue("@IdEntidad_Dsc", drSocios["Socio"].ToString());
                            cmd1.Parameters.AddWithValue("@vAdjunto", NombreDocumento);
                            cmd1.Parameters.AddWithValue("@Usuario", "RobotCobranzas");
                            SqlDataAdapter daCab = new SqlDataAdapter(cmd1);
                            daCab.Fill(dsGN, "dtGN");
                            con.Close();
                        }

                        /********************************
                        * GENERAR CARTA NOTARIAL AVAL
                        ********************************/
                        /*dsDatos = new DataSet();
                        using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConexionStrDBEfideFactoring"].ConnectionString))
                        {
                            SqlCommand cmd1 = new SqlCommand("dbo.Rpt_CartaNotarialCobranza_Qry", con);
                            cmd1.CommandType = CommandType.StoredProcedure;
                            cmd1.Parameters.AddWithValue("@Opcion", 3);
                            cmd1.Parameters.AddWithValue("@IdSocio", drSocios["IdSocio"].ToString());
                            SqlDataAdapter daCab = new SqlDataAdapter(cmd1);
                            daCab.Fill(dsDatos, "dtCabecera");
                            con.Close();

                            if (dsDatos.Tables[0].Rows.Count > 0)
                            {

                                SqlCommand cmd2 = new SqlCommand("dbo.Rpt_CartaNotarialCobranza_Qry", con);
                                cmd2.CommandType = CommandType.StoredProcedure;
                                cmd2.Parameters.AddWithValue("@Opcion", 4);
                                cmd2.Parameters.AddWithValue("@IdEntidad", dr["IdPagadora"].ToString());
                                cmd2.Parameters.AddWithValue("@IdSocio", drSocios["IdSocio"].ToString());
                                cmd2.Parameters.AddWithValue("@Dias", _Dias);
                                SqlDataAdapter daCab1 = new SqlDataAdapter(cmd2);
                                daCab1.Fill(dsDatos, "dtDetalle");
                                con.Close();

                                EfideFactoring.Formula.Crystal.crRpt_CartaNotarialAval oRptAval = new EfideFactoring.Formula.Crystal.crRpt_CartaNotarialAval();
                                oRptAval.SetDataSource(dsDatos);

                                NombreDocumento = "Aval_" + drSocios["IdSocio"].ToString().Trim() + DateTime.Now.ToString("yyyMMddmmss") + ".pdf";
                                oRptAval.ExportToDisk(ExportFormatType.PortableDocFormat, ConfigurationManager.AppSettings["RutaCartaNotariales"].ToString() + NombreDocumento);

                                // Generar movimiento de gestion notarial
                                SqlCommand cmd3 = new SqlCommand("dbo.GestionCartaNotarial_Mnt", con);
                                cmd3.CommandType = CommandType.StoredProcedure;
                                cmd3.Parameters.AddWithValue("@Opcion", 2);
                                cmd3.Parameters.AddWithValue("@IdCartaNotarial", string.Empty);
                                cmd3.Parameters.AddWithValue("@IdEntidad", drSocios["IdSocio"].ToString());
                                cmd3.Parameters.AddWithValue("@IdEntidad_Dsc", drSocios["Socio"].ToString());
                                cmd3.Parameters.AddWithValue("@vAdjunto", NombreDocumento);
                                cmd3.Parameters.AddWithValue("@Usuario", "RobotCobranzas");
                                SqlDataAdapter daCab2 = new SqlDataAdapter(cmd2);
                                daCab2.Fill(dsDatos, "dtGN");
                                con.Close();
                            }
                        }*/

                        /**********************************
                            Generar bitacora y Enviar correo
                        ***********************************/
                        //oEntity = new EfideFactoringBE.RobotCobranzasBE();
                        //oEntity.OPCION = 5;
                        //oEntity.Usuario = "RobotCobranza";
                        //oEntity.IdSocio = dr["IdSocio"].ToString();
                        //oEntity.NombreDocumento = NombreDocumento;
                        //new RobotCobranzasBL().ProcesarRobotCobranzas_Correo(oEntity);
                    }
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}