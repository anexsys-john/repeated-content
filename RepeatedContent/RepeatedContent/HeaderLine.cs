using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepeatedContent
{
    public class HeaderLine
    {
        public bool IsHeader { get; private set; }
        public string Content { get; private set; }

        public HeaderLine(bool isHeader = true, string content = "")
        {
            IsHeader = isHeader;
            Content = content;
        }

        public void Validate()
        {
            IsHeader = true;
        }

        public void InValidate()
        {
            IsHeader = false;
        }
    }
}
