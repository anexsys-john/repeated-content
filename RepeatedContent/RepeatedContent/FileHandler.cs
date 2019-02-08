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
        private List<string> Files = new List<string>();
        private List<string> LinesFromFiles = new List<string>();
        private List<string> NestedDirectories = new List<string>();

        public FileHandler(string directoryPath)
        {
            DirectoryPath = directoryPath;
            GetAllFiles(directoryPath);
        }

        private void GetAllFiles(string directoryPath)
        {
            Files.AddRange(Directory.GetFiles(directoryPath));
            NestedDirectories = Directory.GetDirectories(directoryPath).Cast<string>().ToList();
            foreach (string directory in NestedDirectories)
            {
                GetAllFiles(directory);
            }
        }

        public List<Line> GetRepeatedLines(BackgroundWorker worker, int limit)
        {
            GetLines(worker);
            return LinesFromFiles.GroupBy(x => x)
                        .Where(group => group.Count() >= limit)
                        .Select(group => new Line(group.Count(), group.Key))
                        .ToList();
        }

        public List<RemovedLine> RemoveLinesFromFiles(List<Line> testLines) // returns the lines that were removed
        {
            List<RemovedLine> removedLines = new List<RemovedLine>();
            foreach (string file in Files)
            {
                using (StreamWriter sw = new StreamWriter("test"))
                {
                    using (StreamReader sr = new StreamReader(file))
                    {
                        string line;
                        while ((line = sr.ReadLine()) != null)
                        {
                            if (!testLines.Select(item => item.Content).ToList().Contains(line))
                            {
                                sw.WriteLine(line);
                            }
                            else
                            {
                                removedLines.Add(new RemovedLine(line, file));
                            }
                        }
                    }
                }
                File.Delete(file);
                File.Move("test", file);
            }
            return removedLines;
        }

        private void GetLines(BackgroundWorker worker)
        {
            LinesFromFiles = new List<string>();
            int count = Files.Count;
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
