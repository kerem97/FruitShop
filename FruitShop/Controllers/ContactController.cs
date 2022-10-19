using FruitShop.Models;
using FruitShop.Models.Classes;
using FruitShop.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace FruitShop.Controllers
{
    [AllowAnonymous]
    public class ContactController : Controller
    {
        // GET: Contact
        ContactRepository c = new ContactRepository();
      
        public ActionResult Index()
        {
            var degerler = c.List();
            return View(degerler);
        }

        [HttpGet]
        public ActionResult Contact()
        {

            return View();

        }
        [HttpPost]
        public ActionResult Contact(Contact p)
        {
            c.TAdd(p);
            return RedirectToAction("Contact");

        }
        public ActionResult DeleteMessage(int id)
        {
            Contact t = c.Find(x => x.ID == id);
            c.Delete(t);
            return RedirectToAction("Index");
        }
    }
}