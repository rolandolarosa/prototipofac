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
using System.Diagnostics;

namespace EfideFactoring.Formula.GestionPagadora
{
    public partial class frmGestionPagadoraDetalle : FormulaBase.frmMntDato
    {
        public string _IdPagadoraDsc = string.Empty;
        public string _IdGestor = string.Empty;
        public string _NombreGestor = string.Empty;
        public frmGestionPagadoraDetalle()
        {
            InitializeComponent();
        }

        private void frmGestionPagadoraDetalle_Load(object sender, EventArgs e)
        {
            try
            {
                LlenarCombos();
                CargaDatos();
                CargarPndCobro();
                CargarRecordTop();
                CargarBitacoraComercial();
                CargarBitacoraCobranza();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LlenarCombos()
        {
            try
            {
                String Table_Id = "01014"; //Tipo Origen
                TableBaseBE TableBaseBE = new TableBaseBE()
                {
                    OPCION = 1,
                    USUARIO = General.General.GetCodigoUsuario,
                    Table_Parent_Id = Table_Id
                };

                DataTable dt = new TableBaseBL().ProcesarTableBase(TableBaseBE).Tables[0];
                cboIdOrigenBitacora_tt.DataSource = dt;
                cboIdOrigenBitacora_tt.DisplayMember = "Table_Name";
                cboIdOrigenBitacora_tt.ValueMember = "Table_Id";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargaDatos()
        {
            try
            {
                GestionPagadoraBE IEntity = new GestionPagadoraBE();
                IEntity.OPCION = 1;
                IEntity.IdPagadora = Codigo;
                DataSet ds = new GestionPagadoraBL().ProcesarGestionPagadora(IEntity);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    txtvcRuc.Text = ds.Tables[0].Rows[0]["vcRuc"].ToString();
                    txtvcPagadora.Text = ds.Tables[0].Rows[0]["vcPagadora"].ToString();
                    txtvTipoEmpresa.Text = ds.Tables[0].Rows[0]["vTipoEmpresa"].ToString();
                    txtvPagWeb.Text = ds.Tables[0].Rows[0]["vPagWeb"].ToString();
                    txtIdSector_tt_Dsc.Text = ds.Tables[0].Rows[0]["IdSector_tt_Dsc"].ToString();
                    txtPorcjSector.Text = ds.Tables[0].Rows[0]["PorcjSector"].ToString();
                    txtPorcjCartera.Text = ds.Tables[0].Rows[0]["PorcjCartera"].ToString();
                    txtvFacebook.Text = ds.Tables[0].Rows[0]["vFacebook"].ToString();
                    txtvTwitter.Text = ds.Tables[0].Rows[0]["vTwitter"].ToString();
                    txtnLinea.Text = Convert.ToDecimal(ds.Tables[0].Rows[0]["nLinea"].ToString()).ToString("N2");
                    txtnSaldo.Text = Convert.ToDecimal(ds.Tables[0].Rows[0]["nSaldo"].ToString()).ToString("N2");
                    txtnUtilizado.Text = Convert.ToDecimal(ds.Tables[0].Rows[0]["nUtilizado"].ToString()).ToString("N2");
                    txtPorcjUso.Text = Convert.ToDecimal(ds.Tables[0].Rows[0]["PorcjUso"].ToString()).ToString("N");
                    txtUltActivacion.Text = ds.Tables[0].Rows[0]["UltActivacion"].ToString();
                    txtIdEstadoLinea_tt_Dsc.Text = ds.Tables[0].Rows[0]["IdEstadoLinea_tt_Dsc"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarPndCobro()
        {
            try
            {
                GestionPagadoraBE IEntity = new GestionPagadoraBE();
                IEntity.OPCION = 3;
                IEntity.IdPagadora = Codigo;
                DataSet ds = new GestionPagadoraBL().ProcesarGestionPagadora(IEntity);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    dgvPendienteCobro.DataSource = ds.Tables[0];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void CargarBitacoraComercial()
        {
            try
            {
                DataSet dsBitacoraComercial = new DataSet();
                BitacoraComercialBE BitacoraComercialBE = new BitacoraComercialBE()
                {
                    OPCION = 1,
                    USUARIO = General.General.GetUsuario,
                    IdSocio = Codigo,
                    IdGestor = _IdGestor,
                };

                dsBitacoraComercial = new BitacoraComercialBL().ProcesarBitacoraComercial(BitacoraComercialBE);
                dgvBitacoraComercial.DataSource = dsBitacoraComercial.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarBitacoraCobranza()
        {
            try
            {
                DataSet dsBitacora = new DataSet();
                BitacoraCobranzaInputBE IEntity = new BitacoraCobranzaInputBE()
                {
                    OPCION = 1,
                    USUARIO = General.General.GetUsuario,
                    IdEntidad = Codigo,
                    IdGestor = _IdGestor,
                    IdOrigenBitacora_tt = cboIdOrigenBitacora_tt.SelectedValue.ToString()
                };

                dsBitacora = new BitacoraCobranzaBL().ProcesarBitacoraCobranza(IEntity);
                dgvBitacoraCobranza.DataSource = dsBitacora.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarRecordTop()
        {
            try
            {
                GestionPagadoraBE IEntity = new GestionPagadoraBE();
                IEntity.OPCION = 4;
                IEntity.IdPagadora = Codigo;
                DataSet ds = new GestionPagadoraBL().ProcesarGestionPagadora(IEntity);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    dgvRecordTop.DataSource = ds.Tables[0];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEstadisticaPagadora_Click(object sender, EventArgs e)
        {
            try
            {
                //Formula.GestionComercial.frmEstadisticaPagadora ofrm = new Formula.GestionComercial.frmEstadisticaPagadora();
                //ofrm._IdPagadora = Codigo;
                //ofrm._IdSocio = Codigo.Trim();
                //ofrm._IdPagadora_Dsc = _IdPagadoraDsc;
                //ofrm.ShowDialog();

                ProcessStartInfo info = new ProcessStartInfo();
                info.UseShellExecute = true;
                info.FileName = "ReporteInformeRendimiento.xlsm";
                info.WorkingDirectory = @"\\EFIDESIS\tmp\publish\ReportesCobranza\";
                Process.Start(info);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVerDatos_Click(object sender, EventArgs e)
        {
            try
            {
                Formula.Catalogo.frmMntPagadoraDato ofrm = new Formula.Catalogo.frmMntPagadoraDato();
                ofrm.Codigo = Codigo;
                ofrm.Operacion = "C";
                ofrm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCarteraSector_Click(object sender, EventArgs e)
        {
            try
            {
                frmAnalisisSector ofrm = new frmAnalisisSector();
                ofrm.ShowDialog();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btnSunat_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://e-consultaruc.sunat.gob.pe/cl-ti-itmrconsruc/jcrS00Alias");
        }

        private void btnSentinel_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.sentinelperu.com/cliente/sentinel.aspx");
        }

        private void btnSolicitudIncrLRiesgos_Click(object sender, EventArgs e)
        {

        }

        private void btnSolicitudLegal_Click(object sender, EventArgs e)
        {
            try
            {
                Formula.Legal.frmMntSolicitudDato ofrm = new Formula.Legal.frmMntSolicitudDato();
                ofrm.Operacion = "N";
                ofrm._IdSocio = Codigo;
                ofrm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            try
            {
                EfideFactoring.Formula.Consulta.frmConSaldoSocio3 ofrmConSaldoSocio3 = new EfideFactoring.Formula.Consulta.frmConSaldoSocio3();
                ofrmConSaldoSocio3.Text = "Consulta de Saldos por Pagadora";
                ofrmConSaldoSocio3.oIdSocio = "";
                ofrmConSaldoSocio3.oIdPagadora = Codigo;
                ofrmConSaldoSocio3.oPagadora = _IdPagadoraDsc;
                ofrmConSaldoSocio3._LineaSaldo = 0; /*COMPLETAR INFORMACION*/
                ofrmConSaldoSocio3._TipoCambio = 0; /*COMPLETAR INFORMACION*/
                ofrmConSaldoSocio3.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCompromisos_Click(object sender, EventArgs e)
        {
            try
            {
                //EfideGestion.Aplicacion.Formula.GestionCobranza.frmBitacoraCobranzaDato ofrm = new EfideGestion.Aplicacion.Formula.GestionCobranza.frmBitacoraCobranzaDato();
                //ofrm._IdEntidad = Codigo;
                //ofrm._IdEntidadDsc = txtvcPagadora.Text;
                //ofrm._FlgOrigen = 2;
                //ofrm._FlgCompromiso = 1;
                //ofrm._IdGestor = string.Empty;
                //ofrm._NombreGestor = string.Empty;
                //ofrm.ShowDialog();
                //CargarBitacoraCobranza();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnInformeRiesgos_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregarBitacoraComercial_Click(object sender, EventArgs e)
        {
            try
            {
                EfideFactoring.Formula.GestionComercial.frmMntBitacoraComercialDato frm = new EfideFactoring.Formula.GestionComercial.frmMntBitacoraComercialDato();
                frm.Operacion = "N";
                frm._IdSocio = Codigo;
                frm._NombreSocio = _IdPagadoraDsc;
                frm._IdGestor = _IdGestor;
                frm._NombreGestor = _NombreGestor;
                frm._FlgOrigen = 0;
                frm._FlgBitacoraComercial = 0;
                frm.ShowDialog();
                CargarBitacoraComercial();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvPendienteCobro_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                 DataGridViewRow row = dgvPendienteCobro.Rows[e.RowIndex];// get you required index
                // check the cell value under your specific column and then you can toggle your colors

                 if (dgvPendienteCobro.Rows[e.RowIndex].Cells["Rango"].Value.ToString().Equals("TOTALES S/."))
                 {
                     row.DefaultCellStyle.ForeColor = Color.Black;
                     row.DefaultCellStyle.BackColor = Color.Orange;
                 }
                //row.DefaultCellStyle.ForeColor = Color.FromName(row.Cells["ColorRow"].Value.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnInactivos_Click(object sender, EventArgs e)
        {
            try
            {
                frmQrySociosInactivos ofrm = new frmQrySociosInactivos();
                ofrm.Codigo = Codigo;
                ofrm._IdPagadora_Dsc = txtvcPagadora.Text;
                ofrm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboIdOrigenBitacora_tt_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                CargarBitacoraCobranza();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLineaPagadora_Click(object sender, EventArgs e)
        {
            try
            {
                Formula.Consulta.frmConSaldoPagador ofrm = new Consulta.frmConSaldoPagador();
                ofrm.txtCodigo.Text = Codigo;
                ofrm.txtPagadora.Text = txtvcPagadora.Text;
                ofrm.btnBuscar.PerformClick();
                ofrm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}