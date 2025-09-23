using Domain.Model;
using Data;
namespace Domain.Service;

public class ModuloUsuarioService
{
    public void Add(ModuloUsuario modus)
    {
        ModuloUsuarioInMemory.ModulosUsuarios.Add(modus);
    }


    public bool Delete(int id)
    {
        ModuloUsuario? modusToDelete = ModuloUsuarioInMemory.ModulosUsuarios.Find(x => x.Id == id);
        if (modusToDelete != null)
        {
            ModuloUsuarioInMemory.ModulosUsuarios.Remove(modusToDelete);
            return true;
        }
        else
        {
            return false;
        }
    }

    public ModuloUsuario Get(int id)
    {
        return ModuloUsuarioInMemory.ModulosUsuarios.FirstOrDefault(x => x.Id == id);
    }

    public IEnumerable<ModuloUsuario> GetAll()
    {
        return ModuloUsuarioInMemory.ModulosUsuarios.ToList();
    }

    public bool Update(ModuloUsuario moduloUs)
    {
        var modToUpdate = ModuloUsuarioInMemory.ModulosUsuarios.FirstOrDefault(x => x.Id == moduloUs.Id);
        if (modToUpdate != null)
        {
            modToUpdate.SetId(moduloUs.Id);
            modToUpdate.SetIdModulo(moduloUs.IdModulo);
            modToUpdate.SetIdUsuario(moduloUs.IdUsuario);
            modToUpdate.SetAlta(moduloUs.Alta);
            modToUpdate.SetBaja(moduloUs.Baja);
            modToUpdate.SetModificacion(moduloUs.Modificacion);
            modToUpdate.SetConsulta(moduloUs.Consulta);
            
            return true;
        }
        else
        {
            return false;
        }
    }
}