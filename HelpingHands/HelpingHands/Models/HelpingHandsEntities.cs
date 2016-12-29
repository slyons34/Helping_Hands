using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace HelpingHands.Models 
{
    public class HelpingHandsEntities : DbContext
    {
  
        public DbSet<User> Users { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Donation> Donations { get; set; }

        public HelpingHandsEntities() : base ("HelpingHandsEntities")
        {
            //Database.SetInitializer<SchoolDBContext>(new CreateDatabaseIfNotExists<SchoolDBContext>());
            //Database.SetInitializer<HelpingHandsEntities>(new DropCreateDatabaseAlways<HelpingHandsEntities>());
            Database.SetInitializer<HelpingHandsEntities>(new DropCreateDatabaseIfModelChanges<HelpingHandsEntities>());           
        }


        public User GetUser(string userName)
        {
            User user = (from u in Users
                         where u.UserName.Equals(userName)
                         select u).FirstOrDefault();
            return user;
        }
        
    }
}