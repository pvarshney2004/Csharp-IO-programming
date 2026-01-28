using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Streams_Problems.MemoryStreamDemo
{
    public class ImageToByteArray
    {
        /*
        ByteArray Stream - Convert Image to ByteArray
📌 Problem Statement: Write a C# program that converts an image file
into a byte array and then writes it back to another image file.
Requirements: Use MemoryStream to handle byte arrays. Verify that the
new file is identical to the original image. Handle IOException.
        */
        public static void Execute()
        {
            string sourceImage = @"MemoryStreamDemo/img0.jpg";
            string copiedImage = @"MemoryStreamDemo/output.jpg";
            try
            {
                // read image into byte array
                byte[] imageBytes = File.ReadAllBytes(sourceImage);

                // store bytes in MemoryStream
                using (MemoryStream ms = new MemoryStream(imageBytes))
                {
                    // write byte array back to new image file
                    File.WriteAllBytes(copiedImage, ms.ToArray());
                }
                Console.WriteLine("Image copied successfully using byte array.");

                // additional task to Verify both images are identical
                bool isSame = CompareFiles(sourceImage, copiedImage);
                Console.WriteLine(isSame
                    ? "Verification successful: Files are identical."
                    : "Verification failed: Files are different.");
            }
            catch (IOException ex)
            {
                Console.WriteLine("File error: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unexpected error: " + ex.Message);
            }
        }
        private static bool CompareFiles(string file1, string file2)
        {
            byte[] f1 = File.ReadAllBytes(file1);
            byte[] f2 = File.ReadAllBytes(file2);
            return f1.SequenceEqual(f2);
        }
    }
}