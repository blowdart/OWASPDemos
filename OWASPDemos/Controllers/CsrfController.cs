using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OWASPDemos.Controllers
{
    [Authorize]
    public class CsrfController : Controller
    {
        // GET: Csrf
        public ActionResult Index()
        {
            return View();
        }
    }
}