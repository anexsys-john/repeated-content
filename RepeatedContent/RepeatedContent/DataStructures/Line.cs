using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepeatedContent
{
    public class Line
    {
        public string Content { get; }
        public string ParentFile { get; }

        public Line(string content, string parentFile)
        {
            Content = content;
            ParentFile = parentFile;
        }
    }
}
