using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfideFactoringBE
{
    public class PagadoraEventosBE : TableBaseBE
    {
        public string IdPagadora { get; set; }
        public string IdEvento_tt { get; set; }
        public string IdEvento_tt_Dsc { get; set; }
        public int ChkEvento { get; set; }
    }
}
