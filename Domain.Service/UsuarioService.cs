using Domain.Model;
using Data;

namespace Domain.Service
{
    
    public class UsuarioService
    {

        public void Add(Usuario per)
        {
            UsuarioInMemory.Usuarios.Add(per);
        }


        public bool Delete(int id)
        {
            Usuario? perToDelete = UsuarioInMemory.Usuarios.Find(x => x.Id == id);
            if (perToDelete != null)
            {
                UsuarioInMemory.Usuarios.Remove(perToDelete);
                return true;
            }
            else
            {
                return false;
            }
        }

        public Usuario Get(int id)
        {
            return UsuarioInMemory.Usuarios.FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<Usuario> GetAll()
        {
            return UsuarioInMemory.Usuarios.ToList();
        }

        public bool Update(Usuario usuario)
        {
            var UsuarioToUpdate = UsuarioInMemory.Usuarios.FirstOrDefault(x => x.Id == usuario.Id);
            if (UsuarioToUpdate != null)
            {
                UsuarioToUpdate.SetNombre(usuario.NombreUsuario);
                UsuarioToUpdate.SetClave(usuario.Clave);
                UsuarioToUpdate.SetHabilitado(usuario.Habilitado);
                UsuarioToUpdate.SetCambiaClave(usuario.CambiaClave);
                UsuarioToUpdate.SetIdPersona(usuario.IdPersona);
            
            
        
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
