namespace EfideFactoringXML
{
    partial class frmImportarDocumento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmImportarDocumento));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.lblUsuario = new DevComponents.DotNetBar.LabelX();
            this.btnImportar = new DevComponents.DotNetBar.ButtonX();
            this.btnBuscarXML = new DevComponents.DotNetBar.ButtonX();
            this.txtCarpetaXML = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.groupPanel2 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.lblnroRegistros = new DevComponents.DotNetBar.LabelX();
            this.txtIdLinea_Dsc = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtFecha = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtIdMoneda_tt_Dsc = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX11 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.txtIdTipoLinea_tt_Dsc = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX13 = new DevComponents.DotNetBar.LabelX();
            this.labelX16 = new DevComponents.DotNetBar.LabelX();
            this.txtIdSocio_Dsc = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtIdSocio = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX10 = new DevComponents.DotNetBar.LabelX();
            this.dgvFEDetalle = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.IdPagadora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdPagadora_Dsc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RUC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdDocumento_Dsc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNumDoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdTipoConfirmacion_Dsc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nvNominal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdVencimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nvNegociable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdSocio_BeneficiarioRuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mensaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.grpDato.SuspendLayout();
            this.groupPanel1.SuspendLayout();
            this.groupPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFEDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // grpDato
            // 
            this.grpDato.Controls.Add(this.dgvFEDetalle);
            this.grpDato.Controls.Add(this.groupPanel2);
            this.grpDato.Controls.Add(this.groupPanel1);
            this.grpDato.Size = new System.Drawing.Size(1246, 491);
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
            this.btnCancelar.Location = new System.Drawing.Point(1165, 512);
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(1016, 512);
            this.btnAceptar.Size = new System.Drawing.Size(147, 30);
            this.btnAceptar.Text = "Enviar a Operaciones";
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // groupPanel1
            // 
            this.groupPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.lblUsuario);
            this.groupPanel1.Controls.Add(this.btnImportar);
            this.groupPanel1.Controls.Add(this.btnBuscarXML);
            this.groupPanel1.Controls.Add(this.txtCarpetaXML);
            this.groupPanel1.Controls.Add(this.labelX1);
            this.groupPanel1.Location = new System.Drawing.Point(5, 3);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(1230, 52);
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
            this.groupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
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
            this.groupPanel1.TabIndex = 0;
            // 
            // lblUsuario
            // 
            this.lblUsuario.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lblUsuario.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(911, 3);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(310, 23);
            this.lblUsuario.TabIndex = 24;
            this.lblUsuario.Text = "Usuario: ";
            this.lblUsuario.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // btnImportar
            // 
            this.btnImportar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnImportar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnImportar.Image = ((System.Drawing.Image)(resources.GetObject("btnImportar.Image")));
            this.btnImportar.Location = new System.Drawing.Point(461, 12);
            this.btnImportar.Name = "btnImportar";
            this.btnImportar.Size = new System.Drawing.Size(83, 24);
            this.btnImportar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnImportar.TabIndex = 23;
            this.btnImportar.Text = "&Importar";
            this.btnImportar.Click += new System.EventHandler(this.btnImportar_Click);
            // 
            // btnBuscarXML
            // 
            this.btnBuscarXML.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnBuscarXML.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnBuscarXML.ImageFixedSize = new System.Drawing.Size(18, 18);
            this.btnBuscarXML.Location = new System.Drawing.Point(372, 12);
            this.btnBuscarXML.Name = "btnBuscarXML";
            this.btnBuscarXML.Size = new System.Drawing.Size(83, 23);
            this.btnBuscarXML.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnBuscarXML.TabIndex = 22;
            this.btnBuscarXML.Text = "Buscar XML";
            this.btnBuscarXML.Click += new System.EventHandler(this.btnBuscarXML_Click);
            // 
            // txtCarpetaXML
            // 
            // 
            // 
            // 
            this.txtCarpetaXML.Border.Class = "TextBoxBorder";
            this.txtCarpetaXML.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtCarpetaXML.Location = new System.Drawing.Point(122, 12);
            this.txtCarpetaXML.Name = "txtCarpetaXML";
            this.txtCarpetaXML.Size = new System.Drawing.Size(244, 20);
            this.txtCarpetaXML.TabIndex = 16;
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(19, 12);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(87, 23);
            this.labelX1.TabIndex = 8;
            this.labelX1.Text = "Nombre Carpeta";
            this.labelX1.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // groupPanel2
            // 
            this.groupPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupPanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel2.Controls.Add(this.lblnroRegistros);
            this.groupPanel2.Controls.Add(this.txtIdLinea_Dsc);
            this.groupPanel2.Controls.Add(this.txtFecha);
            this.groupPanel2.Controls.Add(this.txtIdMoneda_tt_Dsc);
            this.groupPanel2.Controls.Add(this.labelX11);
            this.groupPanel2.Controls.Add(this.labelX2);
            this.groupPanel2.Controls.Add(this.txtIdTipoLinea_tt_Dsc);
            this.groupPanel2.Controls.Add(this.labelX13);
            this.groupPanel2.Controls.Add(this.labelX16);
            this.groupPanel2.Controls.Add(this.txtIdSocio_Dsc);
            this.groupPanel2.Controls.Add(this.txtIdSocio);
            this.groupPanel2.Controls.Add(this.labelX10);
            this.groupPanel2.Location = new System.Drawing.Point(5, 57);
            this.groupPanel2.Name = "groupPanel2";
            this.groupPanel2.Size = new System.Drawing.Size(1230, 78);
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
            this.groupPanel2.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
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
            this.groupPanel2.TabIndex = 1;
            // 
            // lblnroRegistros
            // 
            this.lblnroRegistros.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lblnroRegistros.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblnroRegistros.Location = new System.Drawing.Point(1039, 46);
            this.lblnroRegistros.Name = "lblnroRegistros";
            this.lblnroRegistros.Size = new System.Drawing.Size(182, 23);
            this.lblnroRegistros.TabIndex = 18;
            this.lblnroRegistros.Text = "0 registro(s)";
            this.lblnroRegistros.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // txtIdLinea_Dsc
            // 
            // 
            // 
            // 
            this.txtIdLinea_Dsc.Border.Class = "TextBoxBorder";
            this.txtIdLinea_Dsc.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtIdLinea_Dsc.Location = new System.Drawing.Point(533, 7);
            this.txtIdLinea_Dsc.Name = "txtIdLinea_Dsc";
            this.txtIdLinea_Dsc.ReadOnly = true;
            this.txtIdLinea_Dsc.Size = new System.Drawing.Size(196, 20);
            this.txtIdLinea_Dsc.TabIndex = 17;
            // 
            // txtFecha
            // 
            // 
            // 
            // 
            this.txtFecha.Border.Class = "TextBoxBorder";
            this.txtFecha.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtFecha.Location = new System.Drawing.Point(326, 30);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.ReadOnly = true;
            this.txtFecha.Size = new System.Drawing.Size(105, 20);
            this.txtFecha.TabIndex = 16;
            // 
            // txtIdMoneda_tt_Dsc
            // 
            // 
            // 
            // 
            this.txtIdMoneda_tt_Dsc.Border.Class = "TextBoxBorder";
            this.txtIdMoneda_tt_Dsc.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtIdMoneda_tt_Dsc.Location = new System.Drawing.Point(66, 30);
            this.txtIdMoneda_tt_Dsc.Name = "txtIdMoneda_tt_Dsc";
            this.txtIdMoneda_tt_Dsc.ReadOnly = true;
            this.txtIdMoneda_tt_Dsc.Size = new System.Drawing.Size(122, 20);
            this.txtIdMoneda_tt_Dsc.TabIndex = 15;
            // 
            // labelX11
            // 
            this.labelX11.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX11.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX11.Location = new System.Drawing.Point(5, 30);
            this.labelX11.Name = "labelX11";
            this.labelX11.Size = new System.Drawing.Size(43, 23);
            this.labelX11.TabIndex = 14;
            this.labelX11.Text = "Moneda";
            this.labelX11.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(456, 30);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(69, 23);
            this.labelX2.TabIndex = 12;
            this.labelX2.Text = "Tipo de Linea";
            // 
            // txtIdTipoLinea_tt_Dsc
            // 
            // 
            // 
            // 
            this.txtIdTipoLinea_tt_Dsc.Border.Class = "TextBoxBorder";
            this.txtIdTipoLinea_tt_Dsc.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtIdTipoLinea_tt_Dsc.Location = new System.Drawing.Point(533, 28);
            this.txtIdTipoLinea_tt_Dsc.Name = "txtIdTipoLinea_tt_Dsc";
            this.txtIdTipoLinea_tt_Dsc.ReadOnly = true;
            this.txtIdTipoLinea_tt_Dsc.Size = new System.Drawing.Size(196, 20);
            this.txtIdTipoLinea_tt_Dsc.TabIndex = 13;
            // 
            // labelX13
            // 
            this.labelX13.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX13.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX13.Location = new System.Drawing.Point(485, 7);
            this.labelX13.Name = "labelX13";
            this.labelX13.Size = new System.Drawing.Size(38, 23);
            this.labelX13.TabIndex = 10;
            this.labelX13.Text = "Linea";
            this.labelX13.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // labelX16
            // 
            this.labelX16.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX16.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX16.Location = new System.Drawing.Point(17, 7);
            this.labelX16.Name = "labelX16";
            this.labelX16.Size = new System.Drawing.Size(31, 23);
            this.labelX16.TabIndex = 7;
            this.labelX16.Text = "Socio";
            this.labelX16.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // txtIdSocio_Dsc
            // 
            // 
            // 
            // 
            this.txtIdSocio_Dsc.Border.Class = "TextBoxBorder";
            this.txtIdSocio_Dsc.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtIdSocio_Dsc.Location = new System.Drawing.Point(189, 8);
            this.txtIdSocio_Dsc.Name = "txtIdSocio_Dsc";
            this.txtIdSocio_Dsc.ReadOnly = true;
            this.txtIdSocio_Dsc.Size = new System.Drawing.Size(242, 20);
            this.txtIdSocio_Dsc.TabIndex = 9;
            this.txtIdSocio_Dsc.TabStop = false;
            // 
            // txtIdSocio
            // 
            // 
            // 
            // 
            this.txtIdSocio.Border.Class = "TextBoxBorder";
            this.txtIdSocio.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtIdSocio.Location = new System.Drawing.Point(66, 8);
            this.txtIdSocio.Name = "txtIdSocio";
            this.txtIdSocio.ReadOnly = true;
            this.txtIdSocio.Size = new System.Drawing.Size(122, 20);
            this.txtIdSocio.TabIndex = 8;
            this.txtIdSocio.TabStop = false;
            // 
            // labelX10
            // 
            this.labelX10.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX10.Location = new System.Drawing.Point(228, 28);
            this.labelX10.Name = "labelX10";
            this.labelX10.Size = new System.Drawing.Size(92, 23);
            this.labelX10.TabIndex = 3;
            this.labelX10.Text = "Fecha Recepción";
            // 
            // dgvFEDetalle
            // 
            this.dgvFEDetalle.AllowUserToAddRows = false;
            this.dgvFEDetalle.AllowUserToDeleteRows = false;
            this.dgvFEDetalle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvFEDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFEDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdPagadora,
            this.IdPagadora_Dsc,
            this.RUC,
            this.IdDocumento,
            this.IdDocumento_Dsc,
            this.cNumDoc,
            this.IdTipoConfirmacion_Dsc,
            this.nvNominal,
            this.sdVencimiento,
            this.nvNegociable,
            this.IdSocio_BeneficiarioRuc,
            this.Mensaje});
            this.dgvFEDetalle.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFEDetalle.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvFEDetalle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvFEDetalle.Location = new System.Drawing.Point(5, 142);
            this.dgvFEDetalle.Name = "dgvFEDetalle";
            this.dgvFEDetalle.RowHeadersWidth = 10;
            this.dgvFEDetalle.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvFEDetalle.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvFEDetalle.SelectAllSignVisible = false;
            this.dgvFEDetalle.Size = new System.Drawing.Size(1230, 341);
            this.dgvFEDetalle.TabIndex = 3;
            this.dgvFEDetalle.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvFEDetalle_ColumnHeaderMouseClick);
            // 
            // IdPagadora
            // 
            this.IdPagadora.DataPropertyName = "IdPagadora";
            this.IdPagadora.HeaderText = "IdPagadora";
            this.IdPagadora.Name = "IdPagadora";
            this.IdPagadora.ReadOnly = true;
            this.IdPagadora.Visible = false;
            this.IdPagadora.Width = 87;
            // 
            // IdPagadora_Dsc
            // 
            this.IdPagadora_Dsc.DataPropertyName = "IdPagadora_Dsc";
            this.IdPagadora_Dsc.HeaderText = "Pagadora";
            this.IdPagadora_Dsc.Name = "IdPagadora_Dsc";
            this.IdPagadora_Dsc.ReadOnly = true;
            this.IdPagadora_Dsc.Width = 180;
            // 
            // RUC
            // 
            this.RUC.DataPropertyName = "RUC";
            this.RUC.HeaderText = "RUC";
            this.RUC.Name = "RUC";
            this.RUC.ReadOnly = true;
            // 
            // IdDocumento
            // 
            this.IdDocumento.DataPropertyName = "IdDocumento";
            this.IdDocumento.HeaderText = "IdDocumento";
            this.IdDocumento.Name = "IdDocumento";
            this.IdDocumento.ReadOnly = true;
            this.IdDocumento.Visible = false;
            this.IdDocumento.Width = 96;
            // 
            // IdDocumento_Dsc
            // 
            this.IdDocumento_Dsc.DataPropertyName = "IdDocumento_Dsc";
            this.IdDocumento_Dsc.HeaderText = "Doc.";
            this.IdDocumento_Dsc.Name = "IdDocumento_Dsc";
            this.IdDocumento_Dsc.ReadOnly = true;
            this.IdDocumento_Dsc.Width = 60;
            // 
            // cNumDoc
            // 
            this.cNumDoc.DataPropertyName = "cNumDoc";
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cNumDoc.DefaultCellStyle = dataGridViewCellStyle1;
            this.cNumDoc.HeaderText = "Nro. Documento";
            this.cNumDoc.Name = "cNumDoc";
            this.cNumDoc.Width = 80;
            // 
            // IdTipoConfirmacion_Dsc
            // 
            this.IdTipoConfirmacion_Dsc.DataPropertyName = "IdTipoConfirmacion_Dsc";
            this.IdTipoConfirmacion_Dsc.HeaderText = "Tipo Confirmación";
            this.IdTipoConfirmacion_Dsc.Name = "IdTipoConfirmacion_Dsc";
            this.IdTipoConfirmacion_Dsc.ReadOnly = true;
            this.IdTipoConfirmacion_Dsc.Width = 80;
            // 
            // nvNominal
            // 
            this.nvNominal.DataPropertyName = "nvNominal";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = "0";
            this.nvNominal.DefaultCellStyle = dataGridViewCellStyle2;
            this.nvNominal.HeaderText = "Valor Nominal";
            this.nvNominal.Name = "nvNominal";
            this.nvNominal.ReadOnly = true;
            this.nvNominal.Width = 120;
            // 
            // sdVencimiento
            // 
            this.sdVencimiento.DataPropertyName = "sdVencimiento";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.Format = "d";
            this.sdVencimiento.DefaultCellStyle = dataGridViewCellStyle3;
            this.sdVencimiento.HeaderText = "Fecha Vencimiento";
            this.sdVencimiento.Name = "sdVencimiento";
            this.sdVencimiento.Width = 75;
            // 
            // nvNegociable
            // 
            this.nvNegociable.DataPropertyName = "nvNegociable";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle4.Format = "N2";
            this.nvNegociable.DefaultCellStyle = dataGridViewCellStyle4;
            this.nvNegociable.HeaderText = "Importe Neto Pago";
            this.nvNegociable.Name = "nvNegociable";
            this.nvNegociable.Width = 120;
            // 
            // IdSocio_BeneficiarioRuc
            // 
            this.IdSocio_BeneficiarioRuc.DataPropertyName = "IdSocio_BeneficiarioRuc";
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.IdSocio_BeneficiarioRuc.DefaultCellStyle = dataGridViewCellStyle5;
            this.IdSocio_BeneficiarioRuc.HeaderText = "Girador Original RUC";
            this.IdSocio_BeneficiarioRuc.Name = "IdSocio_BeneficiarioRuc";
            this.IdSocio_BeneficiarioRuc.Width = 120;
            // 
            // Mensaje
            // 
            this.Mensaje.DataPropertyName = "Mensaje";
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            this.Mensaje.DefaultCellStyle = dataGridViewCellStyle6;
            this.Mensaje.HeaderText = "Mensaje";
            this.Mensaje.Name = "Mensaje";
            this.Mensaje.ReadOnly = true;
            this.Mensaje.Width = 250;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmImportarDocumento
            // 
            this.ClientSize = new System.Drawing.Size(1254, 548);
            this.DoubleBuffered = true;
            this.Name = "frmImportarDocumento";
            this.Text = "Importar Documentos";
            this.Load += new System.EventHandler(this.frmImportarDocumento_Load);
            this.grpDato.ResumeLayout(false);
            this.groupPanel1.ResumeLayout(false);
            this.groupPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFEDetalle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel2;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.LabelX labelX10;
        private DevComponents.DotNetBar.LabelX labelX16;
        private DevComponents.DotNetBar.Controls.TextBoxX txtIdSocio_Dsc;
        private DevComponents.DotNetBar.Controls.TextBoxX txtIdSocio;
        private DevComponents.DotNetBar.LabelX labelX13;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.TextBoxX txtIdTipoLinea_tt_Dsc;
        private DevComponents.DotNetBar.LabelX labelX11;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvFEDetalle;
        private DevComponents.DotNetBar.Controls.TextBoxX txtIdLinea_Dsc;
        private DevComponents.DotNetBar.Controls.TextBoxX txtFecha;
        private DevComponents.DotNetBar.Controls.TextBoxX txtIdMoneda_tt_Dsc;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtCarpetaXML;
        private DevComponents.DotNetBar.ButtonX btnBuscarXML;
        private DevComponents.DotNetBar.ButtonX btnImportar;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private DevComponents.DotNetBar.LabelX lblUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdPagadora;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdPagadora_Dsc;
        private System.Windows.Forms.DataGridViewTextBoxColumn RUC;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdDocumento_Dsc;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNumDoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdTipoConfirmacion_Dsc;
        private System.Windows.Forms.DataGridViewTextBoxColumn nvNominal;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdVencimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn nvNegociable;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdSocio_BeneficiarioRuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mensaje;
        private DevComponents.DotNetBar.LabelX lblnroRegistros;
    }
}