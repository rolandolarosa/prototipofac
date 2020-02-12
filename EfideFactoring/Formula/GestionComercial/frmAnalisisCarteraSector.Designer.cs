namespace EfideFactoring.Formula.GestionComercial
{
    partial class frmAnalisisCarteraSector
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dgvDatos = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.Sector = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vigente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Utilizado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Porcentaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChartPie = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ChartLine = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.grpDato.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartPie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartLine)).BeginInit();
            this.SuspendLayout();
            // 
            // grpDato
            // 
            this.grpDato.Controls.Add(this.ChartLine);
            this.grpDato.Controls.Add(this.ChartPie);
            this.grpDato.Controls.Add(this.dgvDatos);
            this.grpDato.Size = new System.Drawing.Size(845, 445);
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
            this.btnCancelar.Location = new System.Drawing.Point(764, 466);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(673, 466);
            this.btnAceptar.Visible = false;
            // 
            // dgvDatos
            // 
            this.dgvDatos.AllowUserToAddRows = false;
            this.dgvDatos.AllowUserToDeleteRows = false;
            this.dgvDatos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sector,
            this.Vigente,
            this.Utilizado,
            this.Porcentaje});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDatos.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDatos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvDatos.Location = new System.Drawing.Point(5, 19);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.ReadOnly = true;
            this.dgvDatos.Size = new System.Drawing.Size(410, 150);
            this.dgvDatos.TabIndex = 1;
            // 
            // Sector
            // 
            this.Sector.DataPropertyName = "Sector";
            this.Sector.HeaderText = "Sector";
            this.Sector.Name = "Sector";
            this.Sector.ReadOnly = true;
            // 
            // Vigente
            // 
            this.Vigente.DataPropertyName = "Vigente";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = null;
            this.Vigente.DefaultCellStyle = dataGridViewCellStyle1;
            this.Vigente.HeaderText = "Vigente";
            this.Vigente.Name = "Vigente";
            this.Vigente.ReadOnly = true;
            // 
            // Utilizado
            // 
            this.Utilizado.DataPropertyName = "Utilizado";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.Utilizado.DefaultCellStyle = dataGridViewCellStyle2;
            this.Utilizado.HeaderText = "Utilizado";
            this.Utilizado.Name = "Utilizado";
            this.Utilizado.ReadOnly = true;
            this.Utilizado.Width = 80;
            // 
            // Porcentaje
            // 
            this.Porcentaje.DataPropertyName = "Porcentaje";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N0";
            dataGridViewCellStyle3.NullValue = null;
            this.Porcentaje.DefaultCellStyle = dataGridViewCellStyle3;
            this.Porcentaje.HeaderText = "Porcentaje";
            this.Porcentaje.Name = "Porcentaje";
            this.Porcentaje.ReadOnly = true;
            this.Porcentaje.Width = 60;
            // 
            // ChartPie
            // 
            chartArea2.Name = "ChartArea1";
            this.ChartPie.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.ChartPie.Legends.Add(legend2);
            this.ChartPie.Location = new System.Drawing.Point(421, 19);
            this.ChartPie.Name = "ChartPie";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.ChartPie.Series.Add(series2);
            this.ChartPie.Size = new System.Drawing.Size(386, 150);
            this.ChartPie.TabIndex = 2;
            this.ChartPie.Text = "chart1";
            // 
            // ChartLine
            // 
            chartArea1.Name = "ChartArea1";
            this.ChartLine.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.ChartLine.Legends.Add(legend1);
            this.ChartLine.Location = new System.Drawing.Point(5, 195);
            this.ChartLine.Name = "ChartLine";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.ChartLine.Series.Add(series1);
            this.ChartLine.Size = new System.Drawing.Size(802, 221);
            this.ChartLine.TabIndex = 3;
            this.ChartLine.Text = "chart1";
            // 
            // frmAnalisisCarteraSector
            // 
            this.ClientSize = new System.Drawing.Size(853, 502);
            this.DoubleBuffered = true;
            this.Name = "frmAnalisisCarteraSector";
            this.Text = "Análisis Cartera Sector";
            this.Load += new System.EventHandler(this.frmAnalisisCarteraSector_Load);
            this.grpDato.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartPie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartLine)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX dgvDatos;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartPie;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartLine;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sector;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vigente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Utilizado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Porcentaje;
    }
}