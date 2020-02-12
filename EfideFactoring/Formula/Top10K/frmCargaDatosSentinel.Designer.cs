namespace EfideFactoring.Formula.Top10K
{
    partial class frmCargaDatosSentinel
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
            this.grpDato = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.dgvRegistrosNoCargados = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.Item1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Item3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.cboPeriodo = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.btnImportar = new DevComponents.DotNetBar.ButtonX();
            this.lblRegistros = new DevComponents.DotNetBar.LabelX();
            this.lblRegNoCargados = new DevComponents.DotNetBar.LabelX();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pbCargaTop10K = new System.Windows.Forms.ProgressBar();
            this.grpDato.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistrosNoCargados)).BeginInit();
            this.panelEx1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDato
            // 
            this.grpDato.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpDato.CanvasColor = System.Drawing.SystemColors.Control;
            this.grpDato.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.grpDato.Controls.Add(this.dgvRegistrosNoCargados);
            this.grpDato.Controls.Add(this.panelEx1);
            this.grpDato.Controls.Add(this.lblRegNoCargados);
            this.grpDato.Location = new System.Drawing.Point(1, 12);
            this.grpDato.Name = "grpDato";
            this.grpDato.Size = new System.Drawing.Size(616, 309);
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
            this.grpDato.TabIndex = 12;
            // 
            // dgvRegistrosNoCargados
            // 
            this.dgvRegistrosNoCargados.AllowUserToAddRows = false;
            this.dgvRegistrosNoCargados.AllowUserToDeleteRows = false;
            this.dgvRegistrosNoCargados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegistrosNoCargados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Item1,
            this.Item3});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRegistrosNoCargados.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvRegistrosNoCargados.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvRegistrosNoCargados.Location = new System.Drawing.Point(16, 103);
            this.dgvRegistrosNoCargados.Name = "dgvRegistrosNoCargados";
            this.dgvRegistrosNoCargados.ReadOnly = true;
            this.dgvRegistrosNoCargados.Size = new System.Drawing.Size(586, 187);
            this.dgvRegistrosNoCargados.TabIndex = 24;
            // 
            // Item1
            // 
            this.Item1.DataPropertyName = "Item1";
            this.Item1.HeaderText = "RUC";
            this.Item1.Name = "Item1";
            this.Item1.ReadOnly = true;
            // 
            // Item3
            // 
            this.Item3.DataPropertyName = "Item2";
            this.Item3.HeaderText = "Log";
            this.Item3.Name = "Item3";
            this.Item3.ReadOnly = true;
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.pbCargaTop10K);
            this.panelEx1.Controls.Add(this.cboPeriodo);
            this.panelEx1.Controls.Add(this.labelX1);
            this.panelEx1.Controls.Add(this.btnImportar);
            this.panelEx1.Controls.Add(this.lblRegistros);
            this.panelEx1.Location = new System.Drawing.Point(16, 13);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(586, 59);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 23;
            // 
            // cboPeriodo
            // 
            this.cboPeriodo.DisplayMember = "Text";
            this.cboPeriodo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboPeriodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPeriodo.FormattingEnabled = true;
            this.cboPeriodo.ItemHeight = 14;
            this.cboPeriodo.Location = new System.Drawing.Point(76, 21);
            this.cboPeriodo.Name = "cboPeriodo";
            this.cboPeriodo.Size = new System.Drawing.Size(124, 20);
            this.cboPeriodo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboPeriodo.TabIndex = 57;
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.Location = new System.Drawing.Point(17, 18);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(53, 23);
            this.labelX1.TabIndex = 14;
            this.labelX1.Text = "Periodo";
            // 
            // btnImportar
            // 
            this.btnImportar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnImportar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnImportar.Image = global::EfideFactoring.Properties.Resources.excel_2013;
            this.btnImportar.Location = new System.Drawing.Point(220, 17);
            this.btnImportar.Name = "btnImportar";
            this.btnImportar.Size = new System.Drawing.Size(83, 24);
            this.btnImportar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnImportar.TabIndex = 12;
            this.btnImportar.Text = "&Importar";
            this.btnImportar.Click += new System.EventHandler(this.btnImportar_Click);
            // 
            // lblRegistros
            // 
            this.lblRegistros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRegistros.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lblRegistros.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblRegistros.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistros.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblRegistros.Location = new System.Drawing.Point(405, 5);
            this.lblRegistros.Name = "lblRegistros";
            this.lblRegistros.Size = new System.Drawing.Size(176, 22);
            this.lblRegistros.TabIndex = 21;
            this.lblRegistros.Text = "0  registro(s) cargado(s)";
            this.lblRegistros.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // lblRegNoCargados
            // 
            this.lblRegNoCargados.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRegNoCargados.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lblRegNoCargados.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblRegNoCargados.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegNoCargados.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblRegNoCargados.Location = new System.Drawing.Point(16, 78);
            this.lblRegNoCargados.Name = "lblRegNoCargados";
            this.lblRegNoCargados.Size = new System.Drawing.Size(177, 22);
            this.lblRegNoCargados.TabIndex = 22;
            this.lblRegNoCargados.Text = "0  registro(s) que no se cargaron";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pbCargaTop10K
            // 
            this.pbCargaTop10K.Location = new System.Drawing.Point(320, 32);
            this.pbCargaTop10K.Name = "pbCargaTop10K";
            this.pbCargaTop10K.Size = new System.Drawing.Size(261, 23);
            this.pbCargaTop10K.TabIndex = 58;
            // 
            // frmCargaDatosSentinel
            // 
            this.ClientSize = new System.Drawing.Size(619, 333);
            this.Controls.Add(this.grpDato);
            this.DoubleBuffered = true;
            this.Name = "frmCargaDatosSentinel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Carga de Datos Sentinel";
            this.Load += new System.EventHandler(this.frmCargaDatosSentinel_Load);
            this.grpDato.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistrosNoCargados)).EndInit();
            this.panelEx1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        protected DevComponents.DotNetBar.Controls.GroupPanel grpDato;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvRegistrosNoCargados;
        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.ButtonX btnImportar;
        protected DevComponents.DotNetBar.LabelX lblRegistros;
        protected DevComponents.DotNetBar.LabelX lblRegNoCargados;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item3;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboPeriodo;
        private System.Windows.Forms.ProgressBar pbCargaTop10K;

    }
}