using System;
using System.Threading;
using System.Windows.Forms;

namespace BasicThreading
{
    public partial class FrmBasicThread : Form
    {
        public FrmBasicThread()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            Console.WriteLine("-Before starting thread-");

            // create and name the two threads, both pointing to the same method
            Thread threadA = new Thread(MyThreadClass.Thread1);
            threadA.Name = "Thread A";

            Thread threadB = new Thread(MyThreadClass.Thread1);
            threadB.Name = "Thread B";

            // start both threads so they run at the same time
            threadA.Start();
            threadB.Start();

            // Join() pauses this method here until both threads are fully done
            threadA.Join();
            threadB.Join();

            Console.WriteLine("-End of Thread-");

            // only update the label once both threads have actually finished
            lblStatus.Text = "-End of Thread-";
        }
    }
}