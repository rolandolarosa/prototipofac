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
    public partial class frmAsignarSocio : FormulaBase.frmMntFiltro
    {
        public frmAsignarSocio()
        {
            InitializeComponent();
        }

        private void frmAsignarSocio_Load(object sender, EventArgs e)
        {
            try
            {
                // customize dataviewgrid, add checkbox column
                DataGridViewCheckBoxColumn ChkBoxColumn = new DataGridViewCheckBoxColumn();
                ChkBoxColumn.Width = 30;
                ChkBoxColumn.Name = "ChkSelAsignar";
                ChkBoxColumn.HeaderText = "";
                ChkBoxColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvSocios.Columns.Insert(0, ChkBoxColumn);

                // add checkbox header
                Rectangle rect = dgvSocios.GetCellDisplayRectangle(0, -1, true);
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
                dgvSocios.Controls.Add(ChkBoxHeader);

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

                //DataRow dr1;
                //dr1 = dt.NewRow();
                //dr1["nombreCompleto"] = "--Sin Asignar Ejecutivo--";
                //dr1["gestorID"] = "SinAsignar";
                //dt.Rows.InsertAt(dr1, 1);

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
                for (int i = 0; i < dgvSocios.RowCount; i++)
                {
                    dgvSocios[0, i].Value = ((CheckBox)dgvSocios.Controls.Find("ChkSelAsignar", true)[0]).Checked;
                }
                dgvSocios.EndEdit();
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
                //if (string.IsNullOrEmpty(txtIdPagadora.Text.Trim()) && string.IsNullOrEmpty(txtIdSocio.Text.Trim()) && dtFechaInicio.Value == null)
                //{
                //    MessageBox.Show("Al menos debe ingresar un filtro", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //    return;
                //}

                CarteraSocioBE oEntity = new CarteraSocioBE()
                {
                    OPCION = 4,
                    USUARIO = General.General.GetUsuario,
                    IdSocio = txtIdSocio.Text,
                    gestorCuentaID = cboEjecutivo.SelectedValue.ToString(),
                    IdPagadora = txtIdPagadora.Text,
                    FechaInicio = dtFechaInicio.Value == null ? DateTime.MinValue : dtFechaInicio.Value,
                    FechaFin = dtFechaFin.Value == null ? DateTime.MinValue : dtFechaFin.Value,
                    FechaInactivo1 = dtFechaInactivo1.Value == null ? DateTime.MinValue : dtFechaInactivo1.Value,
                    FechaInactivo2 = dtFechaInactivo2.Value == null ? DateTime.MinValue : dtFechaInactivo2.Value,
                    NumDias = chkSociosInactivos.Checked ? 1 : 0
                };
                DataSet ds = new DataSet();
                ds = new CarteraSocioBL().ProcesarCarteraSocio(oEntity);
                dgvSocios.DataSource = ds.Tables[0];
                lblNRegistros.Text = ds.Tables[0].Rows.Count.ToString() + " registro(s)";

                ((CheckBox)dgvSocios.Controls.Find("ChkSelAsignar", true)[0]).Checked = false;
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
                chkSociosInactivos.Checked = false;
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

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvSocios.Rows.Count == 0)
                {
                    MessageBox.Show("Deben existir socios", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cboUsuarios.Focus();
                    return;
                }

                if (dgvUsuarios.Rows.Count == 0)
                {
                    MessageBox.Show("Agregar al menos un usuario para la distribución", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cboUsuarios.Focus();
                    return;
                }

                int nDistribucion = Math.Abs(dgvSocios.Rows.Count / dgvUsuarios.Rows.Count);
                int nCountUsuario = dgvUsuarios.Rows.Count;
                int nRowUsuario = 0;
                int nCount = 0;

                foreach (DataGridViewRow row in dgvSocios.Rows)
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

                            CarteraSocioBE oEntity = new CarteraSocioBE()
                            {
                                OPCION = 2,
                                USUARIO = General.General.GetUsuario,
                                IdSocio = row.Cells["IdSocio"].Value.ToString(),
                                UsuarioID = dgvUsuarios.Rows[nRowUsuario].Cells["gestorID"].Value.ToString(),
                            };
                            new CarteraSocioBL().ProcesarCarteraSocio(oEntity);
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

        private void btnBusquedaSocio_Click(object sender, EventArgs e)
        {
            try
            {
                Formula.Consulta.frmBusquedaSocio ofrmBusquedaSocio = new Formula.Consulta.frmBusquedaSocio();
                ofrmBusquedaSocio._Opcion = 9;
                ofrmBusquedaSocio.ShowDialog();
                txtIdSocio.Text = ofrmBusquedaSocio.CodSocio.Trim();
                txtRazonSocialSocio.Text = ofrmBusquedaSocio.RazorSocialSocio.Trim();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void dgvSocios_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                DataGridViewRow row = dgvSocios.Rows[e.RowIndex];// get you required index
                // check the cell value under your specific column and then you can toggle your colors

                row.Cells["Clasificacion"].Style.ForeColor = Color.FromName(row.Cells["ColorRow"].Value.ToString());
                //row.DefaultCellStyle.ForeColor = Color.FromName(row.Cells["ColorRow"].Value.ToString());
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

        private void chkSociosInactivos_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                dtFechaInactivo1.Value = DateTime.MinValue;
                dtFechaInactivo2.Value = DateTime.MinValue;
                dtFechaInactivo1.Enabled = false;
                dtFechaInactivo2.Enabled = false;

                if (chkSociosInactivos.Checked)
                {
                    dtFechaInactivo1.Enabled = true;
                    dtFechaInactivo2.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}