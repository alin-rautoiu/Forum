using Forum.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Forum.Controllers
{
    public class ThreadController : Controller
    {
        public ActionResult Index()
        {
            var discussions = new List<Discussion>
            {
                new Discussion {Id=Guid.NewGuid(), Title="Despre cocosi"},
                new Discussion {Id=Guid.NewGuid(), Title="Despre compostoare"}
            };
            return View(discussions);
        }

        public ActionResult See(Guid id)
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}