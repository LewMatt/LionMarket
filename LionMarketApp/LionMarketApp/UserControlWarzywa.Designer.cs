namespace LionMarketApp
{
    partial class UserControlWarzywa
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
            this.lblWarzywa = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblWarzywa
            // 
            this.lblWarzywa.AutoSize = true;
            this.lblWarzywa.Location = new System.Drawing.Point(413, 100);
            this.lblWarzywa.Name = "lblWarzywa";
            this.lblWarzywa.Size = new System.Drawing.Size(51, 13);
            this.lblWarzywa.TabIndex = 0;
            this.lblWarzywa.Text = "Warzywa";
            // 
            // UserControlWarzywa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblWarzywa);
            this.Name = "UserControlWarzywa";
            this.Size = new System.Drawing.Size(900, 550);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWarzywa;
    }
}
