using Domain.Model;
using Data;
using DTOs;

namespace Domain.Service
{
    
    public class UsuarioService
    {

        public void Add(UsuarioDTO user)
        {
            var usuarioRepository = new UsuarioRepository();
            Modulo mod = new Modulo(0,modulo.Descripcion,modulo.Ejecuta);
            moduloRepository.Add(mod);

            modulo.Id = mod.Id;

            return modulo;
        }


        public bool Delete(int id)
        {
            Usuario? perToDelete = UsuarioRepository.Usuarios.Find(x => x.Id == id);
            if (perToDelete != null)
            {
                UsuarioRepository.Usuarios.Remove(perToDelete);
                return true;
            }
            else
            {
                return false;
            }
        }

        public Usuario Get(int id)
        {
            return UsuarioRepository.Usuarios.FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<Usuario> GetAll()
        {
            return UsuarioRepository.Usuarios.ToList();
        }

        public bool Update(Usuario usuario)
        {
            var UsuarioToUpdate = UsuarioRepository.Usuarios.FirstOrDefault(x => x.Id == usuario.Id);
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
