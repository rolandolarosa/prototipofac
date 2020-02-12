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
    public partial class frmGeneracionLoteMensaje : DevComponents.DotNetBar.OfficeForm
    {
        public string _IdLote = string.Empty;
        public frmGeneracionLoteMensaje()
        {
            InitializeComponent();
        }

        private void frmGeneracionLoteMensaje_Load(object sender, EventArgs e)
        {
            try
            {
                DataSet ds = new DataSet();
                LoteBL LoteBL = new LoteBL();
                LoteBE LoteBE = new LoteBE()
                {
                    OPCION = 14,
                    USUARIO = General.General.GetUsuario,
                    IdLote = _IdLote
                };

                ds = LoteBL.ProcesarLote(LoteBE);
                dgvInconsistencias.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}