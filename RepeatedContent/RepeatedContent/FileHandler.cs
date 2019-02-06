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
        private string[] Files;
        private List<string> LinesFromFiles = new List<string>();

        public FileHandler(string directoryPath)
        {
            DirectoryPath = directoryPath;
            Files = Directory.GetFiles(DirectoryPath);
        }

        public List<string> GetRepeatedLines(BackgroundWorker worker)
        {
            GetLines(worker);
            return LinesFromFiles.GroupBy(x => x)
                        .Where(group => group.Count() > 1)
                        .Select(group => group.Key)
                        .ToList();
        }

        public void RemoveLinesFromFiles(List<string> testLines)
        {
            foreach (string file in Files)
            {
                using (StreamWriter sw = new StreamWriter("test"))
                {
                    using (StreamReader sr = new StreamReader(file))
                    {
                        string line;
                        while ((line = sr.ReadLine()) != null)
                        {
                            if (!testLines.Contains(line))
                            {
                                sw.WriteLine(line);
                            }
                        }
                    }
                }
                File.Delete(file);
                File.Move("test", file);
            }
        }

        private void GetLines(BackgroundWorker worker)
        {
            LinesFromFiles = new List<string>();
            int count = Files.Length;
            int i = 1;
            foreach (string file in Files)
            {
                using (StreamReader sr = new StreamReader(file))
                {
                    while (sr.Peek() >= 0)
                    {
                        LinesFromFiles.Add(sr.ReadLine());
                    }
                }
                worker.ReportProgress((i / count) * 100);
                i++;
            }
        }
    }
}
