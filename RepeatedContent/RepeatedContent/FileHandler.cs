﻿using System;
using System.ComponentModel;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepeatedContent
{
    public class FileHandler
    {
        private string DirectoryPath;
        public List<string> Files { get; }
        private List<string> Headers = new List<string>();
        public List<string> LinesFromFiles { get; }
        private List<string> NestedDirectories = new List<string>();
        private ErrorReporter Reporter;

        public FileHandler(string directoryPath, ErrorReporter reporter)
        {
            Reporter = reporter;
            LinesFromFiles = new List<string>();
            Files = new List<string>();
            DirectoryPath = directoryPath;
            try
            {
                GetAllFiles(directoryPath);
            }
            catch (Exception ex)
            {
                Reporter.SetErrorMessage(ex.Message);
            }
            GetHeaders();
        }

        public void GetAllFiles(string directoryPath)
        {
            Files.AddRange(Directory.GetFiles(directoryPath));
            NestedDirectories = Directory.GetDirectories(directoryPath).Cast<string>().ToList();
            foreach (string directory in NestedDirectories)
            {
                GetAllFiles(directory);
            }
        }

        public List<RepeatedLine> GetRepeatedLines(BackgroundWorker worker, int limit)
        {
            GetLines(worker);
            return LinesFromFiles.GroupBy(x => x)
                        .Where(group => group.Count() >= limit)
                        .Select(group => new RepeatedLine(group.Count(), group.Key))
                        .ToList();
        }

        public List<RemovedLine> RemoveLinesFromFiles(BackgroundWorker worker, List<RepeatedLine> testLines) // returns the lines that were removed
        {
            int count = Files.Count();
            int i = 1;
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
                worker.ReportProgress((int)(i / (decimal)count * 100));
                i++;
            }
            return removedLines;
        }

        private void GetHeaders()
        {
            using (StreamReader sr = new StreamReader("data/headers.txt"))
            {
                while (sr.Peek() >= 0)
                {
                    Headers.Add(sr.ReadLine());
                }
            }

        }

        private void DealWithHeaders(ref bool inHeaderSection, ref int newLineCount, string currentLine, int lineNumber, ref List<string> currentFileLines)
        {
            if (lineNumber == 0 && Headers.Contains(currentLine.Split(':').First().ToLower()))
            {
                inHeaderSection = true;
            }
            else if (inHeaderSection && string.IsNullOrEmpty(currentLine))
            {
                newLineCount++;
                if (newLineCount == 2) inHeaderSection = false;
            }
            else if (!inHeaderSection)
            {
                LinesFromFiles.Add(currentLine);
                currentFileLines.Add(currentLine);
            }
        }

        public void GetLines(BackgroundWorker worker)
        {
            int count = Files.Count;
            int i = 1;
            int lineNumber = 0;
            int newLineCount = 0;
            string currentLine;
            bool inHeaderSection = false;
            foreach (string file in Files)
            {
                List<string> currentFileLines = new List<string>();
                using (StreamReader sr = new StreamReader(file))
                {
                    while (sr.Peek() >= 0)
                    {
                        currentLine = sr.ReadLine();
                        DealWithHeaders(ref inHeaderSection, ref newLineCount, currentLine, lineNumber, ref currentFileLines);
                        lineNumber++;
                    }
                }
                worker.ReportProgress((int)(i / (decimal)count * 100));
                i++;

                File.WriteAllLines("test", currentFileLines);
                File.Delete(file);
                File.Move("test", file);
            }
        }
    }
}
