namespace EfideFactoring.Formula.Reportes
{
    partial class frmRptCobranza
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dtInicio = new System.Windows.Forms.DateTimePicker();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX16 = new DevComponents.DotNetBar.LabelX();
            this.btnBusquedaSocio = new DevComponents.DotNetBar.ButtonX();
            this.txtRazonSocialSocio = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtIdSocio = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnLimpiar = new DevComponents.DotNetBar.ButtonX();
            this.grpDato.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDato
            // 
            this.grpDato.Controls.Add(this.btnLimpiar);
            this.grpDato.Controls.Add(this.labelX16);
            this.grpDato.Controls.Add(this.btnBusquedaSocio);
            this.grpDato.Controls.Add(this.txtRazonSocialSocio);
            this.grpDato.Controls.Add(this.txtIdSocio);
            this.grpDato.Controls.Add(this.dtInicio);
            this.grpDato.Controls.Add(this.labelX4);
            this.grpDato.Size = new System.Drawing.Size(509, 103);
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
            this.btnCancelar.Location = new System.Drawing.Point(428, 124);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(337, 124);
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // dtInicio
            // 
            this.dtInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtInicio.Location = new System.Drawing.Point(110, 15);
            this.dtInicio.Name = "dtInicio";
            this.dtInicio.Size = new System.Drawing.Size(102, 20);
            this.dtInicio.TabIndex = 95;
            // 
            // labelX4
            // 
            this.labelX4.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(26, 14);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(81, 23);
            this.labelX4.TabIndex = 94;
            this.labelX4.Text = "Fecha de Corte";
            // 
            // labelX16
            // 
            this.labelX16.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX16.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX16.Location = new System.Drawing.Point(25, 43);
            this.labelX16.Name = "labelX16";
            this.labelX16.Size = new System.Drawing.Size(79, 23);
            this.labelX16.TabIndex = 96;
            this.labelX16.Text = "Socio";
            // 
            // btnBusquedaSocio
            // 
            this.btnBusquedaSocio.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnBusquedaSocio.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnBusquedaSocio.Location = new System.Drawing.Point(428, 43);
            this.btnBusquedaSocio.Name = "btnBusquedaSocio";
            this.btnBusquedaSocio.Size = new System.Drawing.Size(31, 20);
            this.btnBusquedaSocio.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnBusquedaSocio.TabIndex = 99;
            this.btnBusquedaSocio.Text = "...";
            this.btnBusquedaSocio.Click += new System.EventHandler(this.btnBusquedaSocio_Click);
            // 
            // txtRazonSocialSocio
            // 
            // 
            // 
            // 
            this.txtRazonSocialSocio.Border.Class = "TextBoxBorder";
            this.txtRazonSocialSocio.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtRazonSocialSocio.Location = new System.Drawing.Point(215, 43);
            this.txtRazonSocialSocio.Name = "txtRazonSocialSocio";
            this.txtRazonSocialSocio.ReadOnly = true;
            this.txtRazonSocialSocio.Size = new System.Drawing.Size(210, 20);
            this.txtRazonSocialSocio.TabIndex = 98;
            this.txtRazonSocialSocio.TabStop = false;
            // 
            // txtIdSocio
            // 
            // 
            // 
            // 
            this.txtIdSocio.Border.Class = "TextBoxBorder";
            this.txtIdSocio.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtIdSocio.Location = new System.Drawing.Point(110, 43);
            this.txtIdSocio.Name = "txtIdSocio";
            this.txtIdSocio.ReadOnly = true;
            this.txtIdSocio.Size = new System.Drawing.Size(104, 20);
            this.txtIdSocio.TabIndex = 97;
            this.txtIdSocio.TabStop = false;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnLimpiar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnLimpiar.Image = global::EfideFactoring.Properties.Resources.magifier_zoom_out;
            this.btnLimpiar.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnLimpiar.Location = new System.Drawing.Point(465, 43);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(31, 20);
            this.btnLimpiar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnLimpiar.TabIndex = 100;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // frmRptCobranza
            // 
            this.ClientSize = new System.Drawing.Size(517, 160);
            this.DoubleBuffered = true;
            this.Name = "frmRptCobranza";
            this.Text = "Reporte de Cobranzas Socio";
            this.grpDato.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtInicio;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX16;
        private DevComponents.DotNetBar.ButtonX btnBusquedaSocio;
        private DevComponents.DotNetBar.Controls.TextBoxX txtRazonSocialSocio;
        private DevComponents.DotNetBar.Controls.TextBoxX txtIdSocio;
        protected DevComponents.DotNetBar.ButtonX btnLimpiar;
    }
}
