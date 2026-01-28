using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace JSON_Problems
{
    public class FilterJson
    {
        // Parse JSON and filter only those records where age > 25.
        public static void Execute()
        {
            string json =
                @"[
                { 'name':'Amit', 'age':22 },
                { 'name':'Bob', 'age':30 }
            ]";

            JArray array = JArray.Parse(json);

            foreach (var item in array)
            {
                if ((int)item["age"] > 25)
                {
                    Console.WriteLine(item["name"]);
                }
            }
        }
    }
}
