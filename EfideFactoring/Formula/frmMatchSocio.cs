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

namespace EfideFactoring.Formula
{
    public partial class frmMatchSocio : DevComponents.DotNetBar.OfficeForm
    {
        public frmMatchSocio()
        {
            InitializeComponent();
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = 0;
            try
            {   
                dialogResult = MessageBox.Show("Seguro de procesar la aplicación de CXP y CXC ?" , "Confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogResult == DialogResult.Yes)
                {
                   General.msgHelper.Wait("Procesando, espere un momento ...");
                   DataSet dsResultado = new DataSet();
                   using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConexionStrDBEfideFactoring"].ConnectionString))
                   {
                       SqlCommand cmd1 = new SqlCommand("Match_Socios", con);
                       cmd1.CommandType = CommandType.StoredProcedure;
                       cmd1.Parameters.AddWithValue("@gFechaOp", General.General.gFechaOp);
                       cmd1.Parameters.AddWithValue("@gSesionID", General.General.gSesionID);
                       cmd1.Parameters.AddWithValue("@gPlazaID", General.General.gPlazaID);
                       cmd1.Parameters.AddWithValue("@Usuario", General.General.GetUsuario);
                       cmd1.CommandTimeout = 0;
                       cmd1.Parameters.AddWithValue("@Opcion", 1);
                       SqlDataAdapter daCab = new SqlDataAdapter(cmd1);
                       daCab.Fill(dsResultado, "Renovacion");
                       con.Close();
                   }
                   General.msgHelper.Wait();
                   MessageBox.Show("Se Proceso Correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}