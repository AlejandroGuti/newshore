using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace NewShore.Common.DTOs
{
    public class TransportListDTO
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Flight Number")]
        public string FlightNumber { get; set; }

    }
}
