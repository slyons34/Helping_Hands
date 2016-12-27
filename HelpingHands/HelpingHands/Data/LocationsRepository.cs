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
                Id = 1,
                Name = "Greater Cleveland Food Bank",
                Adress1 = "15500 South Waterloo Rd.",
                Adress2 = "",
                City = "Cleveland",
                State = "OH",
                ZipCode = "44110",
                Phone = "216-738-2265",
                Hours = "8:30am - 4:00 pm"
            },
            new Location()
            {
                Id = 2,
                Name = "Parma Christian Church Diciples of Christ",
                Adress1 = "7000 Ridge Rd.",
                Adress2 = "",
                City = "Cleveland",
                State = "OH",
                ZipCode = "44129",
                Phone = "440-842-1614",
                Hours = "9:00am - 1:00 pm"
            },
            new Location()
            {
                Id = 3,
                Name = "Kosher Food Bank",
                Adress1 = "2004 S Green Rd.",
                Adress2 = "",
                City = "Cleveland",
                State = "OH",
                ZipCode = "44121",
                Phone = "216-382-7202",
                Hours = ""
            },
            new Location()
            {
                Id = 4,
                Name = "Huger Network of Grater Cleveland",
                Adress1 = "614 West Superior Av.",
                Adress2 = "Suit 744",
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