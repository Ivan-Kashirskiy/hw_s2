using USort;

namespace SortTests
{
    [TestClass]
    public class sortTests
    {
        [TestMethod]
        public void InsertionSortTest1()
        {
            int[] arr = new int[] { 4, 3, 2, 1 };
            int[] temp = new int[] { 1, 2, 3, 4 };

            bool int_comp(int first, int second)
            {
                return (first > second);
            }

            Sort.sort(arr, int_comp, Sort.sortType.insertion);

            for (int i = 0; i < temp.Count(); i++)
            {
                Assert.AreEqual(temp[i], arr[i]);
            }
        }

        [TestMethod]
        public void InsertionSortTest2()
        {
            int[] arr = new int[] { 15, 46, 84, 12, 100 };
            int[] temp = new int[] { 12, 15, 46, 84, 100 };

            bool int_comp(int first, int second)
            {
                return (first > second);
            }

            Sort.sort(arr, int_comp, Sort.sortType.insertion);

            for (int i = 0; i < temp.Count(); i++)
            {
                Assert.AreEqual(temp[i], arr[i]);
            }
        }

        [TestMethod]
        public void InsertionSortTest3()
        {
            string[] arr = new string[] { "hnj", "eir", "gmi", "btg", "wkr" };
            string[] temp = new string[] { "btg", "eir", "gmi", "hnj", "wkr" };

            bool byFirstLetter_comp(string first, string second)
            {
                return (first[0] > second[0]);
            }

            Sort.sort(arr, byFirstLetter_comp, Sort.sortType.insertion);

            for (int i = 0; i < temp.Count(); i++)
            {
                Assert.AreEqual(temp[i], arr[i]);
            }
        }

        [TestMethod]
        public void InsertionSortTest4()
        {
            string[] arr = new string[] { "hnjwery", "eirt", "gm", "btw", "w" };
            string[] temp = new string[] { "w", "gm", "btw", "eirt", "hnjwery" };

            bool bySize_comp(string first, string second)
            {
                return (first.Count() > second.Count());
            }

            Sort.sort(arr, bySize_comp, Sort.sortType.insertion);

            for (int i = 0; i < temp.Count(); i++)
            {
                Assert.AreEqual(temp[i], arr[i]);
            }

        }


        [TestMethod]
        public void BubbleSortTest1()
        {
            int[] arr = new int[] { 4, 3, 2, 1 };
            int[] temp = new int[] { 1, 2, 3, 4 };

            bool int_comp(int first, int second)
            {
                return (first > second);
            }

            Sort.sort(arr, int_comp, Sort.sortType.buble);

            for (int i = 0; i < temp.Count(); i++)
            {
                Assert.AreEqual(temp[i], arr[i]);
            }
        }

        [TestMethod]
        public void BubbleSortTest2()
        {
            int[] arr = new int[] { 15, 46, 84, 12, 100 };
            int[] temp = new int[] { 12, 15, 46, 84, 100 };

            bool int_comp(int first, int second)
            {
                return (first > second);
            }

            Sort.sort(arr, int_comp, Sort.sortType.buble);

            for (int i = 0; i < temp.Count(); i++)
            {
                Assert.AreEqual(temp[i], arr[i]);
            }
        }

        [TestMethod]
        public void BubbleSortTest3()
        {
            string[] arr = new string[] { "hnj", "eir", "gmi", "btg", "wkr" };
            string[] temp = new string[] { "btg", "eir", "gmi", "hnj", "wkr" };

            bool byFirstLetter_comp(string first, string second)
            {
                return (first[0] > second[0]);
            }

            Sort.sort(arr, byFirstLetter_comp, Sort.sortType.buble);

            for (int i = 0; i < temp.Count(); i++)
            {
                Assert.AreEqual(temp[i], arr[i]);
            }
        }

        [TestMethod]
        public void BubbleSortTest4()
        {
            string[] arr = new string[] { "hnjwery", "eirt", "gm", "btw", "w" };
            string[] temp = new string[] { "w", "gm", "btw", "eirt", "hnjwery" };

            bool bySize_comp(string first, string second)
            {
                return (first.Count() > second.Count());
            }

            Sort.sort(arr, bySize_comp, Sort.sortType.buble);

            for (int i = 0; i < temp.Count(); i++)
            {
                Assert.AreEqual(temp[i], arr[i]);
            }

        }

    }
}