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
        public bool Direction { get; set; } // 0 start to end, 1 end to start
        public bool isLimit { get; set; } // if uno can provide data
        public DataClass() { }
    }
}
