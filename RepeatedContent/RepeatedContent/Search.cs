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
            BackgroundWorker worker = sender as BackgroundWorker;
            e.Result = searchForRepeats(worker, e);
        }

        private string searchForRepeats(BackgroundWorker worker, DoWorkEventArgs e)
        {
            string filepath = tbFileInput.Text;
            FileSplitter splitter = new FileSplitter(filepath);
            RepetitionSearcher searcher = new RepetitionSearcher(splitter.GetLines(worker));
            List<string> repeatedLines = searcher.GetRepeatedLines();
            return string.Join(Environment.NewLine, repeatedLines);
        }

        private void bwRepeatedSearch_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            tbRepeatedContent.AppendText(e.Result.ToString());
        }

        private void bwRepeatedSearch_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            int completion = e.ProgressPercentage;
            pbRepeatedSearchProgress.Value = completion;
            lbProgressPercentage.Text = $"{completion.ToString()} %";
        }
    }
}
