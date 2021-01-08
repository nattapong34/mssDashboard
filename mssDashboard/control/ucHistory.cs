using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mssDashboard.control
{
    public partial class ucHistory : UserControl
    {
        DateTime timestart;
        BackgroundWorker bw;
        public ucHistory()
        {
            InitializeComponent();
            this.bw = new BackgroundWorker();
            this.bw.DoWork += new DoWorkEventHandler(bw_DoWork);
            this.bw.ProgressChanged += new ProgressChangedEventHandler(bw_ProgressChanged);
            this.bw.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bw_RunWorkerCompleted);
            this.bw.WorkerReportsProgress = true;
            this.bw.RunWorkerAsync();
        }
        private void bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

        }

        private void bw_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
        }

        private void bw_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = (BackgroundWorker)sender;
            while (true)
            {
                setTime();
                // pretend like this a really complex calculation going on eating up CPU time

                System.Threading.Thread.Sleep(100);
            }
        }
        void setTime()
        {
            var n = DateTime.Now.Subtract(timestart);
            if (lbTimeleft.InvokeRequired)
            {
                lbTimeleft.Invoke(new Action(setTime));
                return;
            }
            else
            {
                lbTimeleft.Text = string.Format("{0} นาที", n.Minutes);
            }
        }
        public void setDisplay(string q,string c)
        {
            lbQ.Text = q;
            lbCounter.Text = c;
            timestart = new DateTime();
            timestart = DateTime.Now;
           // lbTimeleft.Text = timestart.ToString("hh:mm");
        }
        public void clear()
        {
            lbQ.Text = "";
            lbQ.Text = "";
        }
        public bool checkQ(string q,string c)
        {
            if (lbQ.Text == q && lbCounter.Text==c)
            {
                return true;
            }

            return false;
        }

    }
}
