using NUnit.Framework;
using ExtensionMethods.Source;

namespace ExtensionMethods.Test
{
    public class Tests
    {
        Program p;

        [SetUp]
        public void Setup()
        {
            p = new Program();
        }

        [TestCase("hallo", "welt", "hallo welt")]
        [TestCase("Tom sagt", "hallo", "Tom sagt hallo")]
        [TestCase("hallo", "sagt Tom", "sagt Tom hallo")]
        public void Test1(string val1, string val2, string expected)
        {
            string result = p.Write(val1, val2);
            Assert.AreEqual(expected, result);
        }
    }
}