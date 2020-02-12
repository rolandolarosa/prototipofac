using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;

namespace Efide.Tesoreria.Util
{
    public class AppSettings
    {
        private static string ambiente = ConfigurationManager.AppSettings["Ambiente"].ToString();
        //public static string CnxConnectionDB = "ConexionStrDBEfideContabilidad_" + ambiente;
        public static string ConexionStrDBFENIXSEG = "ConexionStrDBFENIXSEG_" + ambiente;
        public static string ConexionStrDBFENIXCAT = "ConexionStrDBFENIXCAT_" + ambiente;
        public static string CnxConnectionDBFactoring = "ConexionStrDBEfideFactoring_" + ambiente;
        public static string CnxConnectionDBAdeudosInversiones = "ConexionStrDBAdeudosInversiones_" + ambiente;
        public static string ConexionStrDBFENIXDB = "ConexionStrDBFENIXDB_" + ambiente;

        public static string activadorMenuDinamico = ConfigurationManager.AppSettings["ActivadorMenuDinamico"].ToString();
        public static string listaUsuariosMenuDinamico = ConfigurationManager.AppSettings["ListaUsuariosMenuDinamico"].ToString();
        public static string anexoSitemas = ConfigurationManager.AppSettings["AnexoSitemas"].ToString();

        public static string rutaDocumentosAdjuntos = ConfigurationManager.AppSettings["RutaDocumentosAdjuntos"].ToString();
    }

    public class GetNameSchema
    {
        public const string Contabilidad = "Contabilidad.";
        public const string ProcInterno = "ProcInterno.";
        public const string Cartera = "Cartera.";
        public const string Dbo = "dbo.";
        public const string AdminBancos = "AdminBancos.";
    }

    public class GetNameStoreProcedure
    {
        public const string TableBase_Mnt = GetNameSchema.Dbo + "TableBase_Mnt";
        public const string Usuario_Mnt = GetNameSchema.Dbo + "Usuario_Mnt";
        public const string spSelectViewPermisosTM = GetNameSchema.Dbo + "spSelectViewPermisosTM";
        public const string spSelectEntidadesFinancieras = GetNameSchema.Dbo + "spSelectEntidadesFinancieras";
        public const string spSelectValorGenerales = GetNameSchema.Dbo + "spSelectValorGenerales";

        public const string uspInsertInversion = GetNameSchema.Dbo + "uspInsertInversion";
        public const string uspUpdateInversion = GetNameSchema.Dbo + "uspUpdateInversion";
        public const string uspListInversion = GetNameSchema.Dbo + "uspListInversion";
        public const string uspGetInversion = GetNameSchema.Dbo + "uspGetInversion";
        
        
        public const string uspGeneracionCartera = GetNameSchema.Dbo + "uspGeneracionCartera";
        public const string uspGetCartera = GetNameSchema.Dbo + "uspGetCartera";
        public const string uspListCartera = GetNameSchema.Dbo + "uspListCartera";


        public const string uspInsertRescision = GetNameSchema.Dbo + "uspInsertRescision";
        public const string uspUpdateRescision = GetNameSchema.Dbo + "uspUpdateRescision";
        public const string uspListRescision = GetNameSchema.Dbo + "uspListRescision";
        public const string uspGetRescision = GetNameSchema.Dbo + "uspGetRescision";

        public const string uspInsertRenovacion = GetNameSchema.Dbo + "uspInsertRenovacion";
        public const string uspUpdateRenovacion = GetNameSchema.Dbo + "uspUpdateRenovacion";
        public const string uspListRenovacion = GetNameSchema.Dbo + "uspListRenovacion";
        public const string uspGetRenovacion = GetNameSchema.Dbo + "uspGetRenovacion";

        public const string uspInsertContacto = GetNameSchema.Dbo + "uspInsertContacto";
        public const string uspUpdateContacto = GetNameSchema.Dbo + "uspUpdateContacto";
        public const string uspGetContacto = GetNameSchema.Dbo + "uspGetContacto";

        public const string uspInsertDocumento = GetNameSchema.Dbo + "uspInsertDocumento";
        public const string uspDeleteDocumento = GetNameSchema.Dbo + "uspDeleteDocumento";
        public const string uspListDocumento = GetNameSchema.Dbo + "uspListDocumento";

        public const string spSelectBuscadorSocioBanco = GetNameSchema.Dbo + "spSelectBuscadorSocioBanco";
        public const string spSelectCtasBancariasTR = GetNameSchema.Dbo + "spSelectCtasBancariasTR";

        public const string uspInsertConfirmacion = GetNameSchema.Dbo + "uspInsertConfirmacion";
        public const string uspInsertConfirmacionDetalle = GetNameSchema.Dbo + "uspInsertConfirmacionDetalle";

        public const string uspInsertCuentaBancos = GetNameSchema.Dbo + "uspInsertCuentaBancos";
        public const string uspUpdateCuentaBancos = GetNameSchema.Dbo + "uspUpdateCuentaBancos";
        public const string uspGetCuentaBancos = GetNameSchema.Dbo + "uspGetCuentaBancos";
        public const string uspListCuentaBancos = GetNameSchema.Dbo + "uspListCuentaBancos";
        public const string uspMovimientoBancos = GetNameSchema.Dbo + "uspMovimientoBancos";


        public const string uspInsertAdeudo = GetNameSchema.Dbo + "uspInsertAdeudo";
        public const string uspUpdateAdeudo = GetNameSchema.Dbo + "uspUpdateAdeudo";
        public const string uspListAdeudo = GetNameSchema.Dbo + "uspListAdeudo";
        public const string uspGetAdeudo = GetNameSchema.Dbo + "uspGetAdeudo";
    }

    public class GetTablasGenerales
    {
        public const string moneda = "1";
        public const string tipoEntidadFinanciera = "5";

        public const string instrumentoInversion = "00410";
        public const string tipoAdeudos = "01158";

        public const string destino = "219";
        public const string identificacion = "108";
        public const string movimiento = "12";
        public const string estadosInversion = "00440";
        public const string TipoCuentaBancaria = "01011";
    }

    public class EstadoInversion
    {
        public const string Registrado = "00441";
        public const string Vigente = "00442";
        public const string Aplicada = "00443";
        public const string Rescidido = "01010";
        public const string Aprobado = "01023";
        public const string Anulado = "01024";
        public const string Renovado = "01025";
        public const string Cancelado = "01026";
    }

    public class GetEnum
    {
        public enum Eventos
        {
            view,
            insert,
            edit,
            delete,
            search,
            confirmar
        }

        public enum TipoConfirmacion
        {
            Inversion,
            Rescision
        }

        public enum TipoInversionAdeudo
        {
            inversion = 1,
            adeudo = 2
        }
    }
}
