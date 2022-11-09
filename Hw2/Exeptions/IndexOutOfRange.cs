using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    public static class IndexOutOfRange
    {
        public static int getIndex(int[] arr, int index)
        {    
            return arr[index];
        }

        public static int getIndexFixed(int[] arr, int index)
        {
            try
            {
                return arr[index];
            }
            catch (System.IndexOutOfRangeException e)
            {

                Console.WriteLine(e);
                return default;
            }
        }




    }
}