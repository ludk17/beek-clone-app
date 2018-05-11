using BeekClone.Web.DataBase;
using BeekClone.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Mvc;
using BeekClone.Web.Validators;
using BeekClone.Web.Repositorio;
using BeekClone.Web.Servicios;
using BeekClone.Web.Interfaces;

namespace BeekClone.Web.Controllers
{
    public class RegistroController : Controller
    {
        private DbEntities db;

        private UsuarioValidator validator;
        private IUsuarioRepositorio repositorio;
        private EmailSender email;

        public RegistroController(IUsuarioRepositorio repositorio)
        {
            db = new DbEntities();
            validator = new UsuarioValidator(ModelState, db);
            this.repositorio = repositorio;
            email = new EmailSender();
        }

        public ActionResult Listar()
        {
            return View();
        }

        // GET: Registro
        public ActionResult Crear()
        {
            return View(new Usuario());
        }

        [HttpPost]
        public ActionResult Crear(Usuario usuario)
        {
            validator.EjecutarValiciones(usuario);

            if (ModelState.IsValid)
            {
                repositorio.Guardar(usuario);
                email.Send(usuario.Correo, "Bienvenido", GetLink());
                return RedirectToAction("Index", "Home");
            }

            return View("Crear", usuario);
            
        }

        private string GetLink()
        {
            return "<a href='#'>Haz clic aqui para activar tu cuente</a>";
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