using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HelpingHands.Models;
//using HelpingHands.Data;

namespace HelpingHands.Data
{
    public class LocationsRepository
    {
        private static Location[] myLocations = new Location[]
        {
            new Location()
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
            },
            new Location()
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
            },
            new Location()
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
            },
            new Location()
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
            },
        };

       public Location[] GetLocations
        { 
            get
            {                
               return myLocations;
            }
        }
    }
}