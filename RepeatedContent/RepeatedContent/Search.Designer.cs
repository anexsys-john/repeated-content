namespace RepeatedContent
{
    partial class Search
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbFileInput = new System.Windows.Forms.TextBox();
            this.bwRepeatedSearch = new System.ComponentModel.BackgroundWorker();
            this.pbRepeatedSearchProgress = new System.Windows.Forms.ProgressBar();
            this.btnRemoveText = new System.Windows.Forms.Button();
            this.btnDirectorySearch = new System.Windows.Forms.Button();
            this.bwRemoveLines = new System.ComponentModel.BackgroundWorker();
            this.lbxLinesFound = new System.Windows.Forms.ListBox();
            this.lbxLinesToRemove = new System.Windows.Forms.ListBox();
            this.btnFoundToRemove = new System.Windows.Forms.Button();
            this.btnFoundToRemoveAll = new System.Windows.Forms.Button();
            this.btnRemoveToFound = new System.Windows.Forms.Button();
            this.btnRemoveToFoundAll = new System.Windows.Forms.Button();
            this.nudMinimumLineCount = new System.Windows.Forms.NumericUpDown();
            this.lbMinimumLineCount = new System.Windows.Forms.Label();
            this.lbLinesFound = new System.Windows.Forms.Label();
            this.lbLinesToRemove = new System.Windows.Forms.Label();
            this.lbOutput = new System.Windows.Forms.Label();
            this.bwRemoveHeaders = new System.ComponentModel.BackgroundWorker();
            this.rtbOutput = new System.Windows.Forms.RichTextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.cbxAlphaAscending = new System.Windows.Forms.CheckBox();
            this.cbxAlphaDescending = new System.Windows.Forms.CheckBox();
            this.cbxNumericAscending = new System.Windows.Forms.CheckBox();
            this.cbxNumericDescending = new System.Windows.Forms.CheckBox();
            this.cbxNumericPriority = new System.Windows.Forms.CheckBox();
            this.cbxAlphaPriority = new System.Windows.Forms.CheckBox();
            this.btnExportToCSV = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinimumLineCount)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(534, 11);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(262, 23);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Search for Repeated Content and Remove Headers";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tbFileInput
            // 
            this.tbFileInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFileInput.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbFileInput.Location = new System.Drawing.Point(12, 12);
            this.tbFileInput.Name = "tbFileInput";
            this.tbFileInput.Size = new System.Drawing.Size(314, 20);
            this.tbFileInput.TabIndex = 1;
            this.tbFileInput.Text = "Input Directory Here...";
            this.tbFileInput.Enter += new System.EventHandler(this.tbFileInput_Enter);
            this.tbFileInput.Leave += new System.EventHandler(this.tbfileInput_Leave);
            // 
            // bwRepeatedSearch
            // 
            this.bwRepeatedSearch.WorkerReportsProgress = true;
            this.bwRepeatedSearch.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwRepeatedSearch_DoWork);
            this.bwRepeatedSearch.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bwRepeatedSearch_ProgressChanged);
            this.bwRepeatedSearch.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwRepeatedSearch_RunWorkerCompleted);
            // 
            // pbRepeatedSearchProgress
            // 
            this.pbRepeatedSearchProgress.Location = new System.Drawing.Point(12, 40);
            this.pbRepeatedSearchProgress.Name = "pbRepeatedSearchProgress";
            this.pbRepeatedSearchProgress.Size = new System.Drawing.Size(784, 35);
            this.pbRepeatedSearchProgress.TabIndex = 3;
            // 
            // btnRemoveText
            // 
            this.btnRemoveText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveText.Location = new System.Drawing.Point(701, 80);
            this.btnRemoveText.Name = "btnRemoveText";
            this.btnRemoveText.Size = new System.Drawing.Size(95, 22);
            this.btnRemoveText.TabIndex = 5;
            this.btnRemoveText.Text = "Remove Lines";
            this.btnRemoveText.UseVisualStyleBackColor = true;
            this.btnRemoveText.Click += new System.EventHandler(this.btnRemoveText_Click);
            // 
            // btnDirectorySearch
            // 
            this.btnDirectorySearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDirectorySearch.Location = new System.Drawing.Point(332, 12);
            this.btnDirectorySearch.Name = "btnDirectorySearch";
            this.btnDirectorySearch.Size = new System.Drawing.Size(26, 20);
            this.btnDirectorySearch.TabIndex = 6;
            this.btnDirectorySearch.Text = "...";
            this.btnDirectorySearch.UseVisualStyleBackColor = true;
            this.btnDirectorySearch.Click += new System.EventHandler(this.btnDirectorySearch_Click);
            // 
            // bwRemoveLines
            // 
            this.bwRemoveLines.WorkerReportsProgress = true;
            this.bwRemoveLines.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwRemoveLines_DoWork);
            this.bwRemoveLines.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bwRemoveLines_ProgressChanged);
            this.bwRemoveLines.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwRemoveLines_RunWorkerCompleted);
            // 
            // lbxLinesFound
            // 
            this.lbxLinesFound.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxLinesFound.FormattingEnabled = true;
            this.lbxLinesFound.HorizontalScrollbar = true;
            this.lbxLinesFound.Location = new System.Drawing.Point(12, 105);
            this.lbxLinesFound.Name = "lbxLinesFound";
            this.lbxLinesFound.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbxLinesFound.Size = new System.Drawing.Size(360, 277);
            this.lbxLinesFound.TabIndex = 8;
            // 
            // lbxLinesToRemove
            // 
            this.lbxLinesToRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxLinesToRemove.FormattingEnabled = true;
            this.lbxLinesToRemove.HorizontalScrollbar = true;
            this.lbxLinesToRemove.Location = new System.Drawing.Point(436, 105);
            this.lbxLinesToRemove.Name = "lbxLinesToRemove";
            this.lbxLinesToRemove.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbxLinesToRemove.Size = new System.Drawing.Size(360, 277);
            this.lbxLinesToRemove.TabIndex = 9;
            // 
            // btnFoundToRemove
            // 
            this.btnFoundToRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFoundToRemove.Location = new System.Drawing.Point(378, 207);
            this.btnFoundToRemove.Name = "btnFoundToRemove";
            this.btnFoundToRemove.Size = new System.Drawing.Size(52, 45);
            this.btnFoundToRemove.TabIndex = 10;
            this.btnFoundToRemove.Text = ">";
            this.btnFoundToRemove.UseVisualStyleBackColor = true;
            this.btnFoundToRemove.Click += new System.EventHandler(this.btnFoundToRemove_Click);
            // 
            // btnFoundToRemoveAll
            // 
            this.btnFoundToRemoveAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFoundToRemoveAll.Location = new System.Drawing.Point(378, 258);
            this.btnFoundToRemoveAll.Name = "btnFoundToRemoveAll";
            this.btnFoundToRemoveAll.Size = new System.Drawing.Size(52, 45);
            this.btnFoundToRemoveAll.TabIndex = 11;
            this.btnFoundToRemoveAll.Text = ">>";
            this.btnFoundToRemoveAll.UseVisualStyleBackColor = true;
            this.btnFoundToRemoveAll.Click += new System.EventHandler(this.btnFoundToRemoveAll_Click);
            // 
            // btnRemoveToFound
            // 
            this.btnRemoveToFound.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveToFound.Location = new System.Drawing.Point(378, 156);
            this.btnRemoveToFound.Name = "btnRemoveToFound";
            this.btnRemoveToFound.Size = new System.Drawing.Size(52, 45);
            this.btnRemoveToFound.TabIndex = 12;
            this.btnRemoveToFound.Text = "<";
            this.btnRemoveToFound.UseVisualStyleBackColor = true;
            this.btnRemoveToFound.Click += new System.EventHandler(this.btnRemoveToFound_Click);
            // 
            // btnRemoveToFoundAll
            // 
            this.btnRemoveToFoundAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveToFoundAll.Location = new System.Drawing.Point(378, 105);
            this.btnRemoveToFoundAll.Name = "btnRemoveToFoundAll";
            this.btnRemoveToFoundAll.Size = new System.Drawing.Size(52, 45);
            this.btnRemoveToFoundAll.TabIndex = 13;
            this.btnRemoveToFoundAll.Text = "<<";
            this.btnRemoveToFoundAll.UseVisualStyleBackColor = true;
            this.btnRemoveToFoundAll.Click += new System.EventHandler(this.btnRemoveToFoundAll_Click);
            // 
            // nudMinimumLineCount
            // 
            this.nudMinimumLineCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudMinimumLineCount.Location = new System.Drawing.Point(374, 12);
            this.nudMinimumLineCount.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudMinimumLineCount.Name = "nudMinimumLineCount";
            this.nudMinimumLineCount.Size = new System.Drawing.Size(46, 20);
            this.nudMinimumLineCount.TabIndex = 14;
            this.nudMinimumLineCount.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // lbMinimumLineCount
            // 
            this.lbMinimumLineCount.AutoSize = true;
            this.lbMinimumLineCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMinimumLineCount.Location = new System.Drawing.Point(426, 16);
            this.lbMinimumLineCount.Name = "lbMinimumLineCount";
            this.lbMinimumLineCount.Size = new System.Drawing.Size(102, 13);
            this.lbMinimumLineCount.TabIndex = 15;
            this.lbMinimumLineCount.Text = "Minimum Line Count";
            // 
            // lbLinesFound
            // 
            this.lbLinesFound.AutoSize = true;
            this.lbLinesFound.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLinesFound.Location = new System.Drawing.Point(12, 86);
            this.lbLinesFound.Name = "lbLinesFound";
            this.lbLinesFound.Size = new System.Drawing.Size(92, 16);
            this.lbLinesFound.TabIndex = 16;
            this.lbLinesFound.Text = "Lines Found";
            // 
            // lbLinesToRemove
            // 
            this.lbLinesToRemove.AutoSize = true;
            this.lbLinesToRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLinesToRemove.Location = new System.Drawing.Point(436, 86);
            this.lbLinesToRemove.Name = "lbLinesToRemove";
            this.lbLinesToRemove.Size = new System.Drawing.Size(130, 16);
            this.lbLinesToRemove.TabIndex = 17;
            this.lbLinesToRemove.Text = "Lines To Remove";
            // 
            // lbOutput
            // 
            this.lbOutput.AutoSize = true;
            this.lbOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOutput.Location = new System.Drawing.Point(12, 448);
            this.lbOutput.Name = "lbOutput";
            this.lbOutput.Size = new System.Drawing.Size(52, 16);
            this.lbOutput.TabIndex = 18;
            this.lbOutput.Text = "Output";
            // 
            // rtbOutput
            // 
            this.rtbOutput.Location = new System.Drawing.Point(12, 467);
            this.rtbOutput.Name = "rtbOutput";
            this.rtbOutput.ReadOnly = true;
            this.rtbOutput.Size = new System.Drawing.Size(784, 164);
            this.rtbOutput.TabIndex = 19;
            this.rtbOutput.Text = "";
            this.rtbOutput.TextChanged += new System.EventHandler(this.rtbOutput_TextChanged);
            // 
            // cbxAlphaAscending
            // 
            this.cbxAlphaAscending.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbxAlphaAscending.AutoSize = true;
            this.cbxAlphaAscending.Checked = true;
            this.cbxAlphaAscending.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxAlphaAscending.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbxAlphaAscending.Location = new System.Drawing.Point(299, 382);
            this.cbxAlphaAscending.Name = "cbxAlphaAscending";
            this.cbxAlphaAscending.Size = new System.Drawing.Size(37, 23);
            this.cbxAlphaAscending.TabIndex = 20;
            this.cbxAlphaAscending.Text = "A..Z";
            this.cbxAlphaAscending.UseVisualStyleBackColor = true;
            this.cbxAlphaAscending.Click += new System.EventHandler(this.cbxAlphaAscendingFound_Click);
            // 
            // cbxAlphaDescending
            // 
            this.cbxAlphaDescending.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbxAlphaDescending.AutoSize = true;
            this.cbxAlphaDescending.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbxAlphaDescending.Location = new System.Drawing.Point(335, 382);
            this.cbxAlphaDescending.Name = "cbxAlphaDescending";
            this.cbxAlphaDescending.Size = new System.Drawing.Size(37, 23);
            this.cbxAlphaDescending.TabIndex = 21;
            this.cbxAlphaDescending.Text = "Z..A";
            this.cbxAlphaDescending.UseVisualStyleBackColor = true;
            this.cbxAlphaDescending.Click += new System.EventHandler(this.cbxAlphaDescendingFound_Click);
            // 
            // cbxNumericAscending
            // 
            this.cbxNumericAscending.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbxNumericAscending.AutoSize = true;
            this.cbxNumericAscending.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbxNumericAscending.Location = new System.Drawing.Point(12, 382);
            this.cbxNumericAscending.Name = "cbxNumericAscending";
            this.cbxNumericAscending.Size = new System.Drawing.Size(44, 23);
            this.cbxNumericAscending.TabIndex = 22;
            this.cbxNumericAscending.Text = "123...";
            this.cbxNumericAscending.UseVisualStyleBackColor = true;
            this.cbxNumericAscending.Click += new System.EventHandler(this.cbxNumericAscendingFound_Click);
            // 
            // cbxNumericDescending
            // 
            this.cbxNumericDescending.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbxNumericDescending.AutoSize = true;
            this.cbxNumericDescending.Checked = true;
            this.cbxNumericDescending.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxNumericDescending.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbxNumericDescending.Location = new System.Drawing.Point(55, 382);
            this.cbxNumericDescending.Name = "cbxNumericDescending";
            this.cbxNumericDescending.Size = new System.Drawing.Size(44, 23);
            this.cbxNumericDescending.TabIndex = 23;
            this.cbxNumericDescending.Text = "...321";
            this.cbxNumericDescending.UseVisualStyleBackColor = true;
            this.cbxNumericDescending.Click += new System.EventHandler(this.cbxNumericDescendingFound_Click);
            // 
            // cbxNumericPriority
            // 
            this.cbxNumericPriority.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbxNumericPriority.AutoSize = true;
            this.cbxNumericPriority.Checked = true;
            this.cbxNumericPriority.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxNumericPriority.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbxNumericPriority.Location = new System.Drawing.Point(12, 404);
            this.cbxNumericPriority.Name = "cbxNumericPriority";
            this.cbxNumericPriority.Size = new System.Drawing.Size(51, 23);
            this.cbxNumericPriority.TabIndex = 25;
            this.cbxNumericPriority.Text = "Primary";
            this.cbxNumericPriority.UseVisualStyleBackColor = true;
            this.cbxNumericPriority.Click += new System.EventHandler(this.cbxNumericPriority_Click);
            // 
            // cbxAlphaPriority
            // 
            this.cbxAlphaPriority.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbxAlphaPriority.AutoSize = true;
            this.cbxAlphaPriority.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbxAlphaPriority.Location = new System.Drawing.Point(299, 404);
            this.cbxAlphaPriority.Name = "cbxAlphaPriority";
            this.cbxAlphaPriority.Size = new System.Drawing.Size(68, 23);
            this.cbxAlphaPriority.TabIndex = 24;
            this.cbxAlphaPriority.Text = "Secondary";
            this.cbxAlphaPriority.UseVisualStyleBackColor = true;
            this.cbxAlphaPriority.Click += new System.EventHandler(this.cbxAlphaPriority_Click);
            // 
            // btnExportToCSV
            // 
            this.btnExportToCSV.Enabled = false;
            this.btnExportToCSV.Location = new System.Drawing.Point(701, 388);
            this.btnExportToCSV.Name = "btnExportToCSV";
            this.btnExportToCSV.Size = new System.Drawing.Size(94, 23);
            this.btnExportToCSV.TabIndex = 26;
            this.btnExportToCSV.Text = "Export to CSV";
            this.btnExportToCSV.UseVisualStyleBackColor = true;
            this.btnExportToCSV.Click += new System.EventHandler(this.btnExportToCSV_Click);
            // 
            // Search
            // 
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1196, 643);
            this.Controls.Add(this.btnExportToCSV);
            this.Controls.Add(this.cbxNumericPriority);
            this.Controls.Add(this.cbxAlphaPriority);
            this.Controls.Add(this.cbxNumericDescending);
            this.Controls.Add(this.cbxNumericAscending);
            this.Controls.Add(this.cbxAlphaDescending);
            this.Controls.Add(this.cbxAlphaAscending);
            this.Controls.Add(this.rtbOutput);
            this.Controls.Add(this.lbOutput);
            this.Controls.Add(this.lbLinesToRemove);
            this.Controls.Add(this.lbLinesFound);
            this.Controls.Add(this.lbMinimumLineCount);
            this.Controls.Add(this.nudMinimumLineCount);
            this.Controls.Add(this.btnRemoveToFoundAll);
            this.Controls.Add(this.btnRemoveToFound);
            this.Controls.Add(this.btnFoundToRemove);
            this.Controls.Add(this.lbxLinesToRemove);
            this.Controls.Add(this.lbxLinesFound);
            this.Controls.Add(this.btnDirectorySearch);
            this.Controls.Add(this.btnRemoveText);
            this.Controls.Add(this.pbRepeatedSearchProgress);
            this.Controls.Add(this.tbFileInput);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnFoundToRemoveAll);
            this.Name = "Search";
            this.Text = "Repeated Line Remover";
            ((System.ComponentModel.ISupportInitialize)(this.nudMinimumLineCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox tbFileInput;
        private System.ComponentModel.BackgroundWorker bwRepeatedSearch;
        private System.Windows.Forms.ProgressBar pbRepeatedSearchProgress;
        private System.Windows.Forms.Button btnRemoveText;
        private System.Windows.Forms.Button btnDirectorySearch;
        private System.ComponentModel.BackgroundWorker bwRemoveLines;
        private System.Windows.Forms.ListBox lbxLinesFound;
        private System.Windows.Forms.ListBox lbxLinesToRemove;
        private System.Windows.Forms.Button btnFoundToRemove;
        private System.Windows.Forms.Button btnFoundToRemoveAll;
        private System.Windows.Forms.Button btnRemoveToFound;
        private System.Windows.Forms.Button btnRemoveToFoundAll;
        private System.Windows.Forms.NumericUpDown nudMinimumLineCount;
        private System.Windows.Forms.Label lbMinimumLineCount;
        private System.Windows.Forms.Label lbLinesFound;
        private System.Windows.Forms.Label lbLinesToRemove;
        private System.Windows.Forms.Label lbOutput;
        private System.ComponentModel.BackgroundWorker bwRemoveHeaders;
        private System.Windows.Forms.RichTextBox rtbOutput;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.CheckBox cbxAlphaAscending;
        private System.Windows.Forms.CheckBox cbxAlphaDescending;
        private System.Windows.Forms.CheckBox cbxNumericAscending;
        private System.Windows.Forms.CheckBox cbxNumericDescending;
        private System.Windows.Forms.CheckBox cbxNumericPriority;
        private System.Windows.Forms.CheckBox cbxAlphaPriority;
        private System.Windows.Forms.Button btnExportToCSV;
    }
}

