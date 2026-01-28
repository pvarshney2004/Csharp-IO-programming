using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace JSON_Problems
{
    public class ListToJsonArray
    {
        // Convert a list of C# objects into a JSON array.
        public static void Execute()
        {
            var cars = new List<object>
            {
                new { Brand = "BMW", Year = 2022 },
                new { Brand = "Audi", Year = 2021 },
            };

            string json = JsonConvert.SerializeObject(cars, Formatting.Indented);
            Console.WriteLine(json);
        }
    }
}
