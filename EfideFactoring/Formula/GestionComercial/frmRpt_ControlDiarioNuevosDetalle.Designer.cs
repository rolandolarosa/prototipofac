namespace EfideFactoring.Formula.GestionComercial
{
    partial class frmRpt_ControlDiarioNuevosDetalle
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvReporteDetalle = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.lblRegistros = new DevComponents.DotNetBar.LabelX();
            this.IdSocio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Socio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdTipoBitacora_tt_Dsc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaAlerta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdEstado_tt_Dsc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaAtencion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiasVencidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vcSocio1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdTipoBitacora_tt_Dsc1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaAlerta1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdEstado_tt_Dsc1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpDato.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporteDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // grpDato
            // 
            this.grpDato.Controls.Add(this.lblRegistros);
            this.grpDato.Controls.Add(this.dgvReporteDetalle);
            this.grpDato.Size = new System.Drawing.Size(1404, 460);
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
            this.btnCancelar.Location = new System.Drawing.Point(1323, 481);
            this.btnCancelar.Text = "Cerrar";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(1232, 481);
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
            this.IdSocio,
            this.Socio,
            this.FechaRegistro,
            this.IdTipoBitacora_tt_Dsc,
            this.Descripcion,
            this.FechaAlerta,
            this.IdEstado_tt_Dsc,
            this.FechaAtencion,
            this.DiasVencidos,
            this.vcSocio1,
            this.IdTipoBitacora_tt_Dsc1,
            this.FechaAlerta1,
            this.IdEstado_tt_Dsc1});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvReporteDetalle.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvReporteDetalle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvReporteDetalle.Location = new System.Drawing.Point(5, 26);
            this.dgvReporteDetalle.Name = "dgvReporteDetalle";
            this.dgvReporteDetalle.ReadOnly = true;
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            this.dgvReporteDetalle.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvReporteDetalle.Size = new System.Drawing.Size(1390, 425);
            this.dgvReporteDetalle.TabIndex = 0;
            this.dgvReporteDetalle.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReporteDetalle_CellDoubleClick);
            this.dgvReporteDetalle.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvReporteDetalle_ColumnHeaderMouseClick);
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
            this.lblRegistros.Location = new System.Drawing.Point(1218, 1);
            this.lblRegistros.Name = "lblRegistros";
            this.lblRegistros.Size = new System.Drawing.Size(177, 22);
            this.lblRegistros.TabIndex = 57;
            this.lblRegistros.Text = "0  registro(s)";
            this.lblRegistros.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // IdSocio
            // 
            this.IdSocio.DataPropertyName = "IdSocio";
            this.IdSocio.HeaderText = "IdSocio";
            this.IdSocio.Name = "IdSocio";
            this.IdSocio.ReadOnly = true;
            this.IdSocio.Visible = false;
            // 
            // Socio
            // 
            this.Socio.DataPropertyName = "vcSocio";
            this.Socio.HeaderText = "Socio";
            this.Socio.Name = "Socio";
            this.Socio.ReadOnly = true;
            this.Socio.Width = 180;
            // 
            // FechaRegistro
            // 
            this.FechaRegistro.DataPropertyName = "FechaRegistro";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.FechaRegistro.DefaultCellStyle = dataGridViewCellStyle1;
            this.FechaRegistro.HeaderText = "Fecha Registro";
            this.FechaRegistro.Name = "FechaRegistro";
            this.FechaRegistro.ReadOnly = true;
            this.FechaRegistro.Width = 80;
            // 
            // IdTipoBitacora_tt_Dsc
            // 
            this.IdTipoBitacora_tt_Dsc.DataPropertyName = "IdTipoBitacora_tt_Dsc";
            this.IdTipoBitacora_tt_Dsc.HeaderText = "Tipo";
            this.IdTipoBitacora_tt_Dsc.Name = "IdTipoBitacora_tt_Dsc";
            this.IdTipoBitacora_tt_Dsc.ReadOnly = true;
            // 
            // Descripcion
            // 
            this.Descripcion.DataPropertyName = "Descripcion";
            this.Descripcion.HeaderText = "Descripción";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            // 
            // FechaAlerta
            // 
            this.FechaAlerta.DataPropertyName = "FechaAlerta";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Format = "g";
            dataGridViewCellStyle2.NullValue = null;
            this.FechaAlerta.DefaultCellStyle = dataGridViewCellStyle2;
            this.FechaAlerta.HeaderText = "Fecha Programación / Evento";
            this.FechaAlerta.Name = "FechaAlerta";
            this.FechaAlerta.ReadOnly = true;
            this.FechaAlerta.Width = 120;
            // 
            // IdEstado_tt_Dsc
            // 
            this.IdEstado_tt_Dsc.DataPropertyName = "IdEstado_tt_Dsc";
            this.IdEstado_tt_Dsc.HeaderText = "Estado";
            this.IdEstado_tt_Dsc.Name = "IdEstado_tt_Dsc";
            this.IdEstado_tt_Dsc.ReadOnly = true;
            // 
            // FechaAtencion
            // 
            this.FechaAtencion.DataPropertyName = "FechaAtencion";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Format = "g";
            dataGridViewCellStyle3.NullValue = null;
            this.FechaAtencion.DefaultCellStyle = dataGridViewCellStyle3;
            this.FechaAtencion.HeaderText = "Fecha Atención";
            this.FechaAtencion.Name = "FechaAtencion";
            this.FechaAtencion.ReadOnly = true;
            this.FechaAtencion.Width = 120;
            // 
            // DiasVencidos
            // 
            this.DiasVencidos.DataPropertyName = "DiasVencidos";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DiasVencidos.DefaultCellStyle = dataGridViewCellStyle4;
            this.DiasVencidos.HeaderText = "#Días Vencidos";
            this.DiasVencidos.Name = "DiasVencidos";
            this.DiasVencidos.ReadOnly = true;
            this.DiasVencidos.Width = 70;
            // 
            // vcSocio1
            // 
            this.vcSocio1.DataPropertyName = "vcSocio1";
            this.vcSocio1.HeaderText = "Socio";
            this.vcSocio1.Name = "vcSocio1";
            this.vcSocio1.ReadOnly = true;
            this.vcSocio1.Visible = false;
            this.vcSocio1.Width = 180;
            // 
            // IdTipoBitacora_tt_Dsc1
            // 
            this.IdTipoBitacora_tt_Dsc1.DataPropertyName = "IdTipoBitacora_tt_Dsc1";
            this.IdTipoBitacora_tt_Dsc1.HeaderText = "Tipo";
            this.IdTipoBitacora_tt_Dsc1.Name = "IdTipoBitacora_tt_Dsc1";
            this.IdTipoBitacora_tt_Dsc1.ReadOnly = true;
            // 
            // FechaAlerta1
            // 
            this.FechaAlerta1.DataPropertyName = "FechaAlerta1";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Format = "g";
            this.FechaAlerta1.DefaultCellStyle = dataGridViewCellStyle5;
            this.FechaAlerta1.HeaderText = "Fecha Programación";
            this.FechaAlerta1.Name = "FechaAlerta1";
            this.FechaAlerta1.ReadOnly = true;
            // 
            // IdEstado_tt_Dsc1
            // 
            this.IdEstado_tt_Dsc1.DataPropertyName = "IdEstado_tt_Dsc1";
            this.IdEstado_tt_Dsc1.HeaderText = "Estado";
            this.IdEstado_tt_Dsc1.Name = "IdEstado_tt_Dsc1";
            this.IdEstado_tt_Dsc1.ReadOnly = true;
            // 
            // frmRpt_ControlDiarioNuevosDetalle
            // 
            this.ClientSize = new System.Drawing.Size(1412, 517);
            this.DoubleBuffered = true;
            this.Name = "frmRpt_ControlDiarioNuevosDetalle";
            this.Text = "Reporte de Control Diario de Nuevos - Detalle";
            this.Load += new System.EventHandler(this.frmRpt_ControlDiarioNuevosDetalle_Load);
            this.grpDato.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporteDetalle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX dgvReporteDetalle;
        protected DevComponents.DotNetBar.LabelX lblRegistros;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdSocio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Socio;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdTipoBitacora_tt_Dsc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaAlerta;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdEstado_tt_Dsc;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaAtencion;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiasVencidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn vcSocio1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdTipoBitacora_tt_Dsc1;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaAlerta1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdEstado_tt_Dsc1;
    }
}