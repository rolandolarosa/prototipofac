using System.Data;
using EfideFactoringBE;
using EfideFactoringDA;

namespace EfideFactoringBL
{
    public class DepositosSBL
    {
        DepositosSADA DepositosSADA = new DepositosSADA();

        public DataSet ProcesarDepositosSA(DepositosSABE BE)
        {
            return DepositosSADA.ProcesarDepositosSA(BE);
        }
    }
}
