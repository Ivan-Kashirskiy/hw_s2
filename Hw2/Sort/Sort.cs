using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ConsoleApp3.Program;

namespace USort
{
    public class Sort
    {
        public enum sortType { buble, insertion };
        public delegate bool comp<T>(T first, T second);

        public static void sort<T>(T[] arr, comp<T> my_comp, sortType type)
        {
            if (type == sortType.buble)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    for (int j = i + 1; j < arr.Length; j++)
                        if (!my_comp(arr[j], arr[i]))
                        {
                            var temp = arr[j];
                            arr[j] = arr[i];
                            arr[i] = temp;
                        }
                }
            }


            if (type == sortType.insertion)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    int j = i;
                    while (j > 0 && (my_comp(arr[j - 1], arr[j])))
                    {
                        var temp = arr[j - 1];
                        arr[j - 1] = arr[j];
                        arr[j] = temp;

                        j--;
                    }
                }
            }

        }
    }
}
