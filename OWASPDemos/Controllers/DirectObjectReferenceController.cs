using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using OWASPDemos.Models;

namespace OWASPDemos.Controllers
{
    [Authorize]
    public class DirectObjectReferenceController : Controller
    {
        public ActionResult Index(int id=0)
        {
            using (var context = new MessagesContext())
            {
                var model = (from m in context.Messages where m.Id == id select m).SingleOrDefault();

                if (model == null)
                {
                    return new HttpNotFoundResult();
                }

                return View(model);
            }
        }

        public ActionResult Protected(int id = 0)
        {
            using (var context = new MessagesContext())
            {
                var model = (from m in context.Messages where m.Id == id select m).SingleOrDefault();

                if (model == null)
                {
                    return new HttpNotFoundResult();
                }

                if (model.To != User.Identity.Name)
                {
                    return new HttpStatusCodeResult(HttpStatusCode.Forbidden);
                }

                return View("Index", model);
            }
        }
    }
}