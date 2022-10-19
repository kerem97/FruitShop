using FruitShop.Models;
using FruitShop.Models.Classes;
using FruitShop.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace FruitShop.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        Context c=new Context();
      AdminRepository repo=new AdminRepository();
        public ActionResult Index()
        {
            var degerler = c.Admins.ToList();
            return View(degerler);
        }

        public ActionResult DeleteUser(int id)
        {
            Admin t = repo.Find(x => x.AdminId == id);
            repo.Delete(t);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult UpdateUser(int id)
        {
            Admin t = repo.Find(x => x.AdminId == id);
            return View(t);
        }
        [HttpPost]
        public ActionResult UpdateUser(Admin p)
        {
            Admin t = repo.Find(x => x.AdminId == p.AdminId);
            t.username = p.username;
            t.password = p.password;
            repo.TUpdate(t);
            return RedirectToAction("Index");
        }


    }
}