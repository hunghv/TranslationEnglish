using System.Web.Mvc;
using ETran.Services.Services.Interfaces;
using ETran.Services.ViewModels.Request;

namespace EnglishTranslation.Controllers
{
    public class HomeController : Controller
    {
        private readonly IAdminServices _adminServices;

        public HomeController(IAdminServices adminServices)
        {
            _adminServices = adminServices;
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

        public ActionResult Services()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Commtor()
        {
            return View();
        }

        public ActionResult SaveContact(ContactViewModel model)
        {
            var result = _adminServices.SaveContact(model);
            return Json(result, JsonRequestBehavior.AllowGet);
        }
    }
}