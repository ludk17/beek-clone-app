using BeekClone.Web.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace BeekClone.Web.DataBase.Maps
{
    public class LibroMap : EntityTypeConfiguration<Libro>
    {
        public LibroMap()
        {
            ToTable("Libro");
            HasKey(o => o.Id);

            Property(o => o.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity); // opcional si la base de datos no se crea desde código
            Property(o => o.Nombre).HasColumnName("Nombre"); // opcional

            HasRequired(o => o.Autor)
                .WithMany(o => o.Libros)
                .HasForeignKey(o => o.AutorId);

        }
        
    }
}