using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Globalization;
using CsvHelper;

namespace CSV_Problems.ReadAndCountRows
{
    public class CountRows
    {
        /*
        Read and Count Rows in a CSV File
● Read a CSV file and count the number of records (excluding the header row).
        */
        public static void Execute()
        {
            string filePath = @"ReadingCSVFile\sample.csv";
            using (var reader = new StreamReader(filePath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                int records = csv.GetRecords<Student>().ToList().Count;
                Console.WriteLine($"Total Records (excluding header): {records}");
            }
        }
    }
}