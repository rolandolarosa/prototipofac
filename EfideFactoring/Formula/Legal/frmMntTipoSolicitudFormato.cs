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
    public partial class frmMntTipoSolicitudFormato : DevComponents.DotNetBar.OfficeForm
    {
        public frmMntTipoSolicitudFormato()
        {
            InitializeComponent();
        }

        private void frmMntTipoSolicitudFormato_Load(object sender, EventArgs e)
        {
            try
            {
                CargarTipoSolicitud();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarTipoSolicitud() 
        {
            try
            {
                BindingSource bs = new BindingSource();
                String Table_Id = "00287"; // Tipo Solicitud
                TableBaseBE TableBaseBE = new TableBaseBE()
                {
                    OPCION = 1,
                    USUARIO = General.General.GetCodigoUsuario,
                    Table_Parent_Id = Table_Id
                };
                DataSet ds = new TableBaseBL().ProcesarTableBase(TableBaseBE);
                dgvTipoSolicitud.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvTipoSolicitud_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvTipoSolicitud.RowCount > 0)
                {
                    TipoSolicitudFormatoBE oEntity = new TipoSolicitudFormatoBE()
                    {
                        OPCION = 1,
                        USUARIO = General.General.GetUsuario,
                        IdTipoSolicitud_tt = dgvTipoSolicitud.CurrentRow.Cells["Table_Id"].Value.ToString(),
                    };

                    DataSet ds = new TipoSolicitudFormatoBL().ProcesarTipoSolicitudFormato(oEntity);
                    dgvFormatoLegal.DataSource = ds.Tables[0];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                this.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvFormatoLegal_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            try
            {
                // Referenciamos el control DataGridViewCheckBoxCell actual 
                DataGridViewCheckBoxCell cb = new DataGridViewCheckBoxCell();
                if (cb != null)
                {
                    //Confirmammos los cambios efectuados en la celda actual 
                    dgvFormatoLegal.CommitEdit(DataGridViewDataErrorContexts.Commit);
                    Boolean bChk = Convert.ToBoolean(dgvFormatoLegal.CurrentRow.Cells["ChkSel"].Value.ToString());

                    TipoSolicitudFormatoBE oEntity = new TipoSolicitudFormatoBE()
                    {
                        OPCION = 2,
                        USUARIO = General.General.GetCodigoUsuario,
                        IdTipoSolicitud_tt = dgvFormatoLegal.CurrentRow.Cells["IdTipoSolicitud_tt"].Value.ToString(),
                        IdFormatoDocLegal_tt = dgvFormatoLegal.CurrentRow.Cells["IdFormatoDocLegal_tt"].Value.ToString(),
                        Status = bChk ? "A": "*"
                    };
                    new TipoSolicitudFormatoBL().ProcesarTipoSolicitudFormato(oEntity);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnActualizarData_Click(object sender, EventArgs e)
        {
            try
            {
                CargarTipoSolicitud();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}