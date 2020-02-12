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
    public partial class frmQryGestionNPO : FormulaBase.frmMntFiltro
    {
        public frmQryGestionNPO()
        {
            InitializeComponent();
        }

        private void frmQryGestionNPO_Load(object sender, EventArgs e)
        {
            try
            {
                btnBuscar.PerformClick();
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
                SolicitudBE oEntity = new SolicitudBE();
                oEntity.OPCION = 10;
                oEntity.USUARIO = General.General.GetCodigoUsuario;
                oEntity.dtSolicitud = dtSolicitudInput.Value;
                oEntity.FlgVerHistoricos = chkVerHistoricos.Checked ? 1 : 0;
                DataSet ds = new SolicitudBL().ProcesarSolicitud(oEntity);
                dgvSolicitud.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvSolicitud_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex < 0) return;
                if (e.RowIndex == -1) return;

                if (dgvSolicitud.Columns[e.ColumnIndex].Name.Equals("btnVerSolicitud"))
                {
                    frmMntSolicitudEvaluacion ofrm = new frmMntSolicitudEvaluacion();
                    ofrm.Operacion = "C";
                    ofrm.Codigo = dgvSolicitud.CurrentRow.Cells["IdSolicitud"].Value.ToString();
                    ofrm.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}