using System.IO;
using System.Collections.Generic;

namespace RepeatedContent
{
    class FileSearcher
    {
        private readonly string directoryPath; // this is a directory containing .txt files
        private string[] files;
        public List<string> Lines = new List<string>();

        public FileSearcher(string filePath)
        {
            directoryPath = filePath;
        }

        public void GetLines()
        {
            files = Directory.GetFiles(directoryPath);
            foreach (string file in files)
            {
                using (StreamReader sr = new StreamReader(file))
                {
                    while (sr.Peek() >= 0)
                    {
                        Lines.Add(sr.ReadLine());
                    }
                }
            }
        }
    }
}