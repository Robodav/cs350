using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeywordSearchForm
{
    public partial class KeywordSearch : Form
    {
        public KeywordSearch()
        {
            InitializeComponent();
        }

        private void KeywordBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void GenerateContents_Click(object sender, EventArgs e)
        {

        }

        private void PathBox_TextChanged(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void PathBox_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }
    }
}
