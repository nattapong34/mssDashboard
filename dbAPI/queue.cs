using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dbAPI
{
    public class onQueue
    {
        public string pre  { get;set; }
        public int n { get; set; }
        public string status { get; set; }
        public DateTime create_datetime { get; set; }

        public onQueue(string p)
        {
            this.pre = p;
        }


    }
}
