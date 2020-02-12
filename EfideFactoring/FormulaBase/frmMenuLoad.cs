using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using EfideFactoringBE;
using EfideFactoringBL;


namespace EfideFactoring.FormulaBase
{
    public partial class frmMenuLoad : DevComponents.DotNetBar.OfficeForm
    {
        public frmMenuLoad()
        {
            InitializeComponent();
        }

        private FechaSistemaBL FechaSistemaBL = new FechaSistemaBL();

        private void frmMenuLoad_Load(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                MdiClient client = control as MdiClient;
                if (!(client == null))
                {
                    client.BackColor = System.Drawing.Color.LightGray;
                    lblusuario.Text = General.General.GetUsuario;
                    lblFecha.Text = General.General.gFechaOp.ToString().Substring(0, 10);
                    break;
                }
            }
        }

        private void mnuSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void mnuCargaDatos_Click(object sender, EventArgs e)
        {
            Formula.CargaDatos.frmCargaDatos ofrm = new Formula.CargaDatos.frmCargaDatos();
            ofrm.MdiParent = this;
            ofrm.Show();
        }

        private void mnuConsultaDatos_Click(object sender, EventArgs e)
        {
            Formula.CargaDatos.frmConsultaDatosLoad ofrm = new Formula.CargaDatos.frmConsultaDatosLoad();
            ofrm.MdiParent = this;
            ofrm.Show();
        }
    }
}