using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EfideFactoringBE;
using EfideFactoringBL;
using System.Data;

namespace EfideFactoring.Formula.Seguridad
{
    public partial class frmMntMenu : Form
    {

        DataView dvwHijos = default(DataView);
        DataTable dtOpcionLst = new DataTable();
        bool detallar = false;        
        
        public frmMntMenu()
        {
            InitializeComponent();
        }

        private void frmMntMenu_Load(object sender, EventArgs e)
        {
            try
            {
                fnSelOpcion();
                fnHabilitarOpciones();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error: " + ex.Message);
            }
        }
        
        private void fnSelOpcion()
        {
            try
            {
                tvwOpciones.Nodes.Clear();
                if (detallar) 
                {
                    dtOpcionLst = (new OpcionBL()).ListarDetalle();
                }
                else
                {
                    dtOpcionLst = (new OpcionBL()).Listar();
                }
                fnCrearArbol("0", null);
                fnExpandir();
            }
            catch (Exception ex)
            {
                //Throw ex
            }
        } 

   public void fnHabilitarOpciones()
   {
        try
        {
            //Dim dt As DataTable = New CargoBL().Priv_CargoPantalla(pcUsuCod, Me.Name)
            DataTable dt = new CargoBL().Priv_CargoPantalla(General.General.GetCodigoUsuario, this.Name);

            if (dt.Rows.Count > 0) 
            {
            }
            else
            {
                MessageBox.Show("Usted no tiene Permisos para Acceder...", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }
         catch (Exception ex)
         {
            //Throw ex
         }
     }

   private void fnCrearArbol(string IdPadre, TreeNode nodePadre)
   {
       dvwHijos = new DataView(dtOpcionLst);
       dvwHijos.RowFilter = "IdPadre = '" + IdPadre + "'";
       if (dvwHijos.Count > 0)
       {
           foreach (DataRowView dataRowCurrent in dvwHijos)
           {
               TreeNode nuevoNodo = new TreeNode();
               nuevoNodo.Text = dataRowCurrent["cOpcNom"].ToString();
               nuevoNodo.Name = dataRowCurrent["IdOpcion"].ToString();

               if (nodePadre == null)
               {
                   tvwOpciones.Nodes.Add(nuevoNodo);
               }
               else
               {
                   nodePadre.Nodes.Add(nuevoNodo);
               }

               nuevoNodo.Checked = false;
               fnCrearArbol(dataRowCurrent["IdOpcion"].ToString(), nuevoNodo);
           }
       }
   }

   private void fnExpandir()
   {
       try
       {
           foreach (TreeNode nodo in tvwOpciones.Nodes)
           {
               nodo.Expand();
               if (nodo.Nodes.Count > 0)
               {
                   foreach (TreeNode nodo2 in nodo.Nodes)
                   {
                       nodo2.Expand();
                   }
               }
           }
       }
       catch (Exception ex)
       {
           throw ex;
       }
   }

    }
}
