using BeekClone.Web.DataBase;
using BeekClone.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Mvc;

namespace BeekClone.Web.Controllers
{
    public class RegistroController : Controller
    {
        private DbEntities db; 

        public RegistroController()
        {
            db = new DbEntities();
        }

        // GET: Registro
        public ActionResult Crear()
        {
            return View(new Usuario());
        }

        [HttpPost]
        public ActionResult Crear(Usuario usuario)
        {
            ValidarUsuario(usuario);

            if (ModelState.IsValid)
            {
                db.Usuarios.Add(usuario);
                db.SaveChanges();
                return RedirectToAction("Index", "Home");
            }

            return View("Crear", usuario);
            
        }

        private void ValidarUsuario(Usuario usuario)
        {

            if(string.IsNullOrEmpty(usuario.Correo))
                ModelState.AddModelError("Correo", "El Correo Electrónico es obligatorio");

            if (!Regex.Match(usuario.Correo, @"^[a-zA-Z]+@[a-zA-Z]+[.]{1}[a-zA-Z]{2,3}$").Success)
                ModelState.AddModelError("Correo", "El Correo Electrónico no tiene un formato válido");


            if(db.Usuarios.Where(o => o.Correo == usuario.Correo).Count() > 0)
                ModelState.AddModelError("Correo", "El Correo Electrónico ya existe");

            if (string.IsNullOrEmpty(usuario.Password))
                ModelState.AddModelError("Password", "El Password es obligatorio");
        }

        // GET: Registro
        public ActionResult Editar(int id)
        {
            var usuario = db.Usuarios.FirstOrDefault(o => o.Id == 1);

            return View(usuario);
        }


        [HttpPost]
        
        public ActionResult Editar(Usuario usuarioFrm)
        {
            
            Usuario usuarioDb = db.Usuarios.Where(o => o.Id == usuarioFrm.Id).FirstOrDefault();
            usuarioDb.Correo = usuarioFrm.Correo;

            db.SaveChanges();

            return RedirectToAction("Index", "Home");

        }

        private void Eliminar()
        {
            Usuario usuarioDb = db.Usuarios.Where(o => o.Id == 1).FirstOrDefault();

            db.Usuarios.Remove(usuarioDb);

            db.SaveChanges();
        }

        
    }
}