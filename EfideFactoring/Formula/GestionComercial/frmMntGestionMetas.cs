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
    public partial class frmMntGestionMetas : DevComponents.DotNetBar.OfficeForm
    {
        public frmMntGestionMetas()
        {
            InitializeComponent();
        }

        private void frmMntGestionMetas_Load(object sender, EventArgs e)
        {
            try
            {
                txtAnnio.Text = General.General.gFechaOp.Year.ToString();
                LlenarCombos();
                CargaDatos();
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
                String Table_Id = "00213"; //MESES
                TableBaseBE TableBaseBE = new TableBaseBE()
                {
                    OPCION = 1,
                    USUARIO = General.General.GetCodigoUsuario,
                    Table_Parent_Id = Table_Id
                };

                cboMes.DataSource = new TableBaseBL().ProcesarTableBase(TableBaseBE).Tables[0];
                cboMes.DisplayMember = "Table_Name";
                cboMes.ValueMember = "Table_Value";

                cboMes.SelectedValue = DateTime.Now.Month.ToString().PadLeft(2, '0');
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargaDatos()
        {
            try
            {
                DataSet ds = new DataSet();
                GestionMetasBE GestionMetasBE = new GestionMetasBE()
                {
                    OPCION = 1,
                    USUARIO = General.General.GetUsuario,
                    Annio = txtAnnio.Text,
                    Mes = cboMes.SelectedValue.ToString()
                };

                ds = new GestionMetasBL().ProcesarGestionMetas(GestionMetasBE);
                dgvGestionMetas.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboMes_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                CargaDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            try
            {
                GestionMetasBE oEntity = new GestionMetasBE();
                foreach (DataGridViewRow row in dgvGestionMetas.Rows)
                {
                    oEntity.OPCION = 2;
                    oEntity.USUARIO = General.General.GetUsuario;
                    oEntity.Annio = row.Cells["Annio"].Value.ToString();
                    oEntity.Mes = row.Cells["Mes"].Value.ToString();
                    oEntity.GestorId = row.Cells["GestorId"].Value.ToString();
                    oEntity.Monto = string.IsNullOrEmpty(row.Cells["Monto"].Value.ToString())? 0 : Convert.ToDecimal(row.Cells["Monto"].Value);
                    new GestionMetasBL().ProcesarGestionMetas(oEntity);
                }

                MessageBox.Show("Se proceso correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvGestionMetas_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            try
            {
                // Referenciamos el control DataGridViewCheckBoxCell actual 
                DataGridViewCheckBoxCell cb = new DataGridViewCheckBoxCell();
                if (cb != null)
                {
                    //Confirmammos los cambios efectuados en la celda actual 
                    dgvGestionMetas.CommitEdit(DataGridViewDataErrorContexts.Commit);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}