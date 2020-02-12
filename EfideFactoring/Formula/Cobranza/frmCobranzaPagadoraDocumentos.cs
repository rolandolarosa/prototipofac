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

namespace EfideFactoring.Formula.Cobranza
{
    public partial class frmCobranzaPagadoraDocumentos : DevComponents.DotNetBar.OfficeForm
    {
        public string Tipo = string.Empty;
        public string IdEntidad = string.Empty;
        
        public string IdMoneda_tt = string.Empty;
        public string NombreEntidad = string.Empty;
        public BindingList<EntidadTmpLote> LstEntidadTmpLote = new BindingList<EntidadTmpLote>();
       
        DetaLoteBL DetaLoteBL = new DetaLoteBL();

        public frmCobranzaPagadoraDocumentos()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void frmCobranzaPagadoraDocumentos_Load(object sender, EventArgs e)
        {
            txtIdEntidad.Text = IdEntidad.Trim();
            txtNombreEntidad.Text = NombreEntidad.Trim();

            try
            {
                DataSet dsDetaLote = new DataSet();
                DetaLoteBE DetaLoteBE = new DetaLoteBE()
                {
                    OPCION = 13,
                    USUARIO = General.General.GetCodigoUsuario,
                    IdPagadora = Tipo.Equals("P")? txtIdEntidad.Text : string.Empty,
                    IdSocio = Tipo.Equals("S")? txtIdEntidad.Text : string.Empty,
                    IdMoneda_tt = IdMoneda_tt
                };
                
                dsDetaLote = DetaLoteBL.ProcesarDetaLote(DetaLoteBE);
                
                if (dsDetaLote.Tables[0].Rows.Count > 0)
                {
                    dgvDocumentos.DataSource = dsDetaLote.Tables[0];
                }

                if (Tipo.Equals("P"))
                    this.dgvDocumentos.Columns["IdPagadora_Dsc"].Visible = false;
                else
                    this.dgvDocumentos.Columns["Socio"].Visible = false;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvDocumentos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvDocumentos_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            try
            {
                // Referenciamos el control DataGridViewCheckBoxCell actual 
                DataGridViewCheckBoxCell cb = new DataGridViewCheckBoxCell();
                if (cb != null)
                {
                    //Confirmammos los cambios efectuados en la celda actual 
                    dgvDocumentos.CommitEdit(DataGridViewDataErrorContexts.Commit);
                }
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
                Boolean IsAprobo = false;
                if (dgvDocumentos.RowCount > 0)
                {
                    foreach (DataGridViewRow row in dgvDocumentos.Rows)
                    {
                        DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells[16];
                        if (chk.Value != null)
                        {
                            if (chk.Value.ToString().Equals("1"))
                            {
                                EntidadTmpLote oEntity = new EntidadTmpLote()
                                {
                                    IdEntidadSel = row.Cells["IdSocio"].Value.ToString(),
                                    CodDocumento = row.Cells["IdDocumento"].Value.ToString(),
                                    NumDocumento = row.Cells["cNumDoc"].Value.ToString(),
                                    IdLote = row.Cells["NroLote"].Value.ToString(),
                                    cItem = row.Cells["item"].Value.ToString(),
                                };
                                LstEntidadTmpLote.Add(oEntity);
                                IsAprobo = true;
                            }
                        }
                    }

                    if (!IsAprobo)
                    {
                        MessageBox.Show("Debe seleccionar al menos un documento", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    this.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}