using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace JSON_Problems
{
    public class CreateJsonObject
    {
        // Create a JSON object for a Student with fields: name, age, and subjects (array).
        public static void Execute()
        {
            var student = new
            {
                name = "Prashant",
                age = 22,
                subjects = new[] { "Math", "Science", "Computer" },
            };
            string json = JsonConvert.SerializeObject(student, Formatting.Indented);
            Console.WriteLine(json);
        }
    }
}
