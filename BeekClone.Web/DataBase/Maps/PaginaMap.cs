using BeekClone.Web.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace BeekClone.Web.DataBase.Maps
{
    public class PaginaMap: EntityTypeConfiguration<Pagina>
    {
        public PaginaMap()
        {
            ToTable("Pagina");
            HasKey(o => o.Id);
        }
    }
}