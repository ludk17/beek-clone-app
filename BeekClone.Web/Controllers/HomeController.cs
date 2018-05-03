using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BeekClone.Web.DataBase;
using BeekClone.Web.ViewModels;

namespace BeekClone.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            var dbEntities = new DbEntities();

            var viewmodel = new HomeViewModel();

            viewmodel.Libros = dbEntities.Libros.Include("Autor").ToList();

            viewmodel.UsuarioLibros = dbEntities.UsuarioLibros.Where(o => o.UsuarioId == 1).ToList();

            return View(viewmodel);
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