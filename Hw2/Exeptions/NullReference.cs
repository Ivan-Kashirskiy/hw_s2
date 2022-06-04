using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    internal class NullReference
    { 
        public static void DoNullReference()
        {
            int[] nl = null;
            int i = nl.Length;
        }


        public static void DoNullReferenceFixed()
        {
            try
            {
                int[] nl = null;
                int i = nl.Length;
            }
            catch (System.NullReferenceException e)
            {
                Console.WriteLine(e);
            }

        }

    }



    
}
