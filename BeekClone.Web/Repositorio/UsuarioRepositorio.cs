using BeekClone.Web.DataBase;
using BeekClone.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BeekClone.Web.Repositorio
{
    public class UsuarioRepositorio
    {
        private DbEntities db;

        public UsuarioRepositorio()
        {
            db = new DbEntities();
        }

        public void Guardar(Usuario usuario)
        {
            db.Usuarios.Add(usuario);
            db.SaveChanges();
        }

    }
}