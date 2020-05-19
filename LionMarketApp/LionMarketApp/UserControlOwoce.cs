﻿using System;
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
    public partial class UserControlOwoce : UserControl
    {
        public UserControlOwoce()
        {
            InitializeComponent();
            DodajProdukty();
            listViewOwoce.Items[0].Selected = true;
        }

        public List<ListViewItem> wybraneProdukty = new List<ListViewItem>();//lista produktów

        public double suma = 0;//suma wybranych produktów

        private void DodajProdukty()//dodanie produktów do bazy
        {
            listViewOwoce.FullRowSelect = true;

            ListViewItem prod1 = new ListViewItem("Jabłka");
            prod1.SubItems.Add("1kg");
            prod1.SubItems.Add("5");

            ListViewItem prod2 = new ListViewItem("Banany");
            prod2.SubItems.Add("1kg");
            prod2.SubItems.Add("4,50");

            ListViewItem prod3 = new ListViewItem("Kiwi");
            prod3.SubItems.Add("1kg");
            prod3.SubItems.Add("6");

            listViewOwoce.Items.AddRange(new ListViewItem[] { prod1, prod2, prod3 });
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
                
                ListViewItem prod = new ListViewItem(listViewOwoce.SelectedItems[0].Text);

                prod.SubItems.Add(x.ToString());

                double cena = double.Parse(listViewOwoce.SelectedItems[0].SubItems[2].Text);
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
