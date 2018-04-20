using BeekClone.Web.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace BeekClone.Web.DataBase.Maps
{
    public class AutorMap: EntityTypeConfiguration<Autor>
    {
        public AutorMap()
        {
            ToTable("Autor");
            HasKey(o => o.Id);

//            HasMany(o => o.Libros)
//                .WithRequired(o => o.Autor)
//                .HasForeignKey(o => o.AutorId);
        }
    }
}