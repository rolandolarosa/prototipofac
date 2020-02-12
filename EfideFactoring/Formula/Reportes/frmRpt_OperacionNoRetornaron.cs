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

namespace EfideFactoring.Formula.Reportes
{
    public partial class frmRpt_OperacionNoRetornaron : FormulaBase.frmMntDato
    {
        public frmRpt_OperacionNoRetornaron()
        {
            InitializeComponent();
        }

        private void frmRpt_OperacionNoRetornaron_Load(object sender, EventArgs e)
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet ds = new DataSet();
                ds = new GestionComercialBL().Procesar_Rpt_OperacionNoRetornaron(1, string.Empty, cboEjecutivo.SelectedValue.ToString(), 0);
                dgvDatos.DataSource = ds.Tables[0];                
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
                cboEjecutivo.SelectedValue = string.Empty;
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
                DataSet dsGestor = new GestionComercialBL().ProcesarGestionComercial(0, 0, "", "", 0, 3);
                General.General.LlenarCombobox(cboEjecutivo, "nombreCompleto", "gestorID", dsGestor.Tables[0], true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvDatos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvDatos.RowCount > 0)
                {
                    frmRpt_OperacionNoRetornaronDetalle ofrm = new frmRpt_OperacionNoRetornaronDetalle();
                    ofrm.Codigo = dgvDatos.CurrentRow.Cells["codCliente"].Value.ToString();
                    ofrm._IdSocio_Dsc = dgvDatos.CurrentRow.Cells["razonSocial"].Value.ToString();
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