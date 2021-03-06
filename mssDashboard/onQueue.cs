﻿using mssDashboard.control;
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


        private void addtoPanel(queueDisplay _q)
        {
            if (_pn.InvokeRequired)
                _pn.Invoke(new MethodInvoker(() => { _pn.Controls.Add(_q); }));
            else
                _pn.Controls.Add(_q);
        }
        private void removeQonPanel(queueDisplay h)
        {
            if (_pn.InvokeRequired)
                _pn.Invoke(new MethodInvoker(() => { _pn.Controls.Remove(h); }));
            else
                _pn.Controls.Remove(h);
        }

        public void addQueue(string qn, string dest,string im,string time=null)
        {
            var _q = new queueDisplay();
            _q.setQ(qn, dest,im);

            // remove befor add
            removeMainQueue(qn, dest);

            //_pn.Controls.Add(_q);
            addtoPanel(_q);
            visibleQueue();
        }
        public void removeMainQueue(string qn, string dest)
        {
            foreach (Control c in _pn.Controls)
            {
                if (c.GetType() == typeof(queueDisplay))
                {
                    var h = (queueDisplay)c;
                    if (h.checkQ(qn, dest))
                    {
                        removeQonPanel(h);
                        break;
                    }
                    //myFlowLayoutPanel.Controls.Remove(c);
                }
            }
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
                            removeQonPanel(h);
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
