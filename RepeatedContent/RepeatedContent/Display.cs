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
        public Display()
        {
        }

        public void AddLinesToListBox(ListBox listBox, List<Line> lines)
        {
            if (listBox.DataSource == null)
            {
                listBox.DataSource = lines;
            }
            else
            {
                List<Line> source = (List<Line>)listBox.DataSource;
                source.AddRange(lines);
                listBox.DataSource = null;
                listBox.DataSource = source;
            }
        }

        public void RemoveLinesFromListBox(ListBox listBox, List<Line> lines)
        {
            List<Line> source = (List<Line>)listBox.DataSource;
            foreach (Line line in listBox.SelectedItems)
            {
                if (source.Contains(line))
                {
                    source.Remove(line);
                }
            }
            listBox.DataSource = null;
            listBox.DataSource = source;
        }

        public void MoveSelection(ListBox from, ListBox to)
        {
            List<Line> selection = from.SelectedItems.Cast<Line>().ToList();
            AddLinesToListBox(to, selection);
            RemoveLinesFromListBox(from, selection);
        }
    }
}
