namespace WebApp.Controllers
{
    using System.Web.Mvc;

    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to ASP.NET MVC! This is an awesome application";

            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}