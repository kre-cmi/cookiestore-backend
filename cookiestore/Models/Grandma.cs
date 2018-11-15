using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace cookiestore.Models
{
    public class Grandma
    {
        public Grandma(string name)
        {
            Name = name;
        }
        public string Name { get; set; }
    }
}