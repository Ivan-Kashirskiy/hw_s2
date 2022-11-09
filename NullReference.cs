using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    public class NullReference
    { 
        public static int getArrLength(int[] arr)
        {           
            return arr.Length;
        }


        public static int getArrLengthFixed(int[] arr)
        {
            try
            {
                return arr.Length;   
            }
            catch (System.NullReferenceException e)
            {
                Console.WriteLine(e);
                return default;
            }

        }

    }



    
}
