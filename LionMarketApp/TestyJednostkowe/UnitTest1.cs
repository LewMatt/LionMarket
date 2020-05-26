using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LionMarketApp;
using System.Windows.Forms;

namespace TestyJednostkowe
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //objekt testowy
            UserControl1Pieczywo pieczObj = new UserControl1Pieczywo();

            //tworzymy kontrolke na potrzeby testów jednostkowych
            pieczObj.listViewPieczywo.CreateControl();

            //cena produktu
            double cena = 5;

            //ilość sztuk wybranego produktu
            int ilosc = 3;

            //ustawienie ilosci w polu wyboru
            pieczObj.textBoxIleSztuk.Text = ilosc.ToString();

            //dodanie produktów do koszyka
            pieczObj.dodajDoKoszyka();

            //suma oczekiwana
            double suma_o = cena * ilosc;

            //sprawdzanie danych
            Assert.AreEqual(suma_o, pieczObj.suma, 0.001, "Nie działa");

        }

        [TestMethod]
        public void TestMethod2()
        {
            //objekt testowy
            UserControlNabial nabObj = new UserControlNabial();

            //tworzymy kontrolke na potrzeby testów jednostkowych
            nabObj.listViewNabial.CreateControl();

            //cena produktu
            double cena = 20;

            //ilość wybranych produktów
            int ilosc = 4;

            //ilość jednorazowego dodania 
            int x = 1;

            //dodanie produktów do koszyka
            for(int i = 0;i<ilosc;i++)
            {
                nabObj.textBoxIleSztuk.Text = x.ToString();
                nabObj.dodajDoKoszyka();
            }

            //suma oczekiwana
            double suma_o = cena * ilosc;

            //sprawdzenie danych
            Assert.AreEqual(suma_o, nabObj.suma, 0.001, "Nie działa");

        }

        [TestMethod]
        public void TestMethod3()
        {
            //objekt testowy
            UserControlSlodycze slodObj = new UserControlSlodycze();

            //tworzymy kontrolke na potrzeby testów jednostkowych
            slodObj.listViewSlodycze.CreateControl();

            //ilosc produktów do dodania
            double ilosc = 14;

            //ilość sztuk w pojedynczym dodaniu
            int x = 1;

            //dodanie produktów do koszyka
            for(int i = 0;i<ilosc;i++)
            {
                slodObj.textBoxIleSztuk.Text = x.ToString();
                slodObj.dodajDoKoszyka();
            }

            //ilość produktów dodanych do koszyka
            int ilosc_prod_dodanych = slodObj.wybraneProdukty.Count;

            //sprawdzenie danych
            Assert.AreEqual(ilosc, ilosc_prod_dodanych, 0.001, "Nie działa");

        }
    }


}
