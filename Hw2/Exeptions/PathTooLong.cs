using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    static class PathTooLong
    { 

        public static void DoPathTooLong()
        {
            char[] letters = new char[1000000];
                for (int i = 0; i < letters.Length; i++)
                    letters[i] = 'a';

            string path = new string(letters); ;
            using (FileStream fs = File.Open(path, FileMode.Open, FileAccess.Write, FileShare.None));

        }

        public static void DoPathTooLongFixed()
        {
            try
            {
                char[] letters = new char[1000000];
                for (int i = 0; i < letters.Length; i++)
                    letters[i] = 'a';

                string path = new string(letters); ;
                using (FileStream fs = File.Open(path, FileMode.Open, FileAccess.Write, FileShare.None)) ;
            }
            catch (System.IO.PathTooLongException e)
            {
                Console.WriteLine(e);
            }
        }
    }
}