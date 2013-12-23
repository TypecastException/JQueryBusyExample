using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using JqueryBusyExample.Models;
using Newtonsoft.Json;
using System.Threading;

namespace JqueryBusyExample.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public JsonResult LongRunningDemoProcess(DemoViewModel model)
        {
            Thread.Sleep(1000);
            return Json(model, "json");

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