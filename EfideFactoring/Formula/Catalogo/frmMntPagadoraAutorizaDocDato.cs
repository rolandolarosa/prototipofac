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

namespace EfideFactoring.Formula.Catalogo
{
    public partial class frmMntPagadoraAutorizaDocDato : FormulaBase.frmMntDato
    {
        public frmMntPagadoraAutorizaDocDato()
        {
            InitializeComponent();
        }

        private void frmMntPagadoraAutorizaDocDato_Load(object sender, EventArgs e)
        {
            try
            {
                LlenarCombos();
                CargarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #region Metodos ---------------------------------------------
        private void LlenarCombos()
        {
            try
            {
                DocumentoBE DocumentoBE = new DocumentoBE()
                {
                    OPCION = 1,
                    USUARIO = General.General.GetCodigoUsuario
                };

                General.General.LlenarCombobox(cboIdDocumento, "vDocumento", "IdDocumento", new DocumentoBL().ProcesarDocumento(DocumentoBE).Tables[0]);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        private void btnBusquedaSocio_Click(object sender, EventArgs e)
        {
            try
            {
                Formula.Consulta.frmBusquedaSocio ofrmBusquedaSocio = new Formula.Consulta.frmBusquedaSocio();
                ofrmBusquedaSocio.ShowDialog();
                txtIdSocio.Text = ofrmBusquedaSocio.CodSocio.Trim();
                txtRazonSocialSocio.Text = ofrmBusquedaSocio.RazorSocialSocio.Trim();
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
                foreach (DataGridViewRow row in dgvDocumento.Rows)
                {
                    DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells["CheckSel"];
                    if (chk.Value.ToString() == "1")
                    {
                        PagadoraAutorizaDocBE IEntity = new PagadoraAutorizaDocBE()
                        {
                            OPCION = 2,
                            USUARIO = General.General.GetUsuario,
                            IdPagadora = Codigo,
                            IdSocio = row.Cells["IdSocio"].Value.ToString(),
                            IdDocumento = row.Cells["IdDocumento"].Value.ToString(),
                        };
                        new PagadoraAutorizaDocBL().ProcesarPagadoraAutorizaDoc(IEntity);
                    }
                }
                this.Dispose();
                this.Close();
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
                PagadoraAutorizaDocBE IEntity = new PagadoraAutorizaDocBE()
                {
                    OPCION = 4,
                    USUARIO = General.General.GetUsuario,
                    IdPagadora = Codigo,
                    IdSocio = txtIdSocio.Text,
                    IdDocumento = cboIdDocumento.SelectedValue.ToString()
                };
                DataSet ds = new DataSet();
                ds = new PagadoraAutorizaDocBL().ProcesarPagadoraAutorizaDoc(IEntity);
                dgvDocumento.DataSource = ds.Tables[0];
                lblRegistros.Text = ds.Tables[0].Rows.Count.ToString() + " registro(s)";
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
                txtIdSocio.Clear();
                txtRazonSocialSocio.Clear();
                cboIdDocumento.SelectedValue = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvDocumento_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            try
            {
                // Referenciamos el control DataGridViewCheckBoxCell actual 
                DataGridViewCheckBoxCell cb = new DataGridViewCheckBoxCell();
                if (cb != null)
                {
                    //Confirmammos los cambios efectuados en la celda actual 
                    dgvDocumento.CommitEdit(DataGridViewDataErrorContexts.Commit);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}