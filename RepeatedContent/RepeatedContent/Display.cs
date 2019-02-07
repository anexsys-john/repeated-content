using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepeatedContent
{
    class Display
    {
        public void PrintLinesToControl(Control control, List<Line> lines)
        {
            string output = "";
            foreach (Line line in lines)
            {
                output += $"[{line.Count}] ";
                output += line.Content;
                output += Environment.NewLine;
            }
            control.Text = output;
        }
    }
}
