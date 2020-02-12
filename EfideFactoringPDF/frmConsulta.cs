using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using EfideFactoring.General;
using EfideFactoringBL;

namespace EfideFactoringPDF
{
    public partial class frmConsulta : Form
    {
        public frmConsulta()
        {
            InitializeComponent();
        }

        private void frmConsulta_Load(object sender, EventArgs e)
        {
            getParam();

            switch (General.GetVentana)
            {
                case "pagadora": abreFrmMntPagadoraDato();
                    break;
                case "saldoSocio": abreFrmConSaldoSocio2();
                    break;
                case "frmMntSaldoSocio": abreFrmMntSaldoSocio();
                    break;
                case "frmMantDocumentoSocio": abreFrmMantDocumentoSocio();
                    break;
                default:
                    break;
            }
        }

        private void abreFrmMntPagadoraDato()
        {
            EfideFactoring.Formula.Consulta.frmConSaldoSocio3 frm = new EfideFactoring.Formula.Consulta.frmConSaldoSocio3();
            PagadoraBL oPagadoraBL = new PagadoraBL();
            DataSet ds = new DataSet();

            ds = oPagadoraBL.PagadoraXcredito(General.GetParametro1);
            if (ds.Tables[0].Rows.Count > 0)
            {
                frm.oIdPagadora = ds.Tables[0].Rows[0].ItemArray[0].ToString();
                frm.oPagadora = ds.Tables[0].Rows[0].ItemArray[1].ToString();
                frm._TipoCambio = Convert.ToDecimal(ds.Tables[0].Rows[0].ItemArray[2].ToString());
                frm._LineaSaldo = Convert.ToDecimal(ds.Tables[0].Rows[0].ItemArray[3].ToString());
            }
            frm.Text = "Consulta de Saldos por Pagadora";
            this.ShowInTaskbar = false;
            this.Visible = false;
            this.Hide();

            frm.Show(this);
        }

        private void abreFrmConSaldoSocio2()
        {
            EfideFactoring.Formula.Consulta.frmConSaldoSocio2 frm = new EfideFactoring.Formula.Consulta.frmConSaldoSocio2();
            frm.txtCodigo.Text = General.GetParametro1; //"0010001001320CN";
            frm.txtSocio.Text = General.GetParametro2; //"Meliton Bermudes Bartolome Román";
            this.ShowInTaskbar = false;
            this.Visible = false;
            this.Hide();

            frm.Show(this);
        }

        private void abreFrmMntSaldoSocio()
        {
            EfideFactoring.Formula.Registros.frmMntSaldoSocio frm = new EfideFactoring.Formula.Registros.frmMntSaldoSocio();
            frm.creditoID = General.GetParametro1; //"0010001001320CN";
            frm.anio = General.GetParametro2;
            frm.mes = General.GetParametro3;
            this.ShowInTaskbar = false;
            this.Visible = false;
            this.Hide();

            frm.Show(this);
        }

        private void abreFrmMantDocumentoSocio()
        {
            EfideFactoring.Formula.Registros.frmMantDocumentoSocio frm = new EfideFactoring.Formula.Registros.frmMantDocumentoSocio();
            frm.detOrdenID = General.GetParametro1;
            frm.ordenBancoID = General.GetParametro2;
            this.ShowInTaskbar = false;
            this.Visible = false;
            this.Hide();

            frm.Show(this);
        }

        #region " FUNCTION "
        private static bool getParam()
        {
            string[] data = null;
            Entidad entidad = new Entidad();

            bool rpt = false;
            try
            {
                if (System.Deployment.Application.ApplicationDeployment.IsNetworkDeployed)
                {
                    string[] activationData = AppDomain.CurrentDomain.SetupInformation.ActivationArguments.ActivationData;
                    if (activationData != null)
                    {
                        data = activationData[0].Split('|');

                        switch (data.Length)
                        {
                            case 1: General.GetVentana = data[0]; break;
                            case 2: General.GetVentana = data[0]; General.GetParametro1 = data[1]; break;
                            case 3: General.GetVentana = data[0]; General.GetParametro1 = data[1]; General.GetParametro2 = data[2]; break;
                            case 4: General.GetVentana = data[0]; General.GetParametro1 = data[1]; General.GetParametro2 = data[2]; General.GetParametro3 = data[3]; break;
                            default:
                                break;
                        }
                        rpt = true;
                    }
                }
                else
                {
                    //General.GetVentana = "frmMantDocumentoSocio";
                    //General.GetParametro1 = "001000000069SD20180406";
                    //General.GetParametro2 = "001000000068SD20180406";



                    //natural titular no representa
                    General.GetVentana = "frmMntSaldoSocio";
                    General.GetParametro1 = "0010001001793CN     ";
                    General.GetParametro2 = "2018";
                    General.GetParametro3 = "09";



                    /*
                     * 
                     * General.GetParametro1 = "001000000345SD20181107";
                    General.GetParametro2 = "001000000344SD20181107";
                     * 
                     * 
                    //natural titular no representa
                    General.GetParametro1 = "001000000001SD20180515     ";
                    General.GetParametro2 = "001000000001OT20180515     ";
                     
                    //jurico titular no representa
                    General.GetParametro1 = "001000000032SD20171227     ";
                    General.GetParametro2 = "001000000031SD20171227     ";
                    
                    //juridoco tercero no representa
                    General.GetParametro1 = "001000000069SD20180406";
                    General.GetParametro2 = "001000000068SD20180406";

                    //representante tercera persona
                    General.GetParametro1 = "001000000345SD20181107";
                    General.GetParametro2 = "001000000344SD20181107";
                    
                    //juridico titular
                    General.GetParametro1 = "001000000493SD20180724";
                    General.GetParametro2 = "001000000011OT20180724";
                    
                    //natural tercero no representa
                    General.GetParametro1 = "001000000145SD20171204";
                    General.GetParametro2 = "001000000144SD20171204";
                    */

                    rpt = true;
                }
            }
            catch (Exception ex)
            {
                rpt = false;
                throw new Exception("Ocurrió un error al recibir los parámetros - Error: " + ex.Message);
            }

            return rpt;
        }
        #endregion
    }

    public class Entidad
    {
        public string ventana { get; set; }
        public string parametro1 { get; set; }
        public string parametro2 { get; set; }
    }
}
