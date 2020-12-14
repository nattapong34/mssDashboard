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
        public ucHistory()
        {
            InitializeComponent();
        }
        public void setDisplay(string q,string c)
        {
            lbQ.Text = q;
            lbCounter.Text = c;
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
