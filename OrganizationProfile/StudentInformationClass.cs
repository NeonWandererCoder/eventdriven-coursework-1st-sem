using System;

namespace OrganizationProfile
{
    // this class just holds the student's info temporarily so both forms
    // (frmRegistration and frmConfirm) can access the same data
    public class StudentInformationClass
    {
        // the handout's Table lists these as int, but StudentNumber() and
        // ContactNo() return long values, so I made these long to avoid a type
        // mismatch error when assigning them in btnRegister_Click.
        public static long SetStudentNo = 0;
        public static long SetContactNo = 0;
        public static string SetProgram = " ";
        public static string SetGender = " ";
        public static string SetBirthday = " ";
        public static string SetFullName = " ";

        // SetAge isn't in the handout's static variable table either, but
        // the Load event code for frmConfirm uses StudentInformationClass.SetAge,
        // so I added it here too, otherwise the code won't compile.
        public static int SetAge = 0;
    }
}
