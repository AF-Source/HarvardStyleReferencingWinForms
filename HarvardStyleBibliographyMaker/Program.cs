using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HarvardStyleBibliographyMaker
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

        }

    }
    class ComputingFormat
    {
        public string Formating(string Author, string PublishYr, string ArticleTitle, string WebsiteName, string URL, string CurrentTime)
        {
            try // To prevent the user from putting in not the whole name
            {
                string[] AuthorName = Author.Split(' ');
                string FirstLetterOfTheauthorName = AuthorName[0].Substring(0, 1);

                string CompletedFormating = $"{AuthorName[1]}, {FirstLetterOfTheauthorName}. ({PublishYr}) {ArticleTitle}. [online] {WebsiteName}. Available at: {URL} [Accessed: {CurrentTime}] ";
                return CompletedFormating;
            }
            catch
            {
                MessageBox.Show("Please put in the whole Author Name");
            }
            return null;
        }
    }

}
