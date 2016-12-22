using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace HelpingHands.Models
{
    public class HelpingHandsEntities : DbContext
    {
        public DbSet<User> Users { get; set; }

        public HelpingHandsEntities() : base ("HelpingHandsEntities")
        {
        }
        
        
    }
}