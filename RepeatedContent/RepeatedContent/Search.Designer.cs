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
            this.tbOutputWindow = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(498, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(298, 38);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Search for Repeated Content";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tbFileInput
            // 
            this.tbFileInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFileInput.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbFileInput.Location = new System.Drawing.Point(12, 12);
            this.tbFileInput.Name = "tbFileInput";
            this.tbFileInput.Size = new System.Drawing.Size(411, 38);
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
            this.pbRepeatedSearchProgress.Location = new System.Drawing.Point(12, 56);
            this.pbRepeatedSearchProgress.Name = "pbRepeatedSearchProgress";
            this.pbRepeatedSearchProgress.Size = new System.Drawing.Size(784, 35);
            this.pbRepeatedSearchProgress.TabIndex = 3;
            // 
            // btnRemoveText
            // 
            this.btnRemoveText.Location = new System.Drawing.Point(579, 386);
            this.btnRemoveText.Name = "btnRemoveText";
            this.btnRemoveText.Size = new System.Drawing.Size(217, 37);
            this.btnRemoveText.TabIndex = 5;
            this.btnRemoveText.Text = "Remove Text";
            this.btnRemoveText.UseVisualStyleBackColor = true;
            this.btnRemoveText.Click += new System.EventHandler(this.btnRemoveText_Click);
            // 
            // btnDirectorySearch
            // 
            this.btnDirectorySearch.Location = new System.Drawing.Point(436, 12);
            this.btnDirectorySearch.Name = "btnDirectorySearch";
            this.btnDirectorySearch.Size = new System.Drawing.Size(56, 38);
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
            this.lbxLinesFound.FormattingEnabled = true;
            this.lbxLinesFound.ItemHeight = 31;
            this.lbxLinesFound.Location = new System.Drawing.Point(12, 97);
            this.lbxLinesFound.Name = "lbxLinesFound";
            this.lbxLinesFound.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbxLinesFound.Size = new System.Drawing.Size(360, 283);
            this.lbxLinesFound.TabIndex = 8;
            // 
            // lbxLinesToRemove
            // 
            this.lbxLinesToRemove.FormattingEnabled = true;
            this.lbxLinesToRemove.ItemHeight = 31;
            this.lbxLinesToRemove.Location = new System.Drawing.Point(436, 97);
            this.lbxLinesToRemove.Name = "lbxLinesToRemove";
            this.lbxLinesToRemove.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbxLinesToRemove.Size = new System.Drawing.Size(360, 283);
            this.lbxLinesToRemove.TabIndex = 9;
            // 
            // btnFoundToRemove
            // 
            this.btnFoundToRemove.Location = new System.Drawing.Point(378, 199);
            this.btnFoundToRemove.Name = "btnFoundToRemove";
            this.btnFoundToRemove.Size = new System.Drawing.Size(52, 45);
            this.btnFoundToRemove.TabIndex = 10;
            this.btnFoundToRemove.Text = ">";
            this.btnFoundToRemove.UseVisualStyleBackColor = true;
            this.btnFoundToRemove.Click += new System.EventHandler(this.btnFoundToRemove_Click);
            // 
            // btnFoundToRemoveAll
            // 
            this.btnFoundToRemoveAll.Location = new System.Drawing.Point(378, 250);
            this.btnFoundToRemoveAll.Name = "btnFoundToRemoveAll";
            this.btnFoundToRemoveAll.Size = new System.Drawing.Size(52, 45);
            this.btnFoundToRemoveAll.TabIndex = 11;
            this.btnFoundToRemoveAll.Text = ">>";
            this.btnFoundToRemoveAll.UseVisualStyleBackColor = true;
            this.btnFoundToRemoveAll.Click += new System.EventHandler(this.btnFoundToRemoveAll_Click);
            // 
            // btnRemoveToFound
            // 
            this.btnRemoveToFound.Location = new System.Drawing.Point(378, 148);
            this.btnRemoveToFound.Name = "btnRemoveToFound";
            this.btnRemoveToFound.Size = new System.Drawing.Size(52, 45);
            this.btnRemoveToFound.TabIndex = 12;
            this.btnRemoveToFound.Text = "<";
            this.btnRemoveToFound.UseVisualStyleBackColor = true;
            this.btnRemoveToFound.Click += new System.EventHandler(this.btnRemoveToFound_Click);
            // 
            // btnRemoveToFoundAll
            // 
            this.btnRemoveToFoundAll.Location = new System.Drawing.Point(378, 97);
            this.btnRemoveToFoundAll.Name = "btnRemoveToFoundAll";
            this.btnRemoveToFoundAll.Size = new System.Drawing.Size(52, 45);
            this.btnRemoveToFoundAll.TabIndex = 13;
            this.btnRemoveToFoundAll.Text = "<<";
            this.btnRemoveToFoundAll.UseVisualStyleBackColor = true;
            this.btnRemoveToFoundAll.Click += new System.EventHandler(this.btnRemoveToFoundAll_Click);
            // 
            // tbOutputWindow
            // 
            this.tbOutputWindow.Location = new System.Drawing.Point(12, 429);
            this.tbOutputWindow.Multiline = true;
            this.tbOutputWindow.Name = "tbOutputWindow";
            this.tbOutputWindow.ReadOnly = true;
            this.tbOutputWindow.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbOutputWindow.Size = new System.Drawing.Size(784, 131);
            this.tbOutputWindow.TabIndex = 2;
            // 
            // Search
            // 
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1196, 643);
            this.Controls.Add(this.btnRemoveToFoundAll);
            this.Controls.Add(this.btnRemoveToFound);
            this.Controls.Add(this.btnFoundToRemoveAll);
            this.Controls.Add(this.btnFoundToRemove);
            this.Controls.Add(this.lbxLinesToRemove);
            this.Controls.Add(this.lbxLinesFound);
            this.Controls.Add(this.btnDirectorySearch);
            this.Controls.Add(this.btnRemoveText);
            this.Controls.Add(this.pbRepeatedSearchProgress);
            this.Controls.Add(this.tbOutputWindow);
            this.Controls.Add(this.tbFileInput);
            this.Controls.Add(this.btnSearch);
            this.Name = "Search";
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
        private System.Windows.Forms.TextBox tbOutputWindow;
    }
}

