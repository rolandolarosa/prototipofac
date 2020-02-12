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

namespace EfideFactoring.Formula.GestionPagadora
{
    public partial class frmBitacoraPagadora : FormulaBase.frmMntDato
    {
        public frmBitacoraPagadora()
        {
            InitializeComponent();
        }

        private void frmBitacoraPagadora_Load(object sender, EventArgs e)
        {
            try
            {
                bool bGestor = false;
                LlenarCombos(ref bGestor);
                CargarBitacoraComercial();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarBitacoraComercial()
        {
            try
            {
                DataSet dsBitacoraComercial = new DataSet();
                BitacoraComercialBE BitacoraComercialBE = new BitacoraComercialBE()
                {
                    OPCION = 6,
                    USUARIO = General.General.GetUsuario,
                    IdSocio = Codigo,
                    IdGestor = cboEjecutivo.SelectedValue.ToString(),
                    FlgOrigen = 0 // Gestion Pagadoras
                };

                dsBitacoraComercial = new BitacoraComercialBL().ProcesarBitacoraComercial(BitacoraComercialBE);
                dgvBitacoraComercial.DataSource = dsBitacoraComercial.Tables[0];
                lblRegistros.Text = dsBitacoraComercial.Tables[0].Rows.Count.ToString() + " registro(s)";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LlenarCombos(ref bool bGestor)
        {
            bGestor = false;
            try
            {
                DataSet dsGestor = new GestionComercialBL().ProcesarGestionComercial(0, 0, "", "", 0, 3);
                General.General.LlenarCombobox(cboEjecutivo, "nombreCompleto", "gestorID", dsGestor.Tables[0], true);

                if (!string.IsNullOrEmpty(General.General.GetIdGestor.Trim()))
                {
                    cboEjecutivo.SelectedValue = General.General.GetIdGestor;
                    bGestor = true;
                }
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
                CargarBitacoraComercial();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGestionPagadoras_Click(object sender, EventArgs e)
        {
            try
            {
                frmGestionPagadora ofrm = new frmGestionPagadora();
                ofrm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvBitacoraComercial_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex < 0) return;
                if (e.RowIndex == -1) return;
                if (dgvBitacoraComercial.Columns[e.ColumnIndex].Name == "btnAtender")
                {
                    EfideFactoring.Formula.GestionComercial.frmMntBitacoraComercialDato ofrm = new EfideFactoring.Formula.GestionComercial.frmMntBitacoraComercialDato();
                    ofrm.Operacion = "M";
                    ofrm.OrigenAtender = 1;
                    ofrm.IdBitacoraComercialGenerada = dgvBitacoraComercial.Rows[e.RowIndex].Cells["IdBitacoraComercial"].Value.ToString(); // dgvBitacoraComercial.CurrentRow.Cells["IdBitacoraComercial"].Value.ToString();
                    ofrm.Codigo = dgvBitacoraComercial.Rows[e.RowIndex].Cells["IdBitacoraComercial"].Value.ToString(); // dgvBitacoraComercial.CurrentRow.Cells["IdBitacoraComercial"].Value.ToString();
                    ofrm._IdSocio = dgvBitacoraComercial.Rows[e.RowIndex].Cells["IdSocio"].Value.ToString(); //dgvBitacoraComercial.CurrentRow.Cells["IdSocio"].Value.ToString();
                    ofrm._NombreSocio = dgvBitacoraComercial.Rows[e.RowIndex].Cells["vcSocio"].Value.ToString(); //dgvBitacoraComercial.CurrentRow.Cells["vcSocio"].Value.ToString();
                    ofrm._NombreGestor = cboEjecutivo.Text;
                    ofrm._IdGestor = cboEjecutivo.SelectedValue.ToString();
                    ofrm._FlgOrigen = 0;
                    ofrm._FlgBitacoraComercial = 0;
                    ofrm.ShowDialog();
                    CargarBitacoraComercial();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvBitacoraComercial_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                DataGridViewRow row = dgvBitacoraComercial.Rows[e.RowIndex];// get you required index
                // check the cell value under your specific column and then you can toggle your colors
                row.DefaultCellStyle.ForeColor = Color.FromName(row.Cells["ColorRow"].Value.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}