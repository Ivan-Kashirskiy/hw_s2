using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Exceptions
{
    static class Overflow
    {
        public static void DoOverflow()
        {
            checked
            {
                int c = 1; ;
                for (int i = 0; i < 100000000; i++)
                    c = c * 1000000001;
            }
        }

        public static void DoOverflowFixed()
        {
            try
            {
                checked
                {
                    int c = 1;
                    for (int i = 0; i < 100000; i++)
                        c *= 1000000;
                }
            }
            catch (System.OverflowException e)
            {
                Console.WriteLine(e);
            }
        }
    }
}