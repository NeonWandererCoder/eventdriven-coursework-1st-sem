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

            // Part 1 (main lab) - starts with FrmLab1
            Application.Run(new FrmLab1());

            // Application.Run(new FrmLab1());          
            Application.Run(new FrmRegistration());     // challenge

            // Challenge Exercise - comment out the line above and use this one instead
            // Application.Run(new FrmRegistration());
        }
    }
}
