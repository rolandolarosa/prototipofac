using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Efide.Tesoreria.Util
{
    public class General
    {
        public static string GetNombreSistema = "Sistema Factoring.";
        public static string GetCodigoUsuario = "IBENAVENTE";
        public static string GetUsuario = "IBENAVENTE";
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

    }
}
