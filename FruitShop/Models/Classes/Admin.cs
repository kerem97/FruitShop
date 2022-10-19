using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Services.Description;

namespace FruitShop.Models.Classes
{
    public class Admin
    {
        [Key]
        public int AdminId { get; set; }
       
        public string username { get; set; }
       
        public string password { get; set; }
        public string Authorization { get; set; }
    }
}