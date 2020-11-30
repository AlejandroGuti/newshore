using System;
using System.ComponentModel.DataAnnotations;

namespace NewShore.Common.Requests
{
    public class FlightsInfoRequest
    {
        [Required]
        [StringLength(3, MinimumLength = 3)]
        public string Origin { get; set; }
        [Required]
        [StringLength(3, MinimumLength = 3)]
        public string Destination { get; set; }
        [DisplayFormat(DataFormatString = "{yyyy-MM-dd}")]
        [Display(Name = "From")]
        public DateTime From { get; set; }
    }
}
