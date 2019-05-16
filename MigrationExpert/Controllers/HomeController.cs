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
             
            ViewBag.NameD = FormData.Surname ?? " ";
            ViewBag.NameP = FormData.Name;
            return View("Index1");
        }

    }
}