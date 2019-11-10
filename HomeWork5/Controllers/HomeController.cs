using HomeWork5.DataAccess;
using HomeWork5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HomeWork5.Controllers
{
    public class HomeController : Controller
    {
        WallContext wallContext = new WallContext();
        // GET: Home
        public ActionResult Index()
        {
            using (var context = new WallContext())
            {
                var posts = context.Posts.ToList();

                // 2 способ
                ViewData["Posts"] = posts;
            }
            return View();
        }

        [HttpPost]
        public ActionResult Publish(string name, string text)
        {
            wallContext.Posts.Add(new Post { Name = name, Text = text});
            wallContext.SaveChanges();

            return Json(new Post { Name = name, Text = text }, JsonRequestBehavior.AllowGet);
        }
    }
}