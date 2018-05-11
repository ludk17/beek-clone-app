using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BeekClone.Web.Models
{
    public class Partido
    {

        public int PartidoId { get; set; }

        public int EquipoLocalId { get; set; }

        public int EquipoVisitanteId { get; set; }

        public DateTime Fecha { get; set; }

        public Equipo EquipoLocal { get; set; }

        public Equipo EquipoVisitante { get; set; }
    }
}