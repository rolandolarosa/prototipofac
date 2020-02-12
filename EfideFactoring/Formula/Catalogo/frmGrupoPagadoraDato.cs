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
    public partial class frmGrupoPagadoraDato : FormulaBase.frmMntDato
    {
        GrupoPagadoraBL GrupoPagadoraBL = new GrupoPagadoraBL();
        GrupoPagadoraDetalleBL GrupoPagadoraDetalleBL = new GrupoPagadoraDetalleBL();
        PagadoraBL PagadoraBL = new PagadoraBL();
        TableBaseBL TableBaseBL = new TableBaseBL();
        public DataTable dtPagadoras = new DataTable();

        public frmGrupoPagadoraDato()
        {
            InitializeComponent();
        }

        #region Eventos ---------------------------------------------
        private void frmGrupoPagadoraDato_Load(object sender, EventArgs e)
        {
            LlenarCombos();

            dtPagadoras.Columns.Add("IdPagadora", Type.GetType("System.String"));
            dtPagadoras.Columns.Add("vcPagadora", Type.GetType("System.String"));
            dgvPagadoras.DataSource = dtPagadoras;

            if (Operacion.Equals("N"))
            {
            }
            else if (Operacion.Equals("M"))
            {
                txtIdGrupoPagadora.Text = Codigo;
                CargarDatos();
            }
            else
            {
                txtIdGrupoPagadora.Text = Codigo;
                btnAceptar.Enabled = false;
            }
        }

        private void btnIncrementa_Click(object sender, EventArgs e)
        {
            if (string.Empty.Equals(txtIdGrupoPagadora.Text.Trim()))
            {
                if (ValidaIngresoPagadoraGrupo())
                {
                    DataSet dsGrupoPagadora = new DataSet();
                    GrupoPagadoraBE GrupoPagadoraBE = new GrupoPagadoraBE();
                    GrupoPagadoraBE = CargarEntidades();

                    dsGrupoPagadora = GrupoPagadoraBL.ProcesarGrupoPagadora(GrupoPagadoraBE);
                    txtIdGrupoPagadora.Text = dsGrupoPagadora.Tables[0].Rows[0]["IdGrupoPagadora"].ToString();
                }
                else { return; }
            }

            Formula.Catalogo.frmGrupoPagadoraLinea ofrmGrupoPagadoraLinea = new Formula.Catalogo.frmGrupoPagadoraLinea();
            ofrmGrupoPagadoraLinea.IdGrupoPagadora = txtIdGrupoPagadora.Text;
            ofrmGrupoPagadoraLinea.TipoOperacion = "I";
            ofrmGrupoPagadoraLinea.ShowDialog();
            CargarDatos();
        }

        private void btnReduce_Click(object sender, EventArgs e)
        {
            if (string.Empty.Equals(txtIdGrupoPagadora.Text.Trim()))
            {
                if (ValidaIngresoPagadoraGrupo())
                {
                    DataSet dsGrupoPagadora = new DataSet();
                    GrupoPagadoraBE GrupoPagadoraBE = new GrupoPagadoraBE();
                    GrupoPagadoraBE = CargarEntidades();

                    dsGrupoPagadora = GrupoPagadoraBL.ProcesarGrupoPagadora(GrupoPagadoraBE);
                    txtIdGrupoPagadora.Text = dsGrupoPagadora.Tables[0].Rows[0]["IdGrupoPagadora"].ToString();
                }
                else { return; }
            }

            Formula.Catalogo.frmGrupoPagadoraLinea ofrmGrupoPagadoraLinea = new Formula.Catalogo.frmGrupoPagadoraLinea();
            ofrmGrupoPagadoraLinea.IdGrupoPagadora = txtIdGrupoPagadora.Text;
            ofrmGrupoPagadoraLinea.TipoOperacion = "R";
            ofrmGrupoPagadoraLinea.ShowDialog();
            CargarDatos();
        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            Formula.Catalogo.frmGrupoPagadoraLog ofrmGrupoPagadoraLog = new Formula.Catalogo.frmGrupoPagadoraLog();
            ofrmGrupoPagadoraLog.IdGrupoPagadora = txtIdGrupoPagadora.Text.Trim();
            ofrmGrupoPagadoraLog.GrupoPagadora = txtvcGrupo.Text.Trim();
            ofrmGrupoPagadoraLog.ShowDialog();
        }

        private void btnAgregarPagadora_Click(object sender, EventArgs e)
        {
            try
            {
                Formula.Consulta.frmBusquedaPagadora ofrmBusquedaPagadora = new Consulta.frmBusquedaPagadora();
                ofrmBusquedaPagadora.ShowDialog();

                DataSet dsPagadora = new DataSet();
                PagadoraBE PagadoraBE = new PagadoraBE()
                {
                    OPCION = 1,
                    USUARIO = General.General.GetCodigoUsuario,
                    IdPagadora = ofrmBusquedaPagadora.CodigoPagadora.ToString()
                };

                dsPagadora = PagadoraBL.ProcesarPagadora(PagadoraBE);

                if (dsPagadora.Tables[0].Rows.Count > 0)
                {
                    if (Operacion.Equals("M"))
                    {
                        if (dtPagadoras.Rows.Count == 0)
                        {
                            foreach (DataGridViewRow row in dgvPagadoras.Rows)
                            {
                                dtPagadoras.Rows.Add(row.Cells["IdPagadora"].Value, row.Cells["Pagadora"].Value);
                            }
                        }

                        dtPagadoras.Rows.Add(dsPagadora.Tables[0].Rows[0]["IdPagadora"].ToString(), dsPagadora.Tables[0].Rows[0]["vcPagadora"].ToString());
                        dgvPagadoras.DataSource = dtPagadoras;
                        dgvPagadoras.Refresh();
                        return;
                    }

                    dtPagadoras.Rows.Add(dsPagadora.Tables[0].Rows[0]["IdPagadora"].ToString(), dsPagadora.Tables[0].Rows[0]["vcPagadora"].ToString());
                    dgvPagadoras.Refresh();
                }

                lblRegistros.Text = dtPagadoras.Rows.Count.ToString() + " registro(s)";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnQuitarPagadora_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = 0;
            try
            {
                if (dgvPagadoras.RowCount > 0)
                {
                    dialogResult = MessageBox.Show("Seguro de Eliminar la Pagadora: " + dgvPagadoras.CurrentRow.Cells["Pagadora"].Value.ToString().Trim(), "Confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dialogResult == DialogResult.Yes)
                    {
                        if (!String.IsNullOrEmpty(txtIdGrupoPagadora.Text.Trim()))
                        {
                            GrupoPagadoraDetalleBE GrupoPagadoraDetalleBE = new GrupoPagadoraDetalleBE();
                            GrupoPagadoraDetalleBE.OPCION = 3;
                            GrupoPagadoraDetalleBE.USUARIO = General.General.GetCodigoUsuario;
                            GrupoPagadoraDetalleBE.IdGrupoPagadora = txtIdGrupoPagadora.Text.Trim();
                            GrupoPagadoraDetalleBE.IdPagadora = dgvPagadoras.CurrentRow.Cells["IdPagadora"].Value.ToString();
                            GrupoPagadoraDetalleBL.ProcesarGrupoPagadoraDetalle(GrupoPagadoraDetalleBE);
                            MessageBox.Show("Se Proceso Correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            CargarDetalle(txtIdGrupoPagadora.Text.Trim());
                        }
                    }
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
                if (string.IsNullOrEmpty(txtvcGrupo.Text.Trim()))
                {
                    MessageBox.Show("Se debe Ingresar el nombre del Grupo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtvcGrupo.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(cboIdCargo_tt.SelectedValue.ToString()))
                {
                    MessageBox.Show("Se debe seleccionar un Cargo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cboIdCargo_tt.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(txtvcContacto.Text.Trim()))
                {
                    MessageBox.Show("Se debe Ingresar nombre de Contacto", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtvcContacto.Focus();
                    return;
                }

                if (dtPagadoras.Rows.Count == 0)
                {
                    MessageBox.Show("Debe agregar al menos una pagadora.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    btnAgregarPagadora.Focus();
                    return;
                }

                DataSet dsGrupoPagadoraBE = new DataSet();
                GrupoPagadoraBE GrupoPagadoraBE = new GrupoPagadoraBE()
                {
                    OPCION = 2,
                    USUARIO = General.General.GetCodigoUsuario,
                    IdGrupoPagadora = txtIdGrupoPagadora.Text.Trim(),
                    vcGrupo = txtvcGrupo.Text.Trim(),
                    IdCargo_tt = cboIdCargo_tt.SelectedValue.ToString(),
                    vcContacto = txtvcContacto.Text.Trim(),
                    vcTelefono1 = mskvcTelefono1.Text.Trim(),
                    vcTelefono2 = mskvcTelefono2.Text.Trim(),
                    vcAnexo = txtvcAnexo.Text.Trim(),
                    vcCelular = mskvcCelular.Text.Trim(),
                    vcEmail = txtvcEmail.Text.Trim()
                };

                dsGrupoPagadoraBE = GrupoPagadoraBL.ProcesarGrupoPagadora(GrupoPagadoraBE);
                if (dsGrupoPagadoraBE.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow row in dtPagadoras.Rows)
                    {
                        GrupoPagadoraDetalleBE GrupoPagadoraDetalleBE = new GrupoPagadoraDetalleBE()
                        {
                            OPCION = 2,
                            USUARIO = General.General.GetCodigoUsuario,
                            IdGrupoPagadora = dsGrupoPagadoraBE.Tables[0].Rows[0]["IdGrupoPagadora"].ToString(),
                            IdPagadora = row["IdPagadora"].ToString()
                        };
                        GrupoPagadoraDetalleBL.ProcesarGrupoPagadoraDetalle(GrupoPagadoraDetalleBE);
                    }
                }

                MessageBox.Show("Se Proceso Correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Metodos ---------------------------------------------
        private void LlenarCombos()
        {
            String Table_Id = "00009";
            TableBaseBE TableBaseBE = new TableBaseBE()
            {
                OPCION = 1,
                USUARIO = General.General.GetCodigoUsuario,
                Table_Parent_Id = Table_Id
            };

            General.General.LlenarCombobox(cboIdCargo_tt, "Table_Name", "Table_Id", TableBaseBL.ProcesarTableBase(TableBaseBE).Tables[0]);
        }

        private void CargarDatos()
        {
            try
            {
                DataSet dsGrupoPagadora = new DataSet();
                GrupoPagadoraBE GrupoPagadoraBE = new GrupoPagadoraBE()
                {
                    OPCION = 1,
                    USUARIO = General.General.GetCodigoUsuario,
                    IdGrupoPagadora = txtIdGrupoPagadora.Text.Trim()
                };

                dsGrupoPagadora = GrupoPagadoraBL.ProcesarGrupoPagadora(GrupoPagadoraBE);

                if (dsGrupoPagadora.Tables[0].Rows.Count > 0)
                {
                    txtvcGrupo.Text = dsGrupoPagadora.Tables[0].Rows[0]["vcGrupo"].ToString();
                    cboIdCargo_tt.SelectedValue = dsGrupoPagadora.Tables[0].Rows[0]["IdCargo_tt"].ToString();
                    txtvcContacto.Text = dsGrupoPagadora.Tables[0].Rows[0]["vcContacto"].ToString();
                    mskvcTelefono1.Text = dsGrupoPagadora.Tables[0].Rows[0]["vcTelefono1"].ToString();
                    mskvcTelefono2.Text = dsGrupoPagadora.Tables[0].Rows[0]["vcTelefono2"].ToString();
                    txtvcAnexo.Text = dsGrupoPagadora.Tables[0].Rows[0]["vcAnexo"].ToString();
                    mskvcCelular.Text = dsGrupoPagadora.Tables[0].Rows[0]["vcCelular"].ToString();
                    txtvcEmail.Text = dsGrupoPagadora.Tables[0].Rows[0]["vcEmail"].ToString();
                    txtnLinea.Text = Convert.ToDecimal(dsGrupoPagadora.Tables[0].Rows[0]["nLinea"]).ToString("N2");
                    txtnUtilizado.Text = Convert.ToDecimal(dsGrupoPagadora.Tables[0].Rows[0]["nUtilizado"]).ToString("N2");
                    txtSaldo.Text = (Convert.ToDecimal(dsGrupoPagadora.Tables[0].Rows[0]["nLinea"]) - Convert.ToDecimal(dsGrupoPagadora.Tables[0].Rows[0]["nUtilizado"])).ToString("N2");
                    dtFechaVencimiento.Value = !String.IsNullOrEmpty(dsGrupoPagadora.Tables[0].Rows[0]["dtFechaVencimiento"].ToString()) ? Convert.ToDateTime(dsGrupoPagadora.Tables[0].Rows[0]["dtFechaVencimiento"]) : Convert.ToDateTime("01/01/1900");
                    EvaluarMoneda(dsGrupoPagadora.Tables[0].Rows[0]["IdMoneda_tt"].ToString());
                    CargarDetalle(txtIdGrupoPagadora.Text.Trim());
                }
                else
                {
                    MessageBox.Show("Este Grupo no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarDetalle(String IdGrupoPagadora)
        {
            DataSet dsGrupoPagadoraDetalle = new DataSet();
            GrupoPagadoraDetalleBE GrupoPagadoraDetalleBE = new EfideFactoringBE.GrupoPagadoraDetalleBE()
            {
                OPCION = 1,
                USUARIO = General.General.GetCodigoUsuario,
                IdGrupoPagadora = IdGrupoPagadora
            };

            dsGrupoPagadoraDetalle = GrupoPagadoraDetalleBL.ProcesarGrupoPagadoraDetalle(GrupoPagadoraDetalleBE);

            if (dsGrupoPagadoraDetalle.Tables[0].Rows.Count > 0)
            {
                dgvPagadoras.DataSource = dsGrupoPagadoraDetalle.Tables[0];
            }

            lblRegistros.Text = dgvPagadoras.Rows.Count.ToString() + " registro(s)";
        }

        private GrupoPagadoraBE CargarEntidades()
        {
            GrupoPagadoraBE GrupoPagadoraBE = new GrupoPagadoraBE()
            {
                OPCION = 2,
                USUARIO = General.General.GetCodigoUsuario,
                IdGrupoPagadora = txtIdGrupoPagadora.Text.Trim(),
                vcGrupo = txtvcGrupo.Text.Trim(),
                IdCargo_tt = cboIdCargo_tt.SelectedValue.ToString(),
                vcContacto = txtvcContacto.Text.Trim(),
                vcTelefono1 = mskvcTelefono1.Text.Trim(),
                vcTelefono2 = mskvcTelefono2.Text.Trim(),
                vcAnexo = txtvcAnexo.Text.Trim(),
                vcCelular = mskvcCelular.Text.Trim(),
                vcEmail = txtvcEmail.Text.Trim()
            };
            return GrupoPagadoraBE;
        }

        private bool ValidaIngresoPagadoraGrupo()
        {
            bool flg = true;
            if (string.IsNullOrEmpty(txtvcGrupo.Text.Trim()))
            {
                MessageBox.Show("Se debe Ingresar el nombre del Grupo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtvcGrupo.Focus();
                flg = false;
            }

            if (string.IsNullOrEmpty(cboIdCargo_tt.SelectedValue.ToString()))
            {
                MessageBox.Show("Se debe seleccionar un Cargo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cboIdCargo_tt.Focus();
                flg = false;
            }

            if (string.IsNullOrEmpty(txtvcContacto.Text.Trim()))
            {
                MessageBox.Show("Se debe Ingresar nombre de Contacto", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtvcContacto.Focus();
                flg = false;
            }
            return flg;
        }

        private void EvaluarMoneda(string IdMoneda)
        {
            if (IdMoneda.Equals("1"))
            {
                lnlSimbolo1.Text = "S/.";
                lnlSimbolo2.Text = "S/.";
                lnlSimbolo3.Text = "S/.";
            }
            else if (IdMoneda.Equals("2"))
            {
                lnlSimbolo1.Text = "US$";
                lnlSimbolo2.Text = "US$";
                lnlSimbolo3.Text = "US$";
            }
            else
            {
                lnlSimbolo1.Text = "S/.";
                lnlSimbolo2.Text = "S/.";
                lnlSimbolo3.Text = "S/.";
            }
        }
        #endregion
    }
}