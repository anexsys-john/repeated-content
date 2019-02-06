using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RepeatedContent
{
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            tbRepeatedContent.Text = "";
            if (bwRepeatedSearch.IsBusy == false)
            {
                bwRepeatedSearch.RunWorkerAsync();
            }
        }

        private void bwRepeatedSearch_DoWork(object sender, DoWorkEventArgs e)
        {
            string filepath = tbFileInput.Text;
            FileSplitter splitter = new FileSplitter(filepath);
            RepetitionSearcher searcher = new RepetitionSearcher(splitter.GetLines());
            List<string> repeatedLines = searcher.GetRepeatedLines();
            e.Result = repeatedLines;
        }

        private void bwRepeatedSearch_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            foreach (string line in ((IEnumerable<string>)e.Result).Cast<object>().ToList())
            {
                tbRepeatedContent.AppendText(line + Environment.NewLine);
            }
        }
    }
}
