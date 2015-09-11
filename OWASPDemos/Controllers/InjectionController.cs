using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OWASPDemos.Controllers
{
    public class InjectionController : Controller
    {
        // GET: Injection
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string email, string password)
        {
            string query =
                string.Format(
                    CultureInfo.InvariantCulture,
                    "select count(*) from login where username='{0}' and password = '{1}'",
                    email,
                    password);

            ViewData["query"] = query;
            ViewData["email"] = email;
            ViewData["password"] = password;

            return View("Index");
        }
    }
}