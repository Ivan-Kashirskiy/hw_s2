using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Exceptions
{
    static class InvalidCast
    {
        public static void DoInvalidCast()
        {
            object value = 12;         
            string s = (string)value;
        }

        public static void DoInvalidCastFixed()
        {
            try
            {
                object value = 12;
                string s = (string)value;
            }
            catch (System.InvalidCastException e)
            {
                Console.WriteLine(e);               
            }
        }

    }
}
