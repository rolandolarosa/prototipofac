namespace EfideFactoring.Formula.Catalogo
{
    partial class frmGrupoPagadoraLog
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
            this.lblRegistros = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.dgvHistorial = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.IdGrupoLineaLog = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdGrupoPagadoraH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdMoneda_tt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdMoneda_tt_Dsc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nImporteAnterior = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nImporteNuevo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtGrupoPagadora = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorial)).BeginInit();
            this.groupPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblRegistros
            // 
            this.lblRegistros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRegistros.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lblRegistros.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblRegistros.Location = new System.Drawing.Point(403, 38);
            this.lblRegistros.Name = "lblRegistros";
            this.lblRegistros.Size = new System.Drawing.Size(200, 23);
            this.lblRegistros.TabIndex = 6;
            this.lblRegistros.Text = "0 registro(s)";
            this.lblRegistros.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // labelX3
            // 
            this.labelX3.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(18, 38);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(75, 23);
            this.labelX3.TabIndex = 5;
            this.labelX3.Text = "Historico";
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
            this.IdGrupoLineaLog,
            this.IdGrupoPagadoraH,
            this.dtRegistro,
            this.IdMoneda_tt,
            this.IdMoneda_tt_Dsc,
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
            this.dgvHistorial.Location = new System.Drawing.Point(18, 60);
            this.dgvHistorial.Name = "dgvHistorial";
            this.dgvHistorial.ReadOnly = true;
            this.dgvHistorial.RowHeadersWidth = 10;
            this.dgvHistorial.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvHistorial.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvHistorial.Size = new System.Drawing.Size(585, 302);
            this.dgvHistorial.TabIndex = 4;
            // 
            // IdGrupoLineaLog
            // 
            this.IdGrupoLineaLog.DataPropertyName = "IdGrupoLineaLog";
            this.IdGrupoLineaLog.HeaderText = "IdGrupoLineaLog";
            this.IdGrupoLineaLog.Name = "IdGrupoLineaLog";
            this.IdGrupoLineaLog.ReadOnly = true;
            this.IdGrupoLineaLog.Visible = false;
            // 
            // IdGrupoPagadoraH
            // 
            this.IdGrupoPagadoraH.DataPropertyName = "IdGrupoPagadora";
            this.IdGrupoPagadoraH.HeaderText = "Grupo Pagadora";
            this.IdGrupoPagadoraH.Name = "IdGrupoPagadoraH";
            this.IdGrupoPagadoraH.ReadOnly = true;
            // 
            // dtRegistro
            // 
            this.dtRegistro.DataPropertyName = "dtRegistro";
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
            this.nImporteAnterior.HeaderText = "Importe Anterior";
            this.nImporteAnterior.Name = "nImporteAnterior";
            this.nImporteAnterior.ReadOnly = true;
            // 
            // nImporteNuevo
            // 
            this.nImporteNuevo.DataPropertyName = "nImporteNuevo";
            this.nImporteNuevo.HeaderText = "Importe Nuevo";
            this.nImporteNuevo.Name = "nImporteNuevo";
            this.nImporteNuevo.ReadOnly = true;
            // 
            // txtGrupoPagadora
            // 
            // 
            // 
            // 
            this.txtGrupoPagadora.Border.Class = "TextBoxBorder";
            this.txtGrupoPagadora.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtGrupoPagadora.Enabled = false;
            this.txtGrupoPagadora.Location = new System.Drawing.Point(107, 10);
            this.txtGrupoPagadora.Name = "txtGrupoPagadora";
            this.txtGrupoPagadora.Size = new System.Drawing.Size(340, 20);
            this.txtGrupoPagadora.TabIndex = 2;
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(18, 9);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(85, 23);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "Grupo Pagadora";
            this.labelX1.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // groupPanel1
            // 
            this.groupPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.dgvHistorial);
            this.groupPanel1.Controls.Add(this.txtGrupoPagadora);
            this.groupPanel1.Controls.Add(this.labelX1);
            this.groupPanel1.Controls.Add(this.lblRegistros);
            this.groupPanel1.Controls.Add(this.labelX3);
            this.groupPanel1.Location = new System.Drawing.Point(12, 12);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(627, 381);
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
            this.groupPanel1.TabIndex = 1;
            // 
            // frmGrupoPagadoraLog
            // 
            this.ClientSize = new System.Drawing.Size(651, 405);
            this.Controls.Add(this.groupPanel1);
            this.DoubleBuffered = true;
            this.Name = "frmGrupoPagadoraLog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Historico de Líneas de Crédito";
            this.Load += new System.EventHandler(this.frmGrupoPagadoraLog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorial)).EndInit();
            this.groupPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX lblRegistros;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvHistorial;
        private DevComponents.DotNetBar.Controls.TextBoxX txtGrupoPagadora;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdGrupoLineaLog;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdGrupoPagadoraH;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdMoneda_tt;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdMoneda_tt_Dsc;
        private System.Windows.Forms.DataGridViewTextBoxColumn nImporteAnterior;
        private System.Windows.Forms.DataGridViewTextBoxColumn nImporteNuevo;
    }
}