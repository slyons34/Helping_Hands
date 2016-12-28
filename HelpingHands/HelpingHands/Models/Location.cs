using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HelpingHands.Models
{
    public class Location
    {
        public int LocId { get; set; }
        public string Name { get; set; }
        public string Adress1 { get; set; }
        public string Adress2 { get; set; }
        public string Phone { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string Hours { get; set; }
    }
}