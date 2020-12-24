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
        public ucHistory()
        {
            InitializeComponent();
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

        private void tmLeft_Tick(object sender, EventArgs e)
        {
            var n = DateTime.Now.Subtract(timestart);
            //Console.WriteLine(string.Format("{0:D2}:{1:D2}", n.Minutes, n.Seconds));
            lbTimeleft.Text = string.Format("{0} นาที", n.Minutes);
        }
    }
}
