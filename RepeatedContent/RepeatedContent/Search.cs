using System;
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
        public Search()
        {
            InitializeComponent();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            string filepath = tbFileInput.Text;
            FileSearcher fileSearcher = new FileSearcher(filepath);
            fileSearcher.GetLines();

        }
    }
}
