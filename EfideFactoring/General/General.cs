using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Security.Cryptography;
using System.Globalization;
using EfideFactoringBL;
using EfideFactoringBE;


namespace EfideFactoring.General
{
    public class General
    {
        public static string GetNombreSistema = "Sistema Factoring.";
        public static string GetCodigoUsuario = "ADMIN";
        public static string GetUsuario = "ADMIN";
        public static string GetCodigoPerfil = "";
        public static string GetIdGestor = string.Empty;
        public static string GetIdTipoGestor_tt = string.Empty;
        public static string GetColorAnulado = "Red";
        public static string GetColorLoteAprobado = "Blue";
        public static string GetColorLotePorAprobar = "Red";

        public static string GetParamsGlobal = string.Empty;
        public static string GetUsuarioGlobal = string.Empty;
        public static string GetSessionGlobal = string.Empty;
        public static DateTime GetFechaGlobal = DateTime.MinValue;

        public static DateTime gFechaOp = DateTime.Now;
        public static string gPlazaID = "001";
        public static string gSesionID = "";
        public static string gventanillaID = "";
        public static string gRol = "";
        public static string gRol_Dsc = "";

        public static string GetVentana = "";
        public static string GetParametro1 = "";
        public static string GetParametro2 = "";
        public static string GetParametro3 = "";

        public static bool Validar_Enteros(KeyPressEventArgs e)
        {
            bool ReturnValue = false;
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                ReturnValue = true;
            }
            return ReturnValue;
        }

        public static bool Validar_Decimal(KeyPressEventArgs e, String Texto)
        {
            bool bDecimal = Texto.ToString().Contains(".");
            bool ReturnValue = false;

            if (bDecimal && e.KeyChar == 46)
            {
                e.Handled = true;
                ReturnValue = true;
            }

            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != 46))
            {
                e.Handled = true;
                ReturnValue = true;
            }
            return ReturnValue;
        }

        public static bool Validar_Letras(KeyPressEventArgs e)
        {
            bool ReturnValue = false;
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                ReturnValue = true;
            }
            return ReturnValue;
        }

        public static DataTable LlenarCombobox(ComboBox cbo, string Name, string Value, DataTable dt, bool bTodos = false)
        {
            string Texto = "--Seleccionar--";
            if (bTodos)
            {
                Texto = "<<Todos>>";
            }

            DataRow dr;
            dr = dt.NewRow();
            dr[Name] = Texto;
            dr[Value] = "";
            dt.Rows.InsertAt(dr, 0);

            cbo.DataSource = dt;
            cbo.DisplayMember = Name;
            cbo.ValueMember = Value;

            return dt;
        }

        public static string Right(string param, int length)
        {
            int value = param.Length - length;
            string result = param.Substring(value, length);
            return result;
        }

        public static double Redondeo(double nmonto) 
        {
            string y = nmonto.ToString("N2");
            string z = Right(y, 1);
            double ndecim;
            string cTipo = "P";
            double najust;

            if (String.Equals(z, "0") || String.Equals(z, "5"))
            { }
            else
            {
                ndecim = (double)Int32.Parse(z) / 100;
                ndecim = Math.Round(ndecim, 2);
                if (String.Equals(cTipo, "P"))
                {
                    najust = (ndecim < 0.05) ? (0.05 - ndecim) : (0.10 - ndecim);
                    nmonto = (nmonto + najust);
                }
                else
                {
                    najust = (ndecim < 0.05) ? ndecim : (ndecim - 0.05);
                    nmonto = (nmonto - najust);
                }
            }
            return nmonto;
        }

        public static string Encriptar(string Cadena) 
        {
            SymmetricAlgorithm sa = new RijndaelManaged();
            sa.IV = Encoding.UTF8.GetBytes("Seguro Seguro 06");
            sa.Key = Encoding.UTF8.GetBytes("Iniciando una nueva era en GC 06");        

            byte[] NuevaCadena = Encoding.UTF8.GetBytes(Cadena);
            string res = "";
            using (MemoryStream ms = new MemoryStream(NuevaCadena.Length*2))
            {
                using (CryptoStream cs = new CryptoStream(ms, sa.CreateEncryptor(),CryptoStreamMode.Write))
                {
                    cs.Write(NuevaCadena, 0, NuevaCadena.Length);
                }
                res = Convert.ToBase64String(ms.ToArray());
            }
            return res;
        }

        public static string Desencriptar(string contraseña)
        {
            SymmetricAlgorithm sa = new RijndaelManaged();
            sa.IV = Encoding.UTF8.GetBytes("Seguro Seguro 06");
            sa.Key = Encoding.UTF8.GetBytes("Iniciando una nueva era en GC 06");
            byte[] cadena = Convert.FromBase64String(contraseña);
            string res = "";
            using (MemoryStream ms = new MemoryStream(cadena.Length))
            {
                using (CryptoStream cs = new CryptoStream(ms, sa.CreateDecryptor(), CryptoStreamMode.Write))
                {
                    cs.Write(cadena, 0, cadena.Length);
                }
                res = Encoding.UTF8.GetString(ms.ToArray());
            }
            return res;
        }

        public static string MonthName(int month)
        {
            DateTimeFormatInfo dtinfo = new CultureInfo("es-ES", false).DateTimeFormat;
            return dtinfo.GetMonthName(month);
        }

        public static bool validLoginUser(bool getParam)
        {
            bool rpt = false;
            string user;
            string session;
            DateTime fecha;

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
                pfecha = EfideFactoring.General.General.gFechaOp
            };
            DataSet ds = new DataSet();
            ds = UsuarioBL.ProcesarUsuario(UsuarioBE);
            if (ds.Tables[0].Rows.Count > 0)
            {
                General.GetUsuario = ds.Tables[0].Rows[0]["usuarioID"].ToString();
                General.GetCodigoUsuario = ds.Tables[0].Rows[0]["usuarioID"].ToString();
                General.GetIdGestor = ds.Tables[0].Rows[0]["IdGestor"].ToString();
                General.gSesionID = ds.Tables[0].Rows[0]["sesionID"].ToString();
                General.gventanillaID = ds.Tables[0].Rows[0]["ventanillaID"].ToString();
                //EfideFactoring.General.General.gFechaOp = new DateTime(2018, 03, 02, 08, 50, 00);
                General.gRol = ds.Tables[0].Rows[0]["rolGlobal"].ToString();
                General.gRol_Dsc = ds.Tables[0].Rows[0]["rolGlobalName"].ToString();
                rpt = true;
            }
            else
                rpt = false;

            //UsuarioBE UsuarioBE2 = new UsuarioBE()
            //{
            //    OPCION = 2,
            //    pfecha = EfideFactoring.General.General.gFechaOp
            //};
            //ds = UsuarioBL.ProcesarUsuario(UsuarioBE2);

            return rpt;
        }

        public static void ValidarTipoCambio()
        {
            try
            {
                UsuarioBE oEntity = new UsuarioBE()
                {
                    OPCION = 2,
                    pfecha = EfideFactoring.General.General.gFechaOp
                };

                new UsuarioBL().ProcesarUsuario(oEntity);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
