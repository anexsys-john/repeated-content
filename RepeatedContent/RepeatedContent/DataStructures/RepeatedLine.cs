using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepeatedContent
{
    public class RepeatedLine
    {
        public int Count { get; }
        public string Content { get; }
        public List<string> ParentFiles { get; }

        public RepeatedLine(int count, string content, List<string> parentFiles)
        {
            Count = count;
            Content = content;
            ParentFiles = parentFiles;
        }

        public override string ToString()
        {
            return $"[{Count}] >>>{Content}<<<";
        }
    }
}
