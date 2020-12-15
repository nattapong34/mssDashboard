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
    public partial class queueDisplay : UserControl
    {
        public queueDisplay()
        {
            InitializeComponent();
        }
        public void setQ(string qid,string send,Image im)
        {
            lbQ.Text = qid;
            lbCounter.Text = send;
            if (im!=null)
            pbPerson.BackgroundImage = im;
        }
    }
}
