using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Streams_Problems.StreamReaderDemo
{
    public class UserInputToFile
    {
        /*
        Read User Input from Console
📌 Problem Statement: Write a program that asks the user for their
name, age, and favorite programming language, then saves this
information into a file.
Requirements: Use StreamReader for console input. Use StreamWriter
to write the data into a file. Handle exceptions properly.
        */

        public static void Execute()
        {
            string filePath = @"StreamreaderDemo/user_details.txt";
            try
            {
                using (StreamReader reader = new StreamReader(Console.OpenStandardInput()))
                {
                    System.Console.WriteLine("Enter your name: ");
                    string name = Console.ReadLine();

                    System.Console.WriteLine("Enter your age: ");
                    int age = Convert.ToInt32(Console.ReadLine());

                    System.Console.WriteLine("Enter your favourite programming language: ");
                    string language = Console.ReadLine();

                    using (StreamWriter writer = new StreamWriter(filePath))
                    {
                        writer.WriteLine("User Details: ");
                        writer.WriteLine($"Name: {name}");
                        writer.WriteLine($"Age: {age}");
                        writer.WriteLine($"Favorite Programming Language: {language}");
                    }
                }
                Console.WriteLine("\nData successfully saved to file.");
            }
            catch (IOException ex)
            {
                Console.WriteLine("File error occurred: " + ex.Message);
            }
        }
    }
}