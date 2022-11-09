using static Exceptions.IOException;

namespace ExceptionsTests
{
    [TestClass]
    public class IOExceptionTests
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
            string str = "11111111";
            for (int i = 0; i < 100; i++)
                str = str + "1111111";

            str = str + ".txt";

            Assert.AreEqual(getFileSizeFixed(str), default);
        }

        [TestMethod]
        public void test4()
        {
            string str = ".";
            
            Assert.AreEqual(getFileSizeFixed(str), default);
        }


    }
}