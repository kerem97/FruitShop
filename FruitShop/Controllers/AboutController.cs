using FruitShop.Models;
using FruitShop.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FruitShop.Controllers
{
    public class AboutController : Controller
    {
        // GET: About
        AboutRepository repo = new AboutRepository();
       
        public ActionResult Index()
        {
            var degerler = repo.List();
            return View(degerler);
        }
        [HttpGet]
        public ActionResult AddAbout()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddAbout(About p)
        {
            repo.TAdd(p);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult ShowAbout(int id)
        {
            About t = repo.Find(x => x.ID == id);
            return View(t);
        }
        [HttpPost]
        public ActionResult ShowAbout(About p)
        {
            About t = repo.Find(x => x.ID == p.ID);
            t.Title = p.Title;
            t.SubTitle = p.SubTitle;
            t.Image = p.Image;
            repo.TUpdate(t);
            return RedirectToAction("Index");
        }
        public ActionResult DeleteAbout(int id)
        {
            About t = repo.Find(x => x.ID == id);
            repo.Delete(t);
            return RedirectToAction("Index");
        }

    }
}