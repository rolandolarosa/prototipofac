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
    public partial class frmPagadoraContacto : FormulaBase.frmMntDato
    {
        PagadoraContactoBL PagadoraContactoBL = new PagadoraContactoBL();
        TableBaseBL TableBaseBL = new TableBaseBL();
        public string IdPagadora = String.Empty;

        public frmPagadoraContacto()
        {
            InitializeComponent();
        }

        #region Eventos ---------------------------------------------
        private void frmPagadoraContacto_Load(object sender, EventArgs e)
        {
            LlenarCombos(); 
            txtIdPagadora.Text = IdPagadora.ToString().Trim();

            if (Operacion.Equals("M"))
            {
                CargaDatos();
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(cboIdCargo_tt.SelectedValue.ToString()))
                {
                    MessageBox.Show("Se debe seleccionar un cargo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cboIdCargo_tt.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(txtvcContacto.Text.Trim()))
                {
                    MessageBox.Show("Se debe ingresar el contacto", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtvcContacto.Focus();
                    return;
                }


                if (string.IsNullOrEmpty(MskvcTelefono1.Text.Trim().Replace("-", "")))
                {
                    MessageBox.Show("Se debe Ingresar un nro. de teléfono", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    MskvcTelefono1.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(txtvcAnexo.Text.Trim()))
                {
                    MessageBox.Show("Se debe Ingresar un anexo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtvcAnexo.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(txtvcEmail.Text.Trim().Replace("-", "")))
                {
                    MessageBox.Show("Se debe Ingresar el correo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtvcEmail.Focus();
                    return;
                }

                PagadoraContactoBE PagadoraContactoBE = new PagadoraContactoBE()
                {
                    OPCION = 2,
                    USUARIO = General.General.GetCodigoUsuario,
                    IdPagadora = txtIdPagadora.Text.Trim(),
                    IdItemCtc = Codigo,
                    IdCargo_tt = cboIdCargo_tt.SelectedValue.ToString(),
                    vcContacto = txtvcContacto.Text.Trim(),
                    vcTelefono1 = MskvcTelefono1.Text,
                    vcTelefono2 = MskvcTelefono2.Text,
                    vcAnexo = txtvcAnexo.Text.Trim(),
                    vcCelular = MskvcCelular.Text,
                    vcEmail = txtvcEmail.Text,
                    dtCumpleano = dtCumpleano.Value,
                    bEntregaLetra = chkbEntregaLetra.Checked == true ? true : false,
                    bEnvioDocumentacion = chkbEnvioDocumentacion.Checked == true ? true : false,
                };

                PagadoraContactoBL.ProcesarPagadoraContacto(PagadoraContactoBE);
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

            //cboIdCargo_tt.DataSource = TableBaseBL.ProcesarTableBase(TableBaseBE).Tables[0];
            //cboIdCargo_tt.DisplayMember = "Table_Name";
            //cboIdCargo_tt.ValueMember = "Table_Id";

        }

        private void CargaDatos()
        {
            try
            {
                DataSet ds = new DataSet();
                PagadoraContactoBE oEntity = new PagadoraContactoBE()
                {
                    OPCION = 1,
                    USUARIO = General.General.GetUsuario,
                    IdPagadora = txtIdPagadora.Text,
                    IdItemCtc = Codigo
                };
                ds = new PagadoraContactoBL().ProcesarPagadoraContacto(oEntity);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    cboIdCargo_tt.SelectedValue = ds.Tables[0].Rows[0]["IdCargo_tt"].ToString();
                    txtvcContacto.Text = ds.Tables[0].Rows[0]["vcContacto"].ToString();
                    MskvcTelefono1.Text = ds.Tables[0].Rows[0]["vcTelefono1"].ToString();
                    MskvcTelefono2.Text = ds.Tables[0].Rows[0]["vcTelefono2"].ToString();
                    txtvcAnexo.Text = ds.Tables[0].Rows[0]["vcAnexo"].ToString();
                    MskvcCelular.Text = ds.Tables[0].Rows[0]["vcCelular"].ToString();
                    txtvcEmail.Text = ds.Tables[0].Rows[0]["vcEmail"].ToString();
                    if (!string.IsNullOrEmpty(ds.Tables[0].Rows[0]["dtCumpleano"].ToString().Trim())) { dtCumpleano.Value = Convert.ToDateTime(ds.Tables[0].Rows[0]["dtCumpleano"].ToString()); }
                    chkbEntregaLetra.CheckValue = ds.Tables[0].Rows[0]["bEntregaLetra"];
                    chkbEnvioDocumentacion.CheckValue = ds.Tables[0].Rows[0]["bEnvioDocumentacion"];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
    }
}