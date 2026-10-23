using System;
using System.IO;
using System.Windows.Forms;

namespace LabStream
{
    public partial class FrmStudentRecord : Form
    {
        public FrmStudentRecord()
        {
            InitializeComponent();
        }

        // Register button - close this form to go back to FrmRegistration
        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Find button - look for the text file in the folder where the records are saved
        private void btnFind_Click(object sender, EventArgs e)
        {
            // the registration text files are saved in My Documents
            openFileDialog1.InitialDirectory =
            Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            openFileDialog1.Title = "Find Student Record";
            openFileDialog1.DefaultExt = "txt";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // clear the old content first
                    lvRecord.Items.Clear();

                    using (StreamReader streamReader = File.OpenText(openFileDialog1.FileName))
                    {
                        string _getText = "";
                        while ((_getText = streamReader.ReadLine()) != null)
                        {
                            Console.WriteLine(_getText);
                            lvRecord.Items.Add(_getText);
                        }
                    }
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
        }

        // Upload button - only shows a message box and clears the ListView
        private void btnUpload_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Successfully Uploaded!");
            lvRecord.Items.Clear();
        }
    }
}
