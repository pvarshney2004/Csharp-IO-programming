using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CsvHelper;
using System.Globalization;

namespace CSV_Problems.FilterRecords
{
    public class ReadFile02
    {
        /*
        Filter Records from CSV
● Read a CSV file and filter students who have scored more than 80 marks.
● Print only the qualifying records.
        */
        public static void FilterStudent()
        {
            string filePath = @"FilterRecords\sample.csv";

            using (var reader = new StreamReader(filePath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var students = csv.GetRecords<Student>().Where(s => s.Marks > 80);
                Console.WriteLine("Students scoring more than 80 marks:\n");
                foreach (var s in students)
                {
                    Console.WriteLine($"ID: {s.ID}, Name: {s.Name}, Age: {s.Age}, Marks: {s.Marks}");
                }
            }
        }
    }
}