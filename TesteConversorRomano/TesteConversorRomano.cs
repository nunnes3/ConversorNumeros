using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Model;

namespace TesteConversorRomano
{
    [TestClass]
    public class TesteConversorRomano
    {

        [TestMethod]
        public void Retorna1()
        {
            Assert.AreEqual(1, new ConversorRomanos().Conversor("I"));
        }
        [TestMethod]
        public void Retorna4()
        {
            Assert.AreEqual(4, new ConversorRomanos().Conversor("IV"));
        }

        [TestMethod]
        public void Retorna9()
        {
            Assert.AreEqual(9, new ConversorRomanos().Conversor("IX"));
        }

        [TestMethod]
        public void Retorna23()
        {
            Assert.AreEqual(23, new ConversorRomanos().Conversor("XXIII"));
        }

        [TestMethod]
        public void Retorna40()
        {
            Assert.AreEqual(40, new ConversorRomanos().Conversor("XL"));
        }

        [TestMethod]
        public void Retorna140()
        {
            Assert.AreEqual(140, new ConversorRomanos().Conversor("CXL"));
        }

        [TestMethod]
        public void Retorna1140()
        {
            Assert.AreEqual(1140, new ConversorRomanos().Conversor("MCXL"));
        }

        [TestMethod]
        public void Retorna11140()
        {
            Assert.AreEqual(11140, new ConversorRomanos().Conversor("X̄ĪCXL"));
        }

    }
}
