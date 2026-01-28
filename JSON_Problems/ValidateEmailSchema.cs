using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;

namespace JSON_Problems
{
    public class ValidateEmailSchema
    {
        // Validate an email field using JSON Schema.
        public static void Execute()
        {
            string schemaJson =
                @"{
              'type':'object',
              'properties':{
                'email':{'type':'string','format':'email'}
              }
            }";

            JObject data = JObject.Parse(@"{ 'email':'test@gmail.com' }");
            JsonSchema schema = JsonSchema.Parse(schemaJson);

            Console.WriteLine(data.IsValid(schema) ? "Valid Email" : "Invalid Email");
        }
    }
}
