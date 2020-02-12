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

namespace EfideFactoring.Formula.GestionComercial
{
    public partial class frmMntTelefono : FormulaBase.frmMntDato
    {
        public string _IdSocio = string.Empty;
        public frmMntTelefono()
        {
            InitializeComponent();
        }

        private void frmMntTelefono_Load(object sender, EventArgs e)
        {
            try
            {
                LlenarCombos();
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
                TelefonoTDBE oEntity = new TelefonoTDBE();
                oEntity.OPCION = 3;
                oEntity.USUARIO = General.General.GetUsuario;
                DataTable dt = new DataTable();
                dt = new TelefonoTDBL().ProcesarTelefonoTDDA(oEntity).Tables[0];

                DataRow dr;
                dr = dt.NewRow();
                dr["varCodigo"] = 0;
                dr["varDescripcion"] = "--Seleccionar--";
                dt.Rows.InsertAt(dr, 0);

                cbovalorOrigenTeleID.DataSource = dt;
                cbovalorOrigenTeleID.DisplayMember = "varDescripcion";
                cbovalorOrigenTeleID.ValueMember = "varCodigo";

                oEntity.OPCION = 4;
                DataTable dtTipo = new DataTable();
                dtTipo = new TelefonoTDBL().ProcesarTelefonoTDDA(oEntity).Tables[0];

                DataRow drTipo;
                drTipo = dtTipo.NewRow();
                drTipo["varCodigo"] = 0;
                drTipo["varDescripcion"] = "--Seleccionar--";
                dtTipo.Rows.InsertAt(drTipo, 0);

                cbovalorTipoID.DataSource = dtTipo;
                cbovalorTipoID.DisplayMember = "varDescripcion";
                cbovalorTipoID.ValueMember = "varCodigo";
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
                if (string.IsNullOrEmpty(cbovalorTipoID.SelectedValue.ToString()))
                {
                    MessageBox.Show("Seleccione un tipo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                if (string.IsNullOrEmpty(cbovalorOrigenTeleID.SelectedValue.ToString()))
                {
                    MessageBox.Show("Seleccione un origen", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                if (string.IsNullOrEmpty(txtteleTelefono.Text.Trim()))
                {
                    MessageBox.Show("Ingrese el número de teléfono", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                TelefonoTDBE oEntity = new TelefonoTDBE();
                oEntity.OPCION = 2;
                oEntity.USUARIO = General.General.GetUsuario;
                oEntity.IdSocio = _IdSocio;
                oEntity.valorTipoID = string.IsNullOrEmpty(cbovalorTipoID.SelectedValue.ToString()) ? 0 : int.Parse(cbovalorTipoID.SelectedValue.ToString());
                oEntity.valorOrigenTeleID = string.IsNullOrEmpty(cbovalorOrigenTeleID.SelectedValue.ToString()) ? 0 : int.Parse(cbovalorOrigenTeleID.SelectedValue.ToString());
                oEntity.teleTelefono = txtteleTelefono.Text.Trim();
                new TelefonoTDBL().ProcesarTelefonoTDDA(oEntity);

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