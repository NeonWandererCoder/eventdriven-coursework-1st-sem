using System;
using System.Threading;
using System.Windows.Forms;

namespace ThreadPriority
{
    public partial class frmTrackThread : Form
    {
        public frmTrackThread()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            Console.WriteLine("-Thread Starts-");

            // threadA and threadC use the fast method (Thread1)
            Thread threadA = new Thread(MyThreadClass.Thread1);
            threadA.Name = "Thread A";
            threadA.Priority = System.Threading.ThreadPriority.Highest;

            Thread threadC = new Thread(MyThreadClass.Thread1);
            threadC.Name = "Thread C";
            threadC.Priority = System.Threading.ThreadPriority.AboveNormal;

            // threadB and threadD use the slower method (Thread2)
            Thread threadB = new Thread(MyThreadClass.Thread2);
            threadB.Name = "Thread B";
            threadB.Priority = System.Threading.ThreadPriority.Normal;

            Thread threadD = new Thread(MyThreadClass.Thread2);
            threadD.Name = "Thread D";
            threadD.Priority = System.Threading.ThreadPriority.BelowNormal;

            // start all 4 threads so they run at the same time
            threadA.Start();
            threadB.Start();
            threadC.Start();
            threadD.Start();

            // wait here until every thread is fully done
            threadA.Join();
            threadB.Join();
            threadC.Join();
            threadD.Join();

            Console.WriteLine("-End of Thread-");

            // only update the label once all 4 threads have actually finished
            lblStatus.Text = "-End of Thread-";
        }
    }
}