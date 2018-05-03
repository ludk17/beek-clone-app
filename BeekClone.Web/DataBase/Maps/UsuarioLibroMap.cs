using BeekClone.Web.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace BeekClone.Web.DataBase.Maps
{
    public class UsuarioLibroMap : EntityTypeConfiguration<UsuarioLibro>
    {
        public UsuarioLibroMap()
        {
            ToTable("UsuarioLibro");
            HasKey(o => o.Id);
            

        }
        
    }
}