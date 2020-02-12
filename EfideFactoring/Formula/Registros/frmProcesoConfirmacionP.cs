using DevComponents.DotNetBar;
using EfideFactoringBE;
using EfideFactoringBL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;

namespace EfideFactoring.Formula.Registros
{
    public partial class frmProcesoConfirmacionP : FormulaBase.frmMntFiltro
    {
        private DataTable dt;
        public frmProcesoConfirmacionP()
        {
            InitializeComponent();
        }

        private void frmProcesoConfirmacionP_Load(object sender, EventArgs e)
        {
            try
            {
                rbtnPEnviaronConfirmacion.Checked = true;
                EvaluarRbtn();
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
                DataSet ds = new DataSet();
                LoteBE LoteBE = new LoteBE()
                {
                    OPCION = 24,
                    USUARIO = General.General.GetUsuario,
                    IdSocio_Dsc = TextBoxX1.Text.Trim(),
                    IdPagadora_Dsc = txtIdPagadora_Dsc.Text.Trim(),
                    sdDesembolso = rbtnConfirmados.Checked ? dtDesembolsoInicio.Value : DateTime.MinValue,
                    sdAprobacion = rbtnConfirmados.Checked ? dtDesembolsoFin.Value : DateTime.MinValue,
                    FlgEntregado = rbtnPEnviaronConfirmacion.Checked ? "1" : string.Empty,
                    FlgConfimado = rbtnPendienteConfirmarPagadora.Checked ? "1" : string.Empty,
                    FlgPendiente = rbtnConfirmados.Checked ? "1" : string.Empty,
                };

                ds = new LoteBL().ProcesarLote(LoteBE);
                dt = ds.Tables[0];
                dgvLote.DataSource = ds.Tables[0];
                lblRegistros.Text = ds.Tables[0].Rows.Count.ToString() + " registro(s)";

                this.dgvLote.Columns["IdOperacion_tt_Dsc"].Width = 60;
                this.dgvLote.Columns["IdFormaDesembolso_tt_Dsc"].Width = 60;

                this.dgvLote.Columns["sdDesembolso"].Width = 80;
                this.dgvLote.Columns["dtConfirmado"].Width = 80;
                this.dgvLote.Columns["dtEnvioCorreo"].Width = 80;
                FormatoGrid();

                //IdLote
                //IdSocio_Dsc
                //IdPagadora_Dsc
                //IdDocumento_Dsc
                //IdOperacion_tt_Dsc
                //IdFormaDesembolso_tt_Dsc
                //sdDesembolso
                //dtConfirmado
                //UsuarioConfirmado
                //dtEnvioCorreo
                //UsuarioEnvioCorreo
                //IdEstado_tt_Dsc




            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEntregar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = 0;
            try
            {
                List<LoteBE> LstLote = new List<LoteBE>();
                if (dgvLote.RowCount > 0)
                {
                    foreach (DataGridViewRow row in dgvLote.Rows)
                    {
                        DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells["CheckSel"];
                        if (chk.Value.ToString() == "1")
                        {
                            LoteBE IEntity = new LoteBE()
                            {
                                OPCION = 25,
                                USUARIO = General.General.GetUsuario,
                                IdLote = row.Cells["IdLote"].Value.ToString(),
                                cItem = row.Cells["cItem"].Value.ToString(),
                            };
                            LstLote.Add(IEntity);
                        }
                    }

                    if (LstLote.Count == 0)
                    {
                        MessageBox.Show("Debe seleccionar al menos un registro para el envío de confirmación.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }

                    List<string> LstLoteDistinct = LstLote.Select(x => x.IdLote).Distinct().ToList();
                    List<LoteBE> LstLoteEnvio = new List<LoteBE>();

                    foreach (string item in LstLoteDistinct)
                    {
                        LoteBE IEntity = new LoteBE()
                        {
                            OPCION = 25,
                            USUARIO = General.General.GetUsuario,
                            IdLote = item
                        };
                        LstLoteEnvio.Add(IEntity);
                    }

                    dialogResult = MessageBox.Show("¿Seguro de enviar la confirmación de los registros seleccionados?", "Confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        string strResult = string.Empty;
                        strResult = new LoteBL().ProcesarLoteEnvioConfirmacion(LstLoteEnvio);
                        MessageBox.Show(strResult, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnBuscar.PerformClick();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = 0;
            try
            {
                List<LoteBE> LstLote = new List<LoteBE>();
                if (dgvLote.RowCount > 0)
                {
                    foreach (DataGridViewRow row in dgvLote.Rows)
                    {
                        DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells["CheckSel"];
                        if (chk.Value.ToString() == "1")
                        {
                            LoteBE IEntity = new LoteBE()
                            {
                                OPCION = 26,
                                USUARIO = General.General.GetUsuario,
                                IdLote = row.Cells["IdLote"].Value.ToString(),
                                cItem = row.Cells["cItem"].Value.ToString(),
                                gFechaOp = General.General.gFechaOp,
                            };
                            LstLote.Add(IEntity);
                        }
                    }

                    if (LstLote.Count == 0)
                    {
                        MessageBox.Show("Debe seleccionar al menos un registro para la confirmación.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }

                    List<string> LstLoteDistinct = LstLote.Select(x => x.IdLote).Distinct().ToList();
                    List<LoteBE> LstLoteEnvio = new List<LoteBE>();

                    foreach (string item in LstLoteDistinct)
                    {
                        LoteBE IEntity = new LoteBE()
                        {
                            OPCION = 26,
                            USUARIO = General.General.GetUsuario,
                            gFechaOp = General.General.gFechaOp,
                            IdLote = item
                        };
                        LstLoteEnvio.Add(IEntity);
                    }

                    dialogResult = MessageBox.Show("¿Seguro de confirmar los registros seleccionados?", "Confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        new LoteBL().ProcesarLoteEnvioConfirmacion(LstLoteEnvio);
                        MessageBox.Show("Se Proceso Correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnBuscar.PerformClick();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRevertirConfirmacion_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = 0;
            try
            {
                List<LoteBE> LstLote = new List<LoteBE>();
                if (dgvLote.RowCount > 0)
                {
                    foreach (DataGridViewRow row in dgvLote.Rows)
                    {
                        DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells["CheckSel"];
                        if (chk.Value.ToString() == "1")
                        {
                            LoteBE IEntity = new LoteBE()
                            {
                                OPCION = 27,
                                USUARIO = General.General.GetUsuario,
                                IdLote = row.Cells["IdLote"].Value.ToString(),
                                cItem = row.Cells["cItem"].Value.ToString(),
                            };
                            LstLote.Add(IEntity);
                        }
                    }

                    if (LstLote.Count == 0)
                    {
                        MessageBox.Show("Debe seleccionar al menos un registro para revertir la confirmación.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }

                    dialogResult = MessageBox.Show("¿Seguro de revertir la confirmación de los registros seleccionados?", "Confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        new LoteBL().ProcesarLoteEnvioConfirmacion(LstLote);
                        MessageBox.Show("Se Proceso Correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnBuscar.PerformClick();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVerLiquidacion_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = 0;
            try
            {
                if (dgvLote.RowCount > 0)
                {
                    string IdLote = dgvLote.CurrentRow.Cells["IdLote"].Value.ToString();
                    DataSet dsLotes = new DataSet();
                    using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConexionStrDBEfideFactoring"].ConnectionString))
                    {
                        SqlCommand cmd1 = new SqlCommand("Rpt_Lote_Cab", con);
                        cmd1.CommandType = CommandType.StoredProcedure;
                        cmd1.Parameters.AddWithValue("@IdLote", IdLote);
                        SqlDataAdapter daCab = new SqlDataAdapter(cmd1);
                        daCab.Fill(dsLotes, "Rpt_Lote_Cab");

                        SqlCommand cmd2 = new SqlCommand("Rpt_Lote_Det", con);
                        cmd2.CommandType = CommandType.StoredProcedure;
                        cmd2.Parameters.AddWithValue("@IdLote", IdLote);
                        SqlDataAdapter daDet = new SqlDataAdapter(cmd2);
                        daDet.Fill(dsLotes, "Rpt_Lote_Det");

                        con.Close();
                    }

                    Crystal.crRegLiquidacion ocrLoteLiquidacion = new Crystal.crRegLiquidacion();
                    Reportes.frmVisorLoteLiquidacion ofrmVisorLoteLiquidacion = new Reportes.frmVisorLoteLiquidacion();
                    ofrmVisorLoteLiquidacion.crvVisorLoteLiq.ReportSource = ocrLoteLiquidacion;
                    ocrLoteLiquidacion.SetDataSource(dsLotes);
                    ocrLoteLiquidacion.SetParameterValue("usuario", General.General.GetUsuario);
                    ocrLoteLiquidacion.SetParameterValue("moneda", dsLotes.Tables[0].Rows[0]["IdMoneda_Dsc"].ToString());
                    ofrmVisorLoteLiquidacion.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            try
            {
                TextBoxX1.Clear();
                txtIdPagadora_Dsc.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rbtnPEnviaronConfirmacion_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                EvaluarRbtn();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rbtnPendienteConfirmarPagadora_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                EvaluarRbtn();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rbtnConfirmados_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                EvaluarRbtn();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvLote_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            try
            {
                // Referenciamos el control DataGridViewCheckBoxCell actual 
                DataGridViewCheckBoxCell cb = new DataGridViewCheckBoxCell();
                if (cb != null)
                {
                    //Confirmammos los cambios efectuados en la celda actual 
                    dgvLote.CommitEdit(DataGridViewDataErrorContexts.Commit);
                    string IdLote = dgvLote.CurrentRow.Cells["IdLote"].Value.ToString();
                    string Valor = dgvLote.CurrentRow.Cells["CheckSel"].Value.ToString() == "1" ? "1" : "0"; 
                   
                    foreach (DataGridViewRow row in dgvLote.Rows)
                    {
                        if (row.Cells["IdLote"].Value.ToString().Trim().Equals(IdLote.Trim()))
                        {
                            row.Cells["CheckSel"].Value = Valor;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EvaluarRbtn()
        {
            try
            {
                btnEntregar.Enabled = false;
                btnConfirmar.Enabled = false;
                btnRevertirConfirmacion.Enabled = false;
                if (rbtnPEnviaronConfirmacion.Checked)
                {
                    btnEntregar.Enabled = true;
                }
                else if (rbtnPendienteConfirmarPagadora.Checked)
                {
                    btnConfirmar.Enabled = true;
                }
                else if (rbtnConfirmados.Checked)
                {
                    btnRevertirConfirmacion.Enabled = true;
                }

                if (dt != null)
                {
                    dt.Rows.Clear();
                    dgvLote.DataSource = dt;
                    dgvLote.Refresh();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalir2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void dgvLote_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                //DataGridViewRow row = dgvLote.Rows[e.RowIndex];// get you required index
                //// check the cell value under your specific column and then you can toggle your colors

                //if (row.Cells["IdTipoConfirmacion"].Value.ToString().Equals("00435"))
                //{
                //    row.DefaultCellStyle.ForeColor = Color.Blue;
                //}

                //if (row.Cells["IdTipoConfirmacion"].Value.ToString().Equals("00435") && (!row.Cells["NroEnvioCorreo"].Value.ToString().Equals("0")))
                //{
                //    row.DefaultCellStyle.ForeColor = Color.Red;
                //}

                //row.Cells["Clasificacion"].Style.ForeColor = Color.FromName(row.Cells["ColorRow"].Value.ToString());
                //row.DefaultCellStyle.ForeColor = Color.FromName(row.Cells["ColorRow"].Value.ToString());


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormatoGrid()
        {
            try
            {
                foreach (DataGridViewRow row in dgvLote.Rows)
                {
                    if (row.Cells["IdTipoConfirmacion"].Value.ToString().Equals("00435"))
                    {
                        row.DefaultCellStyle.ForeColor = Color.Blue;
                    }

                    if (row.Cells["IdEstadoLinea_tt"].Value.ToString().Equals("00032") || row.Cells["nSaldoLinea"].Value.ToString().Equals("0"))
                    {
                        row.DefaultCellStyle.ForeColor = Color.Red;
                    }

                    if (row.Cells["IdEstadoLinea_tt"].Value.ToString().Equals("00033") || row.Cells["IdEstadoLinea_tt"].Value.ToString().Equals("00450") || row.Cells["IdEstadoLinea_tt"].Value.ToString().Equals("00451")
                        || row.Cells["IdEstadoLinea_tt"].Value.ToString().Equals("00459") || row.Cells["IdEstadoLinea_tt"].Value.ToString().Equals("00491"))
                    {
                        row.DefaultCellStyle.ForeColor = Color.Green;
                    }
                }
                 //DataGridViewRow row = dgvLote.Rows[e.RowIndex];// get you required index
                // check the cell value under your specific column and then you can toggle your colors
            }
            catch (Exception ex)
            {   
                 MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvLote_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                FormatoGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvLote_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvLote.Rows.Count > 0)
                {
                    Consulta.frmConSaldoPagador ofrm = new Consulta.frmConSaldoPagador();
                    ofrm.txtCodigo.Text = dgvLote.CurrentRow.Cells["IdPagadora"].Value.ToString();
                    ofrm.txtPagadora.Text = dgvLote.CurrentRow.Cells["IdPagadora_Dsc"].Value.ToString();
                    ofrm.btnBuscar.PerformClick();
                    ofrm.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}