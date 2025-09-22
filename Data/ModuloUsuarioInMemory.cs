namespace Data;
using Domain.Model;

public static class ModuloUsuarioInMemory
{
    public static List<ModuloUsuario> ModulosUsuarios;

    static ModuloUsuarioInMemory()
    {
        ModulosUsuarios = new List<ModuloUsuario>
        {
            new ModuloUsuario(1,1,1,true,false,false,false)
        };
    }
 
}