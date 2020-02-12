namespace EfideFactoring.Formula.GestionComercial
{
    partial class frmBitacoraComercial
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelEx2 = new DevComponents.DotNetBar.PanelEx();
            this.btnBuscar = new DevComponents.DotNetBar.ButtonX();
            this.cboEjecutivo = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem1 = new DevComponents.Editors.ComboItem();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.btnVentas = new DevComponents.DotNetBar.ButtonX();
            this.lblRegistros = new DevComponents.DotNetBar.LabelX();
            this.dgvBitacoraComercial = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.IdBitacoraComercial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdSocio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vcSocio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdTipoBitacora_tt_Dsc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaAlerta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiasVenc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vencimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdEstado_tt_Dsc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdGestor_Dsc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAtender = new DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn();
            this.ColorRow = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpDato.SuspendLayout();
            this.panelEx2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBitacoraComercial)).BeginInit();
            this.SuspendLayout();
            // 
            // grpDato
            // 
            this.grpDato.Controls.Add(this.lblRegistros);
            this.grpDato.Controls.Add(this.dgvBitacoraComercial);
            this.grpDato.Controls.Add(this.panelEx2);
            this.grpDato.Size = new System.Drawing.Size(1274, 563);
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
            this.btnCancelar.Location = new System.Drawing.Point(1193, 584);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(1102, 584);
            this.btnAceptar.Visible = false;
            // 
            // panelEx2
            // 
            this.panelEx2.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2010;
            this.panelEx2.Controls.Add(this.btnBuscar);
            this.panelEx2.Controls.Add(this.cboEjecutivo);
            this.panelEx2.Controls.Add(this.labelX2);
            this.panelEx2.Controls.Add(this.btnVentas);
            this.panelEx2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEx2.Location = new System.Drawing.Point(0, 0);
            this.panelEx2.Name = "panelEx2";
            this.panelEx2.Size = new System.Drawing.Size(1268, 65);
            this.panelEx2.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx2.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx2.Style.GradientAngle = 90;
            this.panelEx2.TabIndex = 60;
            // 
            // btnBuscar
            // 
            this.btnBuscar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnBuscar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnBuscar.Enabled = false;
            this.btnBuscar.Image = global::EfideFactoring.Properties.Resources.buscar;
            this.btnBuscar.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnBuscar.Location = new System.Drawing.Point(309, 16);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(73, 41);
            this.btnBuscar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnBuscar.TabIndex = 11;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // cboEjecutivo
            // 
            this.cboEjecutivo.DisplayMember = "Text";
            this.cboEjecutivo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboEjecutivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEjecutivo.Enabled = false;
            this.cboEjecutivo.FormattingEnabled = true;
            this.cboEjecutivo.ItemHeight = 14;
            this.cboEjecutivo.Items.AddRange(new object[] {
            this.comboItem1});
            this.cboEjecutivo.Location = new System.Drawing.Point(95, 37);
            this.cboEjecutivo.Name = "cboEjecutivo";
            this.cboEjecutivo.Size = new System.Drawing.Size(162, 20);
            this.cboEjecutivo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboEjecutivo.TabIndex = 10;
            // 
            // comboItem1
            // 
            this.comboItem1.Text = "<< Todos >>";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelX2.Location = new System.Drawing.Point(15, 37);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(59, 20);
            this.labelX2.TabIndex = 9;
            this.labelX2.Text = "Gestor";
            // 
            // btnVentas
            // 
            this.btnVentas.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnVentas.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnVentas.Enabled = false;
            this.btnVentas.Location = new System.Drawing.Point(15, 8);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Size = new System.Drawing.Size(108, 23);
            this.btnVentas.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnVentas.TabIndex = 0;
            this.btnVentas.Text = "VENTAS";
            this.btnVentas.Click += new System.EventHandler(this.btnVentas_Click);
            // 
            // lblRegistros
            // 
            this.lblRegistros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRegistros.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lblRegistros.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblRegistros.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblRegistros.Location = new System.Drawing.Point(1141, 68);
            this.lblRegistros.Name = "lblRegistros";
            this.lblRegistros.Size = new System.Drawing.Size(127, 17);
            this.lblRegistros.TabIndex = 62;
            this.lblRegistros.Text = "0  registro(s)";
            this.lblRegistros.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // dgvBitacoraComercial
            // 
            this.dgvBitacoraComercial.AllowUserToAddRows = false;
            this.dgvBitacoraComercial.AllowUserToDeleteRows = false;
            this.dgvBitacoraComercial.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBitacoraComercial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBitacoraComercial.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdBitacoraComercial,
            this.IdSocio,
            this.vcSocio,
            this.IdTipoBitacora_tt_Dsc,
            this.Descripcion,
            this.FechaRegistro,
            this.FechaAlerta,
            this.DiasVenc,
            this.Vencimiento,
            this.IdEstado_tt_Dsc,
            this.IdGestor_Dsc,
            this.btnAtender,
            this.ColorRow});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBitacoraComercial.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvBitacoraComercial.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvBitacoraComercial.Location = new System.Drawing.Point(0, 91);
            this.dgvBitacoraComercial.Name = "dgvBitacoraComercial";
            this.dgvBitacoraComercial.RowHeadersWidth = 10;
            this.dgvBitacoraComercial.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvBitacoraComercial.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvBitacoraComercial.Size = new System.Drawing.Size(1268, 461);
            this.dgvBitacoraComercial.TabIndex = 61;
            this.dgvBitacoraComercial.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBitacoraComercial_CellClick);
            this.dgvBitacoraComercial.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvBitacoraComercial_CellFormatting);
            // 
            // IdBitacoraComercial
            // 
            this.IdBitacoraComercial.DataPropertyName = "IdBitacoraComercial";
            this.IdBitacoraComercial.HeaderText = "IdBitacoraComercial";
            this.IdBitacoraComercial.Name = "IdBitacoraComercial";
            this.IdBitacoraComercial.ReadOnly = true;
            this.IdBitacoraComercial.Visible = false;
            // 
            // IdSocio
            // 
            this.IdSocio.DataPropertyName = "IdSocio";
            this.IdSocio.HeaderText = "IdSocio";
            this.IdSocio.Name = "IdSocio";
            this.IdSocio.ReadOnly = true;
            this.IdSocio.Width = 120;
            // 
            // vcSocio
            // 
            this.vcSocio.DataPropertyName = "vcSocio";
            this.vcSocio.HeaderText = "Socio";
            this.vcSocio.Name = "vcSocio";
            this.vcSocio.ReadOnly = true;
            this.vcSocio.Width = 200;
            // 
            // IdTipoBitacora_tt_Dsc
            // 
            this.IdTipoBitacora_tt_Dsc.DataPropertyName = "IdTipoBitacora_tt_Dsc";
            this.IdTipoBitacora_tt_Dsc.HeaderText = "Tipo";
            this.IdTipoBitacora_tt_Dsc.Name = "IdTipoBitacora_tt_Dsc";
            this.IdTipoBitacora_tt_Dsc.ReadOnly = true;
            this.IdTipoBitacora_tt_Dsc.Width = 150;
            // 
            // Descripcion
            // 
            this.Descripcion.DataPropertyName = "Descripcion";
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.Visible = false;
            // 
            // FechaRegistro
            // 
            this.FechaRegistro.DataPropertyName = "FechaRegistro";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Format = "g";
            dataGridViewCellStyle1.NullValue = null;
            this.FechaRegistro.DefaultCellStyle = dataGridViewCellStyle1;
            this.FechaRegistro.HeaderText = "Fecha Registro";
            this.FechaRegistro.Name = "FechaRegistro";
            this.FechaRegistro.ReadOnly = true;
            this.FechaRegistro.Width = 125;
            // 
            // FechaAlerta
            // 
            this.FechaAlerta.DataPropertyName = "FechaAlerta";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Format = "f";
            dataGridViewCellStyle2.NullValue = null;
            this.FechaAlerta.DefaultCellStyle = dataGridViewCellStyle2;
            this.FechaAlerta.HeaderText = "Fecha Programada";
            this.FechaAlerta.Name = "FechaAlerta";
            this.FechaAlerta.ReadOnly = true;
            this.FechaAlerta.Width = 150;
            // 
            // DiasVenc
            // 
            this.DiasVenc.DataPropertyName = "DiasVenc";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DiasVenc.DefaultCellStyle = dataGridViewCellStyle3;
            this.DiasVenc.HeaderText = "Días Venc.";
            this.DiasVenc.Name = "DiasVenc";
            this.DiasVenc.Width = 60;
            // 
            // Vencimiento
            // 
            this.Vencimiento.DataPropertyName = "Vencimiento";
            this.Vencimiento.HeaderText = "Vence En";
            this.Vencimiento.Name = "Vencimiento";
            this.Vencimiento.ReadOnly = true;
            // 
            // IdEstado_tt_Dsc
            // 
            this.IdEstado_tt_Dsc.DataPropertyName = "IdEstado_tt_Dsc";
            this.IdEstado_tt_Dsc.HeaderText = "Estado";
            this.IdEstado_tt_Dsc.Name = "IdEstado_tt_Dsc";
            this.IdEstado_tt_Dsc.ReadOnly = true;
            this.IdEstado_tt_Dsc.Width = 80;
            // 
            // IdGestor_Dsc
            // 
            this.IdGestor_Dsc.DataPropertyName = "IdGestor_Dsc";
            this.IdGestor_Dsc.HeaderText = "Gestor";
            this.IdGestor_Dsc.Name = "IdGestor_Dsc";
            this.IdGestor_Dsc.Width = 200;
            // 
            // btnAtender
            // 
            this.btnAtender.DataPropertyName = "btnAtender";
            this.btnAtender.HeaderText = "";
            this.btnAtender.Name = "btnAtender";
            this.btnAtender.Text = "Atender";
            this.btnAtender.UseColumnTextForButtonValue = true;
            this.btnAtender.Width = 60;
            // 
            // ColorRow
            // 
            this.ColorRow.DataPropertyName = "ColorRow";
            this.ColorRow.HeaderText = "ColorRow";
            this.ColorRow.Name = "ColorRow";
            this.ColorRow.Visible = false;
            // 
            // frmBitacoraComercial
            // 
            this.ClientSize = new System.Drawing.Size(1282, 620);
            this.DoubleBuffered = true;
            this.Name = "frmBitacoraComercial";
            this.Text = "Bitacora Comercial";
            this.Load += new System.EventHandler(this.frmBitacoraComercial_Load);
            this.grpDato.ResumeLayout(false);
            this.panelEx2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBitacoraComercial)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected DevComponents.DotNetBar.PanelEx panelEx2;
        protected DevComponents.DotNetBar.LabelX lblRegistros;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvBitacoraComercial;
        private DevComponents.DotNetBar.ButtonX btnVentas;
        protected DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboEjecutivo;
        private DevComponents.Editors.ComboItem comboItem1;
        protected DevComponents.DotNetBar.ButtonX btnBuscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdBitacoraComercial;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdSocio;
        private System.Windows.Forms.DataGridViewTextBoxColumn vcSocio;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdTipoBitacora_tt_Dsc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaAlerta;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiasVenc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vencimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdEstado_tt_Dsc;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdGestor_Dsc;
        private DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn btnAtender;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColorRow;
    }
}