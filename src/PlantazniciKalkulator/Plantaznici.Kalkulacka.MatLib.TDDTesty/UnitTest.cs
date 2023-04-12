/*
 * Autoři:  Marek Kunz (xkunzm02) - vedouci
 *          Jan Křivák (xkriva36)
 *          Marian Pražák (xpraza11)
 *          Kryštof Pleva (xpleva09)
 * 
 * Tým:     Plantážníci
 * 
 * */


using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Plantaznici.Kalkulacka.MathLib;
using KupeckePokty = Plantaznici.Kalkulacka.MathLib.MathLib;

namespace Plantaznici.Kalkulacka.TDDTests
{
    [TestClass]
    public class TestyKnihovny
    {

        //Konstanta, pomahajici usmernit nepresnosti pri pocitani s desetinymi cisly
        const double presnostPoctu = 0.000001;

        [TestMethod]
        public void TestSouctu()
        {
            //Testy Rovnosti
            Assert.AreEqual(0, new KupeckePokty().Scitani(0, 0));
            Assert.AreEqual(10, new KupeckePokty().Scitani(10, 0));
            Assert.AreEqual(0, new KupeckePokty().Scitani(10, -10));
            Assert.AreEqual(0, new KupeckePokty().Scitani(-10, 10));
            Assert.AreEqual(20, new KupeckePokty().Scitani(10, 10));
            Assert.AreEqual(-20, new KupeckePokty().Scitani(-10, -10));
            Assert.AreEqual(300000000, new KupeckePokty().Scitani(200000000, 100000000));
            Assert.AreEqual(2.5, new KupeckePokty().Scitani(1.25, 1.25), presnostPoctu);
            Assert.AreEqual(0, new KupeckePokty().Scitani(-101.25, 101.25), presnostPoctu);
            Assert.AreEqual(2 * Math.PI, new KupeckePokty().Scitani(Math.PI, Math.PI), presnostPoctu);


            //Testy Nerovnosti
            Assert.AreNotEqual(10, new KupeckePokty().Scitani(0, 0));
            Assert.AreNotEqual(0, new KupeckePokty().Scitani(10, 0));
            Assert.AreNotEqual(20, new KupeckePokty().Scitani(10, -10));
            Assert.AreNotEqual(-100, new KupeckePokty().Scitani(-500, 600));
            Assert.AreNotEqual(Math.PI, new KupeckePokty().Scitani(Math.PI, Math.PI), presnostPoctu);
            Assert.AreNotEqual(3, new KupeckePokty().Scitani(1.25, 1.25), presnostPoctu);
        }

        [TestMethod]
        public void TestRozdilu()
        {
            //Testy Rovnosti
            Assert.AreEqual(0, new KupeckePokty().Odcitani(0, 0));
            Assert.AreEqual(10, new KupeckePokty().Odcitani(10, 0));
            Assert.AreEqual(20, new KupeckePokty().Odcitani(10, -10));
            Assert.AreEqual(-20, new KupeckePokty().Odcitani(-10, 10));
            Assert.AreEqual(0, new KupeckePokty().Odcitani(10, 10));
            Assert.AreEqual(0, new KupeckePokty().Odcitani(-10, -10));
            Assert.AreEqual(100000000, new KupeckePokty().Odcitani(200000000, 100000000));
            Assert.AreEqual(0, new KupeckePokty().Odcitani(1.25, 1.25), presnostPoctu);
            Assert.AreEqual(-202.5, new KupeckePokty().Odcitani(-101.25, 101.25), presnostPoctu);
            Assert.AreEqual(0, new KupeckePokty().Odcitani(Math.PI, Math.PI), presnostPoctu);

            //Testy Nerovnosti
            Assert.AreNotEqual(-1, new KupeckePokty().Odcitani(0, 0));
            Assert.AreNotEqual(0, new KupeckePokty().Odcitani(10, 0));
            Assert.AreNotEqual(0, new KupeckePokty().Odcitani(10, -10));
            Assert.AreNotEqual(20, new KupeckePokty().Odcitani(-10, 10));
            Assert.AreNotEqual(20, new KupeckePokty().Odcitani(10, 10));
            Assert.AreNotEqual(-20, new KupeckePokty().Odcitani(-10, -10));
            Assert.AreNotEqual(300000000, new KupeckePokty().Odcitani(200000000, 100000000));
            Assert.AreNotEqual(2.5, new KupeckePokty().Odcitani(1.25, 1.25), presnostPoctu);
            Assert.AreNotEqual(202.5, new KupeckePokty().Odcitani(-101.25, 101.25), presnostPoctu);
            Assert.AreNotEqual(2 * Math.PI, new KupeckePokty().Odcitani(Math.PI, Math.PI), presnostPoctu);
        }

        [TestMethod]
        public void TestNasobeni()
        {
            //Testy Rovnosti
            Assert.AreEqual(0, new KupeckePokty().Nasobeni(0, 0));
            Assert.AreEqual(0, new KupeckePokty().Nasobeni(50, 0));
            Assert.AreEqual(0, new KupeckePokty().Nasobeni(0, 50));
            Assert.AreEqual(50, new KupeckePokty().Nasobeni(1, 50));
            Assert.AreEqual(2500, new KupeckePokty().Nasobeni(50, 50));
            Assert.AreEqual(30, new KupeckePokty().Nasobeni(3, 10));
            Assert.AreEqual(-30, new KupeckePokty().Nasobeni(-3, 10));
            Assert.AreEqual(30, new KupeckePokty().Nasobeni(-3, -10));
            Assert.AreEqual(-30, new KupeckePokty().Nasobeni(3, -10));
            Assert.AreEqual(3, new KupeckePokty().Nasobeni(10, 0.3), presnostPoctu);
            Assert.AreEqual(1.5625, new KupeckePokty().Nasobeni(1.25, 1.25), presnostPoctu);

            //Testy Nerovnosti
            Assert.AreNotEqual(1, new KupeckePokty().Nasobeni(0, 0));
            Assert.AreNotEqual(1, new KupeckePokty().Nasobeni(50, 0));
            Assert.AreNotEqual(100, new KupeckePokty().Nasobeni(50, 50));
            Assert.AreNotEqual(-30, new KupeckePokty().Nasobeni(-3, -10));
            Assert.AreNotEqual(0.03, new KupeckePokty().Nasobeni(0.3, 10), presnostPoctu);
        }

        [TestMethod]
        public void TestDeleni()
        {
            Assert.ThrowsException<DivideByZeroException>(() => new KupeckePokty().Deleni(50, 0));
            //Testy rovnosti
            Assert.AreEqual(0, new KupeckePokty().Deleni(0, 50));
            Assert.AreEqual(0, new KupeckePokty().Deleni(0, -50));
            Assert.AreEqual(2, new KupeckePokty().Deleni(100, 50));
            Assert.AreEqual(-2, new KupeckePokty().Deleni(100, -50));
            Assert.AreEqual(-2, new KupeckePokty().Deleni(-100, 50));
            Assert.AreEqual(2, new KupeckePokty().Deleni(-100, -50));
            Assert.AreEqual(100, new KupeckePokty().Deleni(100, 1));
            Assert.AreEqual(15.88888888888, new KupeckePokty().Deleni(35.75, 2.25), presnostPoctu);
            Assert.AreEqual(0.3, new KupeckePokty().Deleni(3, 10));
            Assert.AreEqual(1, new KupeckePokty().Deleni(100, 100));
            Assert.AreEqual(-3164.5, new KupeckePokty().Deleni(-405056, 128), presnostPoctu);

            //Test nerovnosti
            Assert.AreNotEqual(1, new KupeckePokty().Deleni(0, 50));
            Assert.AreNotEqual(144, new KupeckePokty().Deleni(12, 12));
            Assert.AreNotEqual(-2, new KupeckePokty().Deleni(-100, -50));
            Assert.AreNotEqual(-30, new KupeckePokty().Deleni(-3, -10));
            Assert.AreNotEqual(30, new KupeckePokty().Deleni(3, -10));
            Assert.AreNotEqual(3, new KupeckePokty().Deleni(0.3, 10), presnostPoctu);

            //Test deleni nulou

            Assert.ThrowsException<DivideByZeroException>(() => new KupeckePokty().Deleni(-50, 0));
        }

        [TestMethod]
        public void TestFaktorial()
        {
            //Testy rovnosti
            Assert.AreEqual(1, new KupeckePokty().Faktorial(0));
            Assert.AreEqual(120, new KupeckePokty().Faktorial(5));
            Assert.AreEqual(3628800, new KupeckePokty().Faktorial(10));
            Assert.AreEqual(1, new KupeckePokty().Faktorial(1));
            Assert.AreEqual(1, new KupeckePokty().Faktorial(1));

            //Testy nerovnosti
            Assert.AreNotEqual(0, new KupeckePokty().Faktorial(0));

            //Test zaporneho cisla
            Assert.ThrowsException<ArgumentException>(() => new KupeckePokty().Faktorial(-2));

            //Test desetineho cisla
            Assert.ThrowsException<ArgumentException>(() => new KupeckePokty().Faktorial(1.5));
            Assert.ThrowsException<ArgumentException>(() => new KupeckePokty().Faktorial(-1.5));
        }

        [TestMethod]
        public void TestUmocneni()
        {
            //Testy rovnosti
            Assert.AreEqual(0, new KupeckePokty().Umocneni(0, 1));
            Assert.AreEqual(2, new KupeckePokty().Umocneni(2, 1));
            Assert.AreEqual(1 / 2, new KupeckePokty().Umocneni(2, -1), presnostPoctu);
            Assert.AreEqual(4, new KupeckePokty().Umocneni(2, 2));
            Assert.AreEqual(1 / 4, new KupeckePokty().Umocneni(2, -2), presnostPoctu);
            Assert.AreEqual(-27, new KupeckePokty().Umocneni(-3, 3));
            Assert.AreEqual(-1 / 27, new KupeckePokty().Umocneni(-3, -3), presnostPoctu);
            Assert.AreEqual(1 / 81, new KupeckePokty().Umocneni(-3, 4), presnostPoctu);
            Assert.AreEqual(2, new KupeckePokty().Umocneni(8, 1 / 3), presnostPoctu);
            Assert.AreEqual(1 / 2, new KupeckePokty().Umocneni(8, -1 / 3), presnostPoctu);
            Assert.AreEqual(-2, new KupeckePokty().Umocneni(-8, 1 / 3), presnostPoctu);
            Assert.AreEqual(-1 / 2, new KupeckePokty().Umocneni(-8, -1 / 3), presnostPoctu);

            //Neplatne formaty
            Assert.ThrowsException<ArgumentException>(() => new KupeckePokty().Umocneni(0, 0));
            Assert.ThrowsException<ArgumentException>(() => new KupeckePokty().Umocneni(0, -1));
            Assert.ThrowsException<ArgumentException>(() => new KupeckePokty().Umocneni(-8, -1 / 4));
            Assert.ThrowsException<ArgumentException>(() => new KupeckePokty().Umocneni(-254, 3 / 8));
        }

        [TestMethod]
        public void TestOdmocneni()
        {
            //Testy rovnosti
            Assert.AreEqual(0, new KupeckePokty().Odmocneni(0, 2));
            Assert.AreEqual(2, new KupeckePokty().Odmocneni(2, 1));
            Assert.AreEqual(1 / 2, new KupeckePokty().Odmocneni(2, -1), presnostPoctu);
            Assert.AreEqual(2, new KupeckePokty().Odmocneni(4, 2));
            Assert.AreEqual(1 / 2, new KupeckePokty().Odmocneni(4, -2), presnostPoctu);
            Assert.AreEqual(-1 / 3, new KupeckePokty().Odmocneni(-27, -3), presnostPoctu);
            Assert.AreEqual(-3, new KupeckePokty().Odmocneni(-27, 3));
            Assert.AreEqual(-1 / 27, new KupeckePokty().Odmocneni(-3, -1 / 3), presnostPoctu);
            Assert.AreEqual(27, new KupeckePokty().Odmocneni(-3, 1 / 3), presnostPoctu);
            Assert.AreEqual(-1 / 27, new KupeckePokty().Odmocneni(-3, -1 / 3), presnostPoctu);
            Assert.AreEqual(-1 / 3, new KupeckePokty().Odmocneni(-1 / 27, 3), presnostPoctu);
            Assert.AreEqual(1 / 3, new KupeckePokty().Odmocneni(1 / 27, 3), presnostPoctu);

            //Neplatne formaty
            Assert.ThrowsException<ArgumentException>(() => new KupeckePokty().Odmocneni(0, 0));
            Assert.ThrowsException<ArgumentException>(() => new KupeckePokty().Odmocneni(0, -2));
            Assert.ThrowsException<ArgumentException>(() => new KupeckePokty().Odmocneni(-8, -2 / 3));
            Assert.ThrowsException<ArgumentException>(() => new KupeckePokty().Odmocneni(-12, 2 / 5));
        }

        [TestMethod]
        public void TestAbsHodnoty()
        {
            //Testy Rovnosti
            Assert.AreEqual(0, new KupeckePokty().AbsHodnota(0));
            Assert.AreEqual(5, new KupeckePokty().AbsHodnota(5));
            Assert.AreEqual(5, new KupeckePokty().AbsHodnota(-5));
            Assert.AreEqual(120, new KupeckePokty().AbsHodnota(120));
            Assert.AreEqual(120, new KupeckePokty().AbsHodnota(-120));
            Assert.AreEqual(2.25, new KupeckePokty().AbsHodnota(2.25), presnostPoctu);
            Assert.AreEqual(2.25, new KupeckePokty().AbsHodnota(-2.25), presnostPoctu);

            //Testy nerovnosti
            Assert.AreNotEqual(-5, new KupeckePokty().AbsHodnota(-5));
            Assert.AreNotEqual(-5, new KupeckePokty().AbsHodnota(5));
            Assert.AreNotEqual(-120, new KupeckePokty().AbsHodnota(-120));
            Assert.AreNotEqual(-2.25, new KupeckePokty().AbsHodnota(-2.25), presnostPoctu);
        }
    }
}
