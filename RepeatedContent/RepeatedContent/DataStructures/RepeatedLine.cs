using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepeatedContent
{
    public class RepeatedLine : Line
    {
        public int Count { get; }

        public RepeatedLine(int count, string content) : base(content)
        {
            Count = count;
        }

        public override string ToString()
        {
            return $"[{Count}] >>>{Content}<<<";
        }
    }
}
