using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepeatedContent
{
    public class Line
    {
        public int Count { get; }
        public string Content { get; }

        public Line(int count, string content)
        {
            Count = count;
            Content = content;
        }

        public override string ToString()
        {
            return $"[{Count}] {Content}";
        }
    }
}
