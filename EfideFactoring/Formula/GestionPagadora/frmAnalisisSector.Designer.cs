namespace EfideFactoring.Formula.GestionPagadora
{
    partial class frmAnalisisSector
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvSectores = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.ChartPie = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.IdSector_tt_Dsc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Saldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Porj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpDato.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSectores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartPie)).BeginInit();
            this.SuspendLayout();
            // 
            // grpDato
            // 
            this.grpDato.Controls.Add(this.dgvSectores);
            this.grpDato.Controls.Add(this.ChartPie);
            this.grpDato.Size = new System.Drawing.Size(1238, 591);
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
            this.btnCancelar.Location = new System.Drawing.Point(1157, 612);
            this.btnCancelar.Text = "Cerrar";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(1066, 612);
            this.btnAceptar.Visible = false;
            // 
            // dgvSectores
            // 
            this.dgvSectores.AllowUserToAddRows = false;
            this.dgvSectores.AllowUserToDeleteRows = false;
            this.dgvSectores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSectores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdSector_tt_Dsc,
            this.Saldo,
            this.Porj});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSectores.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSectores.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvSectores.Location = new System.Drawing.Point(5, 3);
            this.dgvSectores.Name = "dgvSectores";
            this.dgvSectores.ReadOnly = true;
            this.dgvSectores.Size = new System.Drawing.Size(389, 579);
            this.dgvSectores.TabIndex = 0;
            // 
            // ChartPie
            // 
            chartArea1.Name = "ChartArea1";
            this.ChartPie.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.ChartPie.Legends.Add(legend1);
            this.ChartPie.Location = new System.Drawing.Point(400, 3);
            this.ChartPie.Name = "ChartPie";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.ChartPie.Series.Add(series1);
            this.ChartPie.Size = new System.Drawing.Size(827, 579);
            this.ChartPie.TabIndex = 1;
            this.ChartPie.Text = "chart1";
            // 
            // IdSector_tt_Dsc
            // 
            this.IdSector_tt_Dsc.DataPropertyName = "IdSector_tt_Dsc";
            this.IdSector_tt_Dsc.HeaderText = "Sector";
            this.IdSector_tt_Dsc.Name = "IdSector_tt_Dsc";
            this.IdSector_tt_Dsc.ReadOnly = true;
            this.IdSector_tt_Dsc.Width = 200;
            // 
            // Saldo
            // 
            this.Saldo.DataPropertyName = "Saldo";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = null;
            this.Saldo.DefaultCellStyle = dataGridViewCellStyle1;
            this.Saldo.HeaderText = "Uso";
            this.Saldo.Name = "Saldo";
            this.Saldo.ReadOnly = true;
            // 
            // Porj
            // 
            this.Porj.DataPropertyName = "Porj";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.Porj.DefaultCellStyle = dataGridViewCellStyle2;
            this.Porj.HeaderText = "%";
            this.Porj.Name = "Porj";
            this.Porj.ReadOnly = true;
            this.Porj.Width = 40;
            // 
            // frmAnalisisSector
            // 
            this.ClientSize = new System.Drawing.Size(1246, 648);
            this.DoubleBuffered = true;
            this.Name = "frmAnalisisSector";
            this.Text = "Análisis de Sectores";
            this.Load += new System.EventHandler(this.frmAnalisisSector_Load);
            this.grpDato.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSectores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartPie)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX dgvSectores;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartPie;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdSector_tt_Dsc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Saldo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Porj;
    }
}