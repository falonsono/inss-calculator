using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using INSS;

namespace UnitTestINSS
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void JoaoSalary2011()
        {
            CalculadorInss calculator = new CalculadorInss(new AliquotService());
            decimal discount = calculator.CalcularDesconto(new DateTime(2011, 03, 17), 1000);

            Assert.AreEqual(discount, 80);
        }

        [TestMethod]
        public void JoaoSalary2012()
        {
            CalculadorInss calculator = new CalculadorInss(new AliquotService());
            decimal discount = calculator.CalcularDesconto(new DateTime(2012, 03, 17), 1000);

            Assert.AreEqual(discount, 70);
        }

        [TestMethod]
        public void MariaSalary2011()
        {
            CalculadorInss calculator = new CalculadorInss(new AliquotService());
            decimal discount = calculator.CalcularDesconto(new DateTime(2011, 03, 17), 4000);

            Assert.AreEqual(discount, 405.86m);
        }

        [TestMethod]
        public void MariaSalary2012()
        {
            CalculadorInss calculator = new CalculadorInss(new AliquotService());
            decimal discount = calculator.CalcularDesconto(new DateTime(2012, 03, 17), 4000);

            Assert.AreEqual(discount, 440);
        }

        [TestMethod]
        public void Test2012MaxValue()
        {
            CalculadorInss calculator = new CalculadorInss(new AliquotService());
            decimal discount = calculator.CalcularDesconto(new DateTime(2012, 03, 17), 4001);

            Assert.AreEqual(discount, 500);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception), "Table of the year 2020 not available!")]
        public void TestInexistentYearTable()
        {
            CalculadorInss calculator = new CalculadorInss(new AliquotService());
            calculator.CalcularDesconto(new DateTime(2020, 03, 17), 1000);

            Assert.Fail();
        }

        [TestMethod]
        public void TestZeroValue()
        {
            CalculadorInss calculator = new CalculadorInss(new AliquotService());
            decimal discount = calculator.CalcularDesconto(new DateTime(2012, 03, 17), 0);

            Assert.AreEqual(discount, 0);
        }
    }
}
