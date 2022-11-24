using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApiHttpresponseMessage.Controllers
{
    public class ProductController : ApiController
    {
        public string[] GetAll()
        {
            string[] products = { "Tv", "Mobile", "Fridge", "Bike", "Laptop" };
            return products;
        }
        public string Getprodct(int id)
        {
            string[] products = { "Tv", "Mobile", "Fridge", "Bike", "Laptop" };
            if(id>=0 && id <= 4)
            {
                return products[id];
            }
            else
            {
                return "NotFound";
            }
        }
    }
}
