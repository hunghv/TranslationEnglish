using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EnglishTranslation.Models;
using ETran.Services.Services.Interfaces;
using ETran.Services.ViewModels.Request;

namespace EnglishTranslation.Controllers
{
    public class HomeController : Controller
    {
        #region Property

        private readonly IAdminServices _adminServices;

        #endregion

        #region Construture

        public HomeController(IAdminServices adminServices)
        {
            _adminServices = adminServices;
        }

        #endregion

        #region Action Result

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

        public ActionResult BaoGia()
        {
            BaoGiaViewModel model = new BaoGiaViewModel();
            model.Country = GetCountryItems();
            model.Source = GetSourceDestinationItems();
            model.Destination = GetSourceDestinationItems();
            model.MethodPay = GetMethodPayItems();
            model.UnitPay = GetUnitPayItems();
            model.Service = GetServicesItems();
            return View(model);
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

        #endregion

        #region Method

        private List<SelectListItem> GetCountryItems()
        {
            var lst = new List<SelectListItem>();
            lst.Add(new SelectListItem
            {
                Selected = false,
                Text = @"--Select--",
                Value = "0"
            });
            var query = _adminServices.GetCountry();
            if (query.Any())
            {
                foreach (var item in query)
                {
                    lst.Add(new SelectListItem
                    {
                        Selected = false,
                        Text = item.CountryName,
                        Value = item.Id.ToString()
                    });
                }

            }
            return lst;
        }
        private List<SelectListItem> GetSourceDestinationItems()
        {
            var lst = new List<SelectListItem>();
            lst.Add(new SelectListItem
            {
                Selected = false,
                Text = @"--Select--",
                Value = "0"
            });
            lst.Add(new SelectListItem
            {
                Selected = false,
                Text = @"Tiếng Anh",
                Value = "1"
            });
            lst.Add(new SelectListItem
            {
                Selected = false,
                Text = @"Tiếng Việt",
                Value = "2"
            });
            return lst;
        }
        private List<SelectListItem> GetUnitPayItems()
        {
            var lst = new List<SelectListItem>();
            lst.Add(new SelectListItem
            {
                Selected = false,
                Text = @"--Select--",
                Value = "0"
            });
            lst.Add(new SelectListItem
            {
                Selected = false,
                Text = @"USD",
                Value = "1"
            });
            lst.Add(new SelectListItem
            {
                Selected = false,
                Text = @"VND",
                Value = "2"
            });
            return lst;
        }
        private List<SelectListItem> GetMethodPayItems()
        {
            var lst = new List<SelectListItem>();
            lst.Add(new SelectListItem
            {
                Selected = false,
                Text = @"--Select--",
                Value = "0"
            });
            lst.Add(new SelectListItem
            {
                Selected = false,
                Text = @"E Banking",
                Value = "1"
            });
            lst.Add(new SelectListItem
            {
                Selected = false,
                Text = @"VND",
                Value = "Cash"
            });
            return lst;
        }
        private List<SelectListItem> GetServicesItems()
        {
            var lst = new List<SelectListItem>();
            lst.Add(new SelectListItem
            {
                Selected = false,
                Text = @"--Select--",
                Value = "0"
            });
            lst.Add(new SelectListItem
            {
                Selected = false,
                Text = @"Dịch thuật",
                Value = "1"
            });
            lst.Add(new SelectListItem
            {
                Selected = false,
                Text = @"Phiên dịch",
                Value = "2"
            });
            lst.Add(new SelectListItem
            {
                Selected = false,
                Text = @"Thu âm -Lồng tiếng",
                Value = "3"
            });
            lst.Add(new SelectListItem
            {
                Selected = false,
                Text = @"Dịch vụ khác",
                Value = "4"
            });
            return lst;
        }
        #endregion
    }
}