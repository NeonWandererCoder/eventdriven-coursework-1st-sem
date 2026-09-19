using System;
using System.Windows.Forms;

namespace OrganizationProfile
{
    public partial class frmConfirm : Form
    {
        public frmConfirm()
        {
            InitializeComponent();
        }

        // step 11: fills in the confirmation labels with whatever was saved
        // in StudentInformationClass from the registration form
        private void frmConfirm_Load(object sender, EventArgs e)
        {
            lblStudentNo.Text = StudentInformationClass.SetStudentNo.ToString();
            lblName.Text = StudentInformationClass.SetFullName;
            lblProgram.Text = StudentInformationClass.SetProgram;
            lblBirthday.Text = StudentInformationClass.SetBirthday;
            lblGender.Text = StudentInformationClass.SetGender;
            lblContactNo.Text = StudentInformationClass.SetContactNo.ToString();
            lblAge.Text = StudentInformationClass.SetAge.ToString();
        }

        // just closes the confirmation dialog once the user checks their info
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
