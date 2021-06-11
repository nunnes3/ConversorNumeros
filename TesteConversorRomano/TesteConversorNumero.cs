using ConsoleApp1.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TesteConversorRomano
{
    [TestClass]
    public class TesteConversorNumero
    {
        [TestMethod]
        public void RetornaI()
        {

            Assert.AreEqual("I", new ConversorNumeros().RetornaNumeroRomano(1));
        }
        [TestMethod]
        public void RetornaIV()
        {
            Assert.AreEqual("IV", new ConversorNumeros().RetornaNumeroRomano(4));
        }

        [TestMethod]
        public void RetornaIX()
        {
            Assert.AreEqual("IX", new ConversorNumeros().RetornaNumeroRomano(9));
        }

        [TestMethod]
        public void RetornaXXIII()
        {

            Assert.AreEqual("XXIII", new ConversorNumeros().RetornaNumeroRomano(23));
        }
        [TestMethod]
        public void RetornaCXL()
        {

            Assert.AreEqual("CXL", new ConversorNumeros().RetornaNumeroRomano(140));
        }
        [TestMethod]
        public void RetornaMCXL()
        {

            Assert.AreEqual("MCXL", new ConversorNumeros().RetornaNumeroRomano(1140));
        }
        [TestMethod]
        public void RetornaXCXL()
        {

            Assert.AreEqual("X̄CXL", new ConversorNumeros().RetornaNumeroRomano(10140));
        }

    }
}
