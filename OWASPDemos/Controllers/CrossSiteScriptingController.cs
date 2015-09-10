using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OWASPDemos.Controllers
{
    public class CrossSiteScriptingController : Controller
    {
        public ActionResult Index()
        {
            var secretCookie = new HttpCookie("secret", "omgyoucantseethis");
            Response.Cookies.Add(secretCookie);
            return View();
        }
    }
};