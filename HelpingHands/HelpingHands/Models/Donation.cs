using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.Mvc;
using System.ComponentModel;

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

        [DisplayName("Category")]
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }

        [DisplayName("Location")]
        public int LocationId { get; set; }
        public virtual Location Location { get; set; }

        [ScaffoldColumn(false)]
        public string UserName { get; set; }
                
        public string Quantity { get; set; }

        public string DateTime { get; set; }
       
        public string Description { get; set; }        
    }
}