
using System.Net;
using System.Web.Mvc;

namespace OWASPDemos.Controllers
{
    public class MissingAccessControlController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult SecretThing()
        {
            return View();
        }

        public ActionResult Protected()
        {
            return View();
        }

        public ActionResult ProtectedSecretThing()
        {
            // Check access control
            if (User.Identity.IsAuthenticated)
            {
                return View();
            }
            else
            {
                return new HttpStatusCodeResult(HttpStatusCode.Forbidden);
            }
        }
    }
}