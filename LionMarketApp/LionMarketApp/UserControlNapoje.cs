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
    public partial class UserControlNapoje : UserControl
    {
        public UserControlNapoje()
        {
            InitializeComponent();
            DodajProdukty();
            listViewNapoje.Items[0].Selected = true;
        }

        public List<ListViewItem> wybraneProdukty = new List<ListViewItem>();//lista produktów

        public double suma = 0;//suma wybranych produktów

        private void DodajProdukty()//dodanie produktów do bazy
        {
            listViewNapoje.FullRowSelect = true;

            ListViewItem prod1 = new ListViewItem("Cola");
            prod1.SubItems.Add("1litr");
            prod1.SubItems.Add("2");

            ListViewItem prod2 = new ListViewItem("Woda");
            prod2.SubItems.Add("1litr");
            prod2.SubItems.Add("1");

            ListViewItem prod3 = new ListViewItem("Sok pomarańczowy");
            prod3.SubItems.Add("1litr");
            prod3.SubItems.Add("3");

            listViewNapoje.Items.AddRange(new ListViewItem[] { prod1, prod2, prod3 });
        }

        private void btnDodajDoKoszyka_Click(object sender, EventArgs e)//przycisk
        {
            if (int.TryParse(textBoxIleSztuk.Text, out int x) == false)
            {
                MessageBox.Show("Niepoprawne dane.");
            }
            else if (int.Parse(textBoxIleSztuk.Text) <= 0)
            {
                MessageBox.Show("Ilość musi być większa niż 0");
            }
            else
            {

                ListViewItem prod = new ListViewItem(listViewNapoje.SelectedItems[0].Text);

                prod.SubItems.Add(x.ToString());

                double cena = double.Parse(listViewNapoje.SelectedItems[0].SubItems[2].Text);
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
