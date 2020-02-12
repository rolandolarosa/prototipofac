using System.Data;
using EfideFactoringBE;
using EfideFactoringDA;

namespace EfideFactoringBL
{
    public class CobranzaPagoBL
    {
        CobranzaPagoDA CobranzaPagoDA = new CobranzaPagoDA();

        public DataSet ProcesarCobranzaPago(CobranzaPagoBE BE)
        {
            return CobranzaPagoDA.ProcesarCobranzaPago(BE);
        }
    }
}
