namespace LionMarketApp
{
    partial class UserControlKoszyk
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
            this.lblKoszyk = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblKoszyk
            // 
            this.lblKoszyk.AutoSize = true;
            this.lblKoszyk.Location = new System.Drawing.Point(408, 87);
            this.lblKoszyk.Name = "lblKoszyk";
            this.lblKoszyk.Size = new System.Drawing.Size(41, 13);
            this.lblKoszyk.TabIndex = 0;
            this.lblKoszyk.Text = "Koszyk";
            // 
            // UserControlKoszyk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblKoszyk);
            this.Name = "UserControlKoszyk";
            this.Size = new System.Drawing.Size(900, 550);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKoszyk;
    }
}
