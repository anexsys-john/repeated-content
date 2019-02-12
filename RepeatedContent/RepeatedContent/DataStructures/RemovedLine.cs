using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepeatedContent
{
    public class RemovedLine : Line
    {
        public string File { get; }
        
        public RemovedLine(string content, string file, string parentFile) : base(content, parentFile)
        {
            File = file;
        }
    }
}
