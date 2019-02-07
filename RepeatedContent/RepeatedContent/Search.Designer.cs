﻿namespace RepeatedContent
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
            this.tbOutputWindow = new System.Windows.Forms.TextBox();
            this.bwRepeatedSearch = new System.ComponentModel.BackgroundWorker();
            this.pbRepeatedSearchProgress = new System.Windows.Forms.ProgressBar();
            this.btnRemoveText = new System.Windows.Forms.Button();
            this.btnDirectorySearch = new System.Windows.Forms.Button();
            this.tbRemoveTextInput = new System.Windows.Forms.TextBox();
            this.bwRemoveLines = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(681, 14);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(418, 38);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Search for Repeated Content";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tbFileInput
            // 
            this.tbFileInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFileInput.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbFileInput.Location = new System.Drawing.Point(12, 14);
            this.tbFileInput.Name = "tbFileInput";
            this.tbFileInput.Size = new System.Drawing.Size(591, 38);
            this.tbFileInput.TabIndex = 1;
            this.tbFileInput.Text = "Input Directory Here...";
            this.tbFileInput.Enter += new System.EventHandler(this.tbFileInput_Enter);
            this.tbFileInput.Leave += new System.EventHandler(this.tbfileInput_Leave);
            // 
            // tbOutputWindow
            // 
            this.tbOutputWindow.Location = new System.Drawing.Point(12, 99);
            this.tbOutputWindow.Multiline = true;
            this.tbOutputWindow.Name = "tbOutputWindow";
            this.tbOutputWindow.ReadOnly = true;
            this.tbOutputWindow.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbOutputWindow.Size = new System.Drawing.Size(1087, 131);
            this.tbOutputWindow.TabIndex = 2;
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
            this.pbRepeatedSearchProgress.Location = new System.Drawing.Point(12, 58);
            this.pbRepeatedSearchProgress.Name = "pbRepeatedSearchProgress";
            this.pbRepeatedSearchProgress.Size = new System.Drawing.Size(1087, 35);
            this.pbRepeatedSearchProgress.TabIndex = 3;
            // 
            // btnRemoveText
            // 
            this.btnRemoveText.Location = new System.Drawing.Point(681, 428);
            this.btnRemoveText.Name = "btnRemoveText";
            this.btnRemoveText.Size = new System.Drawing.Size(418, 37);
            this.btnRemoveText.TabIndex = 5;
            this.btnRemoveText.Text = "Remove Text";
            this.btnRemoveText.UseVisualStyleBackColor = true;
            this.btnRemoveText.Click += new System.EventHandler(this.btnRemoveText_Click);
            // 
            // btnDirectorySearch
            // 
            this.btnDirectorySearch.Location = new System.Drawing.Point(609, 14);
            this.btnDirectorySearch.Name = "btnDirectorySearch";
            this.btnDirectorySearch.Size = new System.Drawing.Size(56, 38);
            this.btnDirectorySearch.TabIndex = 6;
            this.btnDirectorySearch.Text = "...";
            this.btnDirectorySearch.UseVisualStyleBackColor = true;
            this.btnDirectorySearch.Click += new System.EventHandler(this.btnDirectorySearch_Click);
            // 
            // tbRemoveTextInput
            // 
            this.tbRemoveTextInput.Location = new System.Drawing.Point(12, 352);
            this.tbRemoveTextInput.Multiline = true;
            this.tbRemoveTextInput.Name = "tbRemoveTextInput";
            this.tbRemoveTextInput.Size = new System.Drawing.Size(652, 113);
            this.tbRemoveTextInput.TabIndex = 7;
            // 
            // bwRemoveLines
            // 
            this.bwRemoveLines.WorkerReportsProgress = true;
            this.bwRemoveLines.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwRemoveLines_DoWork);
            this.bwRemoveLines.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bwRemoveLines_ProgressChanged);
            this.bwRemoveLines.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwRemoveLines_RunWorkerCompleted);
            // 
            // Search
            // 
            this.ClientSize = new System.Drawing.Size(1196, 621);
            this.Controls.Add(this.tbRemoveTextInput);
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
        private System.Windows.Forms.TextBox tbOutputWindow;
        private System.ComponentModel.BackgroundWorker bwRepeatedSearch;
        private System.Windows.Forms.ProgressBar pbRepeatedSearchProgress;
        private System.Windows.Forms.Button btnRemoveText;
        private System.Windows.Forms.Button btnDirectorySearch;
        private System.Windows.Forms.TextBox tbRemoveTextInput;
        private System.ComponentModel.BackgroundWorker bwRemoveLines;
    }
}

