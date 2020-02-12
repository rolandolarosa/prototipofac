using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Efide.Tesoreria.BusinessEntity;
using Efide.Tesoreria.BusinessLogic;
using Efide.Tesoreria.Util;
using Efide.Tesoreria.WinAdeudos.frmBase;

namespace Efide.Tesoreria.WinAdeudos
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {

            try
            {
                bool logged = false;
                string TipoApp = "00";

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                logged = validLoginUser(getParam());
                if (!logged)
                    Application.Exit();

                if (logged)
                {
                    UsuarioBL UsuarioBL = new UsuarioBL();

                    if (TipoApp == "00")
                    {
                        // VERIFICA TIPO DE CAMBIO
                        if (System.Diagnostics.Debugger.IsAttached)
                        {
                            // VERIFICA SI USUARIO EXISTE 
                            UsuarioBE UsuarioBE = new UsuarioBE()
                            {
                                usuarioID = General.GetCodigoUsuario,
                                OPCION = 3,
                                pfecha = General.gFechaOp,
                            };
                            UsuarioBL.ProcesarUsuario(UsuarioBE);
                        }
                        else
                        {
                            UsuarioBE UsuarioBE = new UsuarioBE()
                            {
                                usuarioID = General.GetCodigoUsuario,
                                OPCION = 3,
                                pfecha = General.gFechaOp,
                            };
                            UsuarioBL.ProcesarUsuario(UsuarioBE);
                        }
                        {
                            Application.Run(new frmMenu());
                        }
                    }
                }
                else
                {
                    throw new Exception("No se pudo iniciar sesión");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " Params: " + General.GetParamsGlobal, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        private static bool getParam()
        {
            //string[] data = null;
            bool rpt = false;
            try
            {
                if (System.Deployment.Application.ApplicationDeployment.IsNetworkDeployed)
                {
                    General.GetUsuarioGlobal = "IBENAVENTE";
                    General.GetFechaGlobal = DateTime.Now.AddDays(-4);
                    General.GetSessionGlobal = "0010000000019SS";

                    General.gSesionID = General.GetSessionGlobal;
                    General.gFechaOp = General.GetFechaGlobal;

                    rpt = true;

                    //string[] activationData = AppDomain.CurrentDomain.SetupInformation.ActivationArguments.ActivationData;
                    //if (activationData != null)
                    //{
                    //    General.GetParamsGlobal = activationData[0];
                    //    data = activationData[0].Split('|');

                    //    General.GetUsuarioGlobal = data[0];
                    //    General.GetFechaGlobal = DateTime.ParseExact(data[1].Replace('\\', '/'), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                    //    General.GetSessionGlobal = data[2];

                    //    General.gSesionID = General.GetSessionGlobal;
                    //    General.gFechaOp = General.GetFechaGlobal;

                    //    rpt = true;
                    //}
                }
                else
                {
                    General.GetUsuarioGlobal = "IBENAVENTE";
                    General.GetFechaGlobal = DateTime.Now.AddDays(-4);
                    General.GetSessionGlobal = "0010000000019SS";

                    General.gSesionID = General.GetSessionGlobal;
                    General.gFechaOp = General.GetFechaGlobal;

                    rpt = true;
                }
            }
            catch (Exception ex)
            {
                General.GetSessionGlobal = "error: " + ex.Message;
                rpt = false;
            }

            return rpt;
        }

        public static bool validLoginUser(bool getParam)
        {
            bool rpt = false;
            string user;
            string session;
            DateTime fecha;
            List<UsuarioBE> lstUsuarioBE = new List<UsuarioBE>();

            if (!getParam)
                throw new Exception("No se recibieron todos los parámetros correctamente.");

            user = General.GetUsuarioGlobal;
            session = General.GetSessionGlobal;
            fecha = General.GetFechaGlobal;

            UsuarioBL UsuarioBL = new UsuarioBL();
            UsuarioBE UsuarioBE = new UsuarioBE()
            {
                OPCION = 1,
                usuarioID = user.Trim(),
                //usuContrasena = General.Encriptar(pass.Trim()),
                pfecha = General.gFechaOp
            };

            lstUsuarioBE = UsuarioBL.ProcesarUsuario(UsuarioBE);
            if (lstUsuarioBE.Count > 0)
            {
                UsuarioBE oUsuarioBE = lstUsuarioBE.FirstOrDefault();
                General.GetUsuario = oUsuarioBE.usuarioID;  //ds.Tables[0].Rows[0]["usuarioID"].ToString();
                General.GetCodigoUsuario = oUsuarioBE.usuarioID; //ds.Tables[0].Rows[0]["usuarioID"].ToString();
                General.GetIdGestor = oUsuarioBE.IdGestor; //ds.Tables[0].Rows[0]["IdGestor"].ToString();
                General.gSesionID = oUsuarioBE.gSesionID; //ds.Tables[0].Rows[0]["sesionID"].ToString();
                General.gventanillaID = oUsuarioBE.ventanillaID; //ds.Tables[0].Rows[0]["ventanillaID"].ToString();
                General.gRol = oUsuarioBE.rolGlobal; //ds.Tables[0].Rows[0]["rolGlobal"].ToString();
                General.gRol_Dsc = oUsuarioBE.rolGlobalName; //ds.Tables[0].Rows[0]["rolGlobalName"].ToString();
                rpt = true;
            }
            else
                rpt = false;

            return rpt;
        }
    }
}
