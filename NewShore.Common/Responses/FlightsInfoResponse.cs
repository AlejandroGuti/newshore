using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace NewShore.Common.Responses
{
    public class FlightsInfoResponse
    {

        public string DepartureDate { get; set; }
        public string DepartureStation { get; set; }
        public string ArrivalStation { get; set; }
        public string FlightNumber { get; set; }
        public decimal Price { get; set; }
        public string Currency { get; set; }

    }
}
