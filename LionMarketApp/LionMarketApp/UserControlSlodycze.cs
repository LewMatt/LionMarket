﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;

namespace LionMarketApp
{
    public partial class UserControlSlodycze : UserControl
    {
        public UserControlSlodycze()
        {
            InitializeComponent();
            DodajProdukty();
            listViewSlodycze.Items[0].Selected = true;
        }

        public List<ListViewItem> wybraneProdukty = new List<ListViewItem>();//lista produktów

        public double suma = 0;//suma wybranych produktów

        public void DodajProdukty()//dodanie produktów do bazy
        {
            listViewSlodycze.FullRowSelect = true;

            ListViewItem prod1 = new ListViewItem("Czekolada");
            prod1.SubItems.Add("1szt");
            prod1.SubItems.Add("2,50");

            ListViewItem prod2 = new ListViewItem("Ciastka");
            prod2.SubItems.Add("1op");
            prod2.SubItems.Add("5");

            ListViewItem prod3 = new ListViewItem("Batonik");
            prod3.SubItems.Add("1szt");
            prod3.SubItems.Add("2");

            listViewSlodycze.Items.AddRange(new ListViewItem[] { prod1, prod2, prod3 });
        }

        public void btnDodajDoKoszyka_Click(object sender, EventArgs e)//przycisk
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

                ListViewItem prod = new ListViewItem(listViewSlodycze.SelectedItems[0].Text);

                prod.SubItems.Add(x.ToString());

                double cena = double.Parse(listViewSlodycze.SelectedItems[0].SubItems[2].Text);
                double cena_razem = cena * x;

                prod.SubItems.Add(cena_razem.ToString());

                wybraneProdukty.Add(prod);

                suma = suma + cena_razem;

                MessageBox.Show("Dodano do koszyka.");

                textBoxIleSztuk.Text = "";

            }
        }
        public void dodajDoKoszyka()
        {
            btnDodajDoKoszyka_Click(null, RoutedEventArgs.Empty);
        }
    }
}
