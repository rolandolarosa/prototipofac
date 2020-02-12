namespace EfideFactoring.Formula.Catalogo
{
    partial class frmMntSocioGrupo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMntSocioGrupo));
            this.dgvGrupo = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.IdGrupo_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vcGrupo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserNew = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateNew = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.lblRegistrosDet = new DevComponents.DotNetBar.LabelX();
            this.dgvSocio = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.IdGrupo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdSocio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdSocio_Dsc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserNew_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateNew_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEliminarDet = new DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn();
            this.PanelEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrupo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSocio)).BeginInit();
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
            this.RibbonBar1.Size = new System.Drawing.Size(776, 40);
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
            this.PanelEx1.Size = new System.Drawing.Size(776, 54);
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
            this.LabelX1.Text = "Grupo";
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
            this.lblRegistros.Location = new System.Drawing.Point(600, 97);
            // 
            // dgvGrupo
            // 
            this.dgvGrupo.AllowUserToAddRows = false;
            this.dgvGrupo.AllowUserToDeleteRows = false;
            this.dgvGrupo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvGrupo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrupo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdGrupo_,
            this.vcGrupo,
            this.UserNew,
            this.DateNew});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvGrupo.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvGrupo.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvGrupo.Location = new System.Drawing.Point(0, 117);
            this.dgvGrupo.Name = "dgvGrupo";
            this.dgvGrupo.ReadOnly = true;
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            this.dgvGrupo.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvGrupo.Size = new System.Drawing.Size(776, 202);
            this.dgvGrupo.TabIndex = 22;
            this.dgvGrupo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGrupo_CellClick);
            this.dgvGrupo.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGrupo_CellContentDoubleClick);
            // 
            // IdGrupo_
            // 
            this.IdGrupo_.DataPropertyName = "IdGrupo";
            this.IdGrupo_.HeaderText = "Código";
            this.IdGrupo_.Name = "IdGrupo_";
            this.IdGrupo_.ReadOnly = true;
            // 
            // vcGrupo
            // 
            this.vcGrupo.DataPropertyName = "vcGrupo";
            this.vcGrupo.HeaderText = "Riesgo Unico";
            this.vcGrupo.Name = "vcGrupo";
            this.vcGrupo.ReadOnly = true;
            this.vcGrupo.Width = 250;
            // 
            // UserNew
            // 
            this.UserNew.DataPropertyName = "UserNew";
            this.UserNew.HeaderText = "UserNew";
            this.UserNew.Name = "UserNew";
            this.UserNew.ReadOnly = true;
            this.UserNew.Visible = false;
            // 
            // DateNew
            // 
            this.DateNew.DataPropertyName = "DateNew";
            this.DateNew.HeaderText = "DateNew";
            this.DateNew.Name = "DateNew";
            this.DateNew.ReadOnly = true;
            this.DateNew.Visible = false;
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelX2.Location = new System.Drawing.Point(0, 320);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(108, 23);
            this.labelX2.TabIndex = 29;
            this.labelX2.Text = "Socios Vinculados";
            // 
            // lblRegistrosDet
            // 
            this.lblRegistrosDet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.lblRegistrosDet.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblRegistrosDet.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblRegistrosDet.Location = new System.Drawing.Point(600, 321);
            this.lblRegistrosDet.Name = "lblRegistrosDet";
            this.lblRegistrosDet.Size = new System.Drawing.Size(176, 22);
            this.lblRegistrosDet.TabIndex = 28;
            this.lblRegistrosDet.Text = "0  registro(s)";
            this.lblRegistrosDet.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // dgvSocio
            // 
            this.dgvSocio.AllowUserToAddRows = false;
            this.dgvSocio.AllowUserToDeleteRows = false;
            this.dgvSocio.AllowUserToOrderColumns = true;
            this.dgvSocio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSocio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSocio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdGrupo,
            this.IdSocio,
            this.IdSocio_Dsc,
            this.UserNew_,
            this.DateNew_,
            this.btnEliminarDet});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSocio.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvSocio.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvSocio.Location = new System.Drawing.Point(0, 349);
            this.dgvSocio.Name = "dgvSocio";
            this.dgvSocio.ReadOnly = true;
            this.dgvSocio.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvSocio.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvSocio.Size = new System.Drawing.Size(776, 228);
            this.dgvSocio.TabIndex = 30;
            this.dgvSocio.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSocio_CellClick);
            // 
            // IdGrupo
            // 
            this.IdGrupo.DataPropertyName = "IdGrupo";
            this.IdGrupo.HeaderText = "IdGrupo";
            this.IdGrupo.Name = "IdGrupo";
            this.IdGrupo.ReadOnly = true;
            this.IdGrupo.Visible = false;
            this.IdGrupo.Width = 70;
            // 
            // IdSocio
            // 
            this.IdSocio.DataPropertyName = "IdSocio";
            this.IdSocio.HeaderText = "Código";
            this.IdSocio.Name = "IdSocio";
            this.IdSocio.ReadOnly = true;
            this.IdSocio.Width = 65;
            // 
            // IdSocio_Dsc
            // 
            this.IdSocio_Dsc.DataPropertyName = "IdSocio_Dsc";
            this.IdSocio_Dsc.HeaderText = "Socio";
            this.IdSocio_Dsc.Name = "IdSocio_Dsc";
            this.IdSocio_Dsc.ReadOnly = true;
            this.IdSocio_Dsc.Width = 200;
            // 
            // UserNew_
            // 
            this.UserNew_.DataPropertyName = "UserNew";
            this.UserNew_.HeaderText = "Usuario Registro";
            this.UserNew_.Name = "UserNew_";
            this.UserNew_.ReadOnly = true;
            // 
            // DateNew_
            // 
            this.DateNew_.DataPropertyName = "DateNew";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Format = "g";
            dataGridViewCellStyle3.NullValue = null;
            this.DateNew_.DefaultCellStyle = dataGridViewCellStyle3;
            this.DateNew_.HeaderText = "Fecha Registro";
            this.DateNew_.Name = "DateNew_";
            this.DateNew_.ReadOnly = true;
            // 
            // btnEliminarDet
            // 
            this.btnEliminarDet.HeaderText = "";
            this.btnEliminarDet.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminarDet.Image")));
            this.btnEliminarDet.Name = "btnEliminarDet";
            this.btnEliminarDet.ReadOnly = true;
            this.btnEliminarDet.Text = null;
            this.btnEliminarDet.Width = 40;
            // 
            // frmMntSocioGrupo
            // 
            this.ClientSize = new System.Drawing.Size(776, 589);
            this.Controls.Add(this.dgvSocio);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.lblRegistrosDet);
            this.Controls.Add(this.dgvGrupo);
            this.DoubleBuffered = true;
            this.Name = "frmMntSocioGrupo";
            this.Text = "Riesgo Unico";
            this.Load += new System.EventHandler(this.frmMntSocioGrupo_Load);
            this.Controls.SetChildIndex(this.RibbonBar1, 0);
            this.Controls.SetChildIndex(this.PanelEx1, 0);
            this.Controls.SetChildIndex(this.lblRegistros, 0);
            this.Controls.SetChildIndex(this.lblGrilla, 0);
            this.Controls.SetChildIndex(this.dgvGrupo, 0);
            this.Controls.SetChildIndex(this.lblRegistrosDet, 0);
            this.Controls.SetChildIndex(this.labelX2, 0);
            this.Controls.SetChildIndex(this.dgvSocio, 0);
            this.PanelEx1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrupo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSocio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX dgvGrupo;
        protected DevComponents.DotNetBar.LabelX labelX2;
        protected DevComponents.DotNetBar.LabelX lblRegistrosDet;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvSocio;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdGrupo_;
        private System.Windows.Forms.DataGridViewTextBoxColumn vcGrupo;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserNew;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateNew;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdGrupo;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdSocio;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdSocio_Dsc;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserNew_;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateNew_;
        private DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn btnEliminarDet;
    }
}