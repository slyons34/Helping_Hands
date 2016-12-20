using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HelpingHands.Models
{
    public class Users
    {
        public int id { get; set; }
        public string UserId { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
    }
}