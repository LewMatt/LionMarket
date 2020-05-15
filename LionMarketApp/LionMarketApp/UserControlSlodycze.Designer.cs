namespace LionMarketApp
{
    partial class UserControlSlodycze
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
            this.lblSlodycze = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSlodycze
            // 
            this.lblSlodycze.AutoSize = true;
            this.lblSlodycze.Location = new System.Drawing.Point(424, 64);
            this.lblSlodycze.Name = "lblSlodycze";
            this.lblSlodycze.Size = new System.Drawing.Size(52, 13);
            this.lblSlodycze.TabIndex = 0;
            this.lblSlodycze.Text = "Słodycze";
            // 
            // UserControlSlodycze
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblSlodycze);
            this.Name = "UserControlSlodycze";
            this.Size = new System.Drawing.Size(900, 550);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSlodycze;
    }
}
