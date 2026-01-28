using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace Streams_Problems.SerializationDeserializationDemo
{
    public class EmployeeSerialization
    {
        /*
        Serialization - Save and Retrieve an Object
📌 Problem Statement: Design a C# program that allows a user to store
a list of employees in a file using Object Serialization and later retrieve
the data from the file.
Requirements: Create an Employee class with fields: id, name,
department, salary. Serialize the list of employees into a file
(BinaryFormatter / JSON Serialization). Deserialize and display the
employees from the file. Handle exceptions properly.
        */

        public static void Execute()
        {
            string filePath = @"SerializationDeserializationDemo/data.json";
            try
            {
                List<Employee> employees = new List<Employee>
                {
                    new Employee { Id = 1, Name = "Prashant", Department = "IT", Salary = 34000 },
                    new Employee { Id = 2, Name = "Aman", Department = "HR", Salary = 42000 },
                    new Employee { Id = 3, Name = "Raj", Department = "Finance", Salary = 48000 }
                };

                // serialization(object to file)
                string jsonData = JsonSerializer.Serialize(employees);
                File.WriteAllText(filePath, jsonData);
                System.Console.WriteLine("Employees Serialize Successfully.");

                // deserialization(file to object)
                string jsonData02 = File.ReadAllText(filePath);
                List<Employee> deserializedEmp = JsonSerializer.Deserialize<List<Employee>>(jsonData02);
                Console.WriteLine("\nEmployees Retrieved from File:\n");
                foreach (var emp in deserializedEmp)
                {
                    Console.WriteLine($"ID: {emp.Id}, Name: {emp.Name}, Dept: {emp.Department}, Salary: {emp.Salary}");
                }
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.Message);
            }
        }
    }
}