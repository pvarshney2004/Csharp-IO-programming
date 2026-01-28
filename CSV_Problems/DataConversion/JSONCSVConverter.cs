using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using CSV_Problems.FilterRecords;

namespace CSV_Problems.DataConversion
{
    public class JSONCSVConverter
    {
        /*
        Convert JSON to CSV and Vice Versa
● Read a JSON file containing a list of students.
● Convert it into CSV format and save it.
● Implement another method to read CSV and convert it back to JSON.
        */
        static string jsonFile = @"DataConversion\students.json";
        static string csvFile = @"DataConversion\students.csv";

        public static void Execute()
        {
            try
            {
                JsonToCsv();
                CsvToJson();
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }

        // method to convert JSON to CSV
        public static void JsonToCsv()
        {
            string jsonData = File.ReadAllText(jsonFile);
            // deserialization (file to object)
            List<Student> students = JsonSerializer.Deserialize<List<Student>>(jsonData);
            // manual writing of c# objects to csv file(serialization)
            using (StreamWriter sw = new StreamWriter(csvFile))
            {
                sw.WriteLine("Id,Name,Age,Marks");
                foreach (var student in students)
                {
                    sw.WriteLine($"{student.Id},{student.Name},{student.Age},{student.Marks}");
                }
            }
            Console.WriteLine("JSON converted to CSV successfully.");
        }

        // method to convert CSV to JSON
        public static void CsvToJson()
        {
            // manual reading of csv file and creating list of objects(de-serialization)
            List<Student> students = new List<Student>();
            string[] lines = File.ReadAllLines(csvFile);
            for (int i = 1; i < lines.Length; i++)
            {
                string[] data = lines[i].Split(',');
                students.Add(new Student
                {
                    Id = int.Parse(data[0]),
                    Name = data[1],
                    Age = int.Parse(data[2]),
                    Marks = int.Parse(data[3])
                });
            }
            // serialization (object to file)
            string jsonData = JsonSerializer.Serialize(students, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText("DataConversion/students_from_csv.json", jsonData);
            Console.WriteLine("CSV converted back to JSON successfully.");
        }
    }
}