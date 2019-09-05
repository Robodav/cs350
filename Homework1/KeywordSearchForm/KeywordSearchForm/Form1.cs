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
            fileContents.Text = System.IO.File.ReadAllText(pathBox.Text);
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
            if (!checkBox1.Checked)
            {
                doc = doc.ToUpper();
                word = word.ToUpper();
            }
            while (running)
            {
                bool found = doc.Contains(word);
                if (found)
                {
                    count++;
                    fileContents.Select((doc.IndexOf(word)+(fileContents.Text.Length-doc.Length)),word.Length); //Selects region in rich textbox at correct index
                    if (colorChoiceRed.Checked) //Check radio buttons for highlight color choice
                    {
                        fileContents.SelectionColor = Color.Red;
                    }
                    else if (colorChoiceBlue.Checked)
                    {
                        fileContents.SelectionColor = Color.Blue;
                    }
                    else if (colorChoiceGreen.Checked)
                    {
                        fileContents.SelectionColor = Color.Green;
                    }
                    else
                    {
                        fileContents.SelectionColor = Color.Purple;
                    }
                    doc = doc.Remove(0, (doc.IndexOf(word) + word.Length));
                }
                else
                {
                    running = false;
                }
            }
            float selectionLength = count * word.Length;
            float selectionFloat = selectionLength / (float)fileContents.Text.Length;
            string selectionPercentage = selectionFloat.ToString("0.00");
            string dataDisplay = "Number of Matches: " + count.ToString() + " (" + selectionPercentage + "%)";
            keywordBox.Text = dataDisplay; //Displays number of matches in keyword box
        }

        private void FileContents_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
