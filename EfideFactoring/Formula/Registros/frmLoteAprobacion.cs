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

namespace EfideFactoring.Formula.Registros
{
    public partial class frmLoteAprobacion : DevComponents.DotNetBar.OfficeForm
    {
        LoteBL LoteBL = new LoteBL();
        TableBaseBL TableBaseBL = new TableBaseBL();
        public frmLoteAprobacion()
        {
            InitializeComponent();
        }

        private void frmLoteAprobacion_Load(object sender, EventArgs e)
        {
            dtFechaRegistro.Value = DateTime.Now;
            LlenarCombos();
            btnBuscar.PerformClick();
        }

        private void LlenarCombos()
        {
            try
            {
                String Table_Id = "00118"; //Estados de Lotes para filtros de aprobacion
                TableBaseBE TableBaseBE = new TableBaseBE()
                {
                    OPCION = 1,
                    USUARIO = General.General.GetCodigoUsuario,
                    Table_Parent_Id = Table_Id
                };

                DataTable dt = TableBaseBL.ProcesarTableBase(TableBaseBE).Tables[0];
                General.General.LlenarCombobox(cboIdEstado_tt, "Table_Name", "Table_Value", dt);
                cboIdEstado_tt.SelectedValue = "00059"; //Por Aprobar
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
                    OPCION = 9,
                    USUARIO = General.General.GetUsuario,
                    IdEstado_tt = cboIdEstado_tt.SelectedValue.ToString(), // Enviado a Aprobación
                    sdDesembolso = dtFechaRegistro.Value
                };

                ds = LoteBL.ProcesarLote(LoteBE);
                dgvLote.DataSource = ds.Tables[0];
                lblRegistros.Text = ds.Tables[0].Rows.Count.ToString() + " registro(s)";

                foreach (DataGridViewRow row in dgvLote.Rows)
                {
                    if (row.Cells["IdEstado_tt"].Value.Equals("00077")) // Aprobado
                    {
                        row.DefaultCellStyle.ForeColor = Color.FromName(General.General.GetColorLoteAprobado);
                    }
                    else
                    {
                        row.DefaultCellStyle.ForeColor = Color.FromName(General.General.GetColorLotePorAprobar);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAprobacion_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime dtOperacion = General.General.gFechaOp.Date.AddHours(DateTime.Now.Hour).AddMinutes(DateTime.Now.Minute).AddSeconds(DateTime.Now.Second);
                General.General.ValidarTipoCambio();
                Boolean IsAprobo = false;
                if (dgvLote.RowCount > 0)
                {
                    foreach (DataGridViewRow row in dgvLote.Rows)
                    {
                        DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells[0];
                        if (chk.Value != null)
                        {
                            if (chk.Value.ToString().Equals("True") && row.Cells["IdEstado_tt"].Value.ToString().Equals("00059")) //Por Aprobar
                            {
                                LoteBE LoteBE = new LoteBE()
                                {
                                    OPCION = 6,
                                    USUARIO = General.General.GetUsuario,
                                    IdLote = row.Cells["IdLote"].Value.ToString(),
                                    gFechaOp = General.General.gFechaOp,
                                    sdAprobacion = dtOperacion,
                                    sdDesembolso = dtOperacion,
                                    IdEstado_tt = "00077" // Aprobado
                                };
                                LoteBL.ProcesarLote(LoteBE);

                                //Guardar el documento PDF
                                String strIdLote = row.Cells["IdLote"].Value.ToString();
                                DataSet dsLotes = new DataSet();
                                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConexionStrDBEfideFactoring"].ConnectionString))
                                {
                                    SqlCommand cmd1 = new SqlCommand("Rpt_Lote_Cab", con);
                                    cmd1.CommandType = CommandType.StoredProcedure;
                                    cmd1.Parameters.AddWithValue("@IdLote", strIdLote);
                                    SqlDataAdapter daCab = new SqlDataAdapter(cmd1);
                                    daCab.Fill(dsLotes, "Rpt_Lote_Cab");

                                    SqlCommand cmd2 = new SqlCommand("Rpt_Lote_Det", con);
                                    cmd2.CommandType = CommandType.StoredProcedure;
                                    cmd2.Parameters.AddWithValue("@IdLote", strIdLote);
                                    SqlDataAdapter daDet = new SqlDataAdapter(cmd2);
                                    daDet.Fill(dsLotes, "Rpt_Lote_Det");

                                    con.Close();
                                }

                                //Crystal.crRegLiquidacion ocrLoteLiquidacion = new Crystal.crRegLiquidacion();
                                //ocrLoteLiquidacion.SetDataSource(dsLotes);
                                //ocrLoteLiquidacion.SetParameterValue("usuario", General.General.GetUsuario);
                                //ocrLoteLiquidacion.SetParameterValue("moneda", dsLotes.Tables[0].Rows[0]["IdMoneda_Dsc"].ToString());
                                //ocrLoteLiquidacion.ExportToDisk(ExportFormatType.PortableDocFormat, ConfigurationManager.AppSettings["RutaArchivoLiquidacionLote"].ToString() + strIdLote.Trim() + ".pdf");
                                IsAprobo = true;

                                //SUBIR EL PDF AL MOVIMIENTO EN CASO EL LOTE VENGA DE ESTE
                                //LoteBE.OPCION = 20;
                                //LoteBE.USUARIO = General.General.GetUsuario;
                                //LoteBE.IdLote = strIdLote;
                                //LoteBE.gFechaOp = General.General.gFechaOp;
                                //LoteBL.ProcesarLote(LoteBE);
                            }
                        }
                    }

                    btnBuscar.PerformClick();
                    if (IsAprobo){
                        MessageBox.Show("Se Proceso Correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                btnBuscar.PerformClick();
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExtornar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = 0;
            try
            {
                Boolean IsProcedio = false;
                int Opcion = 0;
                if (dgvLote.RowCount > 0)
                {
                    dialogResult = MessageBox.Show("Seguro de extornar los lotes seleccionados?: ", "Confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        DataTable dt = new DataTable();
                        dt.Columns.Add("OPCION");
                        dt.Columns.Add("IdLote");
                        foreach (DataGridViewRow row in dgvLote.Rows)
                        {
                            DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells[0];
                            if (chk.Value != null)
                            {
                                
                                if (chk.Value.ToString().Equals("True") && row.Cells["IdEstado_tt"].Value.ToString().Equals("00059")) //Por Aprobar
                                {
                                    DataRow dr = dt.NewRow();
                                    dr["OPCION"] = 6;
                                    dr["IdLote"] = row.Cells["IdLote"].Value.ToString();
                                    dt.Rows.Add(dr);
                                }
                                else if (dgvLote.CurrentRow.Cells["IdEstado_tt"].Value.ToString().Equals("00077")) //Aprobado
                                {
                                    DataRow dr = dt.NewRow();
                                    dr["OPCION"] = 12;
                                    dr["IdLote"] = row.Cells["IdLote"].Value.ToString();
                                    dt.Rows.Add(dr);
                                }
                            }
                        }

                        //Procesar
                        LoteBE LoteBE = new LoteBE()
                        {
                            USUARIO = General.General.GetUsuario,
                            gFechaOp = General.General.gFechaOp,
                            dtLote = dt,
                            IdEstado_tt = "00058" // Registrado
                        };
                        LoteBL.ProcesarLoteExtornacion(LoteBE);
                        IsProcedio = true;
                    }

                    btnBuscar.PerformClick();
                    if(IsProcedio){
                        MessageBox.Show("Se Proceso Correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void dgvLote_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex < 0) return;
                if (e.RowIndex == -1) return;
                if (dgvLote.Columns[e.ColumnIndex].Name == "btnLiquidacion")
                {
                    String strIdLote = dgvLote.CurrentRow.Cells["IdLote"].Value.ToString();
                    DataSet dsLotes = new DataSet();
                    using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConexionStrDBEfideFactoring"].ConnectionString))
                    {
                        SqlCommand cmd1 = new SqlCommand("Rpt_Lote_Cab", con);
                        cmd1.CommandType = CommandType.StoredProcedure;
                        cmd1.Parameters.AddWithValue("@IdLote", strIdLote);
                        SqlDataAdapter daCab = new SqlDataAdapter(cmd1);
                        daCab.Fill(dsLotes, "Rpt_Lote_Cab");

                        SqlCommand cmd2 = new SqlCommand("Rpt_Lote_Det", con);
                        cmd2.CommandType = CommandType.StoredProcedure;
                        cmd2.Parameters.AddWithValue("@IdLote", strIdLote);
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
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}