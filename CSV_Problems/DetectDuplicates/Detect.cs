using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSV_Problems.DetectDuplicates
{
    public class Detect
    {
        /*
        Detect Duplicates in a CSV File
● Read a CSV file and detect duplicate entries based on the ID column.
● Print all duplicate records.
        */
        public static void FindDuplicates()
        {
            string filePath = "DetectDuplicates/sample.csv";
            using (var reader = new StreamReader(filePath))
            using (var csv = new CsvHelper.CsvReader(reader, System.Globalization.CultureInfo.InvariantCulture))
            {
                var employees = csv.GetRecords<Employee>().ToList();
                var duplicates = employees.GroupBy(e => e.ID).Where(g => g.Count() > 1).SelectMany(g => g);
                Console.WriteLine("Duplicate Records (based on ID):\n");

                foreach (var emp in duplicates)
                {
                    Console.WriteLine(
                        $"ID: {emp.ID}, Name: {emp.Name}, Dept: {emp.Department}, Salary: {emp.Salary}");
                }

            }

        }
    }
}