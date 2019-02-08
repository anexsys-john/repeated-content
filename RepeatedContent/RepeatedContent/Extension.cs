using System;
using System.Collections.Generic;
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
    }
}
