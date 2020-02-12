namespace EfideFactoring.Formula.Legal
{
    partial class frmQrySolicitud
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQrySolicitud));
            this.lblEntidad = new DevComponents.DotNetBar.LabelX();
            this.dgvSolicitud = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.IdSolicitud = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtSolicitud = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdPersonaSolicitud_Dsc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdArea_tt_Dsc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Firmas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProxRevision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iPlazo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdEstado_tt_Dsc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnVerSolicitud = new DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn();
            this.grpDato.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSolicitud)).BeginInit();
            this.SuspendLayout();
            // 
            // grpDato
            // 
            this.grpDato.Controls.Add(this.dgvSolicitud);
            this.grpDato.Controls.Add(this.lblEntidad);
            this.grpDato.Size = new System.Drawing.Size(946, 371);
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
            this.btnCancelar.Location = new System.Drawing.Point(865, 392);
            this.btnCancelar.Text = "Cerrar";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(774, 392);
            this.btnAceptar.Visible = false;
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
            this.lblEntidad.Location = new System.Drawing.Point(9, 14);
            this.lblEntidad.Name = "lblEntidad";
            this.lblEntidad.Size = new System.Drawing.Size(926, 23);
            this.lblEntidad.TabIndex = 3;
            this.lblEntidad.Text = "labelX1";
            // 
            // dgvSolicitud
            // 
            this.dgvSolicitud.AllowUserToAddRows = false;
            this.dgvSolicitud.AllowUserToDeleteRows = false;
            this.dgvSolicitud.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSolicitud.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSolicitud.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdSolicitud,
            this.dtSolicitud,
            this.IdPersonaSolicitud_Dsc,
            this.IdArea_tt_Dsc,
            this.Firmas,
            this.ProxRevision,
            this.iPlazo,
            this.IdEstado_tt_Dsc,
            this.btnVerSolicitud});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSolicitud.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSolicitud.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvSolicitud.Location = new System.Drawing.Point(9, 43);
            this.dgvSolicitud.Name = "dgvSolicitud";
            this.dgvSolicitud.ReadOnly = true;
            this.dgvSolicitud.Size = new System.Drawing.Size(926, 307);
            this.dgvSolicitud.TabIndex = 4;
            this.dgvSolicitud.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSolicitud_CellClick);
            // 
            // IdSolicitud
            // 
            this.IdSolicitud.DataPropertyName = "IdSolicitud";
            this.IdSolicitud.HeaderText = "Nro. Solicitud";
            this.IdSolicitud.Name = "IdSolicitud";
            this.IdSolicitud.ReadOnly = true;
            this.IdSolicitud.Width = 80;
            // 
            // dtSolicitud
            // 
            this.dtSolicitud.DataPropertyName = "dtSolicitud";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.dtSolicitud.DefaultCellStyle = dataGridViewCellStyle1;
            this.dtSolicitud.HeaderText = "Fecha";
            this.dtSolicitud.Name = "dtSolicitud";
            this.dtSolicitud.ReadOnly = true;
            // 
            // IdPersonaSolicitud_Dsc
            // 
            this.IdPersonaSolicitud_Dsc.DataPropertyName = "IdPersonaSolicitud_Dsc";
            this.IdPersonaSolicitud_Dsc.HeaderText = "Solicitante";
            this.IdPersonaSolicitud_Dsc.Name = "IdPersonaSolicitud_Dsc";
            this.IdPersonaSolicitud_Dsc.ReadOnly = true;
            this.IdPersonaSolicitud_Dsc.Width = 150;
            // 
            // IdArea_tt_Dsc
            // 
            this.IdArea_tt_Dsc.DataPropertyName = "IdArea_tt_Dsc";
            this.IdArea_tt_Dsc.HeaderText = "Area";
            this.IdArea_tt_Dsc.Name = "IdArea_tt_Dsc";
            this.IdArea_tt_Dsc.ReadOnly = true;
            // 
            // Firmas
            // 
            this.Firmas.DataPropertyName = "Firmas";
            this.Firmas.HeaderText = "Firmas";
            this.Firmas.Name = "Firmas";
            this.Firmas.ReadOnly = true;
            // 
            // ProxRevision
            // 
            this.ProxRevision.DataPropertyName = "ProxRevision";
            this.ProxRevision.HeaderText = "Prox. Revisión";
            this.ProxRevision.Name = "ProxRevision";
            this.ProxRevision.ReadOnly = true;
            // 
            // iPlazo
            // 
            this.iPlazo.DataPropertyName = "iPlazo";
            this.iPlazo.HeaderText = "Plazo";
            this.iPlazo.Name = "iPlazo";
            this.iPlazo.ReadOnly = true;
            // 
            // IdEstado_tt_Dsc
            // 
            this.IdEstado_tt_Dsc.DataPropertyName = "IdEstado_tt_Dsc";
            this.IdEstado_tt_Dsc.HeaderText = "Estado";
            this.IdEstado_tt_Dsc.Name = "IdEstado_tt_Dsc";
            this.IdEstado_tt_Dsc.ReadOnly = true;
            // 
            // btnVerSolicitud
            // 
            this.btnVerSolicitud.HeaderText = "";
            this.btnVerSolicitud.Image = ((System.Drawing.Image)(resources.GetObject("btnVerSolicitud.Image")));
            this.btnVerSolicitud.Name = "btnVerSolicitud";
            this.btnVerSolicitud.ReadOnly = true;
            this.btnVerSolicitud.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btnVerSolicitud.Text = null;
            this.btnVerSolicitud.Width = 40;
            // 
            // frmQrySolicitud
            // 
            this.ClientSize = new System.Drawing.Size(954, 428);
            this.DoubleBuffered = true;
            this.Name = "frmQrySolicitud";
            this.Text = "Historial de Solicitudes";
            this.Load += new System.EventHandler(this.frmQrySolicitud_Load);
            this.grpDato.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSolicitud)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX lblEntidad;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvSolicitud;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdSolicitud;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtSolicitud;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdPersonaSolicitud_Dsc;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdArea_tt_Dsc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Firmas;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProxRevision;
        private System.Windows.Forms.DataGridViewTextBoxColumn iPlazo;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdEstado_tt_Dsc;
        private DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn btnVerSolicitud;
    }
}