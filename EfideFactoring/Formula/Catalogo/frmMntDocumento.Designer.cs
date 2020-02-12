namespace EfideFactoring.Formula.Catalogo
{
    partial class frmMntDocumento
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
            this.dgvDocumento = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.IdDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cAbreviatura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vMascara = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bTituloValor = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.FlgFisicoElectronico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FlgImportePago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PanelEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocumento)).BeginInit();
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
            // btnConsultar
            // 
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
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
            this.LabelX1.Text = "Documento";
            // 
            // lblGrilla
            // 
            // 
            // 
            // 
            this.lblGrilla.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblGrilla.Text = "Documentos";
            // 
            // lblRegistros
            // 
            // 
            // 
            // 
            this.lblRegistros.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // dgvDocumento
            // 
            this.dgvDocumento.AllowUserToAddRows = false;
            this.dgvDocumento.AllowUserToDeleteRows = false;
            this.dgvDocumento.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDocumento.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvDocumento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDocumento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdDocumento,
            this.vDocumento,
            this.cAbreviatura,
            this.vMascara,
            this.bTituloValor,
            this.FlgFisicoElectronico,
            this.FlgImportePago});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDocumento.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDocumento.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvDocumento.Location = new System.Drawing.Point(0, 125);
            this.dgvDocumento.Name = "dgvDocumento";
            this.dgvDocumento.ReadOnly = true;
            this.dgvDocumento.RowHeadersWidth = 10;
            this.dgvDocumento.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvDocumento.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvDocumento.Size = new System.Drawing.Size(735, 277);
            this.dgvDocumento.TabIndex = 22;
            // 
            // IdDocumento
            // 
            this.IdDocumento.DataPropertyName = "IdDocumento";
            this.IdDocumento.HeaderText = "Código";
            this.IdDocumento.Name = "IdDocumento";
            this.IdDocumento.ReadOnly = true;
            this.IdDocumento.Width = 77;
            // 
            // vDocumento
            // 
            this.vDocumento.DataPropertyName = "vDocumento";
            this.vDocumento.HeaderText = "Documento";
            this.vDocumento.Name = "vDocumento";
            this.vDocumento.ReadOnly = true;
            this.vDocumento.Width = 105;
            // 
            // cAbreviatura
            // 
            this.cAbreviatura.DataPropertyName = "cAbreviatura";
            this.cAbreviatura.HeaderText = "Abreviatura";
            this.cAbreviatura.Name = "cAbreviatura";
            this.cAbreviatura.ReadOnly = true;
            this.cAbreviatura.Width = 106;
            // 
            // vMascara
            // 
            this.vMascara.DataPropertyName = "vMascara";
            this.vMascara.HeaderText = "Máscara";
            this.vMascara.Name = "vMascara";
            this.vMascara.ReadOnly = true;
            this.vMascara.Width = 87;
            // 
            // bTituloValor
            // 
            this.bTituloValor.DataPropertyName = "bTituloValor";
            this.bTituloValor.HeaderText = "Titulo Valor";
            this.bTituloValor.Name = "bTituloValor";
            this.bTituloValor.ReadOnly = true;
            this.bTituloValor.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.bTituloValor.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.bTituloValor.Width = 105;
            // 
            // FlgFisicoElectronico
            // 
            this.FlgFisicoElectronico.DataPropertyName = "FlgFisicoElectronico";
            this.FlgFisicoElectronico.HeaderText = "FlgFisicoElectronico";
            this.FlgFisicoElectronico.Name = "FlgFisicoElectronico";
            this.FlgFisicoElectronico.ReadOnly = true;
            this.FlgFisicoElectronico.Visible = false;
            this.FlgFisicoElectronico.Width = 158;
            // 
            // FlgImportePago
            // 
            this.FlgImportePago.DataPropertyName = "FlgImportePago";
            this.FlgImportePago.HeaderText = "FlgImportePago";
            this.FlgImportePago.Name = "FlgImportePago";
            this.FlgImportePago.ReadOnly = true;
            this.FlgImportePago.Visible = false;
            this.FlgImportePago.Width = 132;
            // 
            // frmMntDocumento
            // 
            this.ClientSize = new System.Drawing.Size(735, 414);
            this.Controls.Add(this.dgvDocumento);
            this.DoubleBuffered = true;
            this.Name = "frmMntDocumento";
            this.Text = "Mantenimiento de Documentos";
            this.Controls.SetChildIndex(this.RibbonBar1, 0);
            this.Controls.SetChildIndex(this.PanelEx1, 0);
            this.Controls.SetChildIndex(this.lblRegistros, 0);
            this.Controls.SetChildIndex(this.lblGrilla, 0);
            this.Controls.SetChildIndex(this.dgvDocumento, 0);
            this.PanelEx1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocumento)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX dgvDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn vDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn cAbreviatura;
        private System.Windows.Forms.DataGridViewTextBoxColumn vMascara;
        private System.Windows.Forms.DataGridViewCheckBoxColumn bTituloValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn FlgFisicoElectronico;
        private System.Windows.Forms.DataGridViewTextBoxColumn FlgImportePago;



    }
}