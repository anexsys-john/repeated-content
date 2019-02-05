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
            this.tbFileInput.Size = new System.Drawing.Size(1433, 38);
            this.tbFileInput.TabIndex = 1;
            // 
            // Search
            // 
            this.ClientSize = new System.Drawing.Size(2020, 701);
            this.Controls.Add(this.tbFileInput);
            this.Controls.Add(this.BtnSearch);
            this.Name = "Search";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.TextBox tbFileInput;
    }
}

