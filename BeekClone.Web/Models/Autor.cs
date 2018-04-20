using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BeekClone.Web.Models
{
    public class Autor
    {
        public int Id { get; set; }

        public string Nombre { get; set; }

        public IList<Libro> Libros { get; set; }
    }
}