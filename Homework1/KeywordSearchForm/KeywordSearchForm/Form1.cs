using System;
using System.IO;
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
            fileContents.Text = System.IO.File.ReadAllText(pathBox.Text);
        }

        private void PathBox_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pathBox.Text = openFileDialog1.FileName;
        }

        private void FileContents_TextChanged(object sender, EventArgs e)
        {
            keywordBox.Text = "Enter a search term";
        }

        private void KeywordBox_Click_1(object sender, EventArgs e)
        {
            keywordBox.Text = "";
        }

        private void PathBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Search_Click(object sender, EventArgs e)
        {
            int count = 0;
            bool running = true;
            string doc = fileContents.Text;
            string word = keywordBox.Text;
            while (running)
            {
                bool found = doc.Contains(word);
                if (found)
                {
                    count++;
                    doc = doc.Remove(0, (doc.IndexOf(word) + word.Length));
                    fileContents.Text = doc;
                }
                else
                {
                    running = false;
                }
            }
            keywordBox.Text = count.ToString();
        }
    }
}
