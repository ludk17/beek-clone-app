using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BeekClone.Web.Models
{
    public class Equipo
    {
        public int EquipoId { get; set; }

        public string Nombre { get; set; }

        public IList<Partido> PartidosLocal { get; set; }

        public IList<Partido> PartidosVisitante { get; set; }
    }
}