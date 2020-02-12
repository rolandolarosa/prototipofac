namespace Efide.Tesoreria.WinAdeudosInversiones.cuentaBancos
{
    partial class frmCuentaBancos
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
            this.cboBanco = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.cboTipoCuenta = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.txtCuentaCCI = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.txtCuentaLocal = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.cboMoneda = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.cboTipoEntidadFinanciera = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.ucLoadingBar1 = new Efide.ControlsComponent.ucLoadingBar();
            this.ucMsgBox1 = new Efide.ControlsComponent.ucMsgBox();
            this.grpDato.SuspendLayout();
            this.groupPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDato
            // 
            this.grpDato.Controls.Add(this.ucMsgBox1);
            this.grpDato.Controls.Add(this.ucLoadingBar1);
            this.grpDato.Controls.Add(this.groupPanel1);
            this.grpDato.Size = new System.Drawing.Size(397, 253);
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
            // toolBar
            // 
            // 
            // 
            // 
            this.toolBar.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.toolBar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.toolBar.Size = new System.Drawing.Size(397, 39);
            // 
            // 
            // 
            this.toolBar.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.toolBar.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // cboBanco
            // 
            this.cboBanco.DisplayMember = "Text";
            this.cboBanco.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboBanco.FormattingEnabled = true;
            this.cboBanco.ItemHeight = 14;
            this.cboBanco.Location = new System.Drawing.Point(117, 32);
            this.cboBanco.Name = "cboBanco";
            this.cboBanco.Size = new System.Drawing.Size(238, 20);
            this.cboBanco.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboBanco.TabIndex = 2;
            // 
            // labelX7
            // 
            this.labelX7.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX7.Location = new System.Drawing.Point(15, 30);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(96, 23);
            this.labelX7.TabIndex = 18;
            this.labelX7.Text = "Banco:";
            this.labelX7.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.cboTipoCuenta);
            this.groupPanel1.Controls.Add(this.labelX1);
            this.groupPanel1.Controls.Add(this.labelX5);
            this.groupPanel1.Controls.Add(this.txtCuentaCCI);
            this.groupPanel1.Controls.Add(this.labelX4);
            this.groupPanel1.Controls.Add(this.txtCuentaLocal);
            this.groupPanel1.Controls.Add(this.cboMoneda);
            this.groupPanel1.Controls.Add(this.labelX3);
            this.groupPanel1.Controls.Add(this.cboTipoEntidadFinanciera);
            this.groupPanel1.Controls.Add(this.labelX2);
            this.groupPanel1.Controls.Add(this.cboBanco);
            this.groupPanel1.Controls.Add(this.labelX7);
            this.groupPanel1.Location = new System.Drawing.Point(5, 42);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(380, 171);
            // 
            // 
            // 
            this.groupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel1.Style.BackColorGradientAngle = 90;
            this.groupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderBottomWidth = 1;
            this.groupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderLeftWidth = 1;
            this.groupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderRightWidth = 1;
            this.groupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderTopWidth = 1;
            this.groupPanel1.Style.CornerDiameter = 4;
            this.groupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel1.TabIndex = 19;
            this.groupPanel1.Text = "Datos de cuenta bancaria";
            // 
            // cboTipoCuenta
            // 
            this.cboTipoCuenta.DisplayMember = "Text";
            this.cboTipoCuenta.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboTipoCuenta.FormattingEnabled = true;
            this.cboTipoCuenta.ItemHeight = 14;
            this.cboTipoCuenta.Location = new System.Drawing.Point(117, 74);
            this.cboTipoCuenta.Name = "cboTipoCuenta";
            this.cboTipoCuenta.Size = new System.Drawing.Size(238, 20);
            this.cboTipoCuenta.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboTipoCuenta.TabIndex = 4;
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(15, 72);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(96, 23);
            this.labelX1.TabIndex = 69;
            this.labelX1.Text = "Tipo Cuenta:";
            this.labelX1.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // labelX5
            // 
            this.labelX5.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Location = new System.Drawing.Point(15, 115);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(96, 23);
            this.labelX5.TabIndex = 66;
            this.labelX5.Text = "CCI:";
            this.labelX5.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // txtCuentaCCI
            // 
            // 
            // 
            // 
            this.txtCuentaCCI.Border.Class = "TextBoxBorder";
            this.txtCuentaCCI.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtCuentaCCI.Location = new System.Drawing.Point(117, 116);
            this.txtCuentaCCI.MaxLength = 50;
            this.txtCuentaCCI.Name = "txtCuentaCCI";
            this.txtCuentaCCI.Size = new System.Drawing.Size(238, 20);
            this.txtCuentaCCI.TabIndex = 6;
            this.txtCuentaCCI.Tag = "Requerido";
            // 
            // labelX4
            // 
            this.labelX4.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(15, 93);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(96, 23);
            this.labelX4.TabIndex = 64;
            this.labelX4.Text = "Cuenta Local:";
            this.labelX4.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // txtCuentaLocal
            // 
            // 
            // 
            // 
            this.txtCuentaLocal.Border.Class = "TextBoxBorder";
            this.txtCuentaLocal.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtCuentaLocal.Location = new System.Drawing.Point(117, 95);
            this.txtCuentaLocal.MaxLength = 50;
            this.txtCuentaLocal.Name = "txtCuentaLocal";
            this.txtCuentaLocal.Size = new System.Drawing.Size(238, 20);
            this.txtCuentaLocal.TabIndex = 5;
            this.txtCuentaLocal.Tag = "Requerido";
            // 
            // cboMoneda
            // 
            this.cboMoneda.DisplayMember = "Text";
            this.cboMoneda.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboMoneda.FormattingEnabled = true;
            this.cboMoneda.ItemHeight = 14;
            this.cboMoneda.Location = new System.Drawing.Point(117, 53);
            this.cboMoneda.Name = "cboMoneda";
            this.cboMoneda.Size = new System.Drawing.Size(238, 20);
            this.cboMoneda.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboMoneda.TabIndex = 3;
            // 
            // labelX3
            // 
            this.labelX3.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(15, 51);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(96, 23);
            this.labelX3.TabIndex = 63;
            this.labelX3.Text = "Moneda:";
            this.labelX3.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // cboTipoEntidadFinanciera
            // 
            this.cboTipoEntidadFinanciera.DisplayMember = "Text";
            this.cboTipoEntidadFinanciera.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboTipoEntidadFinanciera.FormattingEnabled = true;
            this.cboTipoEntidadFinanciera.ItemHeight = 14;
            this.cboTipoEntidadFinanciera.Location = new System.Drawing.Point(117, 11);
            this.cboTipoEntidadFinanciera.Name = "cboTipoEntidadFinanciera";
            this.cboTipoEntidadFinanciera.Size = new System.Drawing.Size(238, 20);
            this.cboTipoEntidadFinanciera.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboTipoEntidadFinanciera.TabIndex = 1;
            this.cboTipoEntidadFinanciera.SelectedIndexChanged += new System.EventHandler(this.cboTipoEntidadFinanciera_SelectedIndexChanged);
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(15, 8);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(96, 23);
            this.labelX2.TabIndex = 21;
            this.labelX2.Text = "Tipo Financiera:";
            this.labelX2.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // ucLoadingBar1
            // 
            this.ucLoadingBar1.BackColor = System.Drawing.Color.Transparent;
            this.ucLoadingBar1.Location = new System.Drawing.Point(216, 219);
            this.ucLoadingBar1.Name = "ucLoadingBar1";
            this.ucLoadingBar1.Size = new System.Drawing.Size(167, 26);
            this.ucLoadingBar1.TabIndex = 21;
            // 
            // ucMsgBox1
            // 
            this.ucMsgBox1.Location = new System.Drawing.Point(9, 140);
            this.ucMsgBox1.Name = "ucMsgBox1";
            this.ucMsgBox1.Size = new System.Drawing.Size(10, 10);
            this.ucMsgBox1.TabIndex = 22;
            // 
            // frmCuentaBancos
            // 
            this.ClientSize = new System.Drawing.Size(397, 253);
            this.DoubleBuffered = true;
            this.Name = "frmCuentaBancos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "frmCuentaBancos";
            this.Load += new System.EventHandler(this.frmCuentaBancos_Load);
            this.grpDato.ResumeLayout(false);
            this.groupPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.ComboBoxEx cboBanco;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private ControlsComponent.ucMsgBox ucMsgBox1;
        private ControlsComponent.ucLoadingBar ucLoadingBar1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboMoneda;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboTipoEntidadFinanciera;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.Controls.TextBoxX txtCuentaCCI;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.Controls.TextBoxX txtCuentaLocal;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboTipoCuenta;
        private DevComponents.DotNetBar.LabelX labelX1;

    }
}