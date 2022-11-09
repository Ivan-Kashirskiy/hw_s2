using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    public static class FileNotFound
    {
        public static int getFileSize(string path)
        {
            int length = (int)new System.IO.FileInfo(path).Length;
            return length;
        }

        public static int getFileSizeFixed(string path)
        {
            try
            {
                int length = (int)new System.IO.FileInfo(path).Length;
                return length;
            }
            catch (System.IO.FileNotFoundException e)
            {
                Console.WriteLine(e);
                return default;
            }
        }
    }
}