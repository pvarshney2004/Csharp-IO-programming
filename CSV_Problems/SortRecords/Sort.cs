using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CsvHelper;
using System.Globalization;

namespace CSV_Problems.SortRecords
{
    public class Sort
    {
        /*
        Sort CSV Records by a Column
● Read a CSV file and sort the records by Salary in descending order.
● Print the top 5 highest-paid employees.
        */
        public static void SortEmployeesBySalary()
        {
            string filePath = @"SortRecords/employees.csv";
            var employees = new List<Employee>();
            using (var reader = new StreamReader(filePath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                employees = csv.GetRecords<Employee>().ToList();
            }
            var sortedEmployees = employees.OrderByDescending(emp => emp.Salary).Take(5);
            foreach (var emp in sortedEmployees)
            {
                Console.WriteLine($"Name: {emp.Name}, Salary: {emp.Salary}");
            }
        }
    }
}