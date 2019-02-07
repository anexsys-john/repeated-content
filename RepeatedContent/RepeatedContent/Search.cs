using System;
using System.Text.RegularExpressions;
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
        private FileHandler handler;
        private Display display;

        public Search()
        {
            InitializeComponent();
            display = new Display();
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            tbOutputWindow.Clear();
            if (bwRepeatedSearch.IsBusy == false)
            {
                bwRepeatedSearch.RunWorkerAsync();
            }
        }

        private void btnFoundToRemove_Click(object sender, EventArgs e)
        {
            display.MoveSelection(lbxLinesFound, lbxLinesToRemove);
        }

        private void btnRemoveToFound_Click(object sender, EventArgs e)
        {
            display.MoveSelection(lbxLinesToRemove, lbxLinesFound);
        }

        private void btnFoundToRemoveAll_Click(object sender, EventArgs e)
        {
            display.MoveAll(lbxLinesFound, lbxLinesToRemove);
        }

        private void btnRemoveToFoundAll_Click(object sender, EventArgs e)
        {
            display.MoveAll(lbxLinesToRemove, lbxLinesFound);
        }

        private void btnRemoveText_Click(object sender, EventArgs e)
        {
            tbOutputWindow.Clear();
            if (bwRemoveLines.IsBusy == false)
            {
                bwRemoveLines.RunWorkerAsync();
            }
        }

        private List<Line> searchForRepeats(BackgroundWorker worker, DoWorkEventArgs e)
        {
            handler = new FileHandler(tbFileInput.Text);
            return handler.GetRepeatedLines(worker);
        }

        private void removeLines(BackgroundWorker worker, DoWorkEventArgs e)
        {
            handler = new FileHandler(tbFileInput.Text);
            List<Line> lines = lbxLinesToRemove.Items.Cast<Line>().ToList(); // this is ALL items from list
            handler.RemoveLinesFromFiles(lines);
        }

        private void bwRepeatedSearch_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            e.Result = searchForRepeats(worker, e);
        }

        private void bwRepeatedSearch_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            display.AddLinesToListBox(lbxLinesFound, (List<Line>)e.Result);
        }

        private void bwRepeatedSearch_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            int completion = e.ProgressPercentage;
            pbRepeatedSearchProgress.Value = completion;
        }

        private void bwRemoveLines_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            removeLines(worker, e);
        }

        private void bwRemoveLines_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            display.RemoveLinesFromListBox(lbxLinesToRemove, true);
        }

        private void bwRemoveLines_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
        }
    }
}
