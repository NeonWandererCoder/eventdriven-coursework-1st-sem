using System;
using System.IO;
using System.Windows.Forms;

namespace LabStream
{
    public partial class FrmRegistration : Form
    {
        public FrmRegistration()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            // check first if there is an empty field
            if (txtStudentNo.Text.Trim() == "" || txtLastName.Text.Trim() == "" ||
                txtFirstName.Text.Trim() == "" || txtMI.Text.Trim() == "" ||
                txtAge.Text.Trim() == "" || txtContactNo.Text.Trim() == "" ||
                cboProgram.SelectedIndex == -1 || cboGender.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill in all the fields.");
                return;
            }

            // file name is the student number
            string fileName = txtStudentNo.Text + ".txt";

            // save inside My Documents
            string docPath =
            Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            // array of string that holds all the lines of the text file
            string[] lines = {
                "Student No.:" + txtStudentNo.Text,
                "Full Name:" + txtLastName.Text + ", " + txtFirstName.Text + ", " + txtMI.Text,
                "Program: " + cboProgram.Text,
                "Gender: " + cboGender.Text,
                "Age: " + txtAge.Text,
                "Birthday: " + dtpBirthday.Value.ToString("yyyy-MM-dd"),
                "Contact No." + txtContactNo.Text
            };

            // write every line using foreach
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, fileName)))
            {
                foreach (string line in lines)
                {
                    outputFile.WriteLine(line);
                }
            }

            MessageBox.Show("Registered! File saved as " + fileName + " in " + docPath);
        }

        private void btnRecords_Click(object sender, EventArgs e)
        {
            // open the student record form, then show the registration again when it closes
            FrmStudentRecord studentRecord = new FrmStudentRecord();
            this.Hide();
            studentRecord.ShowDialog();
            this.Show();
        }
    }
}
