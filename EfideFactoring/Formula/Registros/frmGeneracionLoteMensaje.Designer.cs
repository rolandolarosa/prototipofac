namespace EfideFactoring.Formula.Registros
{
    partial class frmGeneracionLoteMensaje
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
            this.RibbonBar1 = new DevComponents.DotNetBar.RibbonBar();
            this.btnSalir = new DevComponents.DotNetBar.ButtonItem();
            this.dgvInconsistencias = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.Mensaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInconsistencias)).BeginInit();
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
            this.RibbonBar1.Size = new System.Drawing.Size(556, 40);
            this.RibbonBar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010;
            this.RibbonBar1.TabIndex = 19;
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
            // dgvInconsistencias
            // 
            this.dgvInconsistencias.AllowUserToAddRows = false;
            this.dgvInconsistencias.AllowUserToDeleteRows = false;
            this.dgvInconsistencias.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvInconsistencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInconsistencias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Mensaje});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInconsistencias.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvInconsistencias.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvInconsistencias.Location = new System.Drawing.Point(0, 32);
            this.dgvInconsistencias.Name = "dgvInconsistencias";
            this.dgvInconsistencias.ReadOnly = true;
            this.dgvInconsistencias.Size = new System.Drawing.Size(556, 267);
            this.dgvInconsistencias.TabIndex = 20;
            // 
            // Mensaje
            // 
            this.Mensaje.DataPropertyName = "Mensaje";
            this.Mensaje.HeaderText = "Mensaje";
            this.Mensaje.Name = "Mensaje";
            this.Mensaje.ReadOnly = true;
            this.Mensaje.Width = 450;
            // 
            // frmGeneracionLoteMensaje
            // 
            this.ClientSize = new System.Drawing.Size(556, 311);
            this.Controls.Add(this.dgvInconsistencias);
            this.Controls.Add(this.RibbonBar1);
            this.DoubleBuffered = true;
            this.Name = "frmGeneracionLoteMensaje";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inconsistencias";
            this.Load += new System.EventHandler(this.frmGeneracionLoteMensaje_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInconsistencias)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected DevComponents.DotNetBar.RibbonBar RibbonBar1;
        protected DevComponents.DotNetBar.ButtonItem btnSalir;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvInconsistencias;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mensaje;
    }
}