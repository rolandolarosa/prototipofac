using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace EfideFactoring.FormulaBase
{
    public partial class frmMntDato : DevComponents.DotNetBar.OfficeForm
    {
        public string Operacion = String.Empty;
        public string Codigo = String.Empty;

        public frmMntDato()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}