using System;
using NUnit.Framework;
using TestEnvironment;

namespace TestEnvironment.Tests
{
    [TestFixture]
    public class MyMathsTesting
    {
        MyMaths mm;

        [SetUp]
        public void SetUp()
        {
            mm = new MyMaths();
        }

        [TestCase(3,5, 8)]
        [TestCase(8,2, 10)]
        [TestCase(10,10, 20)]
        [TestCase(9,2,15)]
        public void TestAddition(int value1, int value2, int expected)
        {
            int result = mm.Add(value1, value2);
            Assert.AreEqual(expected, result);
        }

        [TestCase(10,4,6)]
        [TestCase(0, 9,-9)]
        [TestCase(100,100,0)]
        [TestCase(0,2,-5)]
        public void TestSubtraction(int value1, int value2, int expected)
        {
            int result = mm.Subtract(value1, value2);
            Assert.AreEqual(expected, result);
        }

        [TestCase(2,2,4)]
        [TestCase(5,5,25)]
        [TestCase(100,100,10000)]
        [TestCase(100,2,300)]
        public void TestMultiplication(int value1, int value2, int expected)
        {
            int result = mm.Multiply(value1, value2);
            Assert.AreEqual(expected, result);
        }

        /*[TestCase(2,1,2)]
        [TestCase(6,2,3)]
        [TestCase(100,2,50)]
        public void TestDivision(int value1, int value2, double expected)
        {
            int result = mm.Divide(value1, value2);
            Assert.AreEqual(expected, result);
        }*/
    }
}