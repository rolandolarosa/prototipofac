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

namespace EfideFactoring.Formula.Movimiento
{
    public partial class frmMntMovimientoDato : FormulaBase.frmMntDato
    {
        private string IdReferencia = string.Empty;
        public frmMntMovimientoDato()
        {
            InitializeComponent();
        }

        private void frmMntMovimientoDato_Load(object sender, EventArgs e)
        {
            try
            {
                CargarCombos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarCombos()
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
                General.General.LlenarCombobox(cboIdMoneda_tt, "Table_Name", "Table_Id", new TableBaseBL().ProcesarTableBase(TableBaseBE).Tables[0]);

                DataTable dt = new DataTable();
                dt.Columns.Add("Value");
                dt.Columns.Add("Descripcion");

                DataRow dr = dt.NewRow();
                dr = dt.NewRow();
                dr["Value"] = "";
                dr["Descripcion"] = "-- Seleccione --";
                dt.Rows.InsertAt(dr, 0);

                DataRow dr1 = dt.NewRow();
                dr1["Value"] = "DNI";
                dr1["Descripcion"] = "DNI";
                dt.Rows.InsertAt(dr1, 0);

                DataRow dr2 = dt.NewRow();
                dr2 = dt.NewRow();
                dr2["Value"] = "Ruc";
                dr2["Descripcion"] = "Ruc";
                dt.Rows.InsertAt(dr2, 0);

                cboTipoDocumento.DataSource = dt;
                cboTipoDocumento.DisplayMember = "Descripcion";
                cboTipoDocumento.ValueMember = "Value";
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
                IdReferencia = ofrmBusquedaSocio.CodSocio.Trim();
                txtRazonSocial.Text = ofrmBusquedaSocio.RazorSocialSocio.Trim();
                cboTipoDocumento.SelectedValue = ofrmBusquedaSocio.DocumentoSocio.Trim();
                txtNroDoc.Text = ofrmBusquedaSocio.RUCSocio.Trim();
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
                if (string.IsNullOrEmpty(txtRazonSocial.Text.Trim()))
                {
                    MessageBox.Show("Debe ingresar el nombre o razón social", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtRazonSocial.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(txtNroDoc.Text.Trim()))
                {
                    MessageBox.Show("Debe ingresar el número de documento", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtNroDoc.Focus();
                    return;
                }

                if (dtFechaMovimiento.Value == DateTime.MinValue)
                {
                    MessageBox.Show("Debe ingresar la fecha del depósito", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    dtFechaMovimiento.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(cboIdMoneda_tt.SelectedValue.ToString()))
                {
                    MessageBox.Show("Debe seleccionar la moneda", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cboIdMoneda_tt.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(txtImporte.Text))
                {
                    MessageBox.Show("Ingrese un importe", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtImporte.Focus();
                    return;
                }

                MovimientoBE oEntity = new MovimientoBE()
                {
                    OPCION = 2,
                    USUARIO = General.General.GetCodigoUsuario, 
                    IdMovimiento = "",
                    IdTipo_tt = "1", // Depositos
                    IdReferencia = IdReferencia,
                    RazonSocial = txtRazonSocial.Text,
                    TipoDocumento = cboTipoDocumento.SelectedValue.ToString(),
                    NroDoc = txtNroDoc.Text,
                    FechaMovimiento = dtFechaMovimiento.Value,
                    IdMoneda_tt = cboIdMoneda_tt.SelectedValue.ToString(),
                    Importe = Convert.ToDecimal(txtImporte.Text),
                    IdEstado_tt = "1", // Pendiente
                    Comentario = txtComentario.Text
                };

                new MovimientoBL().ProcesarMovimiento(oEntity);
                MessageBox.Show("Se Proceso Correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtImporte_KeyPress(object sender, KeyPressEventArgs e)
        {
            General.General.Validar_Decimal(e, txtImporte.Text);
        }   
    }
}