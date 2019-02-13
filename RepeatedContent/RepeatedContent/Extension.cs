using System;
using System.Collections.Generic;
using System.Collections;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RepeatedContent
{
    public static class Extension
    {
        public static IOrderedEnumerable<TSource> SortByDescending<TSource>(this ListBox listBox, Func<TSource, object> query)
        {
            IOrderedEnumerable<TSource> sortedItems = listBox.Items.Cast<TSource>().ToList().OrderByDescending(query);
            listBox.DataSource = null;
            listBox.DataSource = sortedItems.ToList();
            return sortedItems;
        }

        public static IOrderedEnumerable<TSource> SortBy<TSource>(this ListBox listBox, Func<TSource, object> query)
        {
            IOrderedEnumerable<TSource> sortedItems = listBox.Items.Cast<TSource>().ToList().OrderBy(query);
            listBox.DataSource = null;
            listBox.DataSource = sortedItems.ToList();
            return sortedItems;
        }

        public static IOrderedEnumerable<TSource> ThenSortBy<TSource>(this IOrderedEnumerable<TSource> sortedItems, Func<TSource, object> query, ListBox listBox)
        {
            IOrderedEnumerable<TSource> newSortedItems = sortedItems.ThenBy(query);
            listBox.DataSource = null;
            listBox.DataSource = newSortedItems.ToList();
            return sortedItems;
        }

        public static IOrderedEnumerable<TSource> ThenSortByDescending<TSource>(this IOrderedEnumerable<TSource> sortedItems, Func<TSource, object> query, ListBox listBox)
        {
            IOrderedEnumerable<TSource> newSortedItems = sortedItems.ThenByDescending(query);
            listBox.DataSource = null;
            listBox.DataSource = newSortedItems.ToList();
            return sortedItems;
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
