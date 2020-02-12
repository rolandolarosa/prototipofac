namespace EfideFactoring.Formula.Catalogo
{
    partial class frmMntPagadora
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
            this.dgvPagadoras = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.txtRuc = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX9 = new DevComponents.DotNetBar.LabelX();
            this.labelX10 = new DevComponents.DotNetBar.LabelX();
            this.IdPagadora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vcPagadora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nLinea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nUtilizado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Saldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdGestor_Dsc = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.FlgIndividualReporte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FlgConvenio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdEstadoLinea_tt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdEstadoLinea_tt_Dsc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaProceso_Dsc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserNew = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateNew = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserEdit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateEdit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PanelEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagadoras)).BeginInit();
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
            this.RibbonBar1.Size = new System.Drawing.Size(1320, 40);
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
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // PanelEx1
            // 
            this.PanelEx1.Controls.Add(this.labelX9);
            this.PanelEx1.Controls.Add(this.labelX10);
            this.PanelEx1.Controls.Add(this.labelX4);
            this.PanelEx1.Controls.Add(this.labelX2);
            this.PanelEx1.Controls.Add(this.txtRuc);
            this.PanelEx1.Controls.Add(this.labelX3);
            this.PanelEx1.Size = new System.Drawing.Size(1320, 57);
            this.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.PanelEx1.Style.GradientAngle = 90;
            this.PanelEx1.Controls.SetChildIndex(this.LabelX1, 0);
            this.PanelEx1.Controls.SetChildIndex(this.labelX3, 0);
            this.PanelEx1.Controls.SetChildIndex(this.TextBoxX1, 0);
            this.PanelEx1.Controls.SetChildIndex(this.btnBuscar, 0);
            this.PanelEx1.Controls.SetChildIndex(this.btnLimpiar, 0);
            this.PanelEx1.Controls.SetChildIndex(this.txtRuc, 0);
            this.PanelEx1.Controls.SetChildIndex(this.labelX2, 0);
            this.PanelEx1.Controls.SetChildIndex(this.labelX4, 0);
            this.PanelEx1.Controls.SetChildIndex(this.labelX10, 0);
            this.PanelEx1.Controls.SetChildIndex(this.labelX9, 0);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(3467, 5);
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(404, 6);
            this.btnBuscar.Size = new System.Drawing.Size(73, 43);
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // TextBoxX1
            // 
            // 
            // 
            // 
            this.TextBoxX1.Border.Class = "TextBoxBorder";
            this.TextBoxX1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TextBoxX1.Location = new System.Drawing.Point(16, 24);
            // 
            // LabelX1
            // 
            // 
            // 
            // 
            this.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LabelX1.Location = new System.Drawing.Point(16, 4);
            this.LabelX1.Text = "Pagadora";
            // 
            // lblGrilla
            // 
            // 
            // 
            // 
            this.lblGrilla.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblGrilla.Location = new System.Drawing.Point(0, 97);
            this.lblGrilla.Text = "Pagadoras";
            // 
            // lblRegistros
            // 
            // 
            // 
            // 
            this.lblRegistros.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblRegistros.Location = new System.Drawing.Point(1144, 97);
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
            this.nLinea,
            this.nUtilizado,
            this.Saldo,
            this.IdGestor_Dsc,
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
            this.FlgIndividualReporte,
            this.FlgConvenio,
            this.IdEstadoLinea_tt,
            this.IdEstadoLinea_tt_Dsc,
            this.FechaProceso_Dsc,
            this.UserNew,
            this.DateNew,
            this.UserEdit,
            this.DateEdit,
            this.Status});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPagadoras.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvPagadoras.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvPagadoras.Location = new System.Drawing.Point(0, 123);
            this.dgvPagadoras.Name = "dgvPagadoras";
            this.dgvPagadoras.ReadOnly = true;
            this.dgvPagadoras.RowHeadersWidth = 10;
            this.dgvPagadoras.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvPagadoras.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvPagadoras.Size = new System.Drawing.Size(1320, 428);
            this.dgvPagadoras.TabIndex = 22;
            this.dgvPagadoras.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvPagadoras_ColumnHeaderMouseClick);
            // 
            // txtRuc
            // 
            // 
            // 
            // 
            this.txtRuc.Border.Class = "TextBoxBorder";
            this.txtRuc.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtRuc.Location = new System.Drawing.Point(230, 24);
            this.txtRuc.MaxLength = 11;
            this.txtRuc.Name = "txtRuc";
            this.txtRuc.Size = new System.Drawing.Size(167, 20);
            this.txtRuc.TabIndex = 8;
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelX3.Location = new System.Drawing.Point(230, 4);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(59, 23);
            this.labelX3.TabIndex = 9;
            this.labelX3.Text = "RUC";
            // 
            // labelX2
            // 
            this.labelX2.AutoSize = true;
            this.labelX2.BackColor = System.Drawing.Color.Red;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.ForeColor = System.Drawing.Color.Red;
            this.labelX2.Location = new System.Drawing.Point(577, 29);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(26, 15);
            this.labelX2.TabIndex = 10;
            this.labelX2.Text = "RUC";
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX4.ForeColor = System.Drawing.Color.Red;
            this.labelX4.Location = new System.Drawing.Point(609, 24);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(59, 23);
            this.labelX4.TabIndex = 11;
            this.labelX4.Text = "Bloqueado";
            // 
            // labelX9
            // 
            this.labelX9.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX9.ForeColor = System.Drawing.Color.Blue;
            this.labelX9.Location = new System.Drawing.Point(706, 23);
            this.labelX9.Name = "labelX9";
            this.labelX9.Size = new System.Drawing.Size(59, 23);
            this.labelX9.TabIndex = 32;
            this.labelX9.Text = "Inactiva";
            // 
            // labelX10
            // 
            this.labelX10.AutoSize = true;
            this.labelX10.BackColor = System.Drawing.Color.Blue;
            // 
            // 
            // 
            this.labelX10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX10.ForeColor = System.Drawing.Color.Blue;
            this.labelX10.Location = new System.Drawing.Point(674, 28);
            this.labelX10.Name = "labelX10";
            this.labelX10.Size = new System.Drawing.Size(26, 15);
            this.labelX10.TabIndex = 31;
            this.labelX10.Text = "RUC";
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
            // nLinea
            // 
            this.nLinea.DataPropertyName = "nLinea";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = null;
            this.nLinea.DefaultCellStyle = dataGridViewCellStyle1;
            this.nLinea.HeaderText = "Linea";
            this.nLinea.Name = "nLinea";
            this.nLinea.ReadOnly = true;
            this.nLinea.Width = 58;
            // 
            // nUtilizado
            // 
            this.nUtilizado.DataPropertyName = "nUtilizado";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.nUtilizado.DefaultCellStyle = dataGridViewCellStyle2;
            this.nUtilizado.HeaderText = "Utilizado";
            this.nUtilizado.Name = "nUtilizado";
            this.nUtilizado.ReadOnly = true;
            this.nUtilizado.Width = 72;
            // 
            // Saldo
            // 
            this.Saldo.DataPropertyName = "Saldo";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.Saldo.DefaultCellStyle = dataGridViewCellStyle3;
            this.Saldo.HeaderText = "Saldo";
            this.Saldo.Name = "Saldo";
            this.Saldo.ReadOnly = true;
            this.Saldo.Width = 59;
            // 
            // IdGestor_Dsc
            // 
            this.IdGestor_Dsc.DataPropertyName = "IdGestor_Dsc";
            this.IdGestor_Dsc.HeaderText = "Gestor";
            this.IdGestor_Dsc.Name = "IdGestor_Dsc";
            this.IdGestor_Dsc.ReadOnly = true;
            this.IdGestor_Dsc.Width = 63;
            // 
            // vcNComercial
            // 
            this.vcNComercial.DataPropertyName = "vcNComercial";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = null;
            this.vcNComercial.DefaultCellStyle = dataGridViewCellStyle4;
            this.vcNComercial.HeaderText = "Nombre Comercial";
            this.vcNComercial.Name = "vcNComercial";
            this.vcNComercial.ReadOnly = true;
            this.vcNComercial.Visible = false;
            this.vcNComercial.Width = 118;
            // 
            // vcNombreCPagadora
            // 
            this.vcNombreCPagadora.DataPropertyName = "vcNombreCPagadora";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "N2";
            dataGridViewCellStyle5.NullValue = null;
            this.vcNombreCPagadora.DefaultCellStyle = dataGridViewCellStyle5;
            this.vcNombreCPagadora.HeaderText = "Nombre Corto";
            this.vcNombreCPagadora.Name = "vcNombreCPagadora";
            this.vcNombreCPagadora.ReadOnly = true;
            this.vcNombreCPagadora.Visible = false;
            this.vcNombreCPagadora.Width = 97;
            // 
            // bNacional
            // 
            this.bNacional.DataPropertyName = "bNacional";
            this.bNacional.HeaderText = "Nacional";
            this.bNacional.Name = "bNacional";
            this.bNacional.ReadOnly = true;
            this.bNacional.Width = 55;
            // 
            // vcRuc
            // 
            this.vcRuc.DataPropertyName = "vcRuc";
            this.vcRuc.HeaderText = "Ruc";
            this.vcRuc.Name = "vcRuc";
            this.vcRuc.ReadOnly = true;
            this.vcRuc.Width = 52;
            // 
            // vcPartida
            // 
            this.vcPartida.DataPropertyName = "vcPartida";
            this.vcPartida.HeaderText = "Partida";
            this.vcPartida.Name = "vcPartida";
            this.vcPartida.ReadOnly = true;
            this.vcPartida.Width = 65;
            // 
            // dtFechaInicio
            // 
            this.dtFechaInicio.DataPropertyName = "dtFechaInicio";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Format = "d";
            dataGridViewCellStyle6.NullValue = null;
            this.dtFechaInicio.DefaultCellStyle = dataGridViewCellStyle6;
            this.dtFechaInicio.HeaderText = "Fecha de Inicio";
            this.dtFechaInicio.Name = "dtFechaInicio";
            this.dtFechaInicio.ReadOnly = true;
            this.dtFechaInicio.Width = 74;
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
            this.IdRiesgo_tt_Dsc.Width = 65;
            // 
            // vcDireccion
            // 
            this.vcDireccion.DataPropertyName = "vcDireccion";
            this.vcDireccion.HeaderText = "Dirección";
            this.vcDireccion.Name = "vcDireccion";
            this.vcDireccion.ReadOnly = true;
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
            this.vcReferencia.Width = 84;
            // 
            // FlgIndividualReporte
            // 
            this.FlgIndividualReporte.DataPropertyName = "FlgIndividualReporte";
            this.FlgIndividualReporte.HeaderText = "FlgIndividualReporte";
            this.FlgIndividualReporte.Name = "FlgIndividualReporte";
            this.FlgIndividualReporte.ReadOnly = true;
            this.FlgIndividualReporte.Visible = false;
            this.FlgIndividualReporte.Width = 129;
            // 
            // FlgConvenio
            // 
            this.FlgConvenio.DataPropertyName = "FlgConvenio";
            this.FlgConvenio.HeaderText = "FlgConvenio";
            this.FlgConvenio.Name = "FlgConvenio";
            this.FlgConvenio.ReadOnly = true;
            this.FlgConvenio.Visible = false;
            this.FlgConvenio.Width = 91;
            // 
            // IdEstadoLinea_tt
            // 
            this.IdEstadoLinea_tt.DataPropertyName = "IdEstadoLinea_tt";
            this.IdEstadoLinea_tt.HeaderText = "IdEstadoLinea_tt";
            this.IdEstadoLinea_tt.Name = "IdEstadoLinea_tt";
            this.IdEstadoLinea_tt.ReadOnly = true;
            this.IdEstadoLinea_tt.Visible = false;
            this.IdEstadoLinea_tt.Width = 112;
            // 
            // IdEstadoLinea_tt_Dsc
            // 
            this.IdEstadoLinea_tt_Dsc.DataPropertyName = "IdEstadoLinea_tt_Dsc";
            this.IdEstadoLinea_tt_Dsc.HeaderText = "IdEstadoLinea_tt_Dsc";
            this.IdEstadoLinea_tt_Dsc.Name = "IdEstadoLinea_tt_Dsc";
            this.IdEstadoLinea_tt_Dsc.ReadOnly = true;
            this.IdEstadoLinea_tt_Dsc.Visible = false;
            this.IdEstadoLinea_tt_Dsc.Width = 137;
            // 
            // FechaProceso_Dsc
            // 
            this.FechaProceso_Dsc.DataPropertyName = "FechaProceso_Dsc";
            this.FechaProceso_Dsc.HeaderText = "FechaProceso_Dsc";
            this.FechaProceso_Dsc.Name = "FechaProceso_Dsc";
            this.FechaProceso_Dsc.ReadOnly = true;
            this.FechaProceso_Dsc.Visible = false;
            this.FechaProceso_Dsc.Width = 126;
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
            // frmMntPagadora
            // 
            this.AcceptButton = this.btnBuscar;
            this.ClientSize = new System.Drawing.Size(1320, 552);
            this.Controls.Add(this.dgvPagadoras);
            this.DoubleBuffered = true;
            this.Name = "frmMntPagadora";
            this.Text = "Pagadoras";
            this.Controls.SetChildIndex(this.RibbonBar1, 0);
            this.Controls.SetChildIndex(this.PanelEx1, 0);
            this.Controls.SetChildIndex(this.lblRegistros, 0);
            this.Controls.SetChildIndex(this.lblGrilla, 0);
            this.Controls.SetChildIndex(this.dgvPagadoras, 0);
            this.PanelEx1.ResumeLayout(false);
            this.PanelEx1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagadoras)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX dgvPagadoras;
        private DevComponents.DotNetBar.Controls.TextBoxX txtRuc;
        protected DevComponents.DotNetBar.LabelX labelX3;
        protected DevComponents.DotNetBar.LabelX labelX4;
        protected DevComponents.DotNetBar.LabelX labelX2;
        protected DevComponents.DotNetBar.LabelX labelX9;
        protected DevComponents.DotNetBar.LabelX labelX10;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdPagadora;
        private System.Windows.Forms.DataGridViewTextBoxColumn vcPagadora;
        private System.Windows.Forms.DataGridViewTextBoxColumn nLinea;
        private System.Windows.Forms.DataGridViewTextBoxColumn nUtilizado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Saldo;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdGestor_Dsc;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn FlgIndividualReporte;
        private System.Windows.Forms.DataGridViewTextBoxColumn FlgConvenio;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdEstadoLinea_tt;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdEstadoLinea_tt_Dsc;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaProceso_Dsc;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserNew;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateNew;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserEdit;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateEdit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
    }
}