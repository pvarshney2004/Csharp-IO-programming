using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using CsvHelper;

namespace CSV_Problems.ModifyCSVFile
{
    public class ModifyFile
    {
        /*
        Modify a CSV File (Update a Value)
● Read a CSV file and increase the salary of employees from the "IT" department by
10%.
● Save the updated records back to a new CSV file.
        */
        public static void UpdateSalary()
        {
            string inputfilePath = @"ModifyCSVFile/employees.csv";
            string outputfilePath = @"ModifyCSVFile/updated_employees.csv";
            using (var reader = new StreamReader(inputfilePath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var records = csv.GetRecords<Employee>().ToList();
                foreach (var emp in records)
                {
                    if (emp.Department == "IT")
                    {
                        emp.Salary *= 1.1;
                    }
                }
                using (var writer = new StreamWriter(outputfilePath))
                using (var csvWriter = new CsvWriter(writer, CultureInfo.InvariantCulture))
                {
                    csvWriter.WriteRecords(records);
                    System.Console.WriteLine("Salary updated and saved to " + outputfilePath);
                }
            }
        }
    }
}