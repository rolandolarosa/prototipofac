namespace Efide.Tesoreria.WinAdeudosInversiones.inversion
{
    partial class frmConfirmacionRescision
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConfirmacionRescision));
            this.ucLoadingBar1 = new Efide.ControlsComponent.ucLoadingBar();
            this.ucMsgBox1 = new Efide.ControlsComponent.ucMsgBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtTotalCobrar = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX15 = new DevComponents.DotNetBar.LabelX();
            this.txtTasaCerrada = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.txtInteresRescision = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX11 = new DevComponents.DotNetBar.LabelX();
            this.txtImporteRescision = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX12 = new DevComponents.DotNetBar.LabelX();
            this.txtObservacionesResicision = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtPlazoRescision = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtTasaRescision = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX14 = new DevComponents.DotNetBar.LabelX();
            this.labelX13 = new DevComponents.DotNetBar.LabelX();
            this.labelX16 = new DevComponents.DotNetBar.LabelX();
            this.txtInteresCerrado = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.txtDiasTranscurridos = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.txtItf = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.dgvDepositos2 = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.CheckSel = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.socioBancoID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pagar_personaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soc_razonSocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soc_tipoPersona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoOperacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sbFechaOperacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorTipoMpagoID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoMpago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorMonedaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ent_emprRazonSocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ctasBancariaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorMonedaID_Dsc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sbImporte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Saldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sbGlosa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ctasBanNumCta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdOperacion_tt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdOperacion_tt_Dsc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdTipoAbono_tt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdTipoAbono_tt_Dsc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn();
            this.panelEx1.SuspendLayout();
            this.groupDetalle.SuspendLayout();
            this.panelEx2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepositos2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBusqueda
            // 
            // 
            // 
            // 
            this.txtBusqueda.Border.Class = "TextBoxBorder";
            this.txtBusqueda.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtBusqueda.Location = new System.Drawing.Point(139, 15);
            this.txtBusqueda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBusqueda_KeyPress);
            // 
            // labelX10
            // 
            // 
            // 
            // 
            this.labelX10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX10.Location = new System.Drawing.Point(26, 15);
            this.labelX10.Text = "Código de Rescisión:";
            this.labelX10.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(380, 9);
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnDetalle
            // 
            this.btnDetalle.Location = new System.Drawing.Point(436, 9);
            this.btnDetalle.Click += new System.EventHandler(this.btnDetalle_Click);
            // 
            // panelEx1
            // 
            this.panelEx1.Location = new System.Drawing.Point(12, 53);
            this.panelEx1.Size = new System.Drawing.Size(832, 50);
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
            this.ribbonBar1.Size = new System.Drawing.Size(856, 39);
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
            this.btnSelTransDepo.Location = new System.Drawing.Point(12, 285);
            this.btnSelTransDepo.Size = new System.Drawing.Size(148, 23);
            this.btnSelTransDepo.Text = "Seleccionar Depósitos";
            this.btnSelTransDepo.Click += new System.EventHandler(this.btnSelTransDepo_Click);
            // 
            // groupDetalle
            // 
            this.groupDetalle.Controls.Add(this.txtItf);
            this.groupDetalle.Controls.Add(this.labelX3);
            this.groupDetalle.Controls.Add(this.txtDiasTranscurridos);
            this.groupDetalle.Controls.Add(this.labelX2);
            this.groupDetalle.Controls.Add(this.txtInteresCerrado);
            this.groupDetalle.Controls.Add(this.labelX1);
            this.groupDetalle.Controls.Add(this.txtTotalCobrar);
            this.groupDetalle.Controls.Add(this.labelX15);
            this.groupDetalle.Controls.Add(this.txtTasaCerrada);
            this.groupDetalle.Controls.Add(this.labelX4);
            this.groupDetalle.Controls.Add(this.txtInteresRescision);
            this.groupDetalle.Controls.Add(this.labelX11);
            this.groupDetalle.Controls.Add(this.txtImporteRescision);
            this.groupDetalle.Controls.Add(this.labelX12);
            this.groupDetalle.Controls.Add(this.txtObservacionesResicision);
            this.groupDetalle.Controls.Add(this.txtPlazoRescision);
            this.groupDetalle.Controls.Add(this.txtTasaRescision);
            this.groupDetalle.Controls.Add(this.labelX14);
            this.groupDetalle.Controls.Add(this.labelX13);
            this.groupDetalle.Controls.Add(this.labelX16);
            this.groupDetalle.Location = new System.Drawing.Point(12, 112);
            this.groupDetalle.Size = new System.Drawing.Size(832, 163);
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
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // panelEx2
            // 
            this.panelEx2.Controls.Add(this.dgvDepositos2);
            this.panelEx2.Controls.Add(this.ucMsgBox1);
            this.panelEx2.Controls.Add(this.ucLoadingBar1);
            this.panelEx2.Size = new System.Drawing.Size(856, 569);
            this.panelEx2.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx2.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx2.Style.GradientAngle = 90;
            // 
            // ucLoadingBar1
            // 
            this.ucLoadingBar1.BackColor = System.Drawing.Color.Transparent;
            this.ucLoadingBar1.Location = new System.Drawing.Point(677, 538);
            this.ucLoadingBar1.Name = "ucLoadingBar1";
            this.ucLoadingBar1.Size = new System.Drawing.Size(167, 26);
            this.ucLoadingBar1.TabIndex = 43;
            // 
            // ucMsgBox1
            // 
            this.ucMsgBox1.Location = new System.Drawing.Point(12, 472);
            this.ucMsgBox1.Name = "ucMsgBox1";
            this.ucMsgBox1.Size = new System.Drawing.Size(10, 10);
            this.ucMsgBox1.TabIndex = 44;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // txtTotalCobrar
            // 
            // 
            // 
            // 
            this.txtTotalCobrar.Border.Class = "TextBoxBorder";
            this.txtTotalCobrar.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTotalCobrar.Enabled = false;
            this.txtTotalCobrar.Location = new System.Drawing.Point(142, 119);
            this.txtTotalCobrar.MaxLength = 14;
            this.txtTotalCobrar.Name = "txtTotalCobrar";
            this.txtTotalCobrar.Size = new System.Drawing.Size(238, 20);
            this.txtTotalCobrar.TabIndex = 75;
            // 
            // labelX15
            // 
            this.labelX15.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX15.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX15.Location = new System.Drawing.Point(37, 117);
            this.labelX15.Name = "labelX15";
            this.labelX15.Size = new System.Drawing.Size(99, 23);
            this.labelX15.TabIndex = 76;
            this.labelX15.Text = "Total por cobrar:";
            this.labelX15.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // txtTasaCerrada
            // 
            // 
            // 
            // 
            this.txtTasaCerrada.Border.Class = "TextBoxBorder";
            this.txtTasaCerrada.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTasaCerrada.Enabled = false;
            this.txtTasaCerrada.Location = new System.Drawing.Point(554, 14);
            this.txtTasaCerrada.MaxLength = 10;
            this.txtTasaCerrada.Name = "txtTasaCerrada";
            this.txtTasaCerrada.Size = new System.Drawing.Size(238, 20);
            this.txtTasaCerrada.TabIndex = 67;
            this.txtTasaCerrada.Tag = "Reqrired, Decimales";
            // 
            // labelX4
            // 
            this.labelX4.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(464, 12);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(83, 23);
            this.labelX4.TabIndex = 74;
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
            this.txtInteresRescision.Location = new System.Drawing.Point(142, 77);
            this.txtInteresRescision.MaxLength = 14;
            this.txtInteresRescision.Name = "txtInteresRescision";
            this.txtInteresRescision.Size = new System.Drawing.Size(238, 20);
            this.txtInteresRescision.TabIndex = 66;
            // 
            // labelX11
            // 
            this.labelX11.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX11.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX11.Location = new System.Drawing.Point(37, 75);
            this.labelX11.Name = "labelX11";
            this.labelX11.Size = new System.Drawing.Size(99, 23);
            this.labelX11.TabIndex = 73;
            this.labelX11.Text = "Interés por cobrar:";
            this.labelX11.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // txtImporteRescision
            // 
            // 
            // 
            // 
            this.txtImporteRescision.Border.Class = "TextBoxBorder";
            this.txtImporteRescision.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtImporteRescision.Enabled = false;
            this.txtImporteRescision.Location = new System.Drawing.Point(142, 56);
            this.txtImporteRescision.MaxLength = 14;
            this.txtImporteRescision.Name = "txtImporteRescision";
            this.txtImporteRescision.Size = new System.Drawing.Size(238, 20);
            this.txtImporteRescision.TabIndex = 65;
            this.txtImporteRescision.Tag = "Reqrired";
            // 
            // labelX12
            // 
            this.labelX12.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX12.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX12.Location = new System.Drawing.Point(37, 54);
            this.labelX12.Name = "labelX12";
            this.labelX12.Size = new System.Drawing.Size(99, 23);
            this.labelX12.TabIndex = 72;
            this.labelX12.Text = "Importe:";
            this.labelX12.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // txtObservacionesResicision
            // 
            // 
            // 
            // 
            this.txtObservacionesResicision.Border.Class = "TextBoxBorder";
            this.txtObservacionesResicision.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtObservacionesResicision.Enabled = false;
            this.txtObservacionesResicision.Location = new System.Drawing.Point(554, 99);
            this.txtObservacionesResicision.MaxLength = 250;
            this.txtObservacionesResicision.Multiline = true;
            this.txtObservacionesResicision.Name = "txtObservacionesResicision";
            this.txtObservacionesResicision.Size = new System.Drawing.Size(238, 40);
            this.txtObservacionesResicision.TabIndex = 68;
            // 
            // txtPlazoRescision
            // 
            // 
            // 
            // 
            this.txtPlazoRescision.Border.Class = "TextBoxBorder";
            this.txtPlazoRescision.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtPlazoRescision.Enabled = false;
            this.txtPlazoRescision.Location = new System.Drawing.Point(142, 35);
            this.txtPlazoRescision.MaxLength = 10;
            this.txtPlazoRescision.Name = "txtPlazoRescision";
            this.txtPlazoRescision.Size = new System.Drawing.Size(238, 20);
            this.txtPlazoRescision.TabIndex = 64;
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
            this.txtTasaRescision.Location = new System.Drawing.Point(142, 14);
            this.txtTasaRescision.MaxLength = 10;
            this.txtTasaRescision.Name = "txtTasaRescision";
            this.txtTasaRescision.Size = new System.Drawing.Size(238, 20);
            this.txtTasaRescision.TabIndex = 63;
            this.txtTasaRescision.Tag = "Reqrired, Decimales";
            // 
            // labelX14
            // 
            this.labelX14.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX14.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX14.Location = new System.Drawing.Point(464, 96);
            this.labelX14.Name = "labelX14";
            this.labelX14.Size = new System.Drawing.Size(83, 23);
            this.labelX14.TabIndex = 71;
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
            this.labelX13.Location = new System.Drawing.Point(35, 32);
            this.labelX13.Name = "labelX13";
            this.labelX13.Size = new System.Drawing.Size(101, 23);
            this.labelX13.TabIndex = 70;
            this.labelX13.Text = "Plazo de Rescisión:";
            this.labelX13.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // labelX16
            // 
            this.labelX16.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX16.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX16.Location = new System.Drawing.Point(35, 11);
            this.labelX16.Name = "labelX16";
            this.labelX16.Size = new System.Drawing.Size(101, 23);
            this.labelX16.TabIndex = 69;
            this.labelX16.Text = "Tasa de Rescisión:";
            this.labelX16.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // txtInteresCerrado
            // 
            // 
            // 
            // 
            this.txtInteresCerrado.Border.Class = "TextBoxBorder";
            this.txtInteresCerrado.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtInteresCerrado.Enabled = false;
            this.txtInteresCerrado.Location = new System.Drawing.Point(554, 78);
            this.txtInteresCerrado.MaxLength = 10;
            this.txtInteresCerrado.Name = "txtInteresCerrado";
            this.txtInteresCerrado.Size = new System.Drawing.Size(238, 20);
            this.txtInteresCerrado.TabIndex = 77;
            this.txtInteresCerrado.Tag = "";
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(464, 76);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(83, 23);
            this.labelX1.TabIndex = 78;
            this.labelX1.Text = "Interés Cerrado:";
            this.labelX1.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // txtDiasTranscurridos
            // 
            // 
            // 
            // 
            this.txtDiasTranscurridos.Border.Class = "TextBoxBorder";
            this.txtDiasTranscurridos.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtDiasTranscurridos.Enabled = false;
            this.txtDiasTranscurridos.Location = new System.Drawing.Point(554, 35);
            this.txtDiasTranscurridos.MaxLength = 10;
            this.txtDiasTranscurridos.Name = "txtDiasTranscurridos";
            this.txtDiasTranscurridos.Size = new System.Drawing.Size(238, 20);
            this.txtDiasTranscurridos.TabIndex = 79;
            this.txtDiasTranscurridos.Tag = "Reqrired, Decimales";
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(443, 33);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(104, 23);
            this.labelX2.TabIndex = 80;
            this.labelX2.Text = "Días transcurridos:";
            this.labelX2.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // txtItf
            // 
            // 
            // 
            // 
            this.txtItf.Border.Class = "TextBoxBorder";
            this.txtItf.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtItf.Enabled = false;
            this.txtItf.Location = new System.Drawing.Point(142, 98);
            this.txtItf.MaxLength = 14;
            this.txtItf.Name = "txtItf";
            this.txtItf.Size = new System.Drawing.Size(238, 20);
            this.txtItf.TabIndex = 81;
            // 
            // labelX3
            // 
            this.labelX3.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(37, 96);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(99, 23);
            this.labelX3.TabIndex = 82;
            this.labelX3.Text = "ITF:";
            this.labelX3.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // dgvDepositos2
            // 
            this.dgvDepositos2.AllowUserToAddRows = false;
            this.dgvDepositos2.AllowUserToDeleteRows = false;
            this.dgvDepositos2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDepositos2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDepositos2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CheckSel,
            this.socioBancoID,
            this.pagar_personaID,
            this.soc_razonSocial,
            this.soc_tipoPersona,
            this.tipoOperacion,
            this.sbFechaOperacion,
            this.valorTipoMpagoID,
            this.TipoMpago,
            this.valorMonedaID,
            this.ent_emprRazonSocial,
            this.ctasBancariaID,
            this.valorMonedaID_Dsc,
            this.sbImporte,
            this.Saldo,
            this.sbGlosa,
            this.ctasBanNumCta,
            this.IdOperacion_tt,
            this.IdOperacion_tt_Dsc,
            this.IdTipoAbono_tt,
            this.IdTipoAbono_tt_Dsc,
            this.Column4});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDepositos2.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDepositos2.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvDepositos2.Location = new System.Drawing.Point(12, 314);
            this.dgvDepositos2.Name = "dgvDepositos2";
            this.dgvDepositos2.ReadOnly = true;
            this.dgvDepositos2.RowHeadersVisible = false;
            this.dgvDepositos2.Size = new System.Drawing.Size(834, 217);
            this.dgvDepositos2.TabIndex = 45;
            this.dgvDepositos2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDepositos2_CellClick);
            // 
            // CheckSel
            // 
            this.CheckSel.DataPropertyName = "CheckSel";
            this.CheckSel.Frozen = true;
            this.CheckSel.HeaderText = "";
            this.CheckSel.Name = "CheckSel";
            this.CheckSel.ReadOnly = true;
            this.CheckSel.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CheckSel.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.CheckSel.Visible = false;
            this.CheckSel.Width = 20;
            // 
            // socioBancoID
            // 
            this.socioBancoID.DataPropertyName = "socioBancoID";
            this.socioBancoID.HeaderText = "socioBancoID";
            this.socioBancoID.Name = "socioBancoID";
            this.socioBancoID.ReadOnly = true;
            this.socioBancoID.Visible = false;
            // 
            // pagar_personaID
            // 
            this.pagar_personaID.DataPropertyName = "pagar_personaID";
            this.pagar_personaID.HeaderText = "pagar_personaID";
            this.pagar_personaID.Name = "pagar_personaID";
            this.pagar_personaID.ReadOnly = true;
            this.pagar_personaID.Visible = false;
            // 
            // soc_razonSocial
            // 
            this.soc_razonSocial.DataPropertyName = "soc_razonSocial";
            this.soc_razonSocial.HeaderText = "Socio";
            this.soc_razonSocial.Name = "soc_razonSocial";
            this.soc_razonSocial.ReadOnly = true;
            this.soc_razonSocial.Visible = false;
            this.soc_razonSocial.Width = 150;
            // 
            // soc_tipoPersona
            // 
            this.soc_tipoPersona.DataPropertyName = "soc_tipoPersona";
            this.soc_tipoPersona.HeaderText = "Tipo Persona";
            this.soc_tipoPersona.Name = "soc_tipoPersona";
            this.soc_tipoPersona.ReadOnly = true;
            this.soc_tipoPersona.Visible = false;
            // 
            // tipoOperacion
            // 
            this.tipoOperacion.DataPropertyName = "tipoOperacion";
            this.tipoOperacion.Frozen = true;
            this.tipoOperacion.HeaderText = "Tipo Operacion";
            this.tipoOperacion.Name = "tipoOperacion";
            this.tipoOperacion.ReadOnly = true;
            // 
            // sbFechaOperacion
            // 
            this.sbFechaOperacion.DataPropertyName = "sbFechaOperacion";
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.sbFechaOperacion.DefaultCellStyle = dataGridViewCellStyle1;
            this.sbFechaOperacion.Frozen = true;
            this.sbFechaOperacion.HeaderText = "Fecha Operacion";
            this.sbFechaOperacion.Name = "sbFechaOperacion";
            this.sbFechaOperacion.ReadOnly = true;
            // 
            // valorTipoMpagoID
            // 
            this.valorTipoMpagoID.DataPropertyName = "valorTipoMpagoID";
            this.valorTipoMpagoID.HeaderText = "valorTipoMpagoID";
            this.valorTipoMpagoID.Name = "valorTipoMpagoID";
            this.valorTipoMpagoID.ReadOnly = true;
            this.valorTipoMpagoID.Visible = false;
            // 
            // TipoMpago
            // 
            this.TipoMpago.DataPropertyName = "TipoMpago";
            this.TipoMpago.HeaderText = "Tipo de Abono";
            this.TipoMpago.Name = "TipoMpago";
            this.TipoMpago.ReadOnly = true;
            this.TipoMpago.Visible = false;
            // 
            // valorMonedaID
            // 
            this.valorMonedaID.DataPropertyName = "valorMonedaID";
            this.valorMonedaID.HeaderText = "valorMonedaID";
            this.valorMonedaID.Name = "valorMonedaID";
            this.valorMonedaID.ReadOnly = true;
            this.valorMonedaID.Visible = false;
            // 
            // ent_emprRazonSocial
            // 
            this.ent_emprRazonSocial.DataPropertyName = "ent_emprRazonSocial";
            this.ent_emprRazonSocial.HeaderText = "Banco";
            this.ent_emprRazonSocial.Name = "ent_emprRazonSocial";
            this.ent_emprRazonSocial.ReadOnly = true;
            // 
            // ctasBancariaID
            // 
            this.ctasBancariaID.DataPropertyName = "ctasBanNumCta";
            this.ctasBancariaID.HeaderText = "Cuenta Bancaria";
            this.ctasBancariaID.Name = "ctasBancariaID";
            this.ctasBancariaID.ReadOnly = true;
            // 
            // valorMonedaID_Dsc
            // 
            this.valorMonedaID_Dsc.DataPropertyName = "valorMonedaID_Dsc";
            this.valorMonedaID_Dsc.HeaderText = "Moneda";
            this.valorMonedaID_Dsc.Name = "valorMonedaID_Dsc";
            this.valorMonedaID_Dsc.ReadOnly = true;
            this.valorMonedaID_Dsc.Width = 60;
            // 
            // sbImporte
            // 
            this.sbImporte.DataPropertyName = "sbImporte";
            this.sbImporte.HeaderText = "Importe";
            this.sbImporte.Name = "sbImporte";
            this.sbImporte.ReadOnly = true;
            this.sbImporte.Width = 70;
            // 
            // Saldo
            // 
            this.Saldo.DataPropertyName = "Saldo";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = "0";
            this.Saldo.DefaultCellStyle = dataGridViewCellStyle2;
            this.Saldo.HeaderText = "Saldo";
            this.Saldo.Name = "Saldo";
            this.Saldo.ReadOnly = true;
            this.Saldo.Width = 70;
            // 
            // sbGlosa
            // 
            this.sbGlosa.DataPropertyName = "sbGlosa";
            this.sbGlosa.HeaderText = "Glosa";
            this.sbGlosa.Name = "sbGlosa";
            this.sbGlosa.ReadOnly = true;
            this.sbGlosa.Width = 185;
            // 
            // ctasBanNumCta
            // 
            this.ctasBanNumCta.DataPropertyName = "ctasBanNumCta";
            this.ctasBanNumCta.HeaderText = "ctasBanNumCta";
            this.ctasBanNumCta.Name = "ctasBanNumCta";
            this.ctasBanNumCta.ReadOnly = true;
            this.ctasBanNumCta.Visible = false;
            // 
            // IdOperacion_tt
            // 
            this.IdOperacion_tt.DataPropertyName = "IdOperacion_tt";
            this.IdOperacion_tt.HeaderText = "IdOperacion_tt";
            this.IdOperacion_tt.Name = "IdOperacion_tt";
            this.IdOperacion_tt.ReadOnly = true;
            this.IdOperacion_tt.Visible = false;
            // 
            // IdOperacion_tt_Dsc
            // 
            this.IdOperacion_tt_Dsc.DataPropertyName = "IdOperacion_tt_Dsc";
            this.IdOperacion_tt_Dsc.HeaderText = "IdOperacion_tt_Dsc";
            this.IdOperacion_tt_Dsc.Name = "IdOperacion_tt_Dsc";
            this.IdOperacion_tt_Dsc.ReadOnly = true;
            this.IdOperacion_tt_Dsc.Visible = false;
            // 
            // IdTipoAbono_tt
            // 
            this.IdTipoAbono_tt.DataPropertyName = "IdTipoAbono_tt";
            this.IdTipoAbono_tt.HeaderText = "IdTipoAbono_tt";
            this.IdTipoAbono_tt.Name = "IdTipoAbono_tt";
            this.IdTipoAbono_tt.ReadOnly = true;
            this.IdTipoAbono_tt.Visible = false;
            // 
            // IdTipoAbono_tt_Dsc
            // 
            this.IdTipoAbono_tt_Dsc.DataPropertyName = "IdTipoAbono_tt_Dsc";
            this.IdTipoAbono_tt_Dsc.HeaderText = "IdTipoAbono_tt_Dsc";
            this.IdTipoAbono_tt_Dsc.Name = "IdTipoAbono_tt_Dsc";
            this.IdTipoAbono_tt_Dsc.ReadOnly = true;
            this.IdTipoAbono_tt_Dsc.Visible = false;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Del";
            this.Column4.Image = ((System.Drawing.Image)(resources.GetObject("Column4.Image")));
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Text = null;
            this.Column4.Width = 30;
            // 
            // frmConfirmacionRescision
            // 
            this.ClientSize = new System.Drawing.Size(856, 569);
            this.DoubleBuffered = true;
            this.Name = "frmConfirmacionRescision";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Confirmación de Rescisión";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmConfirmacionRescision_Load);
            this.panelEx1.ResumeLayout(false);
            this.groupDetalle.ResumeLayout(false);
            this.panelEx2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepositos2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ControlsComponent.ucLoadingBar ucLoadingBar1;
        private ControlsComponent.ucMsgBox ucMsgBox1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTotalCobrar;
        private DevComponents.DotNetBar.LabelX labelX15;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTasaCerrada;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.Controls.TextBoxX txtInteresRescision;
        private DevComponents.DotNetBar.LabelX labelX11;
        private DevComponents.DotNetBar.Controls.TextBoxX txtImporteRescision;
        private DevComponents.DotNetBar.LabelX labelX12;
        private DevComponents.DotNetBar.Controls.TextBoxX txtObservacionesResicision;
        private DevComponents.DotNetBar.Controls.TextBoxX txtPlazoRescision;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTasaRescision;
        private DevComponents.DotNetBar.LabelX labelX14;
        private DevComponents.DotNetBar.LabelX labelX13;
        private DevComponents.DotNetBar.LabelX labelX16;
        private DevComponents.DotNetBar.Controls.TextBoxX txtDiasTranscurridos;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.TextBoxX txtInteresCerrado;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtItf;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvDepositos2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CheckSel;
        private System.Windows.Forms.DataGridViewTextBoxColumn socioBancoID;
        private System.Windows.Forms.DataGridViewTextBoxColumn pagar_personaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn soc_razonSocial;
        private System.Windows.Forms.DataGridViewTextBoxColumn soc_tipoPersona;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoOperacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn sbFechaOperacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorTipoMpagoID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoMpago;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorMonedaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ent_emprRazonSocial;
        private System.Windows.Forms.DataGridViewTextBoxColumn ctasBancariaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorMonedaID_Dsc;
        private System.Windows.Forms.DataGridViewTextBoxColumn sbImporte;
        private System.Windows.Forms.DataGridViewTextBoxColumn Saldo;
        private System.Windows.Forms.DataGridViewTextBoxColumn sbGlosa;
        private System.Windows.Forms.DataGridViewTextBoxColumn ctasBanNumCta;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdOperacion_tt;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdOperacion_tt_Dsc;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdTipoAbono_tt;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdTipoAbono_tt_Dsc;
        private DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn Column4;
    }
}