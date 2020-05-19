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
            this.listViewNabial = new System.Windows.Forms.ListView();
            this.hProdukty = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hIlosc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hCena = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblIleSztuk = new System.Windows.Forms.Label();
            this.textBoxIleSztuk = new System.Windows.Forms.TextBox();
            this.btnDodajDoKoszyka = new System.Windows.Forms.Button();
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
            // listViewNabial
            // 
            this.listViewNabial.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.hProdukty,
            this.hIlosc,
            this.hCena});
            this.listViewNabial.HideSelection = false;
            this.listViewNabial.Location = new System.Drawing.Point(97, 158);
            this.listViewNabial.Name = "listViewNabial";
            this.listViewNabial.Size = new System.Drawing.Size(405, 300);
            this.listViewNabial.TabIndex = 1;
            this.listViewNabial.UseCompatibleStateImageBehavior = false;
            this.listViewNabial.View = System.Windows.Forms.View.Details;
            // 
            // hProdukty
            // 
            this.hProdukty.Text = "Produkty";
            this.hProdukty.Width = 240;
            // 
            // hIlosc
            // 
            this.hIlosc.Text = "Ilość";
            this.hIlosc.Width = 80;
            // 
            // hCena
            // 
            this.hCena.Text = "Cena";
            this.hCena.Width = 80;
            // 
            // lblIleSztuk
            // 
            this.lblIleSztuk.AutoSize = true;
            this.lblIleSztuk.Location = new System.Drawing.Point(599, 188);
            this.lblIleSztuk.Name = "lblIleSztuk";
            this.lblIleSztuk.Size = new System.Drawing.Size(32, 13);
            this.lblIleSztuk.TabIndex = 2;
            this.lblIleSztuk.Text = "Ilość:";
            // 
            // textBoxIleSztuk
            // 
            this.textBoxIleSztuk.Location = new System.Drawing.Point(707, 188);
            this.textBoxIleSztuk.Name = "textBoxIleSztuk";
            this.textBoxIleSztuk.Size = new System.Drawing.Size(100, 20);
            this.textBoxIleSztuk.TabIndex = 3;
            // 
            // btnDodajDoKoszyka
            // 
            this.btnDodajDoKoszyka.Location = new System.Drawing.Point(645, 290);
            this.btnDodajDoKoszyka.Name = "btnDodajDoKoszyka";
            this.btnDodajDoKoszyka.Size = new System.Drawing.Size(121, 35);
            this.btnDodajDoKoszyka.TabIndex = 4;
            this.btnDodajDoKoszyka.Text = "Dodaj do koszyka";
            this.btnDodajDoKoszyka.UseVisualStyleBackColor = true;
            this.btnDodajDoKoszyka.Click += new System.EventHandler(this.btnDodajDoKoszyka_Click);
            // 
            // UserControlNabial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnDodajDoKoszyka);
            this.Controls.Add(this.textBoxIleSztuk);
            this.Controls.Add(this.lblIleSztuk);
            this.Controls.Add(this.listViewNabial);
            this.Controls.Add(this.lblNabial);
            this.Name = "UserControlNabial";
            this.Size = new System.Drawing.Size(900, 550);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNabial;
        private System.Windows.Forms.ListView listViewNabial;
        private System.Windows.Forms.ColumnHeader hProdukty;
        private System.Windows.Forms.ColumnHeader hIlosc;
        private System.Windows.Forms.ColumnHeader hCena;
        private System.Windows.Forms.Label lblIleSztuk;
        private System.Windows.Forms.TextBox textBoxIleSztuk;
        private System.Windows.Forms.Button btnDodajDoKoszyka;
    }
}
