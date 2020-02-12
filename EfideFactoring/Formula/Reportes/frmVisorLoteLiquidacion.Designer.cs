namespace EfideFactoring.Formula.Reportes
{
    partial class frmVisorLoteLiquidacion
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
            this.crvVisorLoteLiq = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvVisorLoteLiq
            // 
            this.crvVisorLoteLiq.ActiveViewIndex = -1;
            this.crvVisorLoteLiq.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvVisorLoteLiq.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvVisorLoteLiq.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvVisorLoteLiq.Location = new System.Drawing.Point(0, 0);
            this.crvVisorLoteLiq.Name = "crvVisorLoteLiq";
            this.crvVisorLoteLiq.Size = new System.Drawing.Size(763, 350);
            this.crvVisorLoteLiq.TabIndex = 0;
            this.crvVisorLoteLiq.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frmVisorLoteLiquidacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 350);
            this.Controls.Add(this.crvVisorLoteLiq);
            this.Name = "frmVisorLoteLiquidacion";
            this.Text = "frmVisorLoteLiquidacion";
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer crvVisorLoteLiq;


    }
}