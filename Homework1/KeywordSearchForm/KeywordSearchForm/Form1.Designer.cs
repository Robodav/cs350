namespace KeywordSearchForm
{
    partial class KeywordSearch
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
            this.pathBox = new System.Windows.Forms.TextBox();
            this.keywordBox = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.generateContents = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.fileContents = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // pathBox
            // 
            this.pathBox.Location = new System.Drawing.Point(4, 12);
            this.pathBox.Name = "pathBox";
            this.pathBox.Size = new System.Drawing.Size(269, 20);
            this.pathBox.TabIndex = 0;
            this.pathBox.Text = "Select Text File";
            this.pathBox.Click += new System.EventHandler(this.PathBox_Click);
            this.pathBox.TextChanged += new System.EventHandler(this.PathBox_TextChanged);
            // 
            // keywordBox
            // 
            this.keywordBox.Location = new System.Drawing.Point(4, 221);
            this.keywordBox.Name = "keywordBox";
            this.keywordBox.Size = new System.Drawing.Size(180, 20);
            this.keywordBox.TabIndex = 2;
            this.keywordBox.Click += new System.EventHandler(this.KeywordBox_Click_1);
            this.keywordBox.TextChanged += new System.EventHandler(this.KeywordBox_TextChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(190, 224);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(83, 17);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "Match Case";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // generateContents
            // 
            this.generateContents.Location = new System.Drawing.Point(4, 38);
            this.generateContents.Name = "generateContents";
            this.generateContents.Size = new System.Drawing.Size(75, 23);
            this.generateContents.TabIndex = 4;
            this.generateContents.Text = "Generate";
            this.generateContents.UseVisualStyleBackColor = true;
            this.generateContents.Click += new System.EventHandler(this.GenerateContents_Click);
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(4, 247);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(75, 23);
            this.search.TabIndex = 5;
            this.search.Text = "Search";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.Search_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "\"txt files (*.txt)|*.txt|All files (*.*)|*.*\"";
            // 
            // fileContents
            // 
            this.fileContents.Location = new System.Drawing.Point(290, 12);
            this.fileContents.Name = "fileContents";
            this.fileContents.Size = new System.Drawing.Size(498, 426);
            this.fileContents.TabIndex = 6;
            this.fileContents.Text = "";
            this.fileContents.TextChanged += new System.EventHandler(this.FileContents_TextChanged_1);
            // 
            // KeywordSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.fileContents);
            this.Controls.Add(this.search);
            this.Controls.Add(this.generateContents);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.keywordBox);
            this.Controls.Add(this.pathBox);
            this.Name = "KeywordSearch";
            this.Text = "Keyword Search";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox pathBox;
        private System.Windows.Forms.TextBox keywordBox;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button generateContents;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.RichTextBox fileContents;
    }
}

