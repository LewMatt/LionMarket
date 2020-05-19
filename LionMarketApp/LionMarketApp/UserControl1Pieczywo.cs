using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LionMarketApp
{
    public partial class UserControl1Pieczywo : UserControl
    {
        public UserControl1Pieczywo()
        {
            InitializeComponent();
            DodajProdukty();
            listViewPieczywo.Items[0].Selected = true;
        }

        public List<ListViewItem> wybraneProdukty = new List<ListViewItem>();

        public double suma = 0;

        private void DodajProdukty()
        {
            listViewPieczywo.FullRowSelect = true;

            ListViewItem prod1 = new ListViewItem("Chleb");
            prod1.SubItems.Add("1szt");
            prod1.SubItems.Add("5");

            ListViewItem prod2 = new ListViewItem("Bułka");
            prod2.SubItems.Add("1szt");
            prod2.SubItems.Add("1");

            ListViewItem prod3 = new ListViewItem("Bagietka");
            prod3.SubItems.Add("1szt");
            prod3.SubItems.Add("2,50");

            listViewPieczywo.Items.AddRange(new ListViewItem[] { prod1, prod2, prod3 });
        }

        private void btnDodajDoKoszyka_Click(object sender, EventArgs e)
        {

            if (int.TryParse(textBoxIleSztuk.Text, out int x) == false)
            {
                MessageBox.Show("Niepoprawne dane.");
            }
            else if(int.Parse(textBoxIleSztuk.Text) <= 0)
            {
                MessageBox.Show("Ilość musi być większa niż 0");
            }
            else
            {
                ListViewItem prod = new ListViewItem(listViewPieczywo.SelectedItems[0].Text);
                prod.SubItems.Add(x.ToString());
                double cena = double.Parse(listViewPieczywo.SelectedItems[0].SubItems[2].Text);
                double cena_razem = cena * x;
                prod.SubItems.Add(cena_razem.ToString());
                wybraneProdukty.Add(prod);
                suma = suma + cena_razem;

                MessageBox.Show("Dodano do koszyka.");

                textBoxIleSztuk.Text = "";

            }
        }
    }
}
