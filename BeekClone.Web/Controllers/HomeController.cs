using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BeekClone.Web.DataBase;

namespace BeekClone.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            var dbEntities = new DbEntities();
            var libros = dbEntities.Libros.Include("Autor").ToList();

            return View(libros);
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