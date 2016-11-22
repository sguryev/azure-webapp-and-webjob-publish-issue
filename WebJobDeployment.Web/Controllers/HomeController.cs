using System.Web.Mvc;

namespace WebJobDeployment.Web.Controllers
{
    using Services;

    public class HomeController : Controller
    {
        private TestService _testService;

        public HomeController()
        {
            _testService = new TestService();
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}