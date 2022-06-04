using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    static class FileNotFound
    {
        public static void DoFileNotFound()
        {      
            string path = "#$@"; 
            using (FileStream fs = File.Open(path, FileMode.Open, FileAccess.Write, FileShare.None));
        }

        public static void DoFileNotFoundFixed()
        {
            try
            {
                string path = "#$@";
                using (FileStream fs = File.Open(path, FileMode.Open, FileAccess.Write, FileShare.None)) ;
            }
            catch (System.IO.FileNotFoundException e)
            {
                Console.WriteLine(e);
            }
        }
    }
}