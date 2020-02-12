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

namespace EfideFactoring.Formula.Top10K
{
    public partial class frmAprobacionComite : FormulaBase.frmMntFiltro
    {
        public frmAprobacionComite()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet ds = new DataSet();
                EmpresaTopBE SocioLineaBE = new EmpresaTopBE()
                {
                    OPCION = 4,
                    USUARIO = General.General.GetUsuario,
                    RUC = TextBoxX1.Text.Trim(),
                    RazonSocial = txtRazonSocial.Text.Trim()
                };

                ds = new EmpresaTopBL().ProcesarEmpresaTop(SocioLineaBE);
                dgvEmpresas.DataSource = ds.Tables[0];
                lblRegistros.Text = ds.Tables[0].Rows.Count.ToString() + " registro(s)";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvEmpresas_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            try
            {
                // Referenciamos el control DataGridViewCheckBoxCell actual 
                DataGridViewCheckBoxCell cb = new DataGridViewCheckBoxCell();
                if (cb != null)
                {
                    //Confirmammos los cambios efectuados en la celda actual 
                    dgvEmpresas.CommitEdit(DataGridViewDataErrorContexts.Commit);
                }
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
                Boolean IsProcedio = false;
                int Opcion = 0;
                if (dgvEmpresas.RowCount > 0)
                {
                    foreach (DataGridViewRow row in dgvEmpresas.Rows)
                    {
                        DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells[0];
                        if (chk.Value != null)
                        {
                            EmpresaTopBE IEntity = new EmpresaTopBE();
                            IEntity.FlgComite = 0;
                            decimal Linea = string.IsNullOrEmpty(row.Cells["nLinea"].Value.ToString()) ? 0 : Convert.ToDecimal(row.Cells["nLinea"].Value);
                            if (chk.Value.ToString().Equals("1"))
                            {
                                IEntity.FlgComite = 1;
                            }

                            IEntity.OPCION = 5;
                            IEntity.USUARIO = General.General.GetUsuario;
                            IEntity.Year = row.Cells["Year"].Value.ToString();
                            IEntity.RUC = row.Cells["RUC"].Value.ToString();
                            IEntity.nLinea = Linea;
                            new EmpresaTopBL().ProcesarEmpresaTop(IEntity);
                        }
                    }

                    btnBuscar.PerformClick();
                    MessageBox.Show("Se Proceso Correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvEmpresas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}