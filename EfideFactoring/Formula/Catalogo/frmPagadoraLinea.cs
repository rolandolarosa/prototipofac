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

namespace EfideFactoring.Formula.Catalogo
{
    public partial class frmPagadoraLinea : FormulaBase.frmMntDato
    {
        PagadoraLineaBL PagadoraLineaBL = new PagadoraLineaBL();
        TableBaseBL TableBaseBL = new TableBaseBL();
        public string IdPagadora = string.Empty;
        public string TipoOperacion = String.Empty;

        public frmPagadoraLinea()
        {
            InitializeComponent();
        }

        #region Eventos ---------------------------------------------
        private void frmPagadoraLinea_Load(object sender, EventArgs e)
        {
            LlenarCombos();
            CargarDatos();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtnLinea.Text.Trim()))
                {
                    MessageBox.Show("Debe Ingresar una Línea de Crédito", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtnLinea.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(cboIdNivelAutonomia_tt.SelectedValue.ToString()))
                {
                    MessageBox.Show("Debe Seleccionar una Nivel de Autonomía", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cboIdNivelAutonomia_tt.Focus();
                    return;
                }

                if (cboIdMoneda_tt.SelectedIndex == -1)
                {
                    MessageBox.Show("Debe Seleccionar una Moneda", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cboIdMoneda_tt.Focus();
                    return;
                }

                if (decimal.Parse(txtnLineaImporte.Text.Trim()) == 0)
                {
                    MessageBox.Show("El Importe debe ser mayor a 0", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtnLineaImporte.Focus();
                    return;
                }

                DataSet dsTableBase = new DataSet();
                TableBaseBE TableBaseBE = new TableBaseBE()
                {
                    OPCION = 1,
                    USUARIO = General.General.GetCodigoUsuario,
                    Table_Id = cboIdNivelAutonomia_tt.SelectedValue.ToString()
                };

                dsTableBase = TableBaseBL.ProcesarTableBase(TableBaseBE);

                if (dsTableBase.Tables[0].Rows.Count > 0)
                {
                    decimal Valor = Convert.ToDecimal(dsTableBase.Tables[0].Rows[0]["Table_Value"]);
                    if (Valor > 0)
                    {
                        if (cboIdMoneda_tt.SelectedValue.ToString().Equals("1") || cboIdMoneda_tt.SelectedValue.ToString().Equals("00036"))
                        {
                            if (decimal.Parse(txtnNuevaLinea.Text.Trim()) > Valor)
                            {
                                MessageBox.Show("El Nivel de Autonomía debe ser de acuerdo a la Nueva Línea", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                txtnLineaImporte.Focus();
                                return;
                            }
                        }
                        else //Dolares
                        {
                            if ((decimal.Parse(txtnNuevaLinea.Text.Trim()) * decimal.Parse(txtTipoCambio.Text.Trim())) > Valor)
                            {
                                MessageBox.Show("El Nivel de Autonomía debe ser de acuerdo a la Nueva Línea", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                txtnLineaImporte.Focus();
                                return;
                            }
                        }
                    }
                }
                else { return; }

                if (TipoOperacion.ToString().Equals("R"))
                {
                    if (decimal.Parse(txtnNuevaLinea.Text.Trim()) < 0)
                    {
                        MessageBox.Show("La nuva Línea no puede ser menor a 0", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtnLineaImporte.Focus();
                        return;
                    }
                }

                PagadoraLineaBE PagadoraLineaBE = new PagadoraLineaBE()
                {
                    OPCION = 2,
                    USUARIO = General.General.GetCodigoUsuario,
                    IdPagadora = IdPagadora,
                    IdMoneda_tt = cboIdMoneda_tt.SelectedValue.ToString(),
                    nLinea = decimal.Parse(txtnNuevaLinea.Text),
                    nUtilizado = 0,
                    IdNivelAutonomia_tt = cboIdNivelAutonomia_tt.SelectedValue.ToString(),
                    dtFechaAprobacion = dtFechaAprobacion.Value,
                    IdMedio_tt = cboIdMedio_tt.SelectedValue.ToString(),
                    IdAnalistaCredito_tt = cboIdAnalistaCredito_tt.SelectedValue.ToString(),
                    iPlazo = !String.Empty.Equals(txtiPlazo.Text.Trim()) ? int.Parse(txtiPlazo.Text.Trim()) : 0,
                    dtFechaVencimiento = dtFechaVencimiento.Value,
                    vcObservaciones = txtvcObservaciones.Text.Trim(),
                    dtTipoCambio = General.General.gFechaOp,
                    nTipoCambio = Convert.ToDecimal(txtTipoCambio.Text),
                    IdEstadoLinea_tt = "00031"
                };

                PagadoraLineaBL.ProcesarPagadoraLinea(PagadoraLineaBE);
                MessageBox.Show("Se Proceso Correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboIdMoneda_tt_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboIdMoneda_tt.ValueMember.ToString() != string.Empty)
            {
                if (cboIdMoneda_tt.SelectedValue.ToString().Equals("00036"))
                {
                    lnlSimbolo.Text = "S/.";
                    lnlSimbolo1.Text = "S/.";
                    lnlSimbolo2.Text = "S/.";
                }
                else if (cboIdMoneda_tt.SelectedValue.ToString().Equals("00037"))
                {
                    lnlSimbolo.Text = "US$";
                    lnlSimbolo1.Text = "US$";
                    lnlSimbolo2.Text = "US$";
                }
                else
                {
                    lnlSimbolo.Text = "€";
                    lnlSimbolo1.Text = "€";
                    lnlSimbolo2.Text = "€";
                }
            }
        }

        private void txtnLineaImporte_TextChanged(object sender, EventArgs e)
        {
            if (TipoOperacion.ToString().Equals("I"))
            {
                txtnNuevaLinea.Text = (decimal.Parse(txtnLinea.Text.Trim()) + decimal.Parse(txtnLineaImporte.Text.Trim())).ToString("N2");
            }
            else
            {
                txtnNuevaLinea.Text = (decimal.Parse(txtnLinea.Text.Trim()) - decimal.Parse(txtnLineaImporte.Text.Trim())).ToString("N2");
            }
        }
        #endregion

        #region Metodos ---------------------------------------------
        private void LlenarCombos()
        {
            try
            {
                String Table_Id = "00035";
                TableBaseBE TableBaseBE = new TableBaseBE()
                {
                    OPCION = 1,
                    USUARIO = General.General.GetCodigoUsuario,
                    Table_Parent_Id = Table_Id
                };

                cboIdMoneda_tt.DataSource = TableBaseBL.ProcesarTableBase(TableBaseBE).Tables[0];
                cboIdMoneda_tt.DisplayMember = "Table_Name";
                cboIdMoneda_tt.ValueMember = "Table_Id";
                cboIdMoneda_tt_SelectedIndexChanged(new object(), new EventArgs());

                TableBaseBE.Table_Parent_Id = "00023";

                General.General.LlenarCombobox(cboIdNivelAutonomia_tt, "Table_Name", "Table_Id", TableBaseBL.ProcesarTableBase(TableBaseBE).Tables[0]);
                //cboIdNivelAutonomia_tt.DataSource = TableBaseBL.ProcesarTableBase(TableBaseBE).Tables[0];
                //cboIdNivelAutonomia_tt.DisplayMember = "Table_Name";
                //cboIdNivelAutonomia_tt.ValueMember = "Table_Id";

                TableBaseBE.Table_Parent_Id = "00027";
                General.General.LlenarCombobox(cboIdMedio_tt, "Table_Name", "Table_Id", TableBaseBL.ProcesarTableBase(TableBaseBE).Tables[0]);

                //cboIdMedio_tt.DataSource = TableBaseBL.ProcesarTableBase(TableBaseBE).Tables[0];
                //cboIdMedio_tt.DisplayMember = "Table_Name";
                //cboIdMedio_tt.ValueMember = "Table_Id";

                TableBaseBE.Table_Parent_Id = "00039";
                General.General.LlenarCombobox(cboIdAnalistaCredito_tt, "Table_Name", "Table_Id", TableBaseBL.ProcesarTableBase(TableBaseBE).Tables[0]);

                //cboIdAnalistaCredito_tt.DataSource = TableBaseBL.ProcesarTableBase(TableBaseBE).Tables[0];
                //cboIdAnalistaCredito_tt.DisplayMember = "Table_Name";
                //cboIdAnalistaCredito_tt.ValueMember = "Table_Id";
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
                DataSet dsPagadoraLinea = new DataSet();
                PagadoraLineaBE PagadoraLineaBE = new PagadoraLineaBE()
                {
                    OPCION = 1,
                    USUARIO = General.General.GetCodigoUsuario,
                    IdPagadora = IdPagadora
                };

                dsPagadoraLinea = PagadoraLineaBL.ProcesarPagadoraLinea(PagadoraLineaBE);

                if (dsPagadoraLinea.Tables[0].Rows.Count > 0)
                {
                    cboIdMoneda_tt.SelectedValue = dsPagadoraLinea.Tables[0].Rows[0]["IdMoneda_tt"];
                    txtnLinea.Text = Convert.ToDecimal(dsPagadoraLinea.Tables[0].Rows[0]["nLinea"]).ToString("N2");
                    txtnNuevaLinea.Text = Convert.ToDecimal(dsPagadoraLinea.Tables[0].Rows[0]["nLinea"]).ToString("N2");
                    cboIdNivelAutonomia_tt.SelectedValue = dsPagadoraLinea.Tables[0].Rows[0]["IdNivelAutonomia_tt"];
                    dtFechaAprobacion.Value = Convert.ToDateTime(dsPagadoraLinea.Tables[0].Rows[0]["dtFechaAprobacion"]);
                    cboIdMedio_tt.SelectedValue = dsPagadoraLinea.Tables[0].Rows[0]["IdMedio_tt"];
                    txtiPlazo.Text = dsPagadoraLinea.Tables[0].Rows[0]["iPlazo"].ToString();
                    txtvcObservaciones.Text = dsPagadoraLinea.Tables[0].Rows[0]["vcObservaciones"].ToString();
                    dtFechaVencimiento.Value = Convert.ToDateTime(dsPagadoraLinea.Tables[0].Rows[0]["dtFechaVencimiento"]);
                    txtTipoCambio.Text = Convert.ToDecimal(dsPagadoraLinea.Tables[0].Rows[0]["nTipoCambio"]).ToString("0.00");
                    cboIdMoneda_tt_SelectedIndexChanged(new object(), new EventArgs());
                }
                else
                {
                    //Obtener el tipo de cambio del dia
                    DataSet dsTC = new DataSet();
                    TableBaseBE TableBaseBE = new TableBaseBE()
                    {
                        OPCION = 6,
                        USUARIO = General.General.GetUsuario,
                    };
                    dsTC = TableBaseBL.ProcesarTableBase(TableBaseBE);

                    if (dsTC.Tables[0].Rows.Count > 0)
                    {
                        txtTipoCambio.Text = Convert.ToDecimal(dsTC.Tables[0].Rows[0]["nTipoCambio"]).ToString("0.00");
                    }
                }
                txtiPlazo.Text = "365";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        private void txtiPlazo_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(dtFechaAprobacion.Text) && !string.IsNullOrEmpty(txtiPlazo.Text.Trim()))
                {
                    Double Plazo = Convert.ToDouble(txtiPlazo.Text);
                    dtFechaVencimiento.Value = dtFechaAprobacion.Value.AddDays(Plazo);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}