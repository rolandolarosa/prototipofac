namespace EfideFactoring.Formula.Reportes
{
    partial class frmRpt_DPF
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cboFechaProceso = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.btnVer = new DevComponents.DotNetBar.ButtonX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.cboMoneda = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.grpDato.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDato
            // 
            this.grpDato.Controls.Add(this.cboMoneda);
            this.grpDato.Controls.Add(this.labelX2);
            this.grpDato.Controls.Add(this.cboFechaProceso);
            this.grpDato.Controls.Add(this.btnVer);
            this.grpDato.Controls.Add(this.labelX1);
            this.grpDato.Size = new System.Drawing.Size(381, 84);
            // 
            // 
            // 
            this.grpDato.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.grpDato.Style.BackColorGradientAngle = 90;
            this.grpDato.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.grpDato.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.grpDato.Style.BorderBottomWidth = 1;
            this.grpDato.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.grpDato.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.grpDato.Style.BorderLeftWidth = 1;
            this.grpDato.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.grpDato.Style.BorderRightWidth = 1;
            this.grpDato.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.grpDato.Style.BorderTopWidth = 1;
            this.grpDato.Style.CornerDiameter = 4;
            this.grpDato.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.grpDato.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.grpDato.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.grpDato.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.grpDato.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.grpDato.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(300, 105);
            this.btnCancelar.Text = "Cerrar";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(209, 105);
            this.btnAceptar.Visible = false;
            // 
            // cboFechaProceso
            // 
            this.cboFechaProceso.DisplayMember = "Text";
            this.cboFechaProceso.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboFechaProceso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFechaProceso.FormattingEnabled = true;
            this.cboFechaProceso.ItemHeight = 14;
            this.cboFechaProceso.Location = new System.Drawing.Point(125, 20);
            this.cboFechaProceso.Name = "cboFechaProceso";
            this.cboFechaProceso.Size = new System.Drawing.Size(127, 20);
            this.cboFechaProceso.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboFechaProceso.TabIndex = 6;
            // 
            // btnVer
            // 
            this.btnVer.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnVer.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnVer.Image = global::EfideFactoring.Properties.Resources.Binocular;
            this.btnVer.Location = new System.Drawing.Point(271, 38);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(75, 23);
            this.btnVer.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnVer.TabIndex = 5;
            this.btnVer.Text = "Ver";
            this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelX1.Location = new System.Drawing.Point(22, 20);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(97, 23);
            this.labelX1.TabIndex = 4;
            this.labelX1.Text = "Fecha de Proceso";
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelX2.Location = new System.Drawing.Point(22, 38);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(97, 23);
            this.labelX2.TabIndex = 7;
            this.labelX2.Text = "Moneda";
            // 
            // cboMoneda
            // 
            this.cboMoneda.DisplayMember = "Text";
            this.cboMoneda.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboMoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMoneda.FormattingEnabled = true;
            this.cboMoneda.ItemHeight = 14;
            this.cboMoneda.Location = new System.Drawing.Point(125, 41);
            this.cboMoneda.Name = "cboMoneda";
            this.cboMoneda.Size = new System.Drawing.Size(127, 20);
            this.cboMoneda.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboMoneda.TabIndex = 8;
            // 
            // frmRpt_DPF
            // 
            this.ClientSize = new System.Drawing.Size(389, 141);
            this.DoubleBuffered = true;
            this.Name = "frmRpt_DPF";
            this.Text = "RELACIÓN DE DEPOSITOS A PLAZO FIJO ";
            this.Load += new System.EventHandler(this.frmRpt_DPF_Load);
            this.grpDato.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.ComboBoxEx cboFechaProceso;
        private DevComponents.DotNetBar.ButtonX btnVer;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboMoneda;
        private DevComponents.DotNetBar.LabelX labelX2;
    }
}