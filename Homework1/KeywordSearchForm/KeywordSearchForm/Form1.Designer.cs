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
            this.colorChoiceRed = new System.Windows.Forms.RadioButton();
            this.colorChoiceBlue = new System.Windows.Forms.RadioButton();
            this.colorChoiceGreen = new System.Windows.Forms.RadioButton();
            this.colorChoicePurple = new System.Windows.Forms.RadioButton();
            this.colorsLabel = new System.Windows.Forms.Label();
            this.colorsGroup = new System.Windows.Forms.GroupBox();
            this.colorsGroup.SuspendLayout();
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
            this.keywordBox.Location = new System.Drawing.Point(4, 124);
            this.keywordBox.Name = "keywordBox";
            this.keywordBox.Size = new System.Drawing.Size(180, 20);
            this.keywordBox.TabIndex = 2;
            this.keywordBox.Click += new System.EventHandler(this.KeywordBox_Click_1);
            this.keywordBox.TextChanged += new System.EventHandler(this.KeywordBox_TextChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(190, 127);
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
            this.search.Location = new System.Drawing.Point(4, 150);
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
            // colorChoiceRed
            // 
            this.colorChoiceRed.AutoSize = true;
            this.colorChoiceRed.Location = new System.Drawing.Point(6, 10);
            this.colorChoiceRed.Name = "colorChoiceRed";
            this.colorChoiceRed.Size = new System.Drawing.Size(45, 17);
            this.colorChoiceRed.TabIndex = 7;
            this.colorChoiceRed.TabStop = true;
            this.colorChoiceRed.Text = "Red";
            this.colorChoiceRed.UseVisualStyleBackColor = true;
            // 
            // colorChoiceBlue
            // 
            this.colorChoiceBlue.AutoSize = true;
            this.colorChoiceBlue.Location = new System.Drawing.Point(72, 10);
            this.colorChoiceBlue.Name = "colorChoiceBlue";
            this.colorChoiceBlue.Size = new System.Drawing.Size(46, 17);
            this.colorChoiceBlue.TabIndex = 8;
            this.colorChoiceBlue.TabStop = true;
            this.colorChoiceBlue.Text = "Blue";
            this.colorChoiceBlue.UseVisualStyleBackColor = true;
            // 
            // colorChoiceGreen
            // 
            this.colorChoiceGreen.AutoSize = true;
            this.colorChoiceGreen.Location = new System.Drawing.Point(143, 10);
            this.colorChoiceGreen.Name = "colorChoiceGreen";
            this.colorChoiceGreen.Size = new System.Drawing.Size(54, 17);
            this.colorChoiceGreen.TabIndex = 9;
            this.colorChoiceGreen.TabStop = true;
            this.colorChoiceGreen.Text = "Green";
            this.colorChoiceGreen.UseVisualStyleBackColor = true;
            // 
            // colorChoicePurple
            // 
            this.colorChoicePurple.AutoSize = true;
            this.colorChoicePurple.Location = new System.Drawing.Point(219, 10);
            this.colorChoicePurple.Name = "colorChoicePurple";
            this.colorChoicePurple.Size = new System.Drawing.Size(55, 17);
            this.colorChoicePurple.TabIndex = 10;
            this.colorChoicePurple.TabStop = true;
            this.colorChoicePurple.Text = "Purple";
            this.colorChoicePurple.UseVisualStyleBackColor = true;
            // 
            // colorsLabel
            // 
            this.colorsLabel.AutoSize = true;
            this.colorsLabel.Location = new System.Drawing.Point(1, 234);
            this.colorsLabel.Name = "colorsLabel";
            this.colorsLabel.Size = new System.Drawing.Size(78, 13);
            this.colorsLabel.TabIndex = 11;
            this.colorsLabel.Text = "Highlight Color:";
            // 
            // colorsGroup
            // 
            this.colorsGroup.Controls.Add(this.colorChoiceRed);
            this.colorsGroup.Controls.Add(this.colorChoiceBlue);
            this.colorsGroup.Controls.Add(this.colorChoicePurple);
            this.colorsGroup.Controls.Add(this.colorChoiceGreen);
            this.colorsGroup.Location = new System.Drawing.Point(4, 250);
            this.colorsGroup.Name = "colorsGroup";
            this.colorsGroup.Size = new System.Drawing.Size(280, 33);
            this.colorsGroup.TabIndex = 12;
            this.colorsGroup.TabStop = false;
            // 
            // KeywordSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.colorsGroup);
            this.Controls.Add(this.colorsLabel);
            this.Controls.Add(this.fileContents);
            this.Controls.Add(this.search);
            this.Controls.Add(this.generateContents);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.keywordBox);
            this.Controls.Add(this.pathBox);
            this.Name = "KeywordSearch";
            this.Text = "Keyword Search";
            this.colorsGroup.ResumeLayout(false);
            this.colorsGroup.PerformLayout();
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
        private System.Windows.Forms.RadioButton colorChoiceRed;
        private System.Windows.Forms.RadioButton colorChoiceBlue;
        private System.Windows.Forms.RadioButton colorChoiceGreen;
        private System.Windows.Forms.RadioButton colorChoicePurple;
        private System.Windows.Forms.Label colorsLabel;
        private System.Windows.Forms.GroupBox colorsGroup;
    }
}

