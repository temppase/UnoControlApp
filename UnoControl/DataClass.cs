using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnoControl
{
    public class DataClass
    {
        public int Interval_length { get; set; } // mm
        public int Interval_count { get; set; } // if uno can provide data in loop
        public int Interval_time { get; set; } // seconds
        public int Offset { get; set; }
        public int Direction { get; set; } // 1 min to max, -1 max to min 0 stop and reset
        public bool isLimit { get; set; } // if uno can provide data
        public bool Play { get; set; }
        public bool Stop { get; set; }
        public DataClass() { }

    }
}
