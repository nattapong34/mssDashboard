using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mssDashboard.control
{
    public partial class queueDisplay : UserControl
    {
        bool blink;
        int count;

        BackgroundWorker bgWorker = new BackgroundWorker();
        private void bgWorker_DoWork(object sender, DoWorkEventArgs e)
        {


            BackgroundWorker worker = (BackgroundWorker)sender;
            while (!worker.CancellationPending)
            {
                setBlink();
                Thread.Sleep(800);

        
                //Console.WriteLine(wplayer.status);
            }
            if (worker.CancellationPending)
            {
                e.Cancel = true;
                return;
            }
        }

        // This event handler updates the progress.
        private void bgWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            // Update Progress Status to UI
        }

        // This event handler deals with the results of the background operation.
        private void bgWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            // Finish
        }
        public queueDisplay()
        {
            InitializeComponent();
            blink = false;
            count = 10;
            this.BackColor = Color.Gold;
            //tmTick.Enabled = true;

            bgWorker.WorkerSupportsCancellation = true;
            bgWorker.DoWork += new DoWorkEventHandler(bgWorker_DoWork);
            bgWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bgWorker_RunWorkerCompleted);
            bgWorker.ProgressChanged += new ProgressChangedEventHandler(bgWorker_ProgressChanged);

            bgWorker.RunWorkerAsync();
        }
        public void setQ(string qid,string send,string im)
        {

            lbQ.Text = qid;
            lbCounter.Text = send;

            if (im!=null)
            {
                try
                {
                    var request = WebRequest.Create(im);

                    using (var response = request.GetResponse())
                    using (var stream = response.GetResponseStream())
                    {
                        //   pbPerson.BackgroundImage = null;
                        pbPerson.BackgroundImage = Bitmap.FromStream(stream);
                    }
                }catch
                {

                }
            }
            else
            {
            }

            //if (im != null)
            //{
            //    WebRequest req = WebRequest.Create(im);
            //    Stream stream = req.GetResponse().GetResponseStream();
            //    pbPerson.BackgroundImage =  GetImageFromURL(im);
            //}
        }
        public bool checkQ(string q, string c)
        {
            //if (lbQ.Text == q && lbCounter.Text == c)
            //{
            //    return true;
            //}
            if (lbCounter.Text == c)
            {
                return true;
            }
            return false;
        }

        void setBlink()
        {
            blink = !blink;
            if (blink)
            {

                blinkBG(Color.Gold);
            }
            else
            {
                blinkBG(Color.Black);
            }
            this.count--;
            if (this.count <= 0)
            {
                // tmTick.Enabled = false;
                blinkBG(Color.Transparent);
                if (bgWorker.IsBusy)
                    bgWorker.CancelAsync();
            }
        }
        void blinkBG(Color c)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new MethodInvoker(delegate
                {
                    this.BackColor = c;
                }));
            }
            else
            {
                this.BackColor = c;
            }
        }
    }
}
