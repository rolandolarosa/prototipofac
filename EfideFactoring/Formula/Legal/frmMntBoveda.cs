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
using System.Configuration;
using System.Diagnostics;

namespace EfideFactoring.Formula.Legal
{
    public partial class frmMntBoveda : FormulaBase.frmMntFiltro
    {
        public int Origen = 0;
        public frmMntBoveda()
        {
            InitializeComponent();
        }

        private void frmMntBoveda_Load(object sender, EventArgs e)
        {
            try
            {
                CargarDatos();

                if (Origen == 0)
                {
                    dgvBoveda.Columns["dtRecepcionCobr"].Visible = false;
                    dgvBoveda.Columns["UsuarioRecepcionCobr"].Visible = false;
                    dgvBoveda.Columns["btnConfirmarIngresoCobranza"].Visible = false;
                    dgvBoveda.Columns["btnEnviarBoveda"].Visible = false;
                }
                else
                {
                    dgvBoveda.Columns["dtCierreBoveda"].Visible = false;
                    dgvBoveda.Columns["vUCierreBoveda"].Visible = false;
                    dgvBoveda.Columns["btnConfirmarRecepcion"].Visible = false;
                    dgvBoveda.Columns["btnEnviarACobranzas"].Visible = false;
                    chkVerHistoricos.Visible = false;
                    btnEditar.Visible = false;
                    btnEliminar.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                CargarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarDatos()
        {
            try
            {
                BovedaBE oEntity = new BovedaBE();
                oEntity.OPCION = Origen == 0 ? 7 : 8;
                oEntity.USUARIO = General.General.GetCodigoUsuario;
                oEntity.vRazonSocialSocio = TextBoxX1.Text;
                oEntity.FlgVerHistoricos = chkVerHistoricos.Checked ? 1 : 0;
                oEntity.IdEstado_tt = "00398";
                DataSet ds = new BovedaBL().ProcesarBoveda(oEntity);
                dgvBoveda.DataSource = ds.Tables[0];

                lblRegistros.Text = ds.Tables[0].Rows.Count + " registro(s)";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
         
        private void dgvBoveda_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex < 0) return;
                if (e.RowIndex == -1) return;

                if (dgvBoveda.Columns[e.ColumnIndex].Name.Equals("btnConfirmarRecepcion")) 
                {
                    if (dgvBoveda.CurrentRow.Cells["IdEstado_tt"].Value.ToString().Equals("00398")) // Enviado a Boveda
                    {
                        DialogResult dialogResult = 0;
                        dialogResult = MessageBox.Show("Seguro de confirmar la recepción del documento a Boveda: " + dgvBoveda.CurrentRow.Cells["IdBoveda"].Value.ToString().Trim(), "Confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dialogResult == DialogResult.Yes)
                        {
                            BovedaDetalleBE oEntity = new BovedaDetalleBE();
                            oEntity.OPCION = 5;
                            oEntity.IdBoveda = dgvBoveda.CurrentRow.Cells["IdBoveda"].Value.ToString();
                            oEntity.IdFormatoDocLegal_tt = dgvBoveda.CurrentRow.Cells["IdFormatoDocLegal_tt"].Value.ToString();
                            oEntity.FechaPago = !string.IsNullOrEmpty(dgvBoveda.CurrentRow.Cells["FechaPago"].Value.ToString()) ? Convert.ToDateTime(dgvBoveda.CurrentRow.Cells["FechaPago"].Value.ToString()) : DateTime.MinValue;
                            oEntity.ImportePago = !string.IsNullOrEmpty(dgvBoveda.CurrentRow.Cells["ImportePago"].Value.ToString()) ? Convert.ToDecimal(dgvBoveda.CurrentRow.Cells["ImportePago"].Value.ToString()) : 0;
                            oEntity.USUARIO = General.General.GetCodigoUsuario;
                            new BovedaDetalleBL().ProcesarBovedaDetalle(oEntity);
                            MessageBox.Show("Se Proceso Correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            CargarDatos();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Solo se puede confirmar la recepción cuando esté enviado a Boveda, verifique por favor", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                if (dgvBoveda.Columns[e.ColumnIndex].Name.Equals("btnEnviarACobranzas")) 
                {
                    if (dgvBoveda.CurrentRow.Cells["IdEstado_tt"].Value.ToString().Equals("01160")) // Solicitado por Cobranzas
                    {
                        DialogResult dialogResult = 0;
                        dialogResult = MessageBox.Show("Seguro de enviar a Cobranzas: " + dgvBoveda.CurrentRow.Cells["IdBoveda"].Value.ToString().Trim(), "Confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dialogResult == DialogResult.Yes)
                        {
                            BovedaDetalleBE oEntity = new BovedaDetalleBE();
                            oEntity.OPCION = 7;
                            oEntity.IdBoveda = dgvBoveda.CurrentRow.Cells["IdBoveda"].Value.ToString();
                            oEntity.IdFormatoDocLegal_tt = dgvBoveda.CurrentRow.Cells["IdFormatoDocLegal_tt"].Value.ToString();
                            oEntity.USUARIO = General.General.GetCodigoUsuario;
                            new BovedaDetalleBL().ProcesarBovedaDetalle(oEntity);
                            MessageBox.Show("Se Proceso Correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            CargarDatos();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Solo se puede enviar a cobranzas cuando exista una solicitud, verifique por favor", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                if (dgvBoveda.Columns[e.ColumnIndex].Name.Equals("btnConfirmarIngresoCobranza"))
                {
                    if (dgvBoveda.CurrentRow.Cells["IdEstado_tt"].Value.ToString().Equals("01161")) // Enviado a Cobranzas
                    {
                        DialogResult dialogResult = 0;
                        dialogResult = MessageBox.Show("¿Seguro de confirmar el ingreso a Cobranzas: " + dgvBoveda.CurrentRow.Cells["IdBoveda"].Value.ToString().Trim() + "?", "Confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dialogResult == DialogResult.Yes)
                        {
                            BovedaDetalleBE oEntity = new BovedaDetalleBE();
                            oEntity.OPCION = 6;
                            oEntity.IdBoveda = dgvBoveda.CurrentRow.Cells["IdBoveda"].Value.ToString();
                            oEntity.IdFormatoDocLegal_tt = dgvBoveda.CurrentRow.Cells["IdFormatoDocLegal_tt"].Value.ToString();
                            oEntity.USUARIO = General.General.GetCodigoUsuario;
                            new BovedaDetalleBL().ProcesarBovedaDetalle(oEntity);
                            MessageBox.Show("Se Proceso Correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            CargarDatos();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Solo se confirmar el ingreso a cobranzas cuando el documento se haya enviado por boveda, verifique por favor", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                if (dgvBoveda.Columns[e.ColumnIndex].Name.Equals("btnEnviarBoveda"))
                {
                    if (dgvBoveda.CurrentRow.Cells["IdEstado_tt"].Value.ToString().Equals("01162")) // En Cobranzas
                    {
                        DialogResult dialogResult = 0;
                        dialogResult = MessageBox.Show("Seguro de enviar a boveda el documento: " + dgvBoveda.CurrentRow.Cells["IdBoveda"].Value.ToString().Trim(), "Confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dialogResult == DialogResult.Yes)
                        {
                            BovedaDetalleBE oEntity = new BovedaDetalleBE();
                            oEntity.OPCION = 9;
                            oEntity.IdBoveda = dgvBoveda.CurrentRow.Cells["IdBoveda"].Value.ToString();
                            oEntity.IdFormatoDocLegal_tt = dgvBoveda.CurrentRow.Cells["IdFormatoDocLegal_tt"].Value.ToString();
                            oEntity.USUARIO = General.General.GetCodigoUsuario;
                            new BovedaDetalleBL().ProcesarBovedaDetalle(oEntity);
                            MessageBox.Show("Se Proceso Correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            CargarDatos();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Solo se confirmar el ingreso a cobranzas cuando el documento se haya enviado por boveda, verifique por favor", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                if (dgvBoveda.Columns[e.ColumnIndex].Name.Equals("btnVer"))
                {
                    if (!string.IsNullOrEmpty(dgvBoveda.CurrentRow.Cells["vArchivoAdjunto"].Value.ToString()))
                    {
                        string filepath = ConfigurationManager.AppSettings["RutaImageFisical"].ToString() + "//LegalSistemas//Boveda//" + dgvBoveda.CurrentRow.Cells["IdBoveda"].Value.ToString() + "//" + dgvBoveda.CurrentRow.Cells["vArchivoAdjunto"].Value.ToString();
                        Process.Start(filepath);
                    }
                }

                if (dgvBoveda.Columns[e.ColumnIndex].Name.Equals("btnTracking"))
                {
                    frmQryBovedaTracking ofrm = new frmQryBovedaTracking();
                    ofrm.Codigo = dgvBoveda.CurrentRow.Cells["IdBoveda"].Value.ToString();
                    ofrm._IdFormatoDocLegal_tt = dgvBoveda.CurrentRow.Cells["IdFormatoDocLegal_tt"].Value.ToString();
                    ofrm.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvBoveda.Rows.Count == 0) return;

                DialogResult dialogResult = 0;
                dialogResult = MessageBox.Show("¿Seguro de extornar el documento seleccionado : " + dgvBoveda.CurrentRow.Cells["IdBoveda"].Value.ToString().Trim() + "?", "Confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    frmMntBovedaComentario ofrm = new frmMntBovedaComentario();
                    ofrm.IdBoveda = dgvBoveda.CurrentRow.Cells["IdBoveda"].Value.ToString();
                    ofrm.IdFormatoDocLegal_tt = dgvBoveda.CurrentRow.Cells["IdFormatoDocLegal_tt"].Value.ToString();
                    ofrm.ShowDialog();
                    CargarDatos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}