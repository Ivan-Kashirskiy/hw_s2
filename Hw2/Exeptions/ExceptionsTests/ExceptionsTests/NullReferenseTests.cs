using static Exceptions.NullReference;

namespace ExceptionsTests
{
    [TestClass]
    public class NullReferenceTests
    {
        [TestMethod]
        public void test1()
        {
            int[] arr = {1};
            Assert.AreEqual(getArrLengthFixed(arr), 1);
        }

        [TestMethod]
        public void test2()
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            Assert.AreEqual(getArrLengthFixed(arr), 5);
        }

        [TestMethod]
        public void test3()
        {
            int[] arr = {};
            Assert.AreEqual(getArrLengthFixed(arr), 0);
        }

        [TestMethod]
        public void test4()
        {
            int[] arr = null;
            Assert.AreEqual(getArrLengthFixed(arr), default);
        }


    }
}