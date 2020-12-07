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

namespace mssDashboard
{
    public partial class frmMain : Form
    {
        api _api;
        List<onQueue> _qq;
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            mediaPlayer.URL = Application.StartupPath + "//media/howto.mp4";
            mediaPlayer.settings.setMode("loop", true);

            mediaPlayer.Ctlcontrols.play();
            mediaPlayer.uiMode = "None";

            // queue

            
 


            _api = new api(Properties.Settings.Default.QSERVER_API, Properties.Settings.Default.QSERVER_API_PORT);
            
            var data=_api.api_getQueue().Result;
            var obj = JObject.Parse(data);
            foreach (JObject q in obj["data"])
            {
             //   Console.WriteLine(q);
                if (q["pre"].ToString()=="A")
                {
                    Console.WriteLine(q["qid"].ToString());
                }
                fatchDisplay(q);
            }
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
    }
}
