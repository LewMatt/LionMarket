namespace LionMarketApp
{
    partial class UserControlMieso
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
            this.lblMieso = new System.Windows.Forms.Label();
            this.listViewMieso = new System.Windows.Forms.ListView();
            this.lblIleSztuk = new System.Windows.Forms.Label();
            this.textBoxIleSztuk = new System.Windows.Forms.TextBox();
            this.btnDodajDoKoszyka = new System.Windows.Forms.Button();
            this.hProdukty = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hIlosc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hCena = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lblMieso
            // 
            this.lblMieso.AutoSize = true;
            this.lblMieso.Location = new System.Drawing.Point(381, 89);
            this.lblMieso.Name = "lblMieso";
            this.lblMieso.Size = new System.Drawing.Size(78, 13);
            this.lblMieso.TabIndex = 0;
            this.lblMieso.Text = "Mięso/Wędliny";
            // 
            // listViewMieso
            // 
            this.listViewMieso.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.hProdukty,
            this.hIlosc,
            this.hCena});
            this.listViewMieso.HideSelection = false;
            this.listViewMieso.Location = new System.Drawing.Point(126, 151);
            this.listViewMieso.Name = "listViewMieso";
            this.listViewMieso.Size = new System.Drawing.Size(405, 300);
            this.listViewMieso.TabIndex = 1;
            this.listViewMieso.UseCompatibleStateImageBehavior = false;
            this.listViewMieso.View = System.Windows.Forms.View.Details;
            // 
            // lblIleSztuk
            // 
            this.lblIleSztuk.AutoSize = true;
            this.lblIleSztuk.Location = new System.Drawing.Point(613, 230);
            this.lblIleSztuk.Name = "lblIleSztuk";
            this.lblIleSztuk.Size = new System.Drawing.Size(32, 13);
            this.lblIleSztuk.TabIndex = 2;
            this.lblIleSztuk.Text = "Ilość:";
            // 
            // textBoxIleSztuk
            // 
            this.textBoxIleSztuk.Location = new System.Drawing.Point(723, 230);
            this.textBoxIleSztuk.Name = "textBoxIleSztuk";
            this.textBoxIleSztuk.Size = new System.Drawing.Size(100, 20);
            this.textBoxIleSztuk.TabIndex = 3;
            // 
            // btnDodajDoKoszyka
            // 
            this.btnDodajDoKoszyka.Location = new System.Drawing.Point(672, 345);
            this.btnDodajDoKoszyka.Name = "btnDodajDoKoszyka";
            this.btnDodajDoKoszyka.Size = new System.Drawing.Size(122, 44);
            this.btnDodajDoKoszyka.TabIndex = 4;
            this.btnDodajDoKoszyka.Text = "Dodaj do koszyka";
            this.btnDodajDoKoszyka.UseVisualStyleBackColor = true;
            this.btnDodajDoKoszyka.Click += new System.EventHandler(this.btnDodajDoKoszyka_Click);
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
            // UserControlMieso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnDodajDoKoszyka);
            this.Controls.Add(this.textBoxIleSztuk);
            this.Controls.Add(this.lblIleSztuk);
            this.Controls.Add(this.listViewMieso);
            this.Controls.Add(this.lblMieso);
            this.Name = "UserControlMieso";
            this.Size = new System.Drawing.Size(900, 550);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMieso;
        private System.Windows.Forms.ListView listViewMieso;
        private System.Windows.Forms.Label lblIleSztuk;
        private System.Windows.Forms.TextBox textBoxIleSztuk;
        private System.Windows.Forms.Button btnDodajDoKoszyka;
        private System.Windows.Forms.ColumnHeader hProdukty;
        private System.Windows.Forms.ColumnHeader hIlosc;
        private System.Windows.Forms.ColumnHeader hCena;
    }
}
