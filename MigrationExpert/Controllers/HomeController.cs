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
            ViewBag.NameD = FormData.Surname?.ToUpper() ?? " ";
            ViewBag.NameP = FormData.Name?.ToUpper() ?? " ";
            ViewBag.CitizenShip = FormData.Citizenship?.ToUpper() ?? " ";
            ViewBag.DateofBirth = FormData.DateOfBirth;
            ViewBag.PGender = FormData.YourGender.ToString() ?? "male";
            ViewBag.CountryOfBirth = FormData.CountryOfBirth?.ToUpper() ?? " ";
            ViewBag.CityOfBirth = FormData.CityOfBirth?.ToUpper() ?? " ";
            ViewBag.PersonalDocumentSeries = FormData.PersonalDocumentSeries?.ToUpper() ?? " ";
            ViewBag.PersonalDocumentType = FormData.PersonalDocumentType?.ToUpper() ?? " ";
            ViewBag.PersonalDocumentNumber = FormData.PersonalDocumentNumber?.ToUpper() ?? " ";
            ViewBag.PersonalDocumentDateOfIssue = FormData.PersonalDocumentDateOfIssue;
            ViewBag.PersonalDocumentDateOfExpiration = FormData.PersonalDocumentDateOfExpiration;
            ViewBag.YourVisa = FormData.YourVisa.ToString() ?? "visa";
            return View("Index1");
        }

    }
}