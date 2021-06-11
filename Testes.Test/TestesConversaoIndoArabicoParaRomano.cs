using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using NumerosRomanos.ConsoleApp;

namespace Testes.Test
{
    [TestClass]
    public class TestesConversaoIndoArabicoParaRomano
    {
        ConversaoIndoArabicoParaRomano converte = new ConversaoIndoArabicoParaRomano();

        [TestMethod]
        public void DeveRetornar_1()
        {
            Assert.AreEqual("I", converte.Converter(1));
        }

        [TestMethod]
        public void DeveRetornar_5()
        {
            Assert.AreEqual("V", converte.Converter(5));
        }

        [TestMethod]
        public void DeveRetornar_10()
        {
            Assert.AreEqual("X", converte.Converter(10));
        }

        [TestMethod]
        public void DeveRetornar_50()
        {
            Assert.AreEqual("L", converte.Converter(50));
        }

        [TestMethod]
        public void DeveRetornar_100()
        {
            Assert.AreEqual("C", converte.Converter(100));
        }

        [TestMethod]
        public void DeveRetornar_944()
        {
            Assert.AreEqual("CMXLIV", converte.Converter(944));
        }
        [TestMethod]
        public void DeveRetornar_2001()
        {
            Assert.AreEqual("MMI", converte.Converter(2001));
        }

        [TestMethod]
        public void DeveRetornar_91()
        {
            Assert.AreEqual("XCI", converte.Converter(91));
        }

        [TestMethod]
        public void DeveRetornar_500()
        {
            Assert.AreEqual("D", converte.Converter(500));
        }

        [TestMethod]
        public void DeveRetornar_1000()
        {
            Assert.AreEqual("M", converte.Converter(1000));
        }

        [TestMethod]
        public void DeveRetornar_4000()
        {
            Assert.AreEqual("ĪV̄", converte.Converter(4000));
        }

        [TestMethod]
        public void DeveRetornar_5000()
        {
            Assert.AreEqual("V̄", converte.Converter(5000));
        }

        [TestMethod]
        public void DeveRetornar_6000()
        {
            Assert.AreEqual("V̄Ī", converte.Converter(6000));
        }

        [TestMethod]
        public void DeveRetornar_4346()
        {
            Assert.AreEqual("ĪV̄CCCXLVI", converte.Converter(4346));
        }

        [TestMethod]
        public void DeveRetornar_7000()
        {
            Assert.AreEqual("V̄ĪĪ", converte.Converter(7000));
        }

        [TestMethod]
        public void DeveRetornar_8000()
        {
            Assert.AreEqual("V̄ĪĪĪ", converte.Converter(8000));
        }

        [TestMethod]
        public void DeveRetornar_9000()
        {
            Assert.AreEqual("ĪX̄", converte.Converter(9000));
        }

        [TestMethod]
        public void DeveRetornar_10000()
        {
            Assert.AreEqual("X̄", converte.Converter(10000));
        }

        [TestMethod]
        public void DeveRetornar_11984()
        {
            Assert.AreEqual("X̄MCMLXXXIV", converte.Converter(11984));
        }

        [TestMethod]
        public void DeveRetornar_878()
        {
            Assert.AreEqual("DCCCLXXVIII", converte.Converter(878));
        }
    }
}
