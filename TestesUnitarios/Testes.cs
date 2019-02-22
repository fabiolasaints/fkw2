using System;
using System.Linq;
using Aula02.Class;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestesUnitarios
{
    [TestClass]
    public class Testes
    {
        [TestMethod]
        public void TestMethod1()
        {
            Poker poker = new Poker();
            var mao1 = "74685";
            string esperado = "45678";
            string teste = poker.Straight(mao1, "");
            Assert.AreEqual(esperado, teste);
        }
    }
}
