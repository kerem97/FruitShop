using FruitShop.Models;
using FruitShop.Models.Classes;
using FruitShop.Repositories;
using System;
using System.Collections.Generic;
using System.Data.Common.CommandTrees;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FruitShop.Controllers
{
    public class FruitController : Controller
    {

        // GET: Fruit
        FruitRepository repo = new FruitRepository();
        
        public ActionResult Index()
        {
            var degerler = repo.List();
            return View(degerler);
        }
        [HttpGet]
        public ActionResult AddFruit()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddFruit(Fruit p)
        {
            repo.TAdd(p);
            return RedirectToAction("Index");
        }
        public ActionResult DeleteFruit(int id)
        {
            Fruit t = repo.Find(x => x.ID == id);
            repo.Delete(t);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult ShowFruit(int id)
        {
            Fruit t = repo.Find(x => x.ID == id);
            return View(t);
        }
        [HttpPost]
        public ActionResult ShowFruit(Fruit p)
        {
            Fruit t = repo.Find(x => x.ID == p.ID);
            t.Name = p.Name;
            t.Image = p.Image;
            t.Price = p.Price;
            t.Piece = p.Piece;
            repo.TUpdate(t);
            return RedirectToAction("Index");
        }

    }
}