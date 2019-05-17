using MigrationExpert.Models;
using System;
using System.Linq;
using System.Web.Mvc;
 

namespace MigrationExpert.Controllers
{
    public class HomeController : Controller
    {

        // GET: Home
        public ActionResult Index1()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Index()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Index(FormN FormData)
        {
             
            ViewBag.NameD = FormData.Surname.ToUpper() ?? " ";
            ViewBag.NameP = FormData.Name.ToUpper();
            ViewBag.CitizenShip = FormData.Citizenship.ToUpper();
            ViewBag.DateofBirth = FormData.DateOfBirth;
            return View("Index1");
        }

    }
}