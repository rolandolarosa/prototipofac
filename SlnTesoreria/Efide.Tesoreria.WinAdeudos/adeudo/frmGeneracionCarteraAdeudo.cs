using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using Efide.Tesoreria.BusinessEntity;
using Efide.Tesoreria.BusinessEntity.adeudo;
using Efide.Tesoreria.BusinessLogic;
using Efide.Tesoreria.BusinessLogic.adeudo;

namespace Efide.Tesoreria.WinAdeudos.adeudo
{
    public partial class frmGeneracionCarteraAdeudo : DevComponents.DotNetBar.OfficeForm
    {
        #region "ENTITY"
        private AdeudoBL _AdeudoBL;
        private AdeudoBL oAdeudoBL
        {
            get { return (_AdeudoBL == null ? _AdeudoBL = new AdeudoBL() : _AdeudoBL); }
        }
        #endregion

        #region "FUNCTION"
        private void cargaMeses()
        {
            List<entidad> lstEntidad = new List<entidad>();
            lstEntidad.Add(new entidad { codigo = "00", nombre = "-TODOS-" });
            lstEntidad.Add(new entidad { codigo = "01", nombre = "ENERO" });
            lstEntidad.Add(new entidad { codigo = "02", nombre = "FEBRERO" });
            lstEntidad.Add(new entidad { codigo = "03", nombre = "MARZO" });
            lstEntidad.Add(new entidad { codigo = "04", nombre = "ABRIL" });
            lstEntidad.Add(new entidad { codigo = "05", nombre = "MAYO" });
            lstEntidad.Add(new entidad { codigo = "06", nombre = "JUNIO" });
            lstEntidad.Add(new entidad { codigo = "07", nombre = "JULIO" });
            lstEntidad.Add(new entidad { codigo = "08", nombre = "AGOSTO" });
            lstEntidad.Add(new entidad { codigo = "09", nombre = "SEPTIEMBRE" });
            lstEntidad.Add(new entidad { codigo = "10", nombre = "OCTUBRE" });
            lstEntidad.Add(new entidad { codigo = "11", nombre = "NOVIEMBRE" });
            lstEntidad.Add(new entidad { codigo = "12", nombre = "DICIEMBRE" });

            cboMes.ValueMember = "codigo";
            cboMes.DisplayMember = "nombre";
            cboMes.DataSource = lstEntidad;
        }
        private void cargaAnios()
        {
            List<entidad> lstEntidad = new List<entidad>();

            for (int i = 0; i < 3; i++)
            {
                lstEntidad.Add(new entidad { codigo = Convert.ToString((DateTime.Now.Year - 1) + i), nombre = Convert.ToString((DateTime.Now.Year - 1) + i) });
            }

            cboAnio.ValueMember = "codigo";
            cboAnio.DisplayMember = "nombre";
            cboAnio.DataSource = lstEntidad;
        }
        private void exportCartera()
        {
            List<CarteraExportBE> lstCarteraExportBE = new List<CarteraExportBE>();
            string nombreArchivo = "";
            int anio = 0;
            int mes = 0;

            this.Invoke((MethodInvoker)delegate
            {
                anio = Convert.ToInt32(dgvCartera.SelectedRows[0].Cells[2].Value);
                mes = Convert.ToInt32(dgvCartera.SelectedRows[0].Cells[3].Value);

                DateTime fechaCorte = new DateTime(Convert.ToInt32(anio), Convert.ToInt32(mes), 1).AddMonths(1).AddDays(-1);
                lstCarteraExportBE = oAdeudoBL.exportCartera(anio, mes);
                nombreArchivo = "AdeudosReporteCartera" + Convert.ToString(mes).PadLeft(2, '0') + anio.ToString();
                Util.Export.ExportToExcelCartera(lstCarteraExportBE, nombreArchivo, anio, getNombreMes(mes), "Reporte de Cartera de Adedudos", "CarteraAdeudos");
            });
        }
        private void generarCartera()
        {
            List<CarteraExportBE> lstCarteraExportBE = new List<CarteraExportBE>();
            DateTime fechaCorte = new DateTime(Convert.ToInt32(cboAnio.SelectedValue), Convert.ToInt32(cboMes.SelectedValue), 1).AddMonths(1).AddDays(-1);
            int anio = 0;
            int mes = 0;

            anio = Convert.ToInt32(cboAnio.SelectedValue);
            mes = Convert.ToInt32(cboMes.SelectedValue);
            oAdeudoBL.generarCartera(anio, mes, Util.General.GetCodigoUsuario);
            ucMsgBox1.ShowMessageSuccess("Se generó satisfactoriamente");
        }
        private void listarCartera()
        {
            List<AdeudoBE> lstAdeudoBE = new List<AdeudoBE>();
            int anio = 0;
            int mes = 0;

            anio = Convert.ToInt32(cboAnio.SelectedValue);
            mes = Convert.ToInt32(cboMes.SelectedValue);
            lstAdeudoBE = oAdeudoBL.listCartera(anio, mes);
            dgvCartera.DataSource = lstAdeudoBE;
        }
        private string getNombreMes(int mes)
        {
            string nombreMes = "";

            switch (mes)
            {
                case 1: nombreMes = "Enero";
                    break;
                case 2: nombreMes = "Febrero";
                    break;
                case 3: nombreMes = "Marzo";
                    break;
                case 4: nombreMes = "Abril";
                    break;
                case 5: nombreMes = "Mayo";
                    break;
                case 6: nombreMes = "Junio";
                    break;
                case 7: nombreMes = "Julio";
                    break;
                case 8: nombreMes = "Agosto";
                    break;
                case 9: nombreMes = "Septiembre";
                    break;
                case 10: nombreMes = "Octubre";
                    break;
                case 11: nombreMes = "Noviembre";
                    break;
                case 12: nombreMes = "Diciembre";
                    break;
                default:
                    break;
            }

            return nombreMes;
        }
        #endregion

        public frmGeneracionCarteraAdeudo()
        {
            InitializeComponent();
        }

        private void frmGeneracionCarteraAdeudo_Load(object sender, EventArgs e)
        {
            try
            {
                dgvCartera.AutoGenerateColumns = false;
                this.TopMost = false;
                this.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2, 30);
                this.StartPosition = FormStartPosition.Manual;

                cargaAnios();
                cargaMeses();
                cboAnio.SelectedValue = DateTime.Now.Year.ToString();

            }
            catch (Exception ex)
            {
                ucMsgBox1.ShowMessageError("Error al cargar la ventana Error: " + ex.Message);
            }
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!(Convert.ToInt32(cboMes.SelectedValue) > 0))
                {
                    ucMsgBox1.ShowMessageWarnnig("Debe seleccionar el mes a procesar");
                    return;
                }
                generarCartera();
                listarCartera();
            }
            catch (Exception ex)
            {
                ucMsgBox1.ShowMessageError("Error al generar la cartera Error: " + ex.Message);
            }
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            try
            {
                Task.Factory.StartNew(() =>
                {
                    Util.Util.SetLoading(this, ucLoadingBar1, true);
                    exportCartera();
                    Util.Util.SetLoading(this, ucLoadingBar1, false);
                });
            }
            catch (Exception ex)
            {
                ucMsgBox1.ShowMessageError("Error al cargar exportar cartera Error: " + ex.Message);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                ucMsgBox1.ShowMessageError("Error al cargar exportar cartera Error: " + ex.Message);
            }
        }

        private void cboAnio_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                listarCartera();
            }
            catch (Exception ex)
            {
                ucMsgBox1.ShowMessageError("Error al cargar listar cartera Error: " + ex.Message);
            }
        }

        private void cboMes_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                listarCartera();
            }
            catch (Exception ex)
            {
                ucMsgBox1.ShowMessageError("Error al cargar listar cartera Error: " + ex.Message);
            }
        }
    }

    public class entidad
    {
        public string codigo { get; set; }
        public string nombre { get; set; }
    }
}