using System;
using System.ComponentModel.DataAnnotations;

namespace NewShore.Common.Requests
{
    public class FlightsInfoRequest
    {
        [Required]
        public string Origin { get; set; }
        [Required]
        public string Destination { get; set; }
        [DisplayFormat(DataFormatString = "{yyyy-MM-dd}")]
        [Display(Name = "From")]
        public DateTime From { get; set; }
    }
}
