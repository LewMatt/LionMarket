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
    public partial class UserControlMieso : UserControl
    {
        public UserControlMieso()
        {
            InitializeComponent();
            DodajProdukty();
            listViewMieso.Items[0].Selected = true;
        }

        public List<ListViewItem> wybraneProdukty = new List<ListViewItem>();//lista produktów

        public double suma = 0;//suma wybranych produktów

        private void DodajProdukty()//dodanie produktów do bazy
        {
            listViewMieso.FullRowSelect = true;

            ListViewItem prod1 = new ListViewItem("Karkówka");
            prod1.SubItems.Add("1kg");
            prod1.SubItems.Add("16");

            ListViewItem prod2 = new ListViewItem("Kurczak");
            prod2.SubItems.Add("1kg");
            prod2.SubItems.Add("10");

            ListViewItem prod3 = new ListViewItem("Szynka");
            prod3.SubItems.Add("1kg");
            prod3.SubItems.Add("18,50");

            listViewMieso.Items.AddRange(new ListViewItem[] { prod1, prod2, prod3 });
        }

        private void btnDodajDoKoszyka_Click(object sender, EventArgs e)//przycisk
        {
            if (double.TryParse(textBoxIleSztuk.Text, out double x) == false)
            {
                MessageBox.Show("Niepoprawne dane.");
            }
            else if (double.Parse(textBoxIleSztuk.Text) <= 0)
            {
                MessageBox.Show("Ilość musi być większa niż 0");
            }
            else
            {

                ListViewItem prod = new ListViewItem(listViewMieso.SelectedItems[0].Text);

                prod.SubItems.Add(x.ToString());

                double cena = double.Parse(listViewMieso.SelectedItems[0].SubItems[2].Text);
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
