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
    public partial class frmRegistroBase : DevComponents.DotNetBar.OfficeForm
    {
        public frmRegistroBase()
        {
            InitializeComponent();
        }

        #region " PROPERTIES "
        public enum Mode
        {
            normal,
            modal
        }
        public Mode mode { get; set; }
        #endregion

        private void frmRegistroBase_Load(object sender, EventArgs e)
        {
            int top = 0;

            switch (mode)
            {
                case Mode.normal:
                    top = 30;
                    break;
                case Mode.modal:
                    top = 120;
                    break;
                default:
                    break;
            }

            this.TopMost = false;
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2, top);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}