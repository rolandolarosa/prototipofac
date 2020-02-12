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

namespace EfideFactoring.Formula.Consulta
{
    public partial class frmQryCuotaCredito : FormulaBase.frmMntDato
    {
        public frmQryCuotaCredito()
        {
            InitializeComponent();
        }

        private void frmQryCuotaCredito_Load(object sender, EventArgs e)
        {
            try
            {
                DataSet dsDatos = new DataSet();
                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConexionStrDBEfideFactoring"].ConnectionString))
                {
                    SqlCommand cmd1 = new SqlCommand("dbo.GestionCobranza_Qry", con);
                    cmd1.CommandType = CommandType.StoredProcedure;
                    cmd1.Parameters.AddWithValue("@creditoID", Codigo);
                    cmd1.Parameters.AddWithValue("@Opcion", 8);
                    cmd1.CommandTimeout = 0;
                    SqlDataAdapter daCab = new SqlDataAdapter(cmd1);
                    daCab.Fill(dsDatos, "dtDatos");
                    con.Close();
                }

                dgvDatos.DataSource = dsDatos.Tables[0];

                decimal SaldoTotal = 0;
                decimal AcTotalCapital = 0;
                decimal AcTotalInteres = 0;
                decimal AcTotal = 0;
                foreach (DataGridViewRow row in dgvDatos.Rows)
                {
                    SaldoTotal = Convert.ToDecimal(row.Cells["Saldo"].Value.ToString());
                    AcTotalCapital = AcTotalCapital + Convert.ToDecimal(row.Cells["Importe"].Value.ToString());
                    AcTotalInteres = AcTotalInteres + Convert.ToDecimal(row.Cells["Interes"].Value.ToString());
                    AcTotal = AcTotal + Convert.ToDecimal(row.Cells["Total"].Value.ToString());
                }

                lblSaldoTotal.Text = SaldoTotal.ToString("N2");
                lblTotalCapital.Text = AcTotalCapital.ToString("N2");
                lblTotalInteres.Text = AcTotalInteres.ToString("N2");
                lblTotal.Text = AcTotal.ToString("N2");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}