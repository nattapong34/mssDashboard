using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mssDashboard
{
    public partial class frmMain : Form
    {
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
        }
    }
}
