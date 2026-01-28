using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSV_Problems.CSVToObjects
{
    public class CsvReader
    {
        /*
        Convert CSV Data into Java Objects
● Read a CSV file and convert each row into a Student Java object.
● Store the objects in a List<Student> and print them.
        */

        public static void Execute()
        {
            string filePath = @"CSVToObjects\students.csv";
            List<Student> students = new List<Student>();
            try
            {
                using(StreamReader sr = new StreamReader(filePath))
                {
                    string line;
                    bool isHeader = true;
                    while ((line = sr.ReadLine()) != null)
                    {
                        // skipping first header line
                        if(isHeader)
                        {
                            isHeader = false;
                            continue;
                        }

                        string[] data = line.Split(',');
                        Student student = new Student
                        {
                            ID = int.Parse(data[0]),
                            Name = data[1],
                            Age = int.Parse(data[2]),
                            Marks = int.Parse(data[3])
                        };
                        students.Add(student);
                    }
                }
                foreach (var s in students)
                {
                    Console.WriteLine(s);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }
    }

}