using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepeatedContent
{
    class RemovedLine
    {
        public string Line { get; }
        public string File { get; }
        
        public RemovedLine(string line, string file)
        {
            Line = line;
            File = file;
        }
    }
}
