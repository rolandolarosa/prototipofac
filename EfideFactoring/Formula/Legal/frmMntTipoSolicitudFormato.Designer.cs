namespace EfideFactoring.Formula.Legal
{
    partial class frmMntTipoSolicitudFormato
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grpDato = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.btnCancelar = new DevComponents.DotNetBar.ButtonX();
            this.LabelX1 = new DevComponents.DotNetBar.LabelX();
            this.dgvTipoSolicitud = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.dgvFormatoLegal = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.IdTipoSolicitud_tt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdFormatoDocLegal_tt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdFormatoDocLegal_tt_Dsc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChkSel = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Table_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Table_Parent_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Table_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Table_Order = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Table_Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnActualizarData = new DevComponents.DotNetBar.ButtonX();
            this.grpDato.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoSolicitud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFormatoLegal)).BeginInit();
            this.SuspendLayout();
            // 
            // grpDato
            // 
            this.grpDato.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpDato.CanvasColor = System.Drawing.SystemColors.Control;
            this.grpDato.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.grpDato.Controls.Add(this.btnActualizarData);
            this.grpDato.Controls.Add(this.labelX2);
            this.grpDato.Controls.Add(this.dgvFormatoLegal);
            this.grpDato.Controls.Add(this.dgvTipoSolicitud);
            this.grpDato.Controls.Add(this.LabelX1);
            this.grpDato.Location = new System.Drawing.Point(4, 15);
            this.grpDato.Name = "grpDato";
            this.grpDato.Size = new System.Drawing.Size(822, 468);
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
            this.grpDato.TabIndex = 14;
            // 
            // btnCancelar
            // 
            this.btnCancelar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Image = global::EfideFactoring.Properties.Resources.cerrar;
            this.btnCancelar.Location = new System.Drawing.Point(741, 489);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(85, 30);
            this.btnCancelar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCancelar.TabIndex = 16;
            this.btnCancelar.Text = "Salir";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // LabelX1
            // 
            this.LabelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LabelX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelX1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LabelX1.Location = new System.Drawing.Point(15, 15);
            this.LabelX1.Name = "LabelX1";
            this.LabelX1.Size = new System.Drawing.Size(300, 23);
            this.LabelX1.TabIndex = 30;
            this.LabelX1.Text = "Tipo de Solicitud";
            // 
            // dgvTipoSolicitud
            // 
            this.dgvTipoSolicitud.AllowUserToAddRows = false;
            this.dgvTipoSolicitud.AllowUserToDeleteRows = false;
            this.dgvTipoSolicitud.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvTipoSolicitud.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTipoSolicitud.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Table_Id,
            this.Table_Parent_Id,
            this.Table_Name,
            this.Table_Order,
            this.Table_Value});
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTipoSolicitud.DefaultCellStyle = dataGridViewCellStyle15;
            this.dgvTipoSolicitud.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvTipoSolicitud.Location = new System.Drawing.Point(15, 44);
            this.dgvTipoSolicitud.Name = "dgvTipoSolicitud";
            this.dgvTipoSolicitud.ReadOnly = true;
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            this.dgvTipoSolicitud.RowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dgvTipoSolicitud.Size = new System.Drawing.Size(394, 403);
            this.dgvTipoSolicitud.TabIndex = 31;
            this.dgvTipoSolicitud.SelectionChanged += new System.EventHandler(this.dgvTipoSolicitud_SelectionChanged);
            // 
            // dgvFormatoLegal
            // 
            this.dgvFormatoLegal.AllowUserToAddRows = false;
            this.dgvFormatoLegal.AllowUserToDeleteRows = false;
            this.dgvFormatoLegal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvFormatoLegal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFormatoLegal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdTipoSolicitud_tt,
            this.IdFormatoDocLegal_tt,
            this.IdFormatoDocLegal_tt_Dsc,
            this.ChkSel});
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFormatoLegal.DefaultCellStyle = dataGridViewCellStyle13;
            this.dgvFormatoLegal.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvFormatoLegal.Location = new System.Drawing.Point(415, 44);
            this.dgvFormatoLegal.Name = "dgvFormatoLegal";
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            this.dgvFormatoLegal.RowsDefaultCellStyle = dataGridViewCellStyle14;
            this.dgvFormatoLegal.Size = new System.Drawing.Size(394, 403);
            this.dgvFormatoLegal.TabIndex = 32;
            this.dgvFormatoLegal.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgvFormatoLegal_CurrentCellDirtyStateChanged);
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelX2.Location = new System.Drawing.Point(415, 15);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(300, 23);
            this.labelX2.TabIndex = 33;
            this.labelX2.Text = "Formatos Legal";
            // 
            // IdTipoSolicitud_tt
            // 
            this.IdTipoSolicitud_tt.DataPropertyName = "IdTipoSolicitud_tt";
            this.IdTipoSolicitud_tt.HeaderText = "IdTipoSolicitud_tt";
            this.IdTipoSolicitud_tt.Name = "IdTipoSolicitud_tt";
            this.IdTipoSolicitud_tt.ReadOnly = true;
            this.IdTipoSolicitud_tt.Visible = false;
            // 
            // IdFormatoDocLegal_tt
            // 
            this.IdFormatoDocLegal_tt.DataPropertyName = "IdFormatoDocLegal_tt";
            this.IdFormatoDocLegal_tt.HeaderText = "IdFormatoDocLegal_tt";
            this.IdFormatoDocLegal_tt.Name = "IdFormatoDocLegal_tt";
            this.IdFormatoDocLegal_tt.ReadOnly = true;
            this.IdFormatoDocLegal_tt.Visible = false;
            // 
            // IdFormatoDocLegal_tt_Dsc
            // 
            this.IdFormatoDocLegal_tt_Dsc.DataPropertyName = "IdFormatoDocLegal_tt_Dsc";
            this.IdFormatoDocLegal_tt_Dsc.HeaderText = "Formato";
            this.IdFormatoDocLegal_tt_Dsc.Name = "IdFormatoDocLegal_tt_Dsc";
            this.IdFormatoDocLegal_tt_Dsc.ReadOnly = true;
            this.IdFormatoDocLegal_tt_Dsc.Width = 300;
            // 
            // ChkSel
            // 
            this.ChkSel.DataPropertyName = "ChkSel";
            this.ChkSel.HeaderText = "";
            this.ChkSel.Name = "ChkSel";
            this.ChkSel.Width = 40;
            // 
            // Table_Id
            // 
            this.Table_Id.DataPropertyName = "Table_Id";
            this.Table_Id.HeaderText = "Table_Id";
            this.Table_Id.Name = "Table_Id";
            this.Table_Id.ReadOnly = true;
            this.Table_Id.Visible = false;
            // 
            // Table_Parent_Id
            // 
            this.Table_Parent_Id.DataPropertyName = "Table_Parent_Id";
            this.Table_Parent_Id.HeaderText = "Table_Parent_Id";
            this.Table_Parent_Id.Name = "Table_Parent_Id";
            this.Table_Parent_Id.ReadOnly = true;
            this.Table_Parent_Id.Visible = false;
            // 
            // Table_Name
            // 
            this.Table_Name.DataPropertyName = "Table_Name";
            this.Table_Name.HeaderText = "Tipo Solicitud";
            this.Table_Name.Name = "Table_Name";
            this.Table_Name.ReadOnly = true;
            this.Table_Name.Width = 350;
            // 
            // Table_Order
            // 
            this.Table_Order.DataPropertyName = "Table_Order";
            this.Table_Order.HeaderText = "Table_Order";
            this.Table_Order.Name = "Table_Order";
            this.Table_Order.ReadOnly = true;
            this.Table_Order.Visible = false;
            // 
            // Table_Value
            // 
            this.Table_Value.DataPropertyName = "Table_Value";
            this.Table_Value.HeaderText = "Table_Value";
            this.Table_Value.Name = "Table_Value";
            this.Table_Value.ReadOnly = true;
            this.Table_Value.Visible = false;
            // 
            // btnActualizarData
            // 
            this.btnActualizarData.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnActualizarData.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnActualizarData.Image = global::EfideFactoring.Properties.Resources.refresh;
            this.btnActualizarData.Location = new System.Drawing.Point(321, 14);
            this.btnActualizarData.Name = "btnActualizarData";
            this.btnActualizarData.Size = new System.Drawing.Size(88, 23);
            this.btnActualizarData.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnActualizarData.TabIndex = 34;
            this.btnActualizarData.Text = "Actualizar";
            this.btnActualizarData.Click += new System.EventHandler(this.btnActualizarData_Click);
            // 
            // frmMntTipoSolicitudFormato
            // 
            this.ClientSize = new System.Drawing.Size(830, 525);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.grpDato);
            this.DoubleBuffered = true;
            this.Name = "frmMntTipoSolicitudFormato";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuración de Formatos por Tipo Solicitud";
            this.Load += new System.EventHandler(this.frmMntTipoSolicitudFormato_Load);
            this.grpDato.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoSolicitud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFormatoLegal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected DevComponents.DotNetBar.ButtonX btnCancelar;
        protected DevComponents.DotNetBar.Controls.GroupPanel grpDato;
        internal DevComponents.DotNetBar.LabelX LabelX1;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvTipoSolicitud;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvFormatoLegal;
        internal DevComponents.DotNetBar.LabelX labelX2;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdTipoSolicitud_tt;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdFormatoDocLegal_tt;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdFormatoDocLegal_tt_Dsc;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ChkSel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Table_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Table_Parent_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Table_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Table_Order;
        private System.Windows.Forms.DataGridViewTextBoxColumn Table_Value;
        private DevComponents.DotNetBar.ButtonX btnActualizarData;
    }
}