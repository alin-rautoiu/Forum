using Forum.DataAccess;
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
        private readonly IDiscussionStore discussionStore;
        public ThreadController(IDiscussionStore discussionStore)
        {
            this.discussionStore = discussionStore;
        }

        public ActionResult Index()
        {
            var discussions = discussionStore.All();
            return View(discussions);
        }

        public ActionResult See(Guid id)
        {
            var discussion = discussionStore.Get(id);
            return View(discussion);
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