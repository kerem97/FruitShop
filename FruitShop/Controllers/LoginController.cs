using FruitShop.Models.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace FruitShop.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        // GET: Login
        
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Admin p)
        {
            Context c = new Context();
            var user = c.Admins.FirstOrDefault(x => x.username == p.username && x.password == p.password);
            if (user != null)
            {
                FormsAuthentication.SetAuthCookie(user.username, true);
                Session["username"] = user.username.ToString();
                return RedirectToAction("Index", "Admin");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
            
        }
    }
}
