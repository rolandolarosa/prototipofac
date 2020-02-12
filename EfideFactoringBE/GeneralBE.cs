
namespace EfideFactoringBE
{
    public class GeneralBE
    {
        public int OPCION { get; set; }
        public string USUARIO { get; set; }
        public string gSesionID { get; set; }
        public string gPlazaID { get; set; }

        private System.DateTime _gFechaOp = System.DateTime.MinValue;
        public System.DateTime gFechaOp
        {
            get { return _gFechaOp; }
            set { _gFechaOp = value; }
        }
    }
}
