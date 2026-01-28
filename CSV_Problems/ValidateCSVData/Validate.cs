using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using CsvHelper;

namespace CSV_Problems.ValidateCSVData
{
    public class Validate
    {
        /*
        Validate CSV Data Before Processing
● Ensure that the "Email" column follows a valid email format using regex.
● Ensure that "Phone Numbers" contain exactly 10 digits.
● Print any invalid rows with an error message.
        */
        public static void ValidateCSV()
        {
            string filePath = "ValidateCSVData/sample.csv";
            // regex for email and phone number 
            string patternForEmail = @"[a-zA-Z0-9._]+@[a-zA-Z]+\.[a-zA-Z]{2,}";
            string patternForPhone = @"\d{10}";
            using (var reader = new StreamReader(filePath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var records = csv.GetRecords<User>().ToList();
                foreach (var user in records)
                {
                    bool isValidEmail = Regex.IsMatch(user.Email, patternForEmail);
                    bool isValidPhone = Regex.IsMatch(user.Phone, patternForPhone);
                    if (!isValidEmail || !isValidPhone)
                    {
                        Console.WriteLine($"Invalid row: ID={user.ID}, Name={user.Name}, Email={user.Email}, Phone={user.Phone}");
                    }
                }
            }

        }
    }
}