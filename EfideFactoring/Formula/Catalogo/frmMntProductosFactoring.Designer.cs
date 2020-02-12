namespace EfideFactoring.Formula.Catalogo
{
    partial class frmMntProductosFactoring
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
            this.dgvProductosFactoring = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.prodCreditoID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lineaCreditoID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.condicionID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monedaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PanelEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductosFactoring)).BeginInit();
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
            this.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.PanelEx1.Style.GradientAngle = 90;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // TextBoxX1
            // 
            // 
            // 
            // 
            this.TextBoxX1.Border.Class = "TextBoxBorder";
            this.TextBoxX1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // LabelX1
            // 
            // 
            // 
            // 
            this.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // lblGrilla
            // 
            // 
            // 
            // 
            this.lblGrilla.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblGrilla.Text = "Productos Factoring";
            // 
            // lblRegistros
            // 
            // 
            // 
            // 
            this.lblRegistros.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // dgvProductosFactoring
            // 
            this.dgvProductosFactoring.AllowUserToAddRows = false;
            this.dgvProductosFactoring.AllowUserToDeleteRows = false;
            this.dgvProductosFactoring.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProductosFactoring.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvProductosFactoring.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductosFactoring.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.prodCreditoID,
            this.lineaCreditoID,
            this.condicionID,
            this.monedaID});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProductosFactoring.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProductosFactoring.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvProductosFactoring.Location = new System.Drawing.Point(0, 121);
            this.dgvProductosFactoring.Name = "dgvProductosFactoring";
            this.dgvProductosFactoring.ReadOnly = true;
            this.dgvProductosFactoring.RowHeadersWidth = 10;
            this.dgvProductosFactoring.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvProductosFactoring.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvProductosFactoring.Size = new System.Drawing.Size(735, 293);
            this.dgvProductosFactoring.TabIndex = 24;
            // 
            // prodCreditoID
            // 
            this.prodCreditoID.DataPropertyName = "prodCreditoID";
            this.prodCreditoID.HeaderText = "prodCreditoID";
            this.prodCreditoID.Name = "prodCreditoID";
            this.prodCreditoID.ReadOnly = true;
            this.prodCreditoID.Width = 97;
            // 
            // lineaCreditoID
            // 
            this.lineaCreditoID.DataPropertyName = "lineaCreditoID";
            this.lineaCreditoID.HeaderText = "lineaCreditoID";
            this.lineaCreditoID.Name = "lineaCreditoID";
            this.lineaCreditoID.ReadOnly = true;
            this.lineaCreditoID.Width = 98;
            // 
            // condicionID
            // 
            this.condicionID.DataPropertyName = "condicionID";
            this.condicionID.HeaderText = "condicionID";
            this.condicionID.Name = "condicionID";
            this.condicionID.ReadOnly = true;
            this.condicionID.Width = 89;
            // 
            // monedaID
            // 
            this.monedaID.DataPropertyName = "monedaID";
            this.monedaID.HeaderText = "monedaID";
            this.monedaID.Name = "monedaID";
            this.monedaID.ReadOnly = true;
            this.monedaID.Width = 81;
            // 
            // frmMntProductosFactoring
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 414);
            this.Controls.Add(this.dgvProductosFactoring);
            this.DoubleBuffered = true;
            this.Name = "frmMntProductosFactoring";
            this.Text = "Mantenimiento de Productos Factoring";
            this.Load += new System.EventHandler(this.frmMntProductosFactoring_Load);
            this.Controls.SetChildIndex(this.RibbonBar1, 0);
            this.Controls.SetChildIndex(this.PanelEx1, 0);
            this.Controls.SetChildIndex(this.lblRegistros, 0);
            this.Controls.SetChildIndex(this.lblGrilla, 0);
            this.Controls.SetChildIndex(this.dgvProductosFactoring, 0);
            this.PanelEx1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductosFactoring)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX dgvProductosFactoring;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodCreditoID;
        private System.Windows.Forms.DataGridViewTextBoxColumn lineaCreditoID;
        private System.Windows.Forms.DataGridViewTextBoxColumn condicionID;
        private System.Windows.Forms.DataGridViewTextBoxColumn monedaID;
    }
}