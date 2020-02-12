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

namespace EfideFactoring.Formula.CargaDatos
{
    public partial class frmConsultaDatosLoad : FormulaBase.frmMntFiltro
    {
        public DataSet ds = new DataSet();
        public frmConsultaDatosLoad()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(TextBoxX1.Text.Trim()))
                {
                    MessageBox.Show("Ingresar una descripción.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    TextBoxX1.Focus();
                    return;
                }

                DatosLoadBE oEntity = new DatosLoadBE()
                {
                    OPCION = 4,
                    USUARIO = General.General.GetCodigoUsuario,
                    Descripcion = TextBoxX1.Text,
                };
                ds = new DatosLoadBL().ProcesarDatosLoad(oEntity);

                dgvCargaDatos.DataSource = ds.Tables[0];
                lblRegistros.Text = ds.Tables[0].Rows.Count.ToString() + " registro(s)";

                btnNuevo.Visible = false;
                if (ds.Tables[0].Rows.Count == 0)
                {
                    btnNuevo.Visible = true;
                }
                MessageBox.Show("Proceso terminado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                string strResultado = string.Empty;
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    strResultado = strResultado + row["Codigo"].ToString() + ", ";
                }

                Crystal.crRptCargaDatos ocrCargaDatos = new Crystal.crRptCargaDatos();
                Reportes.frmVisorLoteLiquidacion ofrmVisorCargaDatos = new Reportes.frmVisorLoteLiquidacion();
                ofrmVisorCargaDatos.crvVisorLoteLiq.ReportSource = ocrCargaDatos;
                ocrCargaDatos.SetParameterValue("usuario", General.General.GetUsuario);
                ocrCargaDatos.SetParameterValue("Criterio", TextBoxX1.Text.Trim());
                ocrCargaDatos.SetParameterValue("Codigo", string.Empty);
                ocrCargaDatos.SetParameterValue("RazonSocial", string.Empty);
                ocrCargaDatos.SetParameterValue("DatosAdicionales", string.Empty);
                ocrCargaDatos.SetParameterValue("ResultadoBusqueda", "NO HUBO COICIDENCIAS");
                ofrmVisorCargaDatos.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            try
            {
                TextBoxX1.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvCargaDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex < 0) return;
                if (e.RowIndex == -1) return;
                if (dgvCargaDatos.Columns[e.ColumnIndex].Name == "btnImprimir")
                {
                    Crystal.crRptCargaDatos ocrCargaDatos = new Crystal.crRptCargaDatos();
                    Reportes.frmVisorLoteLiquidacion ofrmVisorCargaDatos = new Reportes.frmVisorLoteLiquidacion();
                    ofrmVisorCargaDatos.crvVisorLoteLiq.ReportSource = ocrCargaDatos;
                    ocrCargaDatos.SetParameterValue("usuario", General.General.GetUsuario);
                    ocrCargaDatos.SetParameterValue("Criterio", TextBoxX1.Text.Trim());
                    ocrCargaDatos.SetParameterValue("Codigo", dgvCargaDatos.CurrentRow.Cells["Codigo"].Value.ToString());
                    ocrCargaDatos.SetParameterValue("RazonSocial", dgvCargaDatos.CurrentRow.Cells["RazonSocialNombres"].Value.ToString());
                    ocrCargaDatos.SetParameterValue("DatosAdicionales",  dgvCargaDatos.CurrentRow.Cells["DatosAdicionales"].Value.ToString());
                    ocrCargaDatos.SetParameterValue("ResultadoBusqueda", "SI HUBO COICIDENCIA");
                    ofrmVisorCargaDatos.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}