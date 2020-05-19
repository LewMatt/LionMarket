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
            this.lblKoszyk.AutoSize = true;
            this.lblKoszyk.Location = new System.Drawing.Point(408, 87);
            this.lblKoszyk.Name = "lblKoszyk";
            this.lblKoszyk.Size = new System.Drawing.Size(41, 13);
            this.lblKoszyk.TabIndex = 0;
            this.lblKoszyk.Text = "Koszyk";
            // 
            // listViewKoszyk
            // 
            this.listViewKoszyk.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.hProdukty,
            this.hIlosc,
            this.hCena});
            this.listViewKoszyk.HideSelection = false;
            this.listViewKoszyk.Location = new System.Drawing.Point(188, 150);
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
            this.lblC.Location = new System.Drawing.Point(379, 495);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(76, 13);
            this.lblC.TabIndex = 2;
            this.lblC.Text = "Cena łącznie: ";
            // 
            // lblCena
            // 
            this.lblCena.AutoSize = true;
            this.lblCena.Location = new System.Drawing.Point(546, 495);
            this.lblCena.Name = "lblCena";
            this.lblCena.Size = new System.Drawing.Size(22, 13);
            this.lblCena.TabIndex = 3;
            this.lblCena.Text = "0zł";
            // 
            // btnWyczyscKoszyk
            // 
            this.btnWyczyscKoszyk.Location = new System.Drawing.Point(763, 254);
            this.btnWyczyscKoszyk.Name = "btnWyczyscKoszyk";
            this.btnWyczyscKoszyk.Size = new System.Drawing.Size(85, 59);
            this.btnWyczyscKoszyk.TabIndex = 4;
            this.btnWyczyscKoszyk.Text = "Wyczyść koszyk";
            this.btnWyczyscKoszyk.UseVisualStyleBackColor = true;
            this.btnWyczyscKoszyk.Click += new System.EventHandler(this.btnWyczyscKoszyk_Click);
            // 
            // UserControlKoszyk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
