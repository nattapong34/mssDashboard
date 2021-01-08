using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dbAPI;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SimpleTCP;
using mssDashboard.Properties;

namespace mssDashboard
{
    public partial class frmMain : Form
    {
        SimpleTcpServer server;
        history _his;
        onQueue _q;

     //   Queue<JObject> _cal = new Queue<JObject>();
        soundCalling.cSound sd = new soundCalling.cSound();

        string APIURL = $"http://{Settings.Default.QSERVER_API}:{Settings.Default.QSERVER_API_PORT}";
        string APIIMG = $"http://{Settings.Default.QSERVER_API}:{Settings.Default.QSERVER_API_PORT}/personImage/";

        private void countQueue()
        {
            lbQCount.Text = (pnMainQ.Controls.Count + pnHis.Controls.Count).ToString();
            lbQSkip.Text = pnHis.Controls.Count.ToString();
        }
        public frmMain()
        {
            InitializeComponent();
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("th-TH");

            //sd.talkCallingQ("A","1","1");
            //sd.talkCallingQ("A", "2", "1");
            //sd.talkCallingQ("B", "1", "2");
        }



        private void Server_DataReceived(object sender, SimpleTCP.Message e)
        {

            string msg = e.MessageString;
            msg = msg.Substring(0, msg.IndexOf("\u0013"));
            var obj = JObject.Parse(msg);

            if (obj["data"].Count() > 0)
            {
                var q = obj["data"];
                Console.WriteLine(q);



                if (q["status"].ToString() == "W" || q["status"].ToString()=="C")
                {
                   // MessageBox.Show(APIIMG + q["person"]["imagefile"].ToString());
                    _q.addQueue(q["pre"].ToString() + q["qid"].ToString(), q["station"].ToString(), APIIMG + q["person"]["imagefile"].ToString());
                    sd.talkCallingQ(q["pre"].ToString(), q["qid"].ToString(), q["station"].ToString());
                }
                else if (q["status"].ToString() == "S")
                {
                    _his.addQueue(q["pre"].ToString() + q["qid"].ToString(), q["station"].ToString());
                    _q.removeMainQueue(q["pre"].ToString() + q["qid"].ToString(), q["station"].ToString());
                }
                else if (q["status"].ToString() == "R")    // remove  history
                {
                    _his.removeQueue(q["pre"].ToString() + q["qid"].ToString(), q["station"].ToString());
                }

                //string replyMessage = "OK"; //This is the reply message
                // e.ReplyLine(replyMessage);
            }


            txtStatus.Invoke((MethodInvoker)delegate ()
            {
                txtStatus.Text += e.MessageString;
            });
        }

        private void frmMain_LoadAsync(object sender, EventArgs e)
        {
            mediaPlayer.URL = Application.StartupPath + Properties.Settings.Default.VDOFILE;
            mediaPlayer.settings.setMode("loop", true);

            mediaPlayer.Ctlcontrols.play();
            mediaPlayer.uiMode = "None";

            // queue

            server = new SimpleTcpServer();
            server.Delimiter = 0x13;//enter
            server.StringEncoder = Encoding.UTF8;
            server.DataReceived += Server_DataReceived;

            txtStatus.Text += "Server starting...";
            System.Net.IPAddress ip = System.Net.IPAddress.Parse(Properties.Settings.Default.MY_IP);
            server.Start(ip, Convert.ToInt32(Properties.Settings.Default.SOCKET_PORT));


            //_api = new api(Properties.Settings.Default.QSERVER_API, Properties.Settings.Default.QSERVER_API_PORT);

            //var data=_api.api_getQueue().Result;
            //var obj = JObject.Parse(data);
            //foreach (JObject q in obj["data"])
            //{
            // //   Console.WriteLine(q);
            //    if (q["pre"].ToString()=="A")
            //    {
            //        Console.WriteLine(q["qid"].ToString());
            //    }
            //    fatchDisplay(q);
            //}
            _his = new history(ref pnHis);
            //_his.addQueue("A1", "2");
            //_his.addQueue("A2", "2");
            //_his.addQueue("B1", "3");
            //_his.addQueue("B2", "3");
            //_his.addQueue("C1", "1");
            //_his.addQueue("A3", "2");
            //_his.addQueue("A4", "2");
            //_his.addQueue("B3", "3");
            //_his.addQueue("B4", "3");
            //_his.addQueue("C2", "1");
            //_his.removeQueue("A2", "2");

            _q = new onQueue(ref pnMainQ);
            //var img = APIIMG + $"T25.png";
            //_q.addQueue("A5", "1", APIIMG + "tom3.png");
            //_q.addQueue("B5", "2", APIIMG + "tom.jpg");
            //_q.addQueue("C3", "3", "http://10.91.1.200:3000/personImage/T25.png");


            //var dt = DateTime.Parse("2020-12-15T06:33:48.224Z");
            //Console.WriteLine(dt);

            countQueue();


            // sd.talkCallingQ("A","101","4");
            // sd.talkCallingQ("A", "21", "2");
            // sd.talkNum("21");
            // sd.talkNum("31");
            //  MessageBox.Show(sd.readNum((99).ToString()));
        }
        void talkQueue()
        {
            //sd.talkCallingQ("A", "21", "2");
        }
        private void tmClock_Tick(object sender, EventArgs e)
        {
            lbClock.Text = DateTime.Now.ToString("F");
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (server.IsStarted)
                server.Stop();
        }

        private void mediaPlayer_Enter(object sender, EventArgs e)
        {

        }

        private void pnHis_ControlAdded(object sender, ControlEventArgs e)
        {
            countQueue();
        }

        private void pnHis_ControlRemoved(object sender, ControlEventArgs e)
        {
            countQueue();
        }

        private void pnMainQ_ControlAdded(object sender, ControlEventArgs e)
        {
            countQueue();
        }

        private void pnMainQ_ControlRemoved(object sender, ControlEventArgs e)
        {
            countQueue();
        }

        private void pbLogo_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("ต้องการออกจากโปรแกรม", "กรุณายืนยัน", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Dispose();
            }
        }
    }
}
