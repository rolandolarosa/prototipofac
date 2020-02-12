using EfideFactoring.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EfideFactoringXML
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        /// 
        [STAThread]
        static void Main()
        {
            if (!getParam())
                Application.Exit();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmImportarDocumento());
        }

        private static bool getParam()
        {
            string[] data = null;
            bool rpt = false;
            try
            {
                if (System.Deployment.Application.ApplicationDeployment.IsNetworkDeployed)
                {
                    string[] activationData = AppDomain.CurrentDomain.SetupInformation.ActivationArguments.ActivationData;
                    if (activationData != null)
                    {
                        data = activationData[0].Split('|');

                        GeneralXML.CodUsuario = data[0].ToString();
                        GeneralXML.FechaOperacion = DateTime.Parse(data[1].Trim().ToString().Replace('\\', '/'));

                        rpt = true;
                    }
                }
                else
                {
                    rpt = true;
                }
            }
            catch (Exception ex)
            {
                rpt = false;
                throw new Exception("No se recibierón los parámetros corectamente " + ex.Message);
            }

            return rpt;
        }
    }

    public class GeneralXML
    {
        public static string CodUsuario = string.Empty;
        public static DateTime FechaOperacion;
    }
}
