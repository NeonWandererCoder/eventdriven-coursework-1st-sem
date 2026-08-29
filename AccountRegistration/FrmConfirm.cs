using System;
using System.Windows.Forms;
using static StudentInfoClass; // para direkta na lang gamitin DelegateText/DelegateNumber

namespace AccountRegistration
{
    public partial class FrmConfirm : Form
    {
        // delegate variables for each field
        private DelegateText DelProgram, DelLastName, DelFirstName, DelMiddleName, DelAddress;
        private DelegateNumber DelNumAge, DelNumContactNo, DelStudNo;

        public FrmConfirm()
        {
            InitializeComponent();

            // point each delegate to its matching static method
            DelProgram = new DelegateText(StudentInfoClass.GetProgram);
            DelLastName = new DelegateText(StudentInfoClass.GetLastName);
            DelFirstName = new DelegateText(StudentInfoClass.GetFirstName);
            DelMiddleName = new DelegateText(StudentInfoClass.GetMiddleName);
            DelAddress = new DelegateText(StudentInfoClass.GetAddress);

            DelNumAge = new DelegateNumber(StudentInfoClass.GetAge);
            DelNumContactNo = new DelegateNumber(StudentInfoClass.GetContactNo);
            DelStudNo = new DelegateNumber(StudentInfoClass.GetStudentNo);
        }

        private void FrmConfirm_Load(object sender, EventArgs e)
        {
            // display values gamit ang delegates
            lblStudentNo.Text = DelStudNo().ToString();
            lblProgram.Text = DelProgram();
            lblLastName.Text = DelLastName();
            lblFirstName.Text = DelFirstName();
            lblMiddleName.Text = DelMiddleName();
            lblAge.Text = DelNumAge().ToString();
            lblContactNo.Text = DelNumContactNo().ToString();
            lblAddress.Text = DelAddress();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // confirm and send OK result pabalik sa FrmRegistration
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void FrmConfirm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}