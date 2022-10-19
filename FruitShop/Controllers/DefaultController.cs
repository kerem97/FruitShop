using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FruitShop.Repositories;
using System.Web.Mvc;
using FruitShop.Models.Classes;
using FruitShop.Models;

namespace FruitShop.Controllers
{
    [AllowAnonymous]
    public class DefaultController : Controller
    {
        // GET: Default
       

        Context c = new Context();
        TestimonialRepository repo = new TestimonialRepository();
        FruitRepository repo2 = new FruitRepository();
        ContactRepository x = new ContactRepository();
        public ActionResult Index()
        {
            
            var degerler = repo2.List();         
            return View(degerler);
        }
        public PartialViewResult PartialFruit()
        {
           
            var degerler = repo2.List();
            return PartialView(degerler);
            
        }
        public PartialViewResult PartialAbout()
        {
            return PartialView();
        }
        [HttpGet]
        public ActionResult About() 
        {
            AboutRepository repo = new AboutRepository();
            var degerler = repo.List();
            return View(degerler);
        }
        [HttpGet]
        public ActionResult Fruit()
        {
            FruitRepository repo2 = new FruitRepository();
            var degerler = repo2.List();
            return View(degerler);
        }
        public ActionResult Testimonial()
        {
            var degerler = repo.List();
            return View(degerler);
        }
      

        }
    }
