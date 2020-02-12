using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EfideFactoring.FormulaBase
{
    public partial class frmWaitForm : Form
    {
        public frmWaitForm()
        {
            InitializeComponent();
        }

        public void setMensaje(string msj)
        {
            lblMensaje.Text = msj;
        }
    }
}
