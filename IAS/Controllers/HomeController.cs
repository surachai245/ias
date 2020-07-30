using IAS.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace IAS.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //string uri = "http://localhost:8090/api/componant";
            //HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);
            //request.Method = "GET";

            //var webResponse = request.GetResponse();
            //var webStream = webResponse.GetResponseStream();
            //var responseReader = new StreamReader(webStream);
            //var response = responseReader.ReadToEnd();
            //responseReader.Close();
            var response = string.Empty;
            var personlModel = JsonConvert.DeserializeObject<List<PersonalViewModel>>(response);
            
            return View();
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