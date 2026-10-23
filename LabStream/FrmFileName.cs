using System;
using System.Windows.Forms;

namespace LabStream
{
    public partial class FrmFileName : Form
    {
        // public static string, so FrmLab1 can read it (declared above the constructor)
        public static string SetFileName = "";

        public FrmFileName()
        {
            InitializeComponent();
        }

        private void btnOkay_Click(object sender, EventArgs e)
        {
            // don't allow an empty file name
            if (txtFileName.Text.Trim() == "")
            {
                MessageBox.Show("Please enter a file name.");
                return;
            }

            // get the file name from the textbox and add .txt
            SetFileName = txtFileName.Text + ".txt";

            // close this form
            this.Close();
        }
    }
}
