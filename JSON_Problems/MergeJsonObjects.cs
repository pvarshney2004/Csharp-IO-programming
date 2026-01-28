using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace JSON_Problems
{
    public class MergeJsonObjects
    {
        // Merge two JSON objects into one.
        public static void Execute()
        {
            JObject obj1 = JObject.Parse(@"{ 'name':'Amit' }");
            JObject obj2 = JObject.Parse(@"{ 'age':30 }");

            obj1.Merge(obj2);
            Console.WriteLine(obj1.ToString());
        }
    }
}
