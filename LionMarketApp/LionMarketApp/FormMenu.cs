using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LionMarketApp
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
            userControlPromocje1.fMenu = this;
            userControlPromocje1.BringToFront();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        //koszyk
        private void btnKoszyk_Click(object sender, EventArgs e)
        { 

            //pieczywo
            foreach(ListViewItem x in userControl1Pieczywo1.wybraneProdukty)
            {
                userControlKoszyk1.produktyKoszyk.Add(x);
            }
            userControl1Pieczywo1.wybraneProdukty.Clear();

            //owoce
            foreach (ListViewItem x in userControlOwoce1.wybraneProdukty)
            {
                userControlKoszyk1.produktyKoszyk.Add(x);
            }
            userControlOwoce1.wybraneProdukty.Clear();

            //warzywa
            foreach (ListViewItem x in userControlWarzywa1.wybraneProdukty)
            {
                userControlKoszyk1.produktyKoszyk.Add(x);
            }
            userControlWarzywa1.wybraneProdukty.Clear();

            //mieso
            foreach (ListViewItem x in userControlMieso1.wybraneProdukty)
            {
                userControlKoszyk1.produktyKoszyk.Add(x);
            }
            userControlMieso1.wybraneProdukty.Clear();

            //nabial
            foreach (ListViewItem x in userControlNabial1.wybraneProdukty)
            {
                userControlKoszyk1.produktyKoszyk.Add(x);
            }
            userControlNabial1.wybraneProdukty.Clear();

            //napoje
            foreach (ListViewItem x in userControlNapoje1.wybraneProdukty)
            {
                userControlKoszyk1.produktyKoszyk.Add(x);
            }
            userControlNapoje1.wybraneProdukty.Clear();

            //slodycze
            foreach (ListViewItem x in userControlSlodycze1.wybraneProdukty)
            {
                userControlKoszyk1.produktyKoszyk.Add(x);
            }
            userControlSlodycze1.wybraneProdukty.Clear();

            //artykuły spozywcze
            foreach (ListViewItem x in userControlArtSpoz1.wybraneProdukty)
            {
                userControlKoszyk1.produktyKoszyk.Add(x);
            }
            userControlArtSpoz1.wybraneProdukty.Clear();

            //przyprawy
            foreach (ListViewItem x in userControlPrzyprawy1.wybraneProdukty)
            {
                userControlKoszyk1.produktyKoszyk.Add(x);
            }
            userControlPrzyprawy1.wybraneProdukty.Clear();

            //wyswietlanie koszyka
            userControlKoszyk1.listViewKoszyk.Items.Clear();

            foreach (ListViewItem x in userControlKoszyk1.produktyKoszyk)
            {
                userControlKoszyk1.listViewKoszyk.Items.Add(x);
            }

            //pieczywo cena
            userControlKoszyk1.suma_koszyk += userControl1Pieczywo1.suma;
            userControl1Pieczywo1.suma = 0;

            //owoce cena
            userControlKoszyk1.suma_koszyk += userControlOwoce1.suma;
            userControlOwoce1.suma = 0;

            //warzywa cena
            userControlKoszyk1.suma_koszyk += userControlWarzywa1.suma;
            userControlWarzywa1.suma = 0;

            //mieso cena
            userControlKoszyk1.suma_koszyk += userControlMieso1.suma;
            userControlMieso1.suma = 0;

            //nabial cena
            userControlKoszyk1.suma_koszyk += userControlNabial1.suma;
            userControlNabial1.suma = 0;

            //napoje cena
            userControlKoszyk1.suma_koszyk += userControlNapoje1.suma;
            userControlNapoje1.suma = 0;

            //slodycze cena
            userControlKoszyk1.suma_koszyk += userControlSlodycze1.suma;
            userControlSlodycze1.suma = 0;

            //artykuły spozywcze cena
            userControlKoszyk1.suma_koszyk += userControlArtSpoz1.suma;
            userControlArtSpoz1.suma = 0;

            //przyprawy cena
            userControlKoszyk1.suma_koszyk += userControlPrzyprawy1.suma;
            userControlPrzyprawy1.suma = 0;

            //wyswietl cene
            userControlKoszyk1.lblCena.Text = userControlKoszyk1.suma_koszyk.ToString() + " zł" ;

            userControlKoszyk1.BringToFront();
        }

        private void btnPromocje_Click(object sender, EventArgs e)
        {
            userControlPromocje1.BringToFront();
        }

        private void btnPieczywo_Click(object sender, EventArgs e)
        {
            userControl1Pieczywo1.BringToFront();
        }

        
        public void btnOwoce_Click(object sender, EventArgs e)
        {
            userControlOwoce1.BringToFront();
        }

        public void btnWarzywa_Click(object sender, EventArgs e)
        {
            userControlWarzywa1.BringToFront();
        }

        private void btnMieso_Click(object sender, EventArgs e)
        {
            userControlMieso1.BringToFront();
        }

        private void btnNabial_Click(object sender, EventArgs e)
        {
            userControlNabial1.BringToFront();
        }

        public void btnNapoje_Click(object sender, EventArgs e)
        {
            userControlNapoje1.BringToFront();
        }

        public void btnSlodycze_Click(object sender, EventArgs e)
        {
            userControlSlodycze1.BringToFront();
        }

        private void btnArtSpoz_Click(object sender, EventArgs e)
        {
            userControlArtSpoz1.BringToFront();
        }

        private void btnPrzyprawy_Click(object sender, EventArgs e)
        {
            userControlPrzyprawy1.BringToFront();
        }
    }
}
