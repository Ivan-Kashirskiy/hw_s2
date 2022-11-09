using static Exceptions.FileNotFound;

namespace ExceptionsTests
{
    [TestClass]
    public class FileNotFoundTests
    {
        [TestMethod]
        public void test1()
        {
            Assert.AreEqual(getFileSizeFixed("test1.txt"), 1);
        }

        [TestMethod]
        public void test2()
        {
            Assert.AreEqual(getFileSizeFixed("test2.txt"), 5);
        }

        [TestMethod]
        public void test3()
        {
            Assert.AreEqual(getFileSizeFixed("test3.txt"), default);
        }

        [TestMethod]
        public void test4()
        {
            Assert.AreEqual(getFileSizeFixed("test4.txt"), default);
        }


    }
}