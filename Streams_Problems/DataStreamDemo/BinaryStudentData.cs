using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Streams_Problems.DataStreamDemo
{
    public class BinaryStudentData
    {
        /*
        7. Data Streams - Store and Retrieve Primitive Data
📌 Problem Statement: Write a C# program that stores student details
(roll number, name, GPA) in a binary file and retrieves it later.
Requirements: Use BinaryWriter to write primitive data. Use
BinaryReader to read data. Ensure proper closing of resources.
        */
        public static void Execute()
        {
            string filePath = @"DataStreamDemo/student.dat";
            try
            {
                // Write data
                using (BinaryWriter writer = new BinaryWriter(File.Open(filePath, FileMode.Create)))
                {
                    writer.Write(101);
                    writer.Write("Prashant");
                    writer.Write(8.7);
                }

                // Read data
                using (BinaryReader reader = new BinaryReader(File.Open(filePath, FileMode.Open)))
                {
                    int roll = reader.ReadInt32();
                    string name = reader.ReadString();
                    double gpa = reader.ReadDouble();

                    Console.WriteLine("Student Details:");
                    Console.WriteLine($"Roll: {roll}, Name: {name}, GPA: {gpa}");
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine("File error: " + ex.Message);
            }
        }
    }
}