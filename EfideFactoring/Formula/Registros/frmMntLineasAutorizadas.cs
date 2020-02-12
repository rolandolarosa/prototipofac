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
    public partial class frmMntLineasAutorizadas : FormulaBase.frmMntFiltro
    {
        SocioLineaBL SocioLineaBL = new SocioLineaBL();
        private DataTable dt = new DataTable();
        public frmMntLineasAutorizadas()
        {
            InitializeComponent();
        }
         
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Formula.Registros.frmMntLineasAutorizadasDato ofrmMntLineaAutorizadasDato = new Formula.Registros.frmMntLineasAutorizadasDato();
            ofrmMntLineaAutorizadasDato.Operacion = "N";
            ofrmMntLineaAutorizadasDato.ShowDialog();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
           try
            {
                DataSet ds = new DataSet();
                SocioLineaBE SocioLineaBE = new SocioLineaBE()
                {
                    OPCION = 1,
                    USUARIO = General.General.GetUsuario,
                    IdSocio_Dsc = TextBoxX1.Text.Trim(),
                    dtRegistro = dtInicio.Value,
                    dtVencimiento = dtFin.Value
                };

                ds = SocioLineaBL.ProcesarSocioLinea(SocioLineaBE);
                dgvLineasAutorizadas.DataSource = ds.Tables[0];
                lblRegistros.Text = ds.Tables[0].Rows.Count.ToString() + " registro(s)";
                dt = ds.Tables[0];

                foreach (DataGridViewRow row in dgvLineasAutorizadas.Rows)
                {
                    if ( Convert.ToInt32(row.Cells["nPorUsoLin"].Value) < 75) // No Vencido
                    {
                    }
                    else // VEncido
                    {
                        row.DefaultCellStyle.ForeColor = Color.FromName(General.General.GetColorAnulado);
                    }
                }
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
                Formula.Registros.frmMntLineasAutorizadasDato ofrmMntSocioLineaDato = new Formula.Registros.frmMntLineasAutorizadasDato();
                ofrmMntSocioLineaDato.Operacion = "M";
                ofrmMntSocioLineaDato.Codigo = dgvLineasAutorizadas.CurrentRow.Cells["IdLinea"].Value.ToString();
                ofrmMntSocioLineaDato.ShowDialog();
                btnBuscar.PerformClick();
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
                if (dgvLineasAutorizadas.RowCount > 0)
                {
                    dialogResult = MessageBox.Show("Seguro de Eliminar ...:" + dgvLineasAutorizadas.CurrentRow.Cells["IdSocio_Dsc"].Value.ToString().Trim(), "Confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dialogResult == DialogResult.Yes)
                    {
                        SocioLineaBE SocioLineaBE = new SocioLineaBE()
                        {
                            OPCION = 3,
                            USUARIO = General.General.GetUsuario,
                            IdLinea = dgvLineasAutorizadas.CurrentRow.Cells["IdLinea"].Value.ToString(),
                        };

                        SocioLineaBL.ProcesarSocioLinea(SocioLineaBE);
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

        private void btnExcel_Click(object sender, EventArgs e)
        {
            try
            {
                if (dt.Rows.Count > 0)
                {
                    General.msgHelper.ExportToExcel(dt);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}