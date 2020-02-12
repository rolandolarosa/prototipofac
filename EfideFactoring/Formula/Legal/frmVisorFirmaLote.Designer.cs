namespace EfideFactoring.Formula.Legal
{
    partial class frmVisorFirmaLote
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVisorFirmaLote));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvFacultad = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.lblTitulo = new DevComponents.DotNetBar.LabelX();
            this.NroFila = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vcPagadora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdFacultad_tt_Dsc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdRepresentanteF1_Dsc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImageFirma1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.IdRepresentanteF2_Dsc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImageFirma2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.grpDato.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacultad)).BeginInit();
            this.SuspendLayout();
            // 
            // grpDato
            // 
            this.grpDato.Controls.Add(this.lblTitulo);
            this.grpDato.Controls.Add(this.dgvFacultad);
            this.grpDato.Size = new System.Drawing.Size(1764, 699);
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
            this.btnCancelar.Location = new System.Drawing.Point(1683, 720);
            this.btnCancelar.Text = "Cerrar";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(1592, 720);
            this.btnAceptar.Visible = false;
            // 
            // dgvFacultad
            // 
            this.dgvFacultad.AllowUserToAddRows = false;
            this.dgvFacultad.AllowUserToDeleteRows = false;
            this.dgvFacultad.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvFacultad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFacultad.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NroFila,
            this.vcPagadora,
            this.IdFacultad_tt_Dsc,
            this.IdRepresentanteF1_Dsc,
            this.ImageFirma1,
            this.IdRepresentanteF2_Dsc,
            this.ImageFirma2});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFacultad.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvFacultad.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvFacultad.Location = new System.Drawing.Point(6, 36);
            this.dgvFacultad.Name = "dgvFacultad";
            this.dgvFacultad.ReadOnly = true;
            this.dgvFacultad.RowTemplate.Height = 250;
            this.dgvFacultad.Size = new System.Drawing.Size(1745, 642);
            this.dgvFacultad.TabIndex = 39;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lblTitulo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Black;
            this.lblTitulo.Location = new System.Drawing.Point(6, 4);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(1745, 23);
            this.lblTitulo.TabIndex = 40;
            this.lblTitulo.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // NroFila
            // 
            this.NroFila.DataPropertyName = "NroFila";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Red;
            this.NroFila.DefaultCellStyle = dataGridViewCellStyle1;
            this.NroFila.HeaderText = "";
            this.NroFila.Name = "NroFila";
            this.NroFila.ReadOnly = true;
            this.NroFila.Width = 25;
            // 
            // vcPagadora
            // 
            this.vcPagadora.DataPropertyName = "vcPagadora";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.vcPagadora.DefaultCellStyle = dataGridViewCellStyle2;
            this.vcPagadora.HeaderText = "Pagadora";
            this.vcPagadora.Name = "vcPagadora";
            this.vcPagadora.ReadOnly = true;
            this.vcPagadora.Width = 150;
            // 
            // IdFacultad_tt_Dsc
            // 
            this.IdFacultad_tt_Dsc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.IdFacultad_tt_Dsc.DataPropertyName = "IdFacultad_tt_Dsc";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.IdFacultad_tt_Dsc.DefaultCellStyle = dataGridViewCellStyle3;
            this.IdFacultad_tt_Dsc.HeaderText = "Facultades";
            this.IdFacultad_tt_Dsc.Name = "IdFacultad_tt_Dsc";
            this.IdFacultad_tt_Dsc.ReadOnly = true;
            this.IdFacultad_tt_Dsc.Width = 200;
            // 
            // IdRepresentanteF1_Dsc
            // 
            this.IdRepresentanteF1_Dsc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.IdRepresentanteF1_Dsc.DataPropertyName = "IdRepresentanteF1_Dsc";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.IdRepresentanteF1_Dsc.DefaultCellStyle = dataGridViewCellStyle4;
            this.IdRepresentanteF1_Dsc.HeaderText = "Representante 1";
            this.IdRepresentanteF1_Dsc.Name = "IdRepresentanteF1_Dsc";
            this.IdRepresentanteF1_Dsc.ReadOnly = true;
            this.IdRepresentanteF1_Dsc.Width = 200;
            // 
            // ImageFirma1
            // 
            this.ImageFirma1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ImageFirma1.DataPropertyName = "ImageFirma1";
            this.ImageFirma1.HeaderText = "Firma 1";
            this.ImageFirma1.Image = ((System.Drawing.Image)(resources.GetObject("ImageFirma1.Image")));
            this.ImageFirma1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.ImageFirma1.Name = "ImageFirma1";
            this.ImageFirma1.ReadOnly = true;
            this.ImageFirma1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ImageFirma1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ImageFirma1.Width = 450;
            // 
            // IdRepresentanteF2_Dsc
            // 
            this.IdRepresentanteF2_Dsc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.IdRepresentanteF2_Dsc.DataPropertyName = "IdRepresentanteF2_Dsc";
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.IdRepresentanteF2_Dsc.DefaultCellStyle = dataGridViewCellStyle5;
            this.IdRepresentanteF2_Dsc.HeaderText = "Representante 2";
            this.IdRepresentanteF2_Dsc.Name = "IdRepresentanteF2_Dsc";
            this.IdRepresentanteF2_Dsc.ReadOnly = true;
            this.IdRepresentanteF2_Dsc.Width = 200;
            // 
            // ImageFirma2
            // 
            this.ImageFirma2.DataPropertyName = "ImageFirma2";
            this.ImageFirma2.HeaderText = "Firma 2";
            this.ImageFirma2.Image = ((System.Drawing.Image)(resources.GetObject("ImageFirma2.Image")));
            this.ImageFirma2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.ImageFirma2.Name = "ImageFirma2";
            this.ImageFirma2.ReadOnly = true;
            this.ImageFirma2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ImageFirma2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ImageFirma2.Width = 450;
            // 
            // frmVisorFirmaLote
            // 
            this.ClientSize = new System.Drawing.Size(1772, 756);
            this.DoubleBuffered = true;
            this.Name = "frmVisorFirmaLote";
            this.Text = "Combinación de Firmas";
            this.Load += new System.EventHandler(this.frmVisorFirmaLote_Load);
            this.grpDato.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacultad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX dgvFacultad;
        private DevComponents.DotNetBar.LabelX lblTitulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroFila;
        private System.Windows.Forms.DataGridViewTextBoxColumn vcPagadora;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdFacultad_tt_Dsc;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdRepresentanteF1_Dsc;
        private System.Windows.Forms.DataGridViewImageColumn ImageFirma1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdRepresentanteF2_Dsc;
        private System.Windows.Forms.DataGridViewImageColumn ImageFirma2;
    }
}