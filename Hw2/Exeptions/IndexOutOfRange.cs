using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    static class IndexOutOfRange
    {
        public static void DoIndexOutOfRange()
        {
            int[] arr = new int[] { 1, 2 };
            int c = arr[2];
        }

        public static void DoIndexOutOfRangeFixed()
        {
            try
            {
                int[] arr = new int[] { 1, 2 };
                int c = arr[2];
            }
            catch (System.IndexOutOfRangeException e)
            {

                Console.WriteLine(e);               
            }
        }




    }
}