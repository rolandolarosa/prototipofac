
namespace EfideFactoringBE
{
    public class RenovacionBE : GeneralBE
   {
       private string _IdRenovacion = string.Empty;

       public string IdRenovacion
       {
           get { return _IdRenovacion; }
           set { _IdRenovacion = value; }
       }

       private System.DateTime _dtRenovacion;

       public System.DateTime dtRenovacion
       {
           get { return _dtRenovacion; }
           set { _dtRenovacion = value; }
       }

       private System.DateTime _dtRegistro;

       public System.DateTime dtRegistro
       {
           get { return _dtRegistro; }
           set { _dtRegistro = value; }
       }

       private string _IdMoneda_tt = string.Empty;

       public string IdMoneda_tt
       {
           get { return _IdMoneda_tt; }
           set { _IdMoneda_tt = value; }
       }

       private string _TipoRenovacion = string.Empty;

       public string TipoRenovacion
       {
           get { return _TipoRenovacion; }
           set { _TipoRenovacion = value; }
       }

       private string _CtasBancariasID = string.Empty;

       public string CtasBancariasID
       {
           get { return _CtasBancariasID; }
           set { _CtasBancariasID = value; }
       }

       private string _IdOperacion_tt = string.Empty;

       public string IdOperacion_tt
       {
           get { return _IdOperacion_tt; }
           set { _IdOperacion_tt = value; }
       }

       private string _IdTipoAbono_tt = string.Empty;

       public string IdTipoAbono_tt
       {
           get { return _IdTipoAbono_tt; }
           set { _IdTipoAbono_tt = value; }
       }

       private string _socioBancoID = string.Empty;

       public string socioBancoID
       {
           get { return _socioBancoID; }
           set { _socioBancoID = value; }
       }

       private string _IdEstado_tt = string.Empty;

       public string IdEstado_tt
       {
           get { return _IdEstado_tt; }
           set { _IdEstado_tt = value; }
       }

       private string _IdPagadora = string.Empty;

       public string IdPagadora
       {
           get { return _IdPagadora; }
           set { _IdPagadora = value; }
       }

       private string _IdSocio = string.Empty;
       public string IdSocio
       {
           get { return _IdSocio; }
           set { _IdSocio = value; }
       }
   }
}
