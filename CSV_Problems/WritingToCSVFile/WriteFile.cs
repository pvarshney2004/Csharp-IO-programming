using System;
using System.IO;
using CsvHelper;
using System.Globalization;
using System.Collections.Generic;

namespace CSV_Problems.WritingToCSVFile
{
    public class WriteFile
    {
        /*
        Write Data to a CSV File
● Create a CSV file with employee details (ID, Name, Department, Salary).
● Write at least 5 records to the file.
        */

        // method to write CSV using StreamWriter
        public static void UsingStreamReader()
        {
            string filePath = @"WritingToCSVFile\output_streamreader.csv";
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    writer.WriteLine("ID,Name,Department,Salary");
                    writer.WriteLine("104,Alice Williams, Finance, 62000");
                    writer.WriteLine("105,Bob Johnson,Sales,58000");
                }
                Console.WriteLine("CSV file written successfully!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        // method to write CSV using CsvHelper
        public static void UsingCsvHelper()
        {
            using (var writer = new StreamWriter(@"WritingToCSVFile\output_csvhelper.csv"))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                var records = new List<Employee>
                {
                    new Employee { ID = 104, Name = "Alice Williams", Department = "Finance", Salary = 62000 },
                    new Employee { ID = 105, Name = "Bob Johnson", Department = "Sales", Salary = 58000 }
                };
                csv.WriteRecords(records);
            }
            Console.WriteLine("CSV file written successfully using CsvHelper!");
        }


    }
}