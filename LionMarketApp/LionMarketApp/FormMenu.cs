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
            userControlPromocje1.BringToFront();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btnKoszyk_Click(object sender, EventArgs e)
        {
           
            double suma_cen = 0;

            foreach(ListViewItem x in userControl1Pieczywo1.wybraneProdukty)
            {
                userControlKoszyk1.produktyKoszyk.Add(x);
            }
            userControl1Pieczywo1.wybraneProdukty.Clear();

            userControlKoszyk1.listViewKoszyk.Items.Clear();

            foreach(ListViewItem x in userControlKoszyk1.produktyKoszyk)
            {
                userControlKoszyk1.listViewKoszyk.Items.Add(x);
            }

            userControlKoszyk1.suma_koszyk += userControl1Pieczywo1.suma;
            userControl1Pieczywo1.suma = 0;

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

        private void btnOwoce_Click(object sender, EventArgs e)
        {
            userControlOwoce1.BringToFront();
        }

        private void btnWarzywa_Click(object sender, EventArgs e)
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

        private void btnNapoje_Click(object sender, EventArgs e)
        {
            userControlNapoje1.BringToFront();
        }

        private void btnSlodycze_Click(object sender, EventArgs e)
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
