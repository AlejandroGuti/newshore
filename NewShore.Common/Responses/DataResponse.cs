using System;
using System.Collections.Generic;
using System.Text;

namespace NewShore.Common.Responses
{
    public class DataResponse
    {
        public ICollection<FlightsInfoResponse> flightsInfoResponses { get; set; }
    }
}
