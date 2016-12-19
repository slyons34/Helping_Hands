using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HelpingHands.Models;

namespace HelpingHands.Data
{
    public class CategoriesRepository
    {
        private static Categories[] myCategories = new Categories[]
        {
            new Categories()
            {
                Id = 1,
                Description = "VolunteerTime"
            },
            new Categories()
            {
                Id = 2,
                Description = "Food"
            },
            new Categories()
            {
                Id = 3,
                Description = "Money"
            },
            new Categories()
            {
                Id = 4,
                Description = "Clothes"
            }
        };

        public Categories GetCategories(int id)
        {
            Categories myCategories = null;

            return myCategories;
        }


    }
}