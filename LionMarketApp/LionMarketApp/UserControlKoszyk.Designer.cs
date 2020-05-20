namespace LionMarketApp
{
    partial class UserControlKoszyk
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
            this.lblKoszyk = new System.Windows.Forms.Label();
            this.listViewKoszyk = new System.Windows.Forms.ListView();
            this.hProdukty = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hIlosc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hCena = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblC = new System.Windows.Forms.Label();
            this.lblCena = new System.Windows.Forms.Label();
            this.btnWyczyscKoszyk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblKoszyk
            // 
            this.lblKoszyk.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblKoszyk.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblKoszyk.Location = new System.Drawing.Point(0, 0);
            this.lblKoszyk.Name = "lblKoszyk";
            this.lblKoszyk.Size = new System.Drawing.Size(900, 100);
            this.lblKoszyk.TabIndex = 0;
            this.lblKoszyk.Text = "Koszyk";
            this.lblKoszyk.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listViewKoszyk
            // 
            this.listViewKoszyk.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.hProdukty,
            this.hIlosc,
            this.hCena});
            this.listViewKoszyk.HideSelection = false;
            this.listViewKoszyk.Location = new System.Drawing.Point(160, 142);
            this.listViewKoszyk.Name = "listViewKoszyk";
            this.listViewKoszyk.Size = new System.Drawing.Size(505, 300);
            this.listViewKoszyk.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listViewKoszyk.TabIndex = 1;
            this.listViewKoszyk.UseCompatibleStateImageBehavior = false;
            this.listViewKoszyk.View = System.Windows.Forms.View.Details;
            // 
            // hProdukty
            // 
            this.hProdukty.Text = "Produkty";
            this.hProdukty.Width = 300;
            // 
            // hIlosc
            // 
            this.hIlosc.Text = "Ilość";
            this.hIlosc.Width = 100;
            // 
            // hCena
            // 
            this.hCena.Text = "Cena(zł)";
            this.hCena.Width = 100;
            // 
            // lblC
            // 
            this.lblC.AutoSize = true;
            this.lblC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblC.Location = new System.Drawing.Point(320, 480);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(149, 25);
            this.lblC.TabIndex = 2;
            this.lblC.Text = "Cena łącznie: ";
            // 
            // lblCena
            // 
            this.lblCena.AutoSize = true;
            this.lblCena.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCena.Location = new System.Drawing.Point(540, 480);
            this.lblCena.Name = "lblCena";
            this.lblCena.Size = new System.Drawing.Size(40, 25);
            this.lblCena.TabIndex = 3;
            this.lblCena.Text = "0zł";
            // 
            // btnWyczyscKoszyk
            // 
            this.btnWyczyscKoszyk.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnWyczyscKoszyk.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnWyczyscKoszyk.ForeColor = System.Drawing.Color.White;
            this.btnWyczyscKoszyk.Location = new System.Drawing.Point(720, 260);
            this.btnWyczyscKoszyk.Name = "btnWyczyscKoszyk";
            this.btnWyczyscKoszyk.Size = new System.Drawing.Size(120, 70);
            this.btnWyczyscKoszyk.TabIndex = 4;
            this.btnWyczyscKoszyk.Text = "Wyczyść koszyk";
            this.btnWyczyscKoszyk.UseVisualStyleBackColor = false;
            this.btnWyczyscKoszyk.Click += new System.EventHandler(this.btnWyczyscKoszyk_Click);
            // 
            // UserControlKoszyk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnWyczyscKoszyk);
            this.Controls.Add(this.lblCena);
            this.Controls.Add(this.lblC);
            this.Controls.Add(this.listViewKoszyk);
            this.Controls.Add(this.lblKoszyk);
            this.Name = "UserControlKoszyk";
            this.Size = new System.Drawing.Size(900, 550);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKoszyk;
        private System.Windows.Forms.ColumnHeader hProdukty;
        private System.Windows.Forms.ColumnHeader hIlosc;
        private System.Windows.Forms.ColumnHeader hCena;
        public System.Windows.Forms.ListView listViewKoszyk;
        private System.Windows.Forms.Label lblC;
        public System.Windows.Forms.Label lblCena;
        private System.Windows.Forms.Button btnWyczyscKoszyk;
    }
}
