using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity;
using System.Web.Mvc;
using FinalProject.Models;

namespace FinalProject.Controllers
{
    public class HomeController : Controller
    {
        private StoreModelContext db = new StoreModelContext();

        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }
        public ActionResult Order()
        {
            if (!Request.IsAuthenticated)
            {
                return RedirectToAction("Login", "Auth", new { area = "" });
            }

            ViewBag.Title = "Order Page";

            return View();
        }
        public ActionResult Cart()
        {
            if (!Request.IsAuthenticated)
            {
                return RedirectToAction("Login", "Auth", new { area = "" });
            }

            ViewBag.Title = "Cart Page";

            string userid = User.Identity.GetUserId();
            var cartitems = from t1 in db.Cart join t2 in db.Item on t1.itemid equals t2.Id where t1.userid == userid select new ItemResult() { Id = t2.Id, name = t2.name, price = t2.price };

            return View(cartitems);
        }
        public ActionResult OrderHistory()
        {
            if (!Request.IsAuthenticated)
            {
                return RedirectToAction("Login", "Auth", new { area = "" });
            }

            ViewBag.Title = "Order History Page";

            return View();
        }
    }
}
