using static Exceptions.IndexOutOfRange;

namespace ExceptionsTests
{
    [TestClass]
    public class IndexOutOfRangeTests
    {
        [TestMethod]
        public void test1()
        {
            int[] arr = { 0, 1, 2, 3, 4, 5};
            Assert.AreEqual(getIndexFixed(arr, 2), 2);
        }

        [TestMethod]
        public void test2()
        {
            int[] arr = { 5, 4, 3, 2, 1, 0 };
            Assert.AreEqual(getIndexFixed(arr, 0), 5);
        }

        [TestMethod]
        public void test3()
        {
            int[] arr = { 5, 4, 3, 2, 1, 0 };
            Assert.AreEqual(getIndexFixed(arr, 10), default);
        }

        [TestMethod]
        public void test4()
        {
            int[] arr = { 5, 4, 3, 2, 1, 0 };
            Assert.AreEqual(getIndexFixed(arr, -1), default);
        }


    }
}