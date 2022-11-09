using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    public static class DivisionByZero
    {
        public static int divide(int a, int b)
        {
            return a / b;
        }

        public static int divideFixed(int a, int b)
        {
            try
            {
                return a / b;
            }
            catch (System.DivideByZeroException e)
            {
            
                Console.WriteLine(e);
                return default;
            }
        }      
    }
}
