using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Credit_card;
using System.Collections.Generic;

namespace CreditcardTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Valodi_TestMethod()
        {
            Generate Gen = new Generate();
            string bemenet="1234567890123452";
            bool actual = Gen.Valódi(bemenet);
            bool exented = true;
            Assert.AreEqual(exented, actual);
        }
    }
}
