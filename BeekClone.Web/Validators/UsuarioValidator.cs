using BeekClone.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Mvc;
using BeekClone.Web.DataBase;

namespace BeekClone.Web.Validators
{
    public class UsuarioValidator
    {
        private DbEntities db;
        private ModelStateDictionary modelState;

        public UsuarioValidator(ModelStateDictionary modelState, DbEntities db)
        {
            this.modelState = modelState;
            this.db = db;
        }

        public void EjecutarValiciones(Usuario usuario)
        {
            if(string.IsNullOrEmpty(usuario.Correo))
                modelState.AddModelError("Correo", "El Correo Electrónico es obligatorio");

            if (!string.IsNullOrEmpty(usuario.Correo) && Regex.Match(usuario.Correo, @"^[a-zA-Z]+@[a-zA-Z]+[.]{1}[a-zA-Z]{2,3}$").Success)
                modelState.AddModelError("Correo", "El Correo Electrónico no tiene un formato válido");


            if(db.Usuarios.Where(o => o.Correo == usuario.Correo).Count() > 0)
                modelState.AddModelError("Correo", "El Correo Electrónico ya existe");

            if (string.IsNullOrEmpty(usuario.Password))
                modelState.AddModelError("Password", "El Password es obligatorio");
        }
    }
}