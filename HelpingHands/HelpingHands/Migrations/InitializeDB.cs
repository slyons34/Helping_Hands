using HelpingHands.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HelpingHands.Migrations
{
    public class InitializeDB
    {
        public static void Initialize()
        {
            //Database.Initialize(true);

            HelpingHandsEntities context=new Models.HelpingHandsEntities();
            context.Database.ExecuteSqlCommand("sp_MSForEachTable 'ALTER TABLE ? NOCHECK CONSTRAINT ALL'");
            context.Database.ExecuteSqlCommand("sp_MSForEachTable 'IF OBJECT_ID(''?'') NOT IN (ISNULL(OBJECT_ID(''[dbo].[__MigrationHistory]''),0)) DELETE FROM ?'");
            context.Database.ExecuteSqlCommand("EXEC sp_MSForEachTable 'ALTER TABLE ? CHECK CONSTRAINT ALL'");
            context.SaveChanges();

            context.Categories.Add(new Category { Description = "Time(Volunteer)" });
            context.Categories.Add(new Category { Description = "Food" });
            context.Categories.Add(new Category { Description = "Money" });
            context.Categories.Add(new Category { Description = "Clothes" });
            context.Categories.Add(new Category { Description = "Books" });
            context.SaveChanges();

            context.Locations.Add(new Location
            {
                LocationId = 1,
                Name = "Greater Cleveland Food Bank",
                Address1 = "15500 South Waterloo Rd.",
                Address2 = "",
                City = "Cleveland",
                State = "OH",
                ZipCode = "44110",
                Phone = "216-738-2265",
                Hours = "8:30am - 4:00 pm"
            });
            context.Locations.Add(new Location
            {
                LocationId = 2,
                Name = "Parma Christian Church Disciples of Christ",
                Address1 = "7000 Ridge Rd.",
                Address2 = "",
                City = "Cleveland",
                State = "OH",
                ZipCode = "44129",
                Phone = "440-842-1614",
                Hours = "9:00am - 1:00 pm"
            });
            context.Locations.Add(new Location
            {
                LocationId = 3,
                Name = "Kosher Food Bank",
                Address1 = "2004 S Green Rd.",
                Address2 = "",
                City = "Cleveland",
                State = "OH",
                ZipCode = "44121",
                Phone = "216-382-7202",
                Hours = ""
            });
            context.Locations.Add(new Location
            {
                LocationId = 4,
                Name = "Hunger Network of Greater Cleveland",
                Address1 = "614 West Superior Ave.",
                Address2 = "Suite 744",
                City = "Cleveland",
                State = "OH",
                ZipCode = "44113",
                Phone = "216-619-8155",
                Hours = ""
            });
            context.SaveChanges();

            context.Users.Add(new User
            {
                Id = 1,
                UserName = "AnthonyH",
                Email = "stoneah@yahoo.com",
                Password = "amh12345",
                ConfirmPassword = "amh12345",
                Role = "admin",                
            });

            context.Users.Add(new User
            {
                Id = 1,
                UserName = "hhadmin",
                Email = "teamhelpinghands5@gmail.com",
                Password = "hhadmin",
                ConfirmPassword = "hhadmin",
                Role = "admin",
            });

            context.Users.Add(new User
            {
                Id = 1,
                UserName = "mcmejorado",
                Email = "lluvia_dgo@yahoo.com",
                Password = "mcmejorado",
                ConfirmPassword = "mcmejorado",
                Role = "admin",
            });

            context.SaveChanges();

        }
    }
}