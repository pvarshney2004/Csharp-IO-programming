using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Streams_Problems.CountWords
{
    public class Count
    {
        /*
        Count Words in a File
📌 Problem Statement: Write a C# program that counts the number of
words in a given text file and displays the top 5 most frequently
occurring words.
Requirements: Use StreamReader to read the file. Use a
Dictionary<string, int> to count word occurrences. Sort the words based
on frequency and display the top 5.
        */

        public static void Execute()
        {
            string filepath = @"CountWords/sample.txt";
            Dictionary<string, int> wordCount = new Dictionary<string, int>();
            try
            {
                using (StreamReader sr = new StreamReader(filepath))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] words = line
                            .ToLower()
                            .Split(new char[] { ' ', '.', ',', '!', '?', ';', ':' },
                                   StringSplitOptions.RemoveEmptyEntries);

                        foreach (string word in words)
                        {
                            if (wordCount.ContainsKey(word))
                            {
                                wordCount[word]++;
                            }
                            else
                            {
                                wordCount[word] = 1;
                            }
                        }
                    }
                }
                Console.WriteLine("Top 5 most frequent words:\n");
                var topWords = wordCount
                    .OrderByDescending(w => w.Value)
                    .Take(5);
                foreach (var item in topWords)
                {
                    Console.WriteLine($"{item.Key} → {item.Value} times");
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine("File error: " + ex.Message);
            }
        }
    }
}