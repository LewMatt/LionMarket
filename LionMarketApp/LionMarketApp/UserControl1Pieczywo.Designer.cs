namespace LionMarketApp
{
    partial class UserControl1Pieczywo
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
            this.lblPieczywo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPieczywo
            // 
            this.lblPieczywo.AutoSize = true;
            this.lblPieczywo.Location = new System.Drawing.Point(416, 94);
            this.lblPieczywo.Name = "lblPieczywo";
            this.lblPieczywo.Size = new System.Drawing.Size(52, 13);
            this.lblPieczywo.TabIndex = 0;
            this.lblPieczywo.Text = "Pieczywo";
            // 
            // UserControl1Pieczywo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblPieczywo);
            this.Name = "UserControl1Pieczywo";
            this.Size = new System.Drawing.Size(900, 550);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPieczywo;
    }
}
