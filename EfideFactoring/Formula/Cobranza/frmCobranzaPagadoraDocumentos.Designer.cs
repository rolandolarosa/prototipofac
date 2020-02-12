namespace EfideFactoring.Formula.Cobranza
{
    partial class frmCobranzaPagadoraDocumentos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.txtNombreEntidad = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtIdEntidad = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.dgvDocumentos = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.btnSalir = new DevComponents.DotNetBar.ButtonX();
            this.btnAceptar = new DevComponents.DotNetBar.ButtonX();
            this.item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNumDoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdSocio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdPagadora_Dsc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdPagadora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Socio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nvNegociable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nvMontoCobrar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NroLote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaVencimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdVencimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nTazaActiva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nPorFondoGarantia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CheckSel = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.nFondoGarantia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocumentos)).BeginInit();
            this.SuspendLayout();
            // 
            // groupPanel1
            // 
            this.groupPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.txtNombreEntidad);
            this.groupPanel1.Controls.Add(this.txtIdEntidad);
            this.groupPanel1.Controls.Add(this.dgvDocumentos);
            this.groupPanel1.Location = new System.Drawing.Point(10, 12);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(1175, 285);
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
            this.groupPanel1.TabIndex = 29;
            // 
            // txtNombreEntidad
            // 
            this.txtNombreEntidad.BackColor = System.Drawing.SystemColors.Info;
            // 
            // 
            // 
            this.txtNombreEntidad.Border.Class = "TextBoxBorder";
            this.txtNombreEntidad.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtNombreEntidad.Enabled = false;
            this.txtNombreEntidad.Location = new System.Drawing.Point(124, 5);
            this.txtNombreEntidad.Name = "txtNombreEntidad";
            this.txtNombreEntidad.Size = new System.Drawing.Size(353, 22);
            this.txtNombreEntidad.TabIndex = 1;
            // 
            // txtIdEntidad
            // 
            this.txtIdEntidad.BackColor = System.Drawing.SystemColors.Info;
            // 
            // 
            // 
            this.txtIdEntidad.Border.Class = "TextBoxBorder";
            this.txtIdEntidad.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtIdEntidad.Enabled = false;
            this.txtIdEntidad.Location = new System.Drawing.Point(18, 5);
            this.txtIdEntidad.Name = "txtIdEntidad";
            this.txtIdEntidad.Size = new System.Drawing.Size(100, 22);
            this.txtIdEntidad.TabIndex = 0;
            // 
            // dgvDocumentos
            // 
            this.dgvDocumentos.AllowUserToAddRows = false;
            this.dgvDocumentos.AllowUserToDeleteRows = false;
            this.dgvDocumentos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDocumentos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvDocumentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDocumentos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.item,
            this.IdDocumento,
            this.cNumDoc,
            this.Documento,
            this.IdSocio,
            this.IdPagadora_Dsc,
            this.IdPagadora,
            this.Socio,
            this.Importe,
            this.nvNegociable,
            this.nvMontoCobrar,
            this.NroLote,
            this.FechaVencimiento,
            this.sdVencimiento,
            this.nTazaActiva,
            this.nPorFondoGarantia,
            this.CheckSel,
            this.nFondoGarantia});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDocumentos.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvDocumentos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvDocumentos.Location = new System.Drawing.Point(18, 31);
            this.dgvDocumentos.Name = "dgvDocumentos";
            this.dgvDocumentos.RowHeadersWidth = 10;
            this.dgvDocumentos.Size = new System.Drawing.Size(1129, 230);
            this.dgvDocumentos.TabIndex = 2;
            this.dgvDocumentos.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgvDocumentos_CurrentCellDirtyStateChanged);
            // 
            // btnSalir
            // 
            this.btnSalir.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSalir.Image = global::EfideFactoring.Properties.Resources.cerrar;
            this.btnSalir.Location = new System.Drawing.Point(1105, 304);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(78, 28);
            this.btnSalir.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSalir.TabIndex = 30;
            this.btnSalir.Text = "Salir";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAceptar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAceptar.Image = global::EfideFactoring.Properties.Resources.btn_ok;
            this.btnAceptar.Location = new System.Drawing.Point(1013, 304);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(86, 28);
            this.btnAceptar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAceptar.TabIndex = 31;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // item
            // 
            this.item.DataPropertyName = "item";
            this.item.HeaderText = "item";
            this.item.Name = "item";
            this.item.ReadOnly = true;
            this.item.Visible = false;
            this.item.Width = 40;
            // 
            // IdDocumento
            // 
            this.IdDocumento.DataPropertyName = "IdDocumento";
            this.IdDocumento.HeaderText = "IdDocumento";
            this.IdDocumento.Name = "IdDocumento";
            this.IdDocumento.ReadOnly = true;
            this.IdDocumento.Visible = false;
            this.IdDocumento.Width = 97;
            // 
            // cNumDoc
            // 
            this.cNumDoc.DataPropertyName = "cNumDoc";
            this.cNumDoc.HeaderText = "cNumDoc";
            this.cNumDoc.Name = "cNumDoc";
            this.cNumDoc.ReadOnly = true;
            this.cNumDoc.Visible = false;
            this.cNumDoc.Width = 75;
            // 
            // Documento
            // 
            this.Documento.DataPropertyName = "vDocumento";
            this.Documento.HeaderText = "Documento";
            this.Documento.Name = "Documento";
            this.Documento.ReadOnly = true;
            this.Documento.Width = 105;
            // 
            // IdSocio
            // 
            this.IdSocio.DataPropertyName = "IdSocio";
            this.IdSocio.HeaderText = "IdSocio";
            this.IdSocio.Name = "IdSocio";
            this.IdSocio.ReadOnly = true;
            this.IdSocio.Visible = false;
            this.IdSocio.Width = 79;
            // 
            // IdPagadora_Dsc
            // 
            this.IdPagadora_Dsc.DataPropertyName = "IdPagadora_Dsc";
            this.IdPagadora_Dsc.HeaderText = "Pagadora";
            this.IdPagadora_Dsc.Name = "IdPagadora_Dsc";
            this.IdPagadora_Dsc.ReadOnly = true;
            this.IdPagadora_Dsc.Width = 95;
            // 
            // IdPagadora
            // 
            this.IdPagadora.DataPropertyName = "IdPagadora";
            this.IdPagadora.HeaderText = "IdPagadora";
            this.IdPagadora.Name = "IdPagadora";
            this.IdPagadora.ReadOnly = true;
            this.IdPagadora.Visible = false;
            this.IdPagadora.Width = 106;
            // 
            // Socio
            // 
            this.Socio.DataPropertyName = "IdSocio_Dsc";
            this.Socio.HeaderText = "Socio";
            this.Socio.Name = "Socio";
            this.Socio.ReadOnly = true;
            this.Socio.Width = 68;
            // 
            // Importe
            // 
            this.Importe.DataPropertyName = "nvNominal";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = null;
            this.Importe.DefaultCellStyle = dataGridViewCellStyle1;
            this.Importe.HeaderText = "Valor Nominal";
            this.Importe.Name = "Importe";
            this.Importe.ReadOnly = true;
            this.Importe.Width = 121;
            // 
            // nvNegociable
            // 
            this.nvNegociable.DataPropertyName = "nvNegociable";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.nvNegociable.DefaultCellStyle = dataGridViewCellStyle2;
            this.nvNegociable.HeaderText = "Valor Negociable";
            this.nvNegociable.Name = "nvNegociable";
            this.nvNegociable.ReadOnly = true;
            this.nvNegociable.Width = 129;
            // 
            // nvMontoCobrar
            // 
            this.nvMontoCobrar.DataPropertyName = "nvMontoCobrar";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.nvMontoCobrar.DefaultCellStyle = dataGridViewCellStyle3;
            this.nvMontoCobrar.HeaderText = "Monto a Cobrar";
            this.nvMontoCobrar.Name = "nvMontoCobrar";
            this.nvMontoCobrar.ReadOnly = true;
            this.nvMontoCobrar.Width = 120;
            // 
            // NroLote
            // 
            this.NroLote.DataPropertyName = "IdLote";
            this.NroLote.HeaderText = "Nro. Lote";
            this.NroLote.Name = "NroLote";
            this.NroLote.ReadOnly = true;
            this.NroLote.Width = 85;
            // 
            // FechaVencimiento
            // 
            this.FechaVencimiento.DataPropertyName = "sdRecepcion";
            dataGridViewCellStyle4.Format = "d";
            dataGridViewCellStyle4.NullValue = null;
            this.FechaVencimiento.DefaultCellStyle = dataGridViewCellStyle4;
            this.FechaVencimiento.HeaderText = "Fecha Recepción";
            this.FechaVencimiento.Name = "FechaVencimiento";
            this.FechaVencimiento.ReadOnly = true;
            this.FechaVencimiento.Width = 131;
            // 
            // sdVencimiento
            // 
            this.sdVencimiento.DataPropertyName = "sdVencimiento";
            dataGridViewCellStyle5.Format = "d";
            dataGridViewCellStyle5.NullValue = null;
            this.sdVencimiento.DefaultCellStyle = dataGridViewCellStyle5;
            this.sdVencimiento.HeaderText = "Vencimiento";
            this.sdVencimiento.Name = "sdVencimiento";
            this.sdVencimiento.ReadOnly = true;
            this.sdVencimiento.Width = 110;
            // 
            // nTazaActiva
            // 
            this.nTazaActiva.DataPropertyName = "nTazaActiva";
            this.nTazaActiva.HeaderText = "nTazaActiva";
            this.nTazaActiva.Name = "nTazaActiva";
            this.nTazaActiva.ReadOnly = true;
            this.nTazaActiva.Visible = false;
            this.nTazaActiva.Width = 111;
            // 
            // nPorFondoGarantia
            // 
            this.nPorFondoGarantia.DataPropertyName = "nPorFondoGarantia";
            this.nPorFondoGarantia.HeaderText = "nPorFondoGarantia";
            this.nPorFondoGarantia.Name = "nPorFondoGarantia";
            this.nPorFondoGarantia.ReadOnly = true;
            this.nPorFondoGarantia.Visible = false;
            this.nPorFondoGarantia.Width = 158;
            // 
            // CheckSel
            // 
            this.CheckSel.DataPropertyName = "CheckSel";
            this.CheckSel.HeaderText = "";
            this.CheckSel.Name = "CheckSel";
            this.CheckSel.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CheckSel.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.CheckSel.Width = 19;
            // 
            // nFondoGarantia
            // 
            this.nFondoGarantia.DataPropertyName = "nFondoGarantia";
            this.nFondoGarantia.HeaderText = "nFondoGarantia";
            this.nFondoGarantia.Name = "nFondoGarantia";
            this.nFondoGarantia.Visible = false;
            this.nFondoGarantia.Width = 136;
            // 
            // frmCobranzaPagadoraDocumentos
            // 
            this.ClientSize = new System.Drawing.Size(1190, 333);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.groupPanel1);
            this.DoubleBuffered = true;
            this.Name = "frmCobranzaPagadoraDocumentos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cobranza - Documentos Pendientes";
            this.Load += new System.EventHandler(this.frmCobranzaPagadoraDocumentos_Load);
            this.groupPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocumentos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtNombreEntidad;
        private DevComponents.DotNetBar.Controls.TextBoxX txtIdEntidad;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvDocumentos;
        internal DevComponents.DotNetBar.ButtonX btnSalir;
        internal DevComponents.DotNetBar.ButtonX btnAceptar;
        private System.Windows.Forms.DataGridViewTextBoxColumn item;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNumDoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdSocio;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdPagadora_Dsc;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdPagadora;
        private System.Windows.Forms.DataGridViewTextBoxColumn Socio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Importe;
        private System.Windows.Forms.DataGridViewTextBoxColumn nvNegociable;
        private System.Windows.Forms.DataGridViewTextBoxColumn nvMontoCobrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroLote;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaVencimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdVencimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn nTazaActiva;
        private System.Windows.Forms.DataGridViewTextBoxColumn nPorFondoGarantia;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CheckSel;
        private System.Windows.Forms.DataGridViewTextBoxColumn nFondoGarantia;
    }
}