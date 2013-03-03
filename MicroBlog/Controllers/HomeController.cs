using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MicroLib.DataViewModel;

namespace MicroBlog.Controllers
{
    public class HomeController : Controller
    {
        MicroOperations.MicroOperations _MicroOperations = new MicroOperations.MicroOperations();
        RssFeeds _MainFeedData = new RssFeeds();

        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to ASP.NET MVC!";
            _MainFeedData = _MicroOperations.GetMainFeeds();
            return View(_MainFeedData);
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
