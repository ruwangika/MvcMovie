using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMovie.Controllers
{
    public class HelloController : Controller
    {
        //
        // GET: /Hello/

        public ActionResult Index()
        {
            return View();
        }

//        public string Index() {
//            return "This is my <b>default</b> action...";
//        }
        public ActionResult Welcome(string name, int numTimes = 1) {
//            return HttpUtility.HtmlEncode("Hello " + name + ", NumTimes is: " + numTimes);
            ViewBag.Message = "Hello " + name;
            ViewBag.NumTimes = numTimes;

            return View();
        }

    }
}
