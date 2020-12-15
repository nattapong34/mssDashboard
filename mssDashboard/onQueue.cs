using mssDashboard.control;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mssDashboard
{
    class onQueue
    {
        FlowLayoutPanel _pn;
        int MAX_HQ = 3;

        public onQueue(ref FlowLayoutPanel pn)
        {
            _pn = pn;
        }
        public void addQueue(string qn, string dest,Image im)
        {
            var _q = new queueDisplay();
            _q.setQ(qn, dest,im);
            _pn.Controls.Add(_q);
            visibleQueue();
        }
        public void visibleQueue()
        {
            if (_pn.Controls.Count >= MAX_HQ)
            {
                int x = 0;

                foreach (Control c in _pn.Controls)
                {
                    x++;

                    if (c.GetType() == typeof(queueDisplay))
                    {
                        var h = (queueDisplay)c;
                        if (x <= _pn.Controls.Count - MAX_HQ)
                        {
                            _pn.Controls.Remove(h);
                        }
                        else
                        {
                            var i = _pn.Controls.Count - x;
                            h.lbQ.BackColor = Color.FromArgb(i * 5, 31 - i *5, 84 - i * 5);
                            h.lbCounter.BackColor = Color.FromArgb(i * 5, 31 - i * 5, 84 - i * 5);
                        }
                    }
                }
            }
        }
        public void removeQueue(string qn, string dest)
        {
            foreach (Control c in _pn.Controls)
            {
                if (c.GetType() == typeof(ucHistory))
                {
                    var h = (ucHistory)c;
                    if (h.checkQ(qn, dest))
                    {
                        _pn.Controls.Remove(h);
                    }
                    //myFlowLayoutPanel.Controls.Remove(c);
                }
            }
        }
    }
}
