using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Streams_Problems.FileStreamDemo
{
    public class FileReadWrite
    {
        /*
        File Handling - Read and Write a Text File
📌 Problem Statement: Write a C# program that reads the contents of a
text file and writes it into a new file. If the source file does not exist,
display an appropriate message.
Requirements: Use FileStream for reading and writing. Handle
IOException properly. Ensure that the destination file is created if it does
not exist
        */
        public static void Execute()
        {
            string sourceFile = @"FileStreamDemo/source.txt";
            string destinationFile = @"FileStreamDemo/destination.txt";

            try
            {
                if (!File.Exists(sourceFile))
                {
                    System.Console.WriteLine("Source file does not exist.");
                    return;
                }
                using (FileStream fsRead = new FileStream(sourceFile, FileMode.Open, FileAccess.Read))
                using (FileStream fsWrite = new FileStream(destinationFile, FileMode.Create, FileAccess.Write))
                {
                    int byteData;
                    while ((byteData = fsRead.ReadByte()) != -1)
                    {
                        fsWrite.WriteByte((byte)byteData);
                    }
                    System.Console.WriteLine("File copied.");
                }
            }
            catch (IOException ex)
            {
                System.Console.WriteLine(ex.Message);
            }
        }
    }
}