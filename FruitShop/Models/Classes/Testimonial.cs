using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FruitShop.Models
{
    public class Testimonial
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string Message { get; set; }
    }
}