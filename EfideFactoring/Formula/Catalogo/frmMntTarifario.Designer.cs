namespace EfideFactoring.Formula.Catalogo
{
    partial class frmMntTarifario
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvTarifario = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.IdTarifario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipCxcNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdCalculo_tt_Dsc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PorConcepto_tt_Dsc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdFrecuencia_tt_Dsc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorMonedaID_Dsc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PorMonto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bTransferencia = new DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn();
            this.PanelEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTarifario)).BeginInit();
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
            this.RibbonBar1.Size = new System.Drawing.Size(908, 40);
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
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click_1);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click_1);
            // 
            // btnSalir
            // 
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // PanelEx1
            // 
            this.PanelEx1.Size = new System.Drawing.Size(908, 61);
            this.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.PanelEx1.Style.GradientAngle = 90;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(407, 6);
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(330, 6);
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click_1);
            // 
            // TextBoxX1
            // 
            // 
            // 
            // 
            this.TextBoxX1.Border.Class = "TextBoxBorder";
            this.TextBoxX1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TextBoxX1.Location = new System.Drawing.Point(74, 16);
            this.TextBoxX1.Size = new System.Drawing.Size(233, 20);
            // 
            // LabelX1
            // 
            // 
            // 
            // 
            this.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LabelX1.Size = new System.Drawing.Size(73, 23);
            this.LabelX1.Text = "Concepto";
            // 
            // lblGrilla
            // 
            // 
            // 
            // 
            this.lblGrilla.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblGrilla.Location = new System.Drawing.Point(0, 105);
            this.lblGrilla.Text = "Tarifario";
            // 
            // lblRegistros
            // 
            // 
            // 
            // 
            this.lblRegistros.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblRegistros.Location = new System.Drawing.Point(732, 105);
            // 
            // dgvTarifario
            // 
            this.dgvTarifario.AllowUserToAddRows = false;
            this.dgvTarifario.AllowUserToDeleteRows = false;
            this.dgvTarifario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTarifario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvTarifario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTarifario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdTarifario,
            this.tipCxcNombre,
            this.IdCalculo_tt_Dsc,
            this.PorConcepto_tt_Dsc,
            this.IdFrecuencia_tt_Dsc,
            this.valorMonedaID_Dsc,
            this.Monto,
            this.PorMonto,
            this.bTransferencia});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTarifario.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvTarifario.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvTarifario.Location = new System.Drawing.Point(0, 133);
            this.dgvTarifario.Name = "dgvTarifario";
            this.dgvTarifario.ReadOnly = true;
            this.dgvTarifario.RowHeadersWidth = 10;
            this.dgvTarifario.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvTarifario.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvTarifario.Size = new System.Drawing.Size(908, 340);
            this.dgvTarifario.TabIndex = 24;
            // 
            // IdTarifario
            // 
            this.IdTarifario.DataPropertyName = "IdTarifario";
            this.IdTarifario.HeaderText = "Código";
            this.IdTarifario.Name = "IdTarifario";
            this.IdTarifario.ReadOnly = true;
            this.IdTarifario.Width = 65;
            // 
            // tipCxcNombre
            // 
            this.tipCxcNombre.DataPropertyName = "tipCxcNombre";
            this.tipCxcNombre.HeaderText = "Concepto";
            this.tipCxcNombre.Name = "tipCxcNombre";
            this.tipCxcNombre.ReadOnly = true;
            this.tipCxcNombre.Width = 78;
            // 
            // IdCalculo_tt_Dsc
            // 
            this.IdCalculo_tt_Dsc.DataPropertyName = "IdCalculo_tt_Dsc";
            this.IdCalculo_tt_Dsc.HeaderText = "Cálculo";
            this.IdCalculo_tt_Dsc.Name = "IdCalculo_tt_Dsc";
            this.IdCalculo_tt_Dsc.ReadOnly = true;
            this.IdCalculo_tt_Dsc.Width = 67;
            // 
            // PorConcepto_tt_Dsc
            // 
            this.PorConcepto_tt_Dsc.DataPropertyName = "PorConcepto_tt_Dsc";
            this.PorConcepto_tt_Dsc.HeaderText = "Porcentaje de";
            this.PorConcepto_tt_Dsc.Name = "PorConcepto_tt_Dsc";
            this.PorConcepto_tt_Dsc.ReadOnly = true;
            this.PorConcepto_tt_Dsc.Width = 98;
            // 
            // IdFrecuencia_tt_Dsc
            // 
            this.IdFrecuencia_tt_Dsc.DataPropertyName = "IdFrecuencia_tt_Dsc";
            this.IdFrecuencia_tt_Dsc.HeaderText = "Frecuencia";
            this.IdFrecuencia_tt_Dsc.Name = "IdFrecuencia_tt_Dsc";
            this.IdFrecuencia_tt_Dsc.ReadOnly = true;
            this.IdFrecuencia_tt_Dsc.Width = 85;
            // 
            // valorMonedaID_Dsc
            // 
            this.valorMonedaID_Dsc.DataPropertyName = "valorMonedaID_Dsc";
            this.valorMonedaID_Dsc.HeaderText = "Moneda";
            this.valorMonedaID_Dsc.Name = "valorMonedaID_Dsc";
            this.valorMonedaID_Dsc.ReadOnly = true;
            this.valorMonedaID_Dsc.Width = 71;
            // 
            // Monto
            // 
            this.Monto.DataPropertyName = "Monto";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Monto.DefaultCellStyle = dataGridViewCellStyle1;
            this.Monto.HeaderText = "Monto";
            this.Monto.Name = "Monto";
            this.Monto.ReadOnly = true;
            this.Monto.Width = 62;
            // 
            // PorMonto
            // 
            this.PorMonto.DataPropertyName = "PorMonto";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.PorMonto.DefaultCellStyle = dataGridViewCellStyle2;
            this.PorMonto.HeaderText = "Porcentaje";
            this.PorMonto.Name = "PorMonto";
            this.PorMonto.ReadOnly = true;
            this.PorMonto.Width = 83;
            // 
            // bTransferencia
            // 
            this.bTransferencia.Checked = true;
            this.bTransferencia.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.bTransferencia.CheckValue = "N";
            this.bTransferencia.DataPropertyName = "bTransferencia";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.bTransferencia.DefaultCellStyle = dataGridViewCellStyle3;
            this.bTransferencia.HeaderText = "Transferencia";
            this.bTransferencia.Name = "bTransferencia";
            this.bTransferencia.ReadOnly = true;
            this.bTransferencia.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.bTransferencia.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.bTransferencia.Width = 97;
            // 
            // frmMntTarifario
            // 
            this.ClientSize = new System.Drawing.Size(908, 477);
            this.Controls.Add(this.dgvTarifario);
            this.DoubleBuffered = true;
            this.Name = "frmMntTarifario";
            this.Text = "Mantenimiento de Tarifario";
            this.Controls.SetChildIndex(this.dgvTarifario, 0);
            this.Controls.SetChildIndex(this.RibbonBar1, 0);
            this.Controls.SetChildIndex(this.PanelEx1, 0);
            this.Controls.SetChildIndex(this.lblRegistros, 0);
            this.Controls.SetChildIndex(this.lblGrilla, 0);
            this.PanelEx1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTarifario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX dgvTarifario;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdTarifario;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipCxcNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCalculo_tt_Dsc;
        private System.Windows.Forms.DataGridViewTextBoxColumn PorConcepto_tt_Dsc;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdFrecuencia_tt_Dsc;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorMonedaID_Dsc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto;
        private System.Windows.Forms.DataGridViewTextBoxColumn PorMonto;
        private DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn bTransferencia;
    }
}
