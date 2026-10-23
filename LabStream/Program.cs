using System;
using System.Windows.Forms;

namespace LabStream
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Lab Exercise 2 Challenge - start with the registration form
            Application.Run(new FrmRegistration());

            // Lab Exercise 1 (main lab) - use this one instead if needed
            // Application.Run(new FrmLab1());
        }
    }
}
