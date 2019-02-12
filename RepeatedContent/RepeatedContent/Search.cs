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
        private FileHandler Handler;
        private Display Display;
        private ErrorReporter Reporter;

        public Search()
        {
            InitializeComponent();
            Display = new Display();
            Reporter = new ErrorReporter();
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
            Display.ClearListBox(lbxLinesFound);
            Display.ClearListBox(lbxLinesToRemove);
            string message = $"Searching for repeated lines in {tbFileInput.Text}";
            Display.AppendMessage(rtbOutput, message);
            if (bwRepeatedSearch.IsBusy == false)
            {
                bwRepeatedSearch.RunWorkerAsync();
            }
        }

        private void btnFoundToRemove_Click(object sender, EventArgs e)
        {
            Display.MoveSelection(lbxLinesFound, lbxLinesToRemove);
        }

        private void btnRemoveToFound_Click(object sender, EventArgs e)
        {
            Display.MoveSelection(lbxLinesToRemove, lbxLinesFound);
        }

        private void btnFoundToRemoveAll_Click(object sender, EventArgs e)
        {
            Display.MoveAll(lbxLinesFound, lbxLinesToRemove);
        }

        private void btnRemoveToFoundAll_Click(object sender, EventArgs e)
        {
            Display.MoveAll(lbxLinesToRemove, lbxLinesFound);
        }

        private void btnRemoveText_Click(object sender, EventArgs e)
        {
            string message = "Removing selected lines from all files";
            Display.AppendMessage(rtbOutput, message);
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

        private void rtbOutput_TextChanged(object sender, EventArgs e)
        {
            rtbOutput.SelectionStart = rtbOutput.Text.Length;
            rtbOutput.ScrollToCaret();
        }

        private List<RepeatedLine> searchForRepeats(BackgroundWorker worker, DoWorkEventArgs e)
        {
            Reporter.Refresh();
            Handler = new FileHandler(tbFileInput.Text, Reporter);
            return Handler.GetRepeatedLines(worker, (Int32)nudMinimumLineCount.Value);
        }

        private void removeLines(BackgroundWorker worker, DoWorkEventArgs e)
        {
            Reporter.Refresh();
            Handler = new FileHandler(tbFileInput.Text, Reporter);
            List<RepeatedLine> lines = lbxLinesToRemove.Items.Cast<RepeatedLine>().ToList(); // this is ALL items from list
            List<RemovedLine> removedLines = Handler.RemoveLinesFromFiles(worker, lines);
            e.Result = removedLines;
        }

        private void bwRepeatedSearch_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            e.Result = searchForRepeats(worker, e);
        }

        private void bwRepeatedSearch_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (Reporter.HasError)
            {
                Display.AppendMessage(rtbOutput, Reporter.Message, "error");
            }
            else
            {
                Display.AddLinesToListBox(lbxLinesFound, (List<RepeatedLine>)e.Result);
                string message = $"Finished searching {tbFileInput.Text}";
                Display.AppendMessage(rtbOutput, message, "success");
            }
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
            Display.RemoveLinesFromListBox(lbxLinesToRemove, true);
            string message = "";
            foreach (RemovedLine removedLine in (List<RemovedLine>)e.Result)
            {
                int length = removedLine.Content.Length;
                int cutOff = 50;
                bool truncated = length > cutOff;
                string ellipsis = (truncated ? "..." : "");
                message += $"[{removedLine.Content.Substring(0, (truncated ? cutOff : length - 1))}{ellipsis}] has been removed from file [{removedLine.File}]";
                message += Environment.NewLine;
            }
            Display.AppendMessage(rtbOutput, message, "success");
        }

        private void bwRemoveLines_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            int completion = e.ProgressPercentage;
            pbRepeatedSearchProgress.Value = completion;
        }
    }
}
