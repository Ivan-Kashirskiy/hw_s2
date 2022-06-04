using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    static class OutOfMemory
    {
        public static void DoOutOfMemory()
        {
            double[][] arr = new double[10000000][];
            for (int i = 0; i < arr.Length; i++)
                arr[i] = new double[1000000000];
        }

        public static void DoOutOfMemoryFixed()
        {
            try
            {
                double[][] arr = new double[10000000][];
                for (int i = 0; i < arr.Length; i++)
                    arr[i] = new double[100000000];
            }
            catch (System.OutOfMemoryException e)
            {

                Console.WriteLine(e);              
            }
        }
    }
}