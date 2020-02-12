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

namespace EfideFactoring.Formula.Cobranza
{
    public partial class frmMntBaseNegativaDato : FormulaBase.frmMntDato
    {
        public frmMntBaseNegativaDato()
        {
            InitializeComponent();
        }

        private void frmMntBaseNegativaDato_Load(object sender, EventArgs e)
        {
            try
            {
                LlenarCombos();
                if (Operacion.Equals("M"))
                {
                    txtIdBaseNegativa.Text = Codigo;
                    CargarDatos();
                }
                else if (Operacion.Equals("N"))
                {
                    txtdtRegistro.Text = DateTime.Now.ToString("dd/MM/yyyy");
                }
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
                DataSet dsCartera = new DataSet();
                BaseNegativaBE oEntity = new BaseNegativaBE()
                {
                    OPCION = 1,
                    USUARIO = General.General.GetCodigoUsuario,
                    IdBaseNegativa = txtIdBaseNegativa.Text,
                };

                dsCartera = new BaseNegativaBL().ProcesarBaseNegativa(oEntity);

                if (dsCartera.Tables[0].Rows.Count > 0)
                {
                    txtdtRegistro.Text = Convert.ToDateTime(dsCartera.Tables[0].Rows[0]["dtRegistro"].ToString()).ToString("dd/MM/yyyy");
                    txtvApePaterno.Text = dsCartera.Tables[0].Rows[0]["vApePaterno"].ToString();
                    txtvApeMaterno.Text = dsCartera.Tables[0].Rows[0]["vApeMaterno"].ToString();
                    txtvNombre.Text = dsCartera.Tables[0].Rows[0]["vNombre"].ToString();
                    cboIdTipoDocumento_tt.SelectedValue = dsCartera.Tables[0].Rows[0]["IdTipoDocumento_tt"].ToString();
                    txtvNroDocumento.Text = dsCartera.Tables[0].Rows[0]["vNroDocumento"].ToString();
                    txtMotivo.Text = dsCartera.Tables[0].Rows[0]["Motivo"].ToString();
                    txtObservacion.Text = dsCartera.Tables[0].Rows[0]["Observacion"].ToString();
                }
                else
                {
                    MessageBox.Show("Este candidato no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
                String Table_Id = "00134"; //Tipo Documento
                TableBaseBE TableBaseBE = new TableBaseBE()
                {
                    OPCION = 1,
                    USUARIO = General.General.GetCodigoUsuario,
                    Table_Parent_Id = Table_Id
                };
                General.General.LlenarCombobox(cboIdTipoDocumento_tt, "Table_Name", "Table_Id", new TableBaseBL().ProcesarTableBase(TableBaseBE).Tables[0]);
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
                if (string.IsNullOrEmpty(txtvApePaterno.Text.Trim()))
                {
                    MessageBox.Show("Ingresar un apellido paterno", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtvApePaterno.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(cboIdTipoDocumento_tt.SelectedValue.ToString()))
                {
                    MessageBox.Show("Se debe seleccionar un tipo de documento", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cboIdTipoDocumento_tt.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(txtvNroDocumento.Text.Trim()))
                {
                    MessageBox.Show("Ingresar un número de documento", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtvNroDocumento.Focus();
                    return;
                }

                BaseNegativaBE oEntity = new BaseNegativaBE()
                {
                    USUARIO = General.General.GetCodigoUsuario,
                    OPCION = 2,
                    IdBaseNegativa = txtIdBaseNegativa.Text,
                    vApePaterno = txtvApePaterno.Text,
                    vApeMaterno = txtvApeMaterno.Text,
                    vNombre = txtvNombre.Text,
                    IdTipoDocumento_tt = cboIdTipoDocumento_tt.SelectedValue.ToString(),
                    vNroDocumento = txtvNroDocumento.Text,
                    Motivo = txtMotivo.Text,
                    Observacion = txtObservacion.Text
                };
                new BaseNegativaBL().ProcesarBaseNegativa(oEntity);

                MessageBox.Show("Se Proceso Correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}