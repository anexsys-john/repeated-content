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

        private void tbFileInput_Enter(object sender, EventArgs e)
        {
            tbFileInput.ForeColor = Color.Black;
            tbFileInput.Clear();
        }

        private void tbfileInput_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbFileInput.Text))
            {
                tbFileInput.Text = "Input Directory Here...";
            }
        }

        private void btnDirectorySearch_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDialog = new FolderBrowserDialog();
            DialogResult result = folderDialog.ShowDialog();
            tbFileInput.Text = folderDialog.SelectedPath;
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            tbOutputWindow.Text = "";
            if (bwRepeatedSearch.IsBusy == false)
            {
                bwRepeatedSearch.RunWorkerAsync();
            }
        }

        private void btnRemoveText_Click(object sender, EventArgs e)
        {
        }

        private string searchForRepeats(BackgroundWorker worker, DoWorkEventArgs e)
        {
            string filepath = tbFileInput.Text;
            FileHandler handler = new FileHandler(filepath);
            return string.Join(Environment.NewLine, handler.GetRepeatedLines(worker));
        }

        private void bwRepeatedSearch_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            e.Result = searchForRepeats(worker, e);
        }

        private void bwRepeatedSearch_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            tbOutputWindow.AppendText(e.Result.ToString());
        }

        private void bwRepeatedSearch_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            int completion = e.ProgressPercentage;
            pbRepeatedSearchProgress.Value = completion;
        }
    }
}
