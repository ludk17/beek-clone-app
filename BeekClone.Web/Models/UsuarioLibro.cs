using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BeekClone.Web.Models
{
    public class UsuarioLibro
    {
        public int Id { get; set; }

        public int UsuarioId { get; set; }

        public int LibroId { get; set; }


        public Usuario Usuario { get; set; }

    }
}