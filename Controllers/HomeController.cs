using System.Web.Mvc;
using Lab21.DAL;

namespace Lab21.Controllers
{
    public class HomeController : Controller
    {
        private readonly PersonContext _context = new PersonContext();
        public ActionResult Index()
        {
            var items = _context.Items;
            return View(items);
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