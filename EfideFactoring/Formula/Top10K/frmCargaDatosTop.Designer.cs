namespace EfideFactoring.Formula.Top10K
{
    partial class frmCargaDatosTop
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.pbCargaTop10K = new System.Windows.Forms.ProgressBar();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.btnImportar = new DevComponents.DotNetBar.ButtonX();
            this.lblRegistros = new DevComponents.DotNetBar.LabelX();
            this.txtYear = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblRegNoCargados = new DevComponents.DotNetBar.LabelX();
            this.dgvRegistrosNoCargados = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.Item1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Item2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.grpDato.SuspendLayout();
            this.panelEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistrosNoCargados)).BeginInit();
            this.SuspendLayout();
            // 
            // grpDato
            // 
            this.grpDato.Controls.Add(this.dgvRegistrosNoCargados);
            this.grpDato.Controls.Add(this.lblRegNoCargados);
            this.grpDato.Controls.Add(this.panelEx1);
            this.grpDato.Size = new System.Drawing.Size(773, 413);
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
            this.btnCancelar.Location = new System.Drawing.Point(692, 434);
            this.btnCancelar.Text = "Cerrar";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(601, 434);
            this.btnAceptar.Visible = false;
            // 
            // panelEx1
            // 
            this.panelEx1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.pbCargaTop10K);
            this.panelEx1.Controls.Add(this.labelX1);
            this.panelEx1.Controls.Add(this.btnImportar);
            this.panelEx1.Controls.Add(this.lblRegistros);
            this.panelEx1.Controls.Add(this.txtYear);
            this.panelEx1.Location = new System.Drawing.Point(5, 3);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(757, 59);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 24;
            // 
            // pbCargaTop10K
            // 
            this.pbCargaTop10K.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbCargaTop10K.Location = new System.Drawing.Point(339, 29);
            this.pbCargaTop10K.Name = "pbCargaTop10K";
            this.pbCargaTop10K.Size = new System.Drawing.Size(410, 23);
            this.pbCargaTop10K.TabIndex = 22;
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelX1.Location = new System.Drawing.Point(17, 18);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(62, 23);
            this.labelX1.TabIndex = 14;
            this.labelX1.Text = "Año(YYYY)";
            // 
            // btnImportar
            // 
            this.btnImportar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnImportar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnImportar.Image = global::EfideFactoring.Properties.Resources.excel_2013;
            this.btnImportar.Location = new System.Drawing.Point(197, 17);
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
            this.lblRegistros.Location = new System.Drawing.Point(590, 4);
            this.lblRegistros.Name = "lblRegistros";
            this.lblRegistros.Size = new System.Drawing.Size(159, 22);
            this.lblRegistros.TabIndex = 21;
            this.lblRegistros.Text = "0  registro(s) cargado(s)";
            this.lblRegistros.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // txtYear
            // 
            // 
            // 
            // 
            this.txtYear.Border.Class = "TextBoxBorder";
            this.txtYear.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtYear.Location = new System.Drawing.Point(85, 18);
            this.txtYear.MaxLength = 4;
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(92, 20);
            this.txtYear.TabIndex = 13;
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
            this.lblRegNoCargados.Location = new System.Drawing.Point(585, 68);
            this.lblRegNoCargados.Name = "lblRegNoCargados";
            this.lblRegNoCargados.Size = new System.Drawing.Size(177, 15);
            this.lblRegNoCargados.TabIndex = 25;
            this.lblRegNoCargados.Text = "0  registro(s) que no se cargaron";
            this.lblRegNoCargados.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // dgvRegistrosNoCargados
            // 
            this.dgvRegistrosNoCargados.AllowUserToAddRows = false;
            this.dgvRegistrosNoCargados.AllowUserToDeleteRows = false;
            this.dgvRegistrosNoCargados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRegistrosNoCargados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegistrosNoCargados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Item1,
            this.Item2});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRegistrosNoCargados.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvRegistrosNoCargados.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvRegistrosNoCargados.Location = new System.Drawing.Point(5, 87);
            this.dgvRegistrosNoCargados.Name = "dgvRegistrosNoCargados";
            this.dgvRegistrosNoCargados.ReadOnly = true;
            this.dgvRegistrosNoCargados.Size = new System.Drawing.Size(759, 308);
            this.dgvRegistrosNoCargados.TabIndex = 26;
            // 
            // Item1
            // 
            this.Item1.DataPropertyName = "Item1";
            this.Item1.HeaderText = "RUC";
            this.Item1.Name = "Item1";
            this.Item1.ReadOnly = true;
            // 
            // Item2
            // 
            this.Item2.DataPropertyName = "Item2";
            this.Item2.HeaderText = "Razón Social";
            this.Item2.Name = "Item2";
            this.Item2.ReadOnly = true;
            this.Item2.Width = 600;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmCargaDatosTop
            // 
            this.ClientSize = new System.Drawing.Size(781, 470);
            this.DoubleBuffered = true;
            this.Name = "frmCargaDatosTop";
            this.Text = "Carga de Datos Top 10k";
            this.Load += new System.EventHandler(this.frmCargaDatosTop_Load);
            this.grpDato.ResumeLayout(false);
            this.panelEx1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistrosNoCargados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelEx1;
        private System.Windows.Forms.ProgressBar pbCargaTop10K;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.ButtonX btnImportar;
        protected DevComponents.DotNetBar.LabelX lblRegistros;
        private DevComponents.DotNetBar.Controls.TextBoxX txtYear;
        protected DevComponents.DotNetBar.LabelX lblRegNoCargados;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvRegistrosNoCargados;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}