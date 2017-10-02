using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    [TestFixture]

    public class Class1
    {
        
        public void TestAdd()
        {
            int result = Calculator.Add(3, 2);
            Assert.AreEqual(6, result);

            result = Calculator.Add(0, 2);
            Assert.AreEqual(2, result);

            result = Calculator.Add(12, -2);
            Assert.AreEqual(10, result);

            result = Calculator.Add(-3, -2);
            Assert.AreEqual(-5, result);

            result = Calculator.Add(0, 0);
            Assert.AreEqual(0, result);
        }
        [Test]
        public void TestSub()
        {
            int result = Calculator.Sub(3, 2);
            Assert.AreEqual(1, result);

            result = Calculator.Sub(0, 2);
            Assert.AreEqual(-2, result);

            result = Calculator.Sub(12, -2);
            Assert.AreEqual(14, result);

            result = Calculator.Sub(-3, -2);
            Assert.AreEqual(-1, result);

            result = Calculator.Sub(0, 0);
            Assert.AreEqual(0, result);
        }

        [Test]
        public void TestMult()
        {
            int result = Calculator.Mult(3, 2);
            Assert.AreEqual(6, result);

            result = Calculator.Mult(0, 2);
            Assert.AreEqual(0, result);

            result = Calculator.Mult(12, -2);
            Assert.AreEqual(-24, result);

            result = Calculator.Mult(-3, -2);
            Assert.AreEqual(6, result);

            result = Calculator.Mult(0, 0);
            Assert.AreEqual(0, result);
        }

        [Test]
        public void TestDivic()
        {
            int result = Calculator.Divic(3, 2);
            Assert.AreEqual(1, result);

            result = Calculator.Divic(0, 2);
            Assert.AreEqual(0, result);

            result = Calculator.Divic(12, -2);
            Assert.AreEqual(-6, result);

            result = Calculator.Divic(-3, -2);
            Assert.AreEqual(1.5, result);

            result = Calculator.Divic(0, 0);
            Assert.AreEqual(0, result);
        }
    }
}
