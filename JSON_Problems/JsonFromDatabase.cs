using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace JSON_Problems
{
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
    }

    public class JsonFromDatabase
    {
        // Generate a JSON report from database records.
        public static void Execute()
        {
            List<Employee> employees = new List<Employee>
            {
                new Employee
                {
                    Id = 1,
                    Name = "Aman",
                    Salary = 30000,
                },
                new Employee
                {
                    Id = 2,
                    Name = "Ravi",
                    Salary = 45000,
                },
            };

            string jsonReport = JsonConvert.SerializeObject(employees, Formatting.Indented);
            Console.WriteLine(jsonReport);
        }
    }
}
