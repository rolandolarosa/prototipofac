namespace EfideFactoring.Formula.Cobranza
{
    partial class ftmQryDespositosXAplicar
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
            this.dgvDepositosxAplicar = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.socioBancoID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pagar_personaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorMonedaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorMonedaID_Dsc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ctasBancariaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Saldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepositosxAplicar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDepositosxAplicar
            // 
            this.dgvDepositosxAplicar.AllowUserToAddRows = false;
            this.dgvDepositosxAplicar.AllowUserToDeleteRows = false;
            this.dgvDepositosxAplicar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDepositosxAplicar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.socioBancoID,
            this.pagar_personaID,
            this.valorMonedaID,
            this.valorMonedaID_Dsc,
            this.ctasBancariaID,
            this.Saldo});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDepositosxAplicar.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDepositosxAplicar.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvDepositosxAplicar.Location = new System.Drawing.Point(12, 26);
            this.dgvDepositosxAplicar.Name = "dgvDepositosxAplicar";
            this.dgvDepositosxAplicar.ReadOnly = true;
            this.dgvDepositosxAplicar.Size = new System.Drawing.Size(479, 265);
            this.dgvDepositosxAplicar.TabIndex = 0;
            this.dgvDepositosxAplicar.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDepositosxAplicar_CellContentDoubleClick);
            // 
            // socioBancoID
            // 
            this.socioBancoID.DataPropertyName = "socioBancoID";
            this.socioBancoID.HeaderText = "Código";
            this.socioBancoID.Name = "socioBancoID";
            this.socioBancoID.ReadOnly = true;
            // 
            // pagar_personaID
            // 
            this.pagar_personaID.DataPropertyName = "pagar_personaID";
            this.pagar_personaID.HeaderText = "pagar_personaID";
            this.pagar_personaID.Name = "pagar_personaID";
            this.pagar_personaID.ReadOnly = true;
            this.pagar_personaID.Visible = false;
            // 
            // valorMonedaID
            // 
            this.valorMonedaID.DataPropertyName = "valorMonedaID";
            this.valorMonedaID.HeaderText = "valorMonedaID";
            this.valorMonedaID.Name = "valorMonedaID";
            this.valorMonedaID.ReadOnly = true;
            this.valorMonedaID.Visible = false;
            // 
            // valorMonedaID_Dsc
            // 
            this.valorMonedaID_Dsc.DataPropertyName = "valorMonedaID_Dsc";
            this.valorMonedaID_Dsc.HeaderText = "Moneda";
            this.valorMonedaID_Dsc.Name = "valorMonedaID_Dsc";
            this.valorMonedaID_Dsc.ReadOnly = true;
            // 
            // ctasBancariaID
            // 
            this.ctasBancariaID.DataPropertyName = "ctasBancariaID";
            this.ctasBancariaID.HeaderText = "ctasBancariaID";
            this.ctasBancariaID.Name = "ctasBancariaID";
            this.ctasBancariaID.ReadOnly = true;
            this.ctasBancariaID.Visible = false;
            // 
            // Saldo
            // 
            this.Saldo.DataPropertyName = "Saldo";
            this.Saldo.HeaderText = "Saldo";
            this.Saldo.Name = "Saldo";
            this.Saldo.ReadOnly = true;
            // 
            // ftmQryDespositosXAplicar
            // 
            this.ClientSize = new System.Drawing.Size(503, 303);
            this.Controls.Add(this.dgvDepositosxAplicar);
            this.DoubleBuffered = true;
            this.Name = "ftmQryDespositosXAplicar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Depositos por Aplicar";
            this.Load += new System.EventHandler(this.ftmQryDespositosXAplicar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepositosxAplicar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX dgvDepositosxAplicar;
        private System.Windows.Forms.DataGridViewTextBoxColumn socioBancoID;
        private System.Windows.Forms.DataGridViewTextBoxColumn pagar_personaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorMonedaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorMonedaID_Dsc;
        private System.Windows.Forms.DataGridViewTextBoxColumn ctasBancariaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Saldo;
    }
}