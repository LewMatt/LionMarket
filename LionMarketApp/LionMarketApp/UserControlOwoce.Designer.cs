namespace LionMarketApp
{
    partial class UserControlOwoce
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
            this.lblOwoce = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblOwoce
            // 
            this.lblOwoce.AutoSize = true;
            this.lblOwoce.Location = new System.Drawing.Point(445, 99);
            this.lblOwoce.Name = "lblOwoce";
            this.lblOwoce.Size = new System.Drawing.Size(41, 13);
            this.lblOwoce.TabIndex = 0;
            this.lblOwoce.Text = "Owoce";
            // 
            // UserControlOwoce
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblOwoce);
            this.Name = "UserControlOwoce";
            this.Size = new System.Drawing.Size(900, 550);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOwoce;
    }
}
