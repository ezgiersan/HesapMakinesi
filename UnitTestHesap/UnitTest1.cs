using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using HesapMakinesi;

namespace UnitTestHesap
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestToplama()
        {
            Islemci hesap_makinesi = new Islemci();
            double result =hesap_makinesi.toplama(10, 20);
            Assert.AreEqual(result, 30);
        }
        [TestMethod]
        public void TestCikarma()
        {
            Islemci hesap_makinesi = new Islemci();
            double result = hesap_makinesi.cikarma(10, 20);
            Assert.AreEqual(result, -10);
        }
        [TestMethod]
        public void TestCarpma()
        {
            Islemci hesap_makinesi = new Islemci();
            double result = hesap_makinesi.carpma(10, 20);
            Assert.AreEqual(result, 200);
        }
        [TestMethod]
        public void TestSifiraBölme()
        {
            Islemci hesap_makinesi = new Islemci();
            double birincisayi = 10;
            double ikincisayi = 0;
            try {
                
                double result = hesap_makinesi.bölme(birincisayi, ikincisayi);

                Assert.Fail();
            }
            catch (DivideByZeroException)
            {

            }
            
        }
        [TestMethod]
        public void TestBölme()
        {
            Islemci hesap_makinesi = new Islemci();
            double result = hesap_makinesi.bölme(10, 20);
            Assert.AreEqual(result, 0.5);
        }

    }
}
