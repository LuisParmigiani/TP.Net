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
            context.Modulos.Add(usuario);
            context.SaveChanges();
        }
    }
}