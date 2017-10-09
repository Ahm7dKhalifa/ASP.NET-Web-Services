using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Services;
using System.Web.Services;

namespace MyApp
{
    /// <summary>
    /// Summary description for Calculate
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    [System.Web.Script.Services.ScriptService]
    public class Calculate : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }
        /*#########################################
               xml 
        ###########################################*/
        //1.1 normal method
        [WebMethod]
        public int Add()
        {
            return 10 + 10;
        }
        //1.2 add method with xml Serialization
        [WebMethod]
        [System.Xml.Serialization.XmlInclude(typeof(int))]
        public int AddXML()
        {
            int Result = 10 + 10;
            return Result;
        }
        //1.3 add method with xml Serialization and parameters
        [WebMethod]
        [System.Xml.Serialization.XmlInclude(typeof(int))]
        public int AddXMLWithParameters(int x,int y)
        {
            int Result = x + y;
            return Result;
        }
        //1.3 add method with xml Serialization and parameters
        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Xml)]
        public int AddXMLWithParameters2(int x, int y)
        {
            int Result = x + y;
            return Result;
        }
        /*########################################
         *  JSON 
         * ######################################*/
        //2.1 
        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public int AddWithJSON()
        {
            int Result = 10 + 10;
            return Result;
        }
        //2.2 
        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public int AddWithJSONWithParameters(int x,int y)
        {
            int Result = x + y;
            return Result;
        }
    }
}
