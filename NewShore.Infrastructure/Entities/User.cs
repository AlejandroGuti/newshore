
using Microsoft.AspNetCore.Identity;
using NewShore.Common.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace NewShore.Infrastructure.Entities
{
    public class User : IdentityUser
    {
        [MaxLength(32)]
        [Required]
        public string Document { get; set; }

        [Display(Name = "First Name")]
        [MaxLength(50)]
        [Required]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [MaxLength(50)]
        [Required]
        public string LastName { get; set; }

        [Display(Name = "User Type")]
        public UserType UserType { get; set; }

    }
}
