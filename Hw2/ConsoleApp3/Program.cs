using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        public class Point
        {
            public int x;
            public int y;

            public Point(int newX, int newY)
            {
                x = newX;
                y = newY;
            }

            public void print()
            {
                Console.WriteLine(x + " " + y);
            }
        }

        public enum sortType {buble, insertion }; 
        public delegate bool comp<T>(T first, T second);

        public static bool int_comp(int first, int second)
        {
            return (first > second);
        }

        public static bool point_comp(Point first, Point second)
        {
            return (first.x > second.x);
        }

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
        

        static void Main(string[] args)
        {
            int[] array1 = new int[]{5, 2, 6, 1, 2, 9, 6 };         
            Point[] array2 = new Point[]{ new Point(7, 3), new Point(2, 4), new Point(4, 1), new Point(3, 7) };       

            sort(array1, int_comp, sortType.buble);
            sort(array2, point_comp, sortType.insertion);

            for (int i = 0; i < array1.Length; i++)
                Console.WriteLine(array1[i]);

            for (int i = 0; i < array2.Length; i++)
                array2[i].print();


             int c = Console.Read();
        }
    
    
    }
}
