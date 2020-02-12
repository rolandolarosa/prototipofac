using System;
using System.Data;
using EfideFactoringBE;
using EfideFactoringDA;

namespace EfideFactoringBL
{
    public class ReporteBL
    {
        ReporteDA ReporteDAL = new ReporteDA();

        public DataSet ProcesarReporte(int Opcion, string Usuario, int ConceptoId = 0, string Columna = "", int ValorMonedaId = 0, int FlgSBS = 0)
        {
            return ReporteDAL.ProcesarReporte(Opcion, Usuario, ConceptoId, Columna, ValorMonedaId, FlgSBS);
        }

        public DataSet ProcesarReporteRatioLiquidez(int Opcion, string Usuario, int ConceptoId = 0, string Columna = "", int ValorMonedaId = 0)
        {
            return ReporteDAL.ProcesarReporteRatioLiquidez(Opcion, Usuario, ConceptoId, Columna, ValorMonedaId);
        }
    }
}
