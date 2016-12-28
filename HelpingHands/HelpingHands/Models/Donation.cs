using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace HelpingHands.Models
{
    public class Donation
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Location { get; set; }
        public string Item { get; set; }
        public string Quantity { get; set; }
        public string DateTime { get; set; }
        
        public string Description { get; set; }        
    }
}