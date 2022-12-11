using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIO_Operations
{
    public class Operations
    {
        public void FileExists()
        {
            string filePath = @"F:\Bridgelabz Codin\FileIOOperations\FileIO_Operations\FileIO_Operations\WordFile1.txt";
            if (File.Exists(filePath))
            {
                Console.WriteLine("\nFile Exists");
            }
            else
            {
                Console.WriteLine("\nFile Not Found");
            }
            Console.ReadLine();
        }

    }
}
