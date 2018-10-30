using System;
using ConsoleApp1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace testJenkis
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Calcul calc = new Calcul();

            int result = calc.addition(1, 2);

            Assert.AreEqual(3, result);
        }
    }
}
