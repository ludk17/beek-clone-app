using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BeekClone.Web.Models
{
    public class Libro
    {
        public int Id { get; set; }

        public string Nombre { get; set; }

        public string Caratula { get; set; }

        public int AutorId { get; set; }

        public Autor Autor { get; set; }
    }
}