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

        // Seriously bad and dumb code follows.
        public ActionResult Download(string filePath)
        {
            string actualPath = HostingEnvironment.MapPath(filePath);
            byte[] fileBytes = System.IO.File.ReadAllBytes(actualPath);
            string fileName = Path.GetFileName(filePath);
            return File(fileBytes, System.Net.Mime.MediaTypeNames.Application.Octet, fileName);
        }
    }
}