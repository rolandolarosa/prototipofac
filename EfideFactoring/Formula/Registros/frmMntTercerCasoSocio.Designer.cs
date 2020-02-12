namespace EfideFactoring.Formula.Registros
{
    partial class frmMntTercerCasoSocio
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.lblEmpresa = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.btnBusquedaSocio = new DevComponents.DotNetBar.ButtonX();
            this.txtRazonSocialSocio = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtIdSocio = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnAgregar = new DevComponents.DotNetBar.ButtonX();
            this.dgvDatos = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.RibbonBar1 = new DevComponents.DotNetBar.RibbonBar();
            this.btnEliminar = new DevComponents.DotNetBar.ButtonItem();
            this.btnSalir = new DevComponents.DotNetBar.ButtonItem();
            this.lblEmpresaNombre = new DevComponents.DotNetBar.LabelX();
            this.IdTercerCaso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdSocio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdSocio_Dsc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ruc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RazonSocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.lblEmpresaNombre);
            this.groupPanel1.Controls.Add(this.btnAgregar);
            this.groupPanel1.Controls.Add(this.btnBusquedaSocio);
            this.groupPanel1.Controls.Add(this.txtRazonSocialSocio);
            this.groupPanel1.Controls.Add(this.txtIdSocio);
            this.groupPanel1.Controls.Add(this.labelX2);
            this.groupPanel1.Location = new System.Drawing.Point(2, 46);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(535, 69);
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
            // lblEmpresa
            // 
            this.lblEmpresa.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lblEmpresa.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpresa.ForeColor = System.Drawing.Color.Black;
            this.lblEmpresa.Location = new System.Drawing.Point(119, 3);
            this.lblEmpresa.Name = "lblEmpresa";
            this.lblEmpresa.Size = new System.Drawing.Size(385, 23);
            this.lblEmpresa.TabIndex = 0;
            this.lblEmpresa.Text = "Empresa";
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(8, 33);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(74, 23);
            this.labelX2.TabIndex = 1;
            this.labelX2.Text = "Socio";
            // 
            // btnBusquedaSocio
            // 
            this.btnBusquedaSocio.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnBusquedaSocio.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnBusquedaSocio.Location = new System.Drawing.Point(361, 33);
            this.btnBusquedaSocio.Name = "btnBusquedaSocio";
            this.btnBusquedaSocio.Size = new System.Drawing.Size(31, 20);
            this.btnBusquedaSocio.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnBusquedaSocio.TabIndex = 10;
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
            this.txtRazonSocialSocio.Location = new System.Drawing.Point(167, 33);
            this.txtRazonSocialSocio.Name = "txtRazonSocialSocio";
            this.txtRazonSocialSocio.ReadOnly = true;
            this.txtRazonSocialSocio.Size = new System.Drawing.Size(191, 20);
            this.txtRazonSocialSocio.TabIndex = 9;
            this.txtRazonSocialSocio.TabStop = false;
            // 
            // txtIdSocio
            // 
            // 
            // 
            // 
            this.txtIdSocio.Border.Class = "TextBoxBorder";
            this.txtIdSocio.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtIdSocio.Location = new System.Drawing.Point(60, 33);
            this.txtIdSocio.Name = "txtIdSocio";
            this.txtIdSocio.ReadOnly = true;
            this.txtIdSocio.Size = new System.Drawing.Size(107, 20);
            this.txtIdSocio.TabIndex = 8;
            this.txtIdSocio.TabStop = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAgregar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAgregar.Image = global::EfideFactoring.Properties.Resources.add;
            this.btnAgregar.Location = new System.Drawing.Point(417, 33);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(79, 23);
            this.btnAgregar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAgregar.TabIndex = 11;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
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
            this.IdTercerCaso,
            this.IdSocio,
            this.IdSocio_Dsc,
            this.Ruc,
            this.RazonSocial});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDatos.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDatos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvDatos.Location = new System.Drawing.Point(2, 128);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.ReadOnly = true;
            this.dgvDatos.Size = new System.Drawing.Size(535, 184);
            this.dgvDatos.TabIndex = 1;
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
            this.btnEliminar,
            this.btnSalir});
            this.RibbonBar1.Location = new System.Drawing.Point(0, 0);
            this.RibbonBar1.Name = "RibbonBar1";
            this.RibbonBar1.Size = new System.Drawing.Size(538, 40);
            this.RibbonBar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010;
            this.RibbonBar1.TabIndex = 18;
            // 
            // 
            // 
            this.RibbonBar1.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.RibbonBar1.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // btnEliminar
            // 
            this.btnEliminar.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnEliminar.Image = global::EfideFactoring.Properties.Resources.elimina;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.SubItemsExpandWidth = 14;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
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
            // lblEmpresaNombre
            // 
            this.lblEmpresaNombre.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lblEmpresaNombre.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblEmpresaNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpresaNombre.ForeColor = System.Drawing.Color.Black;
            this.lblEmpresaNombre.Location = new System.Drawing.Point(8, 4);
            this.lblEmpresaNombre.Name = "lblEmpresaNombre";
            this.lblEmpresaNombre.Size = new System.Drawing.Size(384, 23);
            this.lblEmpresaNombre.TabIndex = 12;
            this.lblEmpresaNombre.Text = "Empresa";
            // 
            // IdTercerCaso
            // 
            this.IdTercerCaso.DataPropertyName = "IdTercerCaso";
            this.IdTercerCaso.HeaderText = "IdTercerCaso";
            this.IdTercerCaso.Name = "IdTercerCaso";
            this.IdTercerCaso.ReadOnly = true;
            this.IdTercerCaso.Visible = false;
            // 
            // IdSocio
            // 
            this.IdSocio.DataPropertyName = "IdSocio";
            this.IdSocio.HeaderText = "Código";
            this.IdSocio.Name = "IdSocio";
            this.IdSocio.ReadOnly = true;
            // 
            // IdSocio_Dsc
            // 
            this.IdSocio_Dsc.DataPropertyName = "IdSocio_Dsc";
            this.IdSocio_Dsc.HeaderText = "Socio";
            this.IdSocio_Dsc.Name = "IdSocio_Dsc";
            this.IdSocio_Dsc.ReadOnly = true;
            this.IdSocio_Dsc.Width = 250;
            // 
            // Ruc
            // 
            this.Ruc.DataPropertyName = "Ruc";
            this.Ruc.HeaderText = "Ruc";
            this.Ruc.Name = "Ruc";
            this.Ruc.ReadOnly = true;
            this.Ruc.Visible = false;
            // 
            // RazonSocial
            // 
            this.RazonSocial.DataPropertyName = "RazonSocial";
            this.RazonSocial.HeaderText = "RazonSocial";
            this.RazonSocial.Name = "RazonSocial";
            this.RazonSocial.ReadOnly = true;
            this.RazonSocial.Visible = false;
            // 
            // frmMntTercerCasoSocio
            // 
            this.ClientSize = new System.Drawing.Size(538, 324);
            this.Controls.Add(this.dgvDatos);
            this.Controls.Add(this.groupPanel1);
            this.Controls.Add(this.RibbonBar1);
            this.DoubleBuffered = true;
            this.Name = "frmMntTercerCasoSocio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento Tercer Caso - Socios";
            this.Load += new System.EventHandler(this.frmMntTercerCasoSocio_Load);
            this.groupPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX lblEmpresa;
        private DevComponents.DotNetBar.ButtonX btnBusquedaSocio;
        private DevComponents.DotNetBar.Controls.TextBoxX txtRazonSocialSocio;
        private DevComponents.DotNetBar.Controls.TextBoxX txtIdSocio;
        private DevComponents.DotNetBar.ButtonX btnAgregar;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvDatos;
        protected DevComponents.DotNetBar.RibbonBar RibbonBar1;
        protected DevComponents.DotNetBar.ButtonItem btnEliminar;
        protected DevComponents.DotNetBar.ButtonItem btnSalir;
        private DevComponents.DotNetBar.LabelX lblEmpresaNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdTercerCaso;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdSocio;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdSocio_Dsc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ruc;
        private System.Windows.Forms.DataGridViewTextBoxColumn RazonSocial;
    }
}