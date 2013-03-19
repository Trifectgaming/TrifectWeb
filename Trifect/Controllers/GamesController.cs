using System.Web.Mvc;

namespace Trifect.Controllers
{
    public class GamesController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Get()
        {
            return View();
        }
    }
}