using BeekClone.Web.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace BeekClone.Web.DataBase.Maps
{
    public class EquipoMap: EntityTypeConfiguration<Equipo>
    {
        public EquipoMap()
        {
            ToTable("Equipo");
            HasKey(o => o.EquipoId);

        }
    }
}