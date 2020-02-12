using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfideFactoringBE
{
    public class EvaluacionCarteraBE
    {
        public string CreditoID { get; set; }
        public string RazonSocial { get; set; }
        public string NroCredito { get; set; }
        public string Categoria { get; set; }
        public string Producto { get; set; }
        public decimal ImporteOriginal  { get; set; }
        public decimal evaCarteraVigente { get; set; }
        public decimal evaCarteraVencida { get; set; }
        public string Calificacion { get; set; }
        public decimal ProvisionEspecifica { get; set; }
        public decimal PorcCalificacion { get; set; }
        public bool indAltoRiesgo { get; set; }

        public int anio { get; set; }
        public int mes { get; set; }
    }
}
