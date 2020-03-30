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

namespace EfideFactoring.Formula.Cobranza
{
    public partial class frmMntCobranzaPagadoraConf : DevComponents.DotNetBar.OfficeForm
    {
        private CobranzaBL CobranzaBL = new CobranzaBL();
        public frmMntCobranzaPagadoraConf()
        {
            InitializeComponent();
        }

        #region Eventos
        private void frmMntCobranzaPagadoraConf_Load(object sender, EventArgs e)
        {
            dtRegistroFiltro.Value = DateTime.Now;
            LlenarCombos();
            btnBuscar.PerformClick();
        }

        private void LlenarCombos()
        {
            try
            {
                String Table_Id = "00130"; //Estado de Cobranza Filtro Confirmación
                TableBaseBE TableBaseBE = new TableBaseBE()
                {
                    OPCION = 1,
                    USUARIO = General.General.GetCodigoUsuario,
                    Table_Parent_Id = Table_Id
                };

                DataTable dt = new TableBaseBL().ProcesarTableBase(TableBaseBE).Tables[0];
                General.General.LlenarCombobox(cboIdEstado_tt, "Table_Name", "Table_Value", dt);
                cboIdEstado_tt.SelectedValue = "A"; //Pendiente de Confirmación
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
                CobranzaBE CobranzaBE = new CobranzaBE()
                {
                    OPCION = 8,
                    USUARIO = General.General.GetUsuario,
                    dtRegistro = dtRegistroFiltro.Value,
                    Status = cboIdEstado_tt.SelectedValue.ToString()
                };

                ds = CobranzaBL.ProcesarCobranza(CobranzaBE);
                dgvCobranza.DataSource = ds.Tables[0];
                lblRegistros.Text = ds.Tables[0].Rows.Count.ToString() + " registro(s)";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = 0;
            DataSet ds = new DataSet();
            try
            {
                if (dgvCobranza.RowCount > 0)
                {
                    if (dgvCobranza.CurrentRow.Cells["Status"].Value.ToString() != "A")
                    {
                        MessageBox.Show("Esta cobranza ya esta confirmada", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    General.General.ValidarTipoCambio();
                    dialogResult = MessageBox.Show("Seguro de confirmar la cobranza Nro. " + dgvCobranza.CurrentRow.Cells["IdCobranza"].Value.ToString().Trim(), "Confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dialogResult == DialogResult.Yes)
                    {
                        //Confirma el detalle 
                        string IdCobranza = dgvCobranza.CurrentRow.Cells["IdCobranza"].Value.ToString().Trim();
                        string IdMoneda_tt = dgvCobranza.CurrentRow.Cells["IdMoneda_tt"].Value.ToString().Trim();
                        DateTime dtRegistro = Convert.ToDateTime(dgvCobranza.CurrentRow.Cells["Fecha"].Value.ToString().Trim());
                        int iMonedaID = IdMoneda_tt == "00036" ? 1 : 2;

                        BindingList<CobranzaDetalleBE> LstCobranzaDetalle = new BindingList<CobranzaDetalleBE>();
                        DataSet dsDetaLote = new DataSet();
                        CobranzaDetalleBE oCobranzaDetalleBE = new CobranzaDetalleBE()
                        {
                            USUARIO = General.General.GetCodigoUsuario,
                            OPCION = 1,
                            IdCobranza = IdCobranza,
                            sdFechaOp = General.General.gFechaOp
                        };
                        dsDetaLote = new CobranzaDetalleBL().ProcesarCobranzaDetalle(oCobranzaDetalleBE);
                        if (dsDetaLote.Tables[0].Rows.Count > 0)
                        {
                            for (int i = 0; i < dsDetaLote.Tables[0].Rows.Count; i++)
                            {
                                CobranzaDetalleBE oCobranzadetBE = new CobranzaDetalleBE()
                                {
                                    IdLote = dsDetaLote.Tables[0].Rows[i]["IdLote"].ToString(),
                                    cItem = dsDetaLote.Tables[0].Rows[i]["cItem"].ToString(),
                                    IdDocumento = dsDetaLote.Tables[0].Rows[i]["IdDocumento"].ToString(),
                                    IdSocio = dsDetaLote.Tables[0].Rows[i]["IdSocio"].ToString(),
                                    IdSocio_Dsc = dsDetaLote.Tables[0].Rows[i]["IdSocio_Dsc"].ToString(),
                                    vDocumento = dsDetaLote.Tables[0].Rows[i]["vDocumento"].ToString(),
                                    cNumDoc = dsDetaLote.Tables[0].Rows[i]["cNumDoc"].ToString(),
                                    nvNominal = Decimal.Parse(dsDetaLote.Tables[0].Rows[i]["nvNominal"].ToString()),
                                    nvNegociable = Decimal.Parse(dsDetaLote.Tables[0].Rows[i]["nvNegociable"].ToString()),
                                    nvImporte = Decimal.Parse(dsDetaLote.Tables[0].Rows[i]["nvImporte"].ToString()),
                                    DifCobrada = Decimal.Parse(dsDetaLote.Tables[0].Rows[i]["DifCobrada"].ToString()),
                                    Interes = Decimal.Parse(dsDetaLote.Tables[0].Rows[i]["Interes"].ToString()),
                                    Garantia = Decimal.Parse(dsDetaLote.Tables[0].Rows[i]["Garantia"].ToString()),
                                };
                                LstCobranzaDetalle.Add(oCobranzadetBE);
                            }
                        }

                        CobranzaBE oCobranza = new CobranzaBE()
                        {
                            USUARIO = General.General.GetCodigoUsuario,
                            OPCION = 6,
                            IdCobranza = IdCobranza,
                            dtRegistro = General.General.gFechaOp,
                            dtValuta = General.General.gFechaOp,
                            iMonedaID = iMonedaID,
                            gPlazaID = General.General.gPlazaID,
                            gSesionID = General.General.gSesionID,
                            gFechaOp  = General.General.gFechaOp
                        };
                        bool bResult = CobranzaBL.ProcesarCobranza(oCobranza, LstCobranzaDetalle);
                        if (bResult)
                        {
                            //oCobranza = new CobranzaBE()
                            //{
                            //    USUARIO = General.General.GetCodigoUsuario,
                            //    OPCION = 12,
                            //    IdCobranza = IdCobranza,
                            //    dtRegistro = General.General.gFechaOp,
                            //    dtValuta = General.General.gFechaOp,
                            //    gPlazaID = General.General.gPlazaID,
                            //    gSesionID = General.General.gSesionID,
                            //    gFechaOp = General.General.gFechaOp
                            //};
                            //CobranzaBL.ProcesarCobranza(oCobranza);

                            MessageBox.Show("Se Proceso Correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            //Impresion
                            DataSet dsCobranza = new DataSet();
                            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConexionStrDBEfideFactoring"].ConnectionString))
                            {
                                SqlCommand cmd1 = new SqlCommand("Rpt_CobranzaP_Cab", con);
                                cmd1.CommandType = CommandType.StoredProcedure;
                                cmd1.Parameters.AddWithValue("@IdCobranza", IdCobranza);
                                SqlDataAdapter daCab = new SqlDataAdapter(cmd1);
                                daCab.Fill(dsCobranza, "Rpt_CobranzaP_Cab");

                                SqlCommand cmd2 = new SqlCommand("Rpt_CobranzaP_Det", con);
                                cmd2.CommandType = CommandType.StoredProcedure;
                                cmd2.Parameters.AddWithValue("@IdCobranza", IdCobranza);
                                SqlDataAdapter daDet = new SqlDataAdapter(cmd2);
                                daDet.Fill(dsCobranza, "Rpt_CobranzaP_Det");

                                SqlCommand cmd3 = new SqlCommand("Rpt_CobranzaPago", con);
                                cmd3.CommandType = CommandType.StoredProcedure;
                                cmd3.Parameters.AddWithValue("@IdCobranza", IdCobranza);
                                SqlDataAdapter daDet2 = new SqlDataAdapter(cmd3);
                                daDet2.Fill(dsCobranza, "Rpt_CobranzaPago");

                                con.Close();
                            }

                            Crystal.crRptCobranzaPagadora ocrLoteLiquidacion = new Crystal.crRptCobranzaPagadora();
                            Reportes.frmVisorLoteLiquidacion ofrmVisorLoteLiquidacion = new Reportes.frmVisorLoteLiquidacion();
                            ofrmVisorLoteLiquidacion.crvVisorLoteLiq.ReportSource = ocrLoteLiquidacion;
                            ocrLoteLiquidacion.SetDataSource(dsCobranza);
                            ocrLoteLiquidacion.SetParameterValue("FechaCancelacion", dtRegistro);
                            ocrLoteLiquidacion.SetParameterValue("Usuario", General.General.GetUsuario);
                            ofrmVisorLoteLiquidacion.WindowState = FormWindowState.Maximized;
                            ofrmVisorLoteLiquidacion.ShowDialog();
                        }

                        //foreach (var item in LstCobranzaDetalle)
                        //{
                        //    item.USUARIO = General.General.GetCodigoUsuario;
                        //    item.OPCION = 5;
                        //    item.IdPagadora = item.IdPagadora;
                        //    item.IdSocio = item.IdSocio;
                        //    item.IdCobranza = IdCobranza;
                        //    item.nvImporte = item.nvImporte;
                        //    item.sdFechaOp = General.General.gFechaOp;
                        //    item.gSesionID = General.General.gSesionID;
                        //    item.gPlazaID = General.General.gPlazaID;
                        //    item.valorMonedaID = iMonedaID;
                        //    item.IdLote = item.IdLote;
                        //    item.cItem = item.cItem;
                        //    new CobranzaDetalleBL().ProcesarCobranzaDetalle(item);
                        //}
                        btnBuscar.PerformClick();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExtornar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = 0;
            DataSet ds = new DataSet();
            try
            {
                if (dgvCobranza.RowCount > 0)
                {
                    if (dgvCobranza.CurrentRow.Cells["Status"].Value.ToString() != "C")
                    {
                        MessageBox.Show("Esta cobranza no se puede extornar, debe estar confirmada para realizar esta acción", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    dialogResult = MessageBox.Show("Seguro de extornar la cobranza Nro. " + dgvCobranza.CurrentRow.Cells["IdCobranza"].Value.ToString().Trim(), "Confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dialogResult == DialogResult.Yes)
                    {
                        CobranzaBE CobranzaBE = new CobranzaBE()
                        {
                            OPCION = 7,
                            USUARIO = General.General.GetUsuario,
                            IdCobranza = dgvCobranza.CurrentRow.Cells["IdCobranza"].Value.ToString(),
                        };

                        CobranzaBL.ProcesarCobranza(CobranzaBE);
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

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            dtRegistroFiltro.Text = "";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvCobranza.RowCount > 0)
                {
                    if (dgvCobranza.CurrentRow.Cells["IdTipoCobranza_tt"].Value.ToString().Trim() == "00055")
                    {
                        frmMntCobranzaPagadoraDato ofrmMntCobranzaDato = new frmMntCobranzaPagadoraDato();
                        ofrmMntCobranzaDato.Operacion = "C";
                        ofrmMntCobranzaDato.Codigo = dgvCobranza.CurrentRow.Cells["IdCobranza"].Value.ToString();
                        ofrmMntCobranzaDato.ShowDialog();
                        btnBuscar.PerformClick();
                    }
                    else
                    {
                        frmMntCobranzaSocioDato ofrmMntCobranzaDato = new frmMntCobranzaSocioDato();
                        ofrmMntCobranzaDato.Operacion = "C";
                        ofrmMntCobranzaDato.Codigo = dgvCobranza.CurrentRow.Cells["IdCobranza"].Value.ToString();
                        ofrmMntCobranzaDato.ShowDialog();
                        btnBuscar.PerformClick();
                    }
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