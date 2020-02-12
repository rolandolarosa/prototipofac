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
    public class OpcionBL
    {
        public DataTable Listar()
        {
            return new OpcionDAL().Listar();
        }
        public DataTable ListarDetalle()
        {
            return new OpcionDAL().ListarDetalle();
        }
        public DataTable ListarSinAccion()
        {
            return new OpcionDAL().ListarSinAccion();
        }
        public int Opcion_Ins(OpcionBE objOpcionBE)
        {
            return new OpcionDAL().Opcion_Ins(objOpcionBE);
        }
        public bool Opcion_Del(int IdOpcion)
        {
            return new OpcionDAL().Opcion_Del(IdOpcion);
        }
        public DataSet Opcion_Sel(int IdOpcion)
        {
            return new OpcionDAL().Opcion_Sel(IdOpcion);
        }
        public bool Opcion_Upd(int IdPadre, int IdOpcion)
        {
            return new OpcionDAL().Opcion_Upd(IdPadre, IdOpcion);
        }
        public bool Opcion_Upd(OpcionBE OpcionBE)
        {
            return new OpcionDAL().Opcion_Upd(OpcionBE);
        }
        public bool Opcion_UpdAccion(int IdOpcion, string Accion)
        {
            return new OpcionDAL().Opcion_UpdAccion(IdOpcion, Accion);
        }
    }
}
