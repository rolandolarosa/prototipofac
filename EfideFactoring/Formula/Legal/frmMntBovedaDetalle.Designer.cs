namespace EfideFactoring.Formula.Legal
{
    partial class frmMntBovedaDetalle
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMntBovedaDetalle));
            this.panelEx2 = new DevComponents.DotNetBar.PanelEx();
            this.lblSocio = new DevComponents.DotNetBar.LabelX();
            this.dgvBovedaDetalle = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.btnCerrarBoveda = new DevComponents.DotNetBar.ButtonX();
            this.btnObservar = new DevComponents.DotNetBar.ButtonX();
            this.IdBoveda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdFormatoDocLegal_tt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdFormatoDocLegal_tt_Dsc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bFlgRecepcion = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dtRecepcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vSubido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtAdjunto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vArchivoAdjunto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImportePago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdLote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSubir = new DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn();
            this.btnVer = new DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn();
            this.grpDato.SuspendLayout();
            this.panelEx2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBovedaDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // grpDato
            // 
            this.grpDato.Controls.Add(this.labelX1);
            this.grpDato.Controls.Add(this.dgvBovedaDetalle);
            this.grpDato.Controls.Add(this.panelEx2);
            this.grpDato.Size = new System.Drawing.Size(838, 440);
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
            this.btnCancelar.Location = new System.Drawing.Point(757, 461);
            this.btnCancelar.Text = "Cerrar";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(626, 461);
            this.btnAceptar.Size = new System.Drawing.Size(125, 30);
            this.btnAceptar.Text = "Enviar a Boveda";
            this.btnAceptar.Visible = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // panelEx2
            // 
            this.panelEx2.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2010;
            this.panelEx2.Controls.Add(this.lblSocio);
            this.panelEx2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEx2.Location = new System.Drawing.Point(0, 0);
            this.panelEx2.Name = "panelEx2";
            this.panelEx2.Size = new System.Drawing.Size(832, 48);
            this.panelEx2.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx2.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx2.Style.GradientAngle = 90;
            this.panelEx2.TabIndex = 60;
            // 
            // lblSocio
            // 
            // 
            // 
            // 
            this.lblSocio.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblSocio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSocio.ForeColor = System.Drawing.Color.Black;
            this.lblSocio.Location = new System.Drawing.Point(16, 13);
            this.lblSocio.Name = "lblSocio";
            this.lblSocio.Size = new System.Drawing.Size(559, 20);
            this.lblSocio.TabIndex = 0;
            this.lblSocio.Text = "Socio";
            // 
            // dgvBovedaDetalle
            // 
            this.dgvBovedaDetalle.AllowUserToAddRows = false;
            this.dgvBovedaDetalle.AllowUserToDeleteRows = false;
            this.dgvBovedaDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBovedaDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdBoveda,
            this.IdFormatoDocLegal_tt,
            this.IdFormatoDocLegal_tt_Dsc,
            this.bFlgRecepcion,
            this.dtRecepcion,
            this.vSubido,
            this.dtAdjunto,
            this.vArchivoAdjunto,
            this.FechaPago,
            this.ImportePago,
            this.IdLote,
            this.cItem,
            this.btnSubir,
            this.btnVer});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBovedaDetalle.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvBovedaDetalle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvBovedaDetalle.Location = new System.Drawing.Point(0, 76);
            this.dgvBovedaDetalle.Name = "dgvBovedaDetalle";
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            this.dgvBovedaDetalle.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvBovedaDetalle.Size = new System.Drawing.Size(832, 344);
            this.dgvBovedaDetalle.TabIndex = 61;
            this.dgvBovedaDetalle.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBovedaDetalle_CellClick);
            this.dgvBovedaDetalle.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgvBovedaDetalle_CurrentCellDirtyStateChanged);
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(0, 51);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(234, 23);
            this.labelX1.TabIndex = 62;
            this.labelX1.Text = "Documentos";
            // 
            // btnCerrarBoveda
            // 
            this.btnCerrarBoveda.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCerrarBoveda.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCerrarBoveda.Image = global::EfideFactoring.Properties.Resources.btn_ok;
            this.btnCerrarBoveda.Location = new System.Drawing.Point(356, 461);
            this.btnCerrarBoveda.Name = "btnCerrarBoveda";
            this.btnCerrarBoveda.Size = new System.Drawing.Size(130, 30);
            this.btnCerrarBoveda.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCerrarBoveda.TabIndex = 14;
            this.btnCerrarBoveda.Text = "Cerrar Boveda";
            this.btnCerrarBoveda.Visible = false;
            this.btnCerrarBoveda.Click += new System.EventHandler(this.btnCerrarBoveda_Click);
            // 
            // btnObservar
            // 
            this.btnObservar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnObservar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnObservar.Image = global::EfideFactoring.Properties.Resources.buscar;
            this.btnObservar.Location = new System.Drawing.Point(492, 461);
            this.btnObservar.Name = "btnObservar";
            this.btnObservar.Size = new System.Drawing.Size(130, 30);
            this.btnObservar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnObservar.TabIndex = 15;
            this.btnObservar.Text = "Observar";
            this.btnObservar.Visible = false;
            this.btnObservar.Click += new System.EventHandler(this.btnObservar_Click);
            // 
            // IdBoveda
            // 
            this.IdBoveda.DataPropertyName = "IdBoveda";
            this.IdBoveda.HeaderText = "IdBoveda";
            this.IdBoveda.Name = "IdBoveda";
            this.IdBoveda.Visible = false;
            // 
            // IdFormatoDocLegal_tt
            // 
            this.IdFormatoDocLegal_tt.DataPropertyName = "IdFormatoDocLegal_tt";
            this.IdFormatoDocLegal_tt.HeaderText = "Código";
            this.IdFormatoDocLegal_tt.Name = "IdFormatoDocLegal_tt";
            // 
            // IdFormatoDocLegal_tt_Dsc
            // 
            this.IdFormatoDocLegal_tt_Dsc.DataPropertyName = "IdFormatoDocLegal_tt_Dsc";
            this.IdFormatoDocLegal_tt_Dsc.HeaderText = "Formato / Documento";
            this.IdFormatoDocLegal_tt_Dsc.Name = "IdFormatoDocLegal_tt_Dsc";
            this.IdFormatoDocLegal_tt_Dsc.Width = 200;
            // 
            // bFlgRecepcion
            // 
            this.bFlgRecepcion.DataPropertyName = "bFlgRecepcion";
            this.bFlgRecepcion.HeaderText = "Recepción";
            this.bFlgRecepcion.Name = "bFlgRecepcion";
            this.bFlgRecepcion.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.bFlgRecepcion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.bFlgRecepcion.Width = 65;
            // 
            // dtRecepcion
            // 
            this.dtRecepcion.DataPropertyName = "dtRecepcion";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Format = "g";
            dataGridViewCellStyle1.NullValue = null;
            this.dtRecepcion.DefaultCellStyle = dataGridViewCellStyle1;
            this.dtRecepcion.HeaderText = "Fecha Recepción";
            this.dtRecepcion.Name = "dtRecepcion";
            // 
            // vSubido
            // 
            this.vSubido.DataPropertyName = "vSubido";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.vSubido.DefaultCellStyle = dataGridViewCellStyle2;
            this.vSubido.HeaderText = "Subido?";
            this.vSubido.Name = "vSubido";
            this.vSubido.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.vSubido.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.vSubido.Width = 50;
            // 
            // dtAdjunto
            // 
            this.dtAdjunto.DataPropertyName = "dtAdjunto";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Format = "g";
            this.dtAdjunto.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtAdjunto.FillWeight = 120F;
            this.dtAdjunto.HeaderText = "Fecha Subida";
            this.dtAdjunto.Name = "dtAdjunto";
            this.dtAdjunto.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dtAdjunto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dtAdjunto.Width = 130;
            // 
            // vArchivoAdjunto
            // 
            this.vArchivoAdjunto.DataPropertyName = "vArchivoAdjunto";
            this.vArchivoAdjunto.HeaderText = "vArchivoAdjunto";
            this.vArchivoAdjunto.Name = "vArchivoAdjunto";
            this.vArchivoAdjunto.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.vArchivoAdjunto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.vArchivoAdjunto.Visible = false;
            // 
            // FechaPago
            // 
            this.FechaPago.DataPropertyName = "FechaPago";
            this.FechaPago.HeaderText = "FechaPago";
            this.FechaPago.Name = "FechaPago";
            this.FechaPago.Visible = false;
            // 
            // ImportePago
            // 
            this.ImportePago.DataPropertyName = "ImportePago";
            this.ImportePago.HeaderText = "ImportePago";
            this.ImportePago.Name = "ImportePago";
            this.ImportePago.Visible = false;
            // 
            // IdLote
            // 
            this.IdLote.DataPropertyName = "IdLote";
            this.IdLote.HeaderText = "IdLote";
            this.IdLote.Name = "IdLote";
            this.IdLote.Visible = false;
            // 
            // cItem
            // 
            this.cItem.DataPropertyName = "cItem";
            this.cItem.HeaderText = "cItem";
            this.cItem.Name = "cItem";
            this.cItem.Visible = false;
            // 
            // btnSubir
            // 
            this.btnSubir.HeaderText = "";
            this.btnSubir.Image = ((System.Drawing.Image)(resources.GetObject("btnSubir.Image")));
            this.btnSubir.Name = "btnSubir";
            this.btnSubir.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btnSubir.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.btnSubir.Text = null;
            this.btnSubir.ToolTipText = "Subir Documento";
            this.btnSubir.Width = 40;
            // 
            // btnVer
            // 
            this.btnVer.HeaderText = "";
            this.btnVer.Image = ((System.Drawing.Image)(resources.GetObject("btnVer.Image")));
            this.btnVer.Name = "btnVer";
            this.btnVer.Text = null;
            this.btnVer.Width = 40;
            // 
            // frmMntBovedaDetalle
            // 
            this.ClientSize = new System.Drawing.Size(846, 497);
            this.Controls.Add(this.btnObservar);
            this.Controls.Add(this.btnCerrarBoveda);
            this.DoubleBuffered = true;
            this.Name = "frmMntBovedaDetalle";
            this.Text = "Documentos de Boveda";
            this.Load += new System.EventHandler(this.frmMntBovedaDetalle_Load);
            this.Controls.SetChildIndex(this.grpDato, 0);
            this.Controls.SetChildIndex(this.btnAceptar, 0);
            this.Controls.SetChildIndex(this.btnCancelar, 0);
            this.Controls.SetChildIndex(this.btnCerrarBoveda, 0);
            this.Controls.SetChildIndex(this.btnObservar, 0);
            this.grpDato.ResumeLayout(false);
            this.panelEx2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBovedaDetalle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected DevComponents.DotNetBar.PanelEx panelEx2;
        protected DevComponents.DotNetBar.LabelX lblSocio;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvBovedaDetalle;
        private DevComponents.DotNetBar.ButtonX btnCerrarBoveda;
        private DevComponents.DotNetBar.ButtonX btnObservar;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdBoveda;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdFormatoDocLegal_tt;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdFormatoDocLegal_tt_Dsc;
        private System.Windows.Forms.DataGridViewCheckBoxColumn bFlgRecepcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtRecepcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn vSubido;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtAdjunto;
        private System.Windows.Forms.DataGridViewTextBoxColumn vArchivoAdjunto;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImportePago;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdLote;
        private System.Windows.Forms.DataGridViewTextBoxColumn cItem;
        private DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn btnSubir;
        private DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn btnVer;
    }
}