namespace EfideFactoring.Formula.Legal
{
    partial class frmQryBoveda
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvBoveda = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.IdBoveda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdSolicitud = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vRazonSocialSocio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtEnvioBoveda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vUEnvioBoveda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtCierreBoveda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vUCierreBoveda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdEstado_tt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdEstado_tt_Dsc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnVer = new DevComponents.DotNetBar.ButtonItem();
            this.chkVerHistoricos = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.PanelEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBoveda)).BeginInit();
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
            this.RibbonBar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnVer});
            this.RibbonBar1.Size = new System.Drawing.Size(1177, 40);
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
            this.btnNuevo.Visible = false;
            // 
            // btnEditar
            // 
            this.btnEditar.Visible = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Visible = false;
            // 
            // PanelEx1
            // 
            this.PanelEx1.Controls.Add(this.chkVerHistoricos);
            this.PanelEx1.Size = new System.Drawing.Size(1177, 54);
            this.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.PanelEx1.Style.GradientAngle = 90;
            this.PanelEx1.Controls.SetChildIndex(this.LabelX1, 0);
            this.PanelEx1.Controls.SetChildIndex(this.TextBoxX1, 0);
            this.PanelEx1.Controls.SetChildIndex(this.btnBuscar, 0);
            this.PanelEx1.Controls.SetChildIndex(this.btnLimpiar, 0);
            this.PanelEx1.Controls.SetChildIndex(this.chkVerHistoricos, 0);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(711, 3);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(634, 3);
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // TextBoxX1
            // 
            // 
            // 
            // 
            this.TextBoxX1.Border.Class = "TextBoxBorder";
            this.TextBoxX1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TextBoxX1.Location = new System.Drawing.Point(89, 22);
            this.TextBoxX1.Size = new System.Drawing.Size(293, 20);
            // 
            // LabelX1
            // 
            // 
            // 
            // 
            this.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LabelX1.Location = new System.Drawing.Point(24, 21);
            this.LabelX1.Size = new System.Drawing.Size(53, 23);
            this.LabelX1.Text = "Socio";
            // 
            // lblGrilla
            // 
            // 
            // 
            // 
            this.lblGrilla.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblGrilla.Text = "Datos";
            // 
            // lblRegistros
            // 
            // 
            // 
            // 
            this.lblRegistros.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblRegistros.Location = new System.Drawing.Point(1001, 97);
            // 
            // dgvBoveda
            // 
            this.dgvBoveda.AllowUserToAddRows = false;
            this.dgvBoveda.AllowUserToDeleteRows = false;
            this.dgvBoveda.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBoveda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBoveda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdBoveda,
            this.IdSolicitud,
            this.vDescripcion,
            this.vRazonSocialSocio,
            this.dtEnvioBoveda,
            this.vUEnvioBoveda,
            this.dtCierreBoveda,
            this.vUCierreBoveda,
            this.IdEstado_tt,
            this.IdEstado_tt_Dsc});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBoveda.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvBoveda.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvBoveda.Location = new System.Drawing.Point(0, 125);
            this.dgvBoveda.Name = "dgvBoveda";
            this.dgvBoveda.ReadOnly = true;
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            this.dgvBoveda.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvBoveda.Size = new System.Drawing.Size(1177, 438);
            this.dgvBoveda.TabIndex = 22;
            // 
            // IdBoveda
            // 
            this.IdBoveda.DataPropertyName = "IdBoveda";
            this.IdBoveda.HeaderText = "Identificador";
            this.IdBoveda.Name = "IdBoveda";
            this.IdBoveda.ReadOnly = true;
            // 
            // IdSolicitud
            // 
            this.IdSolicitud.DataPropertyName = "IdSolicitud";
            this.IdSolicitud.HeaderText = "IdSolicitud";
            this.IdSolicitud.Name = "IdSolicitud";
            this.IdSolicitud.ReadOnly = true;
            this.IdSolicitud.Visible = false;
            // 
            // vDescripcion
            // 
            this.vDescripcion.DataPropertyName = "vDescripcion";
            this.vDescripcion.HeaderText = "Descripcion";
            this.vDescripcion.Name = "vDescripcion";
            this.vDescripcion.ReadOnly = true;
            this.vDescripcion.Width = 150;
            // 
            // vRazonSocialSocio
            // 
            this.vRazonSocialSocio.DataPropertyName = "vRazonSocialSocio";
            this.vRazonSocialSocio.HeaderText = "Socio";
            this.vRazonSocialSocio.Name = "vRazonSocialSocio";
            this.vRazonSocialSocio.ReadOnly = true;
            this.vRazonSocialSocio.Width = 250;
            // 
            // dtEnvioBoveda
            // 
            this.dtEnvioBoveda.DataPropertyName = "dtEnvioBoveda";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Format = "g";
            this.dtEnvioBoveda.DefaultCellStyle = dataGridViewCellStyle1;
            this.dtEnvioBoveda.HeaderText = "Fecha Envío Boveda";
            this.dtEnvioBoveda.Name = "dtEnvioBoveda";
            this.dtEnvioBoveda.ReadOnly = true;
            this.dtEnvioBoveda.Width = 130;
            // 
            // vUEnvioBoveda
            // 
            this.vUEnvioBoveda.DataPropertyName = "vUEnvioBoveda";
            this.vUEnvioBoveda.HeaderText = "Usuario Envío Boveda";
            this.vUEnvioBoveda.Name = "vUEnvioBoveda";
            this.vUEnvioBoveda.ReadOnly = true;
            // 
            // dtCierreBoveda
            // 
            this.dtCierreBoveda.DataPropertyName = "dtCierreBoveda";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Format = "g";
            dataGridViewCellStyle2.NullValue = null;
            this.dtCierreBoveda.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtCierreBoveda.HeaderText = "Fecha Cierre Boveda";
            this.dtCierreBoveda.Name = "dtCierreBoveda";
            this.dtCierreBoveda.ReadOnly = true;
            this.dtCierreBoveda.Width = 130;
            // 
            // vUCierreBoveda
            // 
            this.vUCierreBoveda.DataPropertyName = "vUCierreBoveda";
            this.vUCierreBoveda.HeaderText = "Usuario Cierre Boveda";
            this.vUCierreBoveda.Name = "vUCierreBoveda";
            this.vUCierreBoveda.ReadOnly = true;
            // 
            // IdEstado_tt
            // 
            this.IdEstado_tt.DataPropertyName = "IdEstado_tt";
            this.IdEstado_tt.HeaderText = "IdEstado_tt";
            this.IdEstado_tt.Name = "IdEstado_tt";
            this.IdEstado_tt.ReadOnly = true;
            this.IdEstado_tt.Visible = false;
            // 
            // IdEstado_tt_Dsc
            // 
            this.IdEstado_tt_Dsc.DataPropertyName = "IdEstado_tt_Dsc";
            this.IdEstado_tt_Dsc.HeaderText = "Estado";
            this.IdEstado_tt_Dsc.Name = "IdEstado_tt_Dsc";
            this.IdEstado_tt_Dsc.ReadOnly = true;
            this.IdEstado_tt_Dsc.Width = 130;
            // 
            // btnVer
            // 
            this.btnVer.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnVer.Image = global::EfideFactoring.Properties.Resources.Binocular;
            this.btnVer.Name = "btnVer";
            this.btnVer.SubItemsExpandWidth = 14;
            this.btnVer.Text = "Ver";
            this.btnVer.Visible = false;
            this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
            // 
            // chkVerHistoricos
            // 
            // 
            // 
            // 
            this.chkVerHistoricos.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.chkVerHistoricos.Location = new System.Drawing.Point(431, 19);
            this.chkVerHistoricos.Name = "chkVerHistoricos";
            this.chkVerHistoricos.Size = new System.Drawing.Size(100, 23);
            this.chkVerHistoricos.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.chkVerHistoricos.TabIndex = 11;
            this.chkVerHistoricos.Text = "Ver Historicos";
            this.chkVerHistoricos.Visible = false;
            // 
            // frmQryBoveda
            // 
            this.ClientSize = new System.Drawing.Size(1177, 575);
            this.Controls.Add(this.dgvBoveda);
            this.DoubleBuffered = true;
            this.Name = "frmQryBoveda";
            this.Text = "Boveda - Ejecutivo";
            this.Load += new System.EventHandler(this.frmQryBoveda_Load);
            this.Controls.SetChildIndex(this.RibbonBar1, 0);
            this.Controls.SetChildIndex(this.PanelEx1, 0);
            this.Controls.SetChildIndex(this.lblRegistros, 0);
            this.Controls.SetChildIndex(this.lblGrilla, 0);
            this.Controls.SetChildIndex(this.dgvBoveda, 0);
            this.PanelEx1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBoveda)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX dgvBoveda;
        private DevComponents.DotNetBar.ButtonItem btnVer;
        private DevComponents.DotNetBar.Controls.CheckBoxX chkVerHistoricos;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdBoveda;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdSolicitud;
        private System.Windows.Forms.DataGridViewTextBoxColumn vDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn vRazonSocialSocio;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtEnvioBoveda;
        private System.Windows.Forms.DataGridViewTextBoxColumn vUEnvioBoveda;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtCierreBoveda;
        private System.Windows.Forms.DataGridViewTextBoxColumn vUCierreBoveda;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdEstado_tt;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdEstado_tt_Dsc;
    }
}