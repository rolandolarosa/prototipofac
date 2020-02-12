namespace EfideFactoring.Formula.Registros
{
    partial class frmMntLineasAutorizadasLog
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.dgvHistorial = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.IdLineaLog = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdLinea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdMoneda_tt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdMoneda_tt_Dsc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nImporteAnterior = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nImporteNuevo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblRegistros = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.txtImporte = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtSocio_Id_Dsc = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblLineaMon = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.groupPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorial)).BeginInit();
            this.panelEx1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupPanel1
            // 
            this.groupPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.dgvHistorial);
            this.groupPanel1.Controls.Add(this.lblRegistros);
            this.groupPanel1.Controls.Add(this.labelX3);
            this.groupPanel1.Controls.Add(this.panelEx1);
            this.groupPanel1.Location = new System.Drawing.Point(12, 12);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(598, 311);
            // 
            // 
            // 
            this.groupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel1.Style.BackColorGradientAngle = 90;
            this.groupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderBottomWidth = 1;
            this.groupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderLeftWidth = 1;
            this.groupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderRightWidth = 1;
            this.groupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderTopWidth = 1;
            this.groupPanel1.Style.CornerDiameter = 4;
            this.groupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel1.TabIndex = 0;
            // 
            // dgvHistorial
            // 
            this.dgvHistorial.AllowUserToAddRows = false;
            this.dgvHistorial.AllowUserToDeleteRows = false;
            this.dgvHistorial.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvHistorial.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvHistorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistorial.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdLineaLog,
            this.IdLinea,
            this.dtRegistro,
            this.IdMoneda_tt,
            this.IdMoneda_tt_Dsc,
            this.nImporteAnterior,
            this.nImporteNuevo});
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHistorial.DefaultCellStyle = dataGridViewCellStyle12;
            this.dgvHistorial.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvHistorial.Location = new System.Drawing.Point(15, 108);
            this.dgvHistorial.Name = "dgvHistorial";
            this.dgvHistorial.ReadOnly = true;
            this.dgvHistorial.RowHeadersWidth = 10;
            this.dgvHistorial.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvHistorial.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvHistorial.Size = new System.Drawing.Size(561, 188);
            this.dgvHistorial.TabIndex = 9;
            // 
            // IdLineaLog
            // 
            this.IdLineaLog.DataPropertyName = "IdLineaLog";
            this.IdLineaLog.HeaderText = "Identificador";
            this.IdLineaLog.Name = "IdLineaLog";
            this.IdLineaLog.ReadOnly = true;
            // 
            // IdLinea
            // 
            this.IdLinea.DataPropertyName = "IdLinea";
            this.IdLinea.HeaderText = "IdLinea";
            this.IdLinea.Name = "IdLinea";
            this.IdLinea.ReadOnly = true;
            this.IdLinea.Visible = false;
            // 
            // dtRegistro
            // 
            this.dtRegistro.DataPropertyName = "dtRegistro";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.Format = "g";
            dataGridViewCellStyle9.NullValue = null;
            this.dtRegistro.DefaultCellStyle = dataGridViewCellStyle9;
            this.dtRegistro.HeaderText = "Fecha de Registro";
            this.dtRegistro.Name = "dtRegistro";
            this.dtRegistro.ReadOnly = true;
            // 
            // IdMoneda_tt
            // 
            this.IdMoneda_tt.DataPropertyName = "IdMoneda_tt";
            this.IdMoneda_tt.HeaderText = "IdMoneda_tt";
            this.IdMoneda_tt.Name = "IdMoneda_tt";
            this.IdMoneda_tt.ReadOnly = true;
            this.IdMoneda_tt.Visible = false;
            // 
            // IdMoneda_tt_Dsc
            // 
            this.IdMoneda_tt_Dsc.DataPropertyName = "IdMoneda_tt_Dsc";
            this.IdMoneda_tt_Dsc.HeaderText = "Moneda";
            this.IdMoneda_tt_Dsc.Name = "IdMoneda_tt_Dsc";
            this.IdMoneda_tt_Dsc.ReadOnly = true;
            // 
            // nImporteAnterior
            // 
            this.nImporteAnterior.DataPropertyName = "nImporteAnterior";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle10.Format = "N2";
            dataGridViewCellStyle10.NullValue = "0";
            this.nImporteAnterior.DefaultCellStyle = dataGridViewCellStyle10;
            this.nImporteAnterior.HeaderText = "Importe Anterior";
            this.nImporteAnterior.Name = "nImporteAnterior";
            this.nImporteAnterior.ReadOnly = true;
            // 
            // nImporteNuevo
            // 
            this.nImporteNuevo.DataPropertyName = "nImporteNuevo";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.Format = "N2";
            dataGridViewCellStyle11.NullValue = "0";
            this.nImporteNuevo.DefaultCellStyle = dataGridViewCellStyle11;
            this.nImporteNuevo.HeaderText = "Importe Nuevo";
            this.nImporteNuevo.Name = "nImporteNuevo";
            this.nImporteNuevo.ReadOnly = true;
            // 
            // lblRegistros
            // 
            this.lblRegistros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRegistros.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lblRegistros.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblRegistros.Location = new System.Drawing.Point(501, 82);
            this.lblRegistros.Name = "lblRegistros";
            this.lblRegistros.Size = new System.Drawing.Size(75, 23);
            this.lblRegistros.TabIndex = 8;
            this.lblRegistros.Text = "0  registro(s)";
            // 
            // labelX3
            // 
            this.labelX3.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(15, 79);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(75, 23);
            this.labelX3.TabIndex = 7;
            this.labelX3.Text = "Historico";
            // 
            // panelEx1
            // 
            this.panelEx1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.txtImporte);
            this.panelEx1.Controls.Add(this.txtSocio_Id_Dsc);
            this.panelEx1.Controls.Add(this.lblLineaMon);
            this.panelEx1.Controls.Add(this.labelX1);
            this.panelEx1.Location = new System.Drawing.Point(15, 7);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(561, 69);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 0;
            // 
            // txtImporte
            // 
            // 
            // 
            // 
            this.txtImporte.Border.Class = "TextBoxBorder";
            this.txtImporte.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtImporte.Enabled = false;
            this.txtImporte.Location = new System.Drawing.Point(116, 36);
            this.txtImporte.Name = "txtImporte";
            this.txtImporte.Size = new System.Drawing.Size(107, 20);
            this.txtImporte.TabIndex = 7;
            this.txtImporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtSocio_Id_Dsc
            // 
            // 
            // 
            // 
            this.txtSocio_Id_Dsc.Border.Class = "TextBoxBorder";
            this.txtSocio_Id_Dsc.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtSocio_Id_Dsc.Enabled = false;
            this.txtSocio_Id_Dsc.Location = new System.Drawing.Point(116, 11);
            this.txtSocio_Id_Dsc.Name = "txtSocio_Id_Dsc";
            this.txtSocio_Id_Dsc.Size = new System.Drawing.Size(423, 20);
            this.txtSocio_Id_Dsc.TabIndex = 6;
            // 
            // lblLineaMon
            // 
            this.lblLineaMon.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lblLineaMon.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblLineaMon.Location = new System.Drawing.Point(3, 36);
            this.lblLineaMon.Name = "lblLineaMon";
            this.lblLineaMon.Size = new System.Drawing.Size(107, 23);
            this.lblLineaMon.TabIndex = 5;
            this.lblLineaMon.Text = "Línea Actual S/";
            this.lblLineaMon.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(16, 11);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(85, 23);
            this.labelX1.TabIndex = 4;
            this.labelX1.Text = "Socio";
            this.labelX1.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // frmMntLineasAutorizadasLog
            // 
            this.ClientSize = new System.Drawing.Size(615, 335);
            this.Controls.Add(this.groupPanel1);
            this.DoubleBuffered = true;
            this.Name = "frmMntLineasAutorizadasLog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Historial de Líneas de Crédito";
            this.Load += new System.EventHandler(this.frmMntLineasAutorizadasLog_Load);
            this.groupPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorial)).EndInit();
            this.panelEx1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtImporte;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSocio_Id_Dsc;
        private DevComponents.DotNetBar.LabelX lblLineaMon;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX lblRegistros;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvHistorial;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdLineaLog;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdLinea;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdMoneda_tt;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdMoneda_tt_Dsc;
        private System.Windows.Forms.DataGridViewTextBoxColumn nImporteAnterior;
        private System.Windows.Forms.DataGridViewTextBoxColumn nImporteNuevo;
    }
}