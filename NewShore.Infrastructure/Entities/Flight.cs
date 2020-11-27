using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace NewShore.Infrastructure.Entities
{
    public class Flight
    {
        public int Id { get; set; }
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
        [Display(Name = "Transport")]
        public Transport Transport { get; set; }
        [Required]
        [Display(Name = "Price")]
        public decimal Price { get; set; }
        [Required]
        [Display(Name = "Currency")]
        public string Currency { get; set; } 
    }
}
