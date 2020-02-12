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

namespace EfideFactoring.Formula.Renovacion
{
    public partial class frmRenovacionDocAdd : DevComponents.DotNetBar.OfficeForm
    {
        DetaLoteBL DetaLoteBL = new DetaLoteBL();
        public List<DetaLoteBE> LstDetalle = new List<DetaLoteBE>();
        public BindingList<EntidadTmpLote> LstEntidadTmpLote = new BindingList<EntidadTmpLote>();
        public string _IdEntidad = string.Empty;
        public string _IdEntidad_Dsc = string.Empty;
        public string _IdMoneda_tt = string.Empty;
        public string _IdMoneda_tt_Dsc = string.Empty;
        public string _dtRenovacion = string.Empty;
        public string _IdLote = string.Empty;
        public string _cItem = string.Empty;
        public string _Tipo = string.Empty;
        public frmRenovacionDocAdd()
        {
            InitializeComponent();
        }

        private void frmRenovacionDocAdd_Load(object sender, EventArgs e)
        {
            try
            {
                txtIdEntidad.Text = _IdEntidad;
                txtIdEntidad_Dsc.Text = _IdEntidad_Dsc;
                txtIdMoneda_tt_Dsc.Text = _IdMoneda_tt_Dsc;
                txtdtRenovacion.Text = _dtRenovacion;
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
                DataSet dsDetaLote = new DataSet();
                DetaLoteBE DetaLoteBE = new DetaLoteBE()
                {
                    OPCION = 7,
                    USUARIO = General.General.GetCodigoUsuario,
                    IdPagadora = _Tipo.Equals("P") ? txtIdEntidad.Text : string.Empty,
                    IdSocio = _Tipo.Equals("S") ? txtIdEntidad.Text : string.Empty,
                    IdMoneda_tt = _IdMoneda_tt,
                    dtRenovacion = Convert.ToDateTime(txtdtRenovacion.Text),
                    Tipo = _Tipo
                };
                dsDetaLote = DetaLoteBL.ProcesarDetaLote(DetaLoteBE);

                if (dsDetaLote.Tables[0].Rows.Count > 0)
                {
                    dgvDocumentos.DataSource = dsDetaLote.Tables[0];
                }

                string dtRenova = "";  
                string dtNow = General.General.gFechaOp.ToString().Substring(0, 10);

                foreach (DataGridViewRow row in dgvDocumentos.Rows)
                {
                    dtRenova = row.Cells["Column3"].Value.ToString().Substring(0, 10);
                    if (DateTime.Parse(dtRenova.ToString()) >= DateTime.Parse(dtNow.ToString()))
                    {
                    }
                    else // Vencido
                    {
                        row.DefaultCellStyle.ForeColor = Color.FromName(General.General.GetColorAnulado);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvDocumentos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //if (dgvDocumentos.RowCount > 0)
                //{
                //    _IdLote = dgvDocumentos.CurrentRow.Cells["IdLote"].Value.ToString();
                //    _cItem = dgvDocumentos.CurrentRow.Cells["cItem"].Value.ToString();
                //    this.Dispose();
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
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
                        DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells[7];
                        if (chk.Value != null)
                        {
                            if (chk.Value.ToString().Equals("1"))
                            {
                                EntidadTmpLote oEntity = new EntidadTmpLote()
                                //DetaLoteBE DetaLoteBE = new DetaLoteBE()
                                {
                                    //IdEntidadSel = row.Cells["IdSocio"].Value.ToString(),
                                    //CodDocumento = row.Cells["IdDocumento"].Value.ToString(),
                                    //NumDocumento = row.Cells["cNumDoc"].Value.ToString(),
                                    IdLote = row.Cells["IdLote"].Value.ToString(),
                                    cItem = row.Cells["cItem"].Value.ToString(),
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