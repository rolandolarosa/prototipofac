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
using System.Configuration;
using System.Diagnostics;

namespace EfideFactoring.Formula.Legal
{
    public partial class frmMntBovedaDetalle : FormulaBase.frmMntDato
    {
        public string _vSocio = string.Empty;
        public string _IdEstado_tt = string.Empty;
        public int Origen = 1;
        public frmMntBovedaDetalle()
        {
            InitializeComponent();
        }

        private void frmMntBovedaDetalle_Load(object sender, EventArgs e)
        {
            try
            {
                lblSocio.Text = "Socio: " + _vSocio;
                CargarDatos();

                if (Origen == 1)
                {
                    btnAceptar.Visible = true;
                }
                else
                {
                    btnObservar.Visible = true;
                    btnCerrarBoveda.Visible = true;
                    btnSubir.Visible = true;
                    //dgvBovedaDetalle.Columns["btnSubir"].Visible = false;
                }

                OcultarBotonesXEstado();
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
                DialogResult dialogResult = 0;
                dialogResult = MessageBox.Show("Está usted seguro de enviar a Boveda los documentos?", "Confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    BovedaBE oEntity = new BovedaBE();
                    oEntity.OPCION = 4;
                    oEntity.USUARIO = General.General.GetUsuario;
                    oEntity.IdBoveda = Codigo;
                    new BovedaBL().ProcesarBoveda(oEntity);
                    MessageBox.Show("Se Proceso Correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnObservar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = 0;
                dialogResult = MessageBox.Show("Está usted seguro de observar los documentos?", "Confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    BovedaBE oEntity = new BovedaBE();
                    oEntity.OPCION = 5;
                    oEntity.USUARIO = General.General.GetUsuario;
                    oEntity.IdBoveda = Codigo;
                    new BovedaBL().ProcesarBoveda(oEntity);
                    MessageBox.Show("Se Proceso Correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCerrarBoveda_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = 0;
                dialogResult = MessageBox.Show("Está usted seguro de cerrar la boveda con los documentos?", "Confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    BovedaBE oEntity = new BovedaBE();
                    oEntity.OPCION = 6;
                    oEntity.USUARIO = General.General.GetUsuario;
                    oEntity.IdBoveda = Codigo;
                    new BovedaBL().ProcesarBoveda(oEntity);
                    MessageBox.Show("Se Proceso Correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvBovedaDetalle_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex < 0) return;
                if (e.RowIndex == -1) return;

                if (dgvBovedaDetalle.Columns[e.ColumnIndex].Name.Equals("btnSubir"))
                {
                    frmMntBovedaDetalleDato ofrm = new frmMntBovedaDetalleDato();
                    ofrm.Operacion = "N";
                    ofrm.Codigo = dgvBovedaDetalle.CurrentRow.Cells["IdBoveda"].Value.ToString();
                    ofrm._IdFormatoDocLegal_tt = dgvBovedaDetalle.CurrentRow.Cells["IdFormatoDocLegal_tt"].Value.ToString(); ;
                    ofrm._IdFormatoDocLegal_tt_Dsc = dgvBovedaDetalle.CurrentRow.Cells["IdFormatoDocLegal_tt_Dsc"].Value.ToString(); ;
                    ofrm.ShowDialog();
                    CargarDatos();
                }

                if (dgvBovedaDetalle.Columns[e.ColumnIndex].Name.Equals("btnVer"))
                {
                    if (dgvBovedaDetalle.CurrentRow.Cells["vSubido"].Value.ToString().Equals("Si"))
                    {
                        string filepath = ConfigurationManager.AppSettings["RutaImageFisical"].ToString() + "//LegalSistemas//Boveda//" + Codigo + "//" + dgvBovedaDetalle.CurrentRow.Cells["vArchivoAdjunto"].Value.ToString();
                        Process.Start(filepath);
                    }
                }
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
                BovedaDetalleBE oEntity = new BovedaDetalleBE();
                oEntity.OPCION = 1;
                oEntity.USUARIO = General.General.GetUsuario;
                oEntity.IdBoveda = Codigo;
                dgvBovedaDetalle.DataSource = new BovedaDetalleBL().ProcesarBovedaDetalle(oEntity).Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OcultarBotonesXEstado()
        {
            try
            {
                switch (_IdEstado_tt)
                {
                    case "00397": //Pendiente de Envío
                        {
                            btnCerrarBoveda.Visible = false;
                            btnObservar.Visible = false;
                            break;
                        }
                    case "00398": //Enviado a Boveda
                        {
                            //dgvBovedaDetalle.Columns["btnSubir"].Visible = false;
                            btnAceptar.Visible = false;
                            break;
                        }
                    case "00399": //Observado
                        {
                            dgvBovedaDetalle.Columns["btnSubir"].Visible = false;
                            btnCerrarBoveda.Visible = false;
                            btnObservar.Visible = false;
                            break;
                        }
                    case "00400": //Cerrado
                        {
                            dgvBovedaDetalle.Columns["btnSubir"].Visible = false;
                            btnCerrarBoveda.Visible = false;
                            btnObservar.Visible = false;
                            btnAceptar.Visible = false;
                            break;
                        }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvBovedaDetalle_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            try
            {
                // Referenciamos el control DataGridViewCheckBoxCell actual 
                DataGridViewCheckBoxCell cb = new DataGridViewCheckBoxCell();
                if (cb != null)
                {
                    //Confirmammos los cambios efectuados en la celda actual 
                    dgvBovedaDetalle.CommitEdit(DataGridViewDataErrorContexts.Commit);
                    Boolean bChk = Convert.ToBoolean(dgvBovedaDetalle.CurrentRow.Cells["bFlgRecepcion"].Value.ToString());

                    BovedaDetalleBE oEntity = new BovedaDetalleBE()
                    {
                        OPCION = 4,
                        USUARIO = General.General.GetCodigoUsuario,
                        IdBoveda = dgvBovedaDetalle.CurrentRow.Cells["IdBoveda"].Value.ToString(),
                        IdFormatoDocLegal_tt = dgvBovedaDetalle.CurrentRow.Cells["IdFormatoDocLegal_tt"].Value.ToString(),
                        bFlgRecepcion = bChk
                    };
                    new BovedaDetalleBL().ProcesarBovedaDetalle(oEntity);
                    CargarDatos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}