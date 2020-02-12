namespace EfideFactoring.Formula.Legal
{
    partial class frmQryBovedaTracking
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
            this.dgvSolicitudTracking = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.IdBoveda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdFormatoDocLegal_tt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdTracking = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdEstado_tt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdEstado_tt_Dsc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdEstado_tt_Nuevo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdEstado_tt_Nuevo_Dsc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vComentario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpDato.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSolicitudTracking)).BeginInit();
            this.SuspendLayout();
            // 
            // grpDato
            // 
            this.grpDato.Controls.Add(this.dgvSolicitudTracking);
            this.grpDato.Size = new System.Drawing.Size(884, 331);
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
            this.btnCancelar.Location = new System.Drawing.Point(803, 352);
            this.btnCancelar.Text = "Cerrar";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(712, 352);
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
            this.IdBoveda,
            this.IdFormatoDocLegal_tt,
            this.IdTracking,
            this.dtRegistro,
            this.IdEstado_tt,
            this.IdEstado_tt_Dsc,
            this.IdEstado_tt_Nuevo,
            this.IdEstado_tt_Nuevo_Dsc,
            this.vComentario,
            this.Usuario});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSolicitudTracking.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSolicitudTracking.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvSolicitudTracking.Location = new System.Drawing.Point(5, 12);
            this.dgvSolicitudTracking.Name = "dgvSolicitudTracking";
            this.dgvSolicitudTracking.ReadOnly = true;
            this.dgvSolicitudTracking.Size = new System.Drawing.Size(868, 310);
            this.dgvSolicitudTracking.TabIndex = 38;
            // 
            // IdBoveda
            // 
            this.IdBoveda.DataPropertyName = "IdBoveda";
            this.IdBoveda.HeaderText = "IdBoveda";
            this.IdBoveda.Name = "IdBoveda";
            this.IdBoveda.ReadOnly = true;
            this.IdBoveda.Visible = false;
            // 
            // IdFormatoDocLegal_tt
            // 
            this.IdFormatoDocLegal_tt.DataPropertyName = "IdFormatoDocLegal_tt";
            this.IdFormatoDocLegal_tt.HeaderText = "IdFormatoDocLegal_tt";
            this.IdFormatoDocLegal_tt.Name = "IdFormatoDocLegal_tt";
            this.IdFormatoDocLegal_tt.ReadOnly = true;
            this.IdFormatoDocLegal_tt.Visible = false;
            // 
            // IdTracking
            // 
            this.IdTracking.DataPropertyName = "IdTracking";
            this.IdTracking.HeaderText = "IdTracking";
            this.IdTracking.Name = "IdTracking";
            this.IdTracking.ReadOnly = true;
            this.IdTracking.Visible = false;
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
            // IdEstado_tt
            // 
            this.IdEstado_tt.DataPropertyName = "IdEstado_tt";
            this.IdEstado_tt.HeaderText = "IdEstado_tt";
            this.IdEstado_tt.Name = "IdEstado_tt";
            this.IdEstado_tt.ReadOnly = true;
            this.IdEstado_tt.Visible = false;
            // 
            // IdEstado_tt_Dsc
            // 
            this.IdEstado_tt_Dsc.DataPropertyName = "IdEstado_tt_Dsc";
            this.IdEstado_tt_Dsc.HeaderText = "Estado Anterior";
            this.IdEstado_tt_Dsc.Name = "IdEstado_tt_Dsc";
            this.IdEstado_tt_Dsc.ReadOnly = true;
            // 
            // IdEstado_tt_Nuevo
            // 
            this.IdEstado_tt_Nuevo.DataPropertyName = "IdEstado_tt_Nuevo";
            this.IdEstado_tt_Nuevo.HeaderText = "IdEstado_tt_Nuevo";
            this.IdEstado_tt_Nuevo.Name = "IdEstado_tt_Nuevo";
            this.IdEstado_tt_Nuevo.ReadOnly = true;
            this.IdEstado_tt_Nuevo.Visible = false;
            // 
            // IdEstado_tt_Nuevo_Dsc
            // 
            this.IdEstado_tt_Nuevo_Dsc.DataPropertyName = "IdEstado_tt_Nuevo_Dsc";
            this.IdEstado_tt_Nuevo_Dsc.HeaderText = "Estado Actual";
            this.IdEstado_tt_Nuevo_Dsc.Name = "IdEstado_tt_Nuevo_Dsc";
            this.IdEstado_tt_Nuevo_Dsc.ReadOnly = true;
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
            // frmQryBovedaTracking
            // 
            this.ClientSize = new System.Drawing.Size(892, 388);
            this.DoubleBuffered = true;
            this.Name = "frmQryBovedaTracking";
            this.Text = "Historia de Eventos";
            this.Load += new System.EventHandler(this.frmQryBovedaTracking_Load);
            this.grpDato.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSolicitudTracking)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX dgvSolicitudTracking;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdBoveda;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdFormatoDocLegal_tt;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdTracking;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdEstado_tt;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdEstado_tt_Dsc;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdEstado_tt_Nuevo;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdEstado_tt_Nuevo_Dsc;
        private System.Windows.Forms.DataGridViewTextBoxColumn vComentario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuario;

    }
}