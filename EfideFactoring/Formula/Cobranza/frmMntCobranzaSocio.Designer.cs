namespace EfideFactoring.Formula.Cobranza
{
    partial class frmMntCobranzaSocio
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvCobranza = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.IdCobranza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdPagadora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdPagadora_Dsc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdSocio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdSocio_Dsc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtValuta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdTipoCobranza_tt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdMoneda_tt_Dsc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdMoneda_tt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CtasBancariasID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdOperacion_tt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdTipoAbono_tt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatosAdicionales = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.socioBancoID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PanelEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCobranza)).BeginInit();
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
            this.RibbonBar1.Size = new System.Drawing.Size(841, 40);
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
            this.btnEliminar.Text = "Anular";
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // PanelEx1
            // 
            this.PanelEx1.Size = new System.Drawing.Size(841, 54);
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
            this.btnLimpiar.Location = new System.Drawing.Point(385, 4);
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(308, 4);
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // TextBoxX1
            // 
            // 
            // 
            // 
            this.TextBoxX1.Border.Class = "TextBoxBorder";
            this.TextBoxX1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TextBoxX1.Location = new System.Drawing.Point(65, 16);
            // 
            // LabelX1
            // 
            // 
            // 
            // 
            this.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LabelX1.Location = new System.Drawing.Point(12, 16);
            this.LabelX1.Size = new System.Drawing.Size(37, 23);
            this.LabelX1.Text = "Socio";
            this.LabelX1.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // lblGrilla
            // 
            // 
            // 
            // 
            this.lblGrilla.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // lblRegistros
            // 
            // 
            // 
            // 
            this.lblRegistros.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblRegistros.Location = new System.Drawing.Point(665, 97);
            // 
            // dgvCobranza
            // 
            this.dgvCobranza.AllowUserToAddRows = false;
            this.dgvCobranza.AllowUserToDeleteRows = false;
            this.dgvCobranza.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCobranza.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCobranza.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdCobranza,
            this.IdPagadora,
            this.IdPagadora_Dsc,
            this.IdSocio,
            this.IdSocio_Dsc,
            this.Fecha,
            this.dtValuta,
            this.IdTipoCobranza_tt,
            this.IdMoneda_tt_Dsc,
            this.IdMoneda_tt,
            this.CtasBancariasID,
            this.Total,
            this.IdOperacion_tt,
            this.IdTipoAbono_tt,
            this.DatosAdicionales,
            this.socioBancoID,
            this.Status,
            this.Estado});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCobranza.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCobranza.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvCobranza.Location = new System.Drawing.Point(0, 116);
            this.dgvCobranza.Name = "dgvCobranza";
            this.dgvCobranza.ReadOnly = true;
            this.dgvCobranza.RowHeadersWidth = 10;
            this.dgvCobranza.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvCobranza.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvCobranza.Size = new System.Drawing.Size(841, 289);
            this.dgvCobranza.TabIndex = 23;
            // 
            // IdCobranza
            // 
            this.IdCobranza.DataPropertyName = "IdCobranza";
            this.IdCobranza.HeaderText = "Nro. Cobranza";
            this.IdCobranza.Name = "IdCobranza";
            this.IdCobranza.ReadOnly = true;
            this.IdCobranza.Width = 80;
            // 
            // IdPagadora
            // 
            this.IdPagadora.DataPropertyName = "IdPagadora";
            this.IdPagadora.HeaderText = "IdPagadora";
            this.IdPagadora.Name = "IdPagadora";
            this.IdPagadora.ReadOnly = true;
            this.IdPagadora.Visible = false;
            this.IdPagadora.Width = 87;
            // 
            // IdPagadora_Dsc
            // 
            this.IdPagadora_Dsc.DataPropertyName = "IdPagadora_Dsc";
            this.IdPagadora_Dsc.HeaderText = "Pagadadora";
            this.IdPagadora_Dsc.Name = "IdPagadora_Dsc";
            this.IdPagadora_Dsc.ReadOnly = true;
            this.IdPagadora_Dsc.Visible = false;
            this.IdPagadora_Dsc.Width = 90;
            // 
            // IdSocio
            // 
            this.IdSocio.DataPropertyName = "IdSocio";
            this.IdSocio.HeaderText = "IdSocio";
            this.IdSocio.Name = "IdSocio";
            this.IdSocio.ReadOnly = true;
            this.IdSocio.Visible = false;
            this.IdSocio.Width = 50;
            // 
            // IdSocio_Dsc
            // 
            this.IdSocio_Dsc.DataPropertyName = "IdSocio_Dsc";
            this.IdSocio_Dsc.HeaderText = "Socio";
            this.IdSocio_Dsc.Name = "IdSocio_Dsc";
            this.IdSocio_Dsc.ReadOnly = true;
            this.IdSocio_Dsc.Width = 200;
            // 
            // Fecha
            // 
            this.Fecha.DataPropertyName = "dtRegistro";
            this.Fecha.HeaderText = "Fecha Registro";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // dtValuta
            // 
            this.dtValuta.DataPropertyName = "dtValuta";
            this.dtValuta.HeaderText = "Fecha Valuta";
            this.dtValuta.Name = "dtValuta";
            this.dtValuta.ReadOnly = true;
            // 
            // IdTipoCobranza_tt
            // 
            this.IdTipoCobranza_tt.DataPropertyName = "IdTipoCobranza_tt";
            this.IdTipoCobranza_tt.HeaderText = "IdTipoCobranza_tt";
            this.IdTipoCobranza_tt.Name = "IdTipoCobranza_tt";
            this.IdTipoCobranza_tt.ReadOnly = true;
            this.IdTipoCobranza_tt.Visible = false;
            this.IdTipoCobranza_tt.Width = 119;
            // 
            // IdMoneda_tt_Dsc
            // 
            this.IdMoneda_tt_Dsc.DataPropertyName = "IdMoneda_tt_Dsc";
            this.IdMoneda_tt_Dsc.HeaderText = "Moneda";
            this.IdMoneda_tt_Dsc.Name = "IdMoneda_tt_Dsc";
            this.IdMoneda_tt_Dsc.ReadOnly = true;
            this.IdMoneda_tt_Dsc.Width = 71;
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
            // CtasBancariasID
            // 
            this.CtasBancariasID.DataPropertyName = "CtasBancariasID";
            this.CtasBancariasID.HeaderText = "CtasBancariasID";
            this.CtasBancariasID.Name = "CtasBancariasID";
            this.CtasBancariasID.ReadOnly = true;
            this.CtasBancariasID.Visible = false;
            this.CtasBancariasID.Width = 111;
            // 
            // Total
            // 
            this.Total.DataPropertyName = "nTotal";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = null;
            this.Total.DefaultCellStyle = dataGridViewCellStyle1;
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // IdOperacion_tt
            // 
            this.IdOperacion_tt.DataPropertyName = "IdOperacion_tt";
            this.IdOperacion_tt.HeaderText = "IdOperacion_tt";
            this.IdOperacion_tt.Name = "IdOperacion_tt";
            this.IdOperacion_tt.ReadOnly = true;
            this.IdOperacion_tt.Visible = false;
            this.IdOperacion_tt.Width = 102;
            // 
            // IdTipoAbono_tt
            // 
            this.IdTipoAbono_tt.DataPropertyName = "IdTipoAbono_tt";
            this.IdTipoAbono_tt.HeaderText = "IdTipoAbono_tt";
            this.IdTipoAbono_tt.Name = "IdTipoAbono_tt";
            this.IdTipoAbono_tt.ReadOnly = true;
            this.IdTipoAbono_tt.Visible = false;
            this.IdTipoAbono_tt.Width = 105;
            // 
            // DatosAdicionales
            // 
            this.DatosAdicionales.DataPropertyName = "DatosAdicionales";
            this.DatosAdicionales.HeaderText = "DatosAdicionales";
            this.DatosAdicionales.Name = "DatosAdicionales";
            this.DatosAdicionales.ReadOnly = true;
            this.DatosAdicionales.Visible = false;
            this.DatosAdicionales.Width = 114;
            // 
            // socioBancoID
            // 
            this.socioBancoID.DataPropertyName = "socioBancoID";
            this.socioBancoID.HeaderText = "socioBancoID";
            this.socioBancoID.Name = "socioBancoID";
            this.socioBancoID.ReadOnly = true;
            this.socioBancoID.Visible = false;
            this.socioBancoID.Width = 99;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Visible = false;
            this.Status.Width = 62;
            // 
            // Estado
            // 
            this.Estado.DataPropertyName = "Estado";
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            // 
            // frmMntCobranzaSocio
            // 
            this.ClientSize = new System.Drawing.Size(841, 417);
            this.Controls.Add(this.dgvCobranza);
            this.DoubleBuffered = true;
            this.Name = "frmMntCobranzaSocio";
            this.Text = "Cobranza por Socio";
            this.Load += new System.EventHandler(this.frmMntCobranzaSocio_Load);
            this.Controls.SetChildIndex(this.RibbonBar1, 0);
            this.Controls.SetChildIndex(this.PanelEx1, 0);
            this.Controls.SetChildIndex(this.lblRegistros, 0);
            this.Controls.SetChildIndex(this.lblGrilla, 0);
            this.Controls.SetChildIndex(this.dgvCobranza, 0);
            this.PanelEx1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCobranza)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX dgvCobranza;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCobranza;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdPagadora;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdPagadora_Dsc;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdSocio;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdSocio_Dsc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtValuta;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdTipoCobranza_tt;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdMoneda_tt_Dsc;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdMoneda_tt;
        private System.Windows.Forms.DataGridViewTextBoxColumn CtasBancariasID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdOperacion_tt;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdTipoAbono_tt;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatosAdicionales;
        private System.Windows.Forms.DataGridViewTextBoxColumn socioBancoID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
    }
}