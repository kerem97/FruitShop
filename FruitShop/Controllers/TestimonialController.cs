using FruitShop.Models;
using FruitShop.Models.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FruitShop.Repositories;

namespace FruitShop.Controllers
{
    public class TestimonialController : Controller
    {
        // GET: Testimonial
        Context c = new Context();
        TestimonialRepository repo=new TestimonialRepository();
        public ActionResult Index()
        {
            var degerler = repo.List();
            return View(degerler);
        }
      

        public ActionResult Delete(int id)
        {
            Testimonial t = repo.Find(x => x.ID == id);
            repo.Delete(t);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Update(int id)
        {
            Testimonial t = repo.Find(x => x.ID == id);
            return View(t);
        }
        [HttpPost]
        public ActionResult Update(Testimonial p)
        {
            Testimonial t = repo.Find(x => x.ID == p.ID);
            t.Name = p.Name;
            t.Message = p.Message;   
            repo.TUpdate(t);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Add(Testimonial p)
        {
            repo.TAdd(p);
            return RedirectToAction("Index");
        }
    }
}