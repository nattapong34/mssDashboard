using mssDashboard.control;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mssDashboard
{
    class history
    {
        FlowLayoutPanel _pn;

        public history(ref FlowLayoutPanel pn)
        {
            _pn = pn;
        }

        public void addQueue(string qn,string dest)
        {
            var _his = new ucHistory();
            _his.setDisplay(qn, dest);
            _pn.Controls.Add(_his);
        }
        public void removeQueue(string qn,string dest)
        {
            foreach (Control c in _pn.Controls)
            {
                if (c.GetType() == typeof(ucHistory))
                {
                    //myFlowLayoutPanel.Controls.Remove(c);
                }
            }
        }
    }
}
