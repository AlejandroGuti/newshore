using NewShore.Common.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace NewShore.Common.Requests
{
    public class UserRequest
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Document { get; set; }
        public UserType UserType { get; set; }
    }
}
