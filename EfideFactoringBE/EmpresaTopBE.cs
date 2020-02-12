
namespace EfideFactoringBE
{
   public class EmpresaTopBE : GeneralBE
   {
       private string _Year = string.Empty;
       
       public string Year
       {
           get { return _Year; }
           set { _Year = value; }
       }

       private string _RUC = string.Empty;
       
       public string RUC
       {
           get { return _RUC; }
           set { _RUC = value; }
       }

       private string _RazonSocial = string.Empty;
       
       public string RazonSocial
       {
           get { return _RazonSocial; }
           set { _RazonSocial = value; }
       }

       private string _NombreComercial = string.Empty;
       
       public string NombreComercial
       {
           get { return _NombreComercial; }
           set { _NombreComercial = value; }
       }

       private string _CIIU = string.Empty;
       
       public string CIIU
       {
           get { return _CIIU; }
           set { _CIIU = value; }
       }

       private string _CIIU5 = string.Empty;
       
       public string CIIU5
       {
           get { return _CIIU5; }
           set { _CIIU5 = value; }
       }

       private string _SectorEsp = string.Empty;
       
       public string SectorEsp
       {
           get { return _SectorEsp; }
           set { _SectorEsp = value; }
       }

       private string _SectorIng = string.Empty;
       
       public string SectorIng
       {
           get { return _SectorIng; }
           set { _SectorIng = value; }
       }

       private string _SubsectorEsp = string.Empty;
       
       public string SubsectorEsp
       {
           get { return _SubsectorEsp; }
           set { _SubsectorEsp = value; }
       }

       private string _CIIUEspDetalle = string.Empty;
       
       public string CIIUEspDetalle
       {
           get { return _CIIUEspDetalle; }
           set { _CIIUEspDetalle = value; }
       }

       private string _CIIUIngDetalle = string.Empty;
       
       public string CIIUIngDetalle
       {
           get { return _CIIUIngDetalle; }
           set { _CIIUIngDetalle = value; }
       }

       private string _ProductosServicios = string.Empty;
       
       public string ProductosServicios
       {
           get { return _ProductosServicios; }
           set { _ProductosServicios = value; }
       }

       private string _Grupo = string.Empty;
       
       public string Grupo
       {
           get { return _Grupo; }
           set { _Grupo = value; }
       }

       private string _Partgrupo = string.Empty;
       
       public string Partgrupo
       {
           get { return _Partgrupo; }
           set { _Partgrupo = value; }
       }

       private string _ListadaBolsa = string.Empty;
       
       public string ListadaBolsa
       {
           get { return _ListadaBolsa; }
           set { _ListadaBolsa = value; }
       }

       private string _ReguladaSbs = string.Empty;
       
       public string ReguladaSbs
       {
           get { return _ReguladaSbs; }
           set { _ReguladaSbs = value; }
       }

       private decimal _NTrabajadores = 0;
       
       public decimal NTrabajadores
       {
           get { return _NTrabajadores; }
           set { _NTrabajadores = value; }
       }

       private decimal _NSucursales = 0;
       
       public decimal NSucursales
       {
           get { return _NSucursales; }
           set { _NSucursales = value; }
       }

       private string _FechaFundacion = string.Empty;
       
       public string FechaFundacion
       {
           get { return _FechaFundacion; }
           set { _FechaFundacion = value; }
       }

       private decimal _AniosFuncionamiento = 0;
       
       public decimal AniosFuncionamiento
       {
           get { return _AniosFuncionamiento; }
           set { _AniosFuncionamiento = value; }
       }

       private string _TamanoEmpresa = string.Empty;
       
       public string TamanoEmpresa
       {
           get { return _TamanoEmpresa; }
           set { _TamanoEmpresa = value; }
       }

       private string _Extranjera = string.Empty;
       
       public string Extranjera
       {
           get { return _Extranjera; }
           set { _Extranjera = value; }
       }

       private decimal _PorcExtranjera = 0;
       
       public decimal PorcExtranjera
       {
           get { return _PorcExtranjera; }
           set { _PorcExtranjera = value; }
       }

       private string _Estatal = string.Empty;
       
       public string Estatal
       {
           get { return _Estatal; }
           set { _Estatal = value; }
       }

       private decimal _PorcEstatal = 0;
       
       public decimal PorcEstatal
       {
           get { return _PorcEstatal; }
           set { _PorcEstatal = value; }
       }

       private string _Situacion = string.Empty;
       
       public string Situacion
       {
           get { return _Situacion; }
           set { _Situacion = value; }
       }

       private string _Direccion = string.Empty;
       
       public string Direccion
       {
           get { return _Direccion; }
           set { _Direccion = value; }
       }

       private string _Distrito = string.Empty;
       
       public string Distrito
       {
           get { return _Distrito; }
           set { _Distrito = value; }
       }

       private string _Provincia = string.Empty;
       
       public string Provincia
       {
           get { return _Provincia; }
           set { _Provincia = value; }
       }

       private string _Departamento = string.Empty;
       
       public string Departamento
       {
           get { return _Departamento; }
           set { _Departamento = value; }
       }

       private string _Telefono1 = string.Empty;
       
       public string Telefono1
       {
           get { return _Telefono1; }
           set { _Telefono1 = value; }
       }

       private string _Telefono2 = string.Empty;
       
       public string Telefono2
       {
           get { return _Telefono2; }
           set { _Telefono2 = value; }
       }

       private string _Telefono3 = string.Empty;
       
       public string Telefono3
       {
           get { return _Telefono3; }
           set { _Telefono3 = value; }
       }

       private string _Celular1 = string.Empty;
       
       public string Celular1
       {
           get { return _Celular1; }
           set { _Celular1 = value; }
       }

       private string _Celular2 = string.Empty;
       
       public string Celular2
       {
           get { return _Celular2; }
           set { _Celular2 = value; }
       }

       private string _Fax1 = string.Empty;
       
       public string Fax1
       {
           get { return _Fax1; }
           set { _Fax1 = value; }
       }

       private string _Fax2 = string.Empty;
       
       public string Fax2
       {
           get { return _Fax2; }
           set { _Fax2 = value; }
       }

       private string _EmailCorp = string.Empty;
       
       public string EmailCorp
       {
           get { return _EmailCorp; }
           set { _EmailCorp = value; }
       }

       private string _PaginaWeb = string.Empty;
       
       public string PaginaWeb
       {
           get { return _PaginaWeb; }
           set { _PaginaWeb = value; }
       }

       private decimal _RankingY = 0;
       
       public decimal RankingY
       {
           get { return _RankingY; }
           set { _RankingY = value; }
       }

       private decimal _RankingY_1 = 0;
       
       public decimal RankingY_1
       {
           get { return _RankingY_1; }
           set { _RankingY_1 = value; }
       }

       private decimal _RankingY_2 = 0;
       
       public decimal RankingY_2
       {
           get { return _RankingY_2; }
           set { _RankingY_2 = value; }
       }

       private decimal _FacturadoMinSolY = 0;
       
       public decimal FacturadoMinSolY
       {
           get { return _FacturadoMinSolY; }
           set { _FacturadoMinSolY = value; }
       }

       private decimal _FacturadoMaxSolY = 0;
       
       public decimal FacturadoMaxSolY
       {
           get { return _FacturadoMaxSolY; }
           set { _FacturadoMaxSolY = value; }
       }

       private decimal _FacturadoMinUsdY = 0;
       
       public decimal FacturadoMinUsdY
       {
           get { return _FacturadoMinUsdY; }
           set { _FacturadoMinUsdY = value; }
       }

       private decimal _FacturadoMaxUsdY = 0;
       
       public decimal FacturadoMaxUsdY
       {
           get { return _FacturadoMaxUsdY; }
           set { _FacturadoMaxUsdY = value; }
       }

       private decimal _FacturadoMinSolY_1 = 0;
       
       public decimal FacturadoMinSolY_1
       {
           get { return _FacturadoMinSolY_1; }
           set { _FacturadoMinSolY_1 = value; }
       }

       private decimal _FacturadoMaxSolY_1 = 0;
       
       public decimal FacturadoMaxSolY_1
       {
           get { return _FacturadoMaxSolY_1; }
           set { _FacturadoMaxSolY_1 = value; }
       }

       private decimal _FacturadoMinUsdY_1 = 0;
       
       public decimal FacturadoMinUsdY_1
       {
           get { return _FacturadoMinUsdY_1; }
           set { _FacturadoMinUsdY_1 = value; }
       }

       private decimal _FacturadoMaxUsdY_1 = 0;
       
       public decimal FacturadoMaxUsdY_1
       {
           get { return _FacturadoMaxUsdY_1; }
           set { _FacturadoMaxUsdY_1 = value; }
       }

       private decimal _FacturadoMinSolY_2 = 0;
       
       public decimal FacturadoMinSolY_2
       {
           get { return _FacturadoMinSolY_2; }
           set { _FacturadoMinSolY_2 = value; }
       }

       private decimal _FacturadoMaxSolY_2 = 0;
       
       public decimal FacturadoMaxSolY_2
       {
           get { return _FacturadoMaxSolY_2; }
           set { _FacturadoMaxSolY_2 = value; }
       }

       private decimal _FacturadoMinUsdY_2 = 0;
       
       public decimal FacturadoMinUsdY_2
       {
           get { return _FacturadoMinUsdY_2; }
           set { _FacturadoMinUsdY_2 = value; }
       }

       private decimal _FacturadoMaxUsdY_2 = 0;
       
       public decimal FacturadoMaxUsdY_2
       {
           get { return _FacturadoMaxUsdY_2; }
           set { _FacturadoMaxUsdY_2 = value; }
       }

       private string _TipoPrivadaPublica = string.Empty;
       
       public string TipoPrivadaPublica
       {
           get { return _TipoPrivadaPublica; }
           set { _TipoPrivadaPublica = value; }
       }

       private decimal _IngresosY = 0;
       
       public decimal IngresosY
       {
           get { return _IngresosY; }
           set { _IngresosY = value; }
       }

       private decimal _UtilidadNetaY = 0;
       
       public decimal UtilidadNetaY
       {
           get { return _UtilidadNetaY; }
           set { _UtilidadNetaY = value; }
       }

       private decimal _ActivosY = 0;
       
       public decimal ActivosY
       {
           get { return _ActivosY; }
           set { _ActivosY = value; }
       }

       private decimal _PatrimonioY = 0;
       
       public decimal PatrimonioY
       {
           get { return _PatrimonioY; }
           set { _PatrimonioY = value; }
       }

       private decimal _PasivoTotalY = 0;
       
       public decimal PasivoTotalY
       {
           get { return _PasivoTotalY; }
           set { _PasivoTotalY = value; }
       }

       private decimal _IngresosY_1 = 0;
       
       public decimal IngresosY_1
       {
           get { return _IngresosY_1; }
           set { _IngresosY_1 = value; }
       }

       private decimal _UtilidadNetaY_1 = 0;
       
       public decimal UtilidadNetaY_1
       {
           get { return _UtilidadNetaY_1; }
           set { _UtilidadNetaY_1 = value; }
       }

       private decimal _ActivosY_1 = 0;
       
       public decimal ActivosY_1
       {
           get { return _ActivosY_1; }
           set { _ActivosY_1 = value; }
       }

       private decimal _PatrimonioY_1 = 0;
       
       public decimal PatrimonioY_1
       {
           get { return _PatrimonioY_1; }
           set { _PatrimonioY_1 = value; }
       }

       private decimal _PasivoTotalY_1 = 0;
       
       public decimal PasivoTotalY_1
       {
           get { return _PasivoTotalY_1; }
           set { _PasivoTotalY_1 = value; }
       }

       private decimal _IngresosY_2 = 0;
       
       public decimal IngresosY_2
       {
           get { return _IngresosY_2; }
           set { _IngresosY_2 = value; }
       }

       private decimal _UtilidadNetaY_2 = 0;
       
       public decimal UtilidadNetaY_2
       {
           get { return _UtilidadNetaY_2; }
           set { _UtilidadNetaY_2 = value; }
       }

       private decimal _ActivosY_2 = 0;
       
       public decimal ActivosY_2
       {
           get { return _ActivosY_2; }
           set { _ActivosY_2 = value; }
       }

       private decimal _PatrimonioY_2 = 0;
       
       public decimal PatrimonioY_2
       {
           get { return _PatrimonioY_2; }
           set { _PatrimonioY_2 = value; }
       }

       private decimal _PasivoTotalY_2 = 0;
       
       public decimal PasivoTotalY_2
       {
           get { return _PasivoTotalY_2; }
           set { _PasivoTotalY_2 = value; }
       }

       private string _TipoExportadora = string.Empty;
       
       public string TipoExportadora
       {
           get { return _TipoExportadora; }
           set { _TipoExportadora = value; }
       }

       private decimal _PorExpoVtasY = 0;
       
       public decimal PorExpoVtasY
       {
           get { return _PorExpoVtasY; }
           set { _PorExpoVtasY = value; }
       }

       private string _Importadora = string.Empty;

       public string Importadora
       {
           get { return _Importadora; }
           set { _Importadora = value; }
       }

       private decimal _USDExpoY = 0;
       
       public decimal USDExpoY
       {
           get { return _USDExpoY; }
           set { _USDExpoY = value; }
       }

       private decimal _USDExpoY_1 = 0;
       
       public decimal USDExpoY_1
       {
           get { return _USDExpoY_1; }
           set { _USDExpoY_1 = value; }
       }

       private decimal _USDExpoY_2 = 0;
       
       public decimal USDExpoY_2
       {
           get { return _USDExpoY_2; }
           set { _USDExpoY_2 = value; }
       }

       private decimal _USDExpoY_3 = 0;
       
       public decimal USDExpoY_3
       {
           get { return _USDExpoY_3; }
           set { _USDExpoY_3 = value; }
       }

       private decimal _USDExpoY_4 = 0;
       
       public decimal USDExpoY_4
       {
           get { return _USDExpoY_4; }
           set { _USDExpoY_4 = value; }
       }

       private decimal _USDExpoY_5 = 0;
       
       public decimal USDExpoY_5
       {
           get { return _USDExpoY_5; }
           set { _USDExpoY_5 = value; }
       }

       private decimal _USDExpoY_6 = 0;
       
       public decimal USDExpoY_6
       {
           get { return _USDExpoY_6; }
           set { _USDExpoY_6 = value; }
       }

       private decimal _USDImpoY = 0;
       
       public decimal USDImpoY
       {
           get { return _USDImpoY; }
           set { _USDImpoY = value; }
       }

       private decimal _USDImpoY_1 = 0;
       
       public decimal USDImpoY_1
       {
           get { return _USDImpoY_1; }
           set { _USDImpoY_1 = value; }
       }

       private decimal _USDImpoY_2 = 0;
       
       public decimal USDImpoY_2
       {
           get { return _USDImpoY_2; }
           set { _USDImpoY_2 = value; }
       }

       private decimal _USDImpoY_3 = 0;
       
       public decimal USDImpoY_3
       {
           get { return _USDImpoY_3; }
           set { _USDImpoY_3 = value; }
       }

       private decimal _USDImpoY_4 = 0;
       
       public decimal USDImpoY_4
       {
           get { return _USDImpoY_4; }
           set { _USDImpoY_4 = value; }
       }

       private decimal _USDImpoY_5 = 0;
       
       public decimal USDImpoY_5
       {
           get { return _USDImpoY_5; }
           set { _USDImpoY_5 = value; }
       }

       private decimal _USDImpoY_6 = 0;
       
       public decimal USDImpoY_6
       {
           get { return _USDImpoY_6; }
           set { _USDImpoY_6 = value; }
       }

       private int _FlgComite = 0;
       public int FlgComite
       {
           get { return _FlgComite; }
           set { _FlgComite = value; }
       }

       private decimal _nLinea = 0;
       public decimal nLinea
       {
           get { return _nLinea; }
           set { _nLinea = value; }
       }
   }
}
