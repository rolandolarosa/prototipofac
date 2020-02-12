using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EfideFactoringBE;
using EfideFactoringDA;

namespace EfideFactoringBL
{
    public class EvaluacionCarteraBL
    {
        EvaluacionCarteraDA _EvaluacionCarteraDA = new EvaluacionCarteraDA();

        public EvaluacionCarteraBE ObtenerEvaluacionCartera(string creditoID, string anio, string mes)
        {
            return _EvaluacionCarteraDA.ObtenerEvaluacionCartera(creditoID, anio, mes);
        }

        public void UpdateEvaluacionCartera(EvaluacionCarteraBE pEvaluacionCarteraBE)
        {
            _EvaluacionCarteraDA.UpdateEvaluacionCartera(pEvaluacionCarteraBE);
        }
    }
}
