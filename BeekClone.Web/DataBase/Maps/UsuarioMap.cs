using BeekClone.Web.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace BeekClone.Web.DataBase.Maps
{
    public class UsuarioMap : EntityTypeConfiguration<Usuario>
    {
        public UsuarioMap()
        {
            ToTable("Usuario");
            HasKey(o => o.Id);

            HasMany(o => o.Libros)
                .WithRequired(o => o.Usuario)
                .HasForeignKey(o => o.UsuarioId);
        }
        
    }
}