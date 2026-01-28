using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using CsvHelper;

namespace CSV_Problems.ReadingCSVFile
{
    public class ReadFile
    {
        /*
Read a CSV File and Print Data
● Read a CSV file containing student details (ID, Name, Age, Marks).
● Print each record in a structured format.
        */

        // method to read CSV using CsvHelper library
        public static void UsingCsvReader()
        {
            string filePath = @"ReadingCSVFile\sample.csv";
            using (var reader = new StreamReader(filePath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var records = csv.GetRecords<Student>().ToList();
                foreach (var student in records)
                {
                    Console.WriteLine($"ID: {student.ID}, Name: {student.Name}, Age: {student.Age}, Marks: {student.Marks}");
                }
            }
        }
        // method to read CSV using StreamReader
        public static void UsingStreamReader()
        {
            string filePath = @"ReadingCSVFile\sample.csv";
            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] values = line.Split(',');
                        Console.WriteLine($"ID: {values[0]}, Name: {values[1]}, Age: {values[2]}, Marks: {values[3]}");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }
}