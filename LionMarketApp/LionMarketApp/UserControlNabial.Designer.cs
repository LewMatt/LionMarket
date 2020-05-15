namespace LionMarketApp
{
    partial class UserControlNabial
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
            this.lblNabial = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNabial
            // 
            this.lblNabial.AutoSize = true;
            this.lblNabial.Location = new System.Drawing.Point(453, 97);
            this.lblNabial.Name = "lblNabial";
            this.lblNabial.Size = new System.Drawing.Size(39, 13);
            this.lblNabial.TabIndex = 0;
            this.lblNabial.Text = "Nabiał";
            // 
            // UserControlNabial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblNabial);
            this.Name = "UserControlNabial";
            this.Size = new System.Drawing.Size(900, 550);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNabial;
    }
}
