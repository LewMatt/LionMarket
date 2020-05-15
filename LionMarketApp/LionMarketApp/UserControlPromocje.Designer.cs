namespace LionMarketApp
{
    partial class UserControlPromocje
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
            this.lblPromocje = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPromocje
            // 
            this.lblPromocje.AutoSize = true;
            this.lblPromocje.Location = new System.Drawing.Point(404, 99);
            this.lblPromocje.Name = "lblPromocje";
            this.lblPromocje.Size = new System.Drawing.Size(51, 13);
            this.lblPromocje.TabIndex = 0;
            this.lblPromocje.Text = "Promocje";
            // 
            // UserControlPromocje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblPromocje);
            this.Name = "UserControlPromocje";
            this.Size = new System.Drawing.Size(900, 550);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPromocje;
    }
}
