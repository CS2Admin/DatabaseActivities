using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DatabaseActivities.Controllers
{
    public class FirstController : Controller
    {
        // GET: First
        public ActionResult Index()
        {
            return View(viewName:"Index",model:"Hello");
        }

        [HttpPost]
        public ActionResult SayHello(string inputString)
        {
            return View(viewName: "Index", model: "Hello " + inputString);
        }

        public ActionResult Square()
        {
            return View("Square", 0.0);
        }

        [HttpPost]
        public ActionResult SquareNumber(double inputNumber)
        {
            return View("Square", inputNumber * inputNumber);
        }
    }
}