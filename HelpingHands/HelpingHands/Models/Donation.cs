using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Security;

namespace HelpingHands.Models
{
    public class Donation
    {
        public Donation()
        {
            if (HttpContext.Current.User.Identity.Name == null)
                UserName = "anonymous";
            else UserName = HttpContext.Current.User.Identity.Name;
        }
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string UserName { get; set; }
        public Location Location { get; set; }
        public Category Item { get; set; }
        public string Quantity { get; set; }
        public string DateTime { get; set; }
       
        public string Description { get; set; }        
    }
}