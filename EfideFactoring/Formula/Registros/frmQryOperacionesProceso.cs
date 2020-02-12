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

namespace EfideFactoring.Formula.Registros
{
    public partial class frmQryOperacionesProceso : FormulaBase.frmMntFiltro
    {

        private string lcmensaje;
        private int tipo; 
        public int Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }


        public frmQryOperacionesProceso()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet ds = new DataSet();
                LoteBE LoteBE = new LoteBE()
                {
                    OPCION = 21,
                    USUARIO = General.General.GetUsuario,
                    IdSocio_Dsc = TextBoxX1.Text.Trim(),
                    sdDesembolso = dtDesembolsoInicio.Value,
                    sdAprobacion = dtDesembolsoFin.Value,
                    FlgConfimado = rbtnTodos.Checked? "1" : string.Empty,
                    FlgEntregado = rbtnEntregado.Checked ? "1" : string.Empty,
                    FlgPendiente = rbtnPendiente.Checked ? "1" : string.Empty,
                };

                ds = new LoteBL().ProcesarLote(LoteBE);
                dgvLote.DataSource = ds.Tables[0];
                lblRegistros.Text = ds.Tables[0].Rows.Count.ToString() + " registro(s)";

                this.dgvLote.Columns["IdFormaDesembolso_tt_Dsc"].Width = 45;
                this.dgvLote.Columns["sdDesembolso"].Width = 80;
                FormatoGrid();
                
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
                if (dgvLote.RowCount > 0)
                {
                    dialogResult = MessageBox.Show("Seguro de confirmar: " + dgvLote.CurrentRow.Cells["IdLote"].Value.ToString().Trim(), "Confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        LoteBE LoteBE = new LoteBE()
                        {
                            OPCION = 22,
                            USUARIO = General.General.GetUsuario,
                            IdLote = dgvLote.CurrentRow.Cells["IdLote"].Value.ToString(),
                        };
                        new LoteBL().ProcesarLote(LoteBE);
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
                    ofrmVisorLoteLiquidacion.StartPosition = FormStartPosition.CenterScreen;
                    ofrmVisorLoteLiquidacion.WindowState = FormWindowState.Maximized;
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

        private void btnEntregar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = 0;
            try
            {
                int CountCheck = 0;
                string IdLoteCheck = string.Empty;
                foreach (DataGridViewRow row in dgvLote.Rows)
                {
                    DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells["ChkSelAtender"];
                    if (chk.Value != null)
                    {
                        if (bool.Parse(chk.Value.ToString()))
                        {
                            IdLoteCheck = IdLoteCheck + row.Cells["IdLote"].Value.ToString().Trim() + ", ";
                            CountCheck++;
                        }
                    }
                }

                if (CountCheck == 0)
                {
                    MessageBox.Show("Debe seleccionar al menos un registro.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                dialogResult = MessageBox.Show("Confirmar si efectivamente se ha realizado la operación de los siguientes Lotes: " + IdLoteCheck, "Importarte", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (dialogResult == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in dgvLote.Rows)
                    {
                        DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells["ChkSelAtender"];
                        if (chk.Value != null)
                        {
                            if (bool.Parse(chk.Value.ToString()))
                            {
                                try
                                {
                                    LoteBE LoteBE = new LoteBE()
                                    {
                                        OPCION = 23,
                                        USUARIO = General.General.GetUsuario,
                                        IdLote = row.Cells["IdLote"].Value.ToString(),
                                    };
                                    new LoteBL().ProcesarLote(LoteBE);
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                    }
                }
                MessageBox.Show("Se Proceso Correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnBuscar.PerformClick();

                /*
                if (dgvLote.RowCount > 0)
                {
                    switch (dgvLote.CurrentRow.Cells["IdFormaDesembolso_tt_Dsc"].Value.ToString().Trim())
                    {
                        case "TRX":
                            lcmensaje = "IMPORTANTE, confirmar si efectivamente " + "\n" + "se ha realizado la Transferencia en el banco" + "\n" + "Lote N° ";
                            lcmensaje = lcmensaje + dgvLote.CurrentRow.Cells["IdLote"].Value.ToString().Trim();
                            break;
                        case "CHQ":
                            lcmensaje = "IMPORTANTE, confirmar si efectivamente " + "\n" + "se ha entregado el ch/ al socio" + "\n" + "Lote N° ";
                            lcmensaje = lcmensaje + dgvLote.CurrentRow.Cells["IdLote"].Value.ToString().Trim();
                            break;
                        case "ABO":
                            lcmensaje = "IMPORTANTE, confirma si efectivamente " + "\n" + "se ha abonado a la cuenta interna de Efide" + "\n" + "Lote N° ";
                            lcmensaje = lcmensaje + dgvLote.CurrentRow.Cells["IdLote"].Value.ToString().Trim();
                            break;
                    }


                    dialogResult = MessageBox.Show(lcmensaje , "Confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    if (dialogResult == DialogResult.Yes)
                    {
                        LoteBE LoteBE = new LoteBE()
                        {
                            OPCION = 23,
                            USUARIO = General.General.GetUsuario,
                            IdLote = dgvLote.CurrentRow.Cells["IdLote"].Value.ToString(),
                        };
                        new LoteBL().ProcesarLote(LoteBE);
                        MessageBox.Show("Se Proceso Correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnBuscar.PerformClick();
                    }
                }
                 */
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmQryOperacionesProceso_Load(object sender, EventArgs e)
        {
            if (Tipo==2)  // Consulta
            {
                btnEntregar.Visible = false;
            }
        }

        private void btnSalir2_Click(object sender, EventArgs e)
        {
            this.Dispose();
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
                    bool Valor = dgvLote.CurrentRow.Cells["ChkSelAtender"].Value == null ? false : bool.Parse(dgvLote.CurrentRow.Cells["ChkSelAtender"].Value.ToString());

                    foreach (DataGridViewRow row in dgvLote.Rows)
                    {
                        if (row.Cells["IdLote"].Value.ToString().Trim().Equals(IdLote.Trim()))
                        {
                            row.Cells["ChkSelAtender"].Value = Valor;
                        }
                    }
                }
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
                }
                //DataGridViewRow row = dgvLote.Rows[e.RowIndex];// get you required index
                // check the cell value under your specific column and then you can toggle your colors
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
                    ofrm.txtPagadora.Text = dgvLote.CurrentRow.Cells["vcPagadora"].Value.ToString();
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