namespace EfideFactoring.Formula.Cobranza
{
    partial class frmMntBaseNegativa
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvBaseNegativa = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.IdBaseNegativa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vApePaterno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vApeMaterno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdTipoDocumento_tt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdTipoDocumento_tt_Dsc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vNroDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Motivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Observacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtvNroDocumento = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.PanelEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaseNegativa)).BeginInit();
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
            this.RibbonBar1.Size = new System.Drawing.Size(1026, 40);
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
            // btnEliminar
            // 
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // PanelEx1
            // 
            this.PanelEx1.Controls.Add(this.txtvNroDocumento);
            this.PanelEx1.Controls.Add(this.labelX6);
            this.PanelEx1.Size = new System.Drawing.Size(1026, 54);
            this.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.PanelEx1.Style.GradientAngle = 90;
            this.PanelEx1.Controls.SetChildIndex(this.LabelX1, 0);
            this.PanelEx1.Controls.SetChildIndex(this.TextBoxX1, 0);
            this.PanelEx1.Controls.SetChildIndex(this.btnBuscar, 0);
            this.PanelEx1.Controls.SetChildIndex(this.btnLimpiar, 0);
            this.PanelEx1.Controls.SetChildIndex(this.labelX6, 0);
            this.PanelEx1.Controls.SetChildIndex(this.txtvNroDocumento, 0);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(779, 4);
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(702, 4);
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // TextBoxX1
            // 
            // 
            // 
            // 
            this.TextBoxX1.Border.Class = "TextBoxBorder";
            this.TextBoxX1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TextBoxX1.Location = new System.Drawing.Point(136, 16);
            this.TextBoxX1.Size = new System.Drawing.Size(274, 20);
            // 
            // LabelX1
            // 
            // 
            // 
            // 
            this.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LabelX1.Size = new System.Drawing.Size(116, 23);
            this.LabelX1.Text = "Nombre/Razón Social";
            // 
            // lblGrilla
            // 
            // 
            // 
            // 
            this.lblGrilla.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblGrilla.Text = "Datos";
            this.lblGrilla.Visible = false;
            // 
            // lblRegistros
            // 
            // 
            // 
            // 
            this.lblRegistros.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblRegistros.Location = new System.Drawing.Point(850, 97);
            // 
            // dgvBaseNegativa
            // 
            this.dgvBaseNegativa.AllowUserToAddRows = false;
            this.dgvBaseNegativa.AllowUserToDeleteRows = false;
            this.dgvBaseNegativa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBaseNegativa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBaseNegativa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdBaseNegativa,
            this.dtRegistro,
            this.vApePaterno,
            this.vApeMaterno,
            this.vNombre,
            this.IdTipoDocumento_tt,
            this.IdTipoDocumento_tt_Dsc,
            this.vNroDocumento,
            this.Motivo,
            this.Observacion});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBaseNegativa.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBaseNegativa.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvBaseNegativa.Location = new System.Drawing.Point(0, 125);
            this.dgvBaseNegativa.Name = "dgvBaseNegativa";
            this.dgvBaseNegativa.ReadOnly = true;
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            this.dgvBaseNegativa.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvBaseNegativa.Size = new System.Drawing.Size(1026, 415);
            this.dgvBaseNegativa.TabIndex = 22;
            // 
            // IdBaseNegativa
            // 
            this.IdBaseNegativa.DataPropertyName = "IdBaseNegativa";
            this.IdBaseNegativa.HeaderText = "Código";
            this.IdBaseNegativa.Name = "IdBaseNegativa";
            this.IdBaseNegativa.ReadOnly = true;
            // 
            // dtRegistro
            // 
            this.dtRegistro.DataPropertyName = "dtRegistro";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.dtRegistro.DefaultCellStyle = dataGridViewCellStyle1;
            this.dtRegistro.HeaderText = "Fecha Registro";
            this.dtRegistro.Name = "dtRegistro";
            this.dtRegistro.ReadOnly = true;
            // 
            // vApePaterno
            // 
            this.vApePaterno.DataPropertyName = "vApePaterno";
            this.vApePaterno.HeaderText = "Apellido Paterno";
            this.vApePaterno.Name = "vApePaterno";
            this.vApePaterno.ReadOnly = true;
            this.vApePaterno.Width = 120;
            // 
            // vApeMaterno
            // 
            this.vApeMaterno.DataPropertyName = "vApeMaterno";
            this.vApeMaterno.HeaderText = "Apellido Materno";
            this.vApeMaterno.Name = "vApeMaterno";
            this.vApeMaterno.ReadOnly = true;
            this.vApeMaterno.Width = 120;
            // 
            // vNombre
            // 
            this.vNombre.DataPropertyName = "vNombre";
            this.vNombre.HeaderText = "Nombre";
            this.vNombre.Name = "vNombre";
            this.vNombre.ReadOnly = true;
            this.vNombre.Width = 120;
            // 
            // IdTipoDocumento_tt
            // 
            this.IdTipoDocumento_tt.DataPropertyName = "IdTipoDocumento_tt";
            this.IdTipoDocumento_tt.HeaderText = "IdTipoDocumento_tt";
            this.IdTipoDocumento_tt.Name = "IdTipoDocumento_tt";
            this.IdTipoDocumento_tt.ReadOnly = true;
            this.IdTipoDocumento_tt.Visible = false;
            // 
            // IdTipoDocumento_tt_Dsc
            // 
            this.IdTipoDocumento_tt_Dsc.DataPropertyName = "IdTipoDocumento_tt_Dsc";
            this.IdTipoDocumento_tt_Dsc.HeaderText = "Doc.";
            this.IdTipoDocumento_tt_Dsc.Name = "IdTipoDocumento_tt_Dsc";
            this.IdTipoDocumento_tt_Dsc.ReadOnly = true;
            this.IdTipoDocumento_tt_Dsc.Width = 60;
            // 
            // vNroDocumento
            // 
            this.vNroDocumento.DataPropertyName = "vNroDocumento";
            this.vNroDocumento.HeaderText = "Nro. Documento";
            this.vNroDocumento.Name = "vNroDocumento";
            this.vNroDocumento.ReadOnly = true;
            this.vNroDocumento.Width = 80;
            // 
            // Motivo
            // 
            this.Motivo.DataPropertyName = "Motivo";
            this.Motivo.HeaderText = "Motivo";
            this.Motivo.Name = "Motivo";
            this.Motivo.ReadOnly = true;
            this.Motivo.Width = 200;
            // 
            // Observacion
            // 
            this.Observacion.DataPropertyName = "Observacion";
            this.Observacion.HeaderText = "Observacion";
            this.Observacion.Name = "Observacion";
            this.Observacion.ReadOnly = true;
            this.Observacion.Visible = false;
            // 
            // txtvNroDocumento
            // 
            // 
            // 
            // 
            this.txtvNroDocumento.Border.Class = "TextBoxBorder";
            this.txtvNroDocumento.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtvNroDocumento.Location = new System.Drawing.Point(503, 16);
            this.txtvNroDocumento.Name = "txtvNroDocumento";
            this.txtvNroDocumento.Size = new System.Drawing.Size(156, 20);
            this.txtvNroDocumento.TabIndex = 27;
            // 
            // labelX6
            // 
            this.labelX6.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelX6.Location = new System.Drawing.Point(421, 13);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(73, 23);
            this.labelX6.TabIndex = 26;
            this.labelX6.Text = "Nro. Doc.";
            this.labelX6.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // frmMntBaseNegativa
            // 
            this.ClientSize = new System.Drawing.Size(1026, 552);
            this.Controls.Add(this.dgvBaseNegativa);
            this.DoubleBuffered = true;
            this.Name = "frmMntBaseNegativa";
            this.Text = "Mantenimiento de Base Negativa";
            this.Controls.SetChildIndex(this.RibbonBar1, 0);
            this.Controls.SetChildIndex(this.PanelEx1, 0);
            this.Controls.SetChildIndex(this.lblRegistros, 0);
            this.Controls.SetChildIndex(this.lblGrilla, 0);
            this.Controls.SetChildIndex(this.dgvBaseNegativa, 0);
            this.PanelEx1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaseNegativa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX dgvBaseNegativa;
        private DevComponents.DotNetBar.Controls.TextBoxX txtvNroDocumento;
        private DevComponents.DotNetBar.LabelX labelX6;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdBaseNegativa;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn vApePaterno;
        private System.Windows.Forms.DataGridViewTextBoxColumn vApeMaterno;
        private System.Windows.Forms.DataGridViewTextBoxColumn vNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdTipoDocumento_tt;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdTipoDocumento_tt_Dsc;
        private System.Windows.Forms.DataGridViewTextBoxColumn vNroDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Motivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Observacion;
    }
}