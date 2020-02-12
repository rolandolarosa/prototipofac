namespace EfideFactoring.Formula.Legal
{
    partial class frmQrySolicitudCheckList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQrySolicitudCheckList));
            this.dgvCheckList = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.IdSolicitud = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdDocumento_tt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdTipo_tt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdDocumento_tt_Dsc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnVerDoc = new DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn();
            this.lblEntidad = new DevComponents.DotNetBar.LabelX();
            this.grpDato.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheckList)).BeginInit();
            this.SuspendLayout();
            // 
            // grpDato
            // 
            this.grpDato.Controls.Add(this.lblEntidad);
            this.grpDato.Controls.Add(this.dgvCheckList);
            this.grpDato.Size = new System.Drawing.Size(654, 343);
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
            this.btnCancelar.Location = new System.Drawing.Point(573, 364);
            this.btnCancelar.Text = "Cerrar";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(482, 364);
            this.btnAceptar.Visible = false;
            // 
            // dgvCheckList
            // 
            this.dgvCheckList.AllowUserToAddRows = false;
            this.dgvCheckList.AllowUserToDeleteRows = false;
            this.dgvCheckList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCheckList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCheckList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdSolicitud,
            this.IdDocumento_tt,
            this.IdTipo_tt,
            this.dtRegistro,
            this.IdDocumento_tt_Dsc,
            this.vDocumento,
            this.btnVerDoc});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCheckList.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCheckList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvCheckList.Location = new System.Drawing.Point(7, 43);
            this.dgvCheckList.Name = "dgvCheckList";
            this.dgvCheckList.ReadOnly = true;
            this.dgvCheckList.Size = new System.Drawing.Size(636, 283);
            this.dgvCheckList.TabIndex = 1;
            this.dgvCheckList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCheckList_CellClick);
            // 
            // IdSolicitud
            // 
            this.IdSolicitud.DataPropertyName = "IdSolicitud";
            this.IdSolicitud.HeaderText = "IdSolicitud";
            this.IdSolicitud.Name = "IdSolicitud";
            this.IdSolicitud.ReadOnly = true;
            this.IdSolicitud.Visible = false;
            // 
            // IdDocumento_tt
            // 
            this.IdDocumento_tt.DataPropertyName = "IdDocumento_tt";
            this.IdDocumento_tt.HeaderText = "IdDocumento_ttS";
            this.IdDocumento_tt.Name = "IdDocumento_tt";
            this.IdDocumento_tt.ReadOnly = true;
            this.IdDocumento_tt.Visible = false;
            // 
            // IdTipo_tt
            // 
            this.IdTipo_tt.DataPropertyName = "IdTipo_tt";
            this.IdTipo_tt.HeaderText = "IdTipo_ttS";
            this.IdTipo_tt.Name = "IdTipo_tt";
            this.IdTipo_tt.ReadOnly = true;
            this.IdTipo_tt.Visible = false;
            // 
            // dtRegistro
            // 
            this.dtRegistro.DataPropertyName = "dtRegistro";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Format = "g";
            dataGridViewCellStyle1.NullValue = null;
            this.dtRegistro.DefaultCellStyle = dataGridViewCellStyle1;
            this.dtRegistro.HeaderText = "Fecha Registro";
            this.dtRegistro.Name = "dtRegistro";
            this.dtRegistro.ReadOnly = true;
            this.dtRegistro.Width = 120;
            // 
            // IdDocumento_tt_Dsc
            // 
            this.IdDocumento_tt_Dsc.DataPropertyName = "IdDocumento_tt_Dsc";
            this.IdDocumento_tt_Dsc.HeaderText = "Documento";
            this.IdDocumento_tt_Dsc.Name = "IdDocumento_tt_Dsc";
            this.IdDocumento_tt_Dsc.ReadOnly = true;
            this.IdDocumento_tt_Dsc.Width = 300;
            // 
            // vDocumento
            // 
            this.vDocumento.DataPropertyName = "vDocumento";
            this.vDocumento.HeaderText = "vDocumentoS";
            this.vDocumento.Name = "vDocumento";
            this.vDocumento.ReadOnly = true;
            this.vDocumento.Visible = false;
            // 
            // btnVerDoc
            // 
            this.btnVerDoc.HeaderText = "";
            this.btnVerDoc.Image = ((System.Drawing.Image)(resources.GetObject("btnVerDoc.Image")));
            this.btnVerDoc.Name = "btnVerDoc";
            this.btnVerDoc.ReadOnly = true;
            this.btnVerDoc.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btnVerDoc.Text = null;
            this.btnVerDoc.Width = 40;
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
            this.lblEntidad.Location = new System.Drawing.Point(7, 11);
            this.lblEntidad.Name = "lblEntidad";
            this.lblEntidad.Size = new System.Drawing.Size(636, 23);
            this.lblEntidad.TabIndex = 2;
            this.lblEntidad.Text = "labelX1";
            // 
            // frmQrySolicitudCheckList
            // 
            this.ClientSize = new System.Drawing.Size(662, 400);
            this.DoubleBuffered = true;
            this.Name = "frmQrySolicitudCheckList";
            this.Text = "Documentos Adjuntos";
            this.Load += new System.EventHandler(this.frmQrySolicitudCheckList_Load);
            this.grpDato.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheckList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX dgvCheckList;
        private DevComponents.DotNetBar.LabelX lblEntidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdSolicitud;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdDocumento_tt;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdTipo_tt;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdDocumento_tt_Dsc;
        private System.Windows.Forms.DataGridViewTextBoxColumn vDocumento;
        private DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn btnVerDoc;
    }
}