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

namespace EfideFactoring.Formula.Registros
{
    public partial class frmMntLineaControl : FormulaBase.frmMntDato
    {
        TableBaseBL TableBaseBL = new TableBaseBL();
        SocioLineaBL SocioLineaBL = new SocioLineaBL();
        public string IdLinea = string.Empty;
        public string TipoOperacion = String.Empty;

        public frmMntLineaControl()
        {
            InitializeComponent();
        }

        private void frmMntLineaControl_Load(object sender, EventArgs e)
        {
            LlenarCombos();
            CargarDatos();
        }

        #region Metodos ---------------------------------------------
        private void LlenarCombos()
        {
            string Table_Id = "00035";
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
        }

        private void CargarDatos()
        {
            try
            {
                DataSet ds = new DataSet();
                SocioLineaBE oSocioLineaBE = new SocioLineaBE()
                {
                    OPCION = 1,
                    USUARIO = General.General.GetCodigoUsuario,
                    IdLinea = IdLinea
                };

                ds = SocioLineaBL.ProcesarSocioLinea(oSocioLineaBE);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    cboIdMoneda_tt.SelectedValue = ds.Tables[0].Rows[0]["IdMoneda_tt"].ToString() == "" ? "00036" : ds.Tables[0].Rows[0]["IdMoneda_tt"].ToString();
                    txtnLinea.Text = Convert.ToDecimal(ds.Tables[0].Rows[0]["nImporte"]).ToString("N2");
                    txtnNuevaLinea.Text = Convert.ToDecimal(ds.Tables[0].Rows[0]["nImporte"]).ToString("N2");
                    if (Convert.ToDecimal(ds.Tables[0].Rows[0]["nImporte"]) > 0) { cboIdMoneda_tt.Enabled = false; }
                    cboIdMoneda_tt_SelectedIndexChanged(new object(), new EventArgs());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Eventos ---------------------------------------------
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

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(dtFechaVencimiento.Text)) {
                    MessageBox.Show("Ingresar una fecha de vencimiento", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtnLinea.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(txtnLinea.Text.Trim()))
                {
                    MessageBox.Show("Debe Ingresar una Línea de Crédito", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtnLinea.Focus();
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

                if (TipoOperacion.ToString().Equals("R"))
                {
                    if (decimal.Parse(txtnNuevaLinea.Text.Trim()) < 0)
                    {
                        MessageBox.Show("La nuva Línea no puede ser menor a 0", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtnLineaImporte.Focus();
                        return;
                    }
                }

                SocioLineaBE oSocioLineaBE = new SocioLineaBE()
                {
                    OPCION = 6,
                    USUARIO = General.General.GetCodigoUsuario,
                    IdLinea = IdLinea,
                    IdMoneda_tt = cboIdMoneda_tt.SelectedValue.ToString(),
                    nImporte = decimal.Parse(txtnNuevaLinea.Text),
                    dtVencimiento = dtFechaVencimiento.Value
                };

                SocioLineaBL.ProcesarSocioLinea(oSocioLineaBE);
                MessageBox.Show("Se Proceso Correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
    }
}