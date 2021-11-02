
namespace ArrayAndListHomework
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.section1ListBox = new System.Windows.Forms.ListBox();
            this.section2ListBox = new System.Windows.Forms.ListBox();
            this.section3ListBox = new System.Windows.Forms.ListBox();
            this.section1Button = new System.Windows.Forms.Button();
            this.section2Button = new System.Windows.Forms.Button();
            this.section3Button = new System.Windows.Forms.Button();
            this.calculateButton = new System.Windows.Forms.Button();
            this.section1AverageLabel = new System.Windows.Forms.Label();
            this.section2AverageLabel = new System.Windows.Forms.Label();
            this.section3AverageLabel = new System.Windows.Forms.Label();
            this.averageScoreLabel = new System.Windows.Forms.Label();
            this.highestScoreLabel = new System.Windows.Forms.Label();
            this.lowestScoreLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // section1ListBox
            // 
            this.section1ListBox.FormattingEnabled = true;
            this.section1ListBox.ItemHeight = 15;
            this.section1ListBox.Items.AddRange(new object[] {
            ""});
            this.section1ListBox.Location = new System.Drawing.Point(12, 12);
            this.section1ListBox.Name = "section1ListBox";
            this.section1ListBox.Size = new System.Drawing.Size(120, 94);
            this.section1ListBox.TabIndex = 0;
            // 
            // section2ListBox
            // 
            this.section2ListBox.FormattingEnabled = true;
            this.section2ListBox.ItemHeight = 15;
            this.section2ListBox.Items.AddRange(new object[] {
            ""});
            this.section2ListBox.Location = new System.Drawing.Point(138, 12);
            this.section2ListBox.Name = "section2ListBox";
            this.section2ListBox.Size = new System.Drawing.Size(120, 94);
            this.section2ListBox.TabIndex = 1;
            // 
            // section3ListBox
            // 
            this.section3ListBox.FormattingEnabled = true;
            this.section3ListBox.ItemHeight = 15;
            this.section3ListBox.Items.AddRange(new object[] {
            ""});
            this.section3ListBox.Location = new System.Drawing.Point(264, 12);
            this.section3ListBox.Name = "section3ListBox";
            this.section3ListBox.Size = new System.Drawing.Size(120, 94);
            this.section3ListBox.TabIndex = 2;
            // 
            // section1Button
            // 
            this.section1Button.Location = new System.Drawing.Point(13, 113);
            this.section1Button.Name = "section1Button";
            this.section1Button.Size = new System.Drawing.Size(119, 23);
            this.section1Button.TabIndex = 3;
            this.section1Button.Text = "Section 1 Open";
            this.section1Button.UseVisualStyleBackColor = true;
            this.section1Button.Click += new System.EventHandler(this.section1Button_Click);
            // 
            // section2Button
            // 
            this.section2Button.Location = new System.Drawing.Point(138, 113);
            this.section2Button.Name = "section2Button";
            this.section2Button.Size = new System.Drawing.Size(120, 23);
            this.section2Button.TabIndex = 4;
            this.section2Button.Text = "Section 2 Open";
            this.section2Button.UseVisualStyleBackColor = true;
            this.section2Button.Click += new System.EventHandler(this.section2Button_Click);
            // 
            // section3Button
            // 
            this.section3Button.Location = new System.Drawing.Point(264, 113);
            this.section3Button.Name = "section3Button";
            this.section3Button.Size = new System.Drawing.Size(120, 23);
            this.section3Button.TabIndex = 5;
            this.section3Button.Text = "Section 3 Open";
            this.section3Button.UseVisualStyleBackColor = true;
            this.section3Button.Click += new System.EventHandler(this.section3Button_Click);
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(13, 143);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(371, 23);
            this.calculateButton.TabIndex = 6;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // section1AverageLabel
            // 
            this.section1AverageLabel.AutoSize = true;
            this.section1AverageLabel.Location = new System.Drawing.Point(13, 173);
            this.section1AverageLabel.Name = "section1AverageLabel";
            this.section1AverageLabel.Size = new System.Drawing.Size(168, 15);
            this.section1AverageLabel.TabIndex = 7;
            this.section1AverageLabel.Text = "Section 1 average exam score: ";
            // 
            // section2AverageLabel
            // 
            this.section2AverageLabel.AutoSize = true;
            this.section2AverageLabel.Location = new System.Drawing.Point(13, 192);
            this.section2AverageLabel.Name = "section2AverageLabel";
            this.section2AverageLabel.Size = new System.Drawing.Size(168, 15);
            this.section2AverageLabel.TabIndex = 8;
            this.section2AverageLabel.Text = "Section 2 average exam score: ";
            // 
            // section3AverageLabel
            // 
            this.section3AverageLabel.AutoSize = true;
            this.section3AverageLabel.Location = new System.Drawing.Point(13, 211);
            this.section3AverageLabel.Name = "section3AverageLabel";
            this.section3AverageLabel.Size = new System.Drawing.Size(168, 15);
            this.section3AverageLabel.TabIndex = 9;
            this.section3AverageLabel.Text = "Section 3 average exam score: ";
            // 
            // averageScoreLabel
            // 
            this.averageScoreLabel.AutoSize = true;
            this.averageScoreLabel.Location = new System.Drawing.Point(13, 230);
            this.averageScoreLabel.Name = "averageScoreLabel";
            this.averageScoreLabel.Size = new System.Drawing.Size(200, 15);
            this.averageScoreLabel.TabIndex = 10;
            this.averageScoreLabel.Text = "Average exam score for all students: ";
            // 
            // highestScoreLabel
            // 
            this.highestScoreLabel.AutoSize = true;
            this.highestScoreLabel.Location = new System.Drawing.Point(13, 249);
            this.highestScoreLabel.Name = "highestScoreLabel";
            this.highestScoreLabel.Size = new System.Drawing.Size(196, 15);
            this.highestScoreLabel.TabIndex = 11;
            this.highestScoreLabel.Text = "Highest score among all 3 sections: ";
            // 
            // lowestScoreLabel
            // 
            this.lowestScoreLabel.AutoSize = true;
            this.lowestScoreLabel.Location = new System.Drawing.Point(13, 268);
            this.lowestScoreLabel.Name = "lowestScoreLabel";
            this.lowestScoreLabel.Size = new System.Drawing.Size(192, 15);
            this.lowestScoreLabel.TabIndex = 12;
            this.lowestScoreLabel.Text = "Lowest score among all 3 sections: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 291);
            this.Controls.Add(this.lowestScoreLabel);
            this.Controls.Add(this.highestScoreLabel);
            this.Controls.Add(this.averageScoreLabel);
            this.Controls.Add(this.section3AverageLabel);
            this.Controls.Add(this.section2AverageLabel);
            this.Controls.Add(this.section1AverageLabel);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.section3Button);
            this.Controls.Add(this.section2Button);
            this.Controls.Add(this.section1Button);
            this.Controls.Add(this.section3ListBox);
            this.Controls.Add(this.section2ListBox);
            this.Controls.Add(this.section1ListBox);
            this.Name = "Form1";
            this.Text = "Computer Science Exam Scores";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox section1ListBox;
        private System.Windows.Forms.ListBox section2ListBox;
        private System.Windows.Forms.ListBox section3ListBox;
        private System.Windows.Forms.Button section1Button;
        private System.Windows.Forms.Button section2Button;
        private System.Windows.Forms.Button section3Button;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label section1AverageLabel;
        private System.Windows.Forms.Label section2AverageLabel;
        private System.Windows.Forms.Label section3AverageLabel;
        private System.Windows.Forms.Label averageScoreLabel;
        private System.Windows.Forms.Label highestScoreLabel;
        private System.Windows.Forms.Label lowestScoreLabel;
    }
}

