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
    public partial class frmMntMagnitud : FormulaBase.frmMntFiltro
    {
        public frmMntMagnitud()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                CargarDatos();
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
                DataSet dsDatos = new DataSet();
                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConexionStrDBEfideFactoring"].ConnectionString))
                {
                    SqlCommand cmd1 = new SqlCommand("dbo.MagnitudPersona_Mnt", con);
                    cmd1.CommandType = CommandType.StoredProcedure;
                    cmd1.Parameters.AddWithValue("@RazonSocial", TextBoxX1.Text);
                    cmd1.Parameters.AddWithValue("@Opcion", 1);
                    cmd1.CommandTimeout = 0;
                    SqlDataAdapter daCab = new SqlDataAdapter(cmd1);
                    daCab.Fill(dsDatos, "dtRpt_SocioEstado");
                    con.Close();
                }

                dgvMagnitud.DataSource = dsDatos.Tables[0];
                lblRegistros.Text = dsDatos.Tables[0].Rows.Count.ToString() + " registro(s)";
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
                if (dgvMagnitud.RowCount > 0)
                {
                    frmMntMagnitudDato ofrmMntTarifarioDato = new frmMntMagnitudDato();
                    ofrmMntTarifarioDato.Operacion = "M";
                    ofrmMntTarifarioDato.Codigo = dgvMagnitud.CurrentRow.Cells["ComunTipoPerID"].Value.ToString();
                    ofrmMntTarifarioDato._ClienteId = dgvMagnitud.CurrentRow.Cells["codCliente"].Value.ToString();
                    ofrmMntTarifarioDato._RazonSocial = dgvMagnitud.CurrentRow.Cells["razonSocial"].Value.ToString();
                    ofrmMntTarifarioDato._MagnitudId = string.IsNullOrEmpty(dgvMagnitud.CurrentRow.Cells["MagnitudId"].Value.ToString()) ? 0 : int.Parse(dgvMagnitud.CurrentRow.Cells["MagnitudId"].Value.ToString());
                    ofrmMntTarifarioDato.ShowDialog();
                    btnBuscar.PerformClick();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmMntMagnitud_Load(object sender, EventArgs e)
        {
            try
            {
                btnBuscar.PerformClick();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}