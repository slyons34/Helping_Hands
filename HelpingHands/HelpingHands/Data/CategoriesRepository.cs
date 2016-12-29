using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HelpingHands.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HelpingHands.Data
{
    public class CategoriesRepository
    {
        private static Category[] myCategories = new Category[]
        {
            new Category() //
            {
                CategoryId = 1,
                Description = "VolunteerTime"
            },
            new Category()
            {
                CategoryId = 2,
                Description = "Food"
            },
            new Category()
            {
                CategoryId = 3,
                Description = "Money"
            },
            new Category()
            {
                CategoryId = 4,
                Description = "Clothes"
            }
        };

        public Category GetCategories(int Catid)
        {
            Category myCategories = null;

            return myCategories;
        }


    }
}