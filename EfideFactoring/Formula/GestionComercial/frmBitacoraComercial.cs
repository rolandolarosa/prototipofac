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
    public partial class frmBitacoraComercial : FormulaBase.frmMntDato
    {
        private bool bPermitir = false;
        private bool bGestor = false;
        public frmBitacoraComercial()
        {
            InitializeComponent();
        }

        private void frmBitacoraComercial_Load(object sender, EventArgs e)
        {
            try
            {

                LlenarCombos(ref bGestor);
                ValidarPermisos(ref bPermitir);

                if (bPermitir)
                {
                    btnVentas.Enabled = true;
                    btnBuscar.Enabled = true;
                    cboEjecutivo.Enabled = true;
                }
                else
                {
                    if (bGestor)
                    {
                        btnVentas.Enabled = true;
                        btnBuscar.Enabled = true;
                    }
                    else
                    {
                        return;
                    }
                }

                CargarBitacoraComercial();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ValidarPermisos(ref bool bPermitir)
        {
            bPermitir = false;
            try
            {
                TableBaseBE oEntity = new TableBaseBE()
                {
                    OPCION = 1,
                    USUARIO = General.General.GetUsuario,
                    Table_Id = System.Configuration.ConfigurationManager.AppSettings["UsuariosGC"].ToString()
                };
                DataSet ds = new TableBaseBL().ProcesarTableBase(oEntity);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    string[] ArrayUsuarios = ds.Tables[0].Rows[0]["Table_Value"].ToString().Split('/');

                    foreach (string item in ArrayUsuarios)
                    {
                        if (item.Trim().Equals(General.General.GetUsuario.Trim()))
                        {
                            bPermitir = true;
                            break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarBitacoraComercial()
        {
            try
            {
                DataSet dsBitacoraComercial = new DataSet();
                BitacoraComercialBE BitacoraComercialBE = new BitacoraComercialBE()
                {
                    OPCION = 4,
                    USUARIO = General.General.GetUsuario,
                    IdSocio = Codigo,
                    IdGestor = cboEjecutivo.SelectedValue.ToString()
                };

                dsBitacoraComercial = new BitacoraComercialBL().ProcesarBitacoraComercial(BitacoraComercialBE);
                dgvBitacoraComercial.DataSource = dsBitacoraComercial.Tables[0];
                lblRegistros.Text = dsBitacoraComercial.Tables[0].Rows.Count.ToString() + " registro(s)";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            try
            {
                frmGestionComercial ofrm = new frmGestionComercial();
                ofrm._bPermitir = bPermitir;
                ofrm._bGestor = bGestor;
                ofrm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvBitacoraComercial_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //DialogResult dialogResult = 0;
            try
            {
                if (e.ColumnIndex < 0) return;
                if (e.RowIndex == -1) return;
                if (dgvBitacoraComercial.Columns[e.ColumnIndex].Name == "btnAtender")
                {
                    //dialogResult = MessageBox.Show("¿Seguro de atender el compromiso?", "Confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    //if (dialogResult == DialogResult.Yes)
                    //{
                        //DataSet dsBitacoraComercial = new DataSet();
                        //BitacoraComercialBE BitacoraComercialBE = new BitacoraComercialBE()
                        //{
                        //    OPCION = 5,
                        //    USUARIO = General.General.GetUsuario,
                        //    IdBitacoraComercial = dgvBitacoraComercial.CurrentRow.Cells["IdBitacoraComercial"].Value.ToString()
                        //};
                        //new BitacoraComercialBL().ProcesarBitacoraComercial(BitacoraComercialBE);
                        //MessageBox.Show("Se Proceso Correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmMntBitacoraComercialDato ofrm = new frmMntBitacoraComercialDato();
                    ofrm.Operacion = "M";
                    ofrm.OrigenAtender = 1;
                    ofrm.IdBitacoraComercialGenerada = dgvBitacoraComercial.Rows[e.RowIndex].Cells["IdBitacoraComercial"].Value.ToString(); // dgvBitacoraComercial.CurrentRow.Cells["IdBitacoraComercial"].Value.ToString();
                    ofrm.Codigo = dgvBitacoraComercial.Rows[e.RowIndex].Cells["IdBitacoraComercial"].Value.ToString(); // dgvBitacoraComercial.CurrentRow.Cells["IdBitacoraComercial"].Value.ToString();
                    ofrm._IdSocio = dgvBitacoraComercial.Rows[e.RowIndex].Cells["IdSocio"].Value.ToString(); //dgvBitacoraComercial.CurrentRow.Cells["IdSocio"].Value.ToString();
                    ofrm._NombreSocio = dgvBitacoraComercial.Rows[e.RowIndex].Cells["vcSocio"].Value.ToString(); //dgvBitacoraComercial.CurrentRow.Cells["vcSocio"].Value.ToString();
                    ofrm._NombreGestor = cboEjecutivo.Text;
                    ofrm._IdGestor = cboEjecutivo.SelectedValue.ToString();
                    ofrm.ShowDialog();
                    CargarBitacoraComercial();
                    //}
                }
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
                CargarBitacoraComercial();
            }
            catch (Exception ex)
            {
               MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LlenarCombos(ref bool bGestor)
        {
            bGestor = false;
            try
            {
                DataSet dsGestor = new GestionComercialBL().ProcesarGestionComercial(0, 0, "", "", 0, 3);
                General.General.LlenarCombobox(cboEjecutivo, "nombreCompleto", "gestorID", dsGestor.Tables[0], true);

                if (!string.IsNullOrEmpty(General.General.GetIdGestor.Trim()))
                {
                    cboEjecutivo.SelectedValue = General.General.GetIdGestor;
                    bGestor = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvBitacoraComercial_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                DataGridViewRow row = dgvBitacoraComercial.Rows[e.RowIndex];// get you required index
                // check the cell value under your specific column and then you can toggle your colors
                row.DefaultCellStyle.ForeColor = Color.FromName(row.Cells["ColorRow"].Value.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}