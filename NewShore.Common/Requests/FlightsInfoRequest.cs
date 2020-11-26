using System;
using System.Collections.Generic;
using System.Text;

namespace NewShore.Common.Requests
{
    public class FlightsInfoRequest
    {
        public string Origin { get; set; }
        public string Destination { get; set; }
        public DateTime From { get; set; }
    }
}
