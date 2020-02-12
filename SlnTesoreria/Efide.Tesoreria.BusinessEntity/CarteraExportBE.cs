using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Efide.Tesoreria.BusinessEntity
{
    public class CarteraExportBE
    {

        public string Cod_Inversion { get; set; }

        public string Nro_Certificado { get; set; }

        public string Tipo_Inversion { get; set; }

        public string Tipo_Financiera { get; set; }

        public string Financiera { get; set; }

        public string Moneda { get; set; }

        public decimal Importe { get; set; }

        public decimal Tasa { get; set; }

        public int Plazo { get; set; }

        public DateTime Fecha_Inicio { get; set; }

        public DateTime Fecha_Vencimiento { get; set; }

        public decimal Tasa_Rescision { get; set; }

        public int Plazo_Rescision { get; set; }

        public int Transcurrido { get; set; }

        public int Faltante { get; set; }

        public string Observaciones { get; set; }

        public string Estado { get; set; }

        public string Funcionario { get; set; }

        public string Telefono { get; set; }

        public string Anexo { get; set; }

        public string Correo { get; set; }
    }
}
