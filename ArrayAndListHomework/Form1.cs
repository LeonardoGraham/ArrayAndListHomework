using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArrayAndListHomework
{
    public partial class Form1 : Form
    {
        private OpenFileDialog openFileDialog = new OpenFileDialog
        {
            Title = "Open File",

            CheckFileExists = true,
            CheckPathExists = true,

            DefaultExt = "txt",
            Filter = "txt files (*.txt)|*.txt",
            FilterIndex = 2,
            RestoreDirectory = true,

            ReadOnlyChecked = true,
            ShowReadOnly = true
        };
        private int arraySize1 = 12, arraySize2 = 8, arraySize3 = 10;
        private int[] section1Scores;
        private int[] section2Scores;
        private int[] section3Scores;

        public Form1()
        {
            InitializeComponent();
        }

        private void section1Button_Click(object sender, EventArgs e)
        {
            section1Scores = AccessFile(arraySize1, section1ListBox);
        }

        private void section2Button_Click(object sender, EventArgs e)
        {
            section2Scores = AccessFile(arraySize2, section2ListBox);
        }

        private void section3Button_Click(object sender, EventArgs e)
        {
            section3Scores = AccessFile(arraySize3, section3ListBox);
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            double average1, average2, average3, averageAll;
            int highestScore = section1Scores[0], lowestScore = section1Scores[0];
            string highestSection = "Section 1", lowestSection = "Section 1";

            int sum1 = 0, sum2 = 0, sum3 = 0;
            foreach(int score in section1Scores)
            {
                sum1 += score;
                
                if (score > highestScore)
                {
                    highestScore = score;
                    highestSection = "Section 1";
                }
                if (score < lowestScore)
                {
                    lowestScore = score;
                    lowestSection = "Section 1";
                }
            }
            average1 = sum1 / (double)arraySize1;

            foreach (int score in section2Scores)
            {
                sum2 += score;
                if (score > highestScore)
                {
                    highestScore = score;
                    highestSection = "Section 2";
                }
                if (score < lowestScore)
                {
                    lowestScore = score;
                    lowestSection = "Section 2";
                }
            }
            average2 = sum2 / (double)arraySize2;

            foreach (int score in section3Scores)
            {
                sum3 += score;
                if (score > highestScore)
                {
                    highestScore = score;
                    highestSection = "Section 3";
                }
                if (score < lowestScore)
                {
                    lowestScore = score;
                    lowestSection = "Section 3";
                }
            }
            average3 = sum3 / (double)arraySize3;

            averageAll = (sum1 + sum2 + sum3) / (double)(arraySize1 + arraySize2 + arraySize3);

            section1AverageLabel.Text += average1.ToString("#.#");
            section2AverageLabel.Text += average2.ToString("#.#");
            section3AverageLabel.Text += average3.ToString("#.#");
            averageScoreLabel.Text += averageAll.ToString("#.#");
            highestScoreLabel.Text += $"{highestScore} {highestSection}";
            lowestScoreLabel.Text += $"{lowestScore} {lowestSection}";
        }

        private int[] AccessFile(int arraySize, ListBox listBox)
        {
            int[] examArray = new int[arraySize];

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileLocation = openFileDialog.FileName;

                using (TextReader reader = File.OpenText(fileLocation))
                {
                    string num;
                    int i = 0;
                    while ((num = reader.ReadLine()) != null && i < arraySize)
                    {
                        examArray[i] = int.Parse(num);
                        i++;
                    }
                }

                listBox.Items.Clear();

                foreach (int num in examArray)
                {
                    listBox.Items.Add(num);
                } 
            }

            return examArray;
        }
    }
}
