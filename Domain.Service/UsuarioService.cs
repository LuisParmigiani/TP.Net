using Domain.Model;
using Data;
using DTOs;

namespace Domain.Service
{
    
    public class UsuarioService
    {

        public UsuarioDTO Add(UsuarioDTO user)
        {
            var usuarioRepository = new UsuarioRepository();
            Usuario us = new Usuario(0,user.NombreUsuario,user.Clave,user.Habilitado,user.CambiaClave,user.IdPersona);
            try
            {
                usuarioRepository.Add(us);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            user.Id = us.Id;

            return user;
        }


        public bool Delete(int id)
        {
            var usuaRepository = new UsuarioRepository();
            return usuaRepository.Delete(id);
        }

        public UsuarioDTO Get(int id)
        {
            var usRepository = new UsuarioRepository();
            Usuario? usuario = usRepository.Get(id);
            if (usuario == null)
                return null;
            return new UsuarioDTO(
                usuario.Id,
                usuario.NombreUsuario,
                usuario.Clave,
                usuario.Habilitado,
                usuario.IdPersona,
                usuario.CambiaClave
                );
        }

        public IEnumerable<UsuarioDTO> GetAll()
        {
            var usRepo = new UsuarioRepository();
            return usRepo.GetAll().Select(usuario => new UsuarioDTO(
                usuario.Id,
                usuario.NombreUsuario,
                usuario.Clave,
                usuario.Habilitado,
                usuario.IdPersona,
                usuario.CambiaClave
            )).ToList();
        }

        public bool Update(UsuarioDTO usuario)
        {
            var usRepo = new UsuarioRepository();
            try
            {
                Usuario us = new Usuario(usuario.Id, usuario.NombreUsuario, usuario.Clave, usuario.Habilitado,
                    usuario.CambiaClave, usuario.IdPersona);
                return usRepo.Update(us);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            
        }

        public UsuarioDTO Login(string username, string password)
        {
            var usRepo = new UsuarioRepository();
            try
            {
                
                Usuario? user = usRepo.Login(username, password);
                UsuarioDTO usuarioDevuelto = new UsuarioDTO(
                    user.Id,
                    user.NombreUsuario,
                    user.Clave,
                    user.Habilitado,
                    user.IdPersona,
                    user.CambiaClave
                );
                return usuarioDevuelto;

            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
