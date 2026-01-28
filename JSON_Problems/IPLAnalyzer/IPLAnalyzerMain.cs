using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace JSON_Problems.IPLAnalyzer
{
    /*
    🏏 Problem Statement: IPL and Censorship Analyzer
🎯 Objective
Develop a C# application that reads IPL match data from JSON and CSV files,
processes the data based on defined censorship rules, and writes the sanitized
data back to new files.
📌 Requirements
1️⃣Input Data Formats
The application should support:
● JSON Input: IPL match data in JSON format.
● CSV Input: IPL match data in CSV format.
2️⃣Censorship Rules
The program should apply the following censorship rules:
1. Mask Team Names → Replace part of the team name with "***".
o Example: "Mumbai Indians" → "Mumbai ***"
2. Redact Player of the Match → Replace player names with "REDACTED".
3️⃣Output Data Formats
● Generate censored JSON and censored CSV files after processing
    */
    public class IPLAnalyzerMain
    {
        public static void Execute()
        {
            string inputCsvFile = @"IPLAnalyzer/beforeCensorship.csv";
            string inputJsonFile = @"IPLAnalyzer/beforeCensorship.json";
            string outputCsvFile = @"IPLAnalyzer/afterCensorship.csv";
            string outputJsonFile = @"IPLAnalyzer/afterCensorship.json";

            ProcessCSVData(inputCsvFile, outputCsvFile);
            ProcessJSONData(inputJsonFile, outputJsonFile);
            Console.WriteLine("Censorship completed successfully.");
        }

        // method to process csv data
        public static void ProcessCSVData(string inputCsvFile, string outputCsvFile)
        {
            using StreamReader reader = new StreamReader(inputCsvFile);
            using StreamWriter writer = new StreamWriter(outputCsvFile);
            string header = reader.ReadLine();
            writer.WriteLine(header);

            while (!reader.EndOfStream)
            {
                string[] data = reader.ReadLine().Split(',');
                data[1] = MaskTeam(data[1]); // masking team1
                data[2] = MaskTeam(data[2]); // masking team2
                data[6] = "REDACTED"; // redacting player_of_match

                writer.WriteLine(string.Join(",", data));
            }
        }

        //method to process json data
        public static void ProcessJSONData(string inputPath, string outputPath)
        {
            string json = File.ReadAllText(inputPath);
            List<Match> matches = JsonSerializer.Deserialize<List<Match>>(json);
            foreach (var match in matches)
            {
                match.team1 = MaskTeam(match.team1);
                match.team2 = MaskTeam(match.team2);
                match.winner = MaskTeam(match.winner);
                match.player_of_match = "REDACTED";
            }
            string censoredJson = JsonSerializer.Serialize(
                matches,
                new JsonSerializerOptions { WriteIndented = true }
            );
            File.WriteAllText(outputPath, censoredJson);
        }

        // method to mask the team
        public static string MaskTeam(string team)
        {
            string firstWord = team.Split(' ')[0];
            return firstWord + " ****";
        }
    }
}
