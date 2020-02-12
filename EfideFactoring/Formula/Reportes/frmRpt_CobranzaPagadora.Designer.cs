namespace EfideFactoring.Formula.Reportes
{
    partial class frmRpt_CobranzaPagadora
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
            this.dtInicio = new System.Windows.Forms.DateTimePicker();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX16 = new DevComponents.DotNetBar.LabelX();
            this.txtIdPagadora = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtDescripcion = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnLimpiar = new DevComponents.DotNetBar.ButtonX();
            this.btnBuscarPagadora = new DevComponents.DotNetBar.ButtonX();
            this.grpDato.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDato
            // 
            this.grpDato.Controls.Add(this.btnLimpiar);
            this.grpDato.Controls.Add(this.btnBuscarPagadora);
            this.grpDato.Controls.Add(this.txtDescripcion);
            this.grpDato.Controls.Add(this.txtIdPagadora);
            this.grpDato.Controls.Add(this.labelX16);
            this.grpDato.Controls.Add(this.labelX4);
            this.grpDato.Controls.Add(this.dtInicio);
            this.grpDato.Size = new System.Drawing.Size(517, 97);
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
            this.btnCancelar.Location = new System.Drawing.Point(436, 118);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(345, 118);
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // dtInicio
            // 
            this.dtInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtInicio.Location = new System.Drawing.Point(113, 24);
            this.dtInicio.Name = "dtInicio";
            this.dtInicio.Size = new System.Drawing.Size(102, 20);
            this.dtInicio.TabIndex = 97;
            // 
            // labelX4
            // 
            this.labelX4.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelX4.Location = new System.Drawing.Point(26, 21);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(81, 23);
            this.labelX4.TabIndex = 98;
            this.labelX4.Text = "Fecha de Corte";
            // 
            // labelX16
            // 
            this.labelX16.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX16.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX16.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelX16.Location = new System.Drawing.Point(26, 50);
            this.labelX16.Name = "labelX16";
            this.labelX16.Size = new System.Drawing.Size(81, 23);
            this.labelX16.TabIndex = 99;
            this.labelX16.Text = "Pagadora";
            // 
            // txtIdPagadora
            // 
            // 
            // 
            // 
            this.txtIdPagadora.Border.Class = "TextBoxBorder";
            this.txtIdPagadora.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtIdPagadora.Location = new System.Drawing.Point(113, 50);
            this.txtIdPagadora.Name = "txtIdPagadora";
            this.txtIdPagadora.Size = new System.Drawing.Size(102, 20);
            this.txtIdPagadora.TabIndex = 100;
            // 
            // txtDescripcion
            // 
            // 
            // 
            // 
            this.txtDescripcion.Border.Class = "TextBoxBorder";
            this.txtDescripcion.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtDescripcion.Location = new System.Drawing.Point(217, 50);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(222, 20);
            this.txtDescripcion.TabIndex = 101;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnLimpiar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnLimpiar.Image = global::EfideFactoring.Properties.Resources.magifier_zoom_out;
            this.btnLimpiar.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnLimpiar.Location = new System.Drawing.Point(478, 50);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(31, 20);
            this.btnLimpiar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnLimpiar.TabIndex = 103;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnBuscarPagadora
            // 
            this.btnBuscarPagadora.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnBuscarPagadora.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnBuscarPagadora.Location = new System.Drawing.Point(441, 50);
            this.btnBuscarPagadora.Name = "btnBuscarPagadora";
            this.btnBuscarPagadora.Size = new System.Drawing.Size(31, 20);
            this.btnBuscarPagadora.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnBuscarPagadora.TabIndex = 102;
            this.btnBuscarPagadora.Text = "...";
            this.btnBuscarPagadora.Click += new System.EventHandler(this.btnBuscarPagadora_Click);
            // 
            // frmRpt_CobranzaPagadora
            // 
            this.ClientSize = new System.Drawing.Size(525, 154);
            this.DoubleBuffered = true;
            this.Name = "frmRpt_CobranzaPagadora";
            this.Text = "Reporte de Cobranzas Pagadora";
            this.Load += new System.EventHandler(this.frmRpt_CobranzaPagadora_Load);
            this.grpDato.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtInicio;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX16;
        private DevComponents.DotNetBar.Controls.TextBoxX txtIdPagadora;
        private DevComponents.DotNetBar.Controls.TextBoxX txtDescripcion;
        protected DevComponents.DotNetBar.ButtonX btnLimpiar;
        private DevComponents.DotNetBar.ButtonX btnBuscarPagadora;
    }
}