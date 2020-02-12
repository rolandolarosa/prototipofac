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
    public partial class frmQrySociosInactivos : FormulaBase.frmMntDato
    {
        public string _IdPagadora_Dsc = string.Empty;
        public frmQrySociosInactivos()
        {
            InitializeComponent();
        }

        private void frmQrySociosInactivos_Load(object sender, EventArgs e)
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
                GestionPagadoraBE oEntity = new GestionPagadoraBE();
                oEntity.OPCION = 6;
                oEntity.IdPagadora = Codigo;
                DataSet ds = new DataSet();
                ds = new GestionPagadoraBL().ProcesarGestionPagadora(oEntity);
                dgvSocios.DataSource = ds.Tables[0];
                lblRegistros.Text = ds.Tables[0].Rows.Count + " registro(s)";
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
                int Count = 0;
                if (dgvSocios.RowCount > 0)
                {
                    foreach (DataGridViewRow row in dgvSocios.Rows)
                    {

                        DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells["ChkSel"];
                        if (Convert.ToBoolean(chk.Value))
                        {
                            GestionPagadoraBE IEntity = new GestionPagadoraBE()
                            {
                                OPCION = 7,
                                USUARIO = General.General.GetUsuario,
                                IdSocio = row.Cells["IdSocio"].Value.ToString(),
                            };
                            new GestionPagadoraBL().ProcesarGestionPagadora(IEntity);
                            Count++;
                        }
                    }

                    if (Count > 0 )
                    {
                        MessageBox.Show("Se Proceso Correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Dispose();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvSocios_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            try
            {
                // Referenciamos el control DataGridViewCheckBoxCell actual 
                DataGridViewCheckBoxCell cb = new DataGridViewCheckBoxCell();
                if (cb != null)
                {
                    //Confirmammos los cambios efectuados en la celda actual 
                    dgvSocios.CommitEdit(DataGridViewDataErrorContexts.Commit);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}