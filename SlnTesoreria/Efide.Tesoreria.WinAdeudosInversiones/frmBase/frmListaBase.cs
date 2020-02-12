using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace Efide.Tesoreria.WinAdeudosInversiones.frmBase
{
    public partial class frmListaBase : DevComponents.DotNetBar.OfficeForm
    {
        public frmListaBase()
        {
            InitializeComponent();
        }

        private void frmListaBase_Load(object sender, EventArgs e)
        {
            this.TopMost = false;
            this.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2, 30);
            this.StartPosition = FormStartPosition.Manual;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}