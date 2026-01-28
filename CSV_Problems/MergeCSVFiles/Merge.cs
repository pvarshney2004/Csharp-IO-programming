using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CsvHelper;
using System.Globalization;

namespace CSV_Problems.MergeCSVFiles
{
    public class Merge
    {
        /*
        Merge Two CSV Files
● You have two CSV files:
○ students1.csv (contains ID, Name, Age)
○ students2.csv (contains ID, Marks, Grade)
● Merge both files based on ID and create a new file containing all details
        */
        public static void MergeCsvFiles()
        {
            string file1 = "MergeCSVFiles/sample1.csv";
            string file2 = "MergeCSVFiles/sample2.csv";
            string outputFile = "MergeCSVFiles/merged_students.csv";
            List<Student1> students1;
            List<Student2> students2;

            using (var reader = new StreamReader(file1))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                students1 = csv.GetRecords<Student1>().ToList();
            }

            using (var reader = new StreamReader(file2))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                students2 = csv.GetRecords<Student2>().ToList();
            }

            // merge based on ID
            var mergedData =
                from s1 in students1
                join s2 in students2 on s1.ID equals s2.ID
                select new StudentMerged
                {
                    ID = s1.ID,
                    Name = s1.Name,
                    Age = s1.Age,
                    Marks = s2.Marks,
                    Grade = s2.Grade
                };

            // writing to new CSV file
            using (var writer = new StreamWriter(outputFile))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.WriteRecords(mergedData);
            }
            System.Console.WriteLine("Merging Completed. Check merged_students.csv file.");

        }
    }
}