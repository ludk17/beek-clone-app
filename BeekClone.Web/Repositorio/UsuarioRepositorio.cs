using BeekClone.Web.DataBase;
using BeekClone.Web.Interfaces;
using BeekClone.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BeekClone.Web.Repositorio
{
    public class UsuarioRepositorio: IUsuarioRepositorio
    {
        private DbEntities db;

        public UsuarioRepositorio()
        {
            db = new DbEntities();
        }


        public List<Usuario> All()
        {
            return db.Usuarios.ToList();
        }

        public void Guardar(Usuario usuario)
        {
            db.Usuarios.Add(usuario);
            db.SaveChanges();
        }

    }
}