using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApplication;

namespace UnitTestProjectAplicacion
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestPrimeraCancion()
        {
            primeraCancion cancion1 = new primeraCancion();
            string esperado = "fiu cric-cric brrah ";
            var actual = cancion1.escuchar();
            Assert.AreEqual(esperado, actual);
        }

        [TestMethod]
        public void TestSegundaCancion()
        {
            segundaCancion cancion1 = new segundaCancion();
            string esperado = "trri-trri croac ";
            var actual = cancion1.escuchar();
            Assert.AreEqual(esperado, actual);
        }

        [TestMethod]
        public void TestTerceraCancion()
        {
            terceraCancion cancion1 = new terceraCancion();
            string esperado = "cric-cric brrah ";
            var actual = cancion1.escuchar();
            Assert.AreEqual(esperado, actual);
        }
    }
}
