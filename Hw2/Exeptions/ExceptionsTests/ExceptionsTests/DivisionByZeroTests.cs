using static Exceptions.DivisionByZero;

namespace ExceptionsTests
{
    [TestClass]
    public class DivisionByZeroTests
    {
        [TestMethod]
        public void test1()
        {
            Assert.AreEqual(divideFixed(4, 2), 2);
        }

        [TestMethod]
        public void test2()
        {
            Assert.AreEqual(divideFixed(10000, 10000), 1);
        }

        [TestMethod]
        public void test3()
        {
            Assert.AreEqual(divideFixed(10000, 0), default);
        }

        [TestMethod]
        public void test4()
        {
            Assert.AreEqual(divideFixed(0, 0), default);
        }


    }
}