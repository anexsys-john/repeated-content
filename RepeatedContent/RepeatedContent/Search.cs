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
            List<RepeatedLine> lines = Handler.GetRepeatedLines(worker, (Int32)nudMinimumLineCount.Value);
            return lines;
        }

        private void removeLines(BackgroundWorker worker, DoWorkEventArgs e)
        {
            Reporter.Refresh();
            Handler = new FileHandler(tbFileInput.Text, Reporter);
            List<RepeatedLine> lines = lbxLinesToRemove.Items.Cast<RepeatedLine>().ToList(); // this is ALL items from list
            List<Line> removedLines = Handler.RemoveLinesFromFiles(worker, lines);
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
            foreach (Line removedLine in (List<Line>)e.Result)
            {
                int length = removedLine.Content.Length;
                int cutOff = 50;
                bool truncated = length > cutOff;
                string ellipsis = (truncated ? "..." : "");
                message += $"[{removedLine.Content.Substring(0, (truncated ? cutOff : length - 1))}{ellipsis}] has been removed from file [{removedLine.ParentFile}]";
                message += Environment.NewLine;
            }
            Display.AppendMessage(rtbOutput, message, "success");
        }

        private void bwRemoveLines_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            int completion = e.ProgressPercentage;
            pbRepeatedSearchProgress.Value = completion;
        }

        private void sortFoundLines()
        {
            if (cbxAlphaPriority.Checked)
            {
                if (cbxAlphaAscending.Checked)
                {
                    if(cbxNumericAscending.Checked)
                    {
                        lbxLinesFound.SortBy<RepeatedLine>(line => line.Content).ThenSortBy(line => line.Count, lbxLinesFound);
                    }
                    else
                    {
                        lbxLinesFound.SortBy<RepeatedLine>(line => line.Content).ThenSortByDescending(line => line.Count, lbxLinesFound);
                    }
                }
                else
                {
                    if(cbxNumericAscending.Checked)
                    {
                        lbxLinesFound.SortByDescending<RepeatedLine>(line => line.Content).ThenSortBy(line => line.Count, lbxLinesFound);
                    }
                    else
                    {
                        lbxLinesFound.SortByDescending<RepeatedLine>(line => line.Content).ThenSortByDescending(line => line.Count, lbxLinesFound);
                    }
                }
            }
            else
            {
                if (cbxAlphaAscending.Checked)
                {
                    if(cbxNumericAscending.Checked)
                    {
                        lbxLinesFound.SortBy<RepeatedLine>(line => line.Count).ThenSortBy(line => line.Content, lbxLinesFound);
                    }
                    else
                    {
                        lbxLinesFound.SortByDescending<RepeatedLine>(line => line.Count).ThenSortBy(line => line.Content, lbxLinesFound);
                    }
                }
                else
                {
                    if(cbxNumericAscending.Checked)
                    {
                        lbxLinesFound.SortBy<RepeatedLine>(line => line.Count).ThenSortByDescending(line => line.Content, lbxLinesFound);
                    }
                    else
                    {
                        lbxLinesFound.SortByDescending<RepeatedLine>(line => line.Count).ThenSortByDescending(line => line.Content, lbxLinesFound);
                    }
                }
            }
        }

        private void cbxAlphaAscendingFound_Click(object sender, EventArgs e)
        {
            cbxAlphaAscending.Checked = !cbxAlphaAscending.Checked;
            if (!cbxAlphaAscending.Checked)
            {
                cbxAlphaDescending.Checked = false;
                cbxAlphaAscending.Checked = true;
                sortFoundLines();
            }
        }

        private void cbxAlphaDescendingFound_Click(object sender, EventArgs e)
        {
            cbxAlphaDescending.Checked = !cbxAlphaDescending.Checked;
            if (!cbxAlphaDescending.Checked)
            {
                cbxAlphaAscending.Checked = false;
                cbxAlphaDescending.Checked = true;
                sortFoundLines();
            }
        }

        private void cbxNumericAscendingFound_Click(object sender, EventArgs e)
        {
            cbxNumericAscending.Checked = !cbxNumericAscending.Checked;
            if (!cbxNumericAscending.Checked)
            {
                cbxNumericDescending.Checked = false;
                cbxNumericAscending.Checked = true;
                sortFoundLines();
            }
        }

        private void cbxNumericDescendingFound_Click(object sender, EventArgs e)
        {
            cbxNumericDescending.Checked = !cbxNumericDescending.Checked;
            if (!cbxNumericDescending.Checked)
            {
                cbxNumericAscending.Checked = false;
                cbxNumericDescending.Checked = true;
                sortFoundLines();
            }
        }

        private void cbxAlphaPriority_Click(object sender, EventArgs e)
        {
            cbxAlphaPriority.Checked = !cbxAlphaPriority.Checked;
            if (!cbxAlphaPriority.Checked)
            {
                cbxNumericPriority.Checked = false;
                cbxAlphaPriority.Checked = true;
                cbxNumericPriority.Text = "Secondary";
                cbxAlphaPriority.Text = "Primary";
                sortFoundLines();
            }
        }

        private void cbxNumericPriority_Click(object sender, EventArgs e)
        {
            cbxNumericPriority.Checked = !cbxNumericPriority.Checked;
            if (!cbxNumericPriority.Checked)
            {
                cbxAlphaPriority.Checked = false;
                cbxNumericPriority.Checked = true;
                cbxAlphaPriority.Text = "Secondary";
                cbxNumericPriority.Text = "Primary";
                sortFoundLines();
            }
        }
    }
}
