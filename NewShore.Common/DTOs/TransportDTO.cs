using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace NewShore.Common.DTOs
{
    public class TransportDTO 
    {
        [Required]
        [Display(Name = "Flight Number")]
        public string FlightNumber { get; set; }
    }
}
