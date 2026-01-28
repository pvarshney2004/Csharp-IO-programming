using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Streams_Problems.ConvertCase
{
    public class UpperToLower
    {
        /*
        Filter Streams - Convert Uppercase to Lowercase
📌 Problem Statement: Create a program that reads a text file and
writes its contents into another file, converting all uppercase letters to
lowercase.
Requirements: Use StreamReader and StreamWriter. Use
BufferedStream for efficiency. Handle character encoding issues.
        */
        public static void Execute()
        {
            string filepath = @"ConvertCase/sample.txt";
            string outputPath = @"ConvertCase/output.txt";
            try
            {
                using (BufferedStream bufferedRead =
                       new BufferedStream(new FileStream(filepath, FileMode.Open)))
                using (BufferedStream bufferedWrite =
                       new BufferedStream(new FileStream(outputPath, FileMode.Create)))
                using (StreamReader reader = new StreamReader(bufferedRead, Encoding.UTF8))
                using (StreamWriter writer = new StreamWriter(bufferedWrite, Encoding.UTF8))
                {
                    string text;
                    while ((text = reader.ReadLine()) != null)
                    {
                        writer.WriteLine(text.ToLower());
                    }
                }
                Console.WriteLine("File converted to lowercase successfully.");
            }
            catch (IOException ex)
            {
                Console.WriteLine("File error: " + ex.Message);
            }
        }
    }
}