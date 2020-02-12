using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using EfideFactoringBE;
using EfideFactoringBL;
using System.Collections;
using System.Diagnostics;


namespace EfideFactoring.FormulaBase
{
    public partial class frmMenu : DevComponents.DotNetBar.OfficeForm
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private FechaSistemaBL FechaSistemaBL = new FechaSistemaBL();
        private void frmMenu_Load(object sender, EventArgs e)
        {
            validaActivacionMenu();

            foreach (Control control in this.Controls)
            {
                MdiClient client = control as MdiClient;
                if (!(client == null))
                {
                    client.BackColor = System.Drawing.Color.LightGray;
                    lblusuario.Text =  General.General.GetUsuario;
                    lblFecha.Text =   General.General.gFechaOp.ToString().Substring(0,10);

                    lblusuario1.Text = "Usuario: " + General.General.GetUsuario.Trim() + " | " + General.General.gRol_Dsc.Trim();
                    lblFecha1.Text = "Fecha: " + General.General.gFechaOp.ToString().Substring(0, 10);
                    break;
                }
            }
        }

        private void validaActivacionMenu()
        {
            if (validaUsuarioActivacionMenu())
            {
            TableBaseBL oTableBaseBL = new TableBaseBL();
            TableBaseBE oTableBaseBE = new TableBaseBE();
            string indActivador = string.Empty;
            DataSet ds = null;

            oTableBaseBE.Table_Id = System.Configuration.ConfigurationManager.AppSettings["ActivadorMenuDinamico"].ToString();
            oTableBaseBE.OPCION = 1;
            ds = oTableBaseBL.ProcesarTableBase(oTableBaseBE);
            indActivador = ds.Tables[0].Rows[0]["Table_Value"].ToString();

            if (indActivador == "1")
            {
                //mnuDesktop.Visible = false;
                mnuDesktop.Items.Clear();
                mnuDinamico.Visible = true;
                loadMenu();
            }
            else
                mnuDesktop.Visible = true;
        }
            else
                mnuDesktop.Visible = true;
        }

        private bool validaUsuarioActivacionMenu()
        {
            TableBaseBL oTableBaseBL = new TableBaseBL();
            TableBaseBE oTableBaseBE = new TableBaseBE();
            string indActivador = string.Empty;
            DataSet ds = null;

            oTableBaseBE.Table_Parent_Id = System.Configuration.ConfigurationManager.AppSettings["ListaUsuariosMenuDinamico"].ToString();
            oTableBaseBE.OPCION = 1;
            ds = oTableBaseBL.ProcesarTableBase(oTableBaseBE);

            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
	            {
                    if (row["Table_Value"].ToString().Trim() == EfideFactoring.General.General.GetCodigoUsuario.Trim())
                        return true;
	            } 
            }

            return false;
        }

        private void mnuDocumentos_Click(object sender, EventArgs e)
        {
            Formula.Catalogo.frmMntDocumento ofrmMntDocumento = new Formula.Catalogo.frmMntDocumento();
            ofrmMntDocumento.MdiParent = this;
            ofrmMntDocumento.Show();
        }

        private void mnuPagadora_Click(object sender, EventArgs e)
        {
            Formula.Catalogo.frmMntPagadora ofrmMntPagadora = new Formula.Catalogo.frmMntPagadora();
            ofrmMntPagadora.MdiParent = this;
            ofrmMntPagadora.Show();
        }

        private void mnuGrupo_Click(object sender, EventArgs e)
        {
            Formula.Catalogo.frmGrupoPagadora ofrmGrupoPagadora = new Formula.Catalogo.frmGrupoPagadora();
            ofrmGrupoPagadora.MdiParent = this;
            ofrmGrupoPagadora.Show();
        }

        private void mnuLineasAutorizadas_Click(object sender, EventArgs e)
        {
            Formula.Registros.frmMntLineasAutorizadas ofrmMntLineasAutorizadas = new Formula.Registros.frmMntLineasAutorizadas();
            ofrmMntLineasAutorizadas.MdiParent = this;
            ofrmMntLineasAutorizadas.Show();
        }

        private void mnuTablasBasicasC_Click(object sender, EventArgs e)
        {
            Formula.Catalogo.frmMntTablasBasicas ofrmMntTablasBasicas = new Formula.Catalogo.frmMntTablasBasicas();
            ofrmMntTablasBasicas.MdiParent = this;
            ofrmMntTablasBasicas.Show();
        }

        private void mnuSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void mnuRegistroCobranza_Click(object sender, EventArgs e)
        {
            Formula.Cobranza.frmMntCobranzaPagadora ofrmMntCobranzaPagadora = new Formula.Cobranza.frmMntCobranzaPagadora();
            ofrmMntCobranzaPagadora.MdiParent = this;
            ofrmMntCobranzaPagadora.Show();
        }

        private void mnuRegistroLotes_Click(object sender, EventArgs e)
        {
            Formula.Registros.frmMntLote ofrmMntLote = new Formula.Registros.frmMntLote();
            ofrmMntLote.MdiParent = this;
            ofrmMntLote.Show();
        }

        private void mnuCobranzaSocios_Click(object sender, EventArgs e)
        {
            Formula.Cobranza.frmMntCobranzaSocio ofrmMntCobranzaSocio = new Formula.Cobranza.frmMntCobranzaSocio();
            ofrmMntCobranzaSocio.MdiParent = this;
            ofrmMntCobranzaSocio.Show();
        }

        private void mnuAprobacionLotes_Click(object sender, EventArgs e)
        {
            Formula.Registros.frmLoteAprobacion ofrmLoteAprobacion = new Formula.Registros.frmLoteAprobacion();
            ofrmLoteAprobacion.MdiParent = this;
            ofrmLoteAprobacion.Show();
        }

        private void mnuTarifario_Click(object sender, EventArgs e)
        {
            Formula.Catalogo.frmMntTarifario ofrmMntTarifario = new Formula.Catalogo.frmMntTarifario();
            ofrmMntTarifario.MdiParent = this;
            ofrmMntTarifario.Show();
        }

        private void mnuProductosFactoring_Click(object sender, EventArgs e)
        {
            Formula.Catalogo.frmMntProductosFactoring ofrmMntProductosFactoring = new Formula.Catalogo.frmMntProductosFactoring();
            ofrmMntProductosFactoring.MdiParent = this;
            ofrmMntProductosFactoring.Show();
        }

        private void mnuConfirmacionCobranza_Click(object sender, EventArgs e)
        {
            Formula.Cobranza.frmMntCobranzaPagadoraConf ofrm = new Formula.Cobranza.frmMntCobranzaPagadoraConf();
            ofrm.MdiParent = this;
            ofrm.Show();   
        }

        private void mnuRenovacionL_Click(object sender, EventArgs e)
        {
            Formula.Renovacion.frmRenovacion ofrm = new Formula.Renovacion.frmRenovacion();
            ofrm.MdiParent = this;
            ofrm.Show();  
        }

        private void mnuTarifarioExepciones_Click(object sender, EventArgs e)
        {
            Formula.Catalogo.frmMntTarifarioExepciones ofrmMntTarifario = new Formula.Catalogo.frmMntTarifarioExepciones();
            ofrmMntTarifario.MdiParent = this;
            ofrmMntTarifario.Show();
        }

        private void mnuGenerarLotes_Click(object sender, EventArgs e)
        {
            Formula.Registros.frmGeneracionLote ofrmGeneracionLote = new Formula.Registros.frmGeneracionLote();
            ofrmGeneracionLote.MdiParent = this;
            ofrmGeneracionLote.Show();
        }

        private void reporteDePrestamosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formula.Reportes.frmRptCreditos ofrmRptCreditos = new Formula.Reportes.frmRptCreditos();
            //ofrmRepPrestamos.MdiParent = this;
            ofrmRptCreditos.Show();
        }

        private void mnuRepCobranzas_Click(object sender, EventArgs e)
        {
            Formula.Reportes.frmRptCobranza ofrmRptCobranza = new Formula.Reportes.frmRptCobranza();
            //ofrmRptCobranza.MdiParent = this;
            ofrmRptCobranza.Show();
        }

        private void mnuSaldosLineasSocios_Click(object sender, EventArgs e)
        {
            Formula.Consulta.frmConSaldoSocio ofrmConSaldoSocio = new Formula.Consulta.frmConSaldoSocio();
            ofrmConSaldoSocio.MdiParent = this;
            ofrmConSaldoSocio.Show();
        }

        private void mnuEnvioCargoCancelados_Click(object sender, EventArgs e)
        {
            Formula.Cobranza.frmEnvioCargo ofrmEnvioCargo = new Formula.Cobranza.frmEnvioCargo();
            ofrmEnvioCargo.MdiParent = this;
            ofrmEnvioCargo.Show();
        }

        private void mnuSaldosLineaPagadoras_Click(object sender, EventArgs e)
        {
            Formula.Consulta.frmConSaldoPagador ofrmConSaldoPagador = new Formula.Consulta.frmConSaldoPagador();
            ofrmConSaldoPagador.MdiParent = this;
            ofrmConSaldoPagador.Show();
        }

        private void mnuLetrasProtestar_Click(object sender, EventArgs e)
        {
            Formula.Cobranza.frmTituloValorProtestar ofrmTituloValorProtestar = new Formula.Cobranza.frmTituloValorProtestar();
            ofrmTituloValorProtestar.MdiParent = this;
            ofrmTituloValorProtestar.Show();
        }

        private void mnuTituloValor_Click(object sender, EventArgs e)
        {
            Formula.Cobranza.frmEnvioVencimientoTituloValor ofrmEnvioVencimientoTituloValor = new Formula.Cobranza.frmEnvioVencimientoTituloValor();
            ofrmEnvioVencimientoTituloValor.MdiParent = this;
            ofrmEnvioVencimientoTituloValor.Show();
        }

        private void mnuDocumento_Click(object sender, EventArgs e)
        {
            Formula.Cobranza.frmEnvioVencimientoDocumento ofrm = new Formula.Cobranza.frmEnvioVencimientoDocumento();
            ofrm.MdiParent = this;
            ofrm.Show();
        }

        private void mnuRepCobranzasPagadora_Click(object sender, EventArgs e)
        {
            Formula.Reportes.frmRpt_CobranzaPagadora ofrmRptCobranza = new Formula.Reportes.frmRpt_CobranzaPagadora();
            ofrmRptCobranza.MdiParent = this;
            ofrmRptCobranza.Show();
        }

        private void avisoDeVencimientoTítuloValorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formula.Cobranza.frmEnvioVencimientoTituloValor ofrmEnvioVencimientoTituloValor = new Formula.Cobranza.frmEnvioVencimientoTituloValor();
            ofrmEnvioVencimientoTituloValor.MdiParent = this;
            ofrmEnvioVencimientoTituloValor.Show();

        }

        private void avisoDeVencimientoDocumentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formula.Cobranza.frmEnvioVencimientoDocumento ofrm = new Formula.Cobranza.frmEnvioVencimientoDocumento();
            ofrm.MdiParent = this;
            ofrm.Show();
        }

        private void mnuAppCCyCP_Click(object sender, EventArgs e)
        {
            Formula.frmMatchSocio ofrm = new Formula.frmMatchSocio();
            ofrm.MdiParent = this;
            ofrm.Show();
        }

        private void mnuMntCarteraCandidato_Click(object sender, EventArgs e)
        {
            Formula.GestionComercial.frmCarteraCandidato ofrm = new Formula.GestionComercial.frmCarteraCandidato();
            ofrm.MdiParent = this;
            ofrm.Show();
        }

        private void mnuGestion_Click(object sender, EventArgs e)
        {
            Formula.GestionComercial.frmGestion ofrm = new Formula.GestionComercial.frmGestion();
            ofrm.MdiParent = this;
            ofrm.Show();
        }

        private void mnuCargaSocios_Click(object sender, EventArgs e)
        {
            Formula.GestionComercial.frmCarteraSocioCarga ofrm = new Formula.GestionComercial.frmCarteraSocioCarga();
            ofrm.MdiParent = this;
            ofrm.Show();
        }

        private void mnuCargaCandidatos_Click(object sender, EventArgs e)
        {
            Formula.GestionComercial.frmCarteraCandidatoCarga ofrm = new Formula.GestionComercial.frmCarteraCandidatoCarga();
            ofrm.MdiParent = this;
            ofrm.Show();
        }

        private void mnuMntTipoUsuarios_Click(object sender, EventArgs e)
        {
            Formula.GestionComercial.frmUsuarioXTipo ofrm = new Formula.GestionComercial.frmUsuarioXTipo();
            ofrm.MdiParent = this;
            ofrm.Show();
        }

        private void mnuAsignarSocios_Click(object sender, EventArgs e)
        {
            Formula.GestionComercial.frmAsignarSocio ofrm = new Formula.GestionComercial.frmAsignarSocio();
            ofrm.MdiParent = this;
            ofrm.Show();
        }

        private void mnuUsuariosXSocios_Click(object sender, EventArgs e)
        {
            Formula.GestionComercial.frmSociosXUsuarios ofrm = new Formula.GestionComercial.frmSociosXUsuarios();
            ofrm.MdiParent = this;
            ofrm.Show();
        }

        private void mnuConfirmacionOperaciones_Click(object sender, EventArgs e)
        {
            Formula.Registros.frmQryOperacionesProceso ofrm = new Formula.Registros.frmQryOperacionesProceso();
            ofrm.Tipo = 1;
            ofrm.MdiParent = this;
            ofrm.Show();
        }

        private void micargaDeDatosTop10K_Click(object sender, EventArgs e)
        {
            Formula.Top10K.frmCargaDatosTop10K ofrm = new Formula.Top10K.frmCargaDatosTop10K();
            ofrm.MdiParent = this;
            ofrm.Show();
        }

        private void mmuCargaDeDatosSentinel_Click(object sender, EventArgs e)
        {
            Formula.Top10K.frmCargaDatosSentinel ofrm = new Formula.Top10K.frmCargaDatosSentinel();
            ofrm.MdiParent = this;
            ofrm.Show();
        }

        private void mmuAprobaciónDeComite_Click(object sender, EventArgs e)
        {
            Formula.Top10K.frmAprobacionComite ofrm = new Formula.Top10K.frmAprobacionComite();
            ofrm.MdiParent = this;
            ofrm.Show();
        }

        private void mmuEnvioConfirmacion_Click(object sender, EventArgs e)
        {
            Formula.Registros.frmProcesoConfirmacionP ofrm = new Formula.Registros.frmProcesoConfirmacionP();
            ofrm.MdiParent = this;
            ofrm.Show();
        }

        private void registroDePlanillaFase0ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formula.Registros.frmMntLote ofrmMntLote = new Formula.Registros.frmMntLote();
            ofrmMntLote.Fase = "0";
            ofrmMntLote.MdiParent = this;
            ofrmMntLote.Show();
        }

        private void reporteComercialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formula.Reportes.frmRptComercial  ofrm = new Formula.Reportes.frmRptComercial();
            ofrm.MdiParent = this;
            ofrm.Show();
        }

        private void mnuOperacionesProceso_Click(object sender, EventArgs e)
        {
            Formula.Registros.frmQryOperacionesProceso ofrm = new Formula.Registros.frmQryOperacionesProceso();
            ofrm.Tipo = 2;
            ofrm.MdiParent = this;
            ofrm.Show();
        }

        private void mnuCatalogo_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    DataSet dsDatos = new DataSet();
            //    string IdSocio = txtIdSocio.Text;
            //    using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConexionStrDBEfideFactoring"].ConnectionString))
            //    {
            //        SqlCommand cmd1 = new SqlCommand("dbo.Rpt_Cobranza", con);
            //        cmd1.CommandType = CommandType.StoredProcedure;
            //        cmd1.Parameters.AddWithValue("@IdSocio", IdSocio);
            //        cmd1.Parameters.AddWithValue("@FechaCorte", dtInicio.Value);
            //        cmd1.Parameters.AddWithValue("@Opcion", 1);
            //        SqlDataAdapter daCab = new SqlDataAdapter(cmd1);
            //        daCab.Fill(dsDatos, "dtCobranzaSocio");
            //        con.Close();
            //    }

            //    Crystal.crRptCobranzaSocioAll ocrLoteLiquidacion = new Crystal.crRptCobranzaSocioAll();
            //    Reportes.frmVisorLoteLiquidacion ofrmVisorLoteLiquidacion = new Reportes.frmVisorLoteLiquidacion();
            //    ofrmVisorLoteLiquidacion.crvVisorLoteLiq.ReportSource = ocrLoteLiquidacion;
            //    ocrLoteLiquidacion.SetDataSource(dsDatos);
            //    ocrLoteLiquidacion.SetParameterValue("usuario", General.General.GetUsuario);
            //    ocrLoteLiquidacion.SetParameterValue("FechaCorte", dtInicio.Value);
            //    ofrmVisorLoteLiquidacion.ShowDialog();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}


        }

        private void gestiónComercialToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mnuGestionComercial_Click(object sender, EventArgs e)
        {
            Formula.GestionComercial.frmBitacoraComercial ofrm = new Formula.GestionComercial.frmBitacoraComercial();
            ofrm.MdiParent = this;
            ofrm.Show();
        }

        private void mmuMetasporEjecutivo_Click(object sender, EventArgs e)
        {
            Formula.GestionComercial.frmMntGestionMetas ofrm = new Formula.GestionComercial.frmMntGestionMetas();
            ofrm.MdiParent = this;
            ofrm.Show();
        }

        private void mmuRptAvaneGestion_Click(object sender, EventArgs e)
        {
            Formula.GestionComercial.frmRptAvanceGestion ofrm = new Formula.GestionComercial.frmRptAvanceGestion();
            ofrm.MdiParent = this;
            ofrm.Show();
        }

        private void mnuRptCColocacionesDeudor_Click(object sender, EventArgs e)
        {
            Formula.Reportes.frmRptColocacionesDeudor ofrm = new Formula.Reportes.frmRptColocacionesDeudor();
            ofrm.MdiParent = this;
            ofrm.Show();
        }

        private void registroTercerCasoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formula.Registros.frmMntTercerCaso ofrm = new Formula.Registros.frmMntTercerCaso();
            ofrm.MdiParent = this;
            ofrm.Show();
        }

        private void mnuRptColocacionesCaptaciones_Click(object sender, EventArgs e)
        {
            Formula.Reportes.frmRptMovimientoColocaciones ofrm = new Formula.Reportes.frmRptMovimientoColocaciones();
            ofrm.MdiParent = this;
            ofrm.Show();
        }

        private void mnuReporteCreditos_Click(object sender, EventArgs e)
        {
            Formula.Reportes.frmRptCreditosResumen ofrm = new Formula.Reportes.frmRptCreditosResumen();
            ofrm.MdiParent = this;
            ofrm.Show();
        }

        private void mnuProcesarPeriodoGC_Click(object sender, EventArgs e)
        {
            Formula.GestionComercial.frmGestionComercialProcesar ofrm = new Formula.GestionComercial.frmGestionComercialProcesar();
            ofrm.MdiParent = this;
            ofrm.Show();
        }

        #region FUNCTION
        private void loadMenu()
        {
            List<AccesoGlobalBE> lstAccesoGlobalBE = new List<AccesoGlobalBE>();
            List<AccesoGlobalBE> lstAccesoGlobalBEPadre = new List<AccesoGlobalBE>();
            List<AccesoGlobalBE> lstAccesoGlobalBEHijo = new List<AccesoGlobalBE>();
            AccesoGlobalBL oAccesoGlobalBL = new AccesoGlobalBL();
            ToolStripMenuItem subMenuPadre;
            ToolStripMenuItem subMenuHijo;

            if (mnuDesktop.Items.Count > 0)
                return;

            string rolID  = General.General.gRol; //"0010000000037R1     ";
            string usuarioID = General.General.GetUsuario; //"ADMIN";
	        string plataformaID = "0010000000005PT     ";
            string moduloID = "0010000000001MD     ";

            lstAccesoGlobalBE = oAccesoGlobalBL.ListaAccesos(rolID.Trim(), usuarioID.Trim(), plataformaID.Trim(), moduloID.Trim());

            lstAccesoGlobalBEPadre = lstAccesoGlobalBE.FindAll(x => x.menPadre == 0 && x.perEstado);
            lstAccesoGlobalBEPadre.Sort((x, y) => x.menPosicion.CompareTo(y.menPosicion));

            mnuDesktop.Items.Clear();
            foreach (AccesoGlobalBE item in lstAccesoGlobalBEPadre)
            {
                lstAccesoGlobalBEHijo = lstAccesoGlobalBE.FindAll(x => x.menPadre == item.menPosicion && x.perEstado && (item.menNomInterno != "mnuGestionCobranza"));
                lstAccesoGlobalBEHijo.Sort((x, y) => x.menPosicion.CompareTo(y.menPosicion));
                subMenuPadre = new ToolStripMenuItem() {  Text = item.menNomPublico, Name = item.menNomInterno, Tag = item.menNomInterno };
                if (item.menNomInterno == "mnuGestionCobranza")
                    subMenuPadre.Click += new System.EventHandler(abrirFormulario);

                foreach (AccesoGlobalBE itemHijo in lstAccesoGlobalBEHijo)
                {
                    subMenuHijo = new ToolStripMenuItem() { Text = itemHijo.menNomPublico, Name = itemHijo.menNomInterno, Tag = itemHijo.menNomInterno };
                    subMenuHijo.Click += new System.EventHandler(abrirFormulario);

                    subMenuPadre.DropDownItems.Add(subMenuHijo);
                }

                mnuDesktop.Items.Add(subMenuPadre);
            }
        }

        private void abrirFormulario(object sender, System.EventArgs e)
        {
            try
	        {
                string strForm = ((System.Windows.Forms.ToolStripMenuItem) sender).Tag.ToString();
                ProcessStartInfo info;

                switch (strForm)
	            {
                    case "mnuSalir": this.Dispose();
                    break;
                    case "mnuReporteFENACREP":
                    {
                        info = new ProcessStartInfo();
                        info.UseShellExecute = true;
                        info.FileName = "Efide.Fenacrep.Winfenacrep.appref-ms";
                        info.WorkingDirectory = @"\\EFIDESIS\tmp\publish\";
                        info.Arguments = "HLOPEZ|123|2018/06/15";
                        Process.Start(info);
                        return;
                    }
                    case "mnuEstadoResultado":
                    {
                        info = new ProcessStartInfo();
                        info.UseShellExecute = true;
                        info.FileName = "Efide.Reportes.Contabilidad.appref-ms";
                        info.WorkingDirectory = @"\\EFIDESIS\tmp\publish\ReportesContabilidad\";
                        //info.Arguments = "HLOPEZ|123|2018/06/15";
                        Process.Start(info);
                        return;
                    }
                    case "mnuPlanillaEjecutivo":
                    {
                        info = new ProcessStartInfo();
                        info.UseShellExecute = true;
                        info.FileName = "EfideFactoringXML.appref-ms";
                        info.WorkingDirectory = @"\\EFIDESIS\tmp\publish\RegistroPlanillaEjecutivoXML\";
                        info.Arguments = General.General.GetUsuario.Trim() + "|" + General.General.gFechaOp.Date.ToString("d");
                        Process.Start(info);
                        return;
                    }
                    case "mnuInversiones":
                    {
                        info = new ProcessStartInfo();
                        info.UseShellExecute = true;
                        info.FileName = "Efide.Tesoreria.WinAdeudosInversiones.appref-ms";
                        info.WorkingDirectory = @"\\EFIDESIS\tmp\publish\Inversiones\";
                        info.Arguments = General.General.GetUsuario.Trim() + "|" + General.General.gFechaOp.Date.ToString("d");
                        Process.Start(info);
                        return;
                    }
                    case "mnuAdeudos":
                    {
                        info = new ProcessStartInfo();
                        info.UseShellExecute = true;
                        info.FileName = "Efide.Tesoreria.WinAdeudos.appref-ms";
                        info.WorkingDirectory = @"\\EFIDESIS\tmp\publish\Adeudos\";
                        info.Arguments = General.General.GetUsuario.Trim() + "|" + General.General.gFechaOp.Date.ToString("d");
                        Process.Start(info);
                        return;
                    }
                    case "mnuGestionCobranza":
                    {
                        info = new ProcessStartInfo();
                        info.UseShellExecute = true;
                        info.FileName = "EfideGestion.Aplicacion.appref-ms";
                        info.WorkingDirectory = @"\\EFIDESIS\tmp\publish\EfideGestion\";
                        info.Arguments = General.General.GetUsuario.Trim() + "|" + General.General.gFechaOp.Date.ToString("d") + "|" + General.General.gSesionID;
                        Process.Start(info);
                        return;
                    }
                    case "mnuBancosOperaciones":
                    {
                        info = new ProcessStartInfo();
                        info.UseShellExecute = true;
                        info.FileName = "EfideResumenBanco.Aplicacion.appref-ms";
                        info.WorkingDirectory = @"\\efidesis\EJECUTABLES_EFIDE\Aplicaciones\ResumenBanco\";
                        //info.Arguments = General.General.GetUsuario.Trim() + "|" + General.General.gFechaOp.Date.ToString("d") + "|" + General.General.gSesionID;
                        Process.Start(info);
                        return;
                    }
                    case "mnuSimuladorCronogramaDpf":
                    {
                        info = new ProcessStartInfo();
                        info.UseShellExecute = true;
                        info.FileName = "SimuladorCronograma.appref-ms";
                        info.WorkingDirectory = @"\\EFIDESIS\tmp\publish\SimuladorCronograma\";
                        info.Arguments = "frmSimuladorDpf" + "|" + General.General.GetUsuario.Trim();
                        Process.Start(info);
                        return;
                    }
                    case "mnuSimuladorCronogramaPrestamo":
                    {
                        info = new ProcessStartInfo();
                        info.UseShellExecute = true;
                        info.FileName = "SimuladorCronograma.appref-ms";
                        info.WorkingDirectory = @"\\EFIDESIS\tmp\publish\SimuladorCronograma\";
                        info.Arguments = "frmSimuladorPrestamo" + "|" + General.General.GetUsuario.Trim();
                        Process.Start(info);
                        return;
                    }
                    case "mnufrmBusquedaTransfDepo":
                    {
                        info = new ProcessStartInfo();
                        info.UseShellExecute = true;
                        info.FileName = "Efide.WinApplication.appref-ms";
                        info.WorkingDirectory = @"\\EFIDESIS\tmp\publish\Consultas\";
                        info.Arguments = "frmBusquedaTransfDepo";
                        Process.Start(info);
                        return;
                    }
	            }

                Type frmType;
                if (strForm.LastIndexOf("_1") > 0)
                    frmType = Type.GetType("EfideFactoring." + strForm.Substring(0, strForm.LastIndexOf("_1")));
                else if (strForm.LastIndexOf("_2") > 0)
                    frmType = Type.GetType("EfideFactoring." + strForm.Substring(0, strForm.LastIndexOf("_2")));
                else if (strForm.LastIndexOf("_3") > 0)
                    frmType = Type.GetType("EfideFactoring." + strForm.Substring(0, strForm.LastIndexOf("_3")));
                else if (strForm.LastIndexOf("_4") > 0)
                    frmType = Type.GetType("EfideFactoring." + strForm.Substring(0, strForm.LastIndexOf("_4")));
                else if (strForm.LastIndexOf("_5") > 0)
                    frmType = Type.GetType("EfideFactoring." + strForm.Substring(0, strForm.LastIndexOf("_5")));
                else if (strForm.LastIndexOf("_6") > 0)
                    frmType = Type.GetType("EfideFactoring." + strForm.Substring(0, strForm.LastIndexOf("_6")));
                else
                    frmType = Type.GetType("EfideFactoring." + strForm);

                object frm = Activator.CreateInstance(frmType);
                switch (strForm)
                {
                    case "Formula.Reportes.frmRptCreditos": 
                        break;
                    case "Formula.Reportes.frmRptCobranza": 
                        break;
                    case "Formula.Registros.frmQryOperacionesProceso": 
                        Formula.Registros.frmQryOperacionesProceso ofrm1 = new Formula.Registros.frmQryOperacionesProceso(); 
                        ofrm1.Tipo = 1; 
                        ofrm1.MdiParent = this; 
                        frm = ofrm1;
                        break;
                    case "Formula.Registros.frmMntLote": 
                        Formula.Registros.frmMntLote ofrm2 = new Formula.Registros.frmMntLote();
                        ofrm2.Fase = "0";
                        ofrm2.MdiParent = this; 
                        frm = ofrm2;
                        break;
                    case "Formula.Registros.frmQryOperacionesProceso_1": 
                        Formula.Registros.frmQryOperacionesProceso ofrm3 = new Formula.Registros.frmQryOperacionesProceso();
                        ofrm3.Tipo = 2;
                        ofrm3.MdiParent = this;
                        frm = ofrm3;
                        break;
                    case "Formula.Renovacion.frmRenovacion_1":
                        Formula.Renovacion.frmRenovacion ofrm4 = new Formula.Renovacion.frmRenovacion();
                        ofrm4.FlgAsistente = 1;
                        ofrm4.MdiParent = this;
                        frm = ofrm4;
                        break;
                    case "Formula.Legal.frmMntSolicitud_1":
                        Formula.Legal.frmMntSolicitud ofrm5 = new Formula.Legal.frmMntSolicitud();
                        ofrm5.FlgLegal = 1;
                        ofrm5.MdiParent = this;
                        frm = ofrm5;
                        break;
                    case "Formula.Legal.frmQryBoveda":
                        Formula.Legal.frmQryBoveda ofrm6 = new Formula.Legal.frmQryBoveda();
                        ofrm6.Origen = 1;
                        ofrm6.MdiParent = this;
                        frm = ofrm6;
                        break;
                    case "Formula.Legal.frmQryBoveda_1":
                        Formula.Legal.frmQryBoveda ofrm7 = new Formula.Legal.frmQryBoveda();
                        ofrm7.Origen = 1;
                        ofrm7.MdiParent = this;
                        frm = ofrm7;
                        break;
                    case "Formula.GestionComercial.frmRpt_Tuberia":
                        Formula.GestionComercial.frmRpt_Tuberia ofrm8 = new Formula.GestionComercial.frmRpt_Tuberia();
                        ofrm8.TitleText = "REPORTE DE TUBERIA DE NUEVOS PROSPECTOS / RECUPERADOS";
                        ofrm8.lblTitulo.Text = "REPORTE DE TUBERIA DE NUEVOS PROSPECTOS / RECUPERADOS";
                        ofrm8.IdTipoGestor_tt = "00249";
                        ofrm8.MdiParent = this;
                        frm = ofrm8;
                        break;
                    case "Formula.GestionComercial.frmRpt_Tuberia_1":
                        Formula.GestionComercial.frmRpt_Tuberia ofrm9 = new Formula.GestionComercial.frmRpt_Tuberia();
                        ofrm9.TitleText = "REPORTE DE TUBERIA DE MANTENIMIENTO / RECUPERADOS";
                        ofrm9.lblTitulo.Text = "REPORTE DE TUBERIA DE MANTENIMIENTO / RECUPERADOS";
                        ofrm9.IdTipoGestor_tt = "00248";
                        ofrm9.MdiParent = this;
                        frm = ofrm9;
                        break;


                    case "Formula.GestionComercial.frmRpt_AvanceFecha_1":
                        Formula.GestionComercial.frmRpt_AvanceFecha ofrm10 = new Formula.GestionComercial.frmRpt_AvanceFecha();
                        ofrm10.Origen = 0;
                        ofrm10.MdiParent = this;
                        frm = ofrm10;
                        break;
                    case "Formula.GestionComercial.frmRpt_AvanceFecha_2":
                        Formula.GestionComercial.frmRpt_AvanceFecha ofrm11 = new Formula.GestionComercial.frmRpt_AvanceFecha();
                        ofrm11.Origen = 1;
                        ofrm11.MdiParent = this;
                        frm = ofrm11;
                        break;
                    case "Formula.GestionComercial.frmRpt_AvanceFecha_3":
                        Formula.GestionComercial.frmRpt_AvanceFecha ofrm12 = new Formula.GestionComercial.frmRpt_AvanceFecha();
                        ofrm12.Origen = 2;
                        ofrm12.MdiParent = this;
                        frm = ofrm12;
                        break;
                    case "Formula.GestionComercial.frmRpt_AvanceFecha_4":
                        Formula.GestionComercial.frmRpt_AvanceFecha ofrm13 = new Formula.GestionComercial.frmRpt_AvanceFecha();
                        ofrm13.Origen = 3;
                        ofrm13.MdiParent = this;
                        frm = ofrm13;
                        break;
                    case "Formula.GestionComercial.frmRpt_AvanceFecha_5":
                        Formula.GestionComercial.frmRpt_AvanceFecha ofrm14 = new Formula.GestionComercial.frmRpt_AvanceFecha();
                        ofrm14.Origen = 4;
                        ofrm14.MdiParent = this;
                        frm = ofrm14;
                        break;
                    case "Formula.GestionComercial.frmRpt_AvanceFecha_6":
                        Formula.GestionComercial.frmRpt_AvanceFecha ofrm15 = new Formula.GestionComercial.frmRpt_AvanceFecha();
                        ofrm15.Origen = 5;
                        ofrm15.MdiParent = this;
                        frm = ofrm15;
                        break;
                    case "Formula.Reportes.FrmRpt_FlujoCaja_1": // Reporte de Flujo de Caja en Soles
                        Formula.Reportes.FrmRpt_FlujoCaja ofrm16 = new Formula.Reportes.FrmRpt_FlujoCaja();
                        ofrm16.MdiParent = this;
                        frm = ofrm16;
                        break;
                    case "Formula.Reportes.FrmRpt_FlujoCaja_2": // Reporte de Flujo de Caja en Soles - SBS
                        Formula.Reportes.FrmRpt_FlujoCaja ofrm17 = new Formula.Reportes.FrmRpt_FlujoCaja();
                        ofrm17._FlgSBS = 1;
                        ofrm17.MdiParent = this;
                        frm = ofrm17;
                        break;
                    case "Formula.Reportes.FrmRpt_FlujoCajaDol_1": // Reporte de Flujo de Caja en Dolares
                        Formula.Reportes.FrmRpt_FlujoCajaDol ofrm18 = new Formula.Reportes.FrmRpt_FlujoCajaDol();
                        ofrm18.MdiParent = this;
                        frm = ofrm18;
                        break;
                    case "Formula.Reportes.FrmRpt_FlujoCajaDol_2": // Reporte de Flujo de Caja en Dolares - SBS
                        Formula.Reportes.FrmRpt_FlujoCajaDol ofrm19 = new Formula.Reportes.FrmRpt_FlujoCajaDol();
                        ofrm19._FlgSBS = 1;
                        ofrm19.MdiParent = this;
                        frm = ofrm19;
                        break;
                    case "Formula.Reportes.FrmRpt_FlujoCajaDiario_1":// Reporte de Flujo de Caja Soles Diario
                        Formula.Reportes.FrmRpt_FlujoCajaDiario ofrm20 = new Formula.Reportes.FrmRpt_FlujoCajaDiario();
                        ofrm20._ValorMonedaId = 1;
                        ofrm20.MdiParent = this;
                        frm = ofrm20;
                        break;
                    case "Formula.Reportes.FrmRpt_FlujoCajaDiario_2": // Reporte de Flujo de Caja Soles Diario - SBS
                        Formula.Reportes.FrmRpt_FlujoCajaDiario ofrm21 = new Formula.Reportes.FrmRpt_FlujoCajaDiario();
                        ofrm21._ValorMonedaId = 1;
                        ofrm21._FlgSBS = 1;
                        ofrm21.MdiParent = this;
                        frm = ofrm21;
                        break;
                    case "Formula.Reportes.FrmRpt_FlujoCajaDiario_3": // Reporte de Flujo de Caja Dolares Diario
                        Formula.Reportes.FrmRpt_FlujoCajaDiario ofrm22 = new Formula.Reportes.FrmRpt_FlujoCajaDiario();
                        ofrm22._ValorMonedaId = 2;
                        ofrm22.MdiParent = this;
                        frm = ofrm22;
                        break;
                    case "Formula.Reportes.FrmRpt_FlujoCajaDiario_4": // Reporte de Flujo de Caja Dolares Diario - SBS
                        Formula.Reportes.FrmRpt_FlujoCajaDiario ofrm23 = new Formula.Reportes.FrmRpt_FlujoCajaDiario();
                        ofrm23._ValorMonedaId = 2;
                        ofrm23._FlgSBS = 1;
                        ofrm23.MdiParent = this;
                        frm = ofrm23;
                        break;
                    case "Formula.Reportes.frmRpt_ConcentracionPasiva_1":
                        Formula.Reportes.frmRpt_ConcentracionPasiva ofrm24 = new Formula.Reportes.frmRpt_ConcentracionPasiva();
                        ofrm24._OpcionRpt = 1;
                        ofrm24.MdiParent = this;
                        frm = ofrm24;
                        break;      
                    case "Formula.Reportes.frmRpt_ConcentracionPasiva_2":
                        Formula.Reportes.frmRpt_ConcentracionPasiva ofrm25 = new Formula.Reportes.frmRpt_ConcentracionPasiva();
                        ofrm25._OpcionRpt = 1;
                        ofrm25.MdiParent = this;
                        frm = ofrm25;
                        break;

                    default: ((Form)frm).MdiParent = this;
                        break;
                }

                if (frmType != null)
                    frmType.InvokeMember("Show", System.Reflection.BindingFlags.InvokeMethod, null, frm, null);
	        }
	        catch (Exception ex)
	        {
                MessageBox.Show("Error al abrir el formulario, Error: " + ex.Message);
	        }
        }
        #endregion

        private void mnuCargaDatosTop10kLinea_Click(object sender, EventArgs e)
        {
            Formula.Top10K.frmCargaDatosTop10KLinea ofrm = new Formula.Top10K.frmCargaDatosTop10KLinea();
            ofrm.MdiParent = this;
            ofrm.Show();
        }

        private void mnuReporteFenacrep_Click(object sender, EventArgs e)
        {
            ProcessStartInfo info = new ProcessStartInfo();
            info.UseShellExecute = true;
            info.FileName = "Efide.Fenacrep.Winfenacrep.appref-ms";
            info.WorkingDirectory = @"\\EFIDESIS\tmp\publish\";
            info.Arguments = "HLOPEZ|123|2018/06/15";
            Process.Start(info);
        }

        private void legalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formula.Legal.frmMntSolicitud ofrm = new Formula.Legal.frmMntSolicitud();
            ofrm.MdiParent = this;
            ofrm.Show();
        }

        private void mnuRenovacionLetrasAsistente_Click(object sender, EventArgs e)
        {
            Formula.Renovacion.frmRenovacion ofrm = new Formula.Renovacion.frmRenovacion();
            ofrm.FlgAsistente = 1;
            ofrm.MdiParent = this;
            ofrm.Show();
        }

        private void mnuBloquearCXP_Click(object sender, EventArgs e)
        {
            Formula.Registros.frmMntCuentasxPagarTMBloqueo ofrm = new Formula.Registros.frmMntCuentasxPagarTMBloqueo();
            ofrm.MdiParent = this;
            ofrm.Show();
        }   

        private void solicitudLegalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formula.Legal.frmMntSolicitud ofrm = new Formula.Legal.frmMntSolicitud();
            ofrm.FlgLegal = 1;
            ofrm.MdiParent = this;
            ofrm.Show();
        }

        private void mnuSolicitud_Click(object sender, EventArgs e)
        {
            Formula.Legal.frmMntSolicitud ofrm = new Formula.Legal.frmMntSolicitud();
            ofrm.MdiParent = this;
            ofrm.Show();
        }   

        private void mnuGestionLegal_Click(object sender, EventArgs e)
        {
            Formula.Legal.frmMntSolicitud ofrm = new Formula.Legal.frmMntSolicitud();
            ofrm.FlgLegal = 1;
            ofrm.MdiParent = this;
            ofrm.Show();
        }

        private void mnuGestionNPO_Click(object sender, EventArgs e)
        {
            Formula.Legal.frmQryGestionNPO ofrm = new Formula.Legal.frmQryGestionNPO();
            ofrm.MdiParent = this;
            ofrm.Show();
        }

        private void configuraciónDeFormatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formula.Legal.frmMntTipoSolicitudFormato ofrm = new Formula.Legal.frmMntTipoSolicitudFormato();
            ofrm.MdiParent = this;
            ofrm.Show();
        }

        private void generarPagoProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProcessStartInfo info = new ProcessStartInfo();
            info.UseShellExecute = true;
            info.FileName = "Efide.Bancos.Telecredito.appref-ms";
            info.WorkingDirectory = @"\\EFIDESIS\tmp\publish\Pago_Proveedores\";
            //info.Arguments = "0010000000001CB|001000000630SD20180302,001000000641SD20180302";
            //info.Arguments = "0010000000001CB|001000000630SD20180302,001000000641SD20180302";
            info.Arguments = "0010000000040CB|001000000201SD20190528,001000006088SD20180622";
            Process.Start(info);
        }

        private void mnuRptControlDiario_Click(object sender, EventArgs e)
        {
            Formula.GestionComercial.frmRpt_ControlDiarioNuevos ofrm = new Formula.GestionComercial.frmRpt_ControlDiarioNuevos();
            ofrm.MdiParent = this;
            ofrm.Show();
        }

        private void mnuControlDiarioMnt_Click(object sender, EventArgs e)
        {
            Formula.GestionComercial.frmRpt_ControlDiarioMnt ofrm = new Formula.GestionComercial.frmRpt_ControlDiarioMnt();
            ofrm.MdiParent = this;
            ofrm.Show();
        }

        private void mnuBovedaEjecutivo_Click(object sender, EventArgs e)
        {
            Formula.Legal.frmQryBoveda ofrm = new Formula.Legal.frmQryBoveda();
            ofrm.TitleText = "Ejecutivo Legal";
            ofrm.Origen = 1;
            ofrm.MdiParent = this;
            ofrm.Show();
        }

        private void mnuBovedaCierre_Click(object sender, EventArgs e)
        {
            //Formula.Legal.frmMntBoveda ofrm = new Formula.Legal.frmMntBoveda();
            //ofrm.Origen = 0;
            //ofrm.MdiParent = this;
            //ofrm.Show();
        }

        private void mnuRptOperacionesNoRetornaronToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formula.Reportes.frmRpt_OperacionNoRetornaron ofrm = new Formula.Reportes.frmRpt_OperacionNoRetornaron();
            ofrm.MdiParent = this;
            ofrm.Show();
        }

        private void rptmnuEstadoResultados_Click(object sender, EventArgs e)
        {
            ProcessStartInfo info = new ProcessStartInfo();
            info.UseShellExecute = true;
            info.FileName = "Efide.Reportes.Contabilidad.appref-ms";
            info.WorkingDirectory = @"\\EFIDESIS\tmp\publish\ReportesContabilidad\";
            //info.Arguments = "HLOPEZ|123|2018/06/15";
            Process.Start(info);
        }

        private void reporteDeInventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProcessStartInfo info = new ProcessStartInfo();
            info.UseShellExecute = true;
            info.FileName = "Efide.Reportes.Inventario.appref-ms";
            info.WorkingDirectory = @"\\EFIDESIS\tmp\publish\ReportesInventario\";
            //info.Arguments = "HLOPEZ|123|2018/06/15";
            Process.Start(info);
        }

        private void asignaciónPagadoraEjecutivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formula.GestionPagadora.frmAsignarGestorPagadora ofrm = new Formula.GestionPagadora.frmAsignarGestorPagadora();
            ofrm.MdiParent = this;
            ofrm.Show();
        }

        private void gestiónPagadoraToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Formula.GestionPagadora.frmBitacoraPagadora ofrm = new Formula.GestionPagadora.frmBitacoraPagadora();
            ofrm.MdiParent = this;
            ofrm.Show();
        }

        private void mnuEmpresasTop10k_Click(object sender, EventArgs e)
        {
            Formula.Top10K.frmCargaDatosTop ofrm = new Formula.Top10K.frmCargaDatosTop();
            ofrm.MdiParent = this;
            ofrm.Show();
        }

        private void planillaEjecutivoTSM_Click(object sender, EventArgs e)
        {
            ProcessStartInfo info = new ProcessStartInfo();
            info.UseShellExecute = true;
            info.FileName = "EfideFactoringXML.appref-ms";
            info.WorkingDirectory = @"\\EFIDESIS\tmp\publish\RegistroPlanillaEjecutivoXML\";
            info.Arguments = General.General.GetUsuario.Trim() + "|" + General.General.gFechaOp.Date.ToString("d");
            Process.Start(info);
        }

        private void mnuTableroGestionN_Click(object sender, EventArgs e)
        {
            Formula.GestionComercial.frmRpt_TableroControlGestionNuevos ofrm = new Formula.GestionComercial.frmRpt_TableroControlGestionNuevos();
            ofrm.MdiParent = this;
            ofrm.Show();
        }

        private void mnuTableroGestionMnt_Click(object sender, EventArgs e)
        {
            Formula.GestionComercial.frmRpt_TableroControlGestionMnt ofrm = new Formula.GestionComercial.frmRpt_TableroControlGestionMnt();
            ofrm.MdiParent = this;
            ofrm.Show();
        }

        private void mnuRptTuberiaNuevos_Click(object sender, EventArgs e)
        {
            Formula.GestionComercial.frmRpt_Tuberia ofrm = new Formula.GestionComercial.frmRpt_Tuberia();
            ofrm.TitleText = "REPORTE DE TUBERIA DE NUEVOS PROSPECTOS / RECUPERADOS";
            ofrm.lblTitulo.Text = "REPORTE DE TUBERIA DE NUEVOS PROSPECTOS / RECUPERADOS";
            ofrm.IdTipoGestor_tt = "00249";
            ofrm.MdiParent = this;
            ofrm.Show();
        }

        private void mnuRpt_TuberiaMnt_Click(object sender, EventArgs e)
        {
            Formula.GestionComercial.frmRpt_Tuberia ofrm = new Formula.GestionComercial.frmRpt_Tuberia();
            ofrm.TitleText = "REPORTE DE TUBERIA DE MANTENIMIENTO / RECUPERADOS";
            ofrm.lblTitulo.Text = "REPORTE DE TUBERIA DE MANTENIMIENTO / RECUPERADOS";
            ofrm.IdTipoGestor_tt = "00248";
            ofrm.MdiParent = this;
            ofrm.Show();
        }

        private void gestionCobranzasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProcessStartInfo info = new ProcessStartInfo();
            info.UseShellExecute = true;
            info.FileName = "EfideGestion.Aplicacion.appref-ms";
            info.WorkingDirectory = @"\\EFIDESIS\tmp\publish\EfideGestion\";
            info.Arguments = General.General.GetUsuario.Trim() + "|" + General.General.gFechaOp.Date.ToString("d") + "|" + General.General.gSesionID;
            Process.Start(info);
        }

        private void reporteResumenGestiónNuevosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formula.GestionComercial.frmRpt_ResumenGestionNuevos ofrm = new Formula.GestionComercial.frmRpt_ResumenGestionNuevos();
            ofrm.MdiParent = this;
            ofrm.Show();
        }

        private void reporteResumenGestiónMantenimientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formula.GestionComercial.frmRpt_ResumenGestionMnt ofrm = new Formula.GestionComercial.frmRpt_ResumenGestionMnt();
            ofrm.MdiParent = this;
            ofrm.Show();
        }

        private void reporteDeSociosEnPeligroDeFugaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formula.GestionComercial.frmRpt_ListaSociosPeligroFuga ofrm = new Formula.GestionComercial.frmRpt_ListaSociosPeligroFuga();
            ofrm.MdiParent = this;
            ofrm.Show();
        }

        private void reporteDeSociosEnPeligroDeFugaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Formula.GestionComercial.frmRpt_ListaSociosPeligroFuga ofrm = new Formula.GestionComercial.frmRpt_ListaSociosPeligroFuga();
            ofrm.MdiParent = this;
            ofrm.Show();
        }

        private void mnuBovedaCobranzas_Click(object sender, EventArgs e)
        {
            //Formula.Legal.frmMntBoveda ofrm = new Formula.Legal.frmMntBoveda();
            //ofrm.Origen = 1;
            //ofrm.MdiParent = this;
            //ofrm.Show();
        }

        private void registroDeIngresoYSalidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formula.Legal.frmMntBoveda ofrm = new Formula.Legal.frmMntBoveda();
            ofrm.Origen = 0;
            ofrm.MdiParent = this;
            ofrm.Show();
        }

        private void bovedaCobranzasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formula.Legal.frmMntBoveda ofrm = new Formula.Legal.frmMntBoveda();
            ofrm.Origen = 1;
            ofrm.MdiParent = this;
            ofrm.Show();
        }

        private void reporteDeAvanceALaFechaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formula.GestionComercial.frmRpt_AvanceFecha ofrm = new Formula.GestionComercial.frmRpt_AvanceFecha();
            ofrm.Origen = 0;
            ofrm.MdiParent = this;
            ofrm.Show();
        }

        private void reporteAvanceGestiónNuevosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formula.GestionComercial.frmRpt_AvanceFecha ofrm = new Formula.GestionComercial.frmRpt_AvanceFecha();
            ofrm.Origen = 1;
            ofrm.MdiParent = this;
            ofrm.Show();
        }

        private void reporteAvanceGestiónGestorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formula.GestionComercial.frmRpt_AvanceFecha ofrm = new Formula.GestionComercial.frmRpt_AvanceFecha();
            ofrm.Origen = 2;
            ofrm.MdiParent = this;
            ofrm.Show();
        }

        private void reporteDeAnálisisMensualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formula.GestionComercial.frmRpt_AvanceFecha ofrm = new Formula.GestionComercial.frmRpt_AvanceFecha();
            ofrm.Origen = 3;
            ofrm.MdiParent = this;
            ofrm.Show();
        }

        private void reporteDeAvanceRendimientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formula.GestionComercial.frmRpt_AvanceFecha ofrm = new Formula.GestionComercial.frmRpt_AvanceFecha();
            ofrm.Origen = 4;
            ofrm.MdiParent = this;
            ofrm.Show();
        }

        private void reporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formula.GestionComercial.frmRpt_AvanceFecha ofrm = new Formula.GestionComercial.frmRpt_AvanceFecha();
            ofrm.Origen = 5;
            ofrm.MdiParent = this;
            ofrm.Show();
        }

        private void bancosOperacionesPorConfirmarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProcessStartInfo info = new ProcessStartInfo();
            info.UseShellExecute = true;
            info.FileName = "EfideResumenBanco.Aplicacion.appref-ms";
            info.WorkingDirectory = @"\\efidesis\EJECUTABLES_EFIDE\Aplicaciones\ResumenBanco\";
            //info.Arguments = General.General.GetUsuario.Trim() + "|" + General.General.gFechaOp.Date.ToString("d") + "|" + General.General.gSesionID;
            Process.Start(info);
        }

        private void simuladorDeCronogramaDPFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProcessStartInfo info;
            info = new ProcessStartInfo();
            info.UseShellExecute = true;
            info.FileName = "SimuladorCronograma.appref-ms";
            info.WorkingDirectory = @"\\EFIDESIS\tmp\publish\SimuladorCronograma\";
            info.Arguments = "frmSimuladorDpf" + "|" + General.General.GetUsuario.Trim();
            Process.Start(info);
        }

        private void simuladorDeCronogramaPréstamoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProcessStartInfo info;
            info = new ProcessStartInfo();
            info.UseShellExecute = true;
            info.FileName = "SimuladorCronograma.appref-ms";
            info.WorkingDirectory = @"\\EFIDESIS\tmp\publish\SimuladorCronograma\";
            info.Arguments = "frmSimuladorPrestamo" + "|" + General.General.GetUsuario.Trim();
            Process.Start(info);
        }

        private void simuladorDeCronogramaDPFToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ProcessStartInfo info;
            info = new ProcessStartInfo();
            info.UseShellExecute = true;
            info.FileName = "SimuladorCronograma.appref-ms";
            info.WorkingDirectory = @"\\EFIDESIS\tmp\publish\SimuladorCronograma\";
            info.Arguments = "frmSimuladorBTB" + "|" + General.General.GetUsuario.Trim();
            Process.Start(info);
        }

        private void adeudosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProcessStartInfo info;
            info = new ProcessStartInfo();
            info.UseShellExecute = true;
            info.FileName = "Efide.Tesoreria.WinAdeudos.appref-ms";
            info.WorkingDirectory = @"\\EFIDESIS\tmp\publish\Adeudos\";
            info.Arguments = General.General.GetUsuario.Trim() + "|" + General.General.gFechaOp.Date.ToString("d");
            Process.Start(info);
        }

        private void inversionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProcessStartInfo info;
            info = new ProcessStartInfo();
            info.UseShellExecute = true;
            info.FileName = "Efide.Tesoreria.WinAdeudosInversiones.appref-ms";
            info.WorkingDirectory = @"\\EFIDESIS\tmp\publish\Inversiones\";
            info.Arguments = General.General.GetUsuario.Trim() + "|" + General.General.gFechaOp.Date.ToString("d");
            Process.Start(info);
        }

        private void mnuMovimientoLineas_Click(object sender, EventArgs e)
        {
            Formula.Reportes.frmRpt_MovimientoLinea ofrm = new Formula.Reportes.frmRpt_MovimientoLinea();
            ofrm.MdiParent = this;
            ofrm.Show();
        }


        private void mnuIngresosRetirosSocios_Click(object sender, EventArgs e)
        {
            Formula.Reportes.frmRpt_SocioEstado ofrm = new Formula.Reportes.frmRpt_SocioEstado();
            ofrm.MdiParent = this;
            ofrm.Show();
        }

        private void mnuAportacionesOrdinarias_Click(object sender, EventArgs e)
        {
            Formula.Reportes.frmRpt_AportacionOrdinaria ofrm = new Formula.Reportes.frmRpt_AportacionOrdinaria();
            ofrm.MdiParent = this;
            ofrm.Show();
        }

        private void mnuCargaMasivaProspectosPag_Click(object sender, EventArgs e)
        {
            Formula.GestionComercial.frmCarteraCandidatoCarga ofrm = new Formula.GestionComercial.frmCarteraCandidatoCarga();
            ofrm._FlgPagadora = 1;
            ofrm.MdiParent = this;
            ofrm.Show();
        }

        private void mnuMntProspectos_Click(object sender, EventArgs e)
        {
            Formula.GestionComercial.frmCarteraCandidato ofrm = new Formula.GestionComercial.frmCarteraCandidato();
            ofrm._FlgPagadora = 1;
            ofrm.MdiParent = this;
            ofrm.Show();
        }

        private void reporteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Formula.Reportes.frmRpt_DesMensualEjecutivo ofrm = new Formula.Reportes.frmRpt_DesMensualEjecutivo();
            ofrm.MdiParent = this;
            ofrm.Show();
        }

        private void mnuEstadoCuenta_Click(object sender, EventArgs e)
        {
            Formula.Catalogo.frmMntSocioConfiguracionEC ofrm = new Formula.Catalogo.frmMntSocioConfiguracionEC();
            ofrm.MdiParent = this;
            ofrm.Show();
        }

        private void reporteDeFlujoDeCajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formula.Reportes.FrmRpt_FlujoCaja ofrm = new Formula.Reportes.FrmRpt_FlujoCaja();
            ofrm.MdiParent = this;
            ofrm.Show();
        }

        private void reporteDeFlujoDeCajaEnDolaresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formula.Reportes.FrmRpt_FlujoCajaDol ofrm = new Formula.Reportes.FrmRpt_FlujoCajaDol();
            ofrm.MdiParent = this;
            ofrm.Show();
        }

        private void reporteDeFlujoDeCajaSolesDiarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formula.Reportes.FrmRpt_FlujoCajaDiario ofrm = new Formula.Reportes.FrmRpt_FlujoCajaDiario();
            ofrm.MdiParent = this;
            ofrm._ValorMonedaId = 1;
            ofrm.Show();
        }

        private void reporteDeFlujoDeCajaDolaresDiarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formula.Reportes.FrmRpt_FlujoCajaDiario ofrm = new Formula.Reportes.FrmRpt_FlujoCajaDiario();
            ofrm.MdiParent = this;
            ofrm._ValorMonedaId = 2;
            ofrm.Show();
        }

        private void requerimientoDeGestiónComercialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formula.GestionComercial.frmRptGestionRequerimiento ofrm = new Formula.GestionComercial.frmRptGestionRequerimiento();
            ofrm.MdiParent = this;
            ofrm.Show();
        }

        private void rptConcentracionPasiva_Click(object sender, EventArgs e)
        {
            Formula.Reportes.frmRpt_ConcentracionPasiva ofrm = new Formula.Reportes.frmRpt_ConcentracionPasiva();
            ofrm.MdiParent = this;
            ofrm._OpcionRpt = 1;
            ofrm.Show();
        }

        private void reporteDeConcentraciónPasivaSBSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formula.Reportes.frmRpt_ConcentracionPasiva ofrm = new Formula.Reportes.frmRpt_ConcentracionPasiva();
            ofrm.MdiParent = this;
            ofrm._OpcionRpt = 2;
            ofrm.Show();
        }

        private void riesgoUnicoSocioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formula.Catalogo.frmMntSocioGrupo ofrm = new Formula.Catalogo.frmMntSocioGrupo();
            ofrm.MdiParent = this;
            ofrm.Show();
        }

        private void reporteControlCreditosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formula.Reportes.frmRpt_ControlCreditos ofrm = new Formula.Reportes.frmRpt_ControlCreditos();
            ofrm.MdiParent = this;
            ofrm.Show();
        }

        private void reporteRatioDeLiquidezToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formula.Reportes.frmRpt_RatioLiquidez ofrm = new Formula.Reportes.frmRpt_RatioLiquidez();
            ofrm.MdiParent = this;
            ofrm.Show();
        }

        private void reporteDeFlujoDeCajaEnSolesSBSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formula.Reportes.FrmRpt_FlujoCaja ofrm = new Formula.Reportes.FrmRpt_FlujoCaja();
            ofrm.MdiParent = this;
            ofrm._FlgSBS = 1;
            ofrm.Show();
        }

        private void reporteDeFlujoDeCajaEnDolaresToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Formula.Reportes.FrmRpt_FlujoCajaDol ofrm = new Formula.Reportes.FrmRpt_FlujoCajaDol();
            ofrm.MdiParent = this;
            ofrm._FlgSBS = 1;
            ofrm.Show();
        }

        private void reporteDeFlujoDeCajaSolesDiarioSBSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formula.Reportes.FrmRpt_FlujoCajaDiario ofrm = new Formula.Reportes.FrmRpt_FlujoCajaDiario();
            ofrm.MdiParent = this;
            ofrm._ValorMonedaId = 1;
            ofrm._FlgSBS = 1;
            ofrm.Show();
        }

        private void reporteDeFlujoDeCajaDolaresDiarioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Formula.Reportes.FrmRpt_FlujoCajaDiario ofrm = new Formula.Reportes.FrmRpt_FlujoCajaDiario();
            ofrm.MdiParent = this;
            ofrm._ValorMonedaId = 2;
            ofrm._FlgSBS = 1;
            ofrm.Show();
        }

        private void búsquedaTransDeposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProcessStartInfo info;
            info = new ProcessStartInfo();
            info.UseShellExecute = true;
            info.FileName = "Efide.WinApplication.appref-ms";
            info.WorkingDirectory = @"\\EFIDESIS\tmp\publish\Consultas\";
            info.Arguments = "frmBusquedaTransfDepo";
            Process.Start(info);
        }

        private void reporteDepositosAPlazoFijoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formula.Reportes.frmRpt_DPF ofrm = new Formula.Reportes.frmRpt_DPF();
            ofrm.MdiParent = this;
            ofrm.Show();
        }

        private void reporteDepositosAPlazoFijoSociosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formula.Reportes.frmRpt_DPF_Socio ofrm = new Formula.Reportes.frmRpt_DPF_Socio();
            ofrm.MdiParent = this;
            ofrm.Show();
        }

        private void reporteSUNATToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formula.Reportes.frmRpt_SunatAnexos ofrm = new Formula.Reportes.frmRpt_SunatAnexos();
            ofrm.MdiParent = this;
            ofrm.Show();
        }

        private void mantenimientoDeBaseNegativaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formula.Cobranza.frmMntBaseNegativa ofrm = new Formula.Cobranza.frmMntBaseNegativa();
            ofrm.MdiParent = this;
            ofrm.Show();
        }

        private void reporteAhorrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formula.Reportes.frmRpt_Ahorros ofrm = new Formula.Reportes.frmRpt_Ahorros();
            ofrm.MdiParent = this;
            ofrm.Show();
        }

        private void magnitudPersonaEmpresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formula.Catalogo.frmMntMagnitud ofrm  = new Formula.Catalogo.frmMntMagnitud();
            ofrm.MdiParent = this;
            ofrm.Show();
        }
    }
}