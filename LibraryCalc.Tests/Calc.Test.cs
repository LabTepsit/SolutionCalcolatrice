using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LibraryCalc;

namespace LibraryCalc.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestSomma()
        {
            int a = 2;
            int b = 3;
            int somma=Calc.Somma(a, b);
            Assert.AreEqual(6,somma);

        }
    }
}
