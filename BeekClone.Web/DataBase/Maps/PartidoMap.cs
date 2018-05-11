using BeekClone.Web.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace BeekClone.Web.DataBase.Maps
{
    public class PartidoMap: EntityTypeConfiguration<Partido>
    {
        public PartidoMap()
        {
            ToTable("Partido");
            HasKey(o => o.PartidoId);

            HasRequired(o => o.EquipoLocal)
                .WithMany(o => o.PartidosLocal)
                .HasForeignKey(o => o.EquipoLocalId);

            HasRequired(o => o.EquipoVisitante)
                .WithMany(o => o.PartidosVisitante)
                .HasForeignKey(o => o.EquipoVisitanteId);

        }
    }
}