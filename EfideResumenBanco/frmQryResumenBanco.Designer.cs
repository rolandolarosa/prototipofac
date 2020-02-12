namespace EfideResumenBanco
{
    partial class frmQryResumenBanco
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvDatos = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.line1 = new DevComponents.DotNetBar.Controls.Line();
            this.line2 = new DevComponents.DotNetBar.Controls.Line();
            this.line3 = new DevComponents.DotNetBar.Controls.Line();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.lblTotalSol = new DevComponents.DotNetBar.LabelX();
            this.lblTotalDol = new DevComponents.DotNetBar.LabelX();
            this.line4 = new DevComponents.DotNetBar.Controls.Line();
            this.btnActualizar = new DevComponents.DotNetBar.ButtonX();
            this.TimeTick = new System.Windows.Forms.Timer(this.components);
            this.FinancieraID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emprRazonSocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorMonedaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Moneda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImporteMail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImporteCavali = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpDato.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // grpDato
            // 
            this.grpDato.Controls.Add(this.btnActualizar);
            this.grpDato.Controls.Add(this.line4);
            this.grpDato.Controls.Add(this.lblTotalDol);
            this.grpDato.Controls.Add(this.lblTotalSol);
            this.grpDato.Controls.Add(this.labelX3);
            this.grpDato.Controls.Add(this.labelX2);
            this.grpDato.Controls.Add(this.line3);
            this.grpDato.Controls.Add(this.line2);
            this.grpDato.Controls.Add(this.line1);
            this.grpDato.Controls.Add(this.labelX1);
            this.grpDato.Controls.Add(this.dgvDatos);
            this.grpDato.Size = new System.Drawing.Size(714, 305);
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
            this.btnCancelar.Location = new System.Drawing.Point(633, 326);
            this.btnCancelar.Text = "Cerrar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(542, 326);
            this.btnAceptar.Visible = false;
            // 
            // dgvDatos
            // 
            this.dgvDatos.AllowUserToAddRows = false;
            this.dgvDatos.AllowUserToDeleteRows = false;
            this.dgvDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FinancieraID,
            this.emprRazonSocial,
            this.valorMonedaID,
            this.Moneda,
            this.ImporteMail,
            this.ImporteCavali,
            this.Total});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDatos.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvDatos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvDatos.Location = new System.Drawing.Point(5, 44);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.ReadOnly = true;
            this.dgvDatos.Size = new System.Drawing.Size(698, 220);
            this.dgvDatos.TabIndex = 0;
            this.dgvDatos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDatos_CellDoubleClick);
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.Location = new System.Drawing.Point(5, 12);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(599, 23);
            this.labelX1.TabIndex = 1;
            this.labelX1.Text = "OPERACIONES EN PROCESO DE APROBACION";
            this.labelX1.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // line1
            // 
            this.line1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.line1.BackColor = System.Drawing.Color.Transparent;
            this.line1.Location = new System.Drawing.Point(5, 286);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(698, 10);
            this.line1.TabIndex = 2;
            this.line1.Text = "line1";
            // 
            // line2
            // 
            this.line2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.line2.BackColor = System.Drawing.Color.Transparent;
            this.line2.Location = new System.Drawing.Point(0, 264);
            this.line2.Name = "line2";
            this.line2.Size = new System.Drawing.Size(10, 27);
            this.line2.TabIndex = 14;
            this.line2.Text = "line2";
            this.line2.VerticalLine = true;
            // 
            // line3
            // 
            this.line3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.line3.BackColor = System.Drawing.Color.Transparent;
            this.line3.Location = new System.Drawing.Point(697, 264);
            this.line3.Name = "line3";
            this.line3.Size = new System.Drawing.Size(10, 27);
            this.line3.TabIndex = 15;
            this.line3.Text = "line3";
            this.line3.VerticalLine = true;
            // 
            // labelX2
            // 
            this.labelX2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.Location = new System.Drawing.Point(379, 267);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(49, 23);
            this.labelX2.TabIndex = 16;
            this.labelX2.Text = "Total S/";
            // 
            // labelX3
            // 
            this.labelX3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelX3.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX3.Location = new System.Drawing.Point(555, 267);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(57, 23);
            this.labelX3.TabIndex = 17;
            this.labelX3.Text = "Total US$";
            // 
            // lblTotalSol
            // 
            this.lblTotalSol.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalSol.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lblTotalSol.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblTotalSol.Location = new System.Drawing.Point(433, 267);
            this.lblTotalSol.Name = "lblTotalSol";
            this.lblTotalSol.Size = new System.Drawing.Size(81, 23);
            this.lblTotalSol.TabIndex = 18;
            this.lblTotalSol.Text = "0.00";
            this.lblTotalSol.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // lblTotalDol
            // 
            this.lblTotalDol.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalDol.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lblTotalDol.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblTotalDol.Location = new System.Drawing.Point(617, 267);
            this.lblTotalDol.Name = "lblTotalDol";
            this.lblTotalDol.Size = new System.Drawing.Size(81, 23);
            this.lblTotalDol.TabIndex = 19;
            this.lblTotalDol.Text = "0.00";
            this.lblTotalDol.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // line4
            // 
            this.line4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.line4.BackColor = System.Drawing.Color.Transparent;
            this.line4.Location = new System.Drawing.Point(521, 264);
            this.line4.Name = "line4";
            this.line4.Size = new System.Drawing.Size(10, 27);
            this.line4.TabIndex = 20;
            this.line4.Text = "line4";
            this.line4.VerticalLine = true;
            // 
            // btnActualizar
            // 
            this.btnActualizar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnActualizar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnActualizar.Image = global::EfideResumenBanco.Properties.Resources.refresh;
            this.btnActualizar.Location = new System.Drawing.Point(610, 3);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(93, 35);
            this.btnActualizar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnActualizar.TabIndex = 21;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // TimeTick
            // 
            this.TimeTick.Interval = 60000;
            this.TimeTick.Tick += new System.EventHandler(this.TimeTick_Tick);
            // 
            // FinancieraID
            // 
            this.FinancieraID.DataPropertyName = "FinancieraID";
            this.FinancieraID.HeaderText = "FinancieraID";
            this.FinancieraID.Name = "FinancieraID";
            this.FinancieraID.ReadOnly = true;
            this.FinancieraID.Visible = false;
            // 
            // emprRazonSocial
            // 
            this.emprRazonSocial.DataPropertyName = "emprRazonSocial";
            this.emprRazonSocial.HeaderText = "Banco";
            this.emprRazonSocial.Name = "emprRazonSocial";
            this.emprRazonSocial.ReadOnly = true;
            this.emprRazonSocial.Width = 250;
            // 
            // valorMonedaID
            // 
            this.valorMonedaID.DataPropertyName = "valorMonedaID";
            this.valorMonedaID.HeaderText = "valorMonedaID";
            this.valorMonedaID.Name = "valorMonedaID";
            this.valorMonedaID.ReadOnly = true;
            this.valorMonedaID.Visible = false;
            // 
            // Moneda
            // 
            this.Moneda.DataPropertyName = "Moneda";
            this.Moneda.HeaderText = "Moneda";
            this.Moneda.Name = "Moneda";
            this.Moneda.ReadOnly = true;
            this.Moneda.Width = 60;
            // 
            // ImporteMail
            // 
            this.ImporteMail.DataPropertyName = "ImporteMail";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "N2";
            this.ImporteMail.DefaultCellStyle = dataGridViewCellStyle5;
            this.ImporteMail.HeaderText = "@Mail";
            this.ImporteMail.Name = "ImporteMail";
            this.ImporteMail.ReadOnly = true;
            // 
            // ImporteCavali
            // 
            this.ImporteCavali.DataPropertyName = "ImporteCavali";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "N2";
            this.ImporteCavali.DefaultCellStyle = dataGridViewCellStyle6;
            this.ImporteCavali.HeaderText = "Cavali";
            this.ImporteCavali.Name = "ImporteCavali";
            this.ImporteCavali.ReadOnly = true;
            // 
            // Total
            // 
            this.Total.DataPropertyName = "Total";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.Format = "N2";
            dataGridViewCellStyle7.NullValue = null;
            this.Total.DefaultCellStyle = dataGridViewCellStyle7;
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            this.Total.Width = 120;
            // 
            // frmQryResumenBanco
            // 
            this.ClientSize = new System.Drawing.Size(722, 362);
            this.DoubleBuffered = true;
            this.Name = "frmQryResumenBanco";
            this.Text = "Operaciones en Proceso";
            this.Load += new System.EventHandler(this.frmQryResumenBanco_Load);
            this.grpDato.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX dgvDatos;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.Line line3;
        private DevComponents.DotNetBar.Controls.Line line2;
        private DevComponents.DotNetBar.Controls.Line line1;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX lblTotalDol;
        private DevComponents.DotNetBar.LabelX lblTotalSol;
        private DevComponents.DotNetBar.Controls.Line line4;
        private DevComponents.DotNetBar.ButtonX btnActualizar;
        private System.Windows.Forms.Timer TimeTick;
        private System.Windows.Forms.DataGridViewTextBoxColumn FinancieraID;
        private System.Windows.Forms.DataGridViewTextBoxColumn emprRazonSocial;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorMonedaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Moneda;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImporteMail;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImporteCavali;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
    }
}