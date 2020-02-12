namespace Efide.Tesoreria.WinAdeudosInversiones.inversion
{
    partial class frmRescisionInversion
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
            this.components = new System.ComponentModel.Container();
            this.txtImporteInversion = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.txtTasaInversion = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.cboMoneda = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cboBanco = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cboTipoInversion = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX9 = new DevComponents.DotNetBar.LabelX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.groupPanel2 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.txtTasaCerrada = new DevComponents.Editors.DoubleInput();
            this.txtDiasTranscurridos = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX22 = new DevComponents.DotNetBar.LabelX();
            this.txtDiferencia = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX21 = new DevComponents.DotNetBar.LabelX();
            this.txtInteresCerrado = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX20 = new DevComponents.DotNetBar.LabelX();
            this.txtITF = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX12 = new DevComponents.DotNetBar.LabelX();
            this.dtpFechaRescision = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.labelX19 = new DevComponents.DotNetBar.LabelX();
            this.txtTotalCobrar = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX15 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.txtInteresRescision = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.txtImporteRescision = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.txtObservacionesResicision = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtPlazoRescision = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtTasaRescision = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX14 = new DevComponents.DotNetBar.LabelX();
            this.labelX13 = new DevComponents.DotNetBar.LabelX();
            this.labelX11 = new DevComponents.DotNetBar.LabelX();
            this.cboTipoEntidadFinanciera = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.ucLoadingBar1 = new Efide.ControlsComponent.ucLoadingBar();
            this.ucMsgBox1 = new Efide.ControlsComponent.ucMsgBox();
            this.txtIdRescisionInversion = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.cboPlazo = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.dtFechaVencimiento = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.labelX18 = new DevComponents.DotNetBar.LabelX();
            this.dtFechaInicio = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.labelX17 = new DevComponents.DotNetBar.LabelX();
            this.labelX16 = new DevComponents.DotNetBar.LabelX();
            this.txtNroCertificado = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX25 = new DevComponents.DotNetBar.LabelX();
            this.panelEx1.SuspendLayout();
            this.groupDetalle.SuspendLayout();
            this.panelEx2.SuspendLayout();
            this.groupPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTasaCerrada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFechaRescision)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaVencimiento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaInicio)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBusqueda
            // 
            // 
            // 
            // 
            this.txtBusqueda.Border.Class = "TextBoxBorder";
            this.txtBusqueda.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtBusqueda.Location = new System.Drawing.Point(147, 15);
            this.txtBusqueda.MaxLength = 50;
            this.txtBusqueda.TabIndex = 1;
            this.txtBusqueda.Tag = "Reqrired";
            this.txtBusqueda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBusqueda_KeyPress);
            // 
            // labelX10
            // 
            // 
            // 
            // 
            this.labelX10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX10.Location = new System.Drawing.Point(34, 12);
            this.labelX10.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(388, 9);
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnDetalle
            // 
            this.btnDetalle.Location = new System.Drawing.Point(444, 9);
            this.btnDetalle.Click += new System.EventHandler(this.btnDetalle_Click);
            // 
            // panelEx1
            // 
            this.panelEx1.Location = new System.Drawing.Point(12, 52);
            this.panelEx1.Size = new System.Drawing.Size(737, 50);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            // 
            // ribbonBar1
            // 
            // 
            // 
            // 
            this.ribbonBar1.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBar1.Size = new System.Drawing.Size(760, 39);
            // 
            // 
            // 
            this.ribbonBar1.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar1.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // btnSelTransDepo
            // 
            this.btnSelTransDepo.Image = null;
            this.btnSelTransDepo.Location = new System.Drawing.Point(785, 56);
            this.btnSelTransDepo.Size = new System.Drawing.Size(24, 26);
            this.btnSelTransDepo.Text = "";
            this.btnSelTransDepo.Visible = false;
            // 
            // groupDetalle
            // 
            this.groupDetalle.BackColor = System.Drawing.Color.Transparent;
            this.groupDetalle.Controls.Add(this.txtNroCertificado);
            this.groupDetalle.Controls.Add(this.labelX25);
            this.groupDetalle.Controls.Add(this.cboPlazo);
            this.groupDetalle.Controls.Add(this.dtFechaVencimiento);
            this.groupDetalle.Controls.Add(this.labelX18);
            this.groupDetalle.Controls.Add(this.dtFechaInicio);
            this.groupDetalle.Controls.Add(this.labelX17);
            this.groupDetalle.Controls.Add(this.labelX16);
            this.groupDetalle.Controls.Add(this.cboTipoEntidadFinanciera);
            this.groupDetalle.Controls.Add(this.labelX5);
            this.groupDetalle.Controls.Add(this.txtImporteInversion);
            this.groupDetalle.Controls.Add(this.labelX8);
            this.groupDetalle.Controls.Add(this.txtTasaInversion);
            this.groupDetalle.Controls.Add(this.labelX1);
            this.groupDetalle.Controls.Add(this.cboMoneda);
            this.groupDetalle.Controls.Add(this.cboBanco);
            this.groupDetalle.Controls.Add(this.cboTipoInversion);
            this.groupDetalle.Controls.Add(this.labelX9);
            this.groupDetalle.Controls.Add(this.labelX7);
            this.groupDetalle.Controls.Add(this.labelX6);
            this.groupDetalle.Location = new System.Drawing.Point(12, 108);
            this.groupDetalle.Size = new System.Drawing.Size(737, 174);
            // 
            // 
            // 
            this.groupDetalle.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupDetalle.Style.BackColorGradientAngle = 90;
            this.groupDetalle.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupDetalle.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupDetalle.Style.BorderBottomWidth = 1;
            this.groupDetalle.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupDetalle.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupDetalle.Style.BorderLeftWidth = 1;
            this.groupDetalle.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupDetalle.Style.BorderRightWidth = 1;
            this.groupDetalle.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupDetalle.Style.BorderTopWidth = 1;
            this.groupDetalle.Style.CornerDiameter = 4;
            this.groupDetalle.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupDetalle.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupDetalle.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupDetalle.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupDetalle.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupDetalle.TabIndex = 2;
            this.groupDetalle.Tag = "";
            this.groupDetalle.Text = "Datos de Inversión";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Image = global::Efide.Tesoreria.WinAdeudosInversiones.Properties.Resources.add;
            this.btnConfirmar.Text = "Guardar";
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // panelEx2
            // 
            this.panelEx2.Controls.Add(this.ucMsgBox1);
            this.panelEx2.Controls.Add(this.ucLoadingBar1);
            this.panelEx2.Controls.Add(this.groupPanel2);
            this.panelEx2.Controls.Add(this.txtIdRescisionInversion);
            this.panelEx2.Size = new System.Drawing.Size(760, 533);
            this.panelEx2.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx2.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx2.Style.GradientAngle = 90;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Visible = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnEnviarAcuerdo
            // 
            this.btnEnviarAcuerdo.Click += new System.EventHandler(this.btnEnviarAcuerdo_Click);
            // 
            // txtImporteInversion
            // 
            // 
            // 
            // 
            this.txtImporteInversion.Border.Class = "TextBoxBorder";
            this.txtImporteInversion.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtImporteInversion.Enabled = false;
            this.txtImporteInversion.Location = new System.Drawing.Point(479, 32);
            this.txtImporteInversion.Name = "txtImporteInversion";
            this.txtImporteInversion.Size = new System.Drawing.Size(238, 20);
            this.txtImporteInversion.TabIndex = 7;
            this.txtImporteInversion.Tag = "";
            // 
            // labelX8
            // 
            this.labelX8.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX8.Location = new System.Drawing.Point(419, 30);
            this.labelX8.Name = "labelX8";
            this.labelX8.Size = new System.Drawing.Size(54, 23);
            this.labelX8.TabIndex = 44;
            this.labelX8.Text = "Importe:";
            this.labelX8.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // txtTasaInversion
            // 
            // 
            // 
            // 
            this.txtTasaInversion.Border.Class = "TextBoxBorder";
            this.txtTasaInversion.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTasaInversion.Enabled = false;
            this.txtTasaInversion.Location = new System.Drawing.Point(479, 53);
            this.txtTasaInversion.Name = "txtTasaInversion";
            this.txtTasaInversion.Size = new System.Drawing.Size(238, 20);
            this.txtTasaInversion.TabIndex = 8;
            this.txtTasaInversion.Tag = "";
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(419, 50);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(54, 23);
            this.labelX1.TabIndex = 42;
            this.labelX1.Text = "Tasa:";
            this.labelX1.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // cboMoneda
            // 
            this.cboMoneda.DisplayMember = "Text";
            this.cboMoneda.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboMoneda.Enabled = false;
            this.cboMoneda.FormattingEnabled = true;
            this.cboMoneda.ItemHeight = 14;
            this.cboMoneda.Location = new System.Drawing.Point(479, 11);
            this.cboMoneda.Name = "cboMoneda";
            this.cboMoneda.Size = new System.Drawing.Size(238, 20);
            this.cboMoneda.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboMoneda.TabIndex = 6;
            // 
            // cboBanco
            // 
            this.cboBanco.DisplayMember = "Text";
            this.cboBanco.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboBanco.Enabled = false;
            this.cboBanco.FormattingEnabled = true;
            this.cboBanco.ItemHeight = 14;
            this.cboBanco.Location = new System.Drawing.Point(144, 75);
            this.cboBanco.Name = "cboBanco";
            this.cboBanco.Size = new System.Drawing.Size(238, 20);
            this.cboBanco.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboBanco.TabIndex = 5;
            // 
            // cboTipoInversion
            // 
            this.cboTipoInversion.DisplayMember = "Text";
            this.cboTipoInversion.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboTipoInversion.Enabled = false;
            this.cboTipoInversion.FormattingEnabled = true;
            this.cboTipoInversion.ItemHeight = 14;
            this.cboTipoInversion.Location = new System.Drawing.Point(144, 33);
            this.cboTipoInversion.Name = "cboTipoInversion";
            this.cboTipoInversion.Size = new System.Drawing.Size(238, 20);
            this.cboTipoInversion.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboTipoInversion.TabIndex = 3;
            // 
            // labelX9
            // 
            this.labelX9.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX9.Location = new System.Drawing.Point(416, 9);
            this.labelX9.Name = "labelX9";
            this.labelX9.Size = new System.Drawing.Size(57, 23);
            this.labelX9.TabIndex = 38;
            this.labelX9.Text = "Moneda:";
            this.labelX9.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // labelX7
            // 
            this.labelX7.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX7.Location = new System.Drawing.Point(43, 72);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(95, 23);
            this.labelX7.TabIndex = 37;
            this.labelX7.Text = "Banco:";
            this.labelX7.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // labelX6
            // 
            this.labelX6.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Location = new System.Drawing.Point(43, 30);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(95, 23);
            this.labelX6.TabIndex = 36;
            this.labelX6.Text = "Tipo de Inversión:";
            this.labelX6.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // groupPanel2
            // 
            this.groupPanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel2.Controls.Add(this.txtTasaCerrada);
            this.groupPanel2.Controls.Add(this.txtDiasTranscurridos);
            this.groupPanel2.Controls.Add(this.labelX22);
            this.groupPanel2.Controls.Add(this.txtDiferencia);
            this.groupPanel2.Controls.Add(this.labelX21);
            this.groupPanel2.Controls.Add(this.txtInteresCerrado);
            this.groupPanel2.Controls.Add(this.labelX20);
            this.groupPanel2.Controls.Add(this.txtITF);
            this.groupPanel2.Controls.Add(this.labelX12);
            this.groupPanel2.Controls.Add(this.dtpFechaRescision);
            this.groupPanel2.Controls.Add(this.labelX19);
            this.groupPanel2.Controls.Add(this.txtTotalCobrar);
            this.groupPanel2.Controls.Add(this.labelX15);
            this.groupPanel2.Controls.Add(this.labelX4);
            this.groupPanel2.Controls.Add(this.txtInteresRescision);
            this.groupPanel2.Controls.Add(this.labelX3);
            this.groupPanel2.Controls.Add(this.txtImporteRescision);
            this.groupPanel2.Controls.Add(this.labelX2);
            this.groupPanel2.Controls.Add(this.txtObservacionesResicision);
            this.groupPanel2.Controls.Add(this.txtPlazoRescision);
            this.groupPanel2.Controls.Add(this.txtTasaRescision);
            this.groupPanel2.Controls.Add(this.labelX14);
            this.groupPanel2.Controls.Add(this.labelX13);
            this.groupPanel2.Controls.Add(this.labelX11);
            this.groupPanel2.Location = new System.Drawing.Point(13, 292);
            this.groupPanel2.Name = "groupPanel2";
            this.groupPanel2.Size = new System.Drawing.Size(736, 205);
            // 
            // 
            // 
            this.groupPanel2.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel2.Style.BackColorGradientAngle = 90;
            this.groupPanel2.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel2.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderBottomWidth = 1;
            this.groupPanel2.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel2.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderLeftWidth = 1;
            this.groupPanel2.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderRightWidth = 1;
            this.groupPanel2.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderTopWidth = 1;
            this.groupPanel2.Style.CornerDiameter = 4;
            this.groupPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel2.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel2.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel2.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel2.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel2.TabIndex = 9;
            this.groupPanel2.Text = "Cálculo de Rescisión";
            // 
            // txtTasaCerrada
            // 
            // 
            // 
            // 
            this.txtTasaCerrada.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txtTasaCerrada.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTasaCerrada.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.txtTasaCerrada.Increment = 1D;
            this.txtTasaCerrada.Location = new System.Drawing.Point(478, 87);
            this.txtTasaCerrada.Name = "txtTasaCerrada";
            this.txtTasaCerrada.ShowUpDown = true;
            this.txtTasaCerrada.Size = new System.Drawing.Size(238, 20);
            this.txtTasaCerrada.TabIndex = 77;
            // 
            // txtDiasTranscurridos
            // 
            // 
            // 
            // 
            this.txtDiasTranscurridos.Border.Class = "TextBoxBorder";
            this.txtDiasTranscurridos.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtDiasTranscurridos.Enabled = false;
            this.txtDiasTranscurridos.Location = new System.Drawing.Point(143, 45);
            this.txtDiasTranscurridos.MaxLength = 14;
            this.txtDiasTranscurridos.Name = "txtDiasTranscurridos";
            this.txtDiasTranscurridos.Size = new System.Drawing.Size(238, 20);
            this.txtDiasTranscurridos.TabIndex = 75;
            this.txtDiasTranscurridos.Tag = "Reqrired";
            // 
            // labelX22
            // 
            this.labelX22.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX22.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX22.Location = new System.Drawing.Point(38, 43);
            this.labelX22.Name = "labelX22";
            this.labelX22.Size = new System.Drawing.Size(99, 23);
            this.labelX22.TabIndex = 76;
            this.labelX22.Text = "Días Transcurridos:";
            this.labelX22.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // txtDiferencia
            // 
            // 
            // 
            // 
            this.txtDiferencia.Border.Class = "TextBoxBorder";
            this.txtDiferencia.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtDiferencia.Enabled = false;
            this.txtDiferencia.ForeColor = System.Drawing.Color.Crimson;
            this.txtDiferencia.Location = new System.Drawing.Point(478, 129);
            this.txtDiferencia.MaxLength = 14;
            this.txtDiferencia.Name = "txtDiferencia";
            this.txtDiferencia.Size = new System.Drawing.Size(238, 20);
            this.txtDiferencia.TabIndex = 73;
            // 
            // labelX21
            // 
            this.labelX21.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX21.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX21.Location = new System.Drawing.Point(400, 127);
            this.labelX21.Name = "labelX21";
            this.labelX21.Size = new System.Drawing.Size(71, 23);
            this.labelX21.TabIndex = 74;
            this.labelX21.Text = "Diferencia:";
            this.labelX21.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // txtInteresCerrado
            // 
            // 
            // 
            // 
            this.txtInteresCerrado.Border.Class = "TextBoxBorder";
            this.txtInteresCerrado.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtInteresCerrado.Enabled = false;
            this.txtInteresCerrado.Location = new System.Drawing.Point(478, 108);
            this.txtInteresCerrado.MaxLength = 10;
            this.txtInteresCerrado.Name = "txtInteresCerrado";
            this.txtInteresCerrado.Size = new System.Drawing.Size(238, 20);
            this.txtInteresCerrado.TabIndex = 15;
            this.txtInteresCerrado.Tag = "";
            this.txtInteresCerrado.TextChanged += new System.EventHandler(this.txtInteresCerrado_TextChanged);
            // 
            // labelX20
            // 
            this.labelX20.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX20.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX20.Location = new System.Drawing.Point(388, 106);
            this.labelX20.Name = "labelX20";
            this.labelX20.Size = new System.Drawing.Size(83, 23);
            this.labelX20.TabIndex = 72;
            this.labelX20.Text = "Interés Cerrado:";
            this.labelX20.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // txtITF
            // 
            // 
            // 
            // 
            this.txtITF.Border.Class = "TextBoxBorder";
            this.txtITF.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtITF.Enabled = false;
            this.txtITF.Location = new System.Drawing.Point(143, 129);
            this.txtITF.MaxLength = 14;
            this.txtITF.Name = "txtITF";
            this.txtITF.Size = new System.Drawing.Size(238, 20);
            this.txtITF.TabIndex = 65;
            // 
            // labelX12
            // 
            this.labelX12.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX12.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX12.Location = new System.Drawing.Point(38, 127);
            this.labelX12.Name = "labelX12";
            this.labelX12.Size = new System.Drawing.Size(99, 23);
            this.labelX12.TabIndex = 66;
            this.labelX12.Text = "ITF:";
            this.labelX12.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // dtpFechaRescision
            // 
            // 
            // 
            // 
            this.dtpFechaRescision.BackgroundStyle.BorderBottomWidth = 1;
            this.dtpFechaRescision.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtpFechaRescision.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtpFechaRescision.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtpFechaRescision.ButtonDropDown.Visible = true;
            this.dtpFechaRescision.Enabled = false;
            this.dtpFechaRescision.IsPopupCalendarOpen = false;
            this.dtpFechaRescision.Location = new System.Drawing.Point(144, 3);
            // 
            // 
            // 
            this.dtpFechaRescision.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtpFechaRescision.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtpFechaRescision.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dtpFechaRescision.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtpFechaRescision.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtpFechaRescision.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtpFechaRescision.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtpFechaRescision.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtpFechaRescision.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtpFechaRescision.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtpFechaRescision.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtpFechaRescision.MonthCalendar.DisplayMonth = new System.DateTime(2018, 8, 1, 0, 0, 0, 0);
            this.dtpFechaRescision.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dtpFechaRescision.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtpFechaRescision.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtpFechaRescision.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtpFechaRescision.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtpFechaRescision.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtpFechaRescision.MonthCalendar.TodayButtonVisible = true;
            this.dtpFechaRescision.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dtpFechaRescision.Name = "dtpFechaRescision";
            this.dtpFechaRescision.Size = new System.Drawing.Size(238, 20);
            this.dtpFechaRescision.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtpFechaRescision.TabIndex = 63;
            this.dtpFechaRescision.Tag = "Reqrired, Fecha";
            // 
            // labelX19
            // 
            this.labelX19.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX19.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX19.Location = new System.Drawing.Point(22, 1);
            this.labelX19.Name = "labelX19";
            this.labelX19.Size = new System.Drawing.Size(115, 23);
            this.labelX19.TabIndex = 64;
            this.labelX19.Text = "Fecha Inicio:";
            this.labelX19.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // txtTotalCobrar
            // 
            // 
            // 
            // 
            this.txtTotalCobrar.Border.Class = "TextBoxBorder";
            this.txtTotalCobrar.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTotalCobrar.Enabled = false;
            this.txtTotalCobrar.Location = new System.Drawing.Point(143, 150);
            this.txtTotalCobrar.MaxLength = 14;
            this.txtTotalCobrar.Name = "txtTotalCobrar";
            this.txtTotalCobrar.Size = new System.Drawing.Size(238, 20);
            this.txtTotalCobrar.TabIndex = 61;
            // 
            // labelX15
            // 
            this.labelX15.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX15.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX15.Location = new System.Drawing.Point(38, 148);
            this.labelX15.Name = "labelX15";
            this.labelX15.Size = new System.Drawing.Size(99, 23);
            this.labelX15.TabIndex = 62;
            this.labelX15.Text = "Total por cobrar:";
            this.labelX15.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // labelX4
            // 
            this.labelX4.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(388, 85);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(83, 23);
            this.labelX4.TabIndex = 60;
            this.labelX4.Text = "Tasa cerrada:";
            this.labelX4.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // txtInteresRescision
            // 
            // 
            // 
            // 
            this.txtInteresRescision.Border.Class = "TextBoxBorder";
            this.txtInteresRescision.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtInteresRescision.Enabled = false;
            this.txtInteresRescision.Location = new System.Drawing.Point(143, 108);
            this.txtInteresRescision.MaxLength = 14;
            this.txtInteresRescision.Name = "txtInteresRescision";
            this.txtInteresRescision.Size = new System.Drawing.Size(238, 20);
            this.txtInteresRescision.TabIndex = 13;
            // 
            // labelX3
            // 
            this.labelX3.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(38, 106);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(99, 23);
            this.labelX3.TabIndex = 58;
            this.labelX3.Text = "Interes por cobrar:";
            this.labelX3.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // txtImporteRescision
            // 
            // 
            // 
            // 
            this.txtImporteRescision.Border.Class = "TextBoxBorder";
            this.txtImporteRescision.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtImporteRescision.Enabled = false;
            this.txtImporteRescision.Location = new System.Drawing.Point(143, 66);
            this.txtImporteRescision.MaxLength = 14;
            this.txtImporteRescision.Name = "txtImporteRescision";
            this.txtImporteRescision.Size = new System.Drawing.Size(238, 20);
            this.txtImporteRescision.TabIndex = 12;
            this.txtImporteRescision.Tag = "Reqrired";
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(38, 64);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(99, 23);
            this.labelX2.TabIndex = 56;
            this.labelX2.Text = "Importe Inversión:";
            this.labelX2.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // txtObservacionesResicision
            // 
            // 
            // 
            // 
            this.txtObservacionesResicision.Border.Class = "TextBoxBorder";
            this.txtObservacionesResicision.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtObservacionesResicision.Location = new System.Drawing.Point(478, 150);
            this.txtObservacionesResicision.MaxLength = 250;
            this.txtObservacionesResicision.Multiline = true;
            this.txtObservacionesResicision.Name = "txtObservacionesResicision";
            this.txtObservacionesResicision.Size = new System.Drawing.Size(238, 20);
            this.txtObservacionesResicision.TabIndex = 16;
            // 
            // txtPlazoRescision
            // 
            // 
            // 
            // 
            this.txtPlazoRescision.Border.Class = "TextBoxBorder";
            this.txtPlazoRescision.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtPlazoRescision.Enabled = false;
            this.txtPlazoRescision.Location = new System.Drawing.Point(143, 24);
            this.txtPlazoRescision.MaxLength = 10;
            this.txtPlazoRescision.Name = "txtPlazoRescision";
            this.txtPlazoRescision.Size = new System.Drawing.Size(238, 20);
            this.txtPlazoRescision.TabIndex = 11;
            this.txtPlazoRescision.Tag = "Reqrired, Decimales";
            // 
            // txtTasaRescision
            // 
            // 
            // 
            // 
            this.txtTasaRescision.Border.Class = "TextBoxBorder";
            this.txtTasaRescision.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTasaRescision.Enabled = false;
            this.txtTasaRescision.Location = new System.Drawing.Point(143, 87);
            this.txtTasaRescision.MaxLength = 10;
            this.txtTasaRescision.Name = "txtTasaRescision";
            this.txtTasaRescision.Size = new System.Drawing.Size(238, 20);
            this.txtTasaRescision.TabIndex = 10;
            this.txtTasaRescision.Tag = "";
            // 
            // labelX14
            // 
            this.labelX14.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX14.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX14.Location = new System.Drawing.Point(388, 147);
            this.labelX14.Name = "labelX14";
            this.labelX14.Size = new System.Drawing.Size(83, 23);
            this.labelX14.TabIndex = 52;
            this.labelX14.Text = "Observaciones:";
            this.labelX14.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // labelX13
            // 
            this.labelX13.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX13.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX13.Location = new System.Drawing.Point(18, 21);
            this.labelX13.Name = "labelX13";
            this.labelX13.Size = new System.Drawing.Size(119, 23);
            this.labelX13.TabIndex = 51;
            this.labelX13.Text = "Plazo Rescisión (días):";
            this.labelX13.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // labelX11
            // 
            this.labelX11.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX11.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX11.Location = new System.Drawing.Point(36, 84);
            this.labelX11.Name = "labelX11";
            this.labelX11.Size = new System.Drawing.Size(101, 23);
            this.labelX11.TabIndex = 50;
            this.labelX11.Text = "Tasa de Rescisión:";
            this.labelX11.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // cboTipoEntidadFinanciera
            // 
            this.cboTipoEntidadFinanciera.DisplayMember = "Text";
            this.cboTipoEntidadFinanciera.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboTipoEntidadFinanciera.Enabled = false;
            this.cboTipoEntidadFinanciera.FormattingEnabled = true;
            this.cboTipoEntidadFinanciera.ItemHeight = 14;
            this.cboTipoEntidadFinanciera.Location = new System.Drawing.Point(144, 54);
            this.cboTipoEntidadFinanciera.Name = "cboTipoEntidadFinanciera";
            this.cboTipoEntidadFinanciera.Size = new System.Drawing.Size(238, 20);
            this.cboTipoEntidadFinanciera.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboTipoEntidadFinanciera.TabIndex = 4;
            this.cboTipoEntidadFinanciera.SelectedValueChanged += new System.EventHandler(this.cboTipoEntidadFinanciera_SelectedValueChanged);
            // 
            // labelX5
            // 
            this.labelX5.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Location = new System.Drawing.Point(15, 51);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(123, 23);
            this.labelX5.TabIndex = 46;
            this.labelX5.Text = "Tipo Entidad Financiera:";
            this.labelX5.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // ucLoadingBar1
            // 
            this.ucLoadingBar1.BackColor = System.Drawing.Color.Transparent;
            this.ucLoadingBar1.Location = new System.Drawing.Point(581, 501);
            this.ucLoadingBar1.Name = "ucLoadingBar1";
            this.ucLoadingBar1.Size = new System.Drawing.Size(167, 26);
            this.ucLoadingBar1.TabIndex = 10;
            // 
            // ucMsgBox1
            // 
            this.ucMsgBox1.Location = new System.Drawing.Point(13, 417);
            this.ucMsgBox1.Name = "ucMsgBox1";
            this.ucMsgBox1.Size = new System.Drawing.Size(10, 10);
            this.ucMsgBox1.TabIndex = 11;
            // 
            // txtIdRescisionInversion
            // 
            // 
            // 
            // 
            this.txtIdRescisionInversion.Border.Class = "TextBoxBorder";
            this.txtIdRescisionInversion.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtIdRescisionInversion.Location = new System.Drawing.Point(19, 420);
            this.txtIdRescisionInversion.MaxLength = 50;
            this.txtIdRescisionInversion.Name = "txtIdRescisionInversion";
            this.txtIdRescisionInversion.ReadOnly = true;
            this.txtIdRescisionInversion.Size = new System.Drawing.Size(18, 20);
            this.txtIdRescisionInversion.TabIndex = 57;
            this.txtIdRescisionInversion.Visible = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkRate = 0;
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // cboPlazo
            // 
            this.cboPlazo.DisplayMember = "Text";
            this.cboPlazo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboPlazo.Enabled = false;
            this.cboPlazo.FormattingEnabled = true;
            this.cboPlazo.ItemHeight = 14;
            this.cboPlazo.Location = new System.Drawing.Point(144, 117);
            this.cboPlazo.Name = "cboPlazo";
            this.cboPlazo.Size = new System.Drawing.Size(238, 20);
            this.cboPlazo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboPlazo.TabIndex = 52;
            // 
            // dtFechaVencimiento
            // 
            // 
            // 
            // 
            this.dtFechaVencimiento.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtFechaVencimiento.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtFechaVencimiento.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtFechaVencimiento.ButtonDropDown.Visible = true;
            this.dtFechaVencimiento.Enabled = false;
            this.dtFechaVencimiento.IsPopupCalendarOpen = false;
            this.dtFechaVencimiento.Location = new System.Drawing.Point(479, 74);
            // 
            // 
            // 
            this.dtFechaVencimiento.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtFechaVencimiento.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtFechaVencimiento.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dtFechaVencimiento.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtFechaVencimiento.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtFechaVencimiento.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtFechaVencimiento.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtFechaVencimiento.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtFechaVencimiento.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtFechaVencimiento.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtFechaVencimiento.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtFechaVencimiento.MonthCalendar.DisplayMonth = new System.DateTime(2018, 8, 1, 0, 0, 0, 0);
            this.dtFechaVencimiento.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dtFechaVencimiento.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtFechaVencimiento.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtFechaVencimiento.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtFechaVencimiento.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtFechaVencimiento.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtFechaVencimiento.MonthCalendar.TodayButtonVisible = true;
            this.dtFechaVencimiento.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dtFechaVencimiento.Name = "dtFechaVencimiento";
            this.dtFechaVencimiento.Size = new System.Drawing.Size(238, 20);
            this.dtFechaVencimiento.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtFechaVencimiento.TabIndex = 48;
            this.dtFechaVencimiento.Tag = "Reqrired, Fecha";
            // 
            // labelX18
            // 
            this.labelX18.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX18.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX18.Location = new System.Drawing.Point(402, 71);
            this.labelX18.Name = "labelX18";
            this.labelX18.Size = new System.Drawing.Size(70, 23);
            this.labelX18.TabIndex = 51;
            this.labelX18.Text = "Fecha Vto:";
            this.labelX18.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // dtFechaInicio
            // 
            // 
            // 
            // 
            this.dtFechaInicio.BackgroundStyle.BorderBottomWidth = 1;
            this.dtFechaInicio.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtFechaInicio.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtFechaInicio.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtFechaInicio.ButtonDropDown.Visible = true;
            this.dtFechaInicio.Enabled = false;
            this.dtFechaInicio.IsPopupCalendarOpen = false;
            this.dtFechaInicio.Location = new System.Drawing.Point(144, 96);
            // 
            // 
            // 
            this.dtFechaInicio.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtFechaInicio.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtFechaInicio.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dtFechaInicio.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtFechaInicio.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtFechaInicio.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtFechaInicio.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtFechaInicio.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtFechaInicio.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtFechaInicio.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtFechaInicio.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtFechaInicio.MonthCalendar.DisplayMonth = new System.DateTime(2018, 8, 1, 0, 0, 0, 0);
            this.dtFechaInicio.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dtFechaInicio.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtFechaInicio.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtFechaInicio.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtFechaInicio.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtFechaInicio.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtFechaInicio.MonthCalendar.TodayButtonVisible = true;
            this.dtFechaInicio.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dtFechaInicio.Name = "dtFechaInicio";
            this.dtFechaInicio.Size = new System.Drawing.Size(238, 20);
            this.dtFechaInicio.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtFechaInicio.TabIndex = 47;
            this.dtFechaInicio.Tag = "Reqrired, Fecha";
            // 
            // labelX17
            // 
            this.labelX17.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX17.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX17.Location = new System.Drawing.Point(22, 94);
            this.labelX17.Name = "labelX17";
            this.labelX17.Size = new System.Drawing.Size(115, 23);
            this.labelX17.TabIndex = 50;
            this.labelX17.Text = "Fecha Inicio:";
            this.labelX17.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // labelX16
            // 
            this.labelX16.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX16.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX16.Location = new System.Drawing.Point(22, 115);
            this.labelX16.Name = "labelX16";
            this.labelX16.Size = new System.Drawing.Size(115, 23);
            this.labelX16.TabIndex = 49;
            this.labelX16.Text = "Plazo:";
            this.labelX16.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // txtNroCertificado
            // 
            // 
            // 
            // 
            this.txtNroCertificado.Border.Class = "TextBoxBorder";
            this.txtNroCertificado.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtNroCertificado.Enabled = false;
            this.txtNroCertificado.Location = new System.Drawing.Point(144, 12);
            this.txtNroCertificado.MaxLength = 15;
            this.txtNroCertificado.Name = "txtNroCertificado";
            this.txtNroCertificado.Size = new System.Drawing.Size(238, 20);
            this.txtNroCertificado.TabIndex = 53;
            this.txtNroCertificado.Tag = "Reqrired";
            // 
            // labelX25
            // 
            this.labelX25.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX25.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX25.Location = new System.Drawing.Point(14, 9);
            this.labelX25.Name = "labelX25";
            this.labelX25.Size = new System.Drawing.Size(122, 23);
            this.labelX25.TabIndex = 54;
            this.labelX25.Text = "Nro. Certificado:";
            this.labelX25.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // frmRescisionInversion
            // 
            this.ClientSize = new System.Drawing.Size(760, 533);
            this.DoubleBuffered = true;
            this.Name = "frmRescisionInversion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Rescisión de Inversión";
            this.Load += new System.EventHandler(this.frmRescisionInversion_Load);
            this.panelEx1.ResumeLayout(false);
            this.groupDetalle.ResumeLayout(false);
            this.panelEx2.ResumeLayout(false);
            this.groupPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtTasaCerrada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFechaRescision)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaVencimiento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaInicio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.TextBoxX txtImporteInversion;
        private DevComponents.DotNetBar.LabelX labelX8;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTasaInversion;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboMoneda;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboBanco;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboTipoInversion;
        private DevComponents.DotNetBar.LabelX labelX9;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel2;
        private DevComponents.DotNetBar.Controls.TextBoxX txtImporteRescision;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.TextBoxX txtObservacionesResicision;
        private DevComponents.DotNetBar.Controls.TextBoxX txtPlazoRescision;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTasaRescision;
        private DevComponents.DotNetBar.LabelX labelX14;
        private DevComponents.DotNetBar.LabelX labelX13;
        private DevComponents.DotNetBar.LabelX labelX11;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboTipoEntidadFinanciera;
        private DevComponents.DotNetBar.LabelX labelX5;
        private ControlsComponent.ucLoadingBar ucLoadingBar1;
        private ControlsComponent.ucMsgBox ucMsgBox1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtIdRescisionInversion;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTotalCobrar;
        private DevComponents.DotNetBar.LabelX labelX15;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboPlazo;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtFechaVencimiento;
        private DevComponents.DotNetBar.LabelX labelX18;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtFechaInicio;
        private DevComponents.DotNetBar.LabelX labelX17;
        private DevComponents.DotNetBar.LabelX labelX16;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtpFechaRescision;
        private DevComponents.DotNetBar.LabelX labelX19;
        private DevComponents.DotNetBar.Controls.TextBoxX txtITF;
        private DevComponents.DotNetBar.LabelX labelX12;
        private DevComponents.DotNetBar.Controls.TextBoxX txtNroCertificado;
        private DevComponents.DotNetBar.LabelX labelX25;
        private DevComponents.DotNetBar.Controls.TextBoxX txtInteresCerrado;
        private DevComponents.DotNetBar.LabelX labelX20;
        private DevComponents.DotNetBar.Controls.TextBoxX txtInteresRescision;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.TextBoxX txtDiferencia;
        private DevComponents.DotNetBar.LabelX labelX21;
        private DevComponents.DotNetBar.Controls.TextBoxX txtDiasTranscurridos;
        private DevComponents.DotNetBar.LabelX labelX22;
        private DevComponents.Editors.DoubleInput txtTasaCerrada;
    }
}