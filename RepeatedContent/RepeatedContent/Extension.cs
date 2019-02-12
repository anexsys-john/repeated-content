using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RepeatedContent
{
    public static class Extension
    {
        public static void SortBy<TSource>(this ListBox listBox, Func<TSource, object> query)
        {
            List<TSource> items = listBox.Items.Cast<TSource>().ToList();
            List<TSource> sortedItems = items.OrderByDescending(query).ToList();
            listBox.DataSource = null;
            listBox.DataSource = sortedItems;
        }

        public static void AppendText(this RichTextBox textBox, string text, Color color)
        {
            textBox.SelectionStart = textBox.TextLength;
            textBox.SelectionLength = 0;
            textBox.SelectionColor = color;
            textBox.AppendText(text);
            textBox.SelectionColor = textBox.ForeColor;
        }
    }
}
