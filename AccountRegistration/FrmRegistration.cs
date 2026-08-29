using System;
using System.Windows.Forms;

namespace AccountRegistration
{
    public partial class FrmRegistration : Form
    {
        public FrmRegistration()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            // check for blank fields first before proceeding
            if (string.IsNullOrWhiteSpace(txtStudentNo.Text) ||
                cbProgram.SelectedIndex == -1 ||
                string.IsNullOrWhiteSpace(txtLastName.Text) ||
                string.IsNullOrWhiteSpace(txtFirstName.Text) ||
                string.IsNullOrWhiteSpace(txtMiddleName.Text) ||
                string.IsNullOrWhiteSpace(txtAge.Text) ||
                string.IsNullOrWhiteSpace(txtContactNo.Text) ||
                string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                MessageBox.Show("Please fill up all the fields before proceeding.",
                    "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // validate that Student No., Age, and Contact No. contain numbers only
            long studentNo, age, contactNo;

            if (!long.TryParse(txtStudentNo.Text, out studentNo))
            {
                MessageBox.Show("Student No. should be numbers only.",
                    "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtStudentNo.Focus();
                return;
            }

            if (!long.TryParse(txtAge.Text, out age) || age <= 0)
            {
                MessageBox.Show("Age should be a valid positive number.",
                    "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAge.Focus();
                return;
            }

            if (!long.TryParse(txtContactNo.Text, out contactNo))
            {
                MessageBox.Show("Contact No. should be numbers only.",
                    "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtContactNo.Focus();
                return;
            }

            // safe to save now since everything passed validation
            StudentInfoClass.StudentNo = studentNo;
            StudentInfoClass.Program = cbProgram.Text;
            StudentInfoClass.LastName = txtLastName.Text;
            StudentInfoClass.FirstName = txtFirstName.Text;
            StudentInfoClass.MiddleName = txtMiddleName.Text;
            StudentInfoClass.Age = age;
            StudentInfoClass.ContactNo = contactNo;
            StudentInfoClass.Address = txtAddress.Text;

            // open FrmConfirm as a dialog box
            FrmConfirm confirmForm = new FrmConfirm();
            DialogResult result = confirmForm.ShowDialog();

            // reset all fields once confirmed
            if (result == DialogResult.OK)
            {
                txtStudentNo.Clear();
                cbProgram.SelectedIndex = -1;
                txtLastName.Clear();
                txtFirstName.Clear();
                txtMiddleName.Clear();
                txtAge.Clear();
                txtContactNo.Clear();
                txtAddress.Clear();
                txtStudentNo.Focus();
            }
        }
    }
}