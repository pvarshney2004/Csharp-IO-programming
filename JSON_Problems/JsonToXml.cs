using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml;
using Newtonsoft.Json;

namespace JSON_Problems
{
    public class JsonToXml
    {
        // convert json to xml format
        public static void Execute()
        {
            string json = "{ 'name':'Prashant', 'age':21 }";
            XmlDocument doc = JsonConvert.DeserializeXmlNode(json, "root");
            Console.WriteLine(doc.OuterXml);
        }
    }
}
