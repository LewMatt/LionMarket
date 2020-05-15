namespace LionMarketApp
{
    partial class UserControlArtSpoz
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
            this.lblArtSpoz = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblArtSpoz
            // 
            this.lblArtSpoz.AutoSize = true;
            this.lblArtSpoz.Location = new System.Drawing.Point(381, 85);
            this.lblArtSpoz.Name = "lblArtSpoz";
            this.lblArtSpoz.Size = new System.Drawing.Size(101, 13);
            this.lblArtSpoz.TabIndex = 0;
            this.lblArtSpoz.Text = "Artykuły spożywcze";
            // 
            // UserControlArtSpoz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblArtSpoz);
            this.Name = "UserControlArtSpoz";
            this.Size = new System.Drawing.Size(900, 550);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblArtSpoz;
    }
}
