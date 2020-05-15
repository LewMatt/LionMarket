namespace LionMarketApp
{
    partial class UserControlMieso
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblMieso = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMieso
            // 
            this.lblMieso.AutoSize = true;
            this.lblMieso.Location = new System.Drawing.Point(381, 89);
            this.lblMieso.Name = "lblMieso";
            this.lblMieso.Size = new System.Drawing.Size(78, 13);
            this.lblMieso.TabIndex = 0;
            this.lblMieso.Text = "Mięso/Wędliny";
            // 
            // UserControlMieso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblMieso);
            this.Name = "UserControlMieso";
            this.Size = new System.Drawing.Size(900, 550);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMieso;
    }
}
