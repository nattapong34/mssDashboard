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
using Newtonsoft.Json.Linq;
using SimpleTCP;

namespace mssDashboard
{
    public partial class frmMain : Form
    {
        api _api;
        List<onQueue> _qq;
        SimpleTcpServer server;
        history _his;

        public frmMain()
        {
            InitializeComponent();

        }

        private void Server_DataReceived(object sender, SimpleTCP.Message e)
        {
            //Update mesage to txtStatus
            txtStatus.Invoke((MethodInvoker)delegate ()
            {
                txtStatus.Text += e.MessageString;
                e.ReplyLine(string.Format("You said: {0}", e.MessageString));
            });
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            mediaPlayer.URL = Application.StartupPath + "//media/howto.mp4";
            mediaPlayer.settings.setMode("loop", true);

            mediaPlayer.Ctlcontrols.play();
            mediaPlayer.uiMode = "None";

            // queue

            server = new SimpleTcpServer();
            server.Delimiter = 0x13;//enter
            server.StringEncoder = Encoding.UTF8;
            server.DataReceived += Server_DataReceived;

            txtStatus.Text += "Server starting...";
            System.Net.IPAddress ip = System.Net.IPAddress.Parse("127.0.0.1");
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
            _his.addQueue("A1", "2");
            _his.addQueue("A2", "2");
            _his.addQueue("B1", "3");
            _his.addQueue("B1", "3");
            _his.addQueue("C1", "1");
        }

        private void fatchDisplay(JObject q)
        {
            if (q["pre"].ToString()==Properties.Settings.Default.QSTATION1)
            {

            }
            else if (q["pre"].ToString() == Properties.Settings.Default.QSTATION2)
            {

            }
            else if (q["pre"].ToString() == Properties.Settings.Default.QSTATION3)
            {

            }
        }

        private void tmClock_Tick(object sender, EventArgs e)
        {
            lbClock.Text = DateTime.Now.ToString("G");
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (server.IsStarted)
                server.Stop();
        }

        private void mediaPlayer_Enter(object sender, EventArgs e)
        {

        }
    }
}
