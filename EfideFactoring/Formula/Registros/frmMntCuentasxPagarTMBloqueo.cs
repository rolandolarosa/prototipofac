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

namespace EfideFactoring.Formula.Registros
{
    public partial class frmMntCuentasxPagarTMBloqueo : FormulaBase.frmMntFiltro
    {
        public frmMntCuentasxPagarTMBloqueo()
        {
            InitializeComponent();
        }

        #region Eventos
        private void frmMntCuentasxPagarTMBloqueo_Load(object sender, EventArgs e)
        {
            try
            {
                // customize dataviewgrid, add checkbox column
                DataGridViewCheckBoxColumn ChkBoxColumn = new DataGridViewCheckBoxColumn();
                ChkBoxColumn.Width = 30;
                ChkBoxColumn.Name = "CheckSel";
                ChkBoxColumn.HeaderText = "";
                ChkBoxColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvDatos.Columns.Insert(0, ChkBoxColumn);

                // add checkbox header
                Rectangle rect = dgvDatos.GetCellDisplayRectangle(0, -1, true);
                // set checkbox header to center of header cell. +1 pixel to position correctly.
                rect.X = rect.Location.X + (rect.Width / 5);
                

                CheckBox ChkBoxHeader = new CheckBox();
                ChkBoxHeader.Name = "CheckSel";
                ChkBoxHeader.Size = new Size(25, 25);
                ChkBoxHeader.Location = rect.Location;
                ChkBoxHeader.Text = "";
                ChkBoxHeader.ForeColor = Color.Transparent;
                ChkBoxHeader.BackColor = Color.Transparent;
                ChkBoxHeader.CheckedChanged += new EventHandler(ChkBoxHeader_CheckedChanged);
                dgvDatos.Controls.Add(ChkBoxHeader);

                chkCuentasBloqueadas.Checked = true;
                btnEliminar.Enabled = true;
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
                for (int i = 0; i < dgvDatos.RowCount; i++)
                {
                    dgvDatos[0, i].Value = ((CheckBox)dgvDatos.Controls.Find("CheckSel", true)[0]).Checked;
                }
                dgvDatos.EndEdit();
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
                ofrmBusquedaSocio.ShowDialog();
                TextBoxX1.Text = ofrmBusquedaSocio.CodSocio.Trim();
                txtRazonSocialSocio.Text = ofrmBusquedaSocio.RazorSocialSocio.Trim();
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
                BuscarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
        }

        private void chkCuentasBloqueadas_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                btnEliminar.Enabled = false;
                btnBloquear.Enabled = false;
                if (chkCuentasBloqueadas.Checked)
                {
                    btnEliminar.Enabled = true;
                }
                else
                {
                    btnBloquear.Enabled = true;
                }

                BuscarDatos();
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
                if (dgvDatos.RowCount > 0)
                {
                    dialogResult = MessageBox.Show("Seguro de desbloquear las cuentas por pagar seleccionadas?", "Confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        int count = 0;
                        foreach (DataGridViewRow row in dgvDatos.Rows)
                        {
                            DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells["CheckSel"];
                            if (chk.Value != null)
                            {
                                if (chk.Value.ToString().Equals("True"))
                                {
                                    CuentasxPagarTMBloqueoBE oEntity = new CuentasxPagarTMBloqueoBE();
                                    oEntity.OPCION = 3;
                                    oEntity.USUARIO = General.General.GetCodigoUsuario;
                                    oEntity.ctaPagarID = row.Cells["ctaPagarID"].Value.ToString();
                                    new CuentasxPagarTMBloqueoBL().ProcesarCuentasxPagarTMBloqueo(oEntity);
                                    count++;
                                }
                            }
                        }

                        if (count > 0)
                        {
                            MessageBox.Show("Se Proceso Correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            BuscarDatos();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBloquear_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = 0;
            try
            {
                if (dgvDatos.RowCount > 0)
                {
                    dialogResult = MessageBox.Show("Seguro de bloquear las cuentas por pagar seleccionadas?", "Confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        int count = 0;
                        foreach (DataGridViewRow row in dgvDatos.Rows)
                        {
                            DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells["CheckSel"];
                            if (chk.Value != null)
                            {
                                if (chk.Value.ToString().Equals("True"))
                                {
                                    CuentasxPagarTMBloqueoBE oEntity = new CuentasxPagarTMBloqueoBE();
                                    oEntity.OPCION = 2;
                                    oEntity.USUARIO = General.General.GetCodigoUsuario;
                                    oEntity.ctaPagarID = row.Cells["ctaPagarID"].Value.ToString();
                                    new CuentasxPagarTMBloqueoBL().ProcesarCuentasxPagarTMBloqueo(oEntity);
                                    count++;
                                }
                            }
                        }

                        if (count > 0)
                        {
                            MessageBox.Show("Se Proceso Correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            BuscarDatos();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Metodos

        private void BuscarDatos()
        {
            try
            {
                CuentasxPagarTMBloqueoBE oEntity = new CuentasxPagarTMBloqueoBE();
                oEntity.OPCION = chkCuentasBloqueadas.Checked ? 1: 4;
                oEntity.USUARIO = General.General.GetCodigoUsuario;
                oEntity.IdSocio = TextBoxX1.Text;
                oEntity.IdPagadora = txtIdPagadora.Text;
                DataSet ds = new CuentasxPagarTMBloqueoBL().ProcesarCuentasxPagarTMBloqueo(oEntity);
                dgvDatos.DataSource = ds.Tables[0];
                lblRegistros.Text = ds.Tables[0].Rows.Count + " registro(s)";

                ((CheckBox)dgvDatos.Controls.Find("CheckSel", true)[0]).Checked = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        private void dgvDatos_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            try
            {
                // Referenciamos el control DataGridViewCheckBoxCell actual 
                DataGridViewCheckBoxCell cb = new DataGridViewCheckBoxCell();
                if (cb != null)
                {
                    //Confirmammos los cambios efectuados en la celda actual 
                    dgvDatos.CommitEdit(DataGridViewDataErrorContexts.Commit);
                }
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

                if (!string.IsNullOrEmpty(ofrmBusquedaPagadora.CodigoPagadora.ToString()))
                {
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
                TextBoxX1.Clear();
                txtRazonSocialSocio.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiarPagadora_Click(object sender, EventArgs e)
        {
            try
            {
                txtIdPagadora.Clear();
                txtDescripcion.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiarSocio_Click(object sender, EventArgs e)
        {
            try
            {
                TextBoxX1.Clear();
                txtRazonSocialSocio.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}