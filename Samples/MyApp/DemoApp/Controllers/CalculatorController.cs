using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoApp.Controllers
{
    public class CalculatorController : Controller
    {
        // GET: Calculator
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult CalculateFromOtherApp()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CalculateFromOtherApp(string x,string y)
        {
            int X = Convert.ToInt32(x);
            int Y = Convert.ToInt32(y);
            CalculateReference.CalculateSoapClient WebService = new CalculateReference.CalculateSoapClient();
            //WebService.AddXMLWithParameters(x, y);error
            ViewBag.Result = WebService.AddXMLWithParameters(X, Y);
            return View();
        }
    }
}