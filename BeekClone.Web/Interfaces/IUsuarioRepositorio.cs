using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BeekClone.Web.Models;

namespace BeekClone.Web.Interfaces
{
    public interface IUsuarioRepositorio
    {
        List<Usuario> All();
        void Guardar(Usuario usuario);
    }
}
