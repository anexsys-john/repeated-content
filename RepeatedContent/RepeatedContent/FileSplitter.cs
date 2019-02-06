using System.IO;
using System.Collections.Generic;
using System.ComponentModel;

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

        public List<string> GetLines(BackgroundWorker worker)
        {
            List<string> lines = new List<string>();
            files = Directory.GetFiles(directoryPath);
            int count = files.Length;
            int i = 1;
            foreach (string file in files)
            {
                using (StreamReader sr = new StreamReader(file))
                {
                    while (sr.Peek() >= 0)
                    {
                        lines.Add(sr.ReadLine());
                    }
                }
                worker.ReportProgress((i / count) * 100);
                i++;
            }
            return lines;
        }
    }
}