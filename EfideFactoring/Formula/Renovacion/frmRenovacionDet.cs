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

namespace EfideFactoring.Formula.Renovacion
{
    public partial class frmRenovacionDet : DevComponents.DotNetBar.OfficeForm
    {
        public string _IdRenovacion = string.Empty;
        RenovacionDetBL RenovacionDetBL = new RenovacionDetBL();
        public frmRenovacionDet()
        {
            InitializeComponent();
        }

        private void frmRenovacionDet_Load(object sender, EventArgs e)
        {
            try
            {
                RenovacionDetBE RenovacionDetBE = new RenovacionDetBE()
                {
                    USUARIO = General.General.GetCodigoUsuario,
                    OPCION = 1,
                    IdRenovacion = _IdRenovacion
                };
                DataSet dsRenovacion;
                dsRenovacion = RenovacionDetBL.ProcesarRenovacionDet(RenovacionDetBE);

                if (dsRenovacion.Tables[0].Rows.Count > 0)
                {
                    dgvRenovacionDet.DataSource = dsRenovacion.Tables[0];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}