namespace EfideFactoring.Formula.Consulta
{
    partial class frmBusquedaPagadoraEfideTop
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
            this.RibbonBar1 = new DevComponents.DotNetBar.RibbonBar();
            this.btnSalir = new DevComponents.DotNetBar.ButtonItem();
            this.PanelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.btnLimpiar = new DevComponents.DotNetBar.ButtonX();
            this.txtvcPagadora = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnBuscar = new DevComponents.DotNetBar.ButtonX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.dgvPagadoras = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.IdPagadora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vcRuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vcPagadora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdSector_tt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LineaDisponible = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PanelEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagadoras)).BeginInit();
            this.SuspendLayout();
            // 
            // RibbonBar1
            // 
            this.RibbonBar1.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.RibbonBar1.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.RibbonBar1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.RibbonBar1.ContainerControlProcessDialogKey = true;
            this.RibbonBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.RibbonBar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnSalir});
            this.RibbonBar1.Location = new System.Drawing.Point(0, 0);
            this.RibbonBar1.Name = "RibbonBar1";
            this.RibbonBar1.Size = new System.Drawing.Size(607, 40);
            this.RibbonBar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010;
            this.RibbonBar1.TabIndex = 29;
            // 
            // 
            // 
            this.RibbonBar1.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.RibbonBar1.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // btnSalir
            // 
            this.btnSalir.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnSalir.Image = global::EfideFactoring.Properties.Resources.cerrar;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.SubItemsExpandWidth = 14;
            this.btnSalir.Text = "Salir";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // PanelEx1
            // 
            this.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2010;
            this.PanelEx1.Controls.Add(this.btnLimpiar);
            this.PanelEx1.Controls.Add(this.txtvcPagadora);
            this.PanelEx1.Controls.Add(this.btnBuscar);
            this.PanelEx1.Controls.Add(this.labelX1);
            this.PanelEx1.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelEx1.Location = new System.Drawing.Point(0, 40);
            this.PanelEx1.Name = "PanelEx1";
            this.PanelEx1.Size = new System.Drawing.Size(607, 58);
            this.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.PanelEx1.Style.GradientAngle = 90;
            this.PanelEx1.TabIndex = 30;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnLimpiar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnLimpiar.Image = global::EfideFactoring.Properties.Resources.magifier_zoom_out;
            this.btnLimpiar.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnLimpiar.Location = new System.Drawing.Point(393, 5);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(73, 44);
            this.btnLimpiar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnLimpiar.TabIndex = 3;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // txtvcPagadora
            // 
            // 
            // 
            // 
            this.txtvcPagadora.Border.Class = "TextBoxBorder";
            this.txtvcPagadora.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtvcPagadora.Location = new System.Drawing.Point(109, 17);
            this.txtvcPagadora.Name = "txtvcPagadora";
            this.txtvcPagadora.Size = new System.Drawing.Size(195, 20);
            this.txtvcPagadora.TabIndex = 1;
            // 
            // btnBuscar
            // 
            this.btnBuscar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnBuscar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnBuscar.Image = global::EfideFactoring.Properties.Resources.buscar;
            this.btnBuscar.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnBuscar.Location = new System.Drawing.Point(314, 5);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(73, 44);
            this.btnBuscar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(12, 17);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(91, 23);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "RUC / Pagadora";
            // 
            // dgvPagadoras
            // 
            this.dgvPagadoras.AllowUserToAddRows = false;
            this.dgvPagadoras.AllowUserToDeleteRows = false;
            this.dgvPagadoras.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPagadoras.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvPagadoras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPagadoras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdPagadora,
            this.vcRuc,
            this.vcPagadora,
            this.IdSector_tt,
            this.LineaDisponible,
            this.Tipo});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPagadoras.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPagadoras.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvPagadoras.Location = new System.Drawing.Point(0, 114);
            this.dgvPagadoras.Name = "dgvPagadoras";
            this.dgvPagadoras.ReadOnly = true;
            this.dgvPagadoras.RowHeadersWidth = 10;
            this.dgvPagadoras.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvPagadoras.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvPagadoras.Size = new System.Drawing.Size(607, 243);
            this.dgvPagadoras.TabIndex = 31;
            this.dgvPagadoras.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPagadoras_CellContentDoubleClick);
            // 
            // IdPagadora
            // 
            this.IdPagadora.DataPropertyName = "IdPagadora";
            this.IdPagadora.HeaderText = "IdPagadora";
            this.IdPagadora.Name = "IdPagadora";
            this.IdPagadora.ReadOnly = true;
            this.IdPagadora.Visible = false;
            this.IdPagadora.Width = 68;
            // 
            // vcRuc
            // 
            this.vcRuc.DataPropertyName = "vcRuc";
            this.vcRuc.HeaderText = "RUC";
            this.vcRuc.Name = "vcRuc";
            this.vcRuc.ReadOnly = true;
            this.vcRuc.Width = 55;
            // 
            // vcPagadora
            // 
            this.vcPagadora.DataPropertyName = "vcPagadora";
            this.vcPagadora.HeaderText = "Razón Social";
            this.vcPagadora.Name = "vcPagadora";
            this.vcPagadora.ReadOnly = true;
            this.vcPagadora.Width = 87;
            // 
            // IdSector_tt
            // 
            this.IdSector_tt.DataPropertyName = "IdSector_tt";
            this.IdSector_tt.HeaderText = "IdSector_tt";
            this.IdSector_tt.Name = "IdSector_tt";
            this.IdSector_tt.ReadOnly = true;
            this.IdSector_tt.Visible = false;
            this.IdSector_tt.Width = 84;
            // 
            // LineaDisponible
            // 
            this.LineaDisponible.DataPropertyName = "LineaDisponible";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = null;
            this.LineaDisponible.DefaultCellStyle = dataGridViewCellStyle1;
            this.LineaDisponible.HeaderText = "Linea Disponible";
            this.LineaDisponible.Name = "LineaDisponible";
            this.LineaDisponible.ReadOnly = true;
            this.LineaDisponible.Width = 101;
            // 
            // Tipo
            // 
            this.Tipo.DataPropertyName = "Tipo";
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            this.Tipo.Visible = false;
            this.Tipo.Width = 53;
            // 
            // frmBusquedaPagadoraEfideTop
            // 
            this.AcceptButton = this.btnBuscar;
            this.ClientSize = new System.Drawing.Size(607, 369);
            this.Controls.Add(this.dgvPagadoras);
            this.Controls.Add(this.PanelEx1);
            this.Controls.Add(this.RibbonBar1);
            this.DoubleBuffered = true;
            this.Name = "frmBusquedaPagadoraEfideTop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Busqueda de Pagadoras Efide / Top";
            this.Load += new System.EventHandler(this.frmBusquedaPagadoraEfideTop_Load);
            this.PanelEx1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagadoras)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected DevComponents.DotNetBar.RibbonBar RibbonBar1;
        protected DevComponents.DotNetBar.ButtonItem btnSalir;
        protected DevComponents.DotNetBar.PanelEx PanelEx1;
        protected DevComponents.DotNetBar.ButtonX btnLimpiar;
        private DevComponents.DotNetBar.Controls.TextBoxX txtvcPagadora;
        protected DevComponents.DotNetBar.ButtonX btnBuscar;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvPagadoras;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdPagadora;
        private System.Windows.Forms.DataGridViewTextBoxColumn vcRuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn vcPagadora;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdSector_tt;
        private System.Windows.Forms.DataGridViewTextBoxColumn LineaDisponible;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
    }
}