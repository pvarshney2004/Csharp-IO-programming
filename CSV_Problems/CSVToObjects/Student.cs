using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSV_Problems.CSVToObjects
{
    public class Student
    {
        public int ID { get; set; }
        public string? Name { get; set; }
        public int Age { get; set; }
        public int Marks { get; set; }

        public override string ToString()
        {
            return $"ID: {ID}, Name: {Name}, Age: {Age}, Marks: {Marks}";
        }

    }
}