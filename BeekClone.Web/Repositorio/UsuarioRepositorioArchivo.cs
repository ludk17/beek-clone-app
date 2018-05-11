using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BeekClone.Web.Models;
using System.IO;
using System.Text;
using BeekClone.Web.Interfaces;

namespace BeekClone.Web.Repositorio
{
    public class UsuarioRepositorioArchivo : IUsuarioRepositorio
    {
        public List<Usuario> All()
        {
            string path = @"C:\Users\Luigui Mendoza\Documents\Visual Studio 2015\Projects\BeekClone.Web\BeekClone.Web\data\basedatos.txt";
            var usuarios = new List<Usuario>();
            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    string s = "";
                    while ((s = sr.ReadLine()) != null)
                    {
                        usuarios.Add(new Usuario
                        {
                            Id = int.Parse(s.Split(';')[0]),
                            Correo = s.Split(';')[1]
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return usuarios;
        }

        public void Guardar(Usuario usuario)
        {
            string path = @"C:\Users\Luigui Mendoza\Documents\Visual Studio 2015\Projects\BeekClone.Web\BeekClone.Web\data\basedatos.txt";

            try
            {   
                using (StreamWriter sw = File.AppendText(path))
                {
                    var data = "\n" + usuario.Id + ";" + usuario.Correo;
                    sw.WriteLine(data);
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}