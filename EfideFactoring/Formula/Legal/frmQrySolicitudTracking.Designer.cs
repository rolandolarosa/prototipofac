namespace EfideFactoring.Formula.Legal
{
    partial class frmQrySolicitudTracking
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvSolicitudTracking = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.IdSolicitud = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdTracking = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdTipo_tt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdEstado_tt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdEstado_tt_Nuevo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vComentario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpDato.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSolicitudTracking)).BeginInit();
            this.SuspendLayout();
            // 
            // grpDato
            // 
            this.grpDato.Controls.Add(this.dgvSolicitudTracking);
            this.grpDato.Size = new System.Drawing.Size(792, 427);
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
            this.btnCancelar.Location = new System.Drawing.Point(711, 448);
            this.btnCancelar.Text = "Cerrar";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(620, 448);
            this.btnAceptar.Visible = false;
            // 
            // dgvSolicitudTracking
            // 
            this.dgvSolicitudTracking.AllowUserToAddRows = false;
            this.dgvSolicitudTracking.AllowUserToDeleteRows = false;
            this.dgvSolicitudTracking.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSolicitudTracking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSolicitudTracking.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdSolicitud,
            this.IdTracking,
            this.IdTipo_tt,
            this.dtRegistro,
            this.IdEstado_tt,
            this.IdEstado_tt_Nuevo,
            this.vComentario,
            this.Usuario});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSolicitudTracking.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvSolicitudTracking.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvSolicitudTracking.Location = new System.Drawing.Point(3, 19);
            this.dgvSolicitudTracking.Name = "dgvSolicitudTracking";
            this.dgvSolicitudTracking.ReadOnly = true;
            this.dgvSolicitudTracking.Size = new System.Drawing.Size(778, 399);
            this.dgvSolicitudTracking.TabIndex = 37;
            // 
            // IdSolicitud
            // 
            this.IdSolicitud.DataPropertyName = "IdSolicitud";
            this.IdSolicitud.HeaderText = "IdSolicitud";
            this.IdSolicitud.Name = "IdSolicitud";
            this.IdSolicitud.ReadOnly = true;
            this.IdSolicitud.Visible = false;
            // 
            // IdTracking
            // 
            this.IdTracking.DataPropertyName = "IdTracking";
            this.IdTracking.HeaderText = "IdTracking";
            this.IdTracking.Name = "IdTracking";
            this.IdTracking.ReadOnly = true;
            this.IdTracking.Visible = false;
            // 
            // IdTipo_tt
            // 
            this.IdTipo_tt.DataPropertyName = "IdTipo_tt";
            this.IdTipo_tt.HeaderText = "IdTipo_tt";
            this.IdTipo_tt.Name = "IdTipo_tt";
            this.IdTipo_tt.ReadOnly = true;
            this.IdTipo_tt.Visible = false;
            // 
            // dtRegistro
            // 
            this.dtRegistro.DataPropertyName = "dtRegistro";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Format = "g";
            dataGridViewCellStyle3.NullValue = null;
            this.dtRegistro.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtRegistro.HeaderText = "Fecha Registro";
            this.dtRegistro.Name = "dtRegistro";
            this.dtRegistro.ReadOnly = true;
            this.dtRegistro.Width = 120;
            // 
            // IdEstado_tt
            // 
            this.IdEstado_tt.DataPropertyName = "IdEstado_tt";
            this.IdEstado_tt.HeaderText = "IdEstado_tt";
            this.IdEstado_tt.Name = "IdEstado_tt";
            this.IdEstado_tt.ReadOnly = true;
            this.IdEstado_tt.Visible = false;
            // 
            // IdEstado_tt_Nuevo
            // 
            this.IdEstado_tt_Nuevo.DataPropertyName = "IdEstado_tt_Nuevo";
            this.IdEstado_tt_Nuevo.HeaderText = "IdEstado_tt_Nuevo";
            this.IdEstado_tt_Nuevo.Name = "IdEstado_tt_Nuevo";
            this.IdEstado_tt_Nuevo.ReadOnly = true;
            this.IdEstado_tt_Nuevo.Visible = false;
            // 
            // vComentario
            // 
            this.vComentario.DataPropertyName = "vComentario";
            this.vComentario.HeaderText = "Observación";
            this.vComentario.Name = "vComentario";
            this.vComentario.ReadOnly = true;
            this.vComentario.Width = 300;
            // 
            // Usuario
            // 
            this.Usuario.DataPropertyName = "Usuario";
            this.Usuario.HeaderText = "Usuario";
            this.Usuario.Name = "Usuario";
            this.Usuario.ReadOnly = true;
            // 
            // frmQrySolicitudTracking
            // 
            this.ClientSize = new System.Drawing.Size(800, 484);
            this.DoubleBuffered = true;
            this.Name = "frmQrySolicitudTracking";
            this.Text = "Observaciones";
            this.Load += new System.EventHandler(this.frmQrySolicitudTracking_Load);
            this.grpDato.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSolicitudTracking)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX dgvSolicitudTracking;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdSolicitud;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdTracking;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdTipo_tt;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdEstado_tt;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdEstado_tt_Nuevo;
        private System.Windows.Forms.DataGridViewTextBoxColumn vComentario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuario;
    }
}