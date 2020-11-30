using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace NewShore.Common.DTOs
{
    public class FlightDTO
    {

            [Required]
            [Display(Name = "Departure Station")]
            public string DepartureStation { get; set; }
            [Required]
            [Display(Name = "Arrival Station")]
            public string ArrivalStation { get; set; }
            [DisplayFormat(DataFormatString = "{yyyy-MM-dd}")]
            [Display(Name = "Departure Date")]
            [Required]
            public DateTime DepartureDate { get; set; }
            [Required]
            [Display(Name = "Flight Number")]
            public string FlightNumber { get; set; }
            [Required]
            [Display(Name = "UserEmail")]
            public string UserEmail { get; set; }
            [Required]
            [Display(Name = "Price")]
            public decimal Price { get; set; }
            [Required]
            [Display(Name = "Currency")]
            [StringLength(3, MinimumLength = 3)]
            public string Currency { get; set; }
        
    }
}
