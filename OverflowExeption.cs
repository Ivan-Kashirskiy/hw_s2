using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Exceptions
{
    public static class Overflow
    {
        public static int pow(int a, int b)
        {
            checked
            {
                int c = 1; ;
                for (int i = 0; i < b; i++)
                    c = c * a;
                return c;
            }
        }

        public static int powFixed(int a, int b)
        {
            try
            {
                checked
                {
                    int c = 1; ;
                    for (int i = 0; i < b; i++)
                        c = c * a;
                    return c;
                }
            }
            catch (System.OverflowException e)
            {
                Console.WriteLine(e);
                return default;
            }
        }
    }
}