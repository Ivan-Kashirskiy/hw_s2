using static Exceptions.InvalidCast;

namespace ExceptionsTests
{
    [TestClass]
    public class InvalidCastTests
    {
        [TestMethod]
        public void test1()
        {           
            Assert.AreEqual(getFirstCharFixed("a"), 'a');
        }

        [TestMethod]
        public void test2()
        {
            Assert.AreEqual(getFirstCharFixed("cba"), 'c');
        }

        [TestMethod]
        public void test3()
        {
            int[] arr = {0, 1, 2}; 
            Assert.AreEqual(getFirstCharFixed(arr), default);
        }

        [TestMethod]
        public void test4()
        {
            double d = 5;
            Assert.AreEqual(getFirstCharFixed(d), default);
        }


    }
}