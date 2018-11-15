using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace cookiestore.Models
{
    public class Ingredient
    {
        public string Description { get; set; }

        public string Amount { get; set; }


        public Ingredient(string description, string amount = "one spoon")
        {
            Description = description;
            Amount = amount;
        }

    }
}