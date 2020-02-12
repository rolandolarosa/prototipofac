namespace EfideFactoring.Formula.GestionComercial
{
    partial class frmRpt_Tuberia
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PanelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.lblTitulo = new DevComponents.DotNetBar.LabelX();
            this.panelEx2 = new DevComponents.DotNetBar.PanelEx();
            this.cboEjecutivo = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem1 = new DevComponents.Editors.ComboItem();
            this.lblRegistros = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.btnLimpiar = new DevComponents.DotNetBar.ButtonX();
            this.btnBuscar = new DevComponents.DotNetBar.ButtonX();
            this.txtTotal = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.dgvTuberia = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.Ejecutivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.razonSocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vcPagadora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdMoneda_tt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdMoneda_tt_Dsc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdFechaFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Doc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Legal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Riesgos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Operac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comerc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Observacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoCambio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpDato.SuspendLayout();
            this.PanelEx1.SuspendLayout();
            this.panelEx2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTuberia)).BeginInit();
            this.SuspendLayout();
            // 
            // grpDato
            // 
            this.grpDato.Controls.Add(this.dgvTuberia);
            this.grpDato.Controls.Add(this.panelEx2);
            this.grpDato.Controls.Add(this.PanelEx1);
            this.grpDato.Size = new System.Drawing.Size(1314, 551);
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
            this.btnCancelar.Location = new System.Drawing.Point(1233, 572);
            this.btnCancelar.Text = "Cerrar";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(1142, 572);
            this.btnAceptar.Visible = false;
            // 
            // PanelEx1
            // 
            this.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2010;
            this.PanelEx1.Controls.Add(this.lblTitulo);
            this.PanelEx1.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelEx1.Location = new System.Drawing.Point(0, 0);
            this.PanelEx1.Name = "PanelEx1";
            this.PanelEx1.Size = new System.Drawing.Size(1308, 33);
            this.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.PanelEx1.Style.GradientAngle = 90;
            this.PanelEx1.TabIndex = 55;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.lblTitulo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTitulo.Location = new System.Drawing.Point(46, 6);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(1178, 23);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "REPORTE DE TUBERIA DE MANTENIMIENTO / RECUPERADOS";
            this.lblTitulo.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // panelEx2
            // 
            this.panelEx2.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2010;
            this.panelEx2.Controls.Add(this.cboEjecutivo);
            this.panelEx2.Controls.Add(this.lblRegistros);
            this.panelEx2.Controls.Add(this.labelX5);
            this.panelEx2.Controls.Add(this.btnLimpiar);
            this.panelEx2.Controls.Add(this.btnBuscar);
            this.panelEx2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEx2.Location = new System.Drawing.Point(0, 33);
            this.panelEx2.Name = "panelEx2";
            this.panelEx2.Size = new System.Drawing.Size(1308, 51);
            this.panelEx2.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx2.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx2.Style.GradientAngle = 90;
            this.panelEx2.TabIndex = 57;
            // 
            // cboEjecutivo
            // 
            this.cboEjecutivo.DisplayMember = "Text";
            this.cboEjecutivo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboEjecutivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEjecutivo.FormattingEnabled = true;
            this.cboEjecutivo.ItemHeight = 14;
            this.cboEjecutivo.Items.AddRange(new object[] {
            this.comboItem1});
            this.cboEjecutivo.Location = new System.Drawing.Point(90, 15);
            this.cboEjecutivo.Name = "cboEjecutivo";
            this.cboEjecutivo.Size = new System.Drawing.Size(162, 20);
            this.cboEjecutivo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboEjecutivo.TabIndex = 57;
            // 
            // comboItem1
            // 
            this.comboItem1.Text = "<< Todos >>";
            // 
            // lblRegistros
            // 
            this.lblRegistros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.lblRegistros.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblRegistros.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblRegistros.Location = new System.Drawing.Point(1129, 29);
            this.lblRegistros.Name = "lblRegistros";
            this.lblRegistros.Size = new System.Drawing.Size(176, 17);
            this.lblRegistros.TabIndex = 56;
            this.lblRegistros.Text = "0  registro(s)";
            this.lblRegistros.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // labelX5
            // 
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelX5.Location = new System.Drawing.Point(16, 15);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(68, 20);
            this.labelX5.TabIndex = 8;
            this.labelX5.Text = "Ejecutivo";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnLimpiar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnLimpiar.Image = global::EfideFactoring.Properties.Resources.magifier_zoom_out;
            this.btnLimpiar.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnLimpiar.Location = new System.Drawing.Point(751, 5);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(73, 41);
            this.btnLimpiar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnLimpiar.TabIndex = 6;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnBuscar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnBuscar.Image = global::EfideFactoring.Properties.Resources.buscar;
            this.btnBuscar.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnBuscar.Location = new System.Drawing.Point(672, 5);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(73, 41);
            this.btnBuscar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtTotal
            // 
            // 
            // 
            // 
            this.txtTotal.Border.Class = "TextBoxBorder";
            this.txtTotal.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTotal.Location = new System.Drawing.Point(465, 572);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(99, 20);
            this.txtTotal.TabIndex = 59;
            this.txtTotal.Text = "0.00";
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelX1.Location = new System.Drawing.Point(327, 570);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(131, 23);
            this.labelX1.TabIndex = 58;
            this.labelX1.Text = "Total en S/";
            this.labelX1.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // dgvTuberia
            // 
            this.dgvTuberia.AllowUserToAddRows = false;
            this.dgvTuberia.AllowUserToDeleteRows = false;
            this.dgvTuberia.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTuberia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTuberia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ejecutivo,
            this.razonSocial,
            this.vcPagadora,
            this.IdMoneda_tt,
            this.IdMoneda_tt_Dsc,
            this.Importe,
            this.sdFechaFin,
            this.Doc,
            this.Legal,
            this.Riesgos,
            this.Operac,
            this.Comerc,
            this.Observacion,
            this.TipoCambio});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTuberia.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvTuberia.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvTuberia.Location = new System.Drawing.Point(0, 90);
            this.dgvTuberia.Name = "dgvTuberia";
            this.dgvTuberia.ReadOnly = true;
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            this.dgvTuberia.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvTuberia.Size = new System.Drawing.Size(1308, 452);
            this.dgvTuberia.TabIndex = 58;
            // 
            // Ejecutivo
            // 
            this.Ejecutivo.DataPropertyName = "Ejecutivo";
            this.Ejecutivo.HeaderText = "Ejecutivo";
            this.Ejecutivo.Name = "Ejecutivo";
            this.Ejecutivo.ReadOnly = true;
            this.Ejecutivo.Width = 80;
            // 
            // razonSocial
            // 
            this.razonSocial.DataPropertyName = "razonSocial";
            this.razonSocial.HeaderText = "Nuevo Prospecto";
            this.razonSocial.Name = "razonSocial";
            this.razonSocial.ReadOnly = true;
            this.razonSocial.Width = 150;
            // 
            // vcPagadora
            // 
            this.vcPagadora.DataPropertyName = "vcPagadora";
            this.vcPagadora.HeaderText = "Pagadora";
            this.vcPagadora.Name = "vcPagadora";
            this.vcPagadora.ReadOnly = true;
            this.vcPagadora.Width = 150;
            // 
            // IdMoneda_tt
            // 
            this.IdMoneda_tt.DataPropertyName = "IdMoneda_tt";
            this.IdMoneda_tt.HeaderText = "IdMoneda_tt";
            this.IdMoneda_tt.Name = "IdMoneda_tt";
            this.IdMoneda_tt.ReadOnly = true;
            this.IdMoneda_tt.Visible = false;
            // 
            // IdMoneda_tt_Dsc
            // 
            this.IdMoneda_tt_Dsc.DataPropertyName = "IdMoneda_tt_Dsc";
            this.IdMoneda_tt_Dsc.HeaderText = "Mon.";
            this.IdMoneda_tt_Dsc.Name = "IdMoneda_tt_Dsc";
            this.IdMoneda_tt_Dsc.ReadOnly = true;
            this.IdMoneda_tt_Dsc.Width = 40;
            // 
            // Importe
            // 
            this.Importe.DataPropertyName = "Importe";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "N0";
            dataGridViewCellStyle1.NullValue = null;
            this.Importe.DefaultCellStyle = dataGridViewCellStyle1;
            this.Importe.HeaderText = "Importe";
            this.Importe.Name = "Importe";
            this.Importe.ReadOnly = true;
            // 
            // sdFechaFin
            // 
            this.sdFechaFin.DataPropertyName = "sdFechaFin";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.sdFechaFin.DefaultCellStyle = dataGridViewCellStyle2;
            this.sdFechaFin.HeaderText = "Fecha Aprox.";
            this.sdFechaFin.Name = "sdFechaFin";
            this.sdFechaFin.ReadOnly = true;
            this.sdFechaFin.Width = 80;
            // 
            // Doc
            // 
            this.Doc.DataPropertyName = "Doc";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Doc.DefaultCellStyle = dataGridViewCellStyle3;
            this.Doc.HeaderText = "F1: Doc";
            this.Doc.Name = "Doc";
            this.Doc.ReadOnly = true;
            this.Doc.Width = 60;
            // 
            // Legal
            // 
            this.Legal.DataPropertyName = "Legal";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Legal.DefaultCellStyle = dataGridViewCellStyle4;
            this.Legal.HeaderText = "F2: Legal";
            this.Legal.Name = "Legal";
            this.Legal.ReadOnly = true;
            this.Legal.Width = 60;
            // 
            // Riesgos
            // 
            this.Riesgos.DataPropertyName = "Riesgos";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Riesgos.DefaultCellStyle = dataGridViewCellStyle5;
            this.Riesgos.HeaderText = "F3: Riesgos";
            this.Riesgos.Name = "Riesgos";
            this.Riesgos.ReadOnly = true;
            this.Riesgos.Width = 60;
            // 
            // Operac
            // 
            this.Operac.DataPropertyName = "Operac";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Operac.DefaultCellStyle = dataGridViewCellStyle6;
            this.Operac.HeaderText = "F4: Operac";
            this.Operac.Name = "Operac";
            this.Operac.ReadOnly = true;
            this.Operac.Width = 60;
            // 
            // Comerc
            // 
            this.Comerc.DataPropertyName = "Comerc";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Comerc.DefaultCellStyle = dataGridViewCellStyle7;
            this.Comerc.HeaderText = "F5: Comerc";
            this.Comerc.Name = "Comerc";
            this.Comerc.ReadOnly = true;
            this.Comerc.Width = 60;
            // 
            // Observacion
            // 
            this.Observacion.DataPropertyName = "Observacion";
            this.Observacion.HeaderText = "Comentario y/o Observaciones";
            this.Observacion.Name = "Observacion";
            this.Observacion.ReadOnly = true;
            this.Observacion.Width = 250;
            // 
            // TipoCambio
            // 
            this.TipoCambio.DataPropertyName = "TipoCambio";
            this.TipoCambio.HeaderText = "TipoCambio";
            this.TipoCambio.Name = "TipoCambio";
            this.TipoCambio.ReadOnly = true;
            this.TipoCambio.Visible = false;
            // 
            // frmRpt_Tuberia
            // 
            this.ClientSize = new System.Drawing.Size(1322, 608);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.labelX1);
            this.DoubleBuffered = true;
            this.Name = "frmRpt_Tuberia";
            this.Text = "Reporte de Tuberia";
            this.Load += new System.EventHandler(this.frmRpt_Tuberia_Load);
            this.Controls.SetChildIndex(this.grpDato, 0);
            this.Controls.SetChildIndex(this.btnAceptar, 0);
            this.Controls.SetChildIndex(this.btnCancelar, 0);
            this.Controls.SetChildIndex(this.labelX1, 0);
            this.Controls.SetChildIndex(this.txtTotal, 0);
            this.grpDato.ResumeLayout(false);
            this.PanelEx1.ResumeLayout(false);
            this.panelEx2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTuberia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected DevComponents.DotNetBar.PanelEx PanelEx1;
        protected DevComponents.DotNetBar.PanelEx panelEx2;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboEjecutivo;
        private DevComponents.Editors.ComboItem comboItem1;
        protected DevComponents.DotNetBar.LabelX lblRegistros;
        protected DevComponents.DotNetBar.LabelX labelX5;
        protected DevComponents.DotNetBar.ButtonX btnLimpiar;
        protected DevComponents.DotNetBar.ButtonX btnBuscar;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvTuberia;
        public DevComponents.DotNetBar.LabelX lblTitulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ejecutivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn razonSocial;
        private System.Windows.Forms.DataGridViewTextBoxColumn vcPagadora;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdMoneda_tt;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdMoneda_tt_Dsc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Importe;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdFechaFin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Doc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Legal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Riesgos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Operac;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comerc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Observacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoCambio;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTotal;
    }
}