using AHCWebDeveloperExam.Helper;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AHCWebDeveloperExam.Controllers
{
    public class HomeController : Controller
    {
        static readonly IServerDataRestClient RestClient = new ServerDataRestClient();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Orders(string id)
        {
            if (id == null || id.Length == 0)
                return null;

            return View(RestClient.GetAll(id));
        }
    }
}