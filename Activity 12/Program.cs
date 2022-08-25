using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Activity_12
{
    internal class Program
    {
        static void Main(string[] args)
        {

            StreamReader inputFile;
            inputFile = File.OpenText(@"C:\Users\ejohn\Documents\activity12.txt");
            
            // Read entire file
            string fileData = inputFile.ReadToEnd();

            // Put fileData into an array by splitting each word by the following characters and removing empty entries
            string[] wordArray = fileData.Split(new[] { ' ', ',', '.', ':', ';', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

            // Create list to hold found words
            List<string> foundWords = new List<string>();

            for (int i = 0; i < wordArray.Length; i++)
            {
                // Find words ending in e or t
                if (wordArray[i].EndsWith("e") || wordArray[i].EndsWith("E") || wordArray[i].EndsWith("t") || wordArray[i].EndsWith("T"))
                {
                    // Add words ending in e or t to list
                    foundWords.Add(wordArray[i]);
                }
            }

            // Write results to console
            Console.WriteLine("There were " + wordArray.Length + " words in the file.");
            Console.WriteLine("Found " + foundWords.Count + " words ending in e or t.");
            Console.Write("Words ending in e or t are: ");

            // Write to console words ending in e or to
            for (int i = 0; i < foundWords.Count; i ++)
            {
                Console.Write(foundWords[i] + ", ");
            }

            // Await key stroke before closing
            Console.ReadKey();
        }
    }
}
