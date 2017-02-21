using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Kasse;
using System.Collections.Generic;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Kerekit_TestMethod()
        {
            Termekek T = new Termekek();

            int bemenet = 54;
            double actual = T.kerekit(bemenet);
            double exented = 55;

            Assert.AreEqual(exented, actual);
        }
        [TestMethod]
        public void Osszead_TestMethod()
        {
            List<Termekek> lista = new List<Termekek>();
            Termekek T = new Termekek();

            string ár1 = "50";
            string ár2 = "20";
            string ár3 = "10";
            double exented = 80;
            double actual = T.Osszead(Lista(ár1, ár2, ár3));

            Assert.AreEqual(exented, actual);
        }
        public List<Termekek> Lista(string ár1, string ár2, string ár3)
        {
            List<Termekek> lista = new List<Termekek>();

            Termekek Á1 = new Termekek();
            Á1.Ár = ár1;
            lista.Add(Á1);

            Termekek Á2 = new Termekek();
            Á2.Ár = ár2;
            lista.Add(Á2);

            Termekek Á3 = new Termekek();
            Á3.Ár = ár3;
            lista.Add(Á3);

            return lista;
        }

        [TestMethod]
        public void Terkmékkereső_TestMethod()
        {
            string bemenet = "1111";

            Termekek T = new Termekek();
            T.Nev = "Próba";
            T.Ár = "1111";
            T.Áfa = "B";

            List<Termekek> exented = new List<Termekek>();
            exented.Add(T);

            List<Termekek> actual = new List<Termekek>();
            actual =T.Terkmékkereső(bemenet);

            Assert.AreEqual(exented[0].Nev.ToString(), actual[0].Nev.ToString());
            Assert.AreEqual(exented[0].Ár.ToString(), actual[0].Ár.ToString());
            Assert.AreEqual(exented[0].Áfa.ToString(), actual[0].Áfa.ToString());
        }
    }
}
