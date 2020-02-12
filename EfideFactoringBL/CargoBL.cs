using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EfideFactoringBE;
using EfideFactoringDA;
using System.Data;

namespace EfideFactoringBL
{
    public class CargoBL
    {

        CargoDAL _CargoDAL = new CargoDAL();
        public bool Insertar(CargoBE BE)
        {
            return _CargoDAL.Insertar(BE);
        }
        public bool Actualizar(CargoBE BE)
        {
            return _CargoDAL.Actualizar(BE);
        }
        public bool Eliminar(string ccarcod, string usuario)
        {
            return _CargoDAL.Eliminar(ccarcod, usuario);
        }

        public CargoBE Buscar(string vcod)
        {
            return _CargoDAL.Buscar(vcod);
        }

        public DataTable ListarFiltro(string _cCarNom)
        {
            return _CargoDAL.ListarFiltro(_cCarNom);
        }

    }
}
