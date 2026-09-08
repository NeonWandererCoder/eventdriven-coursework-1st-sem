using System;
using System.Windows.Forms;

namespace BasicQueuingCashier
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // open all 3 forms at the same time so we can test the whole flow:
            // QueuingForm generates numbers, CashierWindowQueueForm calls them,
            // and CustomerView shows who's being served
            QueuingForm queuingForm = new QueuingForm();
            CashierWindowQueueForm cashierForm = new CashierWindowQueueForm();
            CustomerView customerView = new CustomerView();

            queuingForm.Show();
            cashierForm.Show();
            customerView.Show();

            Application.Run();
        }
    }
}