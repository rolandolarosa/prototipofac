namespace EfideFactoring.Formula.Catalogo
{
    partial class frmMntMagnitud
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
            this.dgvMagnitud = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.comunTipoPerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorPersonaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.razonSocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MagnitudId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MagnitudId_Dsc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PanelEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMagnitud)).BeginInit();
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
            this.RibbonBar1.Size = new System.Drawing.Size(905, 40);
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
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Visible = false;
            // 
            // PanelEx1
            // 
            this.PanelEx1.Size = new System.Drawing.Size(905, 54);
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
            this.LabelX1.Text = "Razón Social";
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
            this.lblRegistros.Location = new System.Drawing.Point(729, 97);
            // 
            // dgvMagnitud
            // 
            this.dgvMagnitud.AllowUserToAddRows = false;
            this.dgvMagnitud.AllowUserToDeleteRows = false;
            this.dgvMagnitud.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMagnitud.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.comunTipoPerID,
            this.codCliente,
            this.valorPersonaID,
            this.razonSocial,
            this.MagnitudId,
            this.MagnitudId_Dsc});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMagnitud.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMagnitud.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvMagnitud.Location = new System.Drawing.Point(0, 125);
            this.dgvMagnitud.Name = "dgvMagnitud";
            this.dgvMagnitud.ReadOnly = true;
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            this.dgvMagnitud.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMagnitud.Size = new System.Drawing.Size(905, 400);
            this.dgvMagnitud.TabIndex = 22;
            // 
            // comunTipoPerID
            // 
            this.comunTipoPerID.DataPropertyName = "comunTipoPerID";
            this.comunTipoPerID.HeaderText = "comunTipoPerID";
            this.comunTipoPerID.Name = "comunTipoPerID";
            this.comunTipoPerID.ReadOnly = true;
            this.comunTipoPerID.Visible = false;
            // 
            // codCliente
            // 
            this.codCliente.DataPropertyName = "codCliente";
            this.codCliente.HeaderText = "Código";
            this.codCliente.Name = "codCliente";
            this.codCliente.ReadOnly = true;
            // 
            // valorPersonaID
            // 
            this.valorPersonaID.DataPropertyName = "valorPersonaID";
            this.valorPersonaID.HeaderText = "Tipo";
            this.valorPersonaID.Name = "valorPersonaID";
            this.valorPersonaID.ReadOnly = true;
            this.valorPersonaID.Width = 60;
            // 
            // razonSocial
            // 
            this.razonSocial.DataPropertyName = "razonSocial";
            this.razonSocial.HeaderText = "Razón Social";
            this.razonSocial.Name = "razonSocial";
            this.razonSocial.ReadOnly = true;
            this.razonSocial.Width = 300;
            // 
            // MagnitudId
            // 
            this.MagnitudId.DataPropertyName = "MagnitudId";
            this.MagnitudId.HeaderText = "MagnitudId";
            this.MagnitudId.Name = "MagnitudId";
            this.MagnitudId.ReadOnly = true;
            this.MagnitudId.Visible = false;
            this.MagnitudId.Width = 150;
            // 
            // MagnitudId_Dsc
            // 
            this.MagnitudId_Dsc.DataPropertyName = "MagnitudId_Dsc";
            this.MagnitudId_Dsc.HeaderText = "Magnitud";
            this.MagnitudId_Dsc.Name = "MagnitudId_Dsc";
            this.MagnitudId_Dsc.ReadOnly = true;
            // 
            // frmMntMagnitud
            // 
            this.ClientSize = new System.Drawing.Size(905, 537);
            this.Controls.Add(this.dgvMagnitud);
            this.DoubleBuffered = true;
            this.Name = "frmMntMagnitud";
            this.Text = "Mantenimiento de Magnitud";
            this.Load += new System.EventHandler(this.frmMntMagnitud_Load);
            this.Controls.SetChildIndex(this.RibbonBar1, 0);
            this.Controls.SetChildIndex(this.PanelEx1, 0);
            this.Controls.SetChildIndex(this.lblRegistros, 0);
            this.Controls.SetChildIndex(this.lblGrilla, 0);
            this.Controls.SetChildIndex(this.dgvMagnitud, 0);
            this.PanelEx1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMagnitud)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX dgvMagnitud;
        private System.Windows.Forms.DataGridViewTextBoxColumn comunTipoPerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn codCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorPersonaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn razonSocial;
        private System.Windows.Forms.DataGridViewTextBoxColumn MagnitudId;
        private System.Windows.Forms.DataGridViewTextBoxColumn MagnitudId_Dsc;
    }
}