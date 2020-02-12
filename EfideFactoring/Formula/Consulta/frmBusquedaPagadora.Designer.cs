namespace EfideFactoring.Formula.Consulta
{
    partial class frmBusquedaPagadora
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
            this.dgvPagadoras = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.IdPagadora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vcPagadora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vcNComercial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vcNombreCPagadora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bNacional = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.vcRuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vcPartida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtFechaInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdSector_tt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdSector_tt_Dsc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdRiesgo_tt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdRiesgo_tt_Dsc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vcDireccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdUbigeo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vcReferencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserNew = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateNew = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserEdit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateEdit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PanelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.btnLimpiar = new DevComponents.DotNetBar.ButtonX();
            this.txtvcPagadora = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnBuscar = new DevComponents.DotNetBar.ButtonX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.RibbonBar1 = new DevComponents.DotNetBar.RibbonBar();
            this.btnSalir = new DevComponents.DotNetBar.ButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagadoras)).BeginInit();
            this.PanelEx1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPagadoras
            // 
            this.dgvPagadoras.AllowUserToAddRows = false;
            this.dgvPagadoras.AllowUserToDeleteRows = false;
            this.dgvPagadoras.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPagadoras.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvPagadoras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPagadoras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdPagadora,
            this.vcPagadora,
            this.vcNComercial,
            this.vcNombreCPagadora,
            this.bNacional,
            this.vcRuc,
            this.vcPartida,
            this.dtFechaInicio,
            this.IdSector_tt,
            this.IdSector_tt_Dsc,
            this.IdRiesgo_tt,
            this.IdRiesgo_tt_Dsc,
            this.vcDireccion,
            this.IdUbigeo,
            this.vcReferencia,
            this.UserNew,
            this.DateNew,
            this.UserEdit,
            this.DateEdit,
            this.Status});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPagadoras.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPagadoras.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvPagadoras.Location = new System.Drawing.Point(0, 113);
            this.dgvPagadoras.Name = "dgvPagadoras";
            this.dgvPagadoras.ReadOnly = true;
            this.dgvPagadoras.RowHeadersWidth = 10;
            this.dgvPagadoras.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvPagadoras.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvPagadoras.Size = new System.Drawing.Size(504, 221);
            this.dgvPagadoras.TabIndex = 30;
            this.dgvPagadoras.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPagadoras_CellContentDoubleClick);
            // 
            // IdPagadora
            // 
            this.IdPagadora.DataPropertyName = "IdPagadora";
            this.IdPagadora.HeaderText = "Código";
            this.IdPagadora.Name = "IdPagadora";
            this.IdPagadora.ReadOnly = true;
            this.IdPagadora.Width = 65;
            // 
            // vcPagadora
            // 
            this.vcPagadora.DataPropertyName = "vcPagadora";
            this.vcPagadora.HeaderText = "Pagadora";
            this.vcPagadora.Name = "vcPagadora";
            this.vcPagadora.ReadOnly = true;
            this.vcPagadora.Width = 78;
            // 
            // vcNComercial
            // 
            this.vcNComercial.DataPropertyName = "vcNComercial";
            this.vcNComercial.HeaderText = "Nombre Comercial";
            this.vcNComercial.Name = "vcNComercial";
            this.vcNComercial.ReadOnly = true;
            this.vcNComercial.Visible = false;
            this.vcNComercial.Width = 118;
            // 
            // vcNombreCPagadora
            // 
            this.vcNombreCPagadora.DataPropertyName = "vcNombreCPagadora";
            this.vcNombreCPagadora.HeaderText = "vcNombreCPagadora";
            this.vcNombreCPagadora.Name = "vcNombreCPagadora";
            this.vcNombreCPagadora.ReadOnly = true;
            this.vcNombreCPagadora.Visible = false;
            this.vcNombreCPagadora.Width = 134;
            // 
            // bNacional
            // 
            this.bNacional.DataPropertyName = "bNacional";
            this.bNacional.HeaderText = "Nacional";
            this.bNacional.Name = "bNacional";
            this.bNacional.ReadOnly = true;
            this.bNacional.Visible = false;
            this.bNacional.Width = 55;
            // 
            // vcRuc
            // 
            this.vcRuc.DataPropertyName = "vcRuc";
            this.vcRuc.HeaderText = "Ruc";
            this.vcRuc.Name = "vcRuc";
            this.vcRuc.ReadOnly = true;
            this.vcRuc.Visible = false;
            this.vcRuc.Width = 52;
            // 
            // vcPartida
            // 
            this.vcPartida.DataPropertyName = "vcPartida";
            this.vcPartida.HeaderText = "Partida";
            this.vcPartida.Name = "vcPartida";
            this.vcPartida.ReadOnly = true;
            this.vcPartida.Visible = false;
            this.vcPartida.Width = 65;
            // 
            // dtFechaInicio
            // 
            this.dtFechaInicio.DataPropertyName = "dtFechaInicio";
            this.dtFechaInicio.HeaderText = "Fecha de Inicio";
            this.dtFechaInicio.Name = "dtFechaInicio";
            this.dtFechaInicio.ReadOnly = true;
            this.dtFechaInicio.Visible = false;
            this.dtFechaInicio.Width = 105;
            // 
            // IdSector_tt
            // 
            this.IdSector_tt.DataPropertyName = "IdSector_tt";
            this.IdSector_tt.HeaderText = "IdSector_tt";
            this.IdSector_tt.Name = "IdSector_tt";
            this.IdSector_tt.ReadOnly = true;
            this.IdSector_tt.Visible = false;
            this.IdSector_tt.Width = 84;
            // 
            // IdSector_tt_Dsc
            // 
            this.IdSector_tt_Dsc.DataPropertyName = "IdSector_tt_Dsc";
            this.IdSector_tt_Dsc.HeaderText = "Sector";
            this.IdSector_tt_Dsc.Name = "IdSector_tt_Dsc";
            this.IdSector_tt_Dsc.ReadOnly = true;
            this.IdSector_tt_Dsc.Visible = false;
            this.IdSector_tt_Dsc.Width = 63;
            // 
            // IdRiesgo_tt
            // 
            this.IdRiesgo_tt.DataPropertyName = "IdRiesgo_tt";
            this.IdRiesgo_tt.HeaderText = "IdRiesgo_tt";
            this.IdRiesgo_tt.Name = "IdRiesgo_tt";
            this.IdRiesgo_tt.ReadOnly = true;
            this.IdRiesgo_tt.Visible = false;
            this.IdRiesgo_tt.Width = 86;
            // 
            // IdRiesgo_tt_Dsc
            // 
            this.IdRiesgo_tt_Dsc.DataPropertyName = "IdRiesgo_tt_Dsc";
            this.IdRiesgo_tt_Dsc.HeaderText = "Riesgo";
            this.IdRiesgo_tt_Dsc.Name = "IdRiesgo_tt_Dsc";
            this.IdRiesgo_tt_Dsc.ReadOnly = true;
            this.IdRiesgo_tt_Dsc.Visible = false;
            this.IdRiesgo_tt_Dsc.Width = 65;
            // 
            // vcDireccion
            // 
            this.vcDireccion.DataPropertyName = "vcDireccion";
            this.vcDireccion.HeaderText = "Dirección";
            this.vcDireccion.Name = "vcDireccion";
            this.vcDireccion.ReadOnly = true;
            this.vcDireccion.Visible = false;
            this.vcDireccion.Width = 77;
            // 
            // IdUbigeo
            // 
            this.IdUbigeo.DataPropertyName = "IdUbigeo";
            this.IdUbigeo.HeaderText = "IdUbigeo";
            this.IdUbigeo.Name = "IdUbigeo";
            this.IdUbigeo.ReadOnly = true;
            this.IdUbigeo.Visible = false;
            this.IdUbigeo.Width = 75;
            // 
            // vcReferencia
            // 
            this.vcReferencia.DataPropertyName = "vcReferencia";
            this.vcReferencia.HeaderText = "Referencia";
            this.vcReferencia.Name = "vcReferencia";
            this.vcReferencia.ReadOnly = true;
            this.vcReferencia.Visible = false;
            this.vcReferencia.Width = 84;
            // 
            // UserNew
            // 
            this.UserNew.DataPropertyName = "UserNew";
            this.UserNew.HeaderText = "UserNew";
            this.UserNew.Name = "UserNew";
            this.UserNew.ReadOnly = true;
            this.UserNew.Visible = false;
            this.UserNew.Width = 76;
            // 
            // DateNew
            // 
            this.DateNew.DataPropertyName = "DateNew";
            this.DateNew.HeaderText = "DateNew";
            this.DateNew.Name = "DateNew";
            this.DateNew.ReadOnly = true;
            this.DateNew.Visible = false;
            this.DateNew.Width = 77;
            // 
            // UserEdit
            // 
            this.UserEdit.DataPropertyName = "UserEdit";
            this.UserEdit.HeaderText = "UserEdit";
            this.UserEdit.Name = "UserEdit";
            this.UserEdit.ReadOnly = true;
            this.UserEdit.Visible = false;
            this.UserEdit.Width = 72;
            // 
            // DateEdit
            // 
            this.DateEdit.DataPropertyName = "DateEdit";
            this.DateEdit.HeaderText = "DateEdit";
            this.DateEdit.Name = "DateEdit";
            this.DateEdit.ReadOnly = true;
            this.DateEdit.Visible = false;
            this.DateEdit.Width = 73;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Visible = false;
            this.Status.Width = 62;
            // 
            // PanelEx1
            // 
            this.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2010;
            this.PanelEx1.Controls.Add(this.btnLimpiar);
            this.PanelEx1.Controls.Add(this.txtvcPagadora);
            this.PanelEx1.Controls.Add(this.btnBuscar);
            this.PanelEx1.Controls.Add(this.labelX1);
            this.PanelEx1.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelEx1.Location = new System.Drawing.Point(0, 40);
            this.PanelEx1.Name = "PanelEx1";
            this.PanelEx1.Size = new System.Drawing.Size(504, 58);
            this.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.PanelEx1.Style.GradientAngle = 90;
            this.PanelEx1.TabIndex = 29;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnLimpiar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnLimpiar.Image = global::EfideFactoring.Properties.Resources.magifier_zoom_out;
            this.btnLimpiar.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnLimpiar.Location = new System.Drawing.Point(393, 5);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(73, 44);
            this.btnLimpiar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnLimpiar.TabIndex = 3;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // txtvcPagadora
            // 
            // 
            // 
            // 
            this.txtvcPagadora.Border.Class = "TextBoxBorder";
            this.txtvcPagadora.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtvcPagadora.Location = new System.Drawing.Point(75, 17);
            this.txtvcPagadora.Name = "txtvcPagadora";
            this.txtvcPagadora.Size = new System.Drawing.Size(229, 20);
            this.txtvcPagadora.TabIndex = 1;
            // 
            // btnBuscar
            // 
            this.btnBuscar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnBuscar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnBuscar.Image = global::EfideFactoring.Properties.Resources.buscar;
            this.btnBuscar.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnBuscar.Location = new System.Drawing.Point(314, 5);
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
            this.labelX1.Location = new System.Drawing.Point(12, 17);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(57, 23);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "Pagadora";
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
            this.RibbonBar1.Size = new System.Drawing.Size(504, 40);
            this.RibbonBar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010;
            this.RibbonBar1.TabIndex = 28;
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
            // frmBusquedaPagadora
            // 
            this.AcceptButton = this.btnBuscar;
            this.ClientSize = new System.Drawing.Size(504, 347);
            this.Controls.Add(this.dgvPagadoras);
            this.Controls.Add(this.PanelEx1);
            this.Controls.Add(this.RibbonBar1);
            this.DoubleBuffered = true;
            this.Name = "frmBusquedaPagadora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Busqueda de Pagadoras";
            this.Load += new System.EventHandler(this.frmBusquedaPagadora_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagadoras)).EndInit();
            this.PanelEx1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX dgvPagadoras;
        protected DevComponents.DotNetBar.PanelEx PanelEx1;
        protected DevComponents.DotNetBar.ButtonX btnLimpiar;
        private DevComponents.DotNetBar.Controls.TextBoxX txtvcPagadora;
        protected DevComponents.DotNetBar.ButtonX btnBuscar;
        private DevComponents.DotNetBar.LabelX labelX1;
        protected DevComponents.DotNetBar.RibbonBar RibbonBar1;
        protected DevComponents.DotNetBar.ButtonItem btnSalir;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdPagadora;
        private System.Windows.Forms.DataGridViewTextBoxColumn vcPagadora;
        private System.Windows.Forms.DataGridViewTextBoxColumn vcNComercial;
        private System.Windows.Forms.DataGridViewTextBoxColumn vcNombreCPagadora;
        private System.Windows.Forms.DataGridViewCheckBoxColumn bNacional;
        private System.Windows.Forms.DataGridViewTextBoxColumn vcRuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn vcPartida;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtFechaInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdSector_tt;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdSector_tt_Dsc;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdRiesgo_tt;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdRiesgo_tt_Dsc;
        private System.Windows.Forms.DataGridViewTextBoxColumn vcDireccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdUbigeo;
        private System.Windows.Forms.DataGridViewTextBoxColumn vcReferencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserNew;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateNew;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserEdit;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateEdit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
    }
}