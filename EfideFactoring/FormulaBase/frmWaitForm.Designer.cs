namespace EfideFactoring.FormulaBase
{
    partial class frmWaitForm
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
            this.lblMensaje = new DevComponents.DotNetBar.LabelX();
            this.SuspendLayout();
            // 
            // lblMensaje
            // 
            // 
            // 
            // 
            this.lblMensaje.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblMensaje.Location = new System.Drawing.Point(19, 9);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(369, 23);
            this.lblMensaje.TabIndex = 1;
            this.lblMensaje.Text = "LabelX1";
            this.lblMensaje.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // frmWaitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 41);
            this.ControlBox = false;
            this.Controls.Add(this.lblMensaje);
            this.Name = "frmWaitForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mensaje";
            this.ResumeLayout(false);

        }

        #endregion

        internal DevComponents.DotNetBar.LabelX lblMensaje;
    }
}