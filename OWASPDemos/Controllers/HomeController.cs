using System.IO;
using System.Web.Hosting;
using System.Web.Mvc;

namespace OWASPDemos.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Throw()
        {
            throw new System.Exception("Something horrible went wrong with the following encryption key...");
        }
    }
}