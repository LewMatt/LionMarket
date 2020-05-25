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

            pieczObj.listViewPieczywo.CreateControl();

            //cena produktu
            double cena = 5;

            //ile wybranych produktów
            int ilosc = 3;

            //ustawienie ilosci w polu wyboru
            pieczObj.textBoxIleSztuk.Text = ilosc.ToString();

            //dodanie produktów do koszyka

            pieczObj.dodajDoKoszyka();

            //suma oczekiwana
            double suma_o = cena * ilosc;

            Assert.AreEqual(suma_o, pieczObj.suma, 0.001, "Nie działa");

        }

        [TestMethod]
        public void TestMethod2()
        {
            UserControlNabial nabObj = new UserControlNabial();

            nabObj.listViewNabial.CreateControl();

            double cena = 20;

            int ilosc = 4;

            int x = 1;

            for(int i = 0;i<ilosc;i++)
            {
                nabObj.textBoxIleSztuk.Text = x.ToString();
                nabObj.dodajDoKoszyka();
            }

            double suma_o = cena * ilosc;

            Assert.AreEqual(suma_o, nabObj.suma, 0.001, "Nie działa");
        }
    }


}
