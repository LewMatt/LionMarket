﻿namespace LionMarketApp
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
            this.listViewOwoce = new System.Windows.Forms.ListView();
            this.hProdukty = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hIlosc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hCena = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblIleSztuk = new System.Windows.Forms.Label();
            this.textBoxIleSztuk = new System.Windows.Forms.TextBox();
            this.btnDodajDoKoszyka = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblOwoce
            // 
            this.lblOwoce.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblOwoce.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblOwoce.Location = new System.Drawing.Point(0, 0);
            this.lblOwoce.Name = "lblOwoce";
            this.lblOwoce.Size = new System.Drawing.Size(900, 100);
            this.lblOwoce.TabIndex = 0;
            this.lblOwoce.Text = "Owoce";
            this.lblOwoce.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listViewOwoce
            // 
            this.listViewOwoce.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.hProdukty,
            this.hIlosc,
            this.hCena});
            this.listViewOwoce.HideSelection = false;
            this.listViewOwoce.Location = new System.Drawing.Point(100, 150);
            this.listViewOwoce.Name = "listViewOwoce";
            this.listViewOwoce.Size = new System.Drawing.Size(405, 300);
            this.listViewOwoce.TabIndex = 1;
            this.listViewOwoce.UseCompatibleStateImageBehavior = false;
            this.listViewOwoce.View = System.Windows.Forms.View.Details;
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
            this.hCena.Text = "Cena(zł)";
            this.hCena.Width = 80;
            // 
            // lblIleSztuk
            // 
            this.lblIleSztuk.AutoSize = true;
            this.lblIleSztuk.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblIleSztuk.Location = new System.Drawing.Point(600, 230);
            this.lblIleSztuk.Name = "lblIleSztuk";
            this.lblIleSztuk.Size = new System.Drawing.Size(62, 25);
            this.lblIleSztuk.TabIndex = 2;
            this.lblIleSztuk.Text = "Ilość:";
            // 
            // textBoxIleSztuk
            // 
            this.textBoxIleSztuk.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxIleSztuk.Location = new System.Drawing.Point(700, 227);
            this.textBoxIleSztuk.Name = "textBoxIleSztuk";
            this.textBoxIleSztuk.Size = new System.Drawing.Size(100, 31);
            this.textBoxIleSztuk.TabIndex = 3;
            // 
            // btnDodajDoKoszyka
            // 
            this.btnDodajDoKoszyka.BackColor = System.Drawing.Color.LimeGreen;
            this.btnDodajDoKoszyka.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDodajDoKoszyka.ForeColor = System.Drawing.Color.White;
            this.btnDodajDoKoszyka.Location = new System.Drawing.Point(600, 320);
            this.btnDodajDoKoszyka.Name = "btnDodajDoKoszyka";
            this.btnDodajDoKoszyka.Size = new System.Drawing.Size(200, 50);
            this.btnDodajDoKoszyka.TabIndex = 4;
            this.btnDodajDoKoszyka.Text = "Dodaj do koszyka";
            this.btnDodajDoKoszyka.UseVisualStyleBackColor = false;
            this.btnDodajDoKoszyka.Click += new System.EventHandler(this.btnDodajDoKoszyka_Click);
            // 
            // UserControlOwoce
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnDodajDoKoszyka);
            this.Controls.Add(this.textBoxIleSztuk);
            this.Controls.Add(this.lblIleSztuk);
            this.Controls.Add(this.listViewOwoce);
            this.Controls.Add(this.lblOwoce);
            this.Name = "UserControlOwoce";
            this.Size = new System.Drawing.Size(900, 550);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOwoce;
        private System.Windows.Forms.ListView listViewOwoce;
        private System.Windows.Forms.ColumnHeader hProdukty;
        private System.Windows.Forms.ColumnHeader hIlosc;
        private System.Windows.Forms.ColumnHeader hCena;
        private System.Windows.Forms.Label lblIleSztuk;
        private System.Windows.Forms.TextBox textBoxIleSztuk;
        private System.Windows.Forms.Button btnDodajDoKoszyka;
    }
}
