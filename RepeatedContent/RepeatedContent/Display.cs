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

        public void AddLinesToListBox(ListBox listBox, List<RepeatedLine> lines)
        {
            if (listBox.DataSource == null)
            {
                listBox.DataSource = lines;
            }
            else
            {
                List<RepeatedLine> source = (List<RepeatedLine>)listBox.DataSource;
                source.AddRange(lines);
                listBox.DataSource = null;
                listBox.DataSource = source;
            }
            SortListBox(listBox);
        }

        public void RemoveLinesFromListBox(ListBox listBox, bool removeAll = false)
        {
            List<RepeatedLine> source = (List<RepeatedLine>)listBox.DataSource;
            if (removeAll)
            {
                foreach (RepeatedLine line in listBox.Items)
                {
                    if (source.Contains(line))
                    {
                        source.Remove(line);
                    }
                }
            }
            else
            {
                foreach (RepeatedLine line in listBox.SelectedItems)
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
            List<RepeatedLine> selection = from.SelectedItems.Cast<RepeatedLine>().ToList();
            AddLinesToListBox(to, selection);
            RemoveLinesFromListBox(from);
        }

        public void MoveAll(ListBox from, ListBox to)
        {
            AddLinesToListBox(to, from.Items.Cast<RepeatedLine>().ToList());
            from.DataSource = null;
        }

        public void AppendOutputMessage(TextBox textBox, string message)
        {
            textBox.AppendText(message);
            textBox.AppendText(Environment.NewLine);
        }

        public void ClearListBox(ListBox listBox)
        {
            listBox.DataSource = null;
        }

        public void ClearOutputMessage(TextBox textBox)
        {
            textBox.Clear();
        }

        private void SortListBox(ListBox listBox)
        {
            listBox.SortBy<RepeatedLine>(line => line.Count);
        }
    }
}
