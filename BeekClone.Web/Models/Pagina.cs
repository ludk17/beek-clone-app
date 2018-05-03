using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BeekClone.Web.Models
{
    public class Pagina
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Url { get; set; }
        public string Descripcion { get; set; }
        public string Fecha { get; set; }
        public string Imagen { get; set; }
        public string Parrafo1 { get; set; }
        public string Parrafo2 { get; set; }
    }
}