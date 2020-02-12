using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using System.Data.SqlClient;
using System.Configuration;

namespace EfideFactoring.Formula.Catalogo
{
    public partial class frmMntMagnitudDato : FormulaBase.frmMntDato
    {
        public int _MagnitudId;
        public string _ClienteId = string.Empty;
        public string _RazonSocial = string.Empty;

        public frmMntMagnitudDato()
        {
            InitializeComponent();
        }

        private void frmMntMagnitudDato_Load(object sender, EventArgs e)
        {
            try
            {
                CargarCombos();

                txtcodCliente.Text = _ClienteId;
                txtrazonSocial.Text = _RazonSocial;

                if (!string.IsNullOrEmpty(_MagnitudId.ToString()))
                {
                    cboMagnitudId.SelectedValue = _MagnitudId;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarCombos()
        {
            try
            {
                DataSet ds = new DataSet();
                ds = EjecutarSQL(3);

                cboMagnitudId.DataSource = ds.Tables[0];
                cboMagnitudId.DisplayMember = "varDescripcion";
                cboMagnitudId.ValueMember = "varCodigo";
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
                if (string.IsNullOrEmpty(cboMagnitudId.SelectedValue.ToString()))
                {
                    MessageBox.Show("Se debe seleccionar un magnitud", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cboMagnitudId.Focus();
                    return;
                }

                DialogResult dialogResult = 0;
                dialogResult = MessageBox.Show("¿Usted esta seguro de guardar los datos?", "Confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogResult == DialogResult.Yes)
                {
                    EjecutarSQL(2);
                }
                this.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private DataSet EjecutarSQL(int Opcion)
        {
            DataSet dsDatos = new DataSet();
            try
            {
                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConexionStrDBEfideFactoring"].ConnectionString))
                {
                    SqlCommand cmd1 = new SqlCommand("dbo.MagnitudPersona_Mnt", con);
                    cmd1.CommandType = CommandType.StoredProcedure;
                    cmd1.Parameters.AddWithValue("ComunTipoPerID", Codigo);
                    cmd1.Parameters.AddWithValue("MagnitudId", cboMagnitudId.SelectedValue);
                    cmd1.Parameters.AddWithValue("@Opcion", Opcion);
                    cmd1.CommandTimeout = 0;
                    SqlDataAdapter daCab = new SqlDataAdapter(cmd1);
                    daCab.Fill(dsDatos, "dtRpt_SocioEstado");
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return dsDatos;
        }
    }
}