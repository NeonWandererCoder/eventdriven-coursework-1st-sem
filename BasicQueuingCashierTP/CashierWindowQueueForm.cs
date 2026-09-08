using System;
using System.Collections;
using System.Windows.Forms;

namespace BasicQueuingCashier
{
    public partial class CashierWindowQueueForm : Form
    {
        // timer used for the challenge exercise, so the list refreshes on its own
        private Timer timerRefresh;

        public CashierWindowQueueForm()
        {
            InitializeComponent();

            // set up the timer to tick every 1 second and auto-refresh the list
            timerRefresh = new Timer();
            timerRefresh.Interval = 1 * 1000; // 1 sec
            timerRefresh.Tick += new EventHandler(timerRefresh_Tick);
            timerRefresh.Start();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DisplayCashierQueue(CashierClass.CashierQueue);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            // remove the number that was already served (challenge exercise)
            if (CashierClass.CashierQueue != null && CashierClass.CashierQueue.Count > 0)
            {
                CashierClass.CashierQueue.Dequeue();
                DisplayCashierQueue(CashierClass.CashierQueue);
            }
            else
            {
                MessageBox.Show("The queue is currently empty.",
                    "No Customers", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void timerRefresh_Tick(object sender, EventArgs e)
        {
            // automatically refresh the list every tick, so new numbers
            // show up without needing to click Refresh (challenge exercise)
            DisplayCashierQueue(CashierClass.CashierQueue);
        }

        public void DisplayCashierQueue(IEnumerable CashierList)
        {
            listCashierQueue.Items.Clear();
            foreach (Object obj in CashierList)
            {
                listCashierQueue.Items.Add(obj.ToString());
            }
        }
    }
}