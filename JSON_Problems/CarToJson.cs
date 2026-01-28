using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace JSON_Problems
{
    public class Car
    {
        public string? Brand { get; set; }
        public int Year { get; set; }
    }

    public class CarToJson
    {
        // Convert a C# object (Car class) into JSON format
        public static void Execute()
        {
            Car car = new Car { Brand = "Toyota", Year = 2023 };
            string json = JsonConvert.SerializeObject(car, Formatting.Indented);
            Console.WriteLine(json);
        }
    }
}
