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
            this.BtnSearch = new System.Windows.Forms.Button();
            this.tbFileInput = new System.Windows.Forms.TextBox();
            this.tbRepeatedContent = new System.Windows.Forms.TextBox();
            this.bwRepeatedSearch = new System.ComponentModel.BackgroundWorker();
            this.pbRepeatedSearchProgress = new System.Windows.Forms.ProgressBar();
            this.lbProgressPercentage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnSearch
            // 
            this.BtnSearch.Location = new System.Drawing.Point(12, 12);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(411, 38);
            this.BtnSearch.TabIndex = 0;
            this.BtnSearch.Text = "Search for Repeated Content";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // tbFileInput
            // 
            this.tbFileInput.Location = new System.Drawing.Point(430, 13);
            this.tbFileInput.Name = "tbFileInput";
            this.tbFileInput.Size = new System.Drawing.Size(659, 38);
            this.tbFileInput.TabIndex = 1;
            // 
            // tbRepeatedContent
            // 
            this.tbRepeatedContent.Location = new System.Drawing.Point(430, 115);
            this.tbRepeatedContent.Multiline = true;
            this.tbRepeatedContent.Name = "tbRepeatedContent";
            this.tbRepeatedContent.ReadOnly = true;
            this.tbRepeatedContent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbRepeatedContent.Size = new System.Drawing.Size(659, 251);
            this.tbRepeatedContent.TabIndex = 2;
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
            this.pbRepeatedSearchProgress.Location = new System.Drawing.Point(430, 58);
            this.pbRepeatedSearchProgress.Name = "pbRepeatedSearchProgress";
            this.pbRepeatedSearchProgress.Size = new System.Drawing.Size(553, 35);
            this.pbRepeatedSearchProgress.TabIndex = 3;
            // 
            // lbProgressPercentage
            // 
            this.lbProgressPercentage.AutoSize = true;
            this.lbProgressPercentage.Location = new System.Drawing.Point(989, 58);
            this.lbProgressPercentage.Name = "lbProgressPercentage";
            this.lbProgressPercentage.Size = new System.Drawing.Size(0, 31);
            this.lbProgressPercentage.TabIndex = 4;
            // 
            // Search
            // 
            this.ClientSize = new System.Drawing.Size(1526, 491);
            this.Controls.Add(this.lbProgressPercentage);
            this.Controls.Add(this.pbRepeatedSearchProgress);
            this.Controls.Add(this.tbRepeatedContent);
            this.Controls.Add(this.tbFileInput);
            this.Controls.Add(this.BtnSearch);
            this.Name = "Search";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.TextBox tbFileInput;
        private System.Windows.Forms.TextBox tbRepeatedContent;
        private System.ComponentModel.BackgroundWorker bwRepeatedSearch;
        private System.Windows.Forms.ProgressBar pbRepeatedSearchProgress;
        private System.Windows.Forms.Label lbProgressPercentage;
    }
}

