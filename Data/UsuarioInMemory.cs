using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Model;

namespace Data
{
    public class UsuarioInMemory
    {
        public static List<Usuario> Usuarios;

        static UsuarioInMemory()
        {
            Usuarios = new List<Usuario>
            {
                new Usuario(1,"Agustin","Ref123..",true,false,1)
            };
        }
    }
}