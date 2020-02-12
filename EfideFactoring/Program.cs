using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;
using EfideFactoringBE;
using EfideFactoringBL;
using System.Globalization;


namespace EfideFactoring
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main(string[] args)
        {
            try
            {
                bool logged = false;
                string TipoApp = "00";
                //General.General.GetCodigoUsuario = "ADMIN";
                //General.General.GetUsuario = "ADMIN";

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                DataSet dsFechaSistema = new DataSet();
                FechaSistemaBL FechaSistemaBL = new FechaSistemaBL();
                FechaSistemaBE FechaSistemaBE = new FechaSistemaBE()
                {
                    OPCION = 1,
                    USUARIO = "ADMIN",
                };
                dsFechaSistema = FechaSistemaBL.ProcesarFechaSistema(FechaSistemaBE);
                if (dsFechaSistema.Tables[0].Rows.Count > 0)
                {
                    EfideFactoring.General.General.gFechaOp = Convert.ToDateTime(dsFechaSistema.Tables[0].Rows[0]["fechaDia"]);
                }

                //getParam();
                //logged = false;
                logged = EfideFactoring.General.General.validLoginUser(getParam());

                //FormulaBase.frmLogin login = new FormulaBase.frmLogin();
                if (!logged)
                    Application.Exit();
                //login.ShowDialog();

                //if ((login.DialogResult == DialogResult.OK) || logged)
                if (logged)
                {

                    DataSet ds = new DataSet();
                    UsuarioBL UsuarioBL = new UsuarioBL();

                    if (TipoApp == "00")
                    {
                        // VERIFICA TIPO DE CAMBIO
                        //UsuarioBE UsuarioBE2 = new UsuarioBE()
                        //{
                        //    OPCION = 2,
                        //    pfecha = EfideFactoring.General.General.gFechaOp,
                        //};
                        //ds = UsuarioBL.ProcesarUsuario(UsuarioBE2);

                        if (System.Diagnostics.Debugger.IsAttached)
                        {
                            // VERIFICA SI USUARIO EXISTE 
                            // COMPILADO
                            UsuarioBE UsuarioBE = new UsuarioBE()
                            {
                                usuarioID = General.General.GetCodigoUsuario,
                                OPCION = 3,
                                pfecha = EfideFactoring.General.General.gFechaOp,
                            };
                            ds = UsuarioBL.ProcesarUsuario(UsuarioBE);
                        }
                        else
                        {
                            UsuarioBE UsuarioBE = new UsuarioBE()
                            {
                                usuarioID = EfideFactoring.General.General.GetCodigoUsuario,
                                OPCION = 3,
                                pfecha = EfideFactoring.General.General.gFechaOp,
                            };
                            ds = UsuarioBL.ProcesarUsuario(UsuarioBE);
                        }
                        {
                            Application.Run(new FormulaBase.frmMenu());
                        }
                    }
                    else if (TipoApp == "01")
                    {
                        Application.Run(new FormulaBase.frmMenuLoad());
                    }
                }
                else
                {
                    throw new Exception("No se pudo iniciar sesión");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " Params: " + General.General.GetParamsGlobal, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
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
                        General.General.GetParamsGlobal = activationData[0];
                        data = activationData[0].Split('|');

                        General.General.GetUsuarioGlobal = data[0];
                        General.General.GetFechaGlobal = DateTime.ParseExact(data[1].Replace('\\', '/'), "dd/MM/yyyy", CultureInfo.InvariantCulture); //Convert.ToDateTime(data[1]);
                        General.General.GetSessionGlobal = data[2];

                        General.General.gSesionID = General.General.GetSessionGlobal;
                        General.General.gFechaOp = General.General.GetFechaGlobal;

                        rpt = true;
                    }
                }
                else
                {
                    General.General.GetUsuarioGlobal = "ADMIN";
                    //string str = General.General.Desencriptar("uvY+XjvhU5xb6D4CC7+qHQ==");
                    General.General.GetFechaGlobal = DateTime.Now;
                    General.General.GetSessionGlobal = "0010000000019SS";

                    General.General.gSesionID = General.General.GetSessionGlobal;
                    General.General.gFechaOp = General.General.GetFechaGlobal;
                    //General.General.gFechaOp = DateTime.Parse("21/09/2018"); PRUEBAS

                    rpt = true;
                }
            }
            catch (Exception ex)
            {
                General.General.GetSessionGlobal = "error: " + ex.Message;
                rpt = false;
            }

            return rpt;
        }
    }
}
