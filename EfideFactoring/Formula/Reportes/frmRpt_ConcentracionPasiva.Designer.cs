namespace EfideFactoring.Formula.Reportes
{
    partial class frmRpt_ConcentracionPasiva
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
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.btnVer = new DevComponents.DotNetBar.ButtonX();
            this.cboFechaProceso = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.grpDato.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDato
            // 
            this.grpDato.Controls.Add(this.cboFechaProceso);
            this.grpDato.Controls.Add(this.btnVer);
            this.grpDato.Controls.Add(this.labelX1);
            this.grpDato.Size = new System.Drawing.Size(392, 97);
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
            this.btnCancelar.Location = new System.Drawing.Point(311, 118);
            this.btnCancelar.Text = "Cerrar";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(220, 118);
            this.btnAceptar.Visible = false;
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelX1.Location = new System.Drawing.Point(32, 35);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(97, 23);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "Fecha de Proceso";
            // 
            // btnVer
            // 
            this.btnVer.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnVer.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnVer.Image = global::EfideFactoring.Properties.Resources.Binocular;
            this.btnVer.Location = new System.Drawing.Point(283, 38);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(75, 23);
            this.btnVer.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnVer.TabIndex = 2;
            this.btnVer.Text = "Ver";
            this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
            // 
            // cboFechaProceso
            // 
            this.cboFechaProceso.DisplayMember = "Text";
            this.cboFechaProceso.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboFechaProceso.FormattingEnabled = true;
            this.cboFechaProceso.ItemHeight = 14;
            this.cboFechaProceso.Location = new System.Drawing.Point(146, 38);
            this.cboFechaProceso.Name = "cboFechaProceso";
            this.cboFechaProceso.Size = new System.Drawing.Size(105, 20);
            this.cboFechaProceso.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboFechaProceso.TabIndex = 3;
            // 
            // frmRpt_ConcentracionPasiva
            // 
            this.ClientSize = new System.Drawing.Size(400, 154);
            this.DoubleBuffered = true;
            this.Name = "frmRpt_ConcentracionPasiva";
            this.Text = "Reporte Concentración Pasiva";
            this.Load += new System.EventHandler(this.frmRpt_ConcentracionPasiva_Load);
            this.grpDato.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.ButtonX btnVer;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboFechaProceso;
    }
}