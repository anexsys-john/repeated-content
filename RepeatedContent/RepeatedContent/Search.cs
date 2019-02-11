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
            display.ClearListBox(lbxLinesFound);
            display.ClearListBox(lbxLinesToRemove);
            string message = $"Searching for repeated lines in {tbFileInput.Text}";
            display.AppendOutputMessage(tbOutputWindow, message);
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
            //tbOutputWindow.Clear();
            if (bwRemoveLines.IsBusy == false)
            {
                bwRemoveLines.RunWorkerAsync();
            }
        }

        private void btnRemoveHeaders_Click(object sender, EventArgs e)
        {
            if (bwRemoveHeaders.IsBusy == false)
            {
                bwRemoveHeaders.RunWorkerAsync();
            }
        }

        private List<Line> searchForRepeats(BackgroundWorker worker, DoWorkEventArgs e)
        {
            handler = new FileHandler(tbFileInput.Text);
            return handler.GetRepeatedLines(worker, (Int32)nudMinimumLineCount.Value);
        }

        private void removeLines(BackgroundWorker worker, DoWorkEventArgs e)
        {
            handler = new FileHandler(tbFileInput.Text);
            List<Line> lines = lbxLinesToRemove.Items.Cast<Line>().ToList(); // this is ALL items from list
            List<RemovedLine> removedLines = handler.RemoveLinesFromFiles(worker, lines);
            e.Result = removedLines;
        }

        private void bwRepeatedSearch_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            e.Result = searchForRepeats(worker, e);
        }

        private void bwRepeatedSearch_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            display.AddLinesToListBox(lbxLinesFound, (List<Line>)e.Result);
            string message = $"Finished searching {tbFileInput.Text}";
            display.AppendOutputMessage(tbOutputWindow, message);
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
            string message = "";
            foreach (RemovedLine removedLine in (List<RemovedLine>)e.Result)
            {
                int length = removedLine.Line.Length;
                int cutOff = 50;
                bool truncated = length > cutOff;
                string ellipsis = (truncated ? "..." : "");
                message += $"[{removedLine.Line.Substring(0, (truncated ? cutOff : length - 1))}{ellipsis}] has been removed from file [{removedLine.File}]";
                message += Environment.NewLine;
            }
            display.AppendOutputMessage(tbOutputWindow, message);
        }

        private void bwRemoveLines_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            int completion = e.ProgressPercentage;
            pbRepeatedSearchProgress.Value = completion;
        }
    }
}
