using System;
using System.Windows.Forms;
using System.Text.RegularExpressions; // needed for Regex, this fixes the error mentioned in step 9

namespace OrganizationProfile
{
    public partial class frmRegistration : Form
    {
        // Table 3 variables
        private string _FullName;
        private int _Age;
        private long _ContactNo;
        private long _StudentNo;

        public frmRegistration()
        {
            InitializeComponent();
        }

        // step 8: loads the program choices into the combo box when the form opens
        private void frmRegistration_Load(object sender, EventArgs e)
        {
            string[] ListOfProgram = new string[] {
                "BS Information Technology",
                "BS Computer Science",
                "BS Information Systems",
                "BS in Accountancy",
                "BS in Hospitality Management",
                "BS in Tourism Management"
            };

            for (int i = 0; i < 6; i++)
            {
                cbPrograms.Items.Add(ListOfProgram[i].ToString());
            }
        }

        public long StudentNumber(string studNum)
        {
            if (Regex.IsMatch(studNum, @"^[0-9]+$"))
            {
                _StudentNo = long.Parse(studNum);
            }
            else
            {
                throw new FormatException("Student number must contain digits only.");
            }

            return _StudentNo;
        }

        public long ContactNo(string Contact)
        {
            if (Regex.IsMatch(Contact, @"^[0-9]{10,11}$"))
            {
                _ContactNo = long.Parse(Contact);
            }
            else
            {
                throw new IndexOutOfRangeException("Contact number must be 10 to 11 digits long.");
            }

            return _ContactNo;
        }

        public string FullName(string LastName, string FirstName, string MiddleInitial)
        {
            if (Regex.IsMatch(LastName, @"^[a-zA-Z]+$") || Regex.IsMatch(FirstName, @"^[a-zA-Z]+$") || Regex.IsMatch(MiddleInitial, @"^[a-zA-Z]+$"))
            {
                _FullName = LastName + ", " + FirstName + ", " + MiddleInitial;
            }
            else
            {
                throw new ArgumentNullException("Last name, first name, or middle initial is missing or invalid.");
            }

            return _FullName;
        }

        public int Age(string age)
        {
            if (Regex.IsMatch(age, @"^[0-9]{1,3}$"))
            {
                _Age = Int32.Parse(age);
            }
            else
            {
                throw new OverflowException("Age must be a valid number from 1 to 3 digits.");
            }

            return _Age;
        }

        // step 10 + challenge exercise: submit button now wrapped in try-catch-finally
        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                StudentInformationClass.SetFullName = FullName(txtLastName.Text,
                    txtFirstName.Text, txtMiddleInitial.Text);

                StudentInformationClass.SetStudentNo = StudentNumber(txtStudentNo.Text);
                StudentInformationClass.SetProgram = cbPrograms.Text;
                StudentInformationClass.SetGender = cbGender.Text;
                StudentInformationClass.SetContactNo = ContactNo(txtContactNo.Text);
                StudentInformationClass.SetAge = Age(txtAge.Text);
                StudentInformationClass.SetBirthday = datePickerBirthday.Value.ToString("yyyy-MM-dd");

                frmConfirm frm = new frmConfirm();
                frm.ShowDialog();
            }
            catch (FormatException fe)
            {
                MessageBox.Show("Format Exception: " + fe.Message);
            }
            catch (ArgumentNullException ane)
            {
                MessageBox.Show("Argument Null Exception: " + ane.Message);
            }
            catch (OverflowException oe)
            {
                MessageBox.Show("Overflow Exception: " + oe.Message);
            }
            catch (IndexOutOfRangeException ioe)
            {
                MessageBox.Show("Index Out Of Range Exception: " + ioe.Message);
            }
            finally
            {
                // just logging that the attempt is done, whether it succeeded or not
                Console.WriteLine("Registration attempt finished processing.");
            }
        }
    }
}
