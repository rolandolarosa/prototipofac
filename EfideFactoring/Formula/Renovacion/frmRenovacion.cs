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

namespace EfideFactoring.Formula.Renovacion
{
    public partial class frmRenovacion : FormulaBase.frmMntFiltro
    {
        public int FlgAsistente = 0;
        RenovacionBL RenovacionBL = new RenovacionBL();
        public frmRenovacion()
        {
            InitializeComponent();
        }

        #region Eventos
        private void frmRenovacion_Load(object sender, EventArgs e)
        {
            try
            {
                LlenarCombos();

                if (FlgAsistente == 1)
                {
                    dtRegistro.Enabled = false;
                    dtRegistro.Value = DateTime.Now; 
                    gvRenovacion.Columns["btnAnularAprob"].Visible = false;
                    gvRenovacion.Columns["btnExtornarRenov"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                General.General.ValidarTipoCambio();
                frmRenovacionDato ofrmRenovacionDato = new frmRenovacionDato();
                ofrmRenovacionDato.Operacion = "N";
                ofrmRenovacionDato.ShowDialog();
                btnBuscar.PerformClick();
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
                RenovacionBE RenovacionBE = new RenovacionBE()
                {
                    USUARIO = General.General.GetCodigoUsuario,
                    OPCION = 1,
                    gSesionID = General.General.gSesionID,
                    gPlazaID = General.General.gPlazaID,
                    gFechaOp = General.General.gFechaOp,
                    dtRegistro = dtRegistro.Value,
                    dtRenovacion = dtRenovacion.Value,
                    IdMoneda_tt = cboIdMoneda_tt.SelectedValue.ToString(),
                    IdEstado_tt = cboIdEstado_tt.SelectedValue.ToString(),
                    IdSocio = txtIdSocio.Text,
                    IdPagadora = txtIdPagadora.Text
                };
                DataSet dsRenovacion;
                dsRenovacion = RenovacionBL.ProcesarRenovacion(RenovacionBE);
                gvRenovacion.DataSource = dsRenovacion.Tables[0];
                lblRegistros.Text = dsRenovacion.Tables[0].Rows.Count + " registro(s)";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBusquedaPagadora_Click(object sender, EventArgs e)
        {
            try
            {
                Formula.Consulta.frmBusquedaPagadora ofrmBusquedaPagadora = new Formula.Consulta.frmBusquedaPagadora();
                ofrmBusquedaPagadora.ShowDialog();

                if (!string.IsNullOrEmpty(ofrmBusquedaPagadora.CodigoPagadora.ToString().Trim()))
                {
                    DataSet dsPagadora = new DataSet();
                    PagadoraBL PagadoraBL = new PagadoraBL();
                    PagadoraBE PagadoraBE = new PagadoraBE()
                    {
                        OPCION = 4,
                        USUARIO = General.General.GetCodigoUsuario,
                        IdPagadora = ofrmBusquedaPagadora.CodigoPagadora.ToString()
                    };

                    dsPagadora = PagadoraBL.ProcesarPagadora(PagadoraBE);

                    if (dsPagadora.Tables[0].Rows.Count > 0)
                    {
                        txtIdPagadora.Text = dsPagadora.Tables[0].Rows[0]["IdPagadora"].ToString();
                        txtIdPagadora_Dsc.Text = dsPagadora.Tables[0].Rows[0]["vcPagadora"].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBusquedaSocio_Click(object sender, EventArgs e)
        {
            try
            {
                Formula.Consulta.frmBusquedaSocio ofrmBusquedaSocio = new Formula.Consulta.frmBusquedaSocio();
                ofrmBusquedaSocio.ShowDialog();

                if (!string.IsNullOrEmpty(ofrmBusquedaSocio.CodSocio))
                {
                    txtIdSocio.Text = ofrmBusquedaSocio.CodSocio.Trim();
                    txtIdSocio_Dsc.Text = ofrmBusquedaSocio.RazorSocialSocio.Trim();
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
                cboIdMoneda_tt.SelectedValue = string.Empty;
                cboIdEstado_tt.SelectedValue = string.Empty;
                dtRegistro.Text = string.Empty;
                dtRenovacion.Text = string.Empty;
                txtIdSocio.Text = string.Empty;
                txtIdSocio_Dsc.Text = string.Empty;
                txtIdPagadora.Text = string.Empty;
                txtIdPagadora_Dsc.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                General.General.ValidarTipoCambio();
                if (gvRenovacion.RowCount > 0)
                {
                    string IdEstado_tt = gvRenovacion.CurrentRow.Cells["IdEstado_tt"].Value.ToString();
                    if (IdEstado_tt == "00113") //Anulado
                    {
                        MessageBox.Show("No se puede editar este registro.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    frmRenovacionDato ofrmRenovacionDato = new frmRenovacionDato();
                    ofrmRenovacionDato.Operacion = "M";
                    ofrmRenovacionDato.Codigo = gvRenovacion.CurrentRow.Cells["IdRenovacion"].Value.ToString();
                    ofrmRenovacionDato.ShowDialog();
                    btnBuscar.PerformClick();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = 0;
            try
            {
                if (gvRenovacion.RowCount > 0)
                {
                    if (gvRenovacion.CurrentRow.Cells["IdEstado_tt"].Value.ToString() != "00110") //Pendiente
                    {
                        MessageBox.Show("Esta renovacion no se eliminar", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    dialogResult = MessageBox.Show("Seguro de eliminar el registro Nro. " + gvRenovacion.CurrentRow.Cells["IdRenovacion"].Value.ToString().Trim(), "Confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dialogResult == DialogResult.Yes)
                    {
                        RenovacionBE RenovacionBE = new RenovacionBE()
                        {
                            OPCION = 5,
                            USUARIO = General.General.GetUsuario,
                            gSesionID = General.General.gSesionID,
                            gPlazaID = General.General.gPlazaID,
                            gFechaOp = General.General.gFechaOp,
                            IdRenovacion = gvRenovacion.CurrentRow.Cells["IdRenovacion"].Value.ToString()
                        };

                        RenovacionBL.ProcesarRenovacion(RenovacionBE);
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

        private void gvRenovacion_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex < 0) return;
                if (e.RowIndex == -1) return;

                switch (gvRenovacion.Columns[e.ColumnIndex].Name)
                {
                    case "btnDetalle":
                        {
                            VerDetalle();
                            break;
                        }
                    case "btnAprobar":
                        {
                            Aprobar();
                            break;
                        }
                    case "btnAnularAprob":
                        {
                            AnularAprobacion();
                            break;
                        }
                    case "btnRenovacion":
                        {
                            Renovacion();
                            break;
                        }
                    case "btnExtornarRenov":
                        {
                            ExtornarRenovacion();
                            break;
                        }
                    case "btnImprimir":
                        {
                            Imprimir();
                            break;
                        }
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Metodos
        private void LlenarCombos()
        {
            try
            {
                String Table_Id = "00035"; //Moneda
                TableBaseBL TableBaseBL = new EfideFactoringBL.TableBaseBL();
                TableBaseBE TableBaseBE = new TableBaseBE()
                {
                    OPCION = 1,
                    USUARIO = General.General.GetCodigoUsuario,
                    Table_Parent_Id = Table_Id
                };
                General.General.LlenarCombobox(cboIdMoneda_tt, "Table_Name", "Table_Id", TableBaseBL.ProcesarTableBase(TableBaseBE).Tables[0]);

                TableBaseBE.Table_Parent_Id = "00109"; //Estado
                General.General.LlenarCombobox(cboIdEstado_tt, "Table_Name", "Table_Id", TableBaseBL.ProcesarTableBase(TableBaseBE).Tables[0]);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ExtornarRenovacion()
        {
            try
            {
                DialogResult dialogResult = 0;
                if (gvRenovacion.CurrentRow.Cells["IdEstado_tt"].Value.ToString() != "00112") //Renovado
                {
                    MessageBox.Show("Este registro no se puede extornar la renovación", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                General.General.ValidarTipoCambio();
                dialogResult = MessageBox.Show("Seguro de extornar la renovación Nro. " + gvRenovacion.CurrentRow.Cells["IdRenovacion"].Value.ToString().Trim(), "Confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogResult == DialogResult.Yes)
                {
                    RenovacionBE RenovacionBE = new RenovacionBE()
                    {
                        OPCION = 6,
                        USUARIO = General.General.GetUsuario,
                        gSesionID = General.General.gSesionID,
                        gPlazaID = General.General.gPlazaID,
                        gFechaOp = General.General.gFechaOp,
                        IdRenovacion = gvRenovacion.CurrentRow.Cells["IdRenovacion"].Value.ToString()
                    };

                    RenovacionBL.ProcesarRenovacion(RenovacionBE);
                    MessageBox.Show("Se Proceso Correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnBuscar.PerformClick();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void VerDetalle()
        {
            try
            {
                frmRenovacionDet ofrm = new frmRenovacionDet();
                ofrm._IdRenovacion = gvRenovacion.CurrentRow.Cells["IdRenovacion"].Value.ToString();
                ofrm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Renovacion()
        {
            try
            {
                if (gvRenovacion.CurrentRow.Cells["IdEstado_tt"].Value.ToString() == "00113") //Anulado
                {
                    MessageBox.Show("Este registro no se puede renovar", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                General.General.ValidarTipoCambio();
                frmRenovacionAplicar ofrm = new frmRenovacionAplicar();
                ofrm.Codigo = gvRenovacion.CurrentRow.Cells["IdRenovacion"].Value.ToString();
                ofrm.ShowDialog();
                btnBuscar.PerformClick();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AnularAprobacion()
        {
            try
            {
                DialogResult dialogResult = 0;
                if (gvRenovacion.CurrentRow.Cells["IdEstado_tt"].Value.ToString() != "00111") //Aprobado
                {
                    MessageBox.Show("Este registro no se puede anular la aprobación", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                dialogResult = MessageBox.Show("Seguro de anular el registro Nro. " + gvRenovacion.CurrentRow.Cells["IdRenovacion"].Value.ToString().Trim(), "Confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogResult == DialogResult.Yes)
                {
                    RenovacionBE RenovacionBE = new RenovacionBE()
                    {
                        OPCION = 3,
                        USUARIO = General.General.GetUsuario,
                        gSesionID = General.General.gSesionID,
                        gPlazaID = General.General.gPlazaID,
                        gFechaOp = General.General.gFechaOp,
                        IdRenovacion = gvRenovacion.CurrentRow.Cells["IdRenovacion"].Value.ToString(),
                        IdEstado_tt = "00113", //Anular
                    };

                    RenovacionBL.ProcesarRenovacion(RenovacionBE);
                    MessageBox.Show("Se Proceso Correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnBuscar.PerformClick();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Aprobar()
        {
            try
            {
                DialogResult dialogResult = 0;
                if (gvRenovacion.CurrentRow.Cells["IdEstado_tt"].Value.ToString() != "00110") //Pendiente
                {
                    MessageBox.Show("Este registro no se puede aprobar", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                General.General.ValidarTipoCambio();
                dialogResult = MessageBox.Show("Seguro de aprobar el registro Nro. " + gvRenovacion.CurrentRow.Cells["IdRenovacion"].Value.ToString().Trim(), "Confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogResult == DialogResult.Yes)
                {
                    RenovacionBE RenovacionBE = new RenovacionBE()
                    {
                        OPCION = 3,
                        USUARIO = General.General.GetUsuario,
                        gSesionID = General.General.gSesionID,
                        gPlazaID = General.General.gPlazaID,
                        gFechaOp = General.General.gFechaOp,
                        IdRenovacion = gvRenovacion.CurrentRow.Cells["IdRenovacion"].Value.ToString(),
                        IdEstado_tt = "00111", //Aprobar
                    };

                    RenovacionBL.ProcesarRenovacion(RenovacionBE);
                    MessageBox.Show("Se Proceso Correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnBuscar.PerformClick();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Imprimir()
        {
            try
            {
                if (gvRenovacion.CurrentRow.Cells["IdEstado_tt"].Value.ToString() == "00113") //Anulada
                {
                    return;
                }

                DataSet dsRenovacion = new DataSet();
                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConexionStrDBEfideFactoring"].ConnectionString))
                {
                    SqlCommand cmd1 = new SqlCommand("Rpt_Renovacion", con);
                    cmd1.CommandType = CommandType.StoredProcedure;
                    cmd1.Parameters.AddWithValue("@Opcion", 1);
                    cmd1.Parameters.AddWithValue("@IdRenovacion", gvRenovacion.CurrentRow.Cells["IdRenovacion"].Value.ToString());
                    SqlDataAdapter daCab = new SqlDataAdapter(cmd1);
                    daCab.Fill(dsRenovacion, "Renovacion");

                    SqlCommand cmd2 = new SqlCommand("Rpt_Renovacion", con);
                    cmd2.CommandType = CommandType.StoredProcedure;
                    cmd2.Parameters.AddWithValue("@Opcion", 2);
                    cmd2.Parameters.AddWithValue("@IdRenovacion", gvRenovacion.CurrentRow.Cells["IdRenovacion"].Value.ToString());
                    SqlDataAdapter daCab2 = new SqlDataAdapter(cmd2);
                    daCab2.Fill(dsRenovacion, "RenovacionDet1");

                    SqlCommand cmd3 = new SqlCommand("Rpt_Renovacion", con);
                    cmd3.CommandType = CommandType.StoredProcedure;
                    cmd3.Parameters.AddWithValue("@Opcion", 3);
                    cmd3.Parameters.AddWithValue("@IdRenovacion", gvRenovacion.CurrentRow.Cells["IdRenovacion"].Value.ToString());
                    SqlDataAdapter daCab3 = new SqlDataAdapter(cmd3);
                    daCab3.Fill(dsRenovacion, "RenovacionDet2");
                    con.Close();

                    SqlCommand cmd4 = new SqlCommand("Rpt_Renovacion", con);
                    cmd4.CommandType = CommandType.StoredProcedure;
                    cmd4.Parameters.AddWithValue("@Opcion", 4);
                    cmd4.Parameters.AddWithValue("@IdRenovacion", gvRenovacion.CurrentRow.Cells["IdRenovacion"].Value.ToString());
                    SqlDataAdapter daCab4 = new SqlDataAdapter(cmd4);
                    daCab4.Fill(dsRenovacion, "RenovacionPago");
                    con.Close();
                }

                Crystal.crRptRenovacion ocrRptRenovacion = new Crystal.crRptRenovacion();
                Reportes.frmVisorLoteLiquidacion ofrmVisorLoteLiquidacion = new Reportes.frmVisorLoteLiquidacion();
                ofrmVisorLoteLiquidacion.crvVisorLoteLiq.ReportSource = ocrRptRenovacion;
                ocrRptRenovacion.SetDataSource(dsRenovacion);
                ocrRptRenovacion.SetParameterValue("usuario", General.General.GetUsuario);
                ofrmVisorLoteLiquidacion.Show();

                //Fondo Garantía
                DataSet dsRenovacionFG = new DataSet();
                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConexionStrDBEfideFactoring"].ConnectionString))
                {
                    SqlCommand cmd1 = new SqlCommand("Rpt_Renovacion", con);
                    cmd1.CommandType = CommandType.StoredProcedure;
                    cmd1.Parameters.AddWithValue("@Opcion", 1);
                    cmd1.Parameters.AddWithValue("@IdRenovacion", gvRenovacion.CurrentRow.Cells["IdRenovacion"].Value.ToString());
                    SqlDataAdapter daCab = new SqlDataAdapter(cmd1);
                    daCab.Fill(dsRenovacionFG, "Renovacion");

                    SqlCommand cmd4 = new SqlCommand("Rpt_Renovacion", con);
                    cmd4.CommandType = CommandType.StoredProcedure;
                    cmd4.Parameters.AddWithValue("@Opcion", 5);
                    cmd4.Parameters.AddWithValue("@IdRenovacion", gvRenovacion.CurrentRow.Cells["IdRenovacion"].Value.ToString());
                    SqlDataAdapter daCab4 = new SqlDataAdapter(cmd4);
                    daCab4.Fill(dsRenovacionFG, "RenovacionFG");
                    con.Close();
                }

                if (dsRenovacionFG.Tables["RenovacionFG"].Rows.Count > 0)
                {
                    Crystal.crRptRenovacionFG ocrRptRenovacionFG = new Crystal.crRptRenovacionFG();
                    Reportes.frmVisorLoteLiquidacion ofrm = new Reportes.frmVisorLoteLiquidacion();
                    ofrm.crvVisorLoteLiq.ReportSource = ocrRptRenovacionFG;
                    ocrRptRenovacionFG.SetDataSource(dsRenovacionFG);
                    ocrRptRenovacionFG.SetParameterValue("Usuario", General.General.GetUsuario);
                    ofrm.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
    }
}