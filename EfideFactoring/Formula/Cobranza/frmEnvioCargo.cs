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
    public partial class frmEnvioCargo : FormulaBase.frmMntFiltro
    {
        public frmEnvioCargo()
        {
            InitializeComponent();
        }

        private void frmEnvioCargo_Load(object sender, EventArgs e)
        {
            try
            {
                dtFechaFilter.Value = DateTime.Now;
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
                CobranzaBE CobranzaBE = new CobranzaBE()
                {
                    OPCION = 9,
                    USUARIO = General.General.GetUsuario,
                    dtRegistro = dtFechaFilter.Value
                };

                CobranzaBL CobranzaBL = new CobranzaBL();
                ds = CobranzaBL.ProcesarCobranza(CobranzaBE);
                dgvEnvioCargo.DataSource = ds.Tables[0];
                lblRegistros.Text = ds.Tables[0].Rows.Count.ToString() + " registro(s)";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            //Generar Cartas
            try
            {

                try
                {

                    DataSet ds = new DataSet();
                    CobranzaBE CobranzaBE = new CobranzaBE()
                    {
                        OPCION = 10,
                        USUARIO = General.General.GetUsuario,
                        dtRegistro = dtFechaFilter.Value
                    };

                    CobranzaBL CobranzaBL = new CobranzaBL();
                    ds = CobranzaBL.ProcesarCobranza(CobranzaBE);

                    Crystal.crRptCargoDocum ocrLoteLiquidacion = new Crystal.crRptCargoDocum();
                    Reportes.frmVisorLoteLiquidacion ofrmVisorLoteLiquidacion = new Reportes.frmVisorLoteLiquidacion();
                    ofrmVisorLoteLiquidacion.crvVisorLoteLiq.ReportSource = ocrLoteLiquidacion;
                    ocrLoteLiquidacion.SetDataSource(ds.Tables[0]);
                    ocrLoteLiquidacion.SetParameterValue("usuario", General.General.GetUsuario);
                    ofrmVisorLoteLiquidacion.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            //Definitivo
            try
            {
                foreach (DataGridViewRow row in dgvEnvioCargo.Rows)
	            {
		             CobranzaDetalleBE CobranzaDetalleBE = new CobranzaDetalleBE()
                     {
                        OPCION = 6,
                        USUARIO = General.General.GetUsuario,
                        sdFechaOp = General.General.gFechaOp,
                        IdCobranza = row.Cells["IdCobranza"].Value.ToString(),
                        IdDocumento = row.Cells["IdDocumento"].Value.ToString(),
                        cNumDoc = row.Cells["cNumDoc"].Value.ToString(),
                     };

                    CobranzaDetalleBL CobranzaDetalleBL = new CobranzaDetalleBL();
                    CobranzaDetalleBL.ProcesarCobranzaDetalle(CobranzaDetalleBE);   
	            }
                MessageBox.Show("Se Proceso Correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnBuscar_Click(new object(), new EventArgs());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}