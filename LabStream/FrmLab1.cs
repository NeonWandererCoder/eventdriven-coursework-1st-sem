using System;
using System.IO;
using System.Windows.Forms;

namespace LabStream
{
    public partial class FrmLab1 : Form
    {
        public FrmLab1()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            // reset the file name first so an old name won't be reused
            FrmFileName.SetFileName = "";

            // make an instance of FrmFileName then show it as a dialog
            FrmFileName fileNameForm = new FrmFileName();
            fileNameForm.ShowDialog();

            // if the user closed the form without typing a file name, stop here
            if (FrmFileName.SetFileName == "")
            {
                MessageBox.Show("No file name entered. File was not created.");
                return;
            }

            // get the text from the textbox
            string getInput = txtInput.Text;

            // the text file will be saved inside the My Documents folder
            string docPath =
            Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath,
            FrmFileName.SetFileName)))
            {
                outputFile.WriteLine(getInput);
                Console.WriteLine(getInput);
            }

            MessageBox.Show("File created in: " + docPath);
        }
    }
}
