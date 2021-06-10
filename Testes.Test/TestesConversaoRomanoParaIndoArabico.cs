using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using NumerosRomanos.ConsoleApp;

namespace Testes.Test
{
    [TestClass]
    public class TestesConversaoRomanoParaIndoArabico
    {

        ConversaoRomanoParaIndoArabico converte = new ConversaoRomanoParaIndoArabico();

        [TestMethod]
        public void DeveRetornar_1()
        {
            Assert.AreEqual(1,converte.Converter("I"));
        }

        [TestMethod]
        public void DeveRetornar_5()
        {
            Assert.AreEqual(5, converte.Converter("V"));
        }

        [TestMethod]
        public void DeveRetornar_10()
        {
            Assert.AreEqual(10, converte.Converter("X"));
        }

        [TestMethod]
        public void DeveRetornar_50()
        {
            Assert.AreEqual(50, converte.Converter("L"));
        }

        [TestMethod]
        public void DeveRetornar_100()
        {
            Assert.AreEqual(100, converte.Converter("C"));
        }

        [TestMethod]
        public void DeveRetornar_944()
        {
            Assert.AreEqual(944, converte.Converter("CMXLIV"));
        }
        [TestMethod]
        public void DeveRetornar_2001()
        {
            Assert.AreEqual(2001, converte.Converter("MMI"));
        }

        [TestMethod]
        public void DeveRetornar_91()
        {
            Assert.AreEqual(91, converte.Converter("XCI"));
        }

        [TestMethod]
        public void DeveRetornar_500()
        {
            Assert.AreEqual(500, converte.Converter("D"));
        }

        [TestMethod]
        public void DeveRetornar_1000()
        {
            Assert.AreEqual(1000, converte.Converter("M"));
        }

        [TestMethod]
        public void DeveRetornar_4000()
        {
            Assert.AreEqual(4000, converte.Converter("ĪV̄"));
        }

        [TestMethod]
        public void DeveRetornar_5000()
        {
            Assert.AreEqual(5000, converte.Converter("V̄"));
        }

        [TestMethod]
        public void DeveRetornar_6000()
        {
            Assert.AreEqual(6000, converte.Converter("V̄Ī"));
        }

        [TestMethod]
        public void DeveRetornar_7000()
        {
            Assert.AreEqual(7000, converte.Converter("V̄ĪĪ"));
        }

        [TestMethod]
        public void DeveRetornar_8000()
        {
            Assert.AreEqual(8000, converte.Converter("V̄ĪĪĪ"));
        }

        [TestMethod]
        public void DeveRetornar_9000()
        {
            Assert.AreEqual(9000, converte.Converter("ĪX̄"));
        }

        [TestMethod]
        public void DeveRetornar_10000()
        {
            Assert.AreEqual(10000, converte.Converter("X̄"));
        }

        [TestMethod]
        public void DeveRetornar_11984()
        {
            Assert.AreEqual(11984, converte.Converter("MMMMMMMMMMMCMLXXXIV"));
        }

        [TestMethod]
        public void DeveRetornar_878()
        {
            Assert.AreEqual(878, converte.Converter("DCCCLXXVIII"));
        }
    }
}
