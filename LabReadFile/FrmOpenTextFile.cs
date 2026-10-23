using System;
using System.IO;
using System.Windows.Forms;

namespace LabReadFile
{
    public partial class FrmOpenTextFile : Form
    {
        public FrmOpenTextFile()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            // handle the possible errors when opening the file
            try
            {
                DisplayToList();
            }
            catch (EmptyFileException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("File not found.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void DisplayToList()
        {
            string path;

            openFileDialog1.InitialDirectory = @"C:\";
            openFileDialog1.Title = "Browse Text Files";
            openFileDialog1.DefaultExt = "txt";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";

            // if the user pressed Cancel, just stop
            if (openFileDialog1.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            path = openFileDialog1.FileName;

            // clear the old content of the list first
            lvShowText.Items.Clear();

            using (StreamReader streamReader = File.OpenText(path))
            {
                string _getText = "";
                while ((_getText = streamReader.ReadLine()) != null)
                {
                    Console.WriteLine(_getText);
                    lvShowText.Items.Add(_getText);
                }
            }

            // throw my customized exception if nothing was read
            if (lvShowText.Items.Count == 0)
            {
                throw new EmptyFileException();
            }
        }
    }

    // my own (customized) exception, thrown when the text file has no content
    public class EmptyFileException : Exception
    {
        public EmptyFileException() : base("The selected text file is empty.")
        {
        }
    }
}