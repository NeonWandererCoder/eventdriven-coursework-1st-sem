using System;
using System.Windows.Forms;

namespace BasicQueuingCashier
{
    public partial class CustomerView : Form
    {
        // timer used to automatically check for updates in the queue
        private Timer timerNowServing;

        public CustomerView()
        {
            InitializeComponent();

            // check every 1 second so the display updates on its own
            timerNowServing = new Timer();
            timerNowServing.Interval = 1 * 1000; // 1 sec
            timerNowServing.Tick += new EventHandler(timerNowServing_Tick);
            timerNowServing.Start();
        }

        private void timerNowServing_Tick(object sender, EventArgs e)
        {
            UpdateNowServing();
        }

        private void UpdateNowServing()
        {
            // single condition: the ?. operator checks "is CashierQueue null"
            // and "is Count > 0" at the same time, so Peek() never runs on
            // a null or empty queue
            if (CashierClass.CashierQueue?.Count > 0)
            {
                lblNowServing.Text = CashierClass.CashierQueue.Peek();
            }
        }
    }
}