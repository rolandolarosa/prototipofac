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
    public partial class frmAsignarGestorPagadora : FormulaBase.frmMntFiltro
    {
        public frmAsignarGestorPagadora()
        {
            InitializeComponent();
        }

        private void frmAsignarGestorPagadora_Load(object sender, EventArgs e)
        {
            try
            {
                // customize dataviewgrid, add checkbox column
                DataGridViewCheckBoxColumn ChkBoxColumn = new DataGridViewCheckBoxColumn();
                ChkBoxColumn.Width = 30;
                ChkBoxColumn.Name = "ChkSelAsignar";
                ChkBoxColumn.HeaderText = "";
                ChkBoxColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvPagadoras.Columns.Insert(0, ChkBoxColumn);

                // add checkbox header
                Rectangle rect = dgvPagadoras.GetCellDisplayRectangle(0, -1, true);
                // set checkbox header to center of header cell. +1 pixel to position correctly.
                rect.X = rect.Location.X + (rect.Width / 5);


                CheckBox ChkBoxHeader = new CheckBox();
                ChkBoxHeader.Name = "ChkSelAsignar";
                ChkBoxHeader.Size = new Size(25, 25);
                ChkBoxHeader.Location = rect.Location;
                ChkBoxHeader.Text = "";
                ChkBoxHeader.ForeColor = Color.Transparent;
                ChkBoxHeader.BackColor = Color.Transparent;
                ChkBoxHeader.CheckedChanged += new EventHandler(ChkBoxHeader_CheckedChanged);
                dgvPagadoras.Controls.Add(ChkBoxHeader);

                LlenarCombos();
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
                General.General.LlenarCombobox(cboUsuarios, "nombreCompleto", "gestorID", new GestionComercialBL().ProcesarGestionComercial(0, 0, "", "", 0, 3).Tables[0]);

                DataSet ds = new DataSet();
                ds = new GestionComercialBL().ProcesarGestionComercial(0, 0, "", "", 0, 3);

                DataTable dt = new DataTable();
                dt = ds.Tables[0];
                DataRow dr;
                dr = dt.NewRow();
                dr["nombreCompleto"] = "--Seleccionar--";
                dr["gestorID"] = "";
                dt.Rows.InsertAt(dr, 0);

                cboEjecutivo.DataSource = dt;
                cboEjecutivo.DisplayMember = "nombreCompleto";
                cboEjecutivo.ValueMember = "gestorID";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ChkBoxHeader_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < dgvPagadoras.RowCount; i++)
                {
                    dgvPagadoras[0, i].Value = ((CheckBox)dgvPagadoras.Controls.Find("ChkSelAsignar", true)[0]).Checked;
                }
                dgvPagadoras.EndEdit();
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
                PagadoraBE oEntity = new PagadoraBE()
                {
                    OPCION = 11,
                    USUARIO = General.General.GetUsuario,
                    IdPagadora = txtIdPagadora.Text,
                    IdGestor = cboEjecutivo.SelectedValue.ToString(),
                    dtFechaInicio = dtFechaInicio.Value == null ? DateTime.MinValue : dtFechaInicio.Value,
                    dtFechaFin = dtFechaFin.Value == null ? DateTime.MinValue : dtFechaFin.Value,
                    FlgInactivo = ChkInactivos.Checked ? 1 : 0,
                    FlgBloqueado = ChkBloqueados.Checked ? 1 : 0,
                };
                DataSet ds = new DataSet();
                ds = new PagadoraBL().ProcesarPagadora(oEntity);
                dgvPagadoras.DataSource = ds.Tables[0];
                lblNRegistros.Text = ds.Tables[0].Rows.Count.ToString() + " registro(s)";

                ((CheckBox)dgvPagadoras.Controls.Find("ChkSelAsignar", true)[0]).Checked = false;
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
                txtIdPagadora.Clear();
                txtDescripcion.Clear();
                ChkInactivos.Checked = false;
                dgvUsuarios.Rows.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscarPagadora_Click(object sender, EventArgs e)
        {
            try
            {
                Formula.Consulta.frmBusquedaPagadora ofrmBusquedaPagadora = new Formula.Consulta.frmBusquedaPagadora();
                ofrmBusquedaPagadora.ShowDialog();

                DataSet dsPagadora = new DataSet();
                PagadoraBE PagadoraBE = new PagadoraBE()
                {
                    OPCION = 4,
                    USUARIO = General.General.GetCodigoUsuario,
                    IdPagadora = ofrmBusquedaPagadora.CodigoPagadora.ToString()
                };

                dsPagadora = new PagadoraBL().ProcesarPagadora(PagadoraBE);

                if (dsPagadora.Tables[0].Rows.Count > 0)
                {
                    txtIdPagadora.Text = dsPagadora.Tables[0].Rows[0]["IdPagadora"].ToString();
                    txtDescripcion.Text = dsPagadora.Tables[0].Rows[0]["vcPagadora"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(cboUsuarios.SelectedValue.ToString()))
                {
                    MessageBox.Show("Se debe seleccionar un ejecutivo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cboUsuarios.Focus();
                    return;
                }

                string[] row0 = { cboUsuarios.SelectedValue.ToString(), cboUsuarios.Text };
                dgvUsuarios.Rows.Add(row0);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvPagadoras_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            try
            {
                // Referenciamos el control DataGridViewCheckBoxCell actual 
                DataGridViewCheckBoxCell cb = new DataGridViewCheckBoxCell();
                if (cb != null)
                {
                    //Confirmammos los cambios efectuados en la celda actual 
                    dgvPagadoras.CommitEdit(DataGridViewDataErrorContexts.Commit);
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
                if (dgvPagadoras.Rows.Count == 0)
                {
                    MessageBox.Show("Deben existir pagadoras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cboUsuarios.Focus();
                    return;
                }

                if (dgvUsuarios.Rows.Count == 0)
                {
                    MessageBox.Show("Agregar al menos un usuario para la distribución", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cboUsuarios.Focus();
                    return;
                }

                int nDistribucion = Math.Abs(dgvPagadoras.Rows.Count / dgvUsuarios.Rows.Count);
                int nCountUsuario = dgvUsuarios.Rows.Count;
                int nRowUsuario = 0;
                int nCount = 0;

                foreach (DataGridViewRow row in dgvPagadoras.Rows)
                {
                    DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells[0];
                    if (chk.Value != null)
                    {
                        if (chk.Value.ToString().Equals("True"))
                        {
                            if ((nCountUsuario - 1) != nRowUsuario)
                            {
                                if (nCount == nDistribucion)
                                {
                                    nRowUsuario += 1;
                                    nCount = 0;
                                }
                            }

                            PagadoraBE oEntity = new PagadoraBE()
                            {
                                OPCION = 10,
                                USUARIO = General.General.GetUsuario,
                                IdPagadora = row.Cells["IdPagadora"].Value.ToString(),
                                IdGestor = dgvUsuarios.Rows[nRowUsuario].Cells["gestorID"].Value.ToString(),
                            };
                            new PagadoraBL().ProcesarPagadora(oEntity);
                            nCount += 1;
                        }
                    }
                }

                MessageBox.Show("Se Proceso Correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //btnLimpiar.PerformClick();
                btnBuscar.PerformClick();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvPagadoras.Rows.Count == 0)
                {
                    MessageBox.Show("Deben existir pagadoras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cboUsuarios.Focus();
                    return;
                }

                int nCount = 0;

                foreach (DataGridViewRow row in dgvPagadoras.Rows)
                {
                    DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells[0];
                    if (chk.Value != null)
                    {
                        if (chk.Value.ToString().Equals("True"))
                        {
                            PagadoraBE oEntity = new PagadoraBE()
                            {
                                OPCION = 12,
                                USUARIO = General.General.GetUsuario,
                                IdPagadora = row.Cells["IdPagadora"].Value.ToString(),
                            };
                            new PagadoraBL().ProcesarPagadora(oEntity);
                            nCount += 1;
                        }
                    }
                }

                MessageBox.Show("Se Proceso Correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnBuscar.PerformClick();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}