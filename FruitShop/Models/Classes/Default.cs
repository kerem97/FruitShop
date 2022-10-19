using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FruitShop.Models
{
    public class Default
    {
        [Key]
        public int ID { get; set; }
        public string Title1 { get; set; }
        public string Description1 { get; set; }
        public string Photo1 { get; set; }
       

       
    }
}