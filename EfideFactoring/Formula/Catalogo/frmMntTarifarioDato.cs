using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EfideFactoringBE;
using EfideFactoringBL;

namespace EfideFactoring.Formula.Catalogo
{
    public partial class frmMntTarifarioDato : EfideFactoring.FormulaBase.frmMntDato
    {
        TarifarioBL TarifarioBL = new TarifarioBL();
        TableBaseBL TableBaseBL = new TableBaseBL();

        public frmMntTarifarioDato()
        {
            InitializeComponent();
        }

        /* Eventos */
        /* Load */
        /* Cargar Datos */
        private void CargarDatos()
        {
            try
            {
                DataSet dsTarifario = new DataSet();
                TarifarioBE TarifarioBE = new TarifarioBE()
                {
                    OPCION = 1,
                    USUARIO = General.General.GetCodigoUsuario,
                    IdTarifario = Codigo,   //txtIdTarifario.Text,
                };
                dsTarifario = TarifarioBL.ProcesarTarifario(TarifarioBE);
                if (dsTarifario.Tables[0].Rows.Count > 0)
                {
                    cboConcepto.SelectedValue = dsTarifario.Tables[0].Rows[0]["tipCxcID"].ToString();
                    cboIdTipoCalculo_tt.SelectedValue = dsTarifario.Tables[0].Rows[0]["IdTipoCalculo_tt"].ToString();
                    if (String.Equals(dsTarifario.Tables[0].Rows[0]["IdCalculo_tt"].ToString(),"00096")) //Por Porcentaje
                    {
                        rbPorcentaje.Checked = true;
                        gpMonto.Enabled = false;
                        txtPorMonto.Text = Convert.ToDecimal(dsTarifario.Tables[0].Rows[0]["PorMonto"]).ToString("N3");
                        cboPorConcepto.SelectedValue = dsTarifario.Tables[0].Rows[0]["PorConcepto_tt"].ToString();
                    }
                    else if (String.Equals(dsTarifario.Tables[0].Rows[0]["IdCalculo_tt"].ToString(),"00097")) //Por Monto
                    {
                        rbMonto.Checked = true;
                        gpPorcentaje.Enabled = false;
                        txtMonto.Text = Convert.ToDecimal(dsTarifario.Tables[0].Rows[0]["Monto"]).ToString("N3");
                    }
                    else //Sin Tipo
                    {}
                    cboFrecuencia.SelectedValue = dsTarifario.Tables[0].Rows[0]["IdFrecuencia_tt"].ToString();
                    chkTransferencia.CheckValue = dsTarifario.Tables[0].Rows[0]["bTransferencia"];
                }
                else
                {
                    MessageBox.Show("Este .... no Existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /* LLenar Combobox */
        
        private void LlenarCombos()
        {
            try
            {
                //cboConcepto
                TarifarioBE TarifarioBE = new TarifarioBE()
                {
                    OPCION = 5,
                    USUARIO = General.General.GetUsuario
                };
                General.General.LlenarCombobox(cboConcepto, "tipCxcNombre", "tipCxcID", TarifarioBL.ProcesarTarifario(TarifarioBE).Tables[0]); 
                                
                // Combos de Tabla Base
                String Table_Id = "00102"; // Porcentaje Conceptos
                TableBaseBE TableBaseBE = new TableBaseBE()
                {
                    OPCION = 1,
                    USUARIO = General.General.GetCodigoUsuario,
                    Table_Parent_Id = Table_Id
                };
                General.General.LlenarCombobox(cboPorConcepto, "Table_Name", "Table_Id", TableBaseBL.ProcesarTableBase(TableBaseBE).Tables[0]);

                TableBaseBE.Table_Parent_Id = "00098"; // Frecuencia
                General.General.LlenarCombobox(cboFrecuencia, "Table_Name", "Table_Id", TableBaseBL.ProcesarTableBase(TableBaseBE).Tables[0]);

                TableBaseBE.Table_Parent_Id = "00035"; // Moneda
                General.General.LlenarCombobox(cboMoneda, "Table_Name", "Table_Id", TableBaseBL.ProcesarTableBase(TableBaseBE).Tables[0]);

                TableBaseBE.Table_Parent_Id = "00126"; // Tipo de Calculo
                General.General.LlenarCombobox(cboIdTipoCalculo_tt, "Table_Name", "Table_Id", TableBaseBL.ProcesarTableBase(TableBaseBE).Tables[0]);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rbPorcentaje_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPorcentaje.Checked == true)
            {
                gpMonto.Enabled = false;
                gpPorcentaje.Enabled = true;
            }
        }

        private void rbMonto_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMonto.Checked == true)
            {
                gpMonto.Enabled = true;
                gpPorcentaje.Enabled = false;
            }
        }

        private void frmMntTarifarioDato_Load(object sender, EventArgs e)
        {
            try
            {
                LlenarCombos();
                if (Operacion.Equals("N"))
                {
                    rbMonto.Checked = true;
                }
                else if (Operacion.Equals("M"))
                {
                    CargarDatos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboConcepto.SelectedIndex < 1)
                {
                    MessageBox.Show("Se debe Ingresar un Concepto", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cboConcepto.Focus();
                    return;
                }

                if (cboIdTipoCalculo_tt.SelectedIndex < 1)
                {
                    MessageBox.Show("Se debe seleccionar un tipo de calculo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cboIdTipoCalculo_tt.Focus();
                    return;
                }

                if (cboFrecuencia.SelectedIndex < 1)
                {
                    MessageBox.Show("Se debe seleccionar una Frecuencia", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cboFrecuencia.Focus();
                    return;
                }

                if (rbMonto.Checked == true)
                {
                    if (Convert.ToDouble(txtMonto.Text) < 0)
                    {
                        MessageBox.Show("Debe ingresar un monto mayor a CERO", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtMonto.Focus();
                    }
                }

                if (rbPorcentaje.Checked == true)
                {
                    if (Convert.ToDouble(txtPorMonto.Text) < 0)
                    {
                        MessageBox.Show("Debe ingresar un porcentaje mayor a CERO", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtPorMonto.Focus();
                    }
                    if (cboPorConcepto.SelectedIndex < 1)
                    {
                        MessageBox.Show("Debe seleccionar Ingresar un Concepto", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        cboPorConcepto.Focus();
                        return;
                    }
                }

                TarifarioBE TarifarioBE = new TarifarioBE()
                {
                    USUARIO = General.General.GetCodigoUsuario,
                    OPCION = 2,
                    IdTarifario = this.Codigo,
                    tipCxcID = cboConcepto.SelectedValue.ToString(),
                    IdTipoCalculo_tt = cboIdTipoCalculo_tt.SelectedValue.ToString(),
                    IdCalculo_tt = ((rbPorcentaje.Checked) == true ? "00096" : "00097"),
                    PorMonto = String.IsNullOrEmpty(txtPorMonto.Text.Trim()) ? 0 : Convert.ToDecimal(txtPorMonto.Text),
                    PorConcepto_tt = cboPorConcepto.SelectedValue.ToString(),
                    Monto = String.IsNullOrEmpty(txtMonto.Text.Trim()) ? 0 : Convert.ToDecimal(txtMonto.Text),
                    IdFrecuencia_tt = cboFrecuencia.SelectedValue.ToString(),
                    bTransferencia = chkTransferencia.Checked ? true : false,
                };

                DataSet dsTarifario = new DataSet();
                dsTarifario = TarifarioBL.ProcesarTarifario(TarifarioBE);
                MessageBox.Show("Se Proceso Correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboConcepto_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataSet dsCxC = new DataSet();
                TarifarioBE TarifarioBE = new TarifarioBE()
                {
                    OPCION = 6,
                    USUARIO = General.General.GetCodigoUsuario,
                    tipCxcID = cboConcepto.SelectedValue.ToString(),
                };

                dsCxC = TarifarioBL.ProcesarTarifario(TarifarioBE);

                if (dsCxC.Tables[0].Rows.Count > 0)
                {
                    cboMoneda.SelectedValue = dsCxC.Tables[0].Rows[0]["valorMonedaID"].ToString().Equals("1") ? "00036" : "00037";  // Soles:Dolares
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
