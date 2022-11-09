using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Exceptions
{
    public static class InvalidCast
    {
        public static char getFirstChar(object value)
        {                 
            return ((string)value)[0];
        }

        public static char getFirstCharFixed(object value)
        {
            try
            {
                return ((string)value)[0];
            }
            catch (System.InvalidCastException e)
            {
                Console.WriteLine(e);
                return default;
            }
        }

    }
}
