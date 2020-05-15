namespace LionMarketApp
{
    partial class UserControlNapoje
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
            this.lblNapoje = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNapoje
            // 
            this.lblNapoje.AutoSize = true;
            this.lblNapoje.Location = new System.Drawing.Point(426, 89);
            this.lblNapoje.Name = "lblNapoje";
            this.lblNapoje.Size = new System.Drawing.Size(41, 13);
            this.lblNapoje.TabIndex = 0;
            this.lblNapoje.Text = "Napoje";
            // 
            // UserControlNapoje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblNapoje);
            this.Name = "UserControlNapoje";
            this.Size = new System.Drawing.Size(900, 550);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNapoje;
    }
}
