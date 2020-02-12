using System.Data;
using EfideFactoringBE;
using EfideFactoringDA;

namespace EfideFactoringBL
{
    public class RenovacionPagoBL
    {
        RenovacionPagoDA RenovacionPagoDA = new RenovacionPagoDA();

        public DataSet ProcesarRenovacionPago(RenovacionPagoBE BE)
        {
            return RenovacionPagoDA.ProcesarRenovacionPago(BE);
        }
    }
}
