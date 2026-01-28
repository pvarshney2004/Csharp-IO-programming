using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Streams_Problems.BufferedStreamDemo
{
    public class FileCopy
    {
        /*
        Buffered Streams - Efficient File Copy
📌 Problem Statement: Create a C# program that copies a large file
(e.g., 100MB) from one location to another using Buffered Streams
(BufferedStream). Compare the performance with normal file streams.
Requirements: Read and write in chunks of 4 KB (4096 bytes). Use
Stopwatch to measure execution time. Compare execution time with
unbuffered streams.
        */
        public static void Execute()
        {
            string sourceFile = @"BufferedStreamDemo/largefile.dat";
            string destUnbuffered = @"BufferedStreamDemo/copy_unbuffered.dat";
            string destBuffered = @"BufferedStreamDemo/copy_buffered.dat";
            int bufferSize = 4096; // 4 KB
            if (!File.Exists(sourceFile))
            {
                Console.WriteLine("Source file does not exist.");
                return;
            }
            // Unbuffered copy
            Stopwatch sw1 = Stopwatch.StartNew();
            CopyUsingFileStream(sourceFile, destUnbuffered, bufferSize);
            sw1.Stop();

            // Buffered copy
            Stopwatch sw2 = Stopwatch.StartNew();
            CopyUsingBufferedStream(sourceFile, destBuffered, bufferSize);
            sw2.Stop();

            Console.WriteLine("Copy Completed.\n");
            Console.WriteLine($"Unbuffered FileStream Time : {sw1.ElapsedMilliseconds} ms");
            Console.WriteLine($"Buffered Stream Time       : {sw2.ElapsedMilliseconds} ms");
        }

        // using FileStream
        public static void CopyUsingFileStream(string source, string destination, int bufferSize)
        {
            using (FileStream fsRead = new FileStream(source, FileMode.Open, FileAccess.Read))
            using (FileStream fsWrite = new FileStream(destination, FileMode.Create, FileAccess.Write))
            {
                byte[] buffer = new byte[bufferSize];
                int bytesRead;

                while ((bytesRead = fsRead.Read(buffer, 0, buffer.Length)) > 0)
                {
                    fsWrite.Write(buffer, 0, bytesRead);
                }
            }
        }

        // using BufferedStream
        public static void CopyUsingBufferedStream(string source, string destination, int bufferSize)
        {
            using (FileStream sourceStream = new FileStream(source, FileMode.Open, FileAccess.Read))
            using (FileStream destStream = new FileStream(destination, FileMode.Create, FileAccess.Write))
            using (BufferedStream bufferedInput = new BufferedStream(sourceStream, bufferSize))
            using (BufferedStream bufferedOutput = new BufferedStream(destStream, bufferSize))
            {
                byte[] buffer = new byte[bufferSize];
                int bytesRead;

                while ((bytesRead = bufferedInput.Read(buffer, 0, buffer.Length)) > 0)
                {
                    bufferedOutput.Write(buffer, 0, bytesRead);
                }
            }
        }
    }
}