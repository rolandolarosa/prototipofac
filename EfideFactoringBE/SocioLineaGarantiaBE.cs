namespace EfideFactoringBE
{
   public class SocioLineaGarantiaBE : GeneralBE
   {
       private string _IdLinea = string.Empty;
       
       public string IdLinea
       {
           get { return _IdLinea; }
           set { _IdLinea = value; }
       }

       private string _IdPagadora = string.Empty;

       public string IdPagadora
       {
           get { return _IdPagadora; }
           set { _IdPagadora = value; }
       }

       private string _IdDocumento = string.Empty;
       
       public string IdDocumento
       {
           get { return _IdDocumento; }
           set { _IdDocumento = value; }
       }

       private string _IdTipo_Documento_tt = string.Empty;

       public string IdTipo_Documento_tt
       {
           get { return _IdTipo_Documento_tt; }
           set { _IdTipo_Documento_tt = value; }
       }

       private string _IdTipo_Documento_tt_Dsc = string.Empty;

       public string IdTipo_Documento_tt_Dsc
       {
           get { return _IdTipo_Documento_tt_Dsc; }
           set { _IdTipo_Documento_tt_Dsc = value; }
       }

       private string _Documento = string.Empty;
       
       public string Documento
       {
           get { return _Documento; }
           set { _Documento = value; }
       }

       private byte[] _Archivo;

       public byte[] Archivo
       {
           get { return _Archivo; }
           set { _Archivo = value; }
       }

       private string _files = string.Empty;
       public string files
       {
           get { return _files; }
           set { _files = value; }
       }
   }
}
