using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BeekClone.Web.Models
{
    public class Usuario
    {
        public int Id { get; set; }

        public string Correo { get; set; }

        public string Password { get; set; }

        public List<UsuarioLibro> Libros { get; set; }
    }
}