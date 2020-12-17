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
        public queueDisplay()
        {
            InitializeComponent();
        }
        public void setQ(string qid,string send,string im)
        {

            lbQ.Text = qid;
            lbCounter.Text = send;

            if (im != null)
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
            //if (im != null)
            //{
            //    WebRequest req = WebRequest.Create(im);
            //    Stream stream = req.GetResponse().GetResponseStream();
            //    pbPerson.BackgroundImage =  GetImageFromURL(im);
            //}
        }
        public bool checkQ(string q, string c)
        {
            if (lbQ.Text == q && lbCounter.Text == c)
            {
                return true;
            }
            return false;
        }
    }
}
