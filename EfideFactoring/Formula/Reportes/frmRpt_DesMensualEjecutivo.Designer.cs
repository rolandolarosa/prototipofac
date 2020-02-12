namespace EfideFactoring.Formula.Reportes
{
    partial class frmRpt_DesMensualEjecutivo
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
            this.btnDesembolsosSoles = new DevComponents.DotNetBar.ButtonX();
            this.btnDesembolsosDolares = new DevComponents.DotNetBar.ButtonX();
            this.btnDesemMensualEjec = new DevComponents.DotNetBar.ButtonX();
            this.btnDesMenSector = new DevComponents.DotNetBar.ButtonX();
            this.grpDato.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDato
            // 
            this.grpDato.Controls.Add(this.btnDesMenSector);
            this.grpDato.Controls.Add(this.btnDesemMensualEjec);
            this.grpDato.Controls.Add(this.btnDesembolsosDolares);
            this.grpDato.Controls.Add(this.btnDesembolsosSoles);
            this.grpDato.Size = new System.Drawing.Size(333, 200);
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
            this.btnCancelar.Location = new System.Drawing.Point(252, 221);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(161, 221);
            this.btnAceptar.Visible = false;
            // 
            // btnDesembolsosSoles
            // 
            this.btnDesembolsosSoles.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDesembolsosSoles.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDesembolsosSoles.Location = new System.Drawing.Point(29, 22);
            this.btnDesembolsosSoles.Name = "btnDesembolsosSoles";
            this.btnDesembolsosSoles.Size = new System.Drawing.Size(243, 23);
            this.btnDesembolsosSoles.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnDesembolsosSoles.TabIndex = 0;
            this.btnDesembolsosSoles.Text = "Desembolsos Mensuales x Ejecutivo Soles";
            this.btnDesembolsosSoles.Click += new System.EventHandler(this.btnDesembolsosSoles_Click);
            // 
            // btnDesembolsosDolares
            // 
            this.btnDesembolsosDolares.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDesembolsosDolares.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDesembolsosDolares.Location = new System.Drawing.Point(29, 62);
            this.btnDesembolsosDolares.Name = "btnDesembolsosDolares";
            this.btnDesembolsosDolares.Size = new System.Drawing.Size(243, 23);
            this.btnDesembolsosDolares.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnDesembolsosDolares.TabIndex = 1;
            this.btnDesembolsosDolares.Text = "Desembolsos Mensuales x Ejecutivo Dolares";
            this.btnDesembolsosDolares.Click += new System.EventHandler(this.btnDesembolsosDolares_Click);
            // 
            // btnDesemMensualEjec
            // 
            this.btnDesemMensualEjec.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDesemMensualEjec.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDesemMensualEjec.Location = new System.Drawing.Point(29, 108);
            this.btnDesemMensualEjec.Name = "btnDesemMensualEjec";
            this.btnDesemMensualEjec.Size = new System.Drawing.Size(191, 23);
            this.btnDesemMensualEjec.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnDesemMensualEjec.TabIndex = 2;
            this.btnDesemMensualEjec.Text = "Desembolsos Mensuales en Soles";
            this.btnDesemMensualEjec.Click += new System.EventHandler(this.btnDesemMensualEjec_Click);
            // 
            // btnDesMenSector
            // 
            this.btnDesMenSector.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDesMenSector.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDesMenSector.Location = new System.Drawing.Point(29, 147);
            this.btnDesMenSector.Name = "btnDesMenSector";
            this.btnDesMenSector.Size = new System.Drawing.Size(191, 23);
            this.btnDesMenSector.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnDesMenSector.TabIndex = 3;
            this.btnDesMenSector.Text = "Desembolsos Mensuales por Sector";
            this.btnDesMenSector.Click += new System.EventHandler(this.btnDesMenSector_Click);
            // 
            // frmRpt_DesMensualEjecutivo
            // 
            this.ClientSize = new System.Drawing.Size(341, 257);
            this.DoubleBuffered = true;
            this.Name = "frmRpt_DesMensualEjecutivo";
            this.Text = "Reporte de Desembolsos Mensuales";
            this.grpDato.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX btnDesembolsosDolares;
        private DevComponents.DotNetBar.ButtonX btnDesembolsosSoles;
        private DevComponents.DotNetBar.ButtonX btnDesemMensualEjec;
        private DevComponents.DotNetBar.ButtonX btnDesMenSector;
    }
}