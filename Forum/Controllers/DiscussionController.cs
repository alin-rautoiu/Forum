using Forum.DataAccess;
using Forum.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Forum.Controllers
{
    public class DiscussionController : Controller
    {
        private readonly IDiscussionStore discussionStore;
        public DiscussionController(IDiscussionStore discussionStore)
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


    }
}