namespace LionMarketApp
{
    partial class FormMenu
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnPromocje = new System.Windows.Forms.Button();
            this.btnPieczywo = new System.Windows.Forms.Button();
            this.btnOwoce = new System.Windows.Forms.Button();
            this.btnWarzywa = new System.Windows.Forms.Button();
            this.btnMieso = new System.Windows.Forms.Button();
            this.btnNabial = new System.Windows.Forms.Button();
            this.btnNapoje = new System.Windows.Forms.Button();
            this.btnSlodycze = new System.Windows.Forms.Button();
            this.btnArtSpoz = new System.Windows.Forms.Button();
            this.btnPrzyprawy = new System.Windows.Forms.Button();
            this.btnKoszyk = new System.Windows.Forms.Button();
            this.userControlPromocje1 = new LionMarketApp.UserControlPromocje();
            this.userControlKoszyk1 = new LionMarketApp.UserControlKoszyk();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnPrzyprawy);
            this.panel1.Controls.Add(this.btnArtSpoz);
            this.panel1.Controls.Add(this.btnSlodycze);
            this.panel1.Controls.Add(this.btnNapoje);
            this.panel1.Controls.Add(this.btnNabial);
            this.panel1.Controls.Add(this.btnMieso);
            this.panel1.Controls.Add(this.btnWarzywa);
            this.panel1.Controls.Add(this.btnOwoce);
            this.panel1.Controls.Add(this.btnPieczywo);
            this.panel1.Controls.Add(this.btnPromocje);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 700);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnExit);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(200, 650);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(900, 50);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnKoszyk);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(200, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(900, 100);
            this.panel3.TabIndex = 2;
            // 
            // btnExit
            // 
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnExit.Location = new System.Drawing.Point(800, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 50);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Wyjście";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnPromocje
            // 
            this.btnPromocje.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPromocje.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPromocje.Location = new System.Drawing.Point(0, 0);
            this.btnPromocje.Name = "btnPromocje";
            this.btnPromocje.Size = new System.Drawing.Size(200, 50);
            this.btnPromocje.TabIndex = 0;
            this.btnPromocje.Text = "Promocje";
            this.btnPromocje.UseVisualStyleBackColor = true;
            this.btnPromocje.Click += new System.EventHandler(this.btnPromocje_Click);
            // 
            // btnPieczywo
            // 
            this.btnPieczywo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPieczywo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPieczywo.Location = new System.Drawing.Point(0, 50);
            this.btnPieczywo.Name = "btnPieczywo";
            this.btnPieczywo.Size = new System.Drawing.Size(200, 50);
            this.btnPieczywo.TabIndex = 1;
            this.btnPieczywo.Text = "Pieczywo";
            this.btnPieczywo.UseVisualStyleBackColor = true;
            // 
            // btnOwoce
            // 
            this.btnOwoce.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOwoce.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnOwoce.Location = new System.Drawing.Point(0, 100);
            this.btnOwoce.Name = "btnOwoce";
            this.btnOwoce.Size = new System.Drawing.Size(200, 50);
            this.btnOwoce.TabIndex = 2;
            this.btnOwoce.Text = "Owoce";
            this.btnOwoce.UseVisualStyleBackColor = true;
            // 
            // btnWarzywa
            // 
            this.btnWarzywa.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnWarzywa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnWarzywa.Location = new System.Drawing.Point(0, 150);
            this.btnWarzywa.Name = "btnWarzywa";
            this.btnWarzywa.Size = new System.Drawing.Size(200, 50);
            this.btnWarzywa.TabIndex = 3;
            this.btnWarzywa.Text = "Warzywa";
            this.btnWarzywa.UseVisualStyleBackColor = true;
            // 
            // btnMieso
            // 
            this.btnMieso.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMieso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnMieso.Location = new System.Drawing.Point(0, 200);
            this.btnMieso.Name = "btnMieso";
            this.btnMieso.Size = new System.Drawing.Size(200, 50);
            this.btnMieso.TabIndex = 4;
            this.btnMieso.Text = "Mięso/Wędliny";
            this.btnMieso.UseVisualStyleBackColor = true;
            // 
            // btnNabial
            // 
            this.btnNabial.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNabial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNabial.Location = new System.Drawing.Point(0, 250);
            this.btnNabial.Name = "btnNabial";
            this.btnNabial.Size = new System.Drawing.Size(200, 50);
            this.btnNabial.TabIndex = 5;
            this.btnNabial.Text = "Nabiał";
            this.btnNabial.UseVisualStyleBackColor = true;
            // 
            // btnNapoje
            // 
            this.btnNapoje.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNapoje.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNapoje.Location = new System.Drawing.Point(0, 300);
            this.btnNapoje.Name = "btnNapoje";
            this.btnNapoje.Size = new System.Drawing.Size(200, 50);
            this.btnNapoje.TabIndex = 6;
            this.btnNapoje.Text = "Napoje";
            this.btnNapoje.UseVisualStyleBackColor = true;
            // 
            // btnSlodycze
            // 
            this.btnSlodycze.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSlodycze.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSlodycze.Location = new System.Drawing.Point(0, 350);
            this.btnSlodycze.Name = "btnSlodycze";
            this.btnSlodycze.Size = new System.Drawing.Size(200, 50);
            this.btnSlodycze.TabIndex = 7;
            this.btnSlodycze.Text = "Słodycze";
            this.btnSlodycze.UseVisualStyleBackColor = true;
            // 
            // btnArtSpoz
            // 
            this.btnArtSpoz.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnArtSpoz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnArtSpoz.Location = new System.Drawing.Point(0, 400);
            this.btnArtSpoz.Name = "btnArtSpoz";
            this.btnArtSpoz.Size = new System.Drawing.Size(200, 50);
            this.btnArtSpoz.TabIndex = 8;
            this.btnArtSpoz.Text = "Art. spożywcze";
            this.btnArtSpoz.UseVisualStyleBackColor = true;
            // 
            // btnPrzyprawy
            // 
            this.btnPrzyprawy.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPrzyprawy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPrzyprawy.Location = new System.Drawing.Point(0, 450);
            this.btnPrzyprawy.Name = "btnPrzyprawy";
            this.btnPrzyprawy.Size = new System.Drawing.Size(200, 50);
            this.btnPrzyprawy.TabIndex = 9;
            this.btnPrzyprawy.Text = "Przyprawy";
            this.btnPrzyprawy.UseVisualStyleBackColor = true;
            // 
            // btnKoszyk
            // 
            this.btnKoszyk.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnKoszyk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnKoszyk.Location = new System.Drawing.Point(800, 0);
            this.btnKoszyk.Name = "btnKoszyk";
            this.btnKoszyk.Size = new System.Drawing.Size(100, 100);
            this.btnKoszyk.TabIndex = 0;
            this.btnKoszyk.Text = "Koszyk";
            this.btnKoszyk.UseVisualStyleBackColor = true;
            this.btnKoszyk.Click += new System.EventHandler(this.btnKoszyk_Click);
            // 
            // userControlPromocje1
            // 
            this.userControlPromocje1.Location = new System.Drawing.Point(200, 100);
            this.userControlPromocje1.Name = "userControlPromocje1";
            this.userControlPromocje1.Size = new System.Drawing.Size(900, 550);
            this.userControlPromocje1.TabIndex = 3;
            // 
            // userControlKoszyk1
            // 
            this.userControlKoszyk1.Location = new System.Drawing.Point(200, 100);
            this.userControlKoszyk1.Name = "userControlKoszyk1";
            this.userControlKoszyk1.Size = new System.Drawing.Size(900, 550);
            this.userControlKoszyk1.TabIndex = 4;
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 700);
            this.Controls.Add(this.userControlKoszyk1);
            this.Controls.Add(this.userControlPromocje1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMenu";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnPrzyprawy;
        private System.Windows.Forms.Button btnArtSpoz;
        private System.Windows.Forms.Button btnSlodycze;
        private System.Windows.Forms.Button btnNapoje;
        private System.Windows.Forms.Button btnNabial;
        private System.Windows.Forms.Button btnMieso;
        private System.Windows.Forms.Button btnWarzywa;
        private System.Windows.Forms.Button btnOwoce;
        private System.Windows.Forms.Button btnPieczywo;
        private System.Windows.Forms.Button btnPromocje;
        private System.Windows.Forms.Button btnKoszyk;
        private UserControlPromocje userControlPromocje1;
        private UserControlKoszyk userControlKoszyk1;
    }
}