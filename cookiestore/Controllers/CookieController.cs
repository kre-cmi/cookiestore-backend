using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using cookiestore.Models;

namespace cookiestore.Controllers
{
    public class CookieController : ApiController
    {
        public IHttpActionResult GetCookie(int id)
        {
            var cookie = new Models.Cookie()
            {
                Id = id,
                Baker = new Grandma("Marry"),
                Ingredients = new List<Ingredient>
                {
                    new Ingredient("sugar"),
                    new Ingredient("eggs", "5"),
                    new Ingredient("flour", "1 kg")
                }
            };
            return Ok(cookie);
        }
    }
}
