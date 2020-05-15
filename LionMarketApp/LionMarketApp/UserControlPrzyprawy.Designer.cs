namespace LionMarketApp
{
    partial class UserControlPrzyprawy
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
            this.lblPrzyprawy = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPrzyprawy
            // 
            this.lblPrzyprawy.AutoSize = true;
            this.lblPrzyprawy.Location = new System.Drawing.Point(403, 90);
            this.lblPrzyprawy.Name = "lblPrzyprawy";
            this.lblPrzyprawy.Size = new System.Drawing.Size(55, 13);
            this.lblPrzyprawy.TabIndex = 0;
            this.lblPrzyprawy.Text = "Przyprawy";
            // 
            // UserControlPrzyprawy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblPrzyprawy);
            this.Name = "UserControlPrzyprawy";
            this.Size = new System.Drawing.Size(900, 550);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPrzyprawy;
    }
}
