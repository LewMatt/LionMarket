﻿namespace LionMarketApp
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
            this.listViewPrzyprawy = new System.Windows.Forms.ListView();
            this.hProdukty = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hIlosc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hCena = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblIleSztuk = new System.Windows.Forms.Label();
            this.textBoxIleSztuk = new System.Windows.Forms.TextBox();
            this.btnDodajDoKoszyka = new System.Windows.Forms.Button();
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
            // listViewPrzyprawy
            // 
            this.listViewPrzyprawy.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.hProdukty,
            this.hIlosc,
            this.hCena});
            this.listViewPrzyprawy.HideSelection = false;
            this.listViewPrzyprawy.Location = new System.Drawing.Point(114, 163);
            this.listViewPrzyprawy.Name = "listViewPrzyprawy";
            this.listViewPrzyprawy.Size = new System.Drawing.Size(405, 300);
            this.listViewPrzyprawy.TabIndex = 1;
            this.listViewPrzyprawy.UseCompatibleStateImageBehavior = false;
            this.listViewPrzyprawy.View = System.Windows.Forms.View.Details;
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
            this.lblIleSztuk.Location = new System.Drawing.Point(641, 203);
            this.lblIleSztuk.Name = "lblIleSztuk";
            this.lblIleSztuk.Size = new System.Drawing.Size(32, 13);
            this.lblIleSztuk.TabIndex = 2;
            this.lblIleSztuk.Text = "Ilość:";
            // 
            // textBoxIleSztuk
            // 
            this.textBoxIleSztuk.Location = new System.Drawing.Point(738, 195);
            this.textBoxIleSztuk.Name = "textBoxIleSztuk";
            this.textBoxIleSztuk.Size = new System.Drawing.Size(100, 20);
            this.textBoxIleSztuk.TabIndex = 3;
            // 
            // btnDodajDoKoszyka
            // 
            this.btnDodajDoKoszyka.Location = new System.Drawing.Point(669, 294);
            this.btnDodajDoKoszyka.Name = "btnDodajDoKoszyka";
            this.btnDodajDoKoszyka.Size = new System.Drawing.Size(115, 57);
            this.btnDodajDoKoszyka.TabIndex = 4;
            this.btnDodajDoKoszyka.Text = "Dodaj do koszyka";
            this.btnDodajDoKoszyka.UseVisualStyleBackColor = true;
            this.btnDodajDoKoszyka.Click += new System.EventHandler(this.btnDodajDoKoszyka_Click);
            // 
            // UserControlPrzyprawy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnDodajDoKoszyka);
            this.Controls.Add(this.textBoxIleSztuk);
            this.Controls.Add(this.lblIleSztuk);
            this.Controls.Add(this.listViewPrzyprawy);
            this.Controls.Add(this.lblPrzyprawy);
            this.Name = "UserControlPrzyprawy";
            this.Size = new System.Drawing.Size(900, 550);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPrzyprawy;
        private System.Windows.Forms.ListView listViewPrzyprawy;
        private System.Windows.Forms.ColumnHeader hProdukty;
        private System.Windows.Forms.ColumnHeader hIlosc;
        private System.Windows.Forms.ColumnHeader hCena;
        private System.Windows.Forms.Label lblIleSztuk;
        private System.Windows.Forms.TextBox textBoxIleSztuk;
        private System.Windows.Forms.Button btnDodajDoKoszyka;
    }
}
