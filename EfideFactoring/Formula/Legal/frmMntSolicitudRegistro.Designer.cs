namespace EfideFactoring.Formula.Legal
{
    partial class frmMntSolicitudRegistro
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
            this.dgvRegistro = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.lblEntidad = new DevComponents.DotNetBar.LabelX();
            this.btnAgregar = new DevComponents.DotNetBar.ButtonX();
            this.btnEditar = new DevComponents.DotNetBar.ButtonX();
            this.btnEliminar = new DevComponents.DotNetBar.ButtonX();
            this.IdSolicitud = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdTipoRegistro_tt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdTipoRegistro_tt_Dsc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vTomo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vFicha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vPartida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vLugar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vNroPagina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vEP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vOtro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpDato.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistro)).BeginInit();
            this.SuspendLayout();
            // 
            // grpDato
            // 
            this.grpDato.Controls.Add(this.btnEliminar);
            this.grpDato.Controls.Add(this.btnEditar);
            this.grpDato.Controls.Add(this.btnAgregar);
            this.grpDato.Controls.Add(this.lblEntidad);
            this.grpDato.Controls.Add(this.dgvRegistro);
            this.grpDato.Size = new System.Drawing.Size(1179, 430);
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
            this.btnCancelar.Location = new System.Drawing.Point(1098, 451);
            this.btnCancelar.Text = "Cerrar";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(1007, 451);
            this.btnAceptar.Visible = false;
            // 
            // dgvRegistro
            // 
            this.dgvRegistro.AllowUserToAddRows = false;
            this.dgvRegistro.AllowUserToDeleteRows = false;
            this.dgvRegistro.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRegistro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegistro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdSolicitud,
            this.IdTipoRegistro_tt,
            this.IdTipoRegistro_tt_Dsc,
            this.vTomo,
            this.vFicha,
            this.vPartida,
            this.dtRegistro,
            this.vCC,
            this.vLugar,
            this.vNroPagina,
            this.vEP,
            this.vOtro});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRegistro.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRegistro.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvRegistro.Location = new System.Drawing.Point(5, 75);
            this.dgvRegistro.Name = "dgvRegistro";
            this.dgvRegistro.ReadOnly = true;
            this.dgvRegistro.Size = new System.Drawing.Size(1163, 330);
            this.dgvRegistro.TabIndex = 0;
            // 
            // lblEntidad
            // 
            this.lblEntidad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEntidad.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lblEntidad.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblEntidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntidad.ForeColor = System.Drawing.Color.Black;
            this.lblEntidad.Location = new System.Drawing.Point(5, 17);
            this.lblEntidad.Name = "lblEntidad";
            this.lblEntidad.Size = new System.Drawing.Size(1163, 23);
            this.lblEntidad.TabIndex = 4;
            this.lblEntidad.Text = "labelX1";
            // 
            // btnAgregar
            // 
            this.btnAgregar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAgregar.Image = global::EfideFactoring.Properties.Resources.add;
            this.btnAgregar.Location = new System.Drawing.Point(930, 46);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAgregar.TabIndex = 5;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnEditar.Image = global::EfideFactoring.Properties.Resources.modifica;
            this.btnEditar.Location = new System.Drawing.Point(1011, 46);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnEditar.TabIndex = 6;
            this.btnEditar.Text = "Editar";
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnEliminar.Image = global::EfideFactoring.Properties.Resources.elimina;
            this.btnEliminar.Location = new System.Drawing.Point(1092, 46);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // IdSolicitud
            // 
            this.IdSolicitud.DataPropertyName = "IdSolicitud";
            this.IdSolicitud.HeaderText = "IdSolicitud";
            this.IdSolicitud.Name = "IdSolicitud";
            this.IdSolicitud.ReadOnly = true;
            this.IdSolicitud.Visible = false;
            // 
            // IdTipoRegistro_tt
            // 
            this.IdTipoRegistro_tt.DataPropertyName = "IdTipoRegistro_tt";
            this.IdTipoRegistro_tt.HeaderText = "IdTipoRegistro_tt";
            this.IdTipoRegistro_tt.Name = "IdTipoRegistro_tt";
            this.IdTipoRegistro_tt.ReadOnly = true;
            this.IdTipoRegistro_tt.Visible = false;
            // 
            // IdTipoRegistro_tt_Dsc
            // 
            this.IdTipoRegistro_tt_Dsc.DataPropertyName = "IdTipoRegistro_tt_Dsc";
            this.IdTipoRegistro_tt_Dsc.HeaderText = "Registro";
            this.IdTipoRegistro_tt_Dsc.Name = "IdTipoRegistro_tt_Dsc";
            this.IdTipoRegistro_tt_Dsc.ReadOnly = true;
            this.IdTipoRegistro_tt_Dsc.Width = 150;
            // 
            // vTomo
            // 
            this.vTomo.DataPropertyName = "vTomo";
            this.vTomo.HeaderText = "Tomo";
            this.vTomo.Name = "vTomo";
            this.vTomo.ReadOnly = true;
            this.vTomo.Width = 120;
            // 
            // vFicha
            // 
            this.vFicha.DataPropertyName = "vFicha";
            this.vFicha.HeaderText = "Ficha";
            this.vFicha.Name = "vFicha";
            this.vFicha.ReadOnly = true;
            this.vFicha.Width = 120;
            // 
            // vPartida
            // 
            this.vPartida.DataPropertyName = "vPartida";
            this.vPartida.HeaderText = "Partida";
            this.vPartida.Name = "vPartida";
            this.vPartida.ReadOnly = true;
            this.vPartida.Width = 120;
            // 
            // dtRegistro
            // 
            this.dtRegistro.DataPropertyName = "dtRegistro";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.dtRegistro.DefaultCellStyle = dataGridViewCellStyle1;
            this.dtRegistro.HeaderText = "Fecha";
            this.dtRegistro.Name = "dtRegistro";
            this.dtRegistro.ReadOnly = true;
            this.dtRegistro.Width = 80;
            // 
            // vCC
            // 
            this.vCC.DataPropertyName = "vCC";
            this.vCC.HeaderText = "1 CC";
            this.vCC.Name = "vCC";
            this.vCC.ReadOnly = true;
            this.vCC.Width = 120;
            // 
            // vLugar
            // 
            this.vLugar.DataPropertyName = "vLugar";
            this.vLugar.HeaderText = "Lugar";
            this.vLugar.Name = "vLugar";
            this.vLugar.ReadOnly = true;
            this.vLugar.Width = 80;
            // 
            // vNroPagina
            // 
            this.vNroPagina.DataPropertyName = "vNroPagina";
            this.vNroPagina.HeaderText = "Nro. Página";
            this.vNroPagina.Name = "vNroPagina";
            this.vNroPagina.ReadOnly = true;
            this.vNroPagina.Width = 80;
            // 
            // vEP
            // 
            this.vEP.DataPropertyName = "vEP";
            this.vEP.HeaderText = "2 EP";
            this.vEP.Name = "vEP";
            this.vEP.ReadOnly = true;
            this.vEP.Width = 120;
            // 
            // vOtro
            // 
            this.vOtro.DataPropertyName = "vOtro";
            this.vOtro.HeaderText = "3 Otro";
            this.vOtro.Name = "vOtro";
            this.vOtro.ReadOnly = true;
            this.vOtro.Width = 120;
            // 
            // frmMntSolicitudRegistro
            // 
            this.ClientSize = new System.Drawing.Size(1187, 487);
            this.DoubleBuffered = true;
            this.Name = "frmMntSolicitudRegistro";
            this.Text = "Registro";
            this.Load += new System.EventHandler(this.frmMntSolicitudRegistro_Load);
            this.grpDato.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX dgvRegistro;
        private DevComponents.DotNetBar.LabelX lblEntidad;
        private DevComponents.DotNetBar.ButtonX btnEditar;
        private DevComponents.DotNetBar.ButtonX btnAgregar;
        private DevComponents.DotNetBar.ButtonX btnEliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdSolicitud;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdTipoRegistro_tt;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdTipoRegistro_tt_Dsc;
        private System.Windows.Forms.DataGridViewTextBoxColumn vTomo;
        private System.Windows.Forms.DataGridViewTextBoxColumn vFicha;
        private System.Windows.Forms.DataGridViewTextBoxColumn vPartida;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn vCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn vLugar;
        private System.Windows.Forms.DataGridViewTextBoxColumn vNroPagina;
        private System.Windows.Forms.DataGridViewTextBoxColumn vEP;
        private System.Windows.Forms.DataGridViewTextBoxColumn vOtro;
    }
}