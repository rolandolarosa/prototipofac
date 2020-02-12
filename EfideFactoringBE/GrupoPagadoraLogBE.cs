
namespace EfideFactoringBE
{
   public class GrupoPagadoraLogBE : GeneralBE
   {
       private string _IdGrupoLineaLog = string.Empty;
       
       public string IdGrupoLineaLog
       {
           get { return _IdGrupoLineaLog; }
           set { _IdGrupoLineaLog = value; }
       }

       private string _IdGrupoPagadora = string.Empty;
       
       public string IdGrupoPagadora
       {
           get { return _IdGrupoPagadora; }
           set { _IdGrupoPagadora = value; }
       }

       private System.DateTime _dtRegistro;
       
       public System.DateTime dtRegistro
       {
           get { return _dtRegistro; }
           set { _dtRegistro = value; }
       }

       private decimal _IdMoneda_tt = 0;
       
       public decimal IdMoneda_tt
       {
           get { return _IdMoneda_tt; }
           set { _IdMoneda_tt = value; }
       }

       private decimal _nImporteAnterior = 0;
       
       public decimal nImporteAnterior
       {
           get { return _nImporteAnterior; }
           set { _nImporteAnterior = value; }
       }

       private decimal _nImporteNuevo = 0;
       
       public decimal nImporteNuevo
       {
           get { return _nImporteNuevo; }
           set { _nImporteNuevo = value; }
       }

   }
}
