using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    static class IOException
    {
        public static void DoIOException()
        {
            char[] letters = new char[1000];
            for (int i = 0; i < letters.Length; i++)
                letters[i] = '0';

            string path = new string(letters); ;
            using (FileStream fs = File.Open(path, FileMode.Open, FileAccess.Write, FileShare.None)) ;

        }

        public static void DoIOExceptionFixed()
        {
            try
            {
                char[] letters = new char[1000];
                for (int i = 0; i < letters.Length; i++)
                    letters[i] = '0';

                string path = new string(letters); ;
                using (FileStream fs = File.Open(path, FileMode.Open, FileAccess.Write, FileShare.None)) ;
            }
            catch (System.IO.IOException e)
            {
                Console.WriteLine(e);
            }
        }
    }
}