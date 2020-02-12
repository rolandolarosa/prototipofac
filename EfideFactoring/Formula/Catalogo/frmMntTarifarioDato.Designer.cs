namespace EfideFactoring.Formula.Catalogo
{
    partial class frmMntTarifarioDato
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
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.cboConcepto = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cboMoneda = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.gpPorcentaje = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.txtPorMonto = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.cboPorConcepto = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.rbPorcentaje = new System.Windows.Forms.RadioButton();
            this.gpMonto = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.txtMonto = new DevComponents.Editors.DoubleInput();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.rbMonto = new System.Windows.Forms.RadioButton();
            this.cboFrecuencia = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.chkTransferencia = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.cboIdTipoCalculo_tt = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.grpDato.SuspendLayout();
            this.gpPorcentaje.SuspendLayout();
            this.gpMonto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMonto)).BeginInit();
            this.SuspendLayout();
            // 
            // grpDato
            // 
            this.grpDato.Controls.Add(this.cboIdTipoCalculo_tt);
            this.grpDato.Controls.Add(this.labelX8);
            this.grpDato.Controls.Add(this.rbPorcentaje);
            this.grpDato.Controls.Add(this.chkTransferencia);
            this.grpDato.Controls.Add(this.rbMonto);
            this.grpDato.Controls.Add(this.cboFrecuencia);
            this.grpDato.Controls.Add(this.labelX3);
            this.grpDato.Controls.Add(this.gpMonto);
            this.grpDato.Controls.Add(this.gpPorcentaje);
            this.grpDato.Controls.Add(this.cboMoneda);
            this.grpDato.Controls.Add(this.labelX1);
            this.grpDato.Controls.Add(this.cboConcepto);
            this.grpDato.Controls.Add(this.labelX2);
            this.grpDato.Size = new System.Drawing.Size(417, 198);
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
            this.grpDato.TabIndex = 0;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(336, 219);
            this.btnCancelar.TabIndex = 2;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(245, 219);
            this.btnAceptar.TabIndex = 1;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.labelX2.Location = new System.Drawing.Point(6, 5);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(59, 23);
            this.labelX2.TabIndex = 0;
            this.labelX2.Text = "Concepto";
            // 
            // cboConcepto
            // 
            this.cboConcepto.DisplayMember = "Text";
            this.cboConcepto.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboConcepto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboConcepto.FormattingEnabled = true;
            this.cboConcepto.ItemHeight = 14;
            this.cboConcepto.Location = new System.Drawing.Point(61, 7);
            this.cboConcepto.Name = "cboConcepto";
            this.cboConcepto.Size = new System.Drawing.Size(346, 20);
            this.cboConcepto.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboConcepto.TabIndex = 1;
            this.cboConcepto.SelectedIndexChanged += new System.EventHandler(this.cboConcepto_SelectedIndexChanged);
            // 
            // cboMoneda
            // 
            this.cboMoneda.DisplayMember = "Text";
            this.cboMoneda.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboMoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMoneda.Enabled = false;
            this.cboMoneda.FormattingEnabled = true;
            this.cboMoneda.ItemHeight = 14;
            this.cboMoneda.Location = new System.Drawing.Point(61, 30);
            this.cboMoneda.Name = "cboMoneda";
            this.cboMoneda.Size = new System.Drawing.Size(126, 20);
            this.cboMoneda.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboMoneda.TabIndex = 3;
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.labelX1.Location = new System.Drawing.Point(6, 30);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(59, 23);
            this.labelX1.TabIndex = 2;
            this.labelX1.Text = "Moneda";
            // 
            // gpPorcentaje
            // 
            this.gpPorcentaje.CanvasColor = System.Drawing.SystemColors.Control;
            this.gpPorcentaje.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.gpPorcentaje.Controls.Add(this.txtPorMonto);
            this.gpPorcentaje.Controls.Add(this.cboPorConcepto);
            this.gpPorcentaje.Controls.Add(this.labelX4);
            this.gpPorcentaje.Location = new System.Drawing.Point(6, 80);
            this.gpPorcentaje.Name = "gpPorcentaje";
            this.gpPorcentaje.Size = new System.Drawing.Size(200, 57);
            // 
            // 
            // 
            this.gpPorcentaje.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.gpPorcentaje.Style.BackColorGradientAngle = 90;
            this.gpPorcentaje.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.gpPorcentaje.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gpPorcentaje.Style.BorderBottomWidth = 1;
            this.gpPorcentaje.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.gpPorcentaje.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gpPorcentaje.Style.BorderLeftWidth = 1;
            this.gpPorcentaje.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gpPorcentaje.Style.BorderRightWidth = 1;
            this.gpPorcentaje.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gpPorcentaje.Style.BorderTopWidth = 1;
            this.gpPorcentaje.Style.CornerDiameter = 4;
            this.gpPorcentaje.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.gpPorcentaje.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.gpPorcentaje.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.gpPorcentaje.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.gpPorcentaje.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.gpPorcentaje.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.gpPorcentaje.TabIndex = 4;
            // 
            // txtPorMonto
            // 
            // 
            // 
            // 
            this.txtPorMonto.Border.Class = "TextBoxBorder";
            this.txtPorMonto.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtPorMonto.Location = new System.Drawing.Point(25, 5);
            this.txtPorMonto.Name = "txtPorMonto";
            this.txtPorMonto.Size = new System.Drawing.Size(80, 20);
            this.txtPorMonto.TabIndex = 4;
            this.txtPorMonto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cboPorConcepto
            // 
            this.cboPorConcepto.DisplayMember = "Text";
            this.cboPorConcepto.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboPorConcepto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPorConcepto.FormattingEnabled = true;
            this.cboPorConcepto.ItemHeight = 14;
            this.cboPorConcepto.Location = new System.Drawing.Point(25, 27);
            this.cboPorConcepto.Name = "cboPorConcepto";
            this.cboPorConcepto.Size = new System.Drawing.Size(152, 20);
            this.cboPorConcepto.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboPorConcepto.TabIndex = 3;
            // 
            // labelX4
            // 
            this.labelX4.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.labelX4.Location = new System.Drawing.Point(111, 5);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(34, 23);
            this.labelX4.TabIndex = 2;
            this.labelX4.Text = "% de";
            // 
            // rbPorcentaje
            // 
            this.rbPorcentaje.AutoSize = true;
            this.rbPorcentaje.BackColor = System.Drawing.Color.Transparent;
            this.rbPorcentaje.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.rbPorcentaje.Location = new System.Drawing.Point(6, 59);
            this.rbPorcentaje.Name = "rbPorcentaje";
            this.rbPorcentaje.Size = new System.Drawing.Size(95, 17);
            this.rbPorcentaje.TabIndex = 0;
            this.rbPorcentaje.TabStop = true;
            this.rbPorcentaje.Text = "Por Porcentaje";
            this.rbPorcentaje.UseVisualStyleBackColor = false;
            this.rbPorcentaje.CheckedChanged += new System.EventHandler(this.rbPorcentaje_CheckedChanged);
            // 
            // gpMonto
            // 
            this.gpMonto.CanvasColor = System.Drawing.SystemColors.Control;
            this.gpMonto.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.gpMonto.Controls.Add(this.txtMonto);
            this.gpMonto.Controls.Add(this.labelX5);
            this.gpMonto.Location = new System.Drawing.Point(210, 80);
            this.gpMonto.Name = "gpMonto";
            this.gpMonto.Size = new System.Drawing.Size(200, 57);
            // 
            // 
            // 
            this.gpMonto.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.gpMonto.Style.BackColorGradientAngle = 90;
            this.gpMonto.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.gpMonto.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gpMonto.Style.BorderBottomWidth = 1;
            this.gpMonto.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.gpMonto.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gpMonto.Style.BorderLeftWidth = 1;
            this.gpMonto.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gpMonto.Style.BorderRightWidth = 1;
            this.gpMonto.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gpMonto.Style.BorderTopWidth = 1;
            this.gpMonto.Style.CornerDiameter = 4;
            this.gpMonto.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.gpMonto.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.gpMonto.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.gpMonto.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.gpMonto.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.gpMonto.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.gpMonto.TabIndex = 5;
            // 
            // txtMonto
            // 
            // 
            // 
            // 
            this.txtMonto.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txtMonto.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtMonto.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.txtMonto.Increment = 1D;
            this.txtMonto.Location = new System.Drawing.Point(61, 18);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.ShowUpDown = true;
            this.txtMonto.Size = new System.Drawing.Size(110, 20);
            this.txtMonto.TabIndex = 2;
            // 
            // labelX5
            // 
            this.labelX5.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.labelX5.Location = new System.Drawing.Point(22, 15);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(59, 23);
            this.labelX5.TabIndex = 1;
            this.labelX5.Text = "Monto";
            // 
            // rbMonto
            // 
            this.rbMonto.AutoSize = true;
            this.rbMonto.BackColor = System.Drawing.Color.Transparent;
            this.rbMonto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.rbMonto.Location = new System.Drawing.Point(210, 59);
            this.rbMonto.Name = "rbMonto";
            this.rbMonto.Size = new System.Drawing.Size(93, 17);
            this.rbMonto.TabIndex = 0;
            this.rbMonto.TabStop = true;
            this.rbMonto.Text = "Por Monto Fijo";
            this.rbMonto.UseVisualStyleBackColor = false;
            this.rbMonto.CheckedChanged += new System.EventHandler(this.rbMonto_CheckedChanged);
            // 
            // cboFrecuencia
            // 
            this.cboFrecuencia.DisplayMember = "Text";
            this.cboFrecuencia.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboFrecuencia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFrecuencia.FormattingEnabled = true;
            this.cboFrecuencia.ItemHeight = 14;
            this.cboFrecuencia.Location = new System.Drawing.Point(71, 143);
            this.cboFrecuencia.Name = "cboFrecuencia";
            this.cboFrecuencia.Size = new System.Drawing.Size(213, 20);
            this.cboFrecuencia.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboFrecuencia.TabIndex = 7;
            // 
            // labelX3
            // 
            this.labelX3.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.labelX3.Location = new System.Drawing.Point(6, 140);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(59, 23);
            this.labelX3.TabIndex = 6;
            this.labelX3.Text = "Frecuencia";
            // 
            // chkTransferencia
            // 
            this.chkTransferencia.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.chkTransferencia.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.chkTransferencia.Location = new System.Drawing.Point(6, 166);
            this.chkTransferencia.Name = "chkTransferencia";
            this.chkTransferencia.Size = new System.Drawing.Size(376, 21);
            this.chkTransferencia.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.chkTransferencia.TabIndex = 8;
            this.chkTransferencia.Text = "Solamente aplicar en transferencias";
            this.chkTransferencia.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            // 
            // cboIdTipoCalculo_tt
            // 
            this.cboIdTipoCalculo_tt.DisplayMember = "Text";
            this.cboIdTipoCalculo_tt.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboIdTipoCalculo_tt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboIdTipoCalculo_tt.FormattingEnabled = true;
            this.cboIdTipoCalculo_tt.ItemHeight = 14;
            this.cboIdTipoCalculo_tt.Location = new System.Drawing.Point(279, 30);
            this.cboIdTipoCalculo_tt.Name = "cboIdTipoCalculo_tt";
            this.cboIdTipoCalculo_tt.Size = new System.Drawing.Size(128, 20);
            this.cboIdTipoCalculo_tt.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboIdTipoCalculo_tt.TabIndex = 36;
            // 
            // labelX8
            // 
            this.labelX8.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.labelX8.Location = new System.Drawing.Point(193, 30);
            this.labelX8.Name = "labelX8";
            this.labelX8.Size = new System.Drawing.Size(80, 23);
            this.labelX8.TabIndex = 35;
            this.labelX8.Text = "Tipo de Calculo";
            // 
            // frmMntTarifarioDato
            // 
            this.ClientSize = new System.Drawing.Size(425, 255);
            this.DoubleBuffered = true;
            this.Name = "frmMntTarifarioDato";
            this.Text = "Mantenimiento de Tarifario - Datos";
            this.Load += new System.EventHandler(this.frmMntTarifarioDato_Load);
            this.grpDato.ResumeLayout(false);
            this.grpDato.PerformLayout();
            this.gpPorcentaje.ResumeLayout(false);
            this.gpMonto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtMonto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboConcepto;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboMoneda;
        protected DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.GroupPanel gpMonto;
        private DevComponents.DotNetBar.Controls.GroupPanel gpPorcentaje;
        private System.Windows.Forms.RadioButton rbPorcentaje;
        private System.Windows.Forms.RadioButton rbMonto;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboFrecuencia;
        protected DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.CheckBoxX chkTransferencia;
        protected DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.Editors.DoubleInput txtMonto;
        protected DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboPorConcepto;
        private DevComponents.DotNetBar.Controls.TextBoxX txtPorMonto;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboIdTipoCalculo_tt;
        protected DevComponents.DotNetBar.LabelX labelX8;
    }
}
