using System;
using System.Collections.Generic;
using System.Text;

namespace NewShore.Infrastructure.Entities
{
    public class Flight
    {
        public int id { get; set; }
        public string DepartureStation { get; set; }
        public string ArrivalStation { get; set; }
        public DateTime DepartureDate { get; set; }
        public Transport Transport { get; set; }
        public decimal Price { get; set; }
        public string Currency { get; set; } 
    }
}
