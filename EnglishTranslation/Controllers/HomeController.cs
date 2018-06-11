using System.Web.Mvc;
using EnglishTranslation.Models;
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
            if (!ModelState.IsValid)
            {
                return View();
            }
            else
            {
                return View();
            }
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

        public ActionResult SaveContact(ContactViewModelDis model)
        {
            var entity = new ContactViewModel
            {
                Phone = model.UserPhone,
                Name = model.UserName,
                Subject = model.UserMsg,
                Email = model.UserEmail,
                IsSendMail = true
            };
            var result = _adminServices.SaveContact(entity);
            if (result == 0)
            {
                return View("Contact");
            }
            else
            {
                return View("Index");
            }
           
        }
    }
}