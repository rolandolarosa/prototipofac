namespace EfideFactoring.Formula.Consulta
{
    partial class frmBusquedaCtaAhorros
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvSocios = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.PanelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.btnLimpiar = new DevComponents.DotNetBar.ButtonX();
            this.txtRazonSocial = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnBuscar = new DevComponents.DotNetBar.ButtonX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.RibbonBar1 = new DevComponents.DotNetBar.RibbonBar();
            this.btnSalir = new DevComponents.DotNetBar.ButtonItem();
            this.dgvtxtNumCuentaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtCodSocio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtSocio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtMoneda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtSaldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtValorMonedaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtTipoProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSocios)).BeginInit();
            this.PanelEx1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvSocios
            // 
            this.dgvSocios.AllowUserToAddRows = false;
            this.dgvSocios.AllowUserToDeleteRows = false;
            this.dgvSocios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSocios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSocios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvtxtNumCuentaID,
            this.dgvtxtCodSocio,
            this.dgvtxtSocio,
            this.dgvtxtProducto,
            this.dgvtxtMoneda,
            this.dgvtxtSaldo,
            this.dgvtxtValorMonedaID,
            this.dgvtxtTipoProducto});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSocios.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSocios.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvSocios.Location = new System.Drawing.Point(0, 103);
            this.dgvSocios.Name = "dgvSocios";
            this.dgvSocios.ReadOnly = true;
            this.dgvSocios.RowHeadersWidth = 10;
            this.dgvSocios.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvSocios.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvSocios.Size = new System.Drawing.Size(783, 371);
            this.dgvSocios.TabIndex = 4;
            this.dgvSocios.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSocios_CellContentDoubleClick);
            // 
            // PanelEx1
            // 
            this.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2010;
            this.PanelEx1.Controls.Add(this.btnLimpiar);
            this.PanelEx1.Controls.Add(this.txtRazonSocial);
            this.PanelEx1.Controls.Add(this.btnBuscar);
            this.PanelEx1.Controls.Add(this.labelX1);
            this.PanelEx1.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelEx1.Location = new System.Drawing.Point(0, 40);
            this.PanelEx1.Name = "PanelEx1";
            this.PanelEx1.Size = new System.Drawing.Size(783, 58);
            this.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.PanelEx1.Style.GradientAngle = 90;
            this.PanelEx1.TabIndex = 3;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnLimpiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimpiar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnLimpiar.Image = global::EfideFactoring.Properties.Resources.magifier_zoom_out;
            this.btnLimpiar.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnLimpiar.Location = new System.Drawing.Point(701, 5);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(73, 44);
            this.btnLimpiar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnLimpiar.TabIndex = 3;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // txtRazonSocial
            // 
            // 
            // 
            // 
            this.txtRazonSocial.Border.Class = "TextBoxBorder";
            this.txtRazonSocial.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtRazonSocial.Location = new System.Drawing.Point(83, 19);
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.Size = new System.Drawing.Size(229, 20);
            this.txtRazonSocial.TabIndex = 1;
            this.txtRazonSocial.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtRazonSocial_KeyDown);
            // 
            // btnBuscar
            // 
            this.btnBuscar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnBuscar.Image = global::EfideFactoring.Properties.Resources.buscar;
            this.btnBuscar.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnBuscar.Location = new System.Drawing.Point(622, 5);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(73, 44);
            this.btnBuscar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(20, 19);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(57, 23);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "Socio";
            // 
            // RibbonBar1
            // 
            this.RibbonBar1.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.RibbonBar1.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.RibbonBar1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.RibbonBar1.ContainerControlProcessDialogKey = true;
            this.RibbonBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.RibbonBar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnSalir});
            this.RibbonBar1.Location = new System.Drawing.Point(0, 0);
            this.RibbonBar1.Name = "RibbonBar1";
            this.RibbonBar1.Size = new System.Drawing.Size(783, 40);
            this.RibbonBar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010;
            this.RibbonBar1.TabIndex = 5;
            // 
            // 
            // 
            this.RibbonBar1.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.RibbonBar1.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // btnSalir
            // 
            this.btnSalir.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnSalir.Image = global::EfideFactoring.Properties.Resources.cerrar;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.SubItemsExpandWidth = 14;
            this.btnSalir.Text = "Salir";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // dgvtxtNumCuentaID
            // 
            this.dgvtxtNumCuentaID.DataPropertyName = "numCuentaID";
            this.dgvtxtNumCuentaID.HeaderText = "N° Cuenta";
            this.dgvtxtNumCuentaID.Name = "dgvtxtNumCuentaID";
            this.dgvtxtNumCuentaID.ReadOnly = true;
            // 
            // dgvtxtCodSocio
            // 
            this.dgvtxtCodSocio.DataPropertyName = "comunTipoCliID";
            this.dgvtxtCodSocio.HeaderText = "Cod. Socio";
            this.dgvtxtCodSocio.Name = "dgvtxtCodSocio";
            this.dgvtxtCodSocio.ReadOnly = true;
            this.dgvtxtCodSocio.Visible = false;
            // 
            // dgvtxtSocio
            // 
            this.dgvtxtSocio.DataPropertyName = "razonSocial";
            this.dgvtxtSocio.HeaderText = "Socio";
            this.dgvtxtSocio.Name = "dgvtxtSocio";
            this.dgvtxtSocio.ReadOnly = true;
            this.dgvtxtSocio.Width = 290;
            // 
            // dgvtxtProducto
            // 
            this.dgvtxtProducto.DataPropertyName = "prodNombre";
            this.dgvtxtProducto.HeaderText = "Producto";
            this.dgvtxtProducto.Name = "dgvtxtProducto";
            this.dgvtxtProducto.ReadOnly = true;
            this.dgvtxtProducto.Width = 200;
            // 
            // dgvtxtMoneda
            // 
            this.dgvtxtMoneda.DataPropertyName = "TipoMoneda";
            this.dgvtxtMoneda.HeaderText = "Moneda";
            this.dgvtxtMoneda.Name = "dgvtxtMoneda";
            this.dgvtxtMoneda.ReadOnly = true;
            this.dgvtxtMoneda.Width = 60;
            // 
            // dgvtxtSaldo
            // 
            this.dgvtxtSaldo.DataPropertyName = "ctaSaldoTotal";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = "0.00";
            this.dgvtxtSaldo.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvtxtSaldo.HeaderText = "Saldo";
            this.dgvtxtSaldo.Name = "dgvtxtSaldo";
            this.dgvtxtSaldo.ReadOnly = true;
            // 
            // dgvtxtValorMonedaID
            // 
            this.dgvtxtValorMonedaID.DataPropertyName = "valorMonedaID";
            this.dgvtxtValorMonedaID.HeaderText = "valorMonedaID";
            this.dgvtxtValorMonedaID.Name = "dgvtxtValorMonedaID";
            this.dgvtxtValorMonedaID.ReadOnly = true;
            this.dgvtxtValorMonedaID.Visible = false;
            // 
            // dgvtxtTipoProducto
            // 
            this.dgvtxtTipoProducto.DataPropertyName = "TipoProducto";
            this.dgvtxtTipoProducto.HeaderText = "TipoProducto";
            this.dgvtxtTipoProducto.Name = "dgvtxtTipoProducto";
            this.dgvtxtTipoProducto.ReadOnly = true;
            this.dgvtxtTipoProducto.Visible = false;
            // 
            // frmBusquedaCtaAhorros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 476);
            this.Controls.Add(this.dgvSocios);
            this.Controls.Add(this.PanelEx1);
            this.Controls.Add(this.RibbonBar1);
            this.DoubleBuffered = true;
            this.Name = "frmBusquedaCtaAhorros";
            this.Text = "frmBusquedaCtaAhorros";
            this.Load += new System.EventHandler(this.frmBusquedaCtaAhorros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSocios)).EndInit();
            this.PanelEx1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX dgvSocios;
        protected DevComponents.DotNetBar.PanelEx PanelEx1;
        protected DevComponents.DotNetBar.ButtonX btnLimpiar;
        private DevComponents.DotNetBar.Controls.TextBoxX txtRazonSocial;
        protected DevComponents.DotNetBar.ButtonX btnBuscar;
        private DevComponents.DotNetBar.LabelX labelX1;
        protected DevComponents.DotNetBar.RibbonBar RibbonBar1;
        protected DevComponents.DotNetBar.ButtonItem btnSalir;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtNumCuentaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtCodSocio;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtSocio;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtMoneda;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtSaldo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtValorMonedaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtTipoProducto;


    }
}