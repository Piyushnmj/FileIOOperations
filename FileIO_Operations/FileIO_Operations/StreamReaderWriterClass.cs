using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIO_Operations
{
    public class StreamReaderWriterClass
    {
        public void StreamWriterOperation()
        {
            Console.WriteLine("**********Stream Writer**********");
            string filePath = @"F:\Bridgelabz Codin\FileIOOperations\FileIO_Operations\FileIO_Operations\WordFile1.txt";
            using (StreamWriter sw = File.AppendText(filePath))
            {
                sw.WriteLine("Hello I am writing this using Stream Writer Operation");
                sw.Close();
                Console.WriteLine(File.ReadAllText(filePath));
            }
        }
    }
}
