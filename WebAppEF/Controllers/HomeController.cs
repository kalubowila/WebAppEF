using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppEF.Core.Core;
using WebAppEF.Core.InterfaceCore;
using WebAppEF.Model.Entity;

namespace WebAppEF.Controllers
{
    public class HomeController : Controller
    {
        private readonly IGenericService _genericService;
        public HomeController()
        {
            _genericService = new GenericService();
        }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            List<EnrollmentDateGroup> enrollmentList = _genericService.GetEnrollmentDateGroup();

            return View(enrollmentList);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}