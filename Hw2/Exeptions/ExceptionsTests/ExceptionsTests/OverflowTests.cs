using static Exceptions.Overflow;

namespace ExceptionsTests
{
    [TestClass]
    public class OverflowTests
    {
        [TestMethod]
        public void test1()
        {
            Assert.AreEqual(powFixed(1, 1), 1);
        }

        [TestMethod]
        public void test2()
        {
            Assert.AreEqual(powFixed(2, 4), 16);
        }

        [TestMethod]
        public void test3()
        {
            Assert.AreEqual(powFixed(10000, 1000000), default);
        }

        [TestMethod]
        public void test4()
        {
            Assert.AreEqual(powFixed(2, 100000000), default);
        }


    }
}