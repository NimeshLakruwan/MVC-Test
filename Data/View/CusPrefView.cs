using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.View
{
    public class CusPrefView
    {
        public int CustomerPreferenceSerial { get; set; }
        public int CustomerSerial { get; set; }
        public string CustomerLike { get; set; }
        public string CustomerDisLike { get; set; }
        public string CustomerFeedBack { get; set; }
    }
}
