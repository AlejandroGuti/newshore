﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace NewShore.Infrastructure.Entities
{
    public class Transport
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Flight Number")]
        public string FlightNumber { get; set; }

        public ICollection<Flight> flights { get; set; }

    }
}
