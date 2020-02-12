namespace EfideFactoring.Formula.Reportes
{
    partial class frmRpt_ControlCreditosDet
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRpt_ControlCreditosDet));
            this.dgvDatos = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.creditoID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.razonSocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.credFechaDes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.credFechaVencimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vFaseAnterior = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vFaseActual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiasAntiguedad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CredMontoVigente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CredMontoVencido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CredMonto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdGrupo = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.btnActualizar = new DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn();
            this.lblEntidad = new DevComponents.DotNetBar.LabelX();
            this.line1 = new DevComponents.DotNetBar.Controls.Line();
            this.line3 = new DevComponents.DotNetBar.Controls.Line();
            this.line4 = new DevComponents.DotNetBar.Controls.Line();
            this.line5 = new DevComponents.DotNetBar.Controls.Line();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.lblTotal = new DevComponents.DotNetBar.LabelX();
            this.line2 = new DevComponents.DotNetBar.Controls.Line();
            this.line6 = new DevComponents.DotNetBar.Controls.Line();
            this.lblTotalVigente = new DevComponents.DotNetBar.LabelX();
            this.lblTotalVencido = new DevComponents.DotNetBar.LabelX();
            this.grpDato.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // grpDato
            // 
            this.grpDato.Controls.Add(this.lblTotalVencido);
            this.grpDato.Controls.Add(this.lblTotalVigente);
            this.grpDato.Controls.Add(this.line6);
            this.grpDato.Controls.Add(this.line2);
            this.grpDato.Controls.Add(this.lblTotal);
            this.grpDato.Controls.Add(this.labelX1);
            this.grpDato.Controls.Add(this.line5);
            this.grpDato.Controls.Add(this.line4);
            this.grpDato.Controls.Add(this.line3);
            this.grpDato.Controls.Add(this.line1);
            this.grpDato.Controls.Add(this.lblEntidad);
            this.grpDato.Controls.Add(this.dgvDatos);
            this.grpDato.Size = new System.Drawing.Size(1410, 436);
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
            this.btnCancelar.Location = new System.Drawing.Point(1329, 457);
            this.btnCancelar.Text = "Cerrar";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(1238, 457);
            this.btnAceptar.Visible = false;
            // 
            // dgvDatos
            // 
            this.dgvDatos.AllowUserToAddRows = false;
            this.dgvDatos.AllowUserToDeleteRows = false;
            this.dgvDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.creditoID,
            this.codCliente,
            this.razonSocial,
            this.Producto,
            this.credFechaDes,
            this.credFechaVencimiento,
            this.Documento,
            this.vFaseAnterior,
            this.vFaseActual,
            this.DiasAntiguedad,
            this.Mon,
            this.CredMontoVigente,
            this.CredMontoVencido,
            this.CredMonto,
            this.IdGrupo,
            this.btnActualizar});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDatos.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvDatos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvDatos.Location = new System.Drawing.Point(5, 45);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.Size = new System.Drawing.Size(1394, 355);
            this.dgvDatos.TabIndex = 0;
            this.dgvDatos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDatos_CellClick);
            this.dgvDatos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDatos_CellDoubleClick);
            // 
            // creditoID
            // 
            this.creditoID.DataPropertyName = "creditoID";
            this.creditoID.HeaderText = "creditoID";
            this.creditoID.Name = "creditoID";
            this.creditoID.ReadOnly = true;
            this.creditoID.Visible = false;
            // 
            // codCliente
            // 
            this.codCliente.DataPropertyName = "codCliente";
            this.codCliente.HeaderText = "Código";
            this.codCliente.Name = "codCliente";
            this.codCliente.ReadOnly = true;
            // 
            // razonSocial
            // 
            this.razonSocial.DataPropertyName = "razonSocial";
            this.razonSocial.HeaderText = "Razón Social";
            this.razonSocial.Name = "razonSocial";
            this.razonSocial.ReadOnly = true;
            this.razonSocial.Width = 250;
            // 
            // Producto
            // 
            this.Producto.DataPropertyName = "Producto";
            this.Producto.HeaderText = "Producto";
            this.Producto.Name = "Producto";
            this.Producto.ReadOnly = true;
            // 
            // credFechaDes
            // 
            this.credFechaDes.DataPropertyName = "credFechaDes";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.credFechaDes.DefaultCellStyle = dataGridViewCellStyle1;
            this.credFechaDes.HeaderText = "Fecha Desembolso";
            this.credFechaDes.Name = "credFechaDes";
            this.credFechaDes.ReadOnly = true;
            // 
            // credFechaVencimiento
            // 
            this.credFechaVencimiento.DataPropertyName = "credFechaVencimiento";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Format = "d";
            this.credFechaVencimiento.DefaultCellStyle = dataGridViewCellStyle2;
            this.credFechaVencimiento.HeaderText = "Fecha Vencimiento";
            this.credFechaVencimiento.Name = "credFechaVencimiento";
            this.credFechaVencimiento.ReadOnly = true;
            this.credFechaVencimiento.Width = 80;
            // 
            // Documento
            // 
            this.Documento.DataPropertyName = "Documento";
            this.Documento.HeaderText = "Documento";
            this.Documento.Name = "Documento";
            this.Documento.ReadOnly = true;
            // 
            // vFaseAnterior
            // 
            this.vFaseAnterior.DataPropertyName = "vFaseAnterior";
            this.vFaseAnterior.HeaderText = "Fase Anterior";
            this.vFaseAnterior.Name = "vFaseAnterior";
            this.vFaseAnterior.ReadOnly = true;
            this.vFaseAnterior.Visible = false;
            this.vFaseAnterior.Width = 80;
            // 
            // vFaseActual
            // 
            this.vFaseActual.DataPropertyName = "vFaseActual";
            this.vFaseActual.HeaderText = "Fase Actual";
            this.vFaseActual.Name = "vFaseActual";
            this.vFaseActual.ReadOnly = true;
            this.vFaseActual.Width = 80;
            // 
            // DiasAntiguedad
            // 
            this.DiasAntiguedad.DataPropertyName = "DiasAntiguedad";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DiasAntiguedad.DefaultCellStyle = dataGridViewCellStyle3;
            this.DiasAntiguedad.HeaderText = "Dias Antiguedad";
            this.DiasAntiguedad.Name = "DiasAntiguedad";
            this.DiasAntiguedad.ReadOnly = true;
            this.DiasAntiguedad.Visible = false;
            // 
            // Mon
            // 
            this.Mon.DataPropertyName = "Mon";
            this.Mon.HeaderText = "Mon.";
            this.Mon.Name = "Mon";
            this.Mon.ReadOnly = true;
            this.Mon.Width = 40;
            // 
            // CredMontoVigente
            // 
            this.CredMontoVigente.DataPropertyName = "CredMontoVigente";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N0";
            this.CredMontoVigente.DefaultCellStyle = dataGridViewCellStyle4;
            this.CredMontoVigente.HeaderText = "Vigente";
            this.CredMontoVigente.Name = "CredMontoVigente";
            this.CredMontoVigente.ReadOnly = true;
            // 
            // CredMontoVencido
            // 
            this.CredMontoVencido.DataPropertyName = "CredMontoVencido";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "N0";
            this.CredMontoVencido.DefaultCellStyle = dataGridViewCellStyle5;
            this.CredMontoVencido.HeaderText = "Vencido";
            this.CredMontoVencido.Name = "CredMontoVencido";
            this.CredMontoVencido.ReadOnly = true;
            // 
            // CredMonto
            // 
            this.CredMonto.DataPropertyName = "CredMonto";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "N0";
            this.CredMonto.DefaultCellStyle = dataGridViewCellStyle6;
            this.CredMonto.HeaderText = "En S/";
            this.CredMonto.Name = "CredMonto";
            this.CredMonto.ReadOnly = true;
            // 
            // IdGrupo
            // 
            this.IdGrupo.DataPropertyName = "IdGrupo";
            this.IdGrupo.HeaderText = "Grupo";
            this.IdGrupo.Name = "IdGrupo";
            this.IdGrupo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.IdGrupo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.IdGrupo.Width = 120;
            // 
            // btnActualizar
            // 
            this.btnActualizar.HeaderText = "";
            this.btnActualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizar.Image")));
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btnActualizar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.btnActualizar.Text = null;
            this.btnActualizar.Width = 40;
            // 
            // lblEntidad
            // 
            this.lblEntidad.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lblEntidad.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblEntidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntidad.Location = new System.Drawing.Point(5, 16);
            this.lblEntidad.Name = "lblEntidad";
            this.lblEntidad.Size = new System.Drawing.Size(569, 23);
            this.lblEntidad.TabIndex = 1;
            this.lblEntidad.Text = "lblEntidad";
            // 
            // line1
            // 
            this.line1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.line1.BackColor = System.Drawing.Color.Transparent;
            this.line1.Location = new System.Drawing.Point(34, 423);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(1365, 10);
            this.line1.TabIndex = 2;
            this.line1.Text = "line1";
            // 
            // line3
            // 
            this.line3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.line3.BackColor = System.Drawing.Color.Transparent;
            this.line3.Location = new System.Drawing.Point(29, 400);
            this.line3.Name = "line3";
            this.line3.Size = new System.Drawing.Size(10, 28);
            this.line3.TabIndex = 4;
            this.line3.Text = "line3";
            this.line3.VerticalLine = true;
            // 
            // line4
            // 
            this.line4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.line4.BackColor = System.Drawing.Color.Transparent;
            this.line4.Location = new System.Drawing.Point(1393, 400);
            this.line4.Name = "line4";
            this.line4.Size = new System.Drawing.Size(10, 28);
            this.line4.TabIndex = 5;
            this.line4.Text = "line4";
            this.line4.VerticalLine = true;
            // 
            // line5
            // 
            this.line5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.line5.BackColor = System.Drawing.Color.Transparent;
            this.line5.Location = new System.Drawing.Point(1103, 400);
            this.line5.Name = "line5";
            this.line5.Size = new System.Drawing.Size(10, 28);
            this.line5.TabIndex = 6;
            this.line5.Text = "line5";
            this.line5.VerticalLine = true;
            // 
            // labelX1
            // 
            this.labelX1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.Location = new System.Drawing.Point(798, 403);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(111, 23);
            this.labelX1.TabIndex = 7;
            this.labelX1.Text = "Total";
            this.labelX1.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotal.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lblTotal.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(1115, 403);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(100, 23);
            this.lblTotal.TabIndex = 8;
            this.lblTotal.Text = "lblTotal";
            this.lblTotal.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // line2
            // 
            this.line2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.line2.BackColor = System.Drawing.Color.Transparent;
            this.line2.Location = new System.Drawing.Point(910, 400);
            this.line2.Name = "line2";
            this.line2.Size = new System.Drawing.Size(10, 28);
            this.line2.TabIndex = 9;
            this.line2.Text = "line2";
            this.line2.VerticalLine = true;
            // 
            // line6
            // 
            this.line6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.line6.BackColor = System.Drawing.Color.Transparent;
            this.line6.Location = new System.Drawing.Point(1009, 400);
            this.line6.Name = "line6";
            this.line6.Size = new System.Drawing.Size(10, 28);
            this.line6.TabIndex = 10;
            this.line6.Text = "line6";
            this.line6.VerticalLine = true;
            // 
            // lblTotalVigente
            // 
            this.lblTotalVigente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalVigente.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lblTotalVigente.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblTotalVigente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalVigente.Location = new System.Drawing.Point(916, 403);
            this.lblTotalVigente.Name = "lblTotalVigente";
            this.lblTotalVigente.Size = new System.Drawing.Size(95, 23);
            this.lblTotalVigente.TabIndex = 11;
            this.lblTotalVigente.Text = "labelX2";
            this.lblTotalVigente.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // lblTotalVencido
            // 
            this.lblTotalVencido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalVencido.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lblTotalVencido.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblTotalVencido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalVencido.Location = new System.Drawing.Point(1017, 403);
            this.lblTotalVencido.Name = "lblTotalVencido";
            this.lblTotalVencido.Size = new System.Drawing.Size(87, 23);
            this.lblTotalVencido.TabIndex = 12;
            this.lblTotalVencido.Text = "labelX3";
            this.lblTotalVencido.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // frmRpt_ControlCreditosDet
            // 
            this.ClientSize = new System.Drawing.Size(1418, 493);
            this.DoubleBuffered = true;
            this.Name = "frmRpt_ControlCreditosDet";
            this.Text = "Reporte Control Crédito Detalle";
            this.Load += new System.EventHandler(this.frmRpt_ControlCreditosDet_Load);
            this.grpDato.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX dgvDatos;
        private DevComponents.DotNetBar.LabelX lblEntidad;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.Line line5;
        private DevComponents.DotNetBar.Controls.Line line4;
        private DevComponents.DotNetBar.Controls.Line line3;
        private DevComponents.DotNetBar.Controls.Line line1;
        private DevComponents.DotNetBar.LabelX lblTotal;
        private DevComponents.DotNetBar.LabelX lblTotalVencido;
        private DevComponents.DotNetBar.LabelX lblTotalVigente;
        private DevComponents.DotNetBar.Controls.Line line6;
        private DevComponents.DotNetBar.Controls.Line line2;
        private System.Windows.Forms.DataGridViewTextBoxColumn creditoID;
        private System.Windows.Forms.DataGridViewTextBoxColumn codCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn razonSocial;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn credFechaDes;
        private System.Windows.Forms.DataGridViewTextBoxColumn credFechaVencimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn vFaseAnterior;
        private System.Windows.Forms.DataGridViewTextBoxColumn vFaseActual;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiasAntiguedad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mon;
        private System.Windows.Forms.DataGridViewTextBoxColumn CredMontoVigente;
        private System.Windows.Forms.DataGridViewTextBoxColumn CredMontoVencido;
        private System.Windows.Forms.DataGridViewTextBoxColumn CredMonto;
        private System.Windows.Forms.DataGridViewComboBoxColumn IdGrupo;
        private DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn btnActualizar;
    }
}