using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    public static class OutOfMemory
    {
        public static double[][] makeArray(int x, int y)
        {
            double[][] arr = new double[x][];
            for (int i = 0; i < arr.Length; i++)
                arr[i] = new double[y];

            return arr;
        }

        public static double[][] makeArrayFixed(int x, int y)
        {
            try
            {
                double[][] arr = new double[x][];
                for (int i = 0; i < arr.Length; i++)
                    arr[i] = new double[y];

                return arr;
            }
            catch (System.OutOfMemoryException e)
            {

                Console.WriteLine(e);
                return default;
            }
        }
    }
}