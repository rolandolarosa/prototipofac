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

namespace EfideFactoring.Formula.Cobranza
{
    public partial class frmTituloValorProtestar : FormulaBase.frmMntFiltro
    {
        public frmTituloValorProtestar()
        {
            InitializeComponent();
        }

        private void frmTituloValorProtestar_Load(object sender, EventArgs e)
        {
            try
            {
                dtFechaFiltro.Value = DateTime.Now;
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
                DataSet ds = new DataSet();
                CobranzaDetalleBL CobranzaDetalleBL = new CobranzaDetalleBL();
                CobranzaDetalleBE CobranzaDetalleBE = new CobranzaDetalleBE()
                {
                    OPCION = 7,
                    USUARIO = General.General.GetUsuario,
                    sdFechaOp = General.General.gFechaOp,
                    sdVencimiento = dtFechaFiltro.Value
                };

                ds = CobranzaDetalleBL.ProcesarCobranzaDetalle(CobranzaDetalleBE);
                dgvCobranzaDetalle.DataSource = ds.Tables[0];
                lblRegistros.Text = ds.Tables[0].Rows.Count.ToString() + " registro(s)";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                Formula.Reportes.frmTituloValorProtestarVisor ofrmTituloValorProtestarVisor = new Reportes.frmTituloValorProtestarVisor();
                ofrmTituloValorProtestarVisor._dtFechaFiltro = dtFechaFiltro.Value;
                ofrmTituloValorProtestarVisor.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}