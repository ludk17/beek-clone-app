using BeekClone.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BeekClone.Web.ViewModels
{
    public class HomeViewModel
    {
        public List<Libro> Libros { get; set; }
        public List<UsuarioLibro> UsuarioLibros { get; set; }
    }
}