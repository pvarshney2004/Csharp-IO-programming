using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CsvHelper;
using System.Globalization;

namespace CSV_Problems.SearchRecord
{
    public class SearchEmployee
    {
        /*
        Search for a Record in CSV
● Read an employees.csv file and search for an employee by name.
● Print their department and salary.
        */
        public static void SearchEmployeeByName(string name)
        {
            string filePath = @"SearchRecord\employees.csv";
            using (var reader = new StreamReader(filePath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var employees = csv.GetRecords<Employee>();
                var employee = employees.FirstOrDefault(e => e.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
                if (employee != null)
                {
                    Console.WriteLine($"Employee Found: Name: {employee.Name}, Department: {employee.Department}, Salary: {employee.Salary}");
                }
                else
                {
                    Console.WriteLine("Employee not found.");
                }
            }
        }
    }
}