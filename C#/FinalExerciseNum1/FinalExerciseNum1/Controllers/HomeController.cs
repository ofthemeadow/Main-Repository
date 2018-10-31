using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FinalExerciseNum1.Models;
using FinalExerciseNum1.DAL;

namespace FinalExerciseNum1.Controllers
{
    public class HomeController : Controller
    {
        private PersonContext db = new PersonContext();



        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "My name is Steffan del Prado.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "My email address is:";

            return View();
        }
    }
}