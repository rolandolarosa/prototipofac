namespace EfideFactoring.Formula.GestionComercial
{
    partial class frmQryBitacoraComercial
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
            this.dgvReporteDetalle = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.lblSocio = new DevComponents.DotNetBar.LabelX();
            this.IdBitacoraComercial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdSocio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdTipoBitacora_tt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdTipoBitacora_tt_Dsc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaAlerta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdEstado_tt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdEstado_tt_Dsc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaAtendido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdGestor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpDato.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporteDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // grpDato
            // 
            this.grpDato.Controls.Add(this.lblSocio);
            this.grpDato.Controls.Add(this.dgvReporteDetalle);
            this.grpDato.Size = new System.Drawing.Size(858, 420);
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
            this.btnCancelar.Location = new System.Drawing.Point(777, 441);
            this.btnCancelar.Text = "Cerrar";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(686, 441);
            this.btnAceptar.Visible = false;
            // 
            // dgvReporteDetalle
            // 
            this.dgvReporteDetalle.AllowUserToAddRows = false;
            this.dgvReporteDetalle.AllowUserToDeleteRows = false;
            this.dgvReporteDetalle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvReporteDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReporteDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdBitacoraComercial,
            this.IdSocio,
            this.IdTipoBitacora_tt,
            this.FechaRegistro,
            this.IdTipoBitacora_tt_Dsc,
            this.Descripcion,
            this.FechaAlerta,
            this.IdEstado_tt,
            this.IdEstado_tt_Dsc,
            this.FechaAtendido,
            this.IdGestor});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvReporteDetalle.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvReporteDetalle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvReporteDetalle.Location = new System.Drawing.Point(5, 58);
            this.dgvReporteDetalle.Name = "dgvReporteDetalle";
            this.dgvReporteDetalle.ReadOnly = true;
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            this.dgvReporteDetalle.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvReporteDetalle.Size = new System.Drawing.Size(844, 344);
            this.dgvReporteDetalle.TabIndex = 1;
            // 
            // lblSocio
            // 
            this.lblSocio.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lblSocio.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblSocio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSocio.Location = new System.Drawing.Point(5, 20);
            this.lblSocio.Name = "lblSocio";
            this.lblSocio.Size = new System.Drawing.Size(764, 23);
            this.lblSocio.TabIndex = 2;
            this.lblSocio.Text = "Socio:";
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
            this.IdSocio.Visible = false;
            // 
            // IdTipoBitacora_tt
            // 
            this.IdTipoBitacora_tt.DataPropertyName = "IdTipoBitacora_tt";
            this.IdTipoBitacora_tt.HeaderText = "IdTipoBitacora_tt";
            this.IdTipoBitacora_tt.Name = "IdTipoBitacora_tt";
            this.IdTipoBitacora_tt.ReadOnly = true;
            this.IdTipoBitacora_tt.Visible = false;
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
            this.Descripcion.Width = 250;
            // 
            // FechaAlerta
            // 
            this.FechaAlerta.DataPropertyName = "FechaAlerta";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Format = "g";
            dataGridViewCellStyle2.NullValue = null;
            this.FechaAlerta.DefaultCellStyle = dataGridViewCellStyle2;
            this.FechaAlerta.HeaderText = "Fecha Programación";
            this.FechaAlerta.Name = "FechaAlerta";
            this.FechaAlerta.ReadOnly = true;
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
            this.IdEstado_tt_Dsc.HeaderText = "Estado";
            this.IdEstado_tt_Dsc.Name = "IdEstado_tt_Dsc";
            this.IdEstado_tt_Dsc.ReadOnly = true;
            this.IdEstado_tt_Dsc.Width = 80;
            // 
            // FechaAtendido
            // 
            this.FechaAtendido.DataPropertyName = "FechaAtendido";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Format = "g";
            dataGridViewCellStyle3.NullValue = null;
            this.FechaAtendido.DefaultCellStyle = dataGridViewCellStyle3;
            this.FechaAtendido.HeaderText = "Fecha Atención";
            this.FechaAtendido.Name = "FechaAtendido";
            this.FechaAtendido.ReadOnly = true;
            // 
            // IdGestor
            // 
            this.IdGestor.DataPropertyName = "IdGestor";
            this.IdGestor.HeaderText = "IdGestor";
            this.IdGestor.Name = "IdGestor";
            this.IdGestor.ReadOnly = true;
            this.IdGestor.Visible = false;
            // 
            // frmQryBitacoraComercial
            // 
            this.ClientSize = new System.Drawing.Size(866, 477);
            this.DoubleBuffered = true;
            this.Name = "frmQryBitacoraComercial";
            this.Text = "Historia Bitacora";
            this.Load += new System.EventHandler(this.frmQryBitacoraComercial_Load);
            this.grpDato.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporteDetalle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX dgvReporteDetalle;
        private DevComponents.DotNetBar.LabelX lblSocio;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdBitacoraComercial;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdSocio;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdTipoBitacora_tt;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdTipoBitacora_tt_Dsc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaAlerta;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdEstado_tt;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdEstado_tt_Dsc;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaAtendido;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdGestor;
    }
}