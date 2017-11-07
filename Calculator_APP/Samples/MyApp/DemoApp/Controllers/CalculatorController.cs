using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoApp.Controllers
{
    public class CalculatorController : Controller
    {
        //create object of proxy class
        CalculateReference.CalculateSoapClient WebService = new CalculateReference.CalculateSoapClient();
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
            //WebService.AddXMLWithParameters(x, y);error
            ViewBag.Result = WebService.AddWithSession(X, Y);
            List<string> PreviosOperationsList = WebService.GetAllAddOperations();
            ViewBag.PreviosOperations = PreviosOperationsList;
            return View();
        }

        [HttpGet]
        public ActionResult CalculateFromOtherApp_WithAjax()
        {
            return View();
        }

        
        public PartialViewResult Calculate_WithAjax(string x, string y)
        {
            int X = Convert.ToInt32(x);
            int Y = Convert.ToInt32(y);
            //WebService.AddXMLWithParameters(x, y);error
            ViewBag.Result = WebService.AddWithSession(X, Y);
            List<string> PreviosOperationsList = WebService.GetAllAddOperations();
            ViewBag.PreviosOperations = PreviosOperationsList;
            return PartialView("Calculate_WithAjax");
        }

    }
}