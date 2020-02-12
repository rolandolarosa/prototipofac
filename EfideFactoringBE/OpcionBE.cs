using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfideFactoringBE
{
    class OpcionBE
    {
        private string _IdOpcion;
        private int _IdPadre;
        private string _cOpcTipo;
        private string _cOpcDesc;
        private string _cOpcNom;
        private string _cOpcNomMenu;
        private int _cOpcOrden;
        private string _Estado;
        private string _Usuario;

        public string IdOpcion
        {
            get { return _IdOpcion; }
            set { _IdOpcion = value; }
        }
        public int IdPadre
        {
            get { return _IdPadre; }
            set { _IdPadre = value; }
        }
        public string cOpcTipo
        {
            get { return _cOpcTipo; }
            set { _cOpcTipo = value; }
        }
        public string cOpcDesc
        {
            get { return _cOpcDesc; }
            set { _cOpcDesc = value; }
        }
        public int cOpcOrden
        {
            get { return _cOpcOrden; }
            set { _cOpcOrden = value; }
        }
        public string cOpcNom
        {
            get { return _cOpcNom; }
            set { _cOpcNom = value; }
        }
        public string cOpcNomMenu
        {
            get { return _cOpcNomMenu; }
            set { _cOpcNomMenu = value; }
        }
        public string cEstado
        {
            get { return _Estado; }
            set { _Estado = value; }
        }
        public string cUsuario
        {
            get { return _Usuario; }
            set { _Usuario = value; }
        }

    }
}
