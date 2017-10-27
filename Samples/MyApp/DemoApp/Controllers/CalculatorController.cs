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
        public ActionResult CalculateFromOtherApp()
        {
            CalculateReference.CalculateSoapClient CalculateWebServiceObj = new CalculateReference.CalculateSoapClient();
            //string Result = CalculateWebServiceObj.Add();error
            int AddResult = CalculateWebServiceObj.Add();
            int AddXMLResult = CalculateWebServiceObj.AddXML();
            //int AddXMLWithParametersResult = CalculateWebServiceObj.AddXMLWithParameters();error
            int AddXMLWithParametersResult = CalculateWebServiceObj.AddXMLWithParameters(123,123);

            return View();
        }
    }
}