using System.IO;
using System.Collections.Generic;

namespace RepeatedContent
{
    class FileSplitter
    {
        private readonly string directoryPath; // this is a directory containing .txt files
        private string[] files;

        public FileSplitter(string filePath)
        {
            directoryPath = filePath;
        }

        public List<string> GetLines()
        {
            List<string> lines = new List<string>();
            files = Directory.GetFiles(directoryPath);
            foreach (string file in files)
            {
                using (StreamReader sr = new StreamReader(file))
                {
                    while (sr.Peek() >= 0)
                    {
                        lines.Add(sr.ReadLine());
                    }
                }
            }
            return lines;
        }
    }
}