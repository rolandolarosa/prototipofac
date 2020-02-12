namespace EfideFactoring.Formula.Catalogo
{
    partial class frmPagadoraLineaLog
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.dgvHistorial = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.IdLineaLog = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdPagadoraH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdMoneda_tt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdMoneda_tt_Dsc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdNivelAutonomia_tt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdNivelAutonomia_tt_Dsc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdMedio_tt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdMedio_tt_Dsc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdAnalistaCredito_tt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdAnalistaCredito_tt_Dsc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iPlazo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtFechaAprobacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtFechaVencimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nImporteAnterior = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nImporteNuevo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtLineaActual = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtPagadora = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.lblRegistros = new DevComponents.DotNetBar.LabelX();
            this.groupPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorial)).BeginInit();
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
            this.groupPanel1.Controls.Add(this.txtLineaActual);
            this.groupPanel1.Controls.Add(this.txtPagadora);
            this.groupPanel1.Controls.Add(this.labelX2);
            this.groupPanel1.Controls.Add(this.labelX1);
            this.groupPanel1.Controls.Add(this.labelX3);
            this.groupPanel1.Controls.Add(this.lblRegistros);
            this.groupPanel1.Location = new System.Drawing.Point(11, 7);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(1146, 464);
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
            this.dgvHistorial.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvHistorial.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvHistorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistorial.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdLineaLog,
            this.IdPagadoraH,
            this.dtRegistro,
            this.IdMoneda_tt,
            this.IdMoneda_tt_Dsc,
            this.IdNivelAutonomia_tt,
            this.IdNivelAutonomia_tt_Dsc,
            this.IdMedio_tt,
            this.IdMedio_tt_Dsc,
            this.IdAnalistaCredito_tt,
            this.IdAnalistaCredito_tt_Dsc,
            this.iPlazo,
            this.dtFechaAprobacion,
            this.dtFechaVencimiento,
            this.nImporteAnterior,
            this.nImporteNuevo});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHistorial.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvHistorial.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvHistorial.Location = new System.Drawing.Point(25, 79);
            this.dgvHistorial.Name = "dgvHistorial";
            this.dgvHistorial.ReadOnly = true;
            this.dgvHistorial.RowHeadersWidth = 10;
            this.dgvHistorial.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvHistorial.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvHistorial.Size = new System.Drawing.Size(1102, 362);
            this.dgvHistorial.TabIndex = 4;
            // 
            // IdLineaLog
            // 
            this.IdLineaLog.DataPropertyName = "IdLineaLog";
            this.IdLineaLog.HeaderText = "IdLineaLog";
            this.IdLineaLog.Name = "IdLineaLog";
            this.IdLineaLog.ReadOnly = true;
            this.IdLineaLog.Visible = false;
            this.IdLineaLog.Width = 85;
            // 
            // IdPagadoraH
            // 
            this.IdPagadoraH.DataPropertyName = "IdPagadora";
            this.IdPagadoraH.HeaderText = "Pagadora";
            this.IdPagadoraH.Name = "IdPagadoraH";
            this.IdPagadoraH.ReadOnly = true;
            this.IdPagadoraH.Width = 78;
            // 
            // dtRegistro
            // 
            this.dtRegistro.DataPropertyName = "dtRegistro";
            this.dtRegistro.HeaderText = "Fecha Registro";
            this.dtRegistro.Name = "dtRegistro";
            this.dtRegistro.ReadOnly = true;
            this.dtRegistro.Width = 96;
            // 
            // IdMoneda_tt
            // 
            this.IdMoneda_tt.DataPropertyName = "IdMoneda_tt";
            this.IdMoneda_tt.HeaderText = "IdMoneda_tt";
            this.IdMoneda_tt.Name = "IdMoneda_tt";
            this.IdMoneda_tt.ReadOnly = true;
            this.IdMoneda_tt.Visible = false;
            this.IdMoneda_tt.Width = 92;
            // 
            // IdMoneda_tt_Dsc
            // 
            this.IdMoneda_tt_Dsc.DataPropertyName = "IdMoneda_tt_Dsc";
            this.IdMoneda_tt_Dsc.HeaderText = "Moneda";
            this.IdMoneda_tt_Dsc.Name = "IdMoneda_tt_Dsc";
            this.IdMoneda_tt_Dsc.ReadOnly = true;
            this.IdMoneda_tt_Dsc.Width = 71;
            // 
            // IdNivelAutonomia_tt
            // 
            this.IdNivelAutonomia_tt.DataPropertyName = "IdNivelAutonomia_tt";
            this.IdNivelAutonomia_tt.HeaderText = "IdNivelAutonomia_tt";
            this.IdNivelAutonomia_tt.Name = "IdNivelAutonomia_tt";
            this.IdNivelAutonomia_tt.ReadOnly = true;
            this.IdNivelAutonomia_tt.Visible = false;
            this.IdNivelAutonomia_tt.Width = 127;
            // 
            // IdNivelAutonomia_tt_Dsc
            // 
            this.IdNivelAutonomia_tt_Dsc.DataPropertyName = "IdNivelAutonomia_tt_Dsc";
            this.IdNivelAutonomia_tt_Dsc.HeaderText = "Nivel Autonomia";
            this.IdNivelAutonomia_tt_Dsc.Name = "IdNivelAutonomia_tt_Dsc";
            this.IdNivelAutonomia_tt_Dsc.ReadOnly = true;
            // 
            // IdMedio_tt
            // 
            this.IdMedio_tt.DataPropertyName = "IdMedio_tt";
            this.IdMedio_tt.HeaderText = "IdMedio_tt";
            this.IdMedio_tt.Name = "IdMedio_tt";
            this.IdMedio_tt.ReadOnly = true;
            this.IdMedio_tt.Visible = false;
            this.IdMedio_tt.Width = 82;
            // 
            // IdMedio_tt_Dsc
            // 
            this.IdMedio_tt_Dsc.DataPropertyName = "IdMedio_tt_Dsc";
            this.IdMedio_tt_Dsc.HeaderText = "Medio";
            this.IdMedio_tt_Dsc.Name = "IdMedio_tt_Dsc";
            this.IdMedio_tt_Dsc.ReadOnly = true;
            this.IdMedio_tt_Dsc.Width = 61;
            // 
            // IdAnalistaCredito_tt
            // 
            this.IdAnalistaCredito_tt.DataPropertyName = "IdAnalistaCredito_tt";
            this.IdAnalistaCredito_tt.HeaderText = "IdAnalistaCredito_tt";
            this.IdAnalistaCredito_tt.Name = "IdAnalistaCredito_tt";
            this.IdAnalistaCredito_tt.ReadOnly = true;
            this.IdAnalistaCredito_tt.Visible = false;
            this.IdAnalistaCredito_tt.Width = 123;
            // 
            // IdAnalistaCredito_tt_Dsc
            // 
            this.IdAnalistaCredito_tt_Dsc.DataPropertyName = "IdAnalistaCredito_tt_Dsc";
            this.IdAnalistaCredito_tt_Dsc.HeaderText = "Analista Crédito";
            this.IdAnalistaCredito_tt_Dsc.Name = "IdAnalistaCredito_tt_Dsc";
            this.IdAnalistaCredito_tt_Dsc.ReadOnly = true;
            this.IdAnalistaCredito_tt_Dsc.Width = 96;
            // 
            // iPlazo
            // 
            this.iPlazo.DataPropertyName = "iPlazo";
            this.iPlazo.HeaderText = "Plazo";
            this.iPlazo.Name = "iPlazo";
            this.iPlazo.ReadOnly = true;
            this.iPlazo.Width = 58;
            // 
            // dtFechaAprobacion
            // 
            this.dtFechaAprobacion.DataPropertyName = "dtFechaAprobacion";
            this.dtFechaAprobacion.HeaderText = "Fecha Aprobación";
            this.dtFechaAprobacion.Name = "dtFechaAprobacion";
            this.dtFechaAprobacion.ReadOnly = true;
            this.dtFechaAprobacion.Width = 109;
            // 
            // dtFechaVencimiento
            // 
            this.dtFechaVencimiento.DataPropertyName = "dtFechaVencimiento";
            this.dtFechaVencimiento.HeaderText = "Fecha Vencimiento";
            this.dtFechaVencimiento.Name = "dtFechaVencimiento";
            this.dtFechaVencimiento.ReadOnly = true;
            this.dtFechaVencimiento.Width = 113;
            // 
            // nImporteAnterior
            // 
            this.nImporteAnterior.DataPropertyName = "nImporteAnterior";
            this.nImporteAnterior.HeaderText = "Importe Anterior";
            this.nImporteAnterior.Name = "nImporteAnterior";
            this.nImporteAnterior.ReadOnly = true;
            this.nImporteAnterior.Width = 97;
            // 
            // nImporteNuevo
            // 
            this.nImporteNuevo.DataPropertyName = "nImporteNuevo";
            this.nImporteNuevo.HeaderText = "Importe Nuevo";
            this.nImporteNuevo.Name = "nImporteNuevo";
            this.nImporteNuevo.ReadOnly = true;
            this.nImporteNuevo.Width = 94;
            // 
            // txtLineaActual
            // 
            // 
            // 
            // 
            this.txtLineaActual.Border.Class = "TextBoxBorder";
            this.txtLineaActual.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtLineaActual.Enabled = false;
            this.txtLineaActual.Location = new System.Drawing.Point(98, 29);
            this.txtLineaActual.Name = "txtLineaActual";
            this.txtLineaActual.Size = new System.Drawing.Size(107, 20);
            this.txtLineaActual.TabIndex = 3;
            // 
            // txtPagadora
            // 
            // 
            // 
            // 
            this.txtPagadora.Border.Class = "TextBoxBorder";
            this.txtPagadora.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtPagadora.Enabled = false;
            this.txtPagadora.Location = new System.Drawing.Point(98, 7);
            this.txtPagadora.Name = "txtPagadora";
            this.txtPagadora.Size = new System.Drawing.Size(340, 20);
            this.txtPagadora.TabIndex = 2;
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(27, 29);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(69, 23);
            this.labelX2.TabIndex = 1;
            this.labelX2.Text = "Línea Actual";
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(27, 7);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(69, 23);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "Pagadora";
            // 
            // labelX3
            // 
            this.labelX3.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(24, 57);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(75, 23);
            this.labelX3.TabIndex = 5;
            this.labelX3.Text = "1. Historico";
            // 
            // lblRegistros
            // 
            this.lblRegistros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRegistros.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lblRegistros.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblRegistros.Location = new System.Drawing.Point(1053, 57);
            this.lblRegistros.Name = "lblRegistros";
            this.lblRegistros.Size = new System.Drawing.Size(75, 23);
            this.lblRegistros.TabIndex = 6;
            this.lblRegistros.Text = "0  registro(s)";
            // 
            // frmPagadoraLineaLog
            // 
            this.ClientSize = new System.Drawing.Size(1159, 478);
            this.Controls.Add(this.groupPanel1);
            this.DoubleBuffered = true;
            this.Name = "frmPagadoraLineaLog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Historico de Líneas de Crédito";
            this.Load += new System.EventHandler(this.frmPagadoraLineaLog_Load);
            this.groupPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorial)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.TextBoxX txtLineaActual;
        private DevComponents.DotNetBar.Controls.TextBoxX txtPagadora;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvHistorial;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX lblRegistros;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdLineaLog;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdPagadoraH;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdMoneda_tt;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdMoneda_tt_Dsc;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdNivelAutonomia_tt;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdNivelAutonomia_tt_Dsc;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdMedio_tt;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdMedio_tt_Dsc;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdAnalistaCredito_tt;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdAnalistaCredito_tt_Dsc;
        private System.Windows.Forms.DataGridViewTextBoxColumn iPlazo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtFechaAprobacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtFechaVencimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn nImporteAnterior;
        private System.Windows.Forms.DataGridViewTextBoxColumn nImporteNuevo;
    }
}