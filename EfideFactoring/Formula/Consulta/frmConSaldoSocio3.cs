using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EfideFactoringBE;
using EfideFactoringBL;
using System.Globalization;
using EfideFactoring.Formula.Cobranza;

namespace EfideFactoring.Formula.Consulta
{
    public partial class frmConSaldoSocio3 : DevComponents.DotNetBar.OfficeForm
    {
        SocioLineaBL SocioLineaBL = new SocioLineaBL();
        public string oIdSocio { get; set; }
        public string oIdPagadora { get; set; }
        public string oPagadora { get; set; }
        public decimal _LineaSaldo = 0;
        public decimal _TipoCambio = 0;
        public int _FlgOrigen = 0;
        public frmConSaldoSocio3()
        {
            InitializeComponent();
        }

        private void frmConSaldoSocio3_Load(object sender, EventArgs e)
        {
            try
            {
                CargarDatos();

                if(_LineaSaldo >0 && _TipoCambio >0 )
                    txtLineaDisponibleDol.Text = string.Format(CultureInfo.CreateSpecificCulture("en-US"), "{0:C}", (_LineaSaldo / _TipoCambio));

                if (_FlgOrigen == 0)
                {
                    lblTitulo1.Text = "SALDOS DE LINEA PAGADORA";
                    lblTitulo2.Text = "VALOR NEGOCIABLE";
                }
                else
                {
                    lblTitulo1.Text = "COBRANZA A LA PAGADORA";
                    lblTitulo2.Text = "VALOR NEGOCIABLE + FONDO GARANTIA";
                }
                CargarPndCobro();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvSaldoSocio3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex < 0) return;
                if (e.RowIndex == -1) return;

                if (dgvSaldoSocio3.Columns[e.ColumnIndex].Name.Equals("btnVisorFirma"))
                {
                    Legal.frmVisorFirmaLote ofrm = new Legal.frmVisorFirmaLote();
                    ofrm._IdSocio = dgvSaldoSocio3.CurrentRow.Cells["IdSocio"].Value.ToString();
                    ofrm._IdSocio_Dsc = dgvSaldoSocio3.CurrentRow.Cells["Socio"].Value.ToString();
                    ofrm.ShowDialog();
                }
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
                txtPagadora.Text = this.oPagadora;
                DataSet ds = new DataSet();
                SocioLineaBE SocioLineaBE = new SocioLineaBE()
                {
                    OPCION = 10,
                    IdSocio = this.oIdSocio,
                    IdPagadora = this.oIdPagadora,
                    USUARIO = General.General.GetUsuario,
                    FlgOrigen = _FlgOrigen
                };
                ds = SocioLineaBL.ProcesarSocioLinea(SocioLineaBE);
                dgvSaldoSocio3.DataSource = ds.Tables[0];

                decimal ACDolSol = 0;
                decimal ACTotalSol = 0;
                foreach (DataGridViewRow row in dgvSaldoSocio3.Rows)
                {
                    if (row.Cells["DiasAtraso"].Value.Equals("")) // No Vencido
                    {
                    }
                    else // VEncido
                    {
                        row.DefaultCellStyle.ForeColor = Color.FromName(General.General.GetColorAnulado);
                    }

                    ACDolSol = ACDolSol + Convert.ToDecimal(row.Cells["TotalD"].Value) * Convert.ToDecimal(row.Cells["nTipoCambio"].Value);
                    ACTotalSol = ACTotalSol + Convert.ToDecimal(row.Cells["TotalS"].Value);
                }
                decimal TotalUtilizado = 0;
                object sumTotSol;
                object sumTotDol;
                sumTotSol = ds.Tables[0].Compute("Sum(TotalS)", "");
                sumTotDol = ds.Tables[0].Compute("Sum(TotalD)", "");
                txtSumSol.Text = string.Format(CultureInfo.CreateSpecificCulture("es-PE"), "{0:C}", sumTotSol);
                txtSumDol.Text = string.Format(CultureInfo.CreateSpecificCulture("en-US"), "{0:C}", sumTotDol);
                txtTotalDolSol.Text = string.Format(CultureInfo.CreateSpecificCulture("es-PE"), "{0:C}", ACDolSol);

                TotalUtilizado = (ACTotalSol + ACDolSol);
                txtTotalUtilizado.Text = string.Format(CultureInfo.CreateSpecificCulture("es-PE"), "{0:C}", TotalUtilizado);
                txtLineaDisponible.Text = string.Format(CultureInfo.CreateSpecificCulture("es-PE"), "{0:C}", _LineaSaldo);
                Grid_Formatting();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarPndCobro()
        {
            try
            {
                GestionPagadoraBE IEntity = new GestionPagadoraBE();
                IEntity.OPCION = 3;
                IEntity.IdPagadora = oIdPagadora;
                IEntity.FlgOrigen = _FlgOrigen;
                DataSet ds = new GestionPagadoraBL().ProcesarGestionPagadora(IEntity);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    dgvPendienteCobro.DataSource = ds.Tables[0];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvPendienteCobro_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                DataGridViewRow row = dgvPendienteCobro.Rows[e.RowIndex];// get you required index
                // check the cell value under your specific column and then you can toggle your colors

                if (dgvPendienteCobro.Rows[e.RowIndex].Cells["Rango"].Value.ToString().Trim().Equals("Totales") || dgvPendienteCobro.Rows[e.RowIndex].Cells["Rango"].Value.ToString().Trim().Equals("Vigente"))
                {
                    row.DefaultCellStyle.ForeColor = Color.Black;
                    row.DefaultCellStyle.BackColor = Color.Orange;
                }

                //row.DefaultCellStyle.ForeColor = Color.FromName(row.Cells["ColorRow"].Value.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnInfFinanciera_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = 0;
            try
            {
                
                dialogResult = MessageBox.Show("Seguro de solicitar información financiera?", "Confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

               if (dialogResult == DialogResult.Yes)
               {
                    GestionPagadoraBE IEntity = new GestionPagadoraBE();
                    IEntity.OPCION = 8;
                    IEntity.IdPagadora = oIdPagadora;
                    IEntity.FlgOrigen = _FlgOrigen;
                    DataSet ds = new GestionPagadoraBL().ProcesarGestionPagadora(IEntity);
                    MessageBox.Show("Se Envió Correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    //    CompromisoComBE CompromisoComBE = new CompromisoComBE()
                    //    {
                    //        OPCION = 3,
                    //        USUARIO = General.General.GetUsuario,
                    //        IdCompromiso = dgvCompromisoCom.CurrentRow.Cells["IdCompromiso"].Value.ToString(),
                    //    };

                    //    CompromisoComBL.ProcesarCompromisoCom(CompromisoComBE);
                    //    MessageBox.Show("Se Proceso Correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //    btnBuscar.PerformClick();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvSaldoSocio3_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex < 0) return;
                if (e.RowIndex == -1) return;

                if (_FlgOrigen == 1){
                    if (dgvSaldoSocio3.Columns[e.ColumnIndex].Name == "TotalS"
                            || dgvSaldoSocio3.Columns[e.ColumnIndex].Name == "TotalD"
                            || dgvSaldoSocio3.Columns[e.ColumnIndex].Name == "sdVencimiento")
                    {
                        frmMntCorregirDatosCobranza ofrm = new frmMntCorregirDatosCobranza();
                        ofrm._IdLote = dgvSaldoSocio3.CurrentRow.Cells["IdLote"].Value.ToString();
                        ofrm._cItem = dgvSaldoSocio3.CurrentRow.Cells["cItem"].Value.ToString();
                        ofrm._Socio = dgvSaldoSocio3.CurrentRow.Cells["Socio"].Value.ToString();
                        ofrm._Documento = dgvSaldoSocio3.CurrentRow.Cells["Documento"].Value.ToString() + " - " + dgvSaldoSocio3.CurrentRow.Cells["cNumDoc"].Value.ToString();
                        ofrm._dtVencimiento = Convert.ToDateTime(dgvSaldoSocio3.CurrentRow.Cells["sdVencimiento"].Value.ToString());
                        ofrm._nImportOriginal = Convert.ToDecimal(dgvSaldoSocio3.CurrentRow.Cells["TotalS"].Value) == 0 ? Convert.ToDecimal(dgvSaldoSocio3.CurrentRow.Cells["TotalD"].Value) : Convert.ToDecimal(dgvSaldoSocio3.CurrentRow.Cells["TotalS"].Value);
                        ofrm.ShowDialog();
                        CargarDatos();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Grid_Formatting()
        {
            try
            {
                foreach (DataGridViewRow row in dgvSaldoSocio3.Rows)
                {
                    if (row.Cells["FlgColorRowFechaVenc"].Value.ToString().Trim().Equals("1"))
                    {
                        row.Cells["sdVencimiento"].Style.BackColor = Color.Yellow;
                    }

                    if (row.Cells["FlgColorRowImporteOriginal"].Value.ToString().Trim().Equals("1"))
                    {
                        row.Cells["TotalS"].Style.BackColor = Color.Yellow;
                        row.Cells["TotalD"].Style.BackColor = Color.Yellow;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvSaldoSocio3_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                Grid_Formatting();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
