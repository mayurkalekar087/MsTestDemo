using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MSTestDemo
{
    [TestClass]
    public class UnitTest1
    {
        private readonly sumOf2Number.Program program;
        public UnitTest1()
        {
            program = new sumOf2Number.Program();
        }

        [TestMethod]
        public void TestMethod1()
        {
            int valueOne = 5;
            int valueTwo = 10;
            var result = program.Add(valueOne, valueTwo);
            Assert.AreEqual(15, result);
        }
        [TestMethod]
        public void TestMethod2()
        {
            int valueOne = 5;
            int valueTwo = 5;
            var result = program.Add(valueOne, valueTwo);
            Assert.AreEqual(15, result);
        }
    }
}
