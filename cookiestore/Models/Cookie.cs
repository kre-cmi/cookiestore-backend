using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace cookiestore.Models
{
    public class Cookie
    {
        public List<Ingredient> Ingredients { get; set; } = new List<Ingredient>();

        public Grandma Baker { get; set;}

        public int Id { get; set; }


    }
}