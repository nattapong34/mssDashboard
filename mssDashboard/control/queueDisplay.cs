using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mssDashboard.control
{
    public partial class queueDisplay : UserControl
    {
        bool blink;
        int count;
        public queueDisplay()
        {
            InitializeComponent();
            blink = false;
            count = 6;
            this.BackColor = Color.Gold;
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

        private void tmTrick_Tick(object sender, EventArgs e)
        {       
            blink = !blink;
            if (blink)
            {
            
                this.BackColor = Color.Gold;
            }
            else
            {
                this.BackColor = Color.Transparent;
            }
            this.count--;
            //if (this.count==0)
            //{
            //    tmTrick.Enabled = false;
            //    this.BackColor = Color.Transparent;
            //}
            Console.WriteLine(blink.ToString());
        }
    }
}
