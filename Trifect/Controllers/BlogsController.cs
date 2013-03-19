using System.Web.Mvc;

namespace Trifect.Controllers
{
    public class BlogsController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}