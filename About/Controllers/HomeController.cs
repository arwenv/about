using System.Web.Mvc;

namespace About.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            ViewBag.Message = "Software developer. More content here.";
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Description of Arwen's site here.";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact information here.";
            return View();
        }

    }
}
