using BeekClone.Web.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BeekClone.Web.Models;

namespace BeekClone.Web.Controllers
{
    public class UsuarioController : Controller
    {
        private DbEntities db;

        public UsuarioController()
        {
            db = new DbEntities();
            ;
        }

        // GET: Usuario
        [HttpPost]
        public ActionResult Marcar(int libro)
        {
            db.UsuarioLibros.Add(new UsuarioLibro
            {
                LibroId = libro,
                UsuarioId = 1,
            });

            db.SaveChanges();

            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        public ActionResult remover(int libro)
        {
            var libroU = db.UsuarioLibros.Where(o => o.LibroId == libro && o.UsuarioId == 1).FirstOrDefault();
            db.UsuarioLibros.Remove(libroU);

            db.SaveChanges();

            return RedirectToAction("Index", "Home");
        }
    }
}