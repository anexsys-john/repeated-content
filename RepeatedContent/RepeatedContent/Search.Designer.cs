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
            this.tbFileInput.Size = new System.Drawing.Size(981, 38);
            this.tbFileInput.TabIndex = 1;
            // 
            // tbRepeatedContent
            // 
            this.tbRepeatedContent.Location = new System.Drawing.Point(430, 69);
            this.tbRepeatedContent.Multiline = true;
            this.tbRepeatedContent.Name = "tbRepeatedContent";
            this.tbRepeatedContent.ReadOnly = true;
            this.tbRepeatedContent.Size = new System.Drawing.Size(981, 370);
            this.tbRepeatedContent.TabIndex = 2;
            // 
            // bwRepeatedSearch
            // 
            this.bwRepeatedSearch.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwRepeatedSearch_DoWork);
            this.bwRepeatedSearch.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwRepeatedSearch_RunWorkerCompleted);
            // 
            // Search
            // 
            this.ClientSize = new System.Drawing.Size(2020, 701);
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
    }
}

