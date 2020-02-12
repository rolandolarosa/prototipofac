namespace EfideFactoring.Formula.Registros
{
    partial class frmMntCuentasxPagarTMBloqueo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMntCuentasxPagarTMBloqueo));
            this.dgvDatos = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.ctaPagarID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cxpFecEmision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.razonSocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vcPagadora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipCxpNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Moneda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cxpImpComp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cxpImpComis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBusquedaSocio = new DevComponents.DotNetBar.ButtonX();
            this.txtRazonSocialSocio = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnBloquear = new DevComponents.DotNetBar.ButtonItem();
            this.chkCuentasBloqueadas = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.txtIdPagadora = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtDescripcion = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnBuscarPagadora = new DevComponents.DotNetBar.ButtonX();
            this.btnLimpiarPagadora = new DevComponents.DotNetBar.ButtonX();
            this.btnLimpiarSocio = new DevComponents.DotNetBar.ButtonX();
            this.PanelEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // RibbonBar1
            // 
            // 
            // 
            // 
            this.RibbonBar1.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.RibbonBar1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.RibbonBar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnBloquear});
            this.RibbonBar1.Size = new System.Drawing.Size(1248, 40);
            // 
            // 
            // 
            this.RibbonBar1.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.RibbonBar1.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Visible = false;
            // 
            // btnEditar
            // 
            this.btnEditar.Visible = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Enabled = false;
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.Text = "Desbloquear";
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // PanelEx1
            // 
            this.PanelEx1.Controls.Add(this.btnLimpiarSocio);
            this.PanelEx1.Controls.Add(this.btnLimpiarPagadora);
            this.PanelEx1.Controls.Add(this.btnBuscarPagadora);
            this.PanelEx1.Controls.Add(this.txtIdPagadora);
            this.PanelEx1.Controls.Add(this.txtDescripcion);
            this.PanelEx1.Controls.Add(this.labelX2);
            this.PanelEx1.Controls.Add(this.chkCuentasBloqueadas);
            this.PanelEx1.Controls.Add(this.btnBusquedaSocio);
            this.PanelEx1.Controls.Add(this.txtRazonSocialSocio);
            this.PanelEx1.Size = new System.Drawing.Size(1248, 66);
            this.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.PanelEx1.Style.GradientAngle = 90;
            this.PanelEx1.Controls.SetChildIndex(this.LabelX1, 0);
            this.PanelEx1.Controls.SetChildIndex(this.TextBoxX1, 0);
            this.PanelEx1.Controls.SetChildIndex(this.btnBuscar, 0);
            this.PanelEx1.Controls.SetChildIndex(this.btnLimpiar, 0);
            this.PanelEx1.Controls.SetChildIndex(this.txtRazonSocialSocio, 0);
            this.PanelEx1.Controls.SetChildIndex(this.btnBusquedaSocio, 0);
            this.PanelEx1.Controls.SetChildIndex(this.chkCuentasBloqueadas, 0);
            this.PanelEx1.Controls.SetChildIndex(this.labelX2, 0);
            this.PanelEx1.Controls.SetChildIndex(this.txtDescripcion, 0);
            this.PanelEx1.Controls.SetChildIndex(this.txtIdPagadora, 0);
            this.PanelEx1.Controls.SetChildIndex(this.btnBuscarPagadora, 0);
            this.PanelEx1.Controls.SetChildIndex(this.btnLimpiarPagadora, 0);
            this.PanelEx1.Controls.SetChildIndex(this.btnLimpiarSocio, 0);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(861, 16);
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(784, 16);
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // TextBoxX1
            // 
            // 
            // 
            // 
            this.TextBoxX1.Border.Class = "TextBoxBorder";
            this.TextBoxX1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TextBoxX1.Location = new System.Drawing.Point(95, 16);
            this.TextBoxX1.ReadOnly = true;
            this.TextBoxX1.Size = new System.Drawing.Size(122, 20);
            // 
            // LabelX1
            // 
            // 
            // 
            // 
            this.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LabelX1.Size = new System.Drawing.Size(46, 23);
            this.LabelX1.Text = "Socio";
            // 
            // lblGrilla
            // 
            // 
            // 
            // 
            this.lblGrilla.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblGrilla.Location = new System.Drawing.Point(0, 111);
            this.lblGrilla.Size = new System.Drawing.Size(177, 23);
            this.lblGrilla.Text = "Cuentas por Pagar";
            // 
            // lblRegistros
            // 
            // 
            // 
            // 
            this.lblRegistros.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblRegistros.Location = new System.Drawing.Point(1072, 112);
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
            this.ctaPagarID,
            this.cxpFecEmision,
            this.razonSocial,
            this.vcPagadora,
            this.tipCxpNombre,
            this.Moneda,
            this.cxpImpComp,
            this.cxpImpComis,
            this.Estado});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDatos.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDatos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvDatos.Location = new System.Drawing.Point(0, 140);
            this.dgvDatos.Name = "dgvDatos";
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            this.dgvDatos.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvDatos.Size = new System.Drawing.Size(1248, 449);
            this.dgvDatos.TabIndex = 22;
            this.dgvDatos.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgvDatos_CurrentCellDirtyStateChanged);
            // 
            // ctaPagarID
            // 
            this.ctaPagarID.DataPropertyName = "ctaPagarID";
            this.ctaPagarID.HeaderText = "Código";
            this.ctaPagarID.Name = "ctaPagarID";
            // 
            // cxpFecEmision
            // 
            this.cxpFecEmision.DataPropertyName = "cxpFecEmision";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.cxpFecEmision.DefaultCellStyle = dataGridViewCellStyle1;
            this.cxpFecEmision.HeaderText = "Fecha Emisión";
            this.cxpFecEmision.Name = "cxpFecEmision";
            this.cxpFecEmision.Width = 80;
            // 
            // razonSocial
            // 
            this.razonSocial.DataPropertyName = "razonSocial";
            this.razonSocial.HeaderText = "Socio";
            this.razonSocial.Name = "razonSocial";
            this.razonSocial.Width = 200;
            // 
            // vcPagadora
            // 
            this.vcPagadora.DataPropertyName = "vcPagadora";
            this.vcPagadora.HeaderText = "Pagadora";
            this.vcPagadora.Name = "vcPagadora";
            this.vcPagadora.ReadOnly = true;
            this.vcPagadora.Width = 200;
            // 
            // tipCxpNombre
            // 
            this.tipCxpNombre.DataPropertyName = "tipCxpNombre";
            this.tipCxpNombre.HeaderText = "Cuenta por Pagar";
            this.tipCxpNombre.Name = "tipCxpNombre";
            this.tipCxpNombre.Width = 200;
            // 
            // Moneda
            // 
            this.Moneda.DataPropertyName = "Moneda";
            this.Moneda.HeaderText = "Moneda";
            this.Moneda.Name = "Moneda";
            this.Moneda.Width = 60;
            // 
            // cxpImpComp
            // 
            this.cxpImpComp.DataPropertyName = "cxpImpComp";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.cxpImpComp.DefaultCellStyle = dataGridViewCellStyle2;
            this.cxpImpComp.HeaderText = "Compromiso";
            this.cxpImpComp.Name = "cxpImpComp";
            this.cxpImpComp.Width = 80;
            // 
            // cxpImpComis
            // 
            this.cxpImpComis.DataPropertyName = "cxpImpComis";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.cxpImpComis.DefaultCellStyle = dataGridViewCellStyle3;
            this.cxpImpComis.HeaderText = "Comisión";
            this.cxpImpComis.Name = "cxpImpComis";
            this.cxpImpComis.Width = 80;
            // 
            // Estado
            // 
            this.Estado.DataPropertyName = "Estado";
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.Width = 80;
            // 
            // btnBusquedaSocio
            // 
            this.btnBusquedaSocio.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnBusquedaSocio.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnBusquedaSocio.Location = new System.Drawing.Point(461, 16);
            this.btnBusquedaSocio.Name = "btnBusquedaSocio";
            this.btnBusquedaSocio.Size = new System.Drawing.Size(31, 20);
            this.btnBusquedaSocio.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnBusquedaSocio.TabIndex = 9;
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
            this.txtRazonSocialSocio.Location = new System.Drawing.Point(218, 16);
            this.txtRazonSocialSocio.Name = "txtRazonSocialSocio";
            this.txtRazonSocialSocio.ReadOnly = true;
            this.txtRazonSocialSocio.Size = new System.Drawing.Size(242, 20);
            this.txtRazonSocialSocio.TabIndex = 8;
            this.txtRazonSocialSocio.TabStop = false;
            // 
            // btnBloquear
            // 
            this.btnBloquear.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnBloquear.Enabled = false;
            this.btnBloquear.Image = ((System.Drawing.Image)(resources.GetObject("btnBloquear.Image")));
            this.btnBloquear.Name = "btnBloquear";
            this.btnBloquear.SubItemsExpandWidth = 14;
            this.btnBloquear.Text = "Bloquear";
            this.btnBloquear.Click += new System.EventHandler(this.btnBloquear_Click);
            // 
            // chkCuentasBloqueadas
            // 
            // 
            // 
            // 
            this.chkCuentasBloqueadas.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.chkCuentasBloqueadas.Location = new System.Drawing.Point(564, 13);
            this.chkCuentasBloqueadas.Name = "chkCuentasBloqueadas";
            this.chkCuentasBloqueadas.Size = new System.Drawing.Size(194, 23);
            this.chkCuentasBloqueadas.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.chkCuentasBloqueadas.TabIndex = 10;
            this.chkCuentasBloqueadas.Text = "Mostrar Cuentas Bloqueadas";
            this.chkCuentasBloqueadas.CheckedChanged += new System.EventHandler(this.chkCuentasBloqueadas_CheckedChanged);
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelX2.Location = new System.Drawing.Point(14, 37);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(70, 23);
            this.labelX2.TabIndex = 11;
            this.labelX2.Text = "Pagadora";
            // 
            // txtIdPagadora
            // 
            // 
            // 
            // 
            this.txtIdPagadora.Border.Class = "TextBoxBorder";
            this.txtIdPagadora.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtIdPagadora.Location = new System.Drawing.Point(95, 39);
            this.txtIdPagadora.Name = "txtIdPagadora";
            this.txtIdPagadora.ReadOnly = true;
            this.txtIdPagadora.Size = new System.Drawing.Size(122, 20);
            this.txtIdPagadora.TabIndex = 12;
            // 
            // txtDescripcion
            // 
            // 
            // 
            // 
            this.txtDescripcion.Border.Class = "TextBoxBorder";
            this.txtDescripcion.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtDescripcion.Location = new System.Drawing.Point(218, 39);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.ReadOnly = true;
            this.txtDescripcion.Size = new System.Drawing.Size(242, 20);
            this.txtDescripcion.TabIndex = 13;
            // 
            // btnBuscarPagadora
            // 
            this.btnBuscarPagadora.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnBuscarPagadora.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnBuscarPagadora.Location = new System.Drawing.Point(461, 39);
            this.btnBuscarPagadora.Name = "btnBuscarPagadora";
            this.btnBuscarPagadora.Size = new System.Drawing.Size(31, 20);
            this.btnBuscarPagadora.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnBuscarPagadora.TabIndex = 14;
            this.btnBuscarPagadora.Text = "...";
            this.btnBuscarPagadora.Click += new System.EventHandler(this.btnBuscarPagadora_Click);
            // 
            // btnLimpiarPagadora
            // 
            this.btnLimpiarPagadora.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnLimpiarPagadora.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnLimpiarPagadora.Image = global::EfideFactoring.Properties.Resources.magifier_zoom_out;
            this.btnLimpiarPagadora.Location = new System.Drawing.Point(494, 39);
            this.btnLimpiarPagadora.Name = "btnLimpiarPagadora";
            this.btnLimpiarPagadora.Size = new System.Drawing.Size(31, 20);
            this.btnLimpiarPagadora.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnLimpiarPagadora.TabIndex = 15;
            this.btnLimpiarPagadora.Click += new System.EventHandler(this.btnLimpiarPagadora_Click);
            // 
            // btnLimpiarSocio
            // 
            this.btnLimpiarSocio.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnLimpiarSocio.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnLimpiarSocio.Image = global::EfideFactoring.Properties.Resources.magifier_zoom_out;
            this.btnLimpiarSocio.Location = new System.Drawing.Point(494, 16);
            this.btnLimpiarSocio.Name = "btnLimpiarSocio";
            this.btnLimpiarSocio.Size = new System.Drawing.Size(31, 20);
            this.btnLimpiarSocio.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnLimpiarSocio.TabIndex = 16;
            this.btnLimpiarSocio.Click += new System.EventHandler(this.btnLimpiarSocio_Click);
            // 
            // frmMntCuentasxPagarTMBloqueo
            // 
            this.ClientSize = new System.Drawing.Size(1248, 588);
            this.Controls.Add(this.dgvDatos);
            this.DoubleBuffered = true;
            this.Name = "frmMntCuentasxPagarTMBloqueo";
            this.Text = "Cuentas por Pagar Bloqueadas";
            this.Load += new System.EventHandler(this.frmMntCuentasxPagarTMBloqueo_Load);
            this.Controls.SetChildIndex(this.RibbonBar1, 0);
            this.Controls.SetChildIndex(this.PanelEx1, 0);
            this.Controls.SetChildIndex(this.lblRegistros, 0);
            this.Controls.SetChildIndex(this.lblGrilla, 0);
            this.Controls.SetChildIndex(this.dgvDatos, 0);
            this.PanelEx1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX dgvDatos;
        private DevComponents.DotNetBar.ButtonX btnBusquedaSocio;
        private DevComponents.DotNetBar.Controls.TextBoxX txtRazonSocialSocio;
        private DevComponents.DotNetBar.ButtonItem btnBloquear;
        private DevComponents.DotNetBar.Controls.CheckBoxX chkCuentasBloqueadas;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.TextBoxX txtIdPagadora;
        private DevComponents.DotNetBar.Controls.TextBoxX txtDescripcion;
        private DevComponents.DotNetBar.ButtonX btnBuscarPagadora;
        private DevComponents.DotNetBar.ButtonX btnLimpiarSocio;
        private DevComponents.DotNetBar.ButtonX btnLimpiarPagadora;
        private System.Windows.Forms.DataGridViewTextBoxColumn ctaPagarID;
        private System.Windows.Forms.DataGridViewTextBoxColumn cxpFecEmision;
        private System.Windows.Forms.DataGridViewTextBoxColumn razonSocial;
        private System.Windows.Forms.DataGridViewTextBoxColumn vcPagadora;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipCxpNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Moneda;
        private System.Windows.Forms.DataGridViewTextBoxColumn cxpImpComp;
        private System.Windows.Forms.DataGridViewTextBoxColumn cxpImpComis;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
    }
}