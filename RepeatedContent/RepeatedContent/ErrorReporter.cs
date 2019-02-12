using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepeatedContent
{
    public class ErrorReporter
    {
        public string Message { get; private set; }
        public bool HasError { get; private set; }

        public ErrorReporter()
        {
            HasError = false;
        }

        public void SetErrorMessage(string message)
        {
            Message = message;
            HasError = true;
        }

        public void Refresh()
        {
            Message = null;
            HasError = false;
        }
    }
}
