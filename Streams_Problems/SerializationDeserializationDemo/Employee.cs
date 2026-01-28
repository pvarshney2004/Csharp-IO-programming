using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Streams_Problems.SerializationDeserializationDemo
{
    // Create an Employee class with fields: id, name, department, salary. 
    public class Employee
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Department { get; set; }
        public double Salary { get; set; }
    }
}