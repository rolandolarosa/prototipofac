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
    public partial class frmGestionDato : FormulaBase.frmMntDato
    {
        public int FlgSocio = 0;
        public string IdGestionAtendida = string.Empty;
        public string IdEntidad = string.Empty;
        public string Entidad = string.Empty;
        public frmGestionDato()
        {
            InitializeComponent();
        }

        private void frmGestionDato_Load(object sender, EventArgs e)
        {
            try
            {
                LlenarCombos();
                if (Operacion.Equals("M"))
                {
                    btnBuscarSocioCandidato.Enabled = false;
                    txtIdEntidad.Text = IdEntidad;
                    txtEntidad.Text = Entidad;
                }
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
                String Table_Id = "00141"; //Accion Gestion
                TableBaseBE TableBaseBE = new TableBaseBE()
                {
                    OPCION = 1,
                    USUARIO = General.General.GetCodigoUsuario,
                    Table_Parent_Id = Table_Id
                };
                General.General.LlenarCombobox(cboIdAccion_tt, "Table_Name", "Table_Id", new TableBaseBL().ProcesarTableBase(TableBaseBE).Tables[0]);

                TableBaseBE.Table_Parent_Id = "00146"; //Tipo Compromiso
                General.General.LlenarCombobox(cboIdTipoCompromiso_tt, "Table_Name", "Table_Id", new TableBaseBL().ProcesarTableBase(TableBaseBE).Tables[0]);

                TableBaseBE.Table_Parent_Id = "00150"; //Motivo Gestion
                General.General.LlenarCombobox(cboIdMotivo_tt, "Table_Name", "Table_Id", new TableBaseBL().ProcesarTableBase(TableBaseBE).Tables[0]);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rbtnCompromiso_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                gpCompromiso.Enabled = false;
                gpNoInteresado.Enabled = false;
                if (rbtnCompromiso.Checked) { gpCompromiso.Enabled = true; }
            }
            catch (Exception ex)
            {
               MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rbtnNoInteresado_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                gpCompromiso.Enabled = false;
                gpNoInteresado.Enabled = false;
                if (rbtnNoInteresado.Checked) { gpNoInteresado.Enabled = true; }
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
                if (string.IsNullOrEmpty(txtIdEntidad.ToString()))
                {
                    MessageBox.Show("Ingresar un socio o candidato", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtIdEntidad.Focus();
                    return;
                }

                if (rbtnCompromiso.Checked)
                {
                    if (string.IsNullOrEmpty(cboIdAccion_tt.SelectedValue.ToString()))
                    {
                        MessageBox.Show("Seleccionar una acción", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        cboIdAccion_tt.Focus();
                        return;
                    }

                    if (string.IsNullOrEmpty(cboIdTipoCompromiso_tt.SelectedValue.ToString()))
                    {
                        MessageBox.Show("Seleccionar un compromiso", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        cboIdTipoCompromiso_tt.Focus();
                        return;
                    }

                    if (dtFechaCompromiso.Value == DateTime.MinValue)
                    {
                        MessageBox.Show("Ingrese una fecha de compromiso", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        dtFechaCompromiso.Focus();
                        return;
                    }

                    GestionBE oGestionBE = new GestionBE()
                    {
                        OPCION = 2,
                        USUARIO = General.General.GetUsuario,
                        IdGestionAtendida = IdGestionAtendida,
                        IdEntidad = txtIdEntidad.Text,
                        IdAccion_tt = cboIdAccion_tt.SelectedValue.ToString(),
                        IdTipoCompromiso_tt = cboIdTipoCompromiso_tt.SelectedValue.ToString(),
                        dtFechaCompromiso = dtFechaCompromiso.Value,
                        Comentario = txtComentario.Text.Trim(),
                        FlgSocio = FlgSocio,
                        FlgInteresado = 1
                    };
                    new GestionBL().ProcesarGestion(oGestionBE);
                }
                else
                {
                    if (string.IsNullOrEmpty(cboIdMotivo_tt.SelectedValue.ToString()))
                    {
                        MessageBox.Show("Seleccionar un motivo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        cboIdMotivo_tt.Focus();
                        return;
                    }

                    if (string.IsNullOrEmpty(txtComentarioNI.Text.Trim()))
                    {
                        MessageBox.Show("Seleccionar un motivo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtComentarioNI.Focus();
                        return;
                    }

                    GestionBE oGestionBE = new GestionBE()
                    {
                        OPCION = 2,
                        USUARIO = General.General.GetUsuario,
                        IdGestionAtendida = IdGestionAtendida,
                        IdEntidad = txtIdEntidad.Text,
                        IdMotivo_tt = cboIdMotivo_tt.SelectedValue.ToString(),
                        Comentario = txtComentarioNI.Text.Trim(),
                        FlgSocio = FlgSocio,
                        FlgInteresado = 0
                    };
                    new GestionBL().ProcesarGestion(oGestionBE);
                }

                MessageBox.Show("Se Proceso Correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscarSocioCandidato_Click(object sender, EventArgs e)
        {
            try
            {
                Formula.GestionComercial.frmBusquedaSocioCandidato ofrmBusquedaSocioCandidato = new Formula.GestionComercial.frmBusquedaSocioCandidato();
                ofrmBusquedaSocioCandidato.ShowDialog();

                if (!string.IsNullOrEmpty(ofrmBusquedaSocioCandidato._Codigo))
                {
                    txtIdEntidad.Text = ofrmBusquedaSocioCandidato._Codigo.Trim();
                    txtEntidad.Text = ofrmBusquedaSocioCandidato._Entidad.Trim();
                    FlgSocio = ofrmBusquedaSocioCandidato._FlgSocio;
                }
            }
            catch (Exception ex)
            { 
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}