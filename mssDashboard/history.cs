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
    class history
    {
        FlowLayoutPanel _pn;
        int MAX_HQ = 7;

        public history(ref FlowLayoutPanel pn)
        {
            _pn = pn;
        }
        private void addtoPanel(ucHistory _q)
        {
            if (_pn.InvokeRequired)
                _pn.Invoke(new MethodInvoker(() => { _pn.Controls.Add(_q); }));
            else
                _pn.Controls.Add(_q);
        }

        public void addQueue(string qn,string dest)
        {
            var _his = new ucHistory();
            _his.setDisplay(qn, dest);
            addtoPanel(_his);
            //_pn.Controls.Add(_his);
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

                    if (c.GetType() == typeof(ucHistory))
                    {
                        var h = (ucHistory)c;
                        if (x <= _pn.Controls.Count - MAX_HQ)
                        {
                            h.Visible = false;
                        }
                        else
                        {
                            var i = _pn.Controls.Count - x;
                            h.lbQ.BackColor = Color.FromArgb(i * 12, 31 + i * 12, 84 + i * 12);
                        }
                    }
                }
            }
        }
        public void removeQueue(string qn,string dest)
        {
            foreach (Control c in _pn.Controls)
            {
                if (c.GetType() == typeof(ucHistory))
                {
                    var h = (ucHistory)c;
                   if (h.checkQ(qn,dest))
                    {
                        _pn.Controls.Remove(h);
                    }
                    //myFlowLayoutPanel.Controls.Remove(c);
                }
            }
        }
    }
}
