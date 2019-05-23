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
            ViewBag.RegDocumentSeries = FormData.RegDocumentSeries?.ToUpper() ?? " ";
            ViewBag.RegDocumentNumber = FormData.RegDocumentNumber?.ToUpper() ?? " ";
            ViewBag.RegDocumentDateOfIssue = FormData.RegDocumentDateOfIssue;
            ViewBag.RegDocumentDateOfExpiration = FormData.RegDocumentDateOfExpiration;
            ViewBag.YourVisitPurpose = FormData.YourVisitPurpose.ToString() ?? "tourism";
            ViewBag.profession = FormData.Profession?.ToString() ?? " ";
            ViewBag.ArrivalDate = FormData.ArrivalDate;
            ViewBag.DepartureDate = FormData.DepartureDate;
            ViewBag.MigrationCardSeries = FormData.MigrationCardSeries?.ToString() ?? " ";
            ViewBag.MigrationCardNumber = FormData.MigrationCardNumber?.ToString() ?? " ";

            // Отрывная часть 1 листа
            ViewBag.ArrivalRegion = FormData.ArrivalRegion?.ToUpper() ?? " ";
            ViewBag.ArrivalArea = FormData.ArrivalArea?.ToUpper() ?? " ";
            ViewBag.ArrivalCity = FormData.ArrivalCity?.ToUpper() ?? " ";
            ViewBag.ArrivalStreet = FormData.ArrivalStreet?.ToUpper() ?? " ";
            ViewBag.ArrivalHouse = FormData.ArrivalHouse?.ToUpper() ?? " ";
            ViewBag.ArrivalHouseNumber = FormData.ArrivalHouseNumber?.ToUpper() ?? " ";
            ViewBag.ArrivalHousingNumber = FormData.ArrivalHousingNumber?.ToUpper() ?? " ";
            ViewBag.ArrivalBuildingNumber = FormData.ArrivalBuildingNumber?.ToUpper() ?? " ";
            ViewBag.ArrivalRoomType = FormData.ArrivalRoomType?.ToUpper() ?? " ";
            ViewBag.ArrivalRoomNumber = FormData.ArrivalRoomNumber?.ToString() ?? " ";


            return View("Index1");
        }

    }
}