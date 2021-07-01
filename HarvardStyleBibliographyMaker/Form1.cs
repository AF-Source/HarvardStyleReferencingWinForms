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

namespace HarvardStyleBibliographyMaker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string FinalisedList;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Author_TextChanged(object sender, EventArgs e)
        {
           
        }



        private void WebsiteName_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void Title_TextChanged(object sender, EventArgs e)
        {
            
        }


        private void URL_TextChanged(object sender, EventArgs e)
        {
            
        }

        public void AddButton_Click(object sender, EventArgs e)
        {
            string author = Author.Text;
            string yearofpublishment = YearOfPublishment.Text;
            string websitename = WebsiteName.Text;
            string title = Title.Text; 
            string url = URL.Text;
            string time = DateTime.Now.ToString("d");
            ComputingFormat format = new ComputingFormat();
            string reference = format.Formating(author, yearofpublishment, websitename, title, url, time);
            List<string> ListOfAllReferences = new List<string>();
            ListOfAllReferences.Add(reference);
             FinalisedList = string.Join("", ListOfAllReferences);
            textBox1.AppendText(FinalisedList + Environment.NewLine);
            
            Author.Clear(); //Clearing all of the textboxes for user's convenience
            WebsiteName.Clear();
            YearOfPublishment.Clear();
            Title.Clear();
            URL.Clear();
        }

        private void BibliographyList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }


        private void YearOfPublishment_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Text File (*.txt)|.txt";
            DialogResult diag = saveFileDialog1.ShowDialog();
            if (diag == DialogResult.OK)
            {

                StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);
                sw.Write(textBox1.Text);
                sw.Flush();
                sw.Close();
                MessageBox.Show("Don't forget to italise the title!", "Reminder!");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome to the Automatic Harvard Referencer Tool! To use it please enter all of the fields and press add to the list. You can edit the list right away by clicking on the big textbox on the right!", "Help Menu");
        }
    }
}
