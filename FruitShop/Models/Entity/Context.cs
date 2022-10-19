using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace FruitShop.Models.Classes
{
    public class Context : DbContext
    {

        public DbSet<About> Abouts { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Fruit> Fruits { get; set; }
        public DbSet<Default> Defaults { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<Contact> Contacts { get; set; }
    }
}