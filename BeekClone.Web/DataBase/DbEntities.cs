using BeekClone.Web.DataBase.Maps;
using BeekClone.Web.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BeekClone.Web.DataBase
{
    public class DbEntities: DbContext
    {
        public IDbSet<Libro> Libros { get; set; }
        public IDbSet<Autor> Autores { get; set; }
        public IDbSet<Usuario> Usuarios { get; set; }
        public IDbSet<UsuarioLibro> UsuarioLibros { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.Add(new LibroMap());
            modelBuilder.Configurations.Add(new AutorMap());
            modelBuilder.Configurations.Add(new UsuarioMap());
            modelBuilder.Configurations.Add(new UsuarioLibroMap());
        }
    }
}