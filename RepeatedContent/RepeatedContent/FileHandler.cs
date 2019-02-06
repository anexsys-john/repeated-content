using System;
using System.ComponentModel;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepeatedContent
{
    class FileHandler
    {
        private string DirectoryPath;
        private string[] files;
        private List<string> Lines = new List<string>();

        public FileHandler(string directoryPath)
        {
            DirectoryPath = directoryPath;
        }

        public List<string> GetRepeatedLines(BackgroundWorker worker)
        {
            GetLines(worker);
            return Lines.GroupBy(x => x)
                        .Where(group => group.Count() > 1)
                        .Select(group => group.Key)
                        .ToList();
        }

        public void GetLines(BackgroundWorker worker)
        {
            Lines = new List<string>();
            files = Directory.GetFiles(DirectoryPath);
            int count = files.Length;
            int i = 1;
            foreach (string file in files)
            {
                using (StreamReader sr = new StreamReader(file))
                {
                    while (sr.Peek() >= 0)
                    {
                        Lines.Add(sr.ReadLine());
                    }
                }
                worker.ReportProgress((i / count) * 100);
                i++;
            }
        }
    }
}
