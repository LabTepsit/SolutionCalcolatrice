using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LibraryCalc;

namespace LibraryCalc.Tests
{
    [TestClass]
    public class CalcTest
    {
        [TestMethod]
        public void TestSomma()
        {
            //si elenca cosa mi serve e cosa mi aspetto
            double num1 = 7;
            double num2 = 2;
            double ris = 9;

            //Invoco il metodo NomeClazze.NomeMetodo
            double somma= Calc.Somma(num1, num2);

            Assert.AreEqual(ris, somma);
        }


        //cambio alcuni valori di partenza
        [TestMethod]
        public void TestSommaPerZero()
        {
            //si elenca cosa mi serve e cosa mi aspetto
            double num1 = 0;
            double num2 = 1;
            double ris = 1;

            //Invoco il metodo NomeClazze.NomeMetodo
            double somma = Calc.Somma(num1, num2);

            Assert.AreEqual(ris, somma);
        }
    }
}
