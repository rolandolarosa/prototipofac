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

namespace EfideFactoring.Formula.Legal
{
    public partial class frmMntSolicitudDocumento : FormulaBase.frmMntDato
    {
        public string _RUC = string.Empty;
        public string _Entidad = string.Empty;
        public frmMntSolicitudDocumento()
        {
            InitializeComponent();
        }

        #region Eventos
        private void frmMntSolicitudDocumento_Load(object sender, EventArgs e)
        {
            try
            {
                lblEntidad.Text = _RUC.Trim() + " - " + _Entidad;
                LlenarCombos();
                CargarDatos();

                if (Operacion.Equals("C"))
                {
                    btnAgregar.Visible = false;
                    cboIdDocumento.Enabled = false;
                    txtiPlazo.Enabled = false;
                    txtnTEA.Enabled = false;
                    dgvDocumento.Columns["btnEliminar"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(cboIdDocumento.SelectedValue.ToString()))
                {
                    MessageBox.Show("Debe seleccionar el documento", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                if (string.IsNullOrEmpty(txtiPlazo.Text.Trim()))
                {
                    MessageBox.Show("Ingresar el plazo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                if (string.IsNullOrEmpty(txtnTEA.Text.Trim()))
                {
                    MessageBox.Show("Ingresar la TEA", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                btnAceptar.Enabled = false;
                SolicitudDocumentoBE oEntity = new SolicitudDocumentoBE();
                oEntity.OPCION = 2;
                oEntity.USUARIO = General.General.GetUsuario;
                oEntity.IdSolicitud = Codigo;
                oEntity.IdDocumento = cboIdDocumento.SelectedValue.ToString();
                oEntity.iPlazo = !string.IsNullOrEmpty(txtiPlazo.Text) ? int.Parse(txtiPlazo.Text) : 0;
                oEntity.nTEA = !string.IsNullOrEmpty(txtnTEA.Text) ? decimal.Parse(txtnTEA.Text) : 0;
                new SolicitudDocumentoBL().ProcesarSolicitudDocumento(oEntity);
                
                cboIdDocumento.SelectedValue = string.Empty;
                txtiPlazo.Clear();
                txtnTEA.Clear();

                CargarDatos();
                btnAceptar.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvDocumento_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DialogResult dialogResult = 0;
            try
            {
                if (e.ColumnIndex < 0) return;
                if (e.RowIndex == -1) return;

                if (dgvDocumento.Columns[e.ColumnIndex].Name.Equals("btnEliminar"))
                {
                    dialogResult = MessageBox.Show("Seguro de eliminar el documento: " + dgvDocumento.CurrentRow.Cells["IdDocumento_Dsc"].Value.ToString().Trim(), "Confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dialogResult == DialogResult.Yes)
                    {
                        SolicitudDocumentoBE oEntity = new SolicitudDocumentoBE();
                        oEntity.OPCION = 3;
                        oEntity.USUARIO = General.General.GetCodigoUsuario;
                        oEntity.IdSolicitud = Codigo;
                        oEntity.IdDocumento = dgvDocumento.CurrentRow.Cells["IdDocumento"].Value.ToString();
                        new SolicitudDocumentoBL().ProcesarSolicitudDocumento(oEntity);
                        CargarDatos();
                        MessageBox.Show("Se Proceso Correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtiPlazo_KeyPress(object sender, KeyPressEventArgs e)
        {
            General.General.Validar_Enteros(e);
        }

        private void txtnTEA_KeyPress(object sender, KeyPressEventArgs e)
        {
            General.General.Validar_Decimal(e, txtnTEA.Text);
        }
        #endregion

        #region Metodos
        private void LlenarCombos()
        {
            try
            {
                DocumentoBE oEntity = new DocumentoBE()
                {
                    OPCION = 1,
                    USUARIO = General.General.GetUsuario
                };

                General.General.LlenarCombobox(cboIdDocumento, "vDocumento", "IdDocumento", new DocumentoBL().ProcesarDocumento(oEntity).Tables[0]);
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
                SolicitudDocumentoBE oEntity = new SolicitudDocumentoBE();
                oEntity.OPCION = 1;
                oEntity.USUARIO = General.General.GetUsuario;
                oEntity.IdSolicitud = Codigo;
                DataSet ds = new SolicitudDocumentoBL().ProcesarSolicitudDocumento(oEntity);
                dgvDocumento.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
    }
}