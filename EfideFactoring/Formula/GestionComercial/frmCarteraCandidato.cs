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
    public partial class frmCarteraCandidato : FormulaBase.frmMntFiltro
    {
        public int _FlgPagadora = 0;
        public frmCarteraCandidato()
        {
            InitializeComponent();
        }

        private void frmCarteraCandidato_Load(object sender, EventArgs e)
        {
            try
            {
                LlenarCombos();

                if (_FlgPagadora == 1)
                {
                    this.TitleText = "Registro Cartera de Prospectos Pagadoras";
                    dgvCarteraCantidato.Columns["vcPagadora"].Visible = false;
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
                String Table_Id = "00134"; //Tipo Documento
                TableBaseBE TableBaseBE = new TableBaseBE()
                {
                    OPCION = 1,
                    USUARIO = General.General.GetCodigoUsuario,
                    Table_Parent_Id = Table_Id
                };
                General.General.LlenarCombobox(cboIdTipoDocumento_tt, "Table_Name", "Table_Id", new TableBaseBL().ProcesarTableBase(TableBaseBE).Tables[0]);

                TableBaseBE.Table_Parent_Id = "00138"; //Tipo Persona
                General.General.LlenarCombobox(cboIdTipoPersona_tt, "Table_Name", "Table_Id", new TableBaseBL().ProcesarTableBase(TableBaseBE).Tables[0]);

                UsuarioGestorBE oEntity = new UsuarioGestorBE()
                {
                    OPCION = 8,
                    USUARIO = General.General.GetCodigoUsuario
                };

                DataTable dt = new DataTable();
                dt = new UsuarioGestorBL().ProcesarUsuarioGestor(oEntity).Tables[0];

                DataRow dr;
                dr = dt.NewRow();
                dr["usuarioID"] = "--Seleccionar--";
                dr["usuarioID"] = "--Seleccionar--";
                dt.Rows.InsertAt(dr, 0);

                cboUsuarioID.DataSource = dt;
                cboUsuarioID.DisplayMember = "usuarioID";
                cboUsuarioID.ValueMember = "usuarioID";
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
                CarteraCandidatoBE CarteraCandidatoBE = new CarteraCandidatoBE()
                {
                    OPCION = 1,
                    USUARIO = General.General.GetUsuario,
                    vApePaterno = TextBoxX1.Text.ToString().Trim(),
                    IdTipoDocumento_tt = cboIdTipoDocumento_tt.SelectedValue.ToString(),
                    vNroDocumento = txtvNroDocumento.Text,
                    IdTipoPersona_tt = cboIdTipoPersona_tt.SelectedValue.ToString(),
                    UsuarioID = cboUsuarioID.SelectedValue.ToString().Equals("--Seleccionar--") ? string.Empty : cboUsuarioID.SelectedValue.ToString(),
                    FlgPagadora = _FlgPagadora
                };
                ds = new CarteraCandidatoBL().ProcesarCarteraCandidato(CarteraCandidatoBE);
                dgvCarteraCantidato.DataSource = ds.Tables[0];
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
                TextBoxX1.Clear();
                cboIdTipoDocumento_tt.SelectedValue = string.Empty;
                txtvNroDocumento.Clear();
                cboIdTipoPersona_tt.SelectedValue  = string.Empty;
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
                Formula.GestionComercial.frmCarteraCandidatoDato ofrmCarteraCandidatoDato = new Formula.GestionComercial.frmCarteraCandidatoDato();
                ofrmCarteraCandidatoDato.Operacion = "N";
                ofrmCarteraCandidatoDato._FlgPagadora = _FlgPagadora;
                ofrmCarteraCandidatoDato.ShowDialog();
                btnBuscar.PerformClick();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvCarteraCantidato.RowCount > 0)
                {
                    Formula.GestionComercial.frmCarteraCandidatoDato ofrmCarteraCandidatoDato = new Formula.GestionComercial.frmCarteraCandidatoDato();
                    ofrmCarteraCandidatoDato.Operacion = "M";
                    ofrmCarteraCandidatoDato._FlgPagadora = _FlgPagadora;
                    ofrmCarteraCandidatoDato.Codigo = dgvCarteraCantidato.CurrentRow.Cells["IdCartera"].Value.ToString();
                    ofrmCarteraCandidatoDato.ShowDialog();
                    btnBuscar.PerformClick();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = 0;
            try
            {
                if (dgvCarteraCantidato.RowCount > 0)
                {
                    dialogResult = MessageBox.Show("Seguro de eliminar al candidato: " + dgvCarteraCantidato.CurrentRow.Cells["vApePaterno"].Value.ToString().Trim(), "Confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dialogResult == DialogResult.Yes)
                    {
                        CarteraCandidatoBE CarteraCandidatoBE = new CarteraCandidatoBE()
                        {
                            OPCION = 3,
                            USUARIO = General.General.GetUsuario,
                            IdCartera = dgvCarteraCantidato.CurrentRow.Cells["IdCartera"].Value.ToString(),
                        };

                        new CarteraCandidatoBL().ProcesarCarteraCandidato(CarteraCandidatoBE);
                        MessageBox.Show("Se Proceso Correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnBuscar.PerformClick();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}