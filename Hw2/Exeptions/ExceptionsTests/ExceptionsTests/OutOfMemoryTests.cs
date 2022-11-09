using static Exceptions.OutOfMemory;

namespace ExceptionsTests
{
    [TestClass]
    public class OutOfMemoryTests
    {
        [TestMethod]
        public void test1()
        {
            Assert.AreEqual(makeArrayFixed(1, 1).Length, 1);
        }

        [TestMethod]
        public void test2()
        {         
            Assert.AreEqual(makeArrayFixed(5, 5).Length, 5);
        }

        [TestMethod]
        public void test3()
        {         
            Assert.AreEqual(makeArrayFixed(5000000, 500000), default);
        }

        [TestMethod]
        public void test4()
        {          
            Assert.AreEqual(makeArrayFixed(10, 1000000000), default);
        }


    }
}