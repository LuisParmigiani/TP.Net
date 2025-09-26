using Domain.Model;
using Microsoft.EntityFrameworkCore;
using System.Data.SqlClient;    

namespace Data
{
    public class UsuarioRepository
    {
        private TPIContext CreateContext()
        {
            return new TPIContext();
        }

        public void Add(Usuario usuario)
        {
            using var context = CreateContext();
            if (context.Personas.Any(p => p.Id == usuario.IdPersona) != true)
            {
                throw new Exception("No se encontró una persona con el ID ingresado");
            }
            context.Usuarios.Add(usuario);
            context.SaveChanges();
        }
        
        public bool Delete(int id)
        {
            using var context = CreateContext();
            var user = context.Usuarios.Find(id);
            if (user != null)
            {
                context.Usuarios.Remove(user);
                context.SaveChanges();
                return true;
            }
            return false;
        }
        public Usuario? Get(int id)
        {
            using var context = CreateContext();
            var usuario = context.Usuarios.Find(id);
            return usuario;
        }
        public IEnumerable<Usuario> GetAll()
        {
            using var context = CreateContext();
            return context.Usuarios.ToList();
        }
        public bool Update(Usuario usuario)
        {
            using var context = CreateContext();
            var userExist = context.Usuarios.Find(usuario.Id);
            if (userExist != null)
            {
                userExist.SetNombre(usuario.NombreUsuario);
                if (context.Personas.Any(p => p.Id == usuario.IdPersona) != true)
                {
                    throw new Exception("No se encontró una persona con el ID ingresado");
                }
                userExist.SetIdPersona(usuario.IdPersona);
                userExist.SetCambiaClave(usuario.CambiaClave);
                userExist.SetClave(usuario.Clave);
                userExist.SetHabilitado(usuario.Habilitado);
                context.SaveChanges();
                return true;
            }

            return false;
        }
        //Puede que en un futuro tengamos más 
        public Usuario? Login(string username, string password)
        {
            using var context = CreateContext();
            var us = context.Usuarios.First(u=> u.NombreUsuario == username);
            if (us != null)
            {
                if (us.NombreUsuario == username && us.Clave == password)
                {
                    return us;
                }
                else
                {
                    throw new Exception("Contraseña incorrecta");
                }
            }
            else
            {

                throw new Exception("No se encontró un usuario con ese nombre");
            }
        }
    }
}