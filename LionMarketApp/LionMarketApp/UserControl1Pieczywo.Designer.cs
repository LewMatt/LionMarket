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
            this.listViewPieczywo = new System.Windows.Forms.ListView();
            this.hProdukt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hIlosc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hCena = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblIleSztuk = new System.Windows.Forms.Label();
            this.textBoxIleSztuk = new System.Windows.Forms.TextBox();
            this.btnDodajDoKoszyka = new System.Windows.Forms.Button();
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
            // listViewPieczywo
            // 
            this.listViewPieczywo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.hProdukt,
            this.hIlosc,
            this.hCena});
            this.listViewPieczywo.HideSelection = false;
            this.listViewPieczywo.Location = new System.Drawing.Point(81, 179);
            this.listViewPieczywo.Name = "listViewPieczywo";
            this.listViewPieczywo.Size = new System.Drawing.Size(405, 300);
            this.listViewPieczywo.TabIndex = 1;
            this.listViewPieczywo.UseCompatibleStateImageBehavior = false;
            this.listViewPieczywo.View = System.Windows.Forms.View.Details;
            // 
            // hProdukt
            // 
            this.hProdukt.Text = "Produkty";
            this.hProdukt.Width = 240;
            // 
            // hIlosc
            // 
            this.hIlosc.Text = "Ilość";
            this.hIlosc.Width = 80;
            // 
            // hCena
            // 
            this.hCena.Text = "Cena(zł)";
            this.hCena.Width = 80;
            // 
            // lblIleSztuk
            // 
            this.lblIleSztuk.AutoSize = true;
            this.lblIleSztuk.Location = new System.Drawing.Point(579, 275);
            this.lblIleSztuk.Name = "lblIleSztuk";
            this.lblIleSztuk.Size = new System.Drawing.Size(32, 13);
            this.lblIleSztuk.TabIndex = 2;
            this.lblIleSztuk.Text = "Ilość:";
            // 
            // textBoxIleSztuk
            // 
            this.textBoxIleSztuk.Location = new System.Drawing.Point(672, 272);
            this.textBoxIleSztuk.Name = "textBoxIleSztuk";
            this.textBoxIleSztuk.Size = new System.Drawing.Size(100, 20);
            this.textBoxIleSztuk.TabIndex = 3;
            // 
            // btnDodajDoKoszyka
            // 
            this.btnDodajDoKoszyka.Location = new System.Drawing.Point(625, 367);
            this.btnDodajDoKoszyka.Name = "btnDodajDoKoszyka";
            this.btnDodajDoKoszyka.Size = new System.Drawing.Size(120, 29);
            this.btnDodajDoKoszyka.TabIndex = 4;
            this.btnDodajDoKoszyka.Text = "Dodaj do koszyka";
            this.btnDodajDoKoszyka.UseVisualStyleBackColor = true;
            this.btnDodajDoKoszyka.Click += new System.EventHandler(this.btnDodajDoKoszyka_Click);
            // 
            // UserControl1Pieczywo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnDodajDoKoszyka);
            this.Controls.Add(this.textBoxIleSztuk);
            this.Controls.Add(this.lblIleSztuk);
            this.Controls.Add(this.listViewPieczywo);
            this.Controls.Add(this.lblPieczywo);
            this.Name = "UserControl1Pieczywo";
            this.Size = new System.Drawing.Size(900, 550);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPieczywo;
        private System.Windows.Forms.ColumnHeader hProdukt;
        private System.Windows.Forms.ColumnHeader hIlosc;
        private System.Windows.Forms.ColumnHeader hCena;
        private System.Windows.Forms.Label lblIleSztuk;
        private System.Windows.Forms.TextBox textBoxIleSztuk;
        private System.Windows.Forms.Button btnDodajDoKoszyka;
        public System.Windows.Forms.ListView listViewPieczywo;
    }
}
