using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace HarvardStyleBibliographyMaker
{
    public partial class HarvardStyleBibliography : Form
    {
        public HarvardStyleBibliography()
        {
            InitializeComponent();
        }

        private string FinalisedList; //Declaring the variable globally for the entire class

        private void AddButton_Click(object sender, EventArgs e)
        {
            string author = Author.Text;
            string yearofpublishment = YearOfPublishment.Text;
            string websitename = WebsiteName.Text;
            string title = Title.Text; 
            string url = URL.Text;
           
            string time = DateTime.Now.ToString("d");
            ComputingFormat format = new ComputingFormat();
            string reference = format.Formating(author, yearofpublishment, websitename, title, url, time);
            List<string> ListOfAllReferences = new List<string>
            {
                reference
            };
            FinalisedList = string.Join("", ListOfAllReferences);
            ListRTB.AppendText(FinalisedList + Environment.NewLine);
           


            Author.Clear(); //Clearing all of the textboxes for user's convenience
            WebsiteName.Clear();
            YearOfPublishment.Clear();
            Title.Clear();
            URL.Clear();
        }
        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Text File (*.txt)|.txt";
            DialogResult diag = saveFileDialog1.ShowDialog();
            if (diag == DialogResult.OK)
            {

                StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);
                sw.Write(ListRTB.Text);
                sw.Flush();
                sw.Close();
                MessageBox.Show("Don't forget to italise the title!", "Reminder!");
            }
        }

        private void HelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome to the Automatic Harvard Referencer Tool! To use it please enter all of the fields and press add to the list. You can edit the list right away by clicking on the big textbox on the right!"
                + Environment.NewLine + "Press Italise to italise the title. Press regular to make font normal.", "Help Menu");
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            ListRTB.SelectionFont = new Font(ListRTB.SelectionFont, FontStyle.Italic); //RTB = Rich Text Box
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            ListRTB.Clear();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            ListRTB.SelectionFont = new Font(ListRTB.SelectionFont, FontStyle.Regular);
        }

    }
}
