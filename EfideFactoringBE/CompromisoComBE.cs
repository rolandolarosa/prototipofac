
namespace EfideFactoringBE
{
   public class CompromisoComBE : GeneralBE
   {
       private string _IdCompromiso = string.Empty;
       
       public string IdCompromiso
       {
           get { return _IdCompromiso; }
           set { _IdCompromiso = value; }
       }

       private System.DateTime _sdFechaReg;
       
       public System.DateTime sdFechaReg
       {
           get { return _sdFechaReg; }
           set { _sdFechaReg = value; }
       }

       private string _IdPagadora = string.Empty;
       
       public string IdPagadora
       {
           get { return _IdPagadora; }
           set { _IdPagadora = value; }
       }

       private string _RucPagadora = string.Empty;
       
       public string RucPagadora
       {
           get { return _RucPagadora; }
           set { _RucPagadora = value; }
       }

       private string _vcPagadora = string.Empty;
       
       public string vcPagadora
       {
           get { return _vcPagadora; }
           set { _vcPagadora = value; }
       }

       private string _idsector_tt = string.Empty;
       
       public string idsector_tt
       {
           get { return _idsector_tt; }
           set { _idsector_tt = value; }
       }

       private string _IdTipoLin_tt = string.Empty;
       
       public string IdTipoLin_tt
       {
           get { return _IdTipoLin_tt; }
           set { _IdTipoLin_tt = value; }
       }

       private decimal _nLineaDisp = 0;
       
       public decimal nLineaDisp
       {
           get { return _nLineaDisp; }
           set { _nLineaDisp = value; }
       }

       private string _IdTipoSer_tt = string.Empty;
       
       public string IdTipoSer_tt
       {
           get { return _IdTipoSer_tt; }
           set { _IdTipoSer_tt = value; }
       }

       private string _vcDescServicio = string.Empty;
       
       public string vcDescServicio
       {
           get { return _vcDescServicio; }
           set { _vcDescServicio = value; }
       }

       private string _IdSocio = string.Empty;
       
       public string IdSocio
       {
           get { return _IdSocio; }
           set { _IdSocio = value; }
       }

       private string _IdMoneda_tt = string.Empty;
       
       public string IdMoneda_tt
       {
           get { return _IdMoneda_tt; }
           set { _IdMoneda_tt = value; }
       }

       private decimal _nImporteFIn = 0;
       
       public decimal nImporteFIn
       {
           get { return _nImporteFIn; }
           set { _nImporteFIn = value; }
       }

       private System.DateTime _sdFechaFin;
       
       public System.DateTime sdFechaFin
       {
           get { return _sdFechaFin; }
           set { _sdFechaFin = value; }
       }

       private decimal _nImporteAte = 0;
       
       public decimal nImporteAte
       {
           get { return _nImporteAte; }
           set { _nImporteAte = value; }
       }

       private string _IdLote = string.Empty;
       
       public string IdLote
       {
           get { return _IdLote; }
           set { _IdLote = value; }
       }

       private string _cItem = string.Empty;
       
       public string cItem
       {
           get { return _cItem; }
           set { _cItem = value; }
       }

       private string _vcContacto = string.Empty;
       
       public string vcContacto
       {
           get { return _vcContacto; }
           set { _vcContacto = value; }
       }

       private string _idcargo_tt = string.Empty;
       
       public string idcargo_tt
       {
           get { return _idcargo_tt; }
           set { _idcargo_tt = value; }
       }

       private string _telefonoanx = string.Empty;
       
       public string telefonoanx
       {
           get { return _telefonoanx; }
           set { _telefonoanx = value; }
       }

       private string _celular = string.Empty;
       
       public string celular
       {
           get { return _celular; }
           set { _celular = value; }
       }

       private string _emailcorp = string.Empty;
       
       public string emailcorp
       {
           get { return _emailcorp; }
           set { _emailcorp = value; }
       }

       private string _IdGestor = string.Empty;
       public string IdGestor
       {
           get { return _IdGestor; }
           set { _IdGestor = value; }
       }

       private string _Origen = string.Empty;
       public string Origen
       {
           get { return _Origen; }
           set { _Origen = value; }
       }
   }
}
