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

        public void RemoveLinesFromListBox(ListBox listBox, bool removeAll = false)
        {
            List<Line> source = (List<Line>)listBox.DataSource;
            if (removeAll)
            {
                foreach (Line line in listBox.Items)
                {
                    if (source.Contains(line))
                    {
                        source.Remove(line);
                    }
                }
            }
            else
            {
                foreach (Line line in listBox.SelectedItems)
                {
                    if (source.Contains(line))
                    {
                        source.Remove(line);
                    }
                }
            }
            listBox.DataSource = null;
            listBox.DataSource = source;
        }

        public void MoveSelection(ListBox from, ListBox to)
        {
            List<Line> selection = from.SelectedItems.Cast<Line>().ToList();
            AddLinesToListBox(to, selection);
            RemoveLinesFromListBox(from);
        }

        public void MoveAll(ListBox from, ListBox to)
        {
            AddLinesToListBox(to, from.Items.Cast<Line>().ToList());
            from.DataSource = null;
        }

        public void AppendOutputMessage(TextBox textBox, string message)
        {
            textBox.AppendText(message);
            textBox.AppendText(Environment.NewLine);
        }

        public void ClearOutputMessage(TextBox textBox)
        {
            textBox.Clear();
        }
    }
}
