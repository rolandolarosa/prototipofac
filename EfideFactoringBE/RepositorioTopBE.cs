
namespace EfideFactoringBE
{
   public class RepositorioTopBE : GeneralBE
   {
       private string _Year = string.Empty;
       public string Year
       {
           get { return _Year; }
           set { _Year = value; }
       }

       private string _cRuc = string.Empty;
       public string cRuc
       {
           get { return _cRuc; }
           set { _cRuc = value; }
       }

       private string _vSectorEsp = string.Empty;
       public string vSectorEsp
       {
           get { return _vSectorEsp; }
           set { _vSectorEsp = value; }
       }

       private string _vMagnitudEmpresa = string.Empty;
       public string vMagnitudEmpresa
       {
           get { return _vMagnitudEmpresa; }
           set { _vMagnitudEmpresa = value; }
       }

       private string _vRanking = string.Empty;
       public string vRanking
       {
           get { return _vRanking; }
           set { _vRanking = value; }
       }

       private decimal _nFacturadoMax = 0;
       public decimal nFacturadoMax
       {
           get { return _nFacturadoMax; }
           set { _nFacturadoMax = value; }
       }

       private string _vTipoEmpresa = string.Empty;
       public string vTipoEmpresa
       {
           get { return _vTipoEmpresa; }
           set { _vTipoEmpresa = value; }
       }

       private string _vPagWeb = string.Empty;
       public string vPagWeb
       {
           get { return _vPagWeb; }
           set { _vPagWeb = value; }
       }

       private string _vNroTrabajador = string.Empty;
       public string vNroTrabajador
       {
           get { return _vNroTrabajador; }
           set { _vNroTrabajador = value; }
       }

       private string _vNroSucursales = string.Empty;
       public string vNroSucursales
       {
           get { return _vNroSucursales; }
           set { _vNroSucursales = value; }
       }

       private string _vResolucionContribuyente = string.Empty;
       public string vResolucionContribuyente
       {
           get { return _vResolucionContribuyente; }
           set { _vResolucionContribuyente = value; }
       }

       private decimal _nUtilidadNeta = 0;
       public decimal nUtilidadNeta
       {
           get { return _nUtilidadNeta; }
           set { _nUtilidadNeta = value; }
       }

       private decimal _nTotalActivo = 0;
       public decimal nTotalActivo
       {
           get { return _nTotalActivo; }
           set { _nTotalActivo = value; }
       }

       private decimal _nPatrimonio = 0;
       public decimal nPatrimonio
       {
           get { return _nPatrimonio; }
           set { _nPatrimonio = value; }
       }

       private decimal _nTotalPasivo = 0;
       public decimal nTotalPasivo
       {
           get { return _nTotalPasivo; }
           set { _nTotalPasivo   = value; }
       }

       private decimal _nTotalVenta = 0;
       public decimal nTotalVenta
       {
           get { return _nTotalVenta; }
           set { _nTotalVenta = value; }
       }

       private string _vFacebook = string.Empty;
       public string vFacebook
       {
           get { return _vFacebook; }
           set { _vFacebook = value; }
       }

       private string _vTwitter = string.Empty;
       public string vTwitter
       {
           get { return _vTwitter; }
           set { _vTwitter = value; }
       }
   }
}
