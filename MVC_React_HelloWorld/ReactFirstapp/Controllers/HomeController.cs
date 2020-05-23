using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ReactFirstapp.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult getmessage()
        {
            return new JsonResult { Data = "Hello World. I am from server-side", JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }
    }
}
