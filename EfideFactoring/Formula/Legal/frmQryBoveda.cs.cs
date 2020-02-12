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

namespace EfideFactoring.Formula.Legal
{
    public partial class frmQryBoveda : FormulaBase.frmMntFiltro
    {
        public int Origen = 1;
        public frmQryBoveda()
        {
            InitializeComponent();
        }

        private void frmQryBoveda_Load(object sender, EventArgs e)
        {
            try
            {
                CargarDatos();

                if (Origen == 1) // Ejecutivo
                {
                    this.TitleText = "Ejecutivo Legal";
                    dgvBoveda.Columns[4].Visible = false;
                    dgvBoveda.Columns[5].Visible = false;
                    dgvBoveda.Columns[6].Visible = false;
                    dgvBoveda.Columns[7].Visible = false;
                    btnEditar.Visible = true;
                }
                else
                {
                    btnVer.Visible = true;
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
                CargarDatos();
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
                BovedaBE oEntity = new BovedaBE();
                oEntity.OPCION = 1;
                oEntity.USUARIO = General.General.GetCodigoUsuario;
                oEntity.vRazonSocialSocio = TextBoxX1.Text;
                oEntity.FlgVerHistoricos = chkVerHistoricos.Checked ? 1 : 0;
                //oEntity.IdPersonaSolicitud = Origen == 1 ? General.General.GetUsuario : string.Empty;
                oEntity.IdEstado_tt = Origen == 1 ? "00397" : "00398";
                DataSet ds = new BovedaBL().ProcesarBoveda(oEntity);
                dgvBoveda.DataSource = ds.Tables[0];

                lblRegistros.Text = ds.Tables[0].Rows.Count + " registro(s)";
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
                if (dgvBoveda.Rows.Count > 0)
                {
                    frmMntBovedaDetalle ofrm = new frmMntBovedaDetalle();
                    ofrm.Operacion = "M";
                    ofrm.Origen = Origen;
                    ofrm._vSocio = dgvBoveda.CurrentRow.Cells["vRazonSocialSocio"].Value.ToString();
                    ofrm.Codigo = dgvBoveda.CurrentRow.Cells["IdBoveda"].Value.ToString();
                    ofrm._IdEstado_tt = dgvBoveda.CurrentRow.Cells["IdEstado_tt"].Value.ToString();
                    ofrm.ShowDialog();
                    btnBuscar.PerformClick();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvBoveda.Rows.Count > 0)
                {
                    frmMntBovedaDetalle ofrm = new frmMntBovedaDetalle();
                    ofrm.Operacion = "V";
                    ofrm.Origen = Origen;
                    ofrm._vSocio = dgvBoveda.CurrentRow.Cells["vRazonSocialSocio"].Value.ToString();
                    ofrm.Codigo = dgvBoveda.CurrentRow.Cells["IdBoveda"].Value.ToString();
                    ofrm._IdEstado_tt = dgvBoveda.CurrentRow.Cells["IdEstado_tt"].Value.ToString();
                    ofrm.ShowDialog();
                    btnBuscar.PerformClick();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}