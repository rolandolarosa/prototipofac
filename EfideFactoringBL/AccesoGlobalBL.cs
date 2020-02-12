using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EfideFactoringBE;
using EfideFactoringDA;

namespace EfideFactoringBL
{
    public class AccesoGlobalBL
    {
        AccesoGlobalDA AccesoGlobalDA = new AccesoGlobalDA();

        public List<AccesoGlobalBE> ListaAccesos(string rolID, string usuarioID, string plataformaID, string moduloID)
        {
            return AccesoGlobalDA.ListaAccesos(rolID, usuarioID, plataformaID, moduloID);
        }
    }
}
