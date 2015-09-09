using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OWASPDemos.Models;

namespace OWASPDemos.Controllers
{
    public class RedirectController : Controller
    {
        public ActionResult Good(int id)
        {
            string target;
            using (var context = new RedirectsContext())
            {
                target = context.Redirects.FirstOrDefault(r => r.ID == id).Uri;
            }

            if (string.IsNullOrEmpty(target))
            {
                return new HttpNotFoundResult();
            }

            return new RedirectResult(target);
        }

        public ActionResult Bad(string target)
        {
            return new RedirectResult(target);
        }
    }
}