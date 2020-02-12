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
    public partial class frmMntFiltro : DevComponents.DotNetBar.OfficeForm
    {
        public frmMntFiltro()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

    }
}